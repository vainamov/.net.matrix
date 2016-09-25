using System;
using System.Collections.Generic;

namespace dotNetdotMatrix {
    public class Charset {
        public string Name { get; set; }
        public string Author { get; set; }
        public int LineHeight { get; set; }
        public int CharHeight { get; set; }
        public DisplayChar[] Characters { get; set; }

        public IEnumerable<String> GetAllCharacters() {
            foreach (DisplayChar dc in Characters) {
                yield return dc.CharacterCode;
            }
        }

        public DisplayChar GetCharacter(char c) {
            foreach (DisplayChar dc in Characters) {
                if (dc.CharacterCode == c.ToString())
                    return dc;
            }
            return null;
        }

        public int MeasureString(string s) {
            int totalCharWidth = 0;
            foreach (char c in s) {
                foreach (DisplayChar dc in Characters) {
                    if (dc.CharacterCode == c.ToString()) {
                        totalCharWidth += (dc.Definition.Length / CharHeight) + 1;
                    }
                }
            }
            return totalCharWidth;
        }

    }
}