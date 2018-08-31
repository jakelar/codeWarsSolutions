using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static string DuplicateEncode(string word)
    {
        word = word.ToLower();
        String result = "";
        Char[] wordToChar = word.ToCharArray();
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        foreach (char ch in wordToChar)
        {
            if (dictionary.ContainsKey(ch))
            {
                dictionary[ch]++;
            }
            else
            {
                dictionary[ch] = 1;
            }
        }
        for (int i = 0; i < wordToChar.Length; i++)
        {
            // if (dictionary.ContainsKey(wordToChar[i]){
            if (dictionary[wordToChar[i]] > 1)
            {
                result += ')';

            }
            else
            {
                result += '(';
            }
        }
        return result;
    }
}