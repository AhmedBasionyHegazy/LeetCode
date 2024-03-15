using LeetCode.WorkSpace;
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
try
{
    Numbers numbers = new Numbers();


    //while (true)
    //{
        //Console.WriteLine("enter number to check");
        //int n = int.Parse(Console.ReadLine() ?? "");

        ////Palindrome Number
        //Console.WriteLine(numbers.isPalindRome(n));

        ////Trailing Zeros
        //Console.WriteLine(numbers.Trailing_zeros(n));

        //Console.WriteLine("enter number n to check");
        //int n = int.Parse(Console.ReadLine() ?? "");

        //Console.WriteLine("enter number x to check");
        //double x = double.Parse(Console.ReadLine() ?? "");

        ////Pow(x,n)
        //Console.WriteLine(numbers.myPow(x, n));
    //}

    Strings strings = new Strings();

    ////Revese String
    //char[] chars = new char[]
    //{
    //    'h',
    //    'e',
    //    'l',
    //    'l',
    //    'o'
    //};
    //Console.WriteLine(strings.reveseString(chars));

    ////Longest Common Prefix
    //string[] strs = new string[] { "leetCode", "lead", "leet" };
    //Console.WriteLine(strings.longestCommonPrefix(strs));

    ////Reverse Words In String
    //string str = " Hello World ";
    //Console.WriteLine(strings.reverseWords(str));

    ////longest Palindrome
    //string str = "babad";
    //Console.WriteLine(strings.longestPalindrome(str));

    ////length Of Longest Substring
    //string str = "abcabcbb";
    //Console.WriteLine(strings.lengthOfLongestSubstring(str));

    //Test
    Test test=new Test();
    //Console.WriteLine("Enter String");
    //string str = Console.ReadLine();
    //Console.WriteLine(test.First_non_repeating_index(str));

    //string[] s = new string[] { "eye", "california", "12321", "level", "was it a cat i saw" };
    //string[] s =new string[] { "Dubai", "amman", "cairo", "fes" };
    //Console.WriteLine(test.Longet_palindrome_string(s));

    Console.WriteLine("Please Enter Number");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine(test.GetSum(num));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}