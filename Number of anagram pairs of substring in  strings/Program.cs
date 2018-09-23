using System;
using System.Collections.Generic;

namespace Number_of_anagram_pairs_of_substring_in__strings
{
    //This Program Finds Number of pairs of anagram in subtrings of strings input by user
    //Number of substrings in a string equals n+(n-1)+(n-2)+.....+1=n(n+1)/2 where n is number of characters ,you can create substring by selecting n,(n-1)..or 1 character but start index of character is always less than end index of character .
    //anagrams are strings which contains same number of unique characters in it.
     class Program
    {

      
        static void Main()


        {
           //Read the count of strings to be inputted by user
            Console.WriteLine("Please input number of strings which you want to enter");
            int numberOfStrings =Convert.ToInt32(Console.ReadLine());

            //Read user inputted string and store them in array
            string[] userStrings = new string[numberOfStrings];
            for (int i = 0; i < numberOfStrings; i++)
            {
                Console.WriteLine("please enter string");
               userStrings[i]= Console.ReadLine();
            }

           int[] numberOfPairs = AnagramPairCalculator.anagramPairCalculator(userStrings);
            //string[] mainStrings = { "qaqa", "xdzxmvpnaa", "zzzz", "ability" };

            //Execute anagram pair calculator for each string's substrings

            


        }
    }

    public class AnagramPairCalculator
    {
        static bool areAnagramUsingCharSorting(String str1, String str2)
        {
            //anagrams have equal number of characters
            if (str1.Length == str2.Length)
            {
                //converting strings into character array for sorting Purpose ,which will be done next
                char[] firstStringAsCharArray = str1.ToCharArray();
                char[] secondStringAsCharArray = str2.ToCharArray();

                //Following Function Sort Characters in alphabetical Order

                Array.Sort(firstStringAsCharArray);
                Array.Sort(secondStringAsCharArray);

                //Converting back character array into strings for comparison purpose

                string firstStringAfterSort = new string(firstStringAsCharArray);
                string secondStringAfterSort = new string(secondStringAsCharArray);

                //if two strings are anagram ,they will become eqal after sorting in alphabetical order

                if (firstStringAfterSort == secondStringAfterSort)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            else
            {
                return false;

            }
        }
        // This function prints all anagram pairs in a 
        // given list of strings

        static int findNumberOfAnagramPairsInList(List<string> listOfSubstrings, int n)
        {
            //Initialize number of anagram pairs to 0 ,we will increase count whenever we find a pair of anagram
            int numberOfPairs = 0;

            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    //check for each substring with another substring in the list if they are anagrams or not
                    if (areAnagramUsingCharSorting(listOfSubstrings[i], listOfSubstrings[j]))
                    {
                        // Console.WriteLine(listOfSubstrings[i] +
                        // " is anagram of " + listOfSubstrings[j]);

                        //when a pair is found ,increase the count of pairs
                        numberOfPairs++;
                    }

            Console.WriteLine(numberOfPairs);
            return numberOfPairs;
        }

      public  static int[] anagramPairCalculator(string[] userStrings)
        {
            int[] numberOfPairs = new int[userStrings.Length];

            for (int i = 0; i < userStrings.Length; i++)
            {
                string value = userStrings[i];

                List<string> subStrings = new List<string>();

                // lenght of substring ranges from 1 to n-1 where n is the number of characters in a given string.
                // full string is not included in the list as it cannot have an anagram as no other substring can have same length

                for (int length = 1; length < value.Length; length++)
                {
                    // n+(n-1)+(n-2)+....,where n is string length and 0,1,2 are index of starting character length of substrings initial value if string length 4 ,is 4-1 i.e 0-3 index
                    for (int start = 0; start <= value.Length - length; start++)
                    {
                        //Substring method takes start index of character from which substring shoul start and length of substring to be extracted
                        string substring = value.Substring(start, length);
                        //Adding substring to a list ,which will be passed to anagram pair calculator
                        subStrings.Add(substring);


                    }
                }

                //passing list of substrings to anagram pair calculator
               numberOfPairs[i]= findNumberOfAnagramPairsInList(subStrings, subStrings.Count);

            }
            //Console.ReadKey();
            return numberOfPairs;
            



        }


    }
}
