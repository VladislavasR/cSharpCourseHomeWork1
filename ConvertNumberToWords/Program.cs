using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumberToWords
{
    class Program
    {
        static void Main()
        {
            const int FROM_NUMBER = -19;
            const int TO_NUMBER = 19;

            Console.WriteLine("Sveiki!");

            string numberInput = "";
            int checkNumber;

            while (numberInput != " ")
            {
                Console.WriteLine($"Iveskite skaiciu nuo {FROM_NUMBER} iki {TO_NUMBER}.   (Iveskite Space programai uzbaigti.)");
                numberInput = Console.ReadLine();
                if (CheckIfGoodNumber(numberInput))
                {
                    checkNumber = Convert.ToInt32(numberInput);
                    Console.WriteLine(ChangeNumberToText(checkNumber));
                }
                else if (CheckIfGoodNumber(numberInput) == false && !numberInput.Equals(" "))
                {
                    Console.WriteLine("Bad Number");
                }
            }
            Console.WriteLine("Viso gero!");
            Console.ReadKey();
        }

        static string ChangeNumberToText(int number)
        {
            string oneNumber = "";
            string numberSign = "";
            if (number < 0)
            {
                numberSign = "Minus ";
            }
            switch (Math.Abs(number))
            {
                case 0:
                    oneNumber = "Nulis";
                    break;
                case 1:
                    oneNumber = "vienas";
                    break;
                case 2:
                    oneNumber = "du";
                    break;
                case 3:
                    oneNumber = "trys";
                    break;
                case 4:
                    oneNumber = "keturi";
                    break;
                case 5:
                    oneNumber = "penki";
                    break;
                case 6:
                    oneNumber = "sesi";
                    break;
                case 7:
                    oneNumber = "septyni";
                    break;
                case 8:
                    oneNumber = "astuoni";
                    break;
                case 9:
                    oneNumber = "devyni";
                    break;
                case 10:
                    oneNumber = "desimt";
                    break;
                case 11:
                    oneNumber = "vienuolika";
                    break;
                case 12:
                    oneNumber = "dvylika";
                    break;
                case 13:
                    oneNumber = "trylika";
                    break;
                case 14:
                    oneNumber = "keturiolika";
                    break;
                case 15:
                    oneNumber = "penkiolika";
                    break;
                case 16:
                    oneNumber = "sesiolika";
                    break;
                case 17:
                    oneNumber = "septyniolika";
                    break;
                case 18:
                    oneNumber = "astuoniolika";
                    break;
                case 19:
                    oneNumber = "deviniolika";
                    break;
                default:
                    oneNumber = "dar nesugalvotas";
                    break;
            }
            return numberSign + oneNumber;
        }

        static bool CheckIfGoodNumber(string numberText)
        {
            int numberSymbol = 0;
            if (numberText.Length != 0 && numberText[0].Equals('-'))
            {
                numberSymbol++;
            }
            for (int i = 0; i < numberText.Length; i++)
            {
                char symbol = numberText[i];
                if (symbol.Equals('0') || symbol.Equals('1') || symbol.Equals('2') || symbol.Equals('3') || symbol.Equals('4') || symbol.Equals('5') || symbol.Equals('6') || symbol.Equals('7') || symbol.Equals('8') || symbol.Equals('9'))
                {
                    numberSymbol++;
                }
            }
            if (numberSymbol == numberText.Length && !numberText.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckIfNumberInRange(int number)
        {
            return number >= -9 && number <= 9 ? true : false;
        }

        // idejos kitom funkcijoms
        //ChangeOnesToText(), ChangeTeensToText, ChangeTensToText, ChangeHundredsToText, ChangeThousandsToText, ChangeMillionsToText, ChangeBilllionsToText


        //Skaiciai zodziais:  
        // "minus"; 
        // "nulis", "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni", "astuoni", "devyni"; 
        // "desimt", "vienualika", "dvylika", "trylika", "keturiolika", "penkiolika", "sesiolika", "septyniolika", "astuoniolika", "devyniolika"; 
        // "dvidesimt", "trisdesimt", "keturiasdesimt", "penkiasdesimt", "sesiasdesimt", "septyniasdesimt", "astuoniasdesimt", "devyniasdesimt"; 
        // "simtas", "tukstantis", "milijonas", "milijardas"; 
        // "simtai", "tukstanciai", "milijonai", "milijardai"; 
        // "simtu", "tukstanciu", "milijonu", "milijardu"; 
    }
}