﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_internal_interface_dependency_injection.CSharp.Main;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        private Dictionary<Char, int> letterScores;
        Alphabet alphabet;
        //private RussianAlphabet _russian;
        //private GreekAlphabet _greek;
        //private EnglishAlphabet _english;

        public Scrabble(Alphabet alphabet) {
            this.letterScores = alphabet.getLetterScores();
        }

        public int score(String word) {
            int total = 0;

            foreach (char ch in word.ToCharArray()) {
                if (this.letterScores.ContainsKey(ch)) {
                    int score = this.letterScores[ch];
                    total += score;
                }
            }

            return total;
        }
    }
}
