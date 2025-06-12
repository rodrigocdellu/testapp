using System.Text;

public sealed class StringReverser
{
    public static string Reverse(string content)
    {
        var finalBuffer = new StringBuilder();
        var letterOrDigitBuffer = new StringBuilder();
        var bufferIndex = 0;

        for (int index = 0; index < content.Length; index++)
        {
            var myChar = content[index];

            if (Char.IsLetterOrDigit(myChar))
            {
                letterOrDigitBuffer.Insert(0, myChar);
            }
        }
        
        for (int index = 0; index < content.Length; index++)
        {
            var myChar = content[index];

            if (Char.IsLetterOrDigit(myChar))
            {
                finalBuffer.Insert(index, letterOrDigitBuffer[bufferIndex++]);
            }
            else
            {
                finalBuffer.Insert(index, myChar);
            }
        }

        return finalBuffer.ToString();
    }
}
