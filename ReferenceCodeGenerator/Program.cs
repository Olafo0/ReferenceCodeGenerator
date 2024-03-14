namespace ReferenceCodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans = GeneratingReferenceCode("zoo");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(ans);
        }

        private static string GeneratingReferenceCode(string ticketType)
        {

            string[] charatersForRef = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
            string TokenGenerated = "";
            string ticketNumber = "11";

            if(ticketType == "zoo")
            {
                Random random = new Random();
                string numberGenerated = Convert.ToString(random.Next(0, 999));
                string characterGenerated = charatersForRef[random.Next(charatersForRef.Length)];

                TokenGenerated = $"ZOT{ticketNumber}{numberGenerated}{characterGenerated}";
            }

            return TokenGenerated;
        }
    }
}