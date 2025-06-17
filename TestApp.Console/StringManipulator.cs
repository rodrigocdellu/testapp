public sealed class StringManipulator
{
	public static string Manipulate(string content)
	{
		return content.Trim().Split(' ').LastOrDefault()!;
	}
}