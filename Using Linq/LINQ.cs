using System.Collections.Generic;

namespace Using_Linq
{
    class LINQ
    {
        public delegate bool IntToBoolFunction(string s);

        //"the", "bike", "this", "it", "tenth","mathematics"
        public static IEnumerable<string> HasTwoLetters(List<string> names, IntToBoolFunction wordsToCheck)
        {
            foreach (string word in names)
            {
                if (wordsToCheck(word))
                {
                    yield return word;
                }
            }
        }




        //public static bool HasTwoLetters(string words)
        //{
        //    if(words =);
        //}
        //public static bool LessThanEighty(int grade)
        //{
        //    return grade <= 80;
        //}
        //public static bool GreaterThanSeventy(int grade)
        //{
        //    return grade >= 70;
        //}
    }
}
