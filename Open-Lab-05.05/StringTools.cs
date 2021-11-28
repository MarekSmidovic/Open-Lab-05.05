using System;
using System.

namespace Open_Lab_05._05
{
    public class StringTools
    {
        public string AlternatingCaps(string original)
        {
            
            string vys = string.Empty;
            int medzera = 0;

            //zistenie pocet miest na vytvorenie arrayu
            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] == ' ')
                {
                    medzera += 1;
                }
            }
            //zapisanie miest medzier
            int[] cisloMedzery = new int[medzera];
            int arrayUmiestnenie = 0;

            for (int i = 0; i < original.Length; i++)
            {
                if (original[i] == ' ')
                {
                    cisloMedzery[arrayUmiestnenie] = i;
                    arrayUmiestnenie++;
                    
                }
            }

            //vymazanie medzier zo stringu
            string aBezMedzier = String.Empty;

            foreach (char ch in original)
            {
                if (ch != ' ')
                {
                    aBezMedzier += ch;
                }
            }
             
            // zvacsovanie 
            for (int i = 0; i <aBezMedzier.Length; i++)
            {

                if (i % 2 == 0)
                {
                    char lenNaLoop = aBezMedzier[i];
                    string velkePismeno = lenNaLoop.ToString().ToUpper();
                    vys += velkePismeno;
                }
                else if (i % 2 == 1)
                {
                    char lenNaLoop = aBezMedzier[i];
                    vys += lenNaLoop;
                }
                
            }

            //pridanie medzier naspat
            for (int i = 0; i < medzera; i++)
            {
                vys = vys.Insert(cisloMedzery[i], " ")
            }

            return vys;
            
        }
    }
}
