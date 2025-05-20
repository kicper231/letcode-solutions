namespace letcode_solutions.Problems
{
    public class SolutionCompress
    {
        public int Compress(char[] chars)
        {
            int index = 0;
            int moves = 0;

            while (moves < chars.Length)
            {
                char actual = chars[index];
                int helpIndex = index + 1;
                int counter = 0;

                while (moves != chars.Length && actual == chars[index])
                {
                    counter++;
                    moves++;
                    index++;
                }

                if (counter > 1)
                {
                    foreach (char item in counter.ToString())
                    {
                        chars[helpIndex++] = item;
                    }
                    moveLeft(chars, counter - counter.ToString().Length - 1, helpIndex);
                    index = helpIndex;
                }
            }

            return index;
        }

        public void moveLeft(char[] chars, int k, int start)
        {
            for (int i = start + k; i < chars.Length; i++)
            {
                chars[i - k] = chars[i];
            }
        }
    }
}