using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    static class MorseCodeTranslator
    {
        private static Dictionary<char, string> _textToMorse = new Dictionary<char, string>()
        {
            {' ', "/"},
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'0', "-----"},
            {',', "--..--"},
            {'.', ".-.-.-"},
            {'?', "..--.."},
            {';', "-.-.-."},
            {':', "---..."},
            {'/', "-..-."},
            {'-', "-....-"},
            {'\'', ".----."},
            {'"', ".-..-."},
            {'(', "-.--."},
            {')', "-.--.-"},
            {'=', "-...-"},
            {'+', ".-.-."},
            {'@', ".--.-."},
            {'!', "-.-.--"},
            {'Á', ".--.-"},
            {'É', "..-.."},
            {'Ö', "---."},
            {'Ä', ".-.-"},
            {'Ñ', "--.--"},
            {'Ü', "..--"}
        };

        private static Dictionary<string, char> _morseToText = new Dictionary<string, char>();

        static MorseCodeTranslator()
        {
            foreach(KeyValuePair<char, string> code in _textToMorse)
            {
                //_morseToText[code.Value] = code.Key;
                //Useful to add new keys to a dictionary however its a catch 22 since it'll overwrite any pre-existing keys that match the new one.
                _morseToText.Add(code.Value, code.Key);
                //This on the other hand will only add keys that haven't been added before and throw an exception/error should any duplicates arise.
            }
        }

        public static string ToMorse(string input)
        {
            List<string> output = new List<string>(input.Length);
            foreach(char character in input.ToUpper())
            {
                try
                {
                    string morseCode = _textToMorse[character];
                    output.Add(morseCode);
                }
                catch(KeyNotFoundException)
                { output.Add("!"); }
            }
            return string.Join(" ", output);
        }
    }
}
