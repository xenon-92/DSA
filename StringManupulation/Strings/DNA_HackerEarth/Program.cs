using System;
using System.Text;

class Demo
{
    //Need to see

    static void Main(string[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int B = Convert.ToInt32(Console.ReadLine());
            string seq = Console.ReadLine();
            StringBuilder toPrint = new StringBuilder();
            for (int j = 0; j < B; j++)
            {
                if (seq[j] == 'U')
                {
                    Console.WriteLine("Error RNA nucleobases found!");
                    break;
                }
                else if (seq[j] == 'A')
                {
                    toPrint.Append("T");
                }
                else if (seq[j] == 'T')
                {
                    toPrint.Append("A");
                }
                else if (seq[j] == 'G')
                {
                    toPrint.Append("C");
                }
                else
                {
                    toPrint.Append("G");
                }
            }
            Console.WriteLine(toPrint);

        }
    }
}