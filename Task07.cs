using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tasks.Task7
{
    public class Task07
    {
        Dictionary<char, int> RomanLettersValues;
        public Task07()
        {
            RomanLettersValues = new Dictionary<char, int>();
            RomanLettersValues.Add('I', 1);
            RomanLettersValues.Add('V', 5);
            RomanLettersValues.Add('X', 10);
            RomanLettersValues.Add('L', 50);
            RomanLettersValues.Add('C', 100);
            RomanLettersValues.Add('D', 500);
            RomanLettersValues.Add('M', 1000);
        }
        public int  RomanToInt(string Roman)
        {
            try
            {
                validRomanString(Roman);
            }
            catch(ArgumentException e)
            {
                throw new ArgumentException("Złe dane wejściowe! ",e);
            }
            
                int suma = 0;
                for (int i = 0; i < Roman.Length; i++)
                {
                    int value = getValue(Roman[i]);
                    if (value != 0)
                    {
                        if (i + 1 < Roman.Length && getValue(Roman[i + 1]) < value)
                            suma = suma + value;
                        else
                            if (i + 1 < Roman.Length && getValue(Roman[i + 1]) > value)
                            suma = suma - value;
                        else
                            suma += value;
                    }
                    else
                    {
                        throw new ArgumentException("Złe dane wejściowe! - Niedozwolony znak!");
                    }
                }
                return suma;
            
            
        }
        public int getValue(char leter)
        {
            return RomanLettersValues.GetValueOrDefault(leter);            
        }
        public bool validRomanString(string roman)
        {
            var correct = true;
            correct = UnavaliableNeighbour(roman);
            return correct;
        }
        public bool UnavaliableNeighbour(string roman)
        {
            List<string> Unavaliable = new List<string>();
            Unavaliable.Add("IIII");
            Unavaliable.Add("XXXX");
            Unavaliable.Add("CCCC");
            Unavaliable.Add("MMMM");
            Unavaliable.Add("VV");
            Unavaliable.Add("LL");
            
            Unavaliable.Add("IL");
            Unavaliable.Add("VL");

            
            Unavaliable.Add("IC");
            Unavaliable.Add("VC");
            Unavaliable.Add("LC");

            Unavaliable.Add("DD");
            Unavaliable.Add("LD");
            Unavaliable.Add("XD");
            Unavaliable.Add("VD");
            Unavaliable.Add("ID");

            
            Unavaliable.Add("IM");
            Unavaliable.Add("VM");
            Unavaliable.Add("XM");
            Unavaliable.Add("LM");
            Unavaliable.Add("DM");

            Unavaliable.Add("IXX");
            Unavaliable.Add("XCC");
            Unavaliable.Add("CMM");
            Unavaliable.Add("IIV");
            Unavaliable.Add("IIX");

            Unavaliable.Add("IXI");
            Unavaliable.Add("XCX");
            Unavaliable.Add("CMC");


            foreach (string unavaliable in Unavaliable)
            {
                if(roman.Contains(unavaliable))
                {
                    throw new ArgumentException("Liczba rzymska nie została zapisana w sposób prawidłowy"); 
                    //return false;
                }
            }
            return true;
        }

        
    }
}
