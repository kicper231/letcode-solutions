namespace letcode_solutions.Problems
{
    public class SolutionCompress2
    {
        public int Compress2(char[] chars)
        {
            int index = 0;
            int help = 0;
            while (index < chars.Length)
            {
                char current = chars[index];
                int counter = 0;

                while (index != chars.Length && current == chars[index])
                {
                    counter++;
                    index++;
                }

                chars[help] = current;
                if (counter > 1)
                {
                    foreach (char c in counter.ToString())
                    {
                        chars[++help] = c;
                    }
                }
                help++;
            }

            return help;
        }
    }
}