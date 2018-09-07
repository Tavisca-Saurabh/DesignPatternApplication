using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FactoryDesignExample
{
    sealed class Logger
    {
        private static int counter = 0;

        /*
         * Private property initilized with null
         * ensures that only one instance of the object is created
         * based on the null condition
         */
        private static Logger instance = null;

        /*
         * public property is used to return only one instance of the class
         * leveraging on the private property
         */
        public static Logger GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Logger();
                return instance;
            }
        }
        /*
         * Private constructor ensures that object is not
         * instantiated other than with in the class itself
         */
        private Logger()
        {
            
        }
        /*
         * Public method which can be invoked through the singleton instance
         */
        public void SaveInToLogFile(string message)
        {
            StringBuilder log = new StringBuilder();
            log.Append(message);
            log.Append(" ");
            log.Append(DateTime.Now.ToLongTimeString());
            log.Append(" ");
            log.Append(DateTime.Now.ToLongDateString());
            log.Append(" ");
            log.Append(Environment.NewLine);
            // flush every 20 seconds as you do it
            File.AppendAllText("C:/Users/smanchanda/Desktop/logFile.txt", log.ToString());
            //log.Clear();
            Console.WriteLine(log.ToString());
        }
    }
}
