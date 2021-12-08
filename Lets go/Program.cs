using System;

namespace Lets_go
{
    internal class Program
    {
        static int CzyLitera(char a)
        {
            string literki = "Bab";
            literki = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
            int y = 0;
            while (y<literki.Length)
            {
                if (a == literki[y])
                {
                    return 1;
                }
                else
                {
                    y++;
                }
            }
            return 0;



        }


        static int CzySamogloska(char a)
        {
            string literki = "a";
            literki = "AaEeYyUuIiOo";
            int y = 0;
            while (y < literki.Length)
            {
                if(a == literki[y])
                {
                    return 1;
                }
                else
                {
                    y++;
                }
            }
            return 0;
        }


        static string Znajdz(string tekst)
        {
            int y = 0;
            string wyraz = "";
            string najlepszywyraz = "";
            int[] tab = new int[10];
            while (y < tekst.Length)
            {
                if (CzyLitera(tekst[y]) == 1)
                {
                    wyraz = wyraz + tekst[y];
                    y++;
                }
                else
                {
                    if (wyraz != "")
                    {
                        int samogloska = 0;
                        int spolgloska = 0;
                        int a = 0;
                        int roznica = 0;

                        while (a<wyraz.Length)
                        {
                            if(CzySamogloska(wyraz[a]) == 1)
                            {
                                samogloska++;
                                a++;
                            }
                            else
                            {
                                spolgloska++;
                                a++;
                            }
                        }
                        if(roznica < spolgloska - samogloska)
                        {
                            roznica = spolgloska - samogloska;
                            najlepszywyraz = wyraz;
                            wyraz = "";
                            samogloska = 0;
                            spolgloska = 0;
                            a = 0;
                        }
                        else
                        {
                            wyraz = "";
                            samogloska = 0;
                            spolgloska = 0;
                            a = 0;
                        }

                        
                    }
                    else
                    {
                        y++;
                    }
                }
            }


            if (najlepszywyraz == "") return " ";
            else return najlepszywyraz;
        }
        static void Main(string[] args)
        {
            string tekst = "ba bb bx bxbbxbx";
            Console.WriteLine(Znajdz(tekst));
        }
    }
}
