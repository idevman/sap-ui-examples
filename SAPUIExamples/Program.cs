using SAPUIExamples.Examples;
using System;

namespace SAPUIExamples
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LaunchHelloWorld();
            // LaunchCatchingEvents();
        }

        /// <summary>
        /// Launch Hellow world example
        /// </summary>
        private static void LaunchHelloWorld()
        {
            HelloWorld addOn = new HelloWorld
            {
                Application = SAPUIInitializer.GetApplication()
            };
            addOn.ShowMessage();
        }

        private static void LaunchCatchingEvents()
        {
            CatchingEvents addOn = new CatchingEvents
            {
                Application = SAPUIInitializer.GetApplication()

            };
            addOn.Init();
            System.Windows.Forms.Application.Run();
        }

    }

}
