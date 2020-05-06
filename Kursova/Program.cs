using Kursova.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BaseSystem baseSystem;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                baseSystem = JsonConvert.DeserializeObject<BaseSystem>(System.IO.File.ReadAllText(openFileDialog.FileName));
            }
            else
            {
                baseSystem = new BaseSystem();
            }



            Application.Run(new TourForm(baseSystem));

        }
    }
}
