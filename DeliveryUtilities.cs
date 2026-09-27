namespace OOP05
{
    public static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("----------------------------------------");
        }

        public static void PrintDoubleSeparator()
        {
            Console.WriteLine("========================================");
        }

        public static void PrintHeader(string title)
        {
            PrintDoubleSeparator();
            Console.WriteLine(title);
            PrintDoubleSeparator();
        }

        public static void PrintSystemTitle(string title)
        {
            PrintSeparator();
            Console.WriteLine(title);
            PrintSeparator();
        }

        public static void PrintSubTitle(string title)
        {
            PrintSystemTitle(title);
        }
    }
}
