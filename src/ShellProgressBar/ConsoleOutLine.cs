namespace ShellProgressBar
{
	public struct ConsoleOutLine
	{
		public bool Error { get; set; }
		public string Line { get; set; }

		public ConsoleOutLine(string line, bool error = false)
		{
			Error = error;
			Line = line;
		}
	}
}
