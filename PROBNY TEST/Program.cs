using System;

namespace PROBNY_TEST
{
    internal class Program
    {
        static bool CzySamogloska(char a)
        {
            string literki = "iyeaouIYEAOU";
            //literki = "a";
            int y = 0;
            while (y < literki.Length)
            {
                if (a == literki[y])
                {
                    return true;

                }
                else
                {
                    y++;
                }
            }
            return false;

        }

        static bool CzyLitera(char a)
        {
            string literki = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            //literki = "ab";
            int y = 0;
            while (y < literki.Length)
            {
                if (a == literki[y])
                {
                    return true;
                }
                else
                {
                    y++;
                }
            }
            return false;
        }
        static string Znajdz(string tekst)
        {
            int samogloski = 0;
            int spolgloski = 0;
            int y = 0;
            int a = 0;
            string wyraz = "";
            string najlepszywyraz = "";
            while (y < tekst.Length)
            {
                while (y < tekst.Length)
                {
                    if (true == CzyLitera(tekst[y]))
                    {
                        wyraz = wyraz + tekst[y];
                        y++;

                    }
                    else
                    {
                        y++;
                        if (wyraz != "") break;


                    }
                }


                while (wyraz.Length > a)
                {
                    if (true == CzySamogloska(wyraz[a]))
                    {
                        samogloski++;
                        a++;
                    }
                    else if (false == CzySamogloska(wyraz[a]))
                    {
                        spolgloski++;
                        a++;
                    }
                }
                if (spolgloski > samogloski)
                {
                    najlepszywyraz = wyraz;
                    wyraz = "";
                    spolgloski = 0;
                    samogloski = 0;
                }
                else
                {
                    spolgloski = 0;
                    samogloski = 0;
                    wyraz = "";
                }


            }

                    
                
            





            if (najlepszywyraz == "")
            {
                return " ";

            }
            else return najlepszywyraz;
        }
        static void Main(string[] args)
        {
            string tekst = " aa-bbb?ppp*yyt ";
            Console.WriteLine(Znajdz(tekst));
        }
    }
}
