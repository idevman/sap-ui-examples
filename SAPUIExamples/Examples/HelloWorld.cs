using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPUIExamples.Examples
{

    /// <summary>
    /// Add-On used to display a hello world message
    /// </summary>
    public class HelloWorld
    {

        /// <summary>
        /// SAP application to handle
        /// </summary>
        public Application Application { get; set; }

        /// <summary>
        /// Show message to user
        /// </summary>
        public void ShowMessage()
        {
            Application.MessageBox("Hello World", 1, "Ok", "", "");
        }

    }

}
