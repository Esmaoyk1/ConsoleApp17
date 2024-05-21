using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SqlTablo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tablo tablo = new Tablo();
            DateTime dateTime0 = new DateTime(1954, 04, 02);
            tablo[0, 0] = "TCno";
            tablo[0, 1] = "İsim";
            tablo[0, 2] = "Soyisim";
            tablo[0, 3] = "Doğum Tarihi";

            DateTime dateTime1 = new DateTime(1956, 10, 07);
            tablo[1, 0] = 123456;
            tablo[1, 1] = "Emine";
            tablo[1, 2] = "Sarı";
            tablo[1, 3] = dateTime1;

            DateTime dateTime2 = new DateTime(1958, 12, 07);
            tablo[2, 0] = 123456;
            tablo[2, 1] = "Leyla";
            tablo[2, 2] = "Bilgin";
            tablo[2, 3] = dateTime2;

            DateTime dateTime3 = new DateTime(1960, 03, 17);
            tablo[3, 0] = 123456;
            tablo[3, 1] = "Ali";
            tablo[3, 2] = "Saygın";
            tablo[3, 3] = dateTime3;

            DateTime dateTime4 = new DateTime(2000, 05, 13);
            tablo[4, 0] = 123456;
            tablo[4, 1] = "Mehmet";
            tablo[4, 2] = "Sayar";
            tablo[4, 3] = dateTime4;

            DateTime dateTime5 = new DateTime(2013, 09, 22);
            tablo[5, 0] = 123456;
            tablo[5, 1] = "Mustafa";
            tablo[5, 2] = "Can";
            tablo[5, 3] = dateTime5;

            DateTime dateTime6 = new DateTime(2007, 06, 14);
            tablo[6, 0] = 123456;
            tablo[6, 1] = "Rabia";
            tablo[6, 2] = "Keskin";
            tablo[6, 3] = dateTime6;

            DateTime dateTime7 = new DateTime(2001, 10, 09);
            tablo[7, 0] = 123456;
            tablo[7, 1] = "Ahmet";
            tablo[7, 2] = "Gezgin";
            tablo[7, 3] = dateTime7;

            DateTime dateTime8 = new DateTime(2007, 01, 27);
            tablo[8, 0] = 123456;
            tablo[8, 1] = "Nazlı";
            tablo[8, 2] = "Yaşar";
            tablo[8, 3] = dateTime8;

            DateTime dateTime9 = new DateTime(1999, 05, 13);
            tablo[9, 0] = 123456;
            tablo[9, 1] = "Hülya";
            tablo[9, 2] = "Durmaz";
            tablo[9, 3] = dateTime9;

            DateTime dateTime10 = new DateTime(1954, 04, 02);
            tablo[10, 0] = "786940";
            tablo[10, 1] = "Fadime";
            tablo[10, 2] = "Andaç";
            tablo[10, 3] = dateTime10;

            Console.WriteLine(tablo[1, 1]);
            Console.WriteLine(tablo["Fadime Nur"].ToString());//////tek bir satır istenirse
            Console.WriteLine();
            for (int i = 0; i < tablo.satır1; i++)//////////bütün verileri yazdırma
            {
                for (int j = 0; j < tablo.sütun1; j++)
                {
                    Console.Write(tablo[i, j] + "      ");

                }
                Console.Write("\n");

            }
            Console.WriteLine();
            Console.WriteLine(tablo[3]);////////////belirli sütunu getirme





            Console.ReadLine();
        }
    }
    class Tablo
    {
        private object[,] satırdizi;
        string a = "";
        string b = "";
        public int satır1;
        public int sütun1;
        public Tablo()
        {

            satırdizi = new object[11, 4];
            this.satır1 = 11;
            this.sütun1 = 4;
        }
        public Tablo(int satır, int sütun)
        {
            satırdizi = new object[satır, sütun];
            this.satır1 = satır;
            this.sütun1 = sütun;
        }

        public object this[int index1, int index2]
        {
            get
            {
                if (index1 < 0 || index2 < 0 || index1 >= satır1 || index2 >= sütun1)
                    throw new Exception("sayı index dışında");
                return satırdizi[index1, index2];

            }
            set
            {
                if (index1 < 0 || index2 < 0 || index1 >= satır1 || index2 >= sütun1)
                    throw new Exception("sayı index dışında");

                satırdizi[index1, index2] = value;
            }
        }
        public object this[string Kelime]
        {

            get
            {

                for (int i = 0; i < satır1; i++)
                {

                    for (int j = 0; j < sütun1; j++)
                    {
                        if (satırdizi[i, j].ToString() == Kelime)
                        {
                            a = "  " + satırdizi[i, 0].ToString() + "    " + satırdizi[i, 1].ToString() + "    " + satırdizi[i, 2].ToString();
                            break;

                        }

                    }






                }
                return a;






            }
        }
        public object this[int sütunindex]
        {

            get
            {

                for (int i = 0; i < satır1; i++)
                {




                    b = b + satırdizi[i, sütunindex].ToString() + "\n";



                }
                return b;







            }
        }

    }

    public class Sütun
    {
        public int Tcno;
        public string Name;
        public string LastName;
        public object date;
    }


}
