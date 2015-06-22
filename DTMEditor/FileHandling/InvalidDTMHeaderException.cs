using System;
using System.IO;
using System.Runtime.Serialization;

namespace DTMEditor.FileHandling
{
	[Serializable]
	public sealed class InvalidDTMHeaderException : IOException
	{
		public InvalidDTMHeaderException()
		{
		}

		public InvalidDTMHeaderException(string message) : base(message)
		{
		}

		public InvalidDTMHeaderException(string message, Exception innerException) : base(message, innerException)
		{
		}

		private InvalidDTMHeaderException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
