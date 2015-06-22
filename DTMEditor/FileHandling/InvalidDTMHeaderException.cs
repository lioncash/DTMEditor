using System.IO;

namespace DTMEditor.FileHandling
{
	public sealed class InvalidDTMHeaderException : IOException
	{
		public InvalidDTMHeaderException()
		{
		}

		public InvalidDTMHeaderException(string message) : base(message)
		{
		}
	}
}
