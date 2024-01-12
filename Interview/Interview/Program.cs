using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        public static void Menu()//4 8 15 16 23 42
        {
            Console.WriteLine("Enter a code to see it in action: \n 1.From a given list return the index of the numbers witch summed to each other equal an objective\n" +
                "2.Difference function, which subtracts one list from another and returns the result\n" +
                "3.Given an integral number, determine if it's a perfect square number\n" +
                "4.Given a string of n letters return another string with the first letter is uppercased followed by a repetition augmented in 1 each time you print a letter RULES IN THE CLASS\n" +
                "5.You are going to be given a word. Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.\n" +
                "6.Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.\n" +
                "7.Given a string, replace every letter with its position in the alphabet.\n" +
                "8.You are given a string of space separated numbers, and have to return the highest and lowest number.\n" +
                "9.Given a roman numeral, convert it to an integer.\n" +
                "11.Take a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS) \n" +
                "12.Implement the function which takes an array containing the names of people that like an item. It must return the display text \n" +
                "13.Write a function that takes a string of braces, and determines if the order of the braces is valid. It should return true if the string is valid, and false if it's invalid.\n" +
                "14.Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed \n" +
                "15.Write a function that, given a string of text (possibly with punctuation and line-breaks), returns an array of the top-3 most occurring words, in descending order of the number of occurrences.\n" +
                "16.Implement a function that receives two IPv4 addresses, and returns the number of addresses between them (including the first one, excluding the last one).\n" +
                "17.Given the string representations of two integers, return the string representation of the sum of those integers. Find a clever way to do it. \n" +
                "18.In this kata you have to correctly return who is the \"survivor\", ie: the last element of a Josephus permutation. \n"+
                "19.Your task is to create a regular expression capable of evaluating binary strings (strings with only 1s and 0s) and determining whether the given string represents a number divisible by 3.\n" +
                "20.An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.\n" +
                "21.Range extraction. If theres a range of numbers keep the last and the first, so if this condition is true  represent the range with an - \n" +
                "22.String to interger. \n" +
                "23.Reverse an array \n");
            var opc = Console.ReadLine();
            switch (opc)
            {
                case "1":
                    IndiceSumaObjetivo.Busqueda();
                    Console.WriteLine(IndiceSumaObjetivo.arrayRes[0].ToString() + " " + IndiceSumaObjetivo.arrayRes[1].ToString()+" are the indexes");
                    Console.ReadLine();
                    break;
                case "2":
                    foreach(int a in Compare2Arrays.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }))
                    {
                        Console.WriteLine(a);
                    }
                    Console.WriteLine("this is the new 'a' order");
                    Console.ReadLine();
                    foreach (int a in Compare2Arrays.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }))
                    {
                        Console.WriteLine(a);
                    }
                    Console.WriteLine("this is the new 'a' order");
                    Console.ReadLine();
                    foreach (int a in Compare2Arrays.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }))
                    {
                        Console.WriteLine(a);
                    }
                    Console.WriteLine("this is the new 'a' order");
                    Console.ReadLine();
                    foreach (int a in Compare2Arrays.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { }))
                    {
                        Console.WriteLine(a);
                    }
                    Console.WriteLine("this is the new 'a' order");
                    Console.ReadLine();

                    foreach (int a in Compare2Arrays.ArrayDiff(new int[] { }, new int[] { 1, 2 }))
                    {
                        Console.WriteLine(a);
                    }
                    Console.WriteLine("this is the new 'a' order");
                    Console.ReadLine();
                    foreach (int a in Compare2Arrays.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }))
                    {
                        Console.WriteLine(a);
                    }
                    Console.WriteLine("this is the new 'a' order");
                    Console.ReadLine();
                    break;
                case "3":
                    if (PerfectSquare.IsSquare(-1) == false)
                    {
                        Console.WriteLine(-1 + " Is not a perfect square number");
                    }
                    else
                    {
                        Console.WriteLine(-1 + " Is a perfect square number");
                    }
                    if (PerfectSquare.IsSquare(3) == false)
                    {
                        Console.WriteLine(3 + " Is not a perfect square number");
                    }
                    else
                    {
                        Console.WriteLine(3 + " Is a perfect square number");
                    }
                    if (PerfectSquare.IsSquare(4) == false)
                    {
                        Console.WriteLine(4 + " Is not a perfect square number");
                    }
                    else
                    {
                        Console.WriteLine(4 + " Is a perfect square number");
                    }
                    if (PerfectSquare.IsSquare(25) == false)
                    {
                        Console.WriteLine(25 + " Is not a perfect square number");
                    }
                    else
                    {
                        Console.WriteLine(25 + " Is a perfect square number");
                    }
                    if (PerfectSquare.IsSquare(26) == false)
                    {
                        Console.WriteLine(26 + " Is not a perfect square number");
                    }
                    else
                    {
                        Console.WriteLine(26 + " Is a perfect square number");
                    }
                    Console.ReadLine();
                     break;
                case "4":
                    Console.WriteLine(StringManipulation.Accum("ZpglnRxqenU"));
                    Console.WriteLine(StringManipulation.Accum("NyffsGeyylB"));
                    Console.WriteLine(StringManipulation.Accum("MjtkuBovqrU"));
                    Console.WriteLine(StringManipulation.Accum("EvidjUnokmM"));
                    Console.WriteLine(StringManipulation.Accum("HbideVbxncC"));
                    Console.ReadLine();
                    break;
                case "5":
                    Console.WriteLine(MiddleLetter.GetMiddle("test"));
                    Console.WriteLine(MiddleLetter.GetMiddle("testing"));
                    Console.WriteLine(MiddleLetter.GetMiddle("middle"));
                    Console.WriteLine(MiddleLetter.GetMiddle("A"));
                    Console.ReadLine();
                    break;
                case "6":
                    Console.WriteLine(ArrToPhone.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 })+"call me ;)");
                    Console.WriteLine(ArrToPhone.CreatePhoneNumber(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }) + "call me ;)");
                    Console.ReadLine();
                    break;
                case "7":
                    Console.WriteLine(NumbersOfLetters.AlphabetPosition("The sunset sets at twelve o' clock.")+"/");
                    Console.WriteLine(NumbersOfLetters.AlphabetPosition("The narwhal bacons at midnight.") + "/");
                    Console.WriteLine("pretty cool huh ?");
                    Console.ReadLine();
                    break;
                case "8":
                    Console.WriteLine(HighestLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
                    Console.WriteLine(HighestLowest.HighAndLow("1 2 3"));
                    Console.ReadLine();
                    break;
                case "9":
                    Console.WriteLine(RomanToInt.RomToInt("III").ToString());
                    Console.WriteLine(RomanToInt.RomToInt("MCMXCIV").ToString());
                    Console.ReadLine();
                    break;
                case "10":
                    Console.WriteLine(CompareString.IsMatch("aab","c*a*b"));
                    Console.WriteLine(CompareString.IsMatch("talon", ".a*on"));
                    Console.WriteLine(CompareString.IsMatch("pesos", ".*sos"));
                    Console.WriteLine(CompareString.IsMatch("cabrales", "c*a*bsew"));
                    Console.WriteLine(CompareString.IsMatch("estudioss", "estudio*"));
                    Console.ReadLine();
                    break;
                case "11":
                    Console.WriteLine(SecondCalc.GetReadableTime(0));
                    Console.WriteLine(SecondCalc.GetReadableTime(5));
                    Console.WriteLine(SecondCalc.GetReadableTime(60));
                    Console.WriteLine(SecondCalc.GetReadableTime(86399));
                    Console.WriteLine(SecondCalc.GetReadableTime(359999));
                    Console.ReadLine();
                    break;
                case "12":
                    Console.WriteLine(FaceLikes.Likes(new string[0]));
                    Console.WriteLine(FaceLikes.Likes(new string[] { "Peter" }));
                    Console.WriteLine(FaceLikes.Likes(new string[] { "Jacob", "Alex" }));
                    Console.WriteLine(FaceLikes.Likes(new string[] { "Max", "John", "Mark" }));
                    Console.WriteLine(FaceLikes.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
                    Console.ReadLine();
                    break;
                case "13":
                    Console.WriteLine(VerifyBraces.validBraces("()"));
                    Console.WriteLine(VerifyBraces.validBraces("()}[]"));
                    Console.WriteLine(VerifyBraces.validBraces("({}[])"));
                    Console.WriteLine(VerifyBraces.validBraces("[}]{"));
                    Console.ReadLine();
                    break;
                case "14":
                    Console.WriteLine(FiveLetters.SpinWords("Welcome"));
                    Console.WriteLine(FiveLetters.SpinWords("Hey fellow warriors"));
                    Console.WriteLine(FiveLetters.SpinWords("This is a test"));
                    Console.WriteLine(FiveLetters.SpinWords("This is another test"));
                    Console.WriteLine(FiveLetters.SpinWords("You are almost to the last test"));
                    Console.WriteLine(FiveLetters.SpinWords("Just kidding there is still one more"));
                    Console.ReadLine();
                    break;
                case "15":
                    int[] exampleTest1 = { 2, 6, 8, -10, 3 };
                    Console.WriteLine(FindTheOutlier.Find(exampleTest1));
                    int[] exampleTest2 = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
                    Console.WriteLine(FindTheOutlier.Find(exampleTest2));
                    int[] exampleTest3 = { 2147483647, 0, 1 };
                    Console.WriteLine(FindTheOutlier.Find(exampleTest3));
                    Console.ReadLine();
                    break;
                case "16":
                    Console.WriteLine(CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50"));
                    Console.WriteLine(CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0"));
                    Console.WriteLine(CountIPAddresses.IpsBetween("0.0.0.0", "255.255.255.255"));
                    Console.ReadLine();
                    break;
                case "17":
                    Console.WriteLine(TwoStringsSum.sumStrings("123122","123"));
                    Console.WriteLine(TwoStringsSum.sumStrings("68283", "60392"));
                    Console.WriteLine(TwoStringsSum.sumStrings("1380922", "589234"));
                    Console.ReadLine();
                    break;
                case "18"://to see results put a break at the return and you can see the array content
                    Console.WriteLine(JosephusPermutation.JosephusPerm(7,3));
                    Console.WriteLine(JosephusPermutation.JosephusPerm(11, 19));
                    Console.WriteLine(JosephusPermutation.JosephusPerm(40, 3));
                    Console.ReadLine();
                    break;
                case "19":
                    //BinaryWhisper.MultipleOf3("1010100101");//677
                    //BinaryWhisper.MultipleOf3("11010101");//213
                    //BinaryWhisper.MultipleOf3("1110110");//118
                    //BinaryWhisper.MultipleOf3("101100101");//357
                    //BinaryWhisper.MultipleOf3("111010100");//468
                    Console.WriteLine(BinaryWhisper.MultipleOf3("1010100101"));
                    Console.WriteLine(BinaryWhisper.MultipleOf3("11010101"));
                    Console.WriteLine(BinaryWhisper.MultipleOf3("1110110"));
                    Console.WriteLine(BinaryWhisper.MultipleOf3("101100101"));
                    Console.WriteLine(BinaryWhisper.MultipleOf3("111010100"));
                    Console.ReadLine();
                    break;
                case "20":
                    Console.WriteLine(Isograms.Isogram("Dermatoglyphics"));//true
                    Console.WriteLine(Isograms.Isogram("isogram"));//true
                    Console.WriteLine(Isograms.Isogram("moose"));//false
                    Console.WriteLine(Isograms.Isogram("isIsogram"));//false
                    Console.WriteLine(Isograms.Isogram("aba"));//false
                    Console.WriteLine(Isograms.Isogram("moOse"));//false
                    Console.WriteLine(Isograms.Isogram("thumbscrewjapingly"));//true
                    Console.WriteLine(Isograms.Isogram(""));//true
                    Console.ReadLine();
                    break;
                case "21":
                    Console.WriteLine(RangeExtr.Extract(new[] { 1, 2 }));
                    Console.WriteLine(RangeExtr.Extract(new[] { 1, 2, 3 }));
                    Console.WriteLine(RangeExtr.Extract(new[] { -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 }));
                    Console.WriteLine(RangeExtr.Extract(new[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 }));
                    Console.WriteLine(RangeExtr.Extract(new[] { 81, 82, 83, 84, 86, 87, 89, 90, 91, 92, 94 }));
                    Console.WriteLine(RangeExtr.Extract(new[] { 17, 19, 20 }));
                    Console.WriteLine(RangeExtr.Extract(new[] { -79, -78, -76 }));
                    Console.ReadLine();
                    break;
                case "22":
                    Console.WriteLine(Parser.ParseInt("one"));
                    Console.WriteLine(Parser.ParseInt("twenty"));
                    Console.WriteLine(Parser.ParseInt("fifty-five"));
                    Console.WriteLine(Parser.ParseInt("seventy six"));
                    Console.WriteLine(Parser.ParseInt("eleven thousand four hundred and seventy-six"));
                    Console.WriteLine(Parser.ParseInt("ninety seven thousand four hundred and ninety nine"));
                    Console.ReadLine();
                    break;
                case "23":
                    Console.WriteLine(ArrReverse.Digitize(1203894587139).ToString());
                    Console.WriteLine(ArrReverse.Digitize(12).ToString());
                    Console.WriteLine(ArrReverse.Digitize(9123478102).ToString());
                    Console.WriteLine(ArrReverse.Digitize(59128371).ToString());
                    Console.WriteLine(ArrReverse.Digitize(123489).ToString());
                    Console.WriteLine(ArrReverse.Digitize(123128546123412).ToString());
                    Console.WriteLine(ArrReverse.Digitize(12413548127).ToString());
                    Console.WriteLine(ArrReverse.Digitize(1231).ToString());
                    Console.WriteLine(ArrReverse.Digitize(76584).ToString());
                    Console.WriteLine(ArrReverse.Digitize(469).ToString());
                    Console.WriteLine(ArrReverse.Digitize(22).ToString());
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("sorry, this is not a valid option\n ENDING PROGRAM AFTER THIS :( \n....\n...\n..\n.\n bad user bye");
                    Console.ReadLine();
                    break;

            }
        }
           

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
