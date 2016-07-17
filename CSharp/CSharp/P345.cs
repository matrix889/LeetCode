using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P345
{

    public class Solution
    {
        private char []_vowel;
        public string ReverseVowels(string s)
        {
            int l = 0, r = s.Length - 1;
            _vowel = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            var tmpS = new char[s.Length];
            for (var i = 0; i < s.Length; ++i) tmpS[i] = s[i];

            while (l < r)
            {
                while (l < s.Length && !IsVowel(s[l])) ++l;
                while (r > 0 && !IsVowel(s[r])) --r;
                if (l < r)
                {
                    var tmp = tmpS[l];
                    tmpS[l] = tmpS[r];
                    tmpS[r] = tmp;
                }
                ++l;
                --r;
            }
            return new string(tmpS);
        }

        private bool IsVowel(char c)
        {
            for (var index = 0; index < _vowel.Length; index++)
            {
                var t = _vowel[index];
                if ((c == t) || (t == char.ToLower(c)) ) return true;
            }
            return false;
        }
    }
}
