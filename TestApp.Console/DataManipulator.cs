public sealed class DataManipulator
{
    public static void SetZeroes()
    {
        var matrix = new int[][]
        {
            [1, 1, 1],
            [1, 0, 1],
            [1, 1, 1]
        };

        // rows
        for (int internalRows = 0; internalRows < matrix.Length; internalRows++)
        {
            // clomns
            for (int internalClomns = 0; internalClomns < matrix.Length; internalClomns++)
            {
                if (matrix[internalRows][internalClomns] == 0)
                {
                    /* ToDo: Finish the implementation of the SetZeroes method.
                       The method should set entire row and column to zero if an element is zero.
                       For example, given the matrix:
                       [1, 1, 1]
                       [1, 0, 1]
                       [1, 1, 1]
                       The output should be:
                       [1, 0, 1]
                       [0, 0, 0]
                       [1, 0, 1] */
                }
            }
        }
    }
}