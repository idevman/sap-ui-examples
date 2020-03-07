using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPUIExamples
{

    /// <summary>
    /// Used to create SAP initializer
    /// </summary>
    public class SAPUIInitializer
    {
        
        /// <summary>
        /// Create SAP application context
        /// </summary>
        /// <returns>SAP application context</returns>
        public static Application GetApplication()
        {
            SboGuiApi guiApi = new SboGuiApi();
            guiApi.Connect(Convert.ToString(Environment.GetCommandLineArgs().GetValue(1)));
            return guiApi.GetApplication(-1);
        }

    }

}
