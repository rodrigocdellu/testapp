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

    public static string SpecialReverse(string content)
    {
        var result = content.ToCharArray();
        var indexA = 0;
        var indexB = content.Length - 1;

        while (indexA < indexB)
        {
            if (!Char.IsAsciiLetterOrDigit(result[indexA]))
            {
                indexA++;

                continue;
            }
            
            if (!Char.IsAsciiLetterOrDigit(result[indexB]))
            {
                indexB--;

                continue;
            }

            var temp = result[indexA];
            result[indexA] = result[indexB];
            result[indexB] = temp;

            indexA++;
            indexB--;
        }

        return new string(result);
    }
}
