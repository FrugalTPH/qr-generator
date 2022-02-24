using System;

namespace qr_generator
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
				if (args.Length != 2) { return; }
				new qrBuilder(args[0], args[1]).Execute();
			}
            catch (Exception)
            {

                throw;
            }

			//string value = "Generation failed - it is likely that the valid command line paramenters were not passed!";
			//try
			//{
			//	if (args.Length != 2) { return; }
			//	new qrBuilder(args[0], args[1]).Execute();
			//	value = "Generation Succeeded!";
			//}
			//finally
			//{
			//	#if !DEBUG
			//		Console.WriteLine(value);
			//		Console.WriteLine("Press any key to exit...");
			//		Console.ReadKey();
			//	#endif
			//}
			
		}
    }
}
