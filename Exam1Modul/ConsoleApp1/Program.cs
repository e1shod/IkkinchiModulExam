namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 - masala
            List<int> natija1 = new List<int> { 2, 5, 6, 9, 8 };

            static int JuftlarniSanash(List<int> list)
            {
                int count = 0;

                foreach (int number in list)
                {
                    if (number % 2 == 0)
                    {
                        count++;
                    }
                }

                return count;
            }
            Console.WriteLine(JuftlarniSanash(natija1));

            // 2 - masala



            List<string> natija2 = new List<string> { "academy", "school", "programming" };
            static bool ElementningUzunligi(List<string> list)
            {
                foreach (string s in list)
                {
                    if (s.Length <= 5)
                    {
                        return false;
                    }
                }
                return true;
            }

            Console.WriteLine(ElementningUzunligi(natija2));


            //3 - masala

            string natija3 = BrinchiUchtaHarf("salom");

            static string BrinchiUchtaHarf(string text)
            {
                return text.Substring(0, 3);
            }

            Console.WriteLine(natija3);


            // 4 - masala
            bool natija4 = BoshidagiPDP("pdp academy");

            static bool BoshidagiPDP(string text)
            {
                if (text.StartsWith("pdp"))
                {
                    return true;
                }
                else
                { return false; }
            }
            Console.WriteLine(natija4);

        }
    }
}
