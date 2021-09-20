using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace ConsoleApp42
{
    class Shifr
    {
        public void Shif()
        {
            ArrayList revers = new ArrayList();
            ArrayList razner = new ArrayList();
            ArrayList text12 = new ArrayList();

            DES dES = new DES();
            ArrayList oldtext = new ArrayList();
            Random random = new Random();
            string text = Console.ReadLine();
            Console.WriteLine("1: Вывести на экран исходный текст");
            Console.WriteLine("2: Текст после перемешки");
            Console.WriteLine("3: Ключ");
            Console.WriteLine("4: Произвести принцип дешифратора");
            oldtext.Add(text);
            string[] array_text = text.Split(' ');
            char[] answer;
            string Key = "";

            for (int i = 0; i < array_text.Length; i++)
            {
                int[] array1 = new int[array_text[i].Length];





                for (int ik = 0; ik < array1.Length; ik++)
                {
                    array1[ik] = ik;
                    razner.Add(ik);
                }

                int[] array2 = new int[array1.Length];



                for (int j1 = 0; j1 < array2.Length; j1++)
                {
                    array2[j1] = array1[random.Next(array1.Length)];
                    array1 = array1.Where(x => x != array2[j1]).ToArray();

                }


                answer = array_text[i].ToCharArray();
                revers.Add(answer);


                for (int j = 0; j < array_text[i].Length; j++)
                {
                    answer[array2[j]] = array_text[i][j];
                    Key += array2[j];
                    Key += " ";


                }



                Key += " ";
                Console.Write(" ");



                Console.WriteLine();

            }

            text12.Add(Key);
            
            
            bool run = true;
            while (run)
            {
                
                int a = Convert.ToInt32(Console.ReadLine());
                String listString = "";
                Char[] listu;

                switch (a)
                {
                    case 1:
                        foreach (string i in oldtext)
                        {

                            listString += i + "\t";
                            Console.WriteLine(listString);
                        }
                        break;
                    case 2:
                        foreach (char[] i in revers)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 3:
                        foreach (string i in text12)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 4: dES.DESIF();
                        break;
                    default:
                        { run = true; break; };
                        


                }

            }
        }
    }
}
