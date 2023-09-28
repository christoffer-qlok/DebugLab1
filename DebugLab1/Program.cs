namespace DebugLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("Hello world!"));
        }


        static string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            char[] answer = new char[chars.Length];

            for (int i = 0; i < chars.Length; i++)
            {
                answer[i] = chars[chars.Length - i];
            }
            return new string(answer);
        }
    }
}
