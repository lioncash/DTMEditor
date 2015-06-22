using System;
using System.Collections.Generic;
using System.IO;

namespace DTMEditor.FileHandling
{
	/// <summary>
	/// Dolphin Movie File.
	/// </summary>
	public sealed class DTM
	{
		#region Constructor

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="filename">Path to the DTM movie file.</param>
		public DTM(string filename)
		{
			if (filename == null)
				throw new ArgumentNullException("filename");

			if (!File.Exists(filename))
				throw new FileNotFoundException("Specified file does not exist.", filename);

			FilePath = filename;
			ControllerData = new List<DTMControllerDatum>();

			using (var reader = new BinaryReader(File.OpenRead(filename)))
			{
				byte[] fileMagic = reader.ReadBytes(4);
				if (!IsValidHeaderID(fileMagic))
					throw new InvalidDTMHeaderException("Invalid file: Header magic is incorrect.");

				GameID = reader.ReadBytes(6);
				IsWiiGame = reader.ReadBoolean();
				ConnectedControllers = reader.ReadByte();
				IsFromSaveState = reader.ReadBoolean();
				FrameCount = reader.ReadUInt64();
				InputFrameCount = reader.ReadUInt64();
				LagFrameCount = reader.ReadUInt64();
				UniqueID = reader.ReadUInt64();
				NumRerecords = reader.ReadUInt32();
				Author = reader.ReadBytes(32);
				VideoBackend = reader.ReadBytes(16);
				AudioEmulator = reader.ReadBytes(16);
				MD5 = reader.ReadBytes(16);
				RecordingStartTime = reader.ReadUInt64();
				IsSavedConfig = reader.ReadBoolean();
				UsingIdleSkip = reader.ReadBoolean();
				UsingDualCore = reader.ReadBoolean();
				UsingProgressiveScan = reader.ReadBoolean();
				UsingHLEDSP = reader.ReadBoolean();
				UsingFastDiscSpeed = reader.ReadBoolean();
				CPUCore = reader.ReadByte();
				IsEFBAccessEnabled = reader.ReadBoolean();
				IsEFBCopiesEnabled = reader.ReadBoolean();
				UsingEFBToTexture = reader.ReadBoolean();
				IsEFBCopyCacheEnabled = reader.ReadBoolean();
				IsEmulatingEFBFormatChanges = reader.ReadBoolean();
				UsingXFB = reader.ReadBoolean();
				UsingRealXFB = reader.ReadBoolean();
				UsingMemoryCard = reader.ReadBoolean();
				UsingClearSaves = reader.ReadBoolean();
				NumBongos = reader.ReadByte();
				SyncGPU = reader.ReadBoolean();
				UsingNetplay = reader.ReadBoolean();
				PAL60 = reader.ReadBoolean();

				// Skip reserved bytes
				reader.BaseStream.Position += 12;

				SecondDiscName = reader.ReadBytes(40);
				GitRevision = reader.ReadBytes(20);
				DSPIROMHash = reader.ReadUInt32();
				DSPCoefHash = reader.ReadUInt32();
				TickCount = reader.ReadUInt64();

				// Jump to controller data and read it.
				reader.BaseStream.Position = 0x100;

				int frameNum = 0;
				while (reader.BaseStream.Position != reader.BaseStream.Length)
				{
					ControllerData.Add(new DTMControllerDatum(reader.ReadUInt64(), frameNum));
					frameNum += 1;
				}
			}
		}

		#endregion

		#region Properties

		/// <summary>
		/// File path to the DTM file.
		/// </summary>
		public string FilePath { get; private set; }

		/// <summary>
		/// ID of the game that this movie was made for.
		/// </summary>
		public byte[] GameID { get; private set; }

		/// <summary>
		/// Whether or not this movie file is for a Wii game.
		/// </summary>
		public bool IsWiiGame { get; private set; }

		/// <summary>
		/// Number of connected controllers (1-4)
		/// </summary>
		public byte ConnectedControllers { get; private set; }

		/// <summary>
		/// false indicates that the recording started from bootup, true for savestate
		/// </summary>
		public bool IsFromSaveState { get; private set; }

		/// <summary>
		/// Number of frames in the recording.
		/// </summary>
		public ulong FrameCount { get; private set; }

		/// <summary>
		/// Number of input frames in the recording.
		/// </summary>
		public ulong InputFrameCount { get; private set; }

		/// <summary>
		/// Number of lag frames in the recording.
		/// </summary>
		public ulong LagFrameCount { get; private set; }

		/// <summary>
		/// (not implemented) A Unique ID comprised of: md5(time + Game ID)
		/// </summary>
		public ulong UniqueID { get; private set; }

		/// <summary>
		/// Number of rerecords/'cuts' of this TAS
		/// </summary>
		public uint NumRerecords { get; private set; }

		/// <summary>
		/// Author's name
		/// </summary>
		public byte[] Author { get; private set; }

		/// <summary>
		/// Name of the video backend used.
		/// </summary>
		public byte[] VideoBackend { get; private set; }

		/// <summary>
		/// Name of the audio emulator used.
		/// </summary>
		public byte[] AudioEmulator { get; private set; }

		/// <summary>
		/// MD5 of the game ISO.
		/// </summary>
		public byte[] MD5 { get; private set; }

		/// <summary>
		/// Seconds since 1970 that recording started (used for RTC).
		/// </summary>
		public ulong RecordingStartTime { get; private set; }

		/// <summary>
		/// Whether or not certain settings are loaded.
		/// </summary>
		/// <remarks>
		/// All properties following this one are loaded during startup if true.
		/// </remarks>
		public bool IsSavedConfig { get; private set; }

		public bool UsingIdleSkip { get; private set; }
		public bool UsingDualCore { get; private set; }
		public bool UsingProgressiveScan { get; private set; }
		public bool UsingHLEDSP { get; private set; }
		public bool UsingFastDiscSpeed { get; private set; }

		public byte CPUCore { get; private set; }
		public bool IsEFBAccessEnabled { get; private set; }
		public bool IsEFBCopiesEnabled { get; private set; }
		public bool UsingEFBToTexture { get; private set; }
		public bool IsEFBCopyCacheEnabled { get; private set; }
		public bool IsEmulatingEFBFormatChanges { get; private set; }
		public bool UsingXFB { get; private set; }
		public bool UsingRealXFB { get; private set; }
		public bool UsingMemoryCard { get; private set; }

		public bool UsingClearSaves { get; private set; }
		public byte NumBongos { get; private set; }
		public bool SyncGPU { get; private set; }
		public bool UsingNetplay { get; private set; }
		public bool PAL60 { get; private set; }

		public byte[] SecondDiscName { get; private set; }
		public byte[] GitRevision { get; private set; }
		public uint DSPIROMHash { get; private set; }
		public uint DSPCoefHash { get; private set; }
		public ulong TickCount { get; private set; }

		/// <summary>
		/// Controller data. Each entry represents the controller data
		/// that is used within a certain frame.
		/// </summary>
		public List<DTMControllerDatum> ControllerData { get; private set; }

		#endregion

		#region Methods

		/// <summary>
		/// Saves the data in the DTM file representation to given path.
		/// </summary>
		/// <param name="filepath">The path to save the file to.</param>
		public void Save(string filepath)
		{
			using (var bw = new BinaryWriter(File.Open(filepath, FileMode.Create)))
			{
				//                    'D'   'T'   'M'
				bw.Write(new byte[] { 0x44, 0x54, 0x4D, 0x1A });

				bw.Write(GameID);
				bw.Write(IsWiiGame);
				bw.Write(ConnectedControllers);
				bw.Write(IsFromSaveState);
				bw.Write(FrameCount);
				bw.Write(InputFrameCount);
				bw.Write(LagFrameCount);

				// Reserved bytes
				bw.Write(new byte[8]);

				bw.Write(NumRerecords);
				bw.Write(Author);
				bw.Write(VideoBackend);

				// Reserved
				bw.Write(new byte[16]);

				bw.Write(MD5);
				bw.Write(RecordingStartTime);
				bw.Write(IsSavedConfig);
				bw.Write(UsingIdleSkip);
				bw.Write(UsingDualCore);
				bw.Write(UsingProgressiveScan);
				bw.Write(UsingHLEDSP);
				bw.Write(UsingFastDiscSpeed);
				bw.Write(CPUCore);
				bw.Write(IsEFBAccessEnabled);
				bw.Write(IsEFBCopiesEnabled);
				bw.Write(UsingEFBToTexture);
				bw.Write(IsEFBCopyCacheEnabled);
				bw.Write(IsEmulatingEFBFormatChanges);
				bw.Write(UsingXFB);
				bw.Write(UsingRealXFB);
				bw.Write(UsingMemoryCard);
				bw.Write(UsingClearSaves);
				bw.Write(NumBongos);
				bw.Write(SyncGPU);
				bw.Write(UsingNetplay);
				bw.Write(PAL60);
				
				// Reserved
				bw.Write(new byte[12]);

				bw.Write(SecondDiscName);
				bw.Write(GitRevision);
				bw.Write(DSPIROMHash);
				bw.Write(DSPCoefHash);
				bw.Write(TickCount);

				// Reserved
				bw.Write(new byte[11]);

				// Write controller data
				foreach (DTMControllerDatum d in ControllerData)
					bw.Write(d.Data);
			}
		}

		#endregion

		#region Utility Methods

		private static bool IsValidHeaderID(byte[] data)
		{
			return data[0] == 'D' &&
				   data[1] == 'T' &&
				   data[2] == 'M' &&
				   data[3] == 0x1A;
		}

		#endregion
	}
}
