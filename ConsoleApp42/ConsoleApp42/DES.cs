using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace ConsoleApp42
{
    class DES
    {
        public void DESIF()
        {

            string old = "";
            Console.Write("Ввести криптограмму: ");

            string Keykrip = Console.ReadLine();
            ArrayList Kriop = new ArrayList();
            Kriop.Add(Kriop);
            string[] arrayKrip = Keykrip.Split(' ');

            string NewStroka = "";
            for (int i = 0; i < arrayKrip.Length; i++)
            {
                
                int[] massiv = new int[arrayKrip[i].Length];

                Console.WriteLine("Ключ для слова: " + arrayKrip[i]);

                for (int j = 0; j < arrayKrip[i].Length; j++)
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                   
                    old += arrayKrip[i][a];
                }
                NewStroka += " " + old;
            }
            Console.WriteLine("Сообщение:" + NewStroka);
        }
    }
}
