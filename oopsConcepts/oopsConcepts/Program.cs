namespace oopsConcepts
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ArraySample();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }

        static void ArraySample()
        {
            int[] num = { 1, 2, 3, 4 };
            Console.WriteLine("print second value" + num[1]);

            List<int> numList = new List<int> () { 1, 2, 3, 4 };
            Console.WriteLine("print second value" + numList[1]);

            //access all value from array
            var resultArray = from a1 in num
                              select a1;

            //access array value greater than 2
            var resultArray2 = from a1 in num
                               where a1 > 2
                               select a1;

            //access array value based on position
            int resul3 = num.ElementAt(2);
            


        }
    }


}