using System;
using System.Reflection.Metadata.Ecma335;


//codingBat WarmUp2
internal class Program
{

    //Problem:Given a string and a non-negative int n, return a larger string that is n copies of the original string.

    public static string stringTimes(string str, int n)
    {

        if (n > 0)
        {
            // Initialize an empty string to store the repeated string
            string lastString = "";

            // Repeat the input string 'n' times
            for (int i = 0; i < n; i++)
            {
                // Concatenate the input string to the lastString 'n' times
                lastString += str;
            }

            // Return the resulting string containing the input string repeated 'n' times
            return lastString;
        }
        else
        {
            // If 'n' is not greater than 0, return the original string
            return str;
        }


    }

    /*
     Problem:Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, 
    or whatever is there if the string is less than length 3. Return n copies of the front;

     */

    public static string frontTimes(string str, int n)
    {
      
        string lastString = "";

        // Extract the first three characters of the input string
        string firstThree = str.Substring(0, 3);

        // Check if 'n' is greater than 0 and if the length of the input string is at least 3
        if (n > 0 && str.Length >= 3)
        {
            // Repeat the first three characters 'n' times
            for (int i = 0; i < n; i++)
            {
                // Concatenate the first three characters to the lastString 'n' times
                lastString += firstThree;
            }

            // Return the resulting string containing the first three characters repeated 'n' times
            return lastString;
        }
        else
        {
            // If 'n' is not greater than 0 or the length of the input string is less than 3, return the original string
            return str;
        }


    }

    //Problem:Count the number of "xx" in the given string. We'll say that overlapping is allowed, so "xxx" contains 2 "xx".


    public static int countXX(string str)
    {       
        int count = 0;

        // Iterate through the characters of the string up to the second last character
        for (int i = 0; i < str.Length - 1; i++)
        {
            // Check if the current character and the next character form "xx"
            if (str.Substring(i, 2).Equals("xx"))
                // If "xx" is found, increment the count
                count++;
        }

        // Return the total count of "xx" occurrences
        return count;
    }


    //Problem:Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".

    public static bool doubleX(string str)
    {

      
        int count = 0;

        // Iterate through the characters of the string up to the second last character
        for (int i = 0; i < str.Length - 1; i++)
        {
            // Check if the current character and the next character form "xx"
            if (str.Substring(i, 2).Equals("xx"))
          
                count++;
        }

        // Check if the count is not zero
        if (count != 0)
        {
            // If count is not zero, return true
            return true;
        }
        else
        {
            // If count is zero, return false
            return false;
        }

    }


    //Problem:Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".


    public static string stringBits(string str)
    {

        string newString="";

        for(int i=0;i<str.Length;i+=2)
        {
       
            newString += str.Substring(i, 1);

        }


        return newString;
    }

    //Problem:Given a non-empty string like "Code" return a string like "CCoCodCode".

    public static string stringSplosion(string str)
    {

        string newString = "";
       

        for(int i=0;i<=str.Length;i++)
        {


            newString+=str.Substring(0, i); 

        }

        return newString;

    }


    /*
     Problem:Given a string, return the count of the number of times that a substring length 2 appears in the string and also as the last 2 chars of the string, 
    so "hixxxhi" yields 1 (we won't count the end substring).
     */
    public static int last2(string str)
    {
        // Extract the last two characters of the input string
        string lastTwo = str.Substring(str.Length - 2);
        
        int count = 0;

        if (str.Length > 1)
        {
            // Iterate through the characters of the string up to the second last character
            for (int i = 0; i < str.Length - 1; i++)
            {
                // Check if the current substring of length 2 equals the last two characters
                if (str.Substring(i, 2).Equals(lastTwo))
                    count++;
            }

            // Return the count minus 1 (to exclude the last occurrence)
            return count - 1;
        }
        else
        {
            // If the length of the input string is not greater than 1, return 0
            return 0;
        }


    }

    //Problem:Given an array of ints, return the number of 9's in the array.


    public static int arrayCount9(int[] nums)
    {
        int count = 0;

        nums.ToList().ForEach(x =>
        {
            if (x == 9)
            {

                count++;
            }


        });
        return count;

    }

    //Problem:Given an array of ints, return true if one of the first 4 elements in the array is a 9. The array length may be less than 4.

    public static bool arrayFront9(int[] nums)
    {


        bool x = false;

        if (nums.Length >= 4)
        {
            for (int i = 0; i < 4; i++)
            {
                if (nums[i] == 9)
                {

                    x = true;


                }
            }       
        }

        return x;
    }

    //Problem:Given an array of ints, return true if the sequence of numbers 1, 2, 3 appears in the array somewhere.

    public static bool array123(int[] nums)
    {

        bool x = false;

        if (nums.Length >= 4)
        {
            for (int i = 0; i+2<= nums.Length; i++)
            {
                if (nums[i]==1&& nums[i+1] == 2 && nums[i+2] == 3)
                {

                    x = true;


                }
            }
        }

        return x;
    }


    /*
     Problem:Given 2 strings, a and b, return the number of the positions where they contain the same length 2 substring. 
    So "xxcaazz" and "xxbaaz" yields 3, since the "xx", "aa", and "az" substrings appear in the same place in both strings.

     */
    public static int stringMatch(string a, string b)
    {
        int count = 0;

        
        if (a.Length >= b.Length)
        {
            // Iterate through the characters of string 'a' up to the second last character
            for (int i = 0; i <= a.Length - 1; i++)
            {
                // Check if there are enough characters remaining in 'b' to form a substring of length 2
                // and if the substring of 'a' starting at position 'i' with length 2 equals the corresponding substring of 'b'
                if (i + 1 < b.Length && a.Substring(i, 2).Equals(b.Substring(i, 2)))
                {
                    
                    count++;
                }
            }
        }
       
        else if (b.Length >= a.Length)
        {
            // Iterate through the characters of string 'b' up to the second last character
            for (int i = 0; i <= b.Length - 1; i++)
            {
                // Check if there are enough characters remaining in 'a' to form a substring of length 2
                // and if the substring of 'b' starting at position 'i' with length 2 equals the corresponding substring of 'a'
                if (i + 1 < a.Length && b.Substring(i, 2).Equals(a.Substring(i, 2)))
                {
                    
                    count++;
                }
            }
        }

        // Return the total count of matching substrings
        return count;
    }



    //Problem:Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end should not be removed.
    public static string stringX(string str)
    {
        string newString = "";

        for (int i = 0; i < str.Length; i++)
        {

            if ((i == 0 || i == str.Length-1) && str[i]=='x')
            {

                newString += str[i];
            }

            if (str[i] != 'x')
            {
                newString += str[i];
            }
        }

        return newString;

        
    }


    //Problem:Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".

    public static string altPairs(string str)
    {

        string newString = "";

        for (int i = 0; i < str.Length; i+=4)
        {

            if (i  < str.Length)
            {
                newString += str[i];
                

            }

            if (i+1<str.Length)
            {             
                newString += str[i + 1];

            }
                


        }

        return newString;

    }

    /*
     Problem:Suppose the string "yak" is unlucky. Given a string, return a version where all the "yak" are removed, 
    but the "a" can be any char. The "yak" strings will not overlap.

     */

    public static string stringYak(string str)
    {
        
        string newString = "";

        // Iterate through the characters of the input string
        for (int i = 0; i < str.Length; i++)
        {
            // Check if there are enough characters remaining in the string to form "yak"
            if (i + 2 < str.Length && str[i] == 'y' && str[i + 2] == 'k')
            {
                // If "yak" is found, skip the next two characters by incrementing 'i' by 2
                i = i + 2;
            }
            else
            {
                // If "yak" is not found, append the current character to the newString
                newString += str[i];
            }
        }

        // Return the modified string
        return newString;
    }


    /*
     Problem:Given an array of ints, return the number of times that two 6's are next to each other in the array. 
    Also count instances where the second "6" is actually a 7.

     */
    public static int array667(int[] nums)
    {
        int count = 0;

        for (int i = 0;i<nums.Length-1; i++)
        {

            if ((nums[i]==6&& nums[i+1] == 6)||(nums[i] == 6 && nums[i + 1]==7))
            {

                count++;

            }


        }

        return count;

    }

    /*
     Problem:Given an array of ints, we'll say that a triple is a value appearing 3 times in a row in the array. 
    Return true if the array does not contain any triples.

     */

    public static bool noTriples(int[] nums)
    {
        // Initialize a boolean variable to track if there are triples in the array
        bool arrHave = false;

        // Iterate through the array elements up to the second last element
        for (int i = 0; i < nums.Length - 1; i++)
        {
            // Check if there are enough elements remaining in the array to form a triple
            // and if the current element is equal to the next two elements
            if (i + 2 < nums.Length && (nums[i] == nums[i + 1]) && (nums[i] == nums[i + 2]) && (nums[i + 1] == nums[i + 2]))
            {
                // If a triple is found, set arrHave to true
                arrHave = true;
            }
        }

        
        if (arrHave)
        {
            // If arrHave is true, return false
            return false;
        }
        else
        {
            // If arrHave is false, return true
            return true;
        }

    }

    /*
     Given an array of ints, return true if it contains a 2, 7, 1 pattern: a value, followed by the value plus 5, followed by the value minus 1. 
    Additionally the 271 counts even if the "1" differs by 2 or less from the correct value.

     */

    public static bool has271(int[] nums)
    {
        // Iterate through the array elements
        for (int i = 0; i < nums.Length; i++)
        {
            // Check if there are enough elements remaining in the array to form a pattern
            if (i + 2 < nums.Length)
            {
                // Get the value of the current element
                int val = nums[i];

                // Check if the next element is equal to (val + 5) and if the element after that
                // is within 2 units of (val - 1) in absolute difference
                if (nums[i + 1] == (val + 5) && Math.Abs(nums[i + 2] - (val - 1)) <= 2)
                {
                    // If the pattern is found, return true
                    return true;
                }
            }
        }

        // If the pattern is not found, return false
        return false;

    }

    private static void Main(string[] args)
    {

        //stringTimes Example
        /*
        Console.WriteLine(stringTimes("Hi",2));
        Console.WriteLine(stringTimes("Hi", 3));
        Console.WriteLine(stringTimes("Hi", 1));
        */


        //frontTimes Example

        /*
        Console.WriteLine(frontTimes("Chocolate", 2));
        Console.WriteLine(frontTimes("Chocolate", 3));
        Console.WriteLine(frontTimes("Abc", 3));
        */



        //countXX Example

        /*
        Console.WriteLine(countXX("abcxx"));
        Console.WriteLine(countXX("xxx"));
        Console.WriteLine(countXX("xxxx"));
        */


        //doubleX Example

        /*
        Console.WriteLine(doubleX("axxbb"));
        Console.WriteLine(doubleX("axaxax"));
        Console.WriteLine(doubleX("xxxxx"));
        */

        //stringBits Example

        /*
        Console.WriteLine(stringBits("Hello"));
        Console.WriteLine(stringBits("Hi"));
        Console.WriteLine(stringBits("Heeololeo"));
        */

        //stringSplosion Example

        /*
        Console.WriteLine(stringSplosion("Code"));
        Console.WriteLine(stringSplosion("abc"));
        Console.WriteLine(stringSplosion("ab"));
        */



        //last2 Example

        /*
        Console.WriteLine(last2("hixxhi"));
        Console.WriteLine(last2("xaxxaxaxx"));
        Console.WriteLine(last2("axxxaaxx"));
        */

        //arrayCount9

        /*
        int[] arr1 = { 1,2,9 };
        int[] arr2 = { 1,9,9 };
        int[] arr3 = { 1,9,9,3,9 };

        Console.WriteLine(arrayCount9(arr1));
        Console.WriteLine(arrayCount9(arr2));
        Console.WriteLine(arrayCount9(arr3));
        */


        //arrayFront9 Example

        /*
        int[] arr1 = { 1, 2, 9, 3, 4 };
        int[] arr2 = { 1, 2, 3, 4, 9 };
        int[] arr3 = { 1, 2, 3, 4, 5 };

        Console.WriteLine(arrayFront9(arr1));
        Console.WriteLine(arrayFront9(arr2));
        Console.WriteLine(arrayFront9(arr3));
        */



        //array123 Example


        /*
        int[] arr1 = { 1, 1, 2, 3, 1 };
        int[] arr2 = { 1, 1, 2, 4, 1 };
        int[] arr3 = { 1, 1, 2, 1, 2, 3 };


        Console.WriteLine(array123(arr1));
        Console.WriteLine(array123(arr2));
        Console.WriteLine(array123(arr3));

        */


        //stringMatch Example


        /*
        Console.WriteLine(stringMatch("xxcaazz", "xxbaaz"));
        Console.WriteLine(stringMatch("abc", "abc"));
        Console.WriteLine(stringMatch("abc", "axc"));
        */


        //stringX Example

        /*
        Console.WriteLine(stringX("xxHxix"));
        Console.WriteLine(stringX("abxxxcd"));
        Console.WriteLine(stringX("xabxxxcdx"));
        */


        //altPairs Example

        /*
        Console.WriteLine(altPairs("kitten"));
        Console.WriteLine(altPairs("Chocolate"));
        Console.WriteLine(altPairs("CodingHorror"));
        */


        //stringYak Example


        /*
        Console.WriteLine(stringYak("yakpak"));
        Console.WriteLine(stringYak("pakyak"));
        Console.WriteLine(stringYak("yak123ya"));
        */




        //array667 Example


        /*
        int[] arr1 = { 6, 6, 2 };
        int[] arr2 = { 6, 6, 2, 6 };
        int[] arr3 = { 6, 7, 2, 6 };

        Console.WriteLine(array667(arr1));
        Console.WriteLine(array667(arr2));
        Console.WriteLine(array667(arr3));
        */



        //noTriples Example


        /*
        int[] arr1 = { 1, 1, 2, 2, 1 };
        int[] arr2 = { 1, 1, 2, 2, 2, 1 };
        int[] arr3 = { 1, 1, 1, 2, 2, 2, 1 };


        Console.WriteLine(noTriples(arr1));
        Console.WriteLine(noTriples(arr2));
        Console.WriteLine(noTriples(arr3));
        */


        //has271 Example


        /*
        int[] arr1 = { 1, 2, 7, 1 };
        int[] arr2 = { 1, 2, 8, 1 };
        int[] arr3 = { 2, 7, 1 };

        Console.WriteLine(has271(arr1));
        Console.WriteLine(has271(arr2));
        Console.WriteLine(has271(arr3));
        */

    }
}