using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CountdownBotForm
{
    public class WordGuesser
    {
        public WordGuesser()
        {
            wordDictionary = ReadWords();
        }

        enum Letters
        {
            a = 1 << 0,
            b = 1 << 1,
            c = 1 << 2,
            d = 1 << 3,
            e = 1 << 4,
            f = 1 << 5,
            g = 1 << 6,
            h = 1 << 7,
            i = 1 << 8,
            j = 1 << 9,
            k = 1 << 10,
            l = 1 << 11,
            m = 1 << 12,
            n = 1 << 13,
            o = 1 << 14,
            p = 1 << 15,
            q = 1 << 16,
            r = 1 << 17,
            s = 1 << 18,
            t = 1 << 19,
            u = 1 << 20,
            v = 1 << 21,
            w = 1 << 22,
            x = 1 << 23,
            y = 1 << 24,
            z = 1 << 25
        }

        public static Dictionary<string, int> wordDictionary = new Dictionary<string, int>();

        public static Dictionary<string, int> ReadWords()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            try
            {
                StreamReader sr = new StreamReader("words_alpha.txt");
                String line = sr.ReadLine();
                while (line != null)
                {
                    dict.Add(line, ParseString(line));
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch
            {

            }

            return dict;
        }

        public static int ParseString(string word)
        {
            int hashCode = 0;

            foreach (char c in word)
            {
                int index = ReturnAlphaNumericBit(c);
                if ((hashCode & index) != index)
                {
                    hashCode += index;
                }
            }

            return hashCode;
        }

        public static int ReturnAlphaNumericBit(char c)
        {
            switch (c)
            {
                case 'a':
                    return (int)Letters.a;
                case 'b':
                    return (int)Letters.b;
                case 'c':
                    return (int)Letters.c;
                case 'd':
                    return (int)Letters.d;
                case 'e':
                    return (int)Letters.e;
                case 'f':
                    return (int)Letters.f;
                case 'g':
                    return (int)Letters.g;
                case 'h':
                    return (int)Letters.h;
                case 'i':
                    return (int)Letters.i;
                case 'j':
                    return (int)Letters.j;
                case 'k':
                    return (int)Letters.k;
                case 'l':
                    return (int)Letters.l;
                case 'm':
                    return (int)Letters.m;
                case 'n':
                    return (int)Letters.n;
                case 'o':
                    return (int)Letters.o;
                case 'p':
                    return (int)Letters.p;
                case 'q':
                    return (int)Letters.q;
                case 'r':
                    return (int)Letters.r;
                case 's':
                    return (int)Letters.s;
                case 't':
                    return (int)Letters.t;
                case 'u':
                    return (int)Letters.u;
                case 'v':
                    return (int)Letters.v;
                case 'w':
                    return (int)Letters.w;
                case 'x':
                    return (int)Letters.x;
                case 'y':
                    return (int)Letters.y;
                case 'z':
                    return (int)Letters.z;
            }

            throw new Exception();
        }

        public string GuessWords(string letters)
        {
            for (int lettersToRemove = 0; lettersToRemove < letters.Length; lettersToRemove++)
            {
                List<string> lettersRemoved = GetRemovedLetterStrings(letters, lettersToRemove);
                foreach (string toTest in lettersRemoved)
                {
                    string possibleWord = GuessWord(toTest);
                    if (possibleWord != "")
                        return possibleWord;
                }
            }

            return "No words found";
        }

        public List<String> GetRemovedLetterStrings(string letters, int lettersToRemove)
        {
            List<string> strings = new List<string>();
            strings.Add(letters);

            for (int i = 0; i < lettersToRemove; i++)
            {
                List<string> newStrings = new List<string>();
                foreach (string newLetters in strings)
                {
                    for (int j = 0; j < newLetters.Length; j++)
                    {
                        newStrings.Add(RemoveLetter(newLetters, j));
                    }
                }
                strings = newStrings;
            }

            return strings;
        }

        public String RemoveLetter(string letters, int indexToRemove)
        {
            return letters.Remove(indexToRemove, 1);
        }

        public string GuessWord(string letters)
        {
            int lettersHashCode = ParseString(letters);

            Dictionary<string, int> smallDict = wordDictionary.Where(x => x.Value == lettersHashCode).ToDictionary(x => x.Key, x => x.Value);

            for (int i = letters.Length; i > 0; i--)
            {
                Dictionary<string, int> lettersDict = smallDict.Where(x => x.Key.Length == i).ToDictionary(x => x.Key, x => x.Value);
                if (lettersDict.Count > 0)
                {
                    List<string> words = lettersDict.Keys.ToList();

                    foreach(string word in words)
                    {
                        if (VerifyWord(letters, word))
                        {
                            return word;
                        }
                    }                    
                }   
            }

            return "";
        }

        public bool VerifyWord(string letters, string word)
        {
            Dictionary<char, int> lettersDict = new Dictionary<char, int>();
            Dictionary<char, int> wordDict = new Dictionary<char, int>();

            List<char> lettersAvailable = new List<char>();

            foreach (char letter in letters)
            {
                if (lettersDict.ContainsKey(letter))
                {
                    lettersDict[letter] += 1;
                }                    
                else
                {
                    lettersAvailable.Add(letter);
                    lettersDict[letter] = 1;
                }
            }

            foreach (char letter in word)
            {
                if (wordDict.ContainsKey(letter))
                {
                    wordDict[letter] += 1;
                }
                else
                {
                    wordDict[letter] = 1;
                }
            }

            foreach(char letter in lettersAvailable)
            {
                if (wordDict.ContainsKey(letter) && lettersDict.ContainsKey(letter))
                {
                    //ensure that we have enough letters to make the word - this is handling for words with one or more duplicate letter
                    if (wordDict[letter] > lettersDict[letter])
                    {
                        return false;
                    }    
                }
            }

            return true;
        }
    }
}
