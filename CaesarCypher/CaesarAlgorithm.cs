using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCypher;

/// <summary>
/// This implements the classical "Caeser Cypher" algorithm.
/// When implementing in code we have to make some strict decisions about what our "alphabet" is.  see the private _first and _last variables.
/// <para>use the Encrypt() and Decrypt() instance methods to use it.</para>
/// </summary>
public class CaesarAlgorithm
{
   /// <summary>
   /// first printable ascii character.   see "ASCII Printable Characters" on wikipedia https://en.wikipedia.org/wiki/ASCII#Printable_characters  
   /// <para>value ' ' converts to the number 32</para>
   /// </summary>
   private char _first = ' ';

   /// <summary>
   /// last printable ascii character.   see "ASCII Printable Characters" on wikipedia https://en.wikipedia.org/wiki/ASCII#Printable_characters  
   /// <para>value '~' converts to the number 126</para>
   /// </summary>
   private char _last = '~';
   /// <summary>
   /// the size of this "alphabet" (all printable ascii characters).
   /// <para>calculated in this class's constructor  (95)</para>
   /// </summary>
   private int _alphabetSize;
   
   public CaesarAlgorithm()
   {
      _alphabetSize = _last - _first + 1;   
   }

   public string Encrypt(string plainText, int shift)
   {
      //ensure our shift is a positive number  (we can't shift by a negative number)
      //for example, if shift is -1, we want to shift by 95 (the size of our alphabet)
      {
         shift = shift % _alphabetSize;
         shift += _alphabetSize;
         shift = shift % _alphabetSize;
      }

      //an empty output string that will be appended to, during the following FOR loop.
      string output = "";

      //do the work of cyphering our input "plainText"
      for (var i = 0; i < plainText.Length; i++)
      {
         var currentChar = plainText[i];
         //ensure our outputChar is within bounds of our printable characters

         int outputChar;  
         //for example, if our character is ' ', it's value is 32.  we want to apply mod (%) to it, so we need to translate it to 0.
         {
            //translate current character so it's "alphabet space" starts at zero, do this by subtracting the first character of our alphabet. (32)
            outputChar = (currentChar - _first);
            //apply our cypher  (shift,  with mod to wrap around properly)
            outputChar += shift;
            outputChar = outputChar % _alphabetSize;
            //translate output back into printable character space by adding back the first character of our alphabet. (32)
            outputChar += _first;
         }

         //finally, append this "encrypted" character to our output.
         output += (char)outputChar;

      }

      //done with for-loop, our "output" now contains the fully encrypted input "plainText"
      return output;
   }

}
