using SAPbouiCOM;

namespace SAPUIExamples.Examples
{

    /// <summary>
    /// Used to handle events in forms
    /// </summary>
    public class CatchingEvents
    {

        /// <summary>
        /// SAP application to handle
        /// </summary>
        public Application Application { get; set; }

        /// <summary>
        /// Initialize events listeners
        /// </summary>
        public void Init()
        {
            Application.AppEvent += Application_AppEvent;
            Application.MenuEvent += Application_MenuEvent;
        }

        /// <summary>
        /// Display some system detection
        /// </summary>
        /// <param name="EventType"></param>
        private void Application_AppEvent(BoAppEventTypes EventType)
        {
            switch (EventType)
            {
                case BoAppEventTypes.aet_ShutDown:
                    Application.MessageBox("Shutdown detected");
                    System.Windows.Forms.Application.Exit();
                    break;
                case BoAppEventTypes.aet_CompanyChanged:
                    Application.MessageBox("Company changed detected");
                    break;
                case BoAppEventTypes.aet_LanguageChanged:
                    Application.MessageBox("Language changed");
                    break;

            }
        }

        /// <summary>
        /// Catch menu button pressed
        /// </summary>
        /// <param name="pVal"></param>
        /// <param name="BubbleEvent"></param>
        private void Application_MenuEvent(ref MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            if (pVal.BeforeAction == true)
            {

                Application.SetStatusBarMessage("Menu item: " + pVal.MenuUID + " sent an event BEFORE SAP Business One processes it.", BoMessageTime.bmt_Long, true);
                //  BubbleEvent = False
            }
            else
            {
                Application.SetStatusBarMessage("Menu item: " + pVal.MenuUID + " sent an event AFTER SAP Business One processes it.", BoMessageTime.bmt_Long, true);
            }
        }

    }

}
