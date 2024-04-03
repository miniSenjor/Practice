using System;
using System.Windows.Forms;

namespace Practika
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            //Application.Run(new FormErrorShowDialog("Товар успешно добавлен", "Успех"));
        }
    }
}
