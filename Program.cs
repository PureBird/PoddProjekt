using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoddProjekt
{
    internal static class Program
    {
        private static readonly MongoDBServices service = new MongoDBServices();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Testkod

            Medlem medlem1 = new Medlem("1", "Axel", "Axel@gmail.com", 10);

            service.LaggTillMedlem(medlem1);

            List<Medlem> allaMedlemmar = service.HamtaAllaMedlemmar();

            foreach(Medlem m in allaMedlemmar)
            {
                System.Diagnostics.Debug.WriteLine(m.Namn);
            }
        }
    }
}
