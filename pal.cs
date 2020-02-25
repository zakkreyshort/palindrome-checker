using System;
using System.Collections.Generic;

public class Palindrome
{
    public string Input;
    public static void Main()
    {
        Console.WriteLine("Enter a word");
        string userInput = Console.ReadLine();
        Palindrome word = new Palindrome(userInput);
        word.IsPalindrome(word.Input);
    }

    public Palindrome(string input)
    {
        Input = input;
    }

    public void IsPalindrome(string input)
    {
        char[] wordCheck = input.ToCharArray();
        Array.Reverse(wordCheck);
        string check = new string(wordCheck);

        if(check == input)
        {
            Console.WriteLine("Is palindrome");
        }
        else
        {
            Console.WriteLine("Is not palindrome");
        }
    }
}