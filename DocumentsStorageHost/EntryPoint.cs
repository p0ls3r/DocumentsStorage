using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsStorageHost
{
    class EntryPoint
    {
        [System.STAThreadAttribute()]
        public static void Main()
        {
            var app = new App();
            var mainWindow = new MainWindow() { WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen };
            app.Run(mainWindow);
        }
    }
}