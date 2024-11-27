using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoirotCatalogApp
{
    internal static class Program
    {
        
        [STAThread] // Required for running Windows Forms

        // Method that runs upon program start
        static void Main()
        {
            Application.EnableVisualStyles(); // Makes application controls appear more modern
            Application.SetCompatibleTextRenderingDefault(false); // Gives better text rendering
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12; // Use TLS 1.2 for network communication
            Application.Run(new StartMenu()); // Open main menu
        }
    }
}
