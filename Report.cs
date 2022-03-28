using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CMP1903M_Assessment_1_Base_Code
{
    public class Report
    {
        public int[] analyseText(string Text)
        string Text = Input.text


        String[] sentences = Text.Split('.');
        int numsentences = sentenses.Count();

        String[] characters = Text.Split('');
        string[] vowels = ["A","E","I","O","U","a","e","i","o","u"];
        string[] consonants = ["B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z","b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z"];
        int numberOfVowls = 0;
        int numberOfConsonants = 0;
        int numberOfUpperCase = 0;
        int numberOfLowerCase = 0;
        foreach(String character in characters){
            if(vowels.Contains(character)){
                numberOfVowls++;
            }
            else if(consonants.Contains(character)){
                numberOfConsonants++;
            }
        }
        foreach(String character in characters){
            
            if(character.ToCar.IsUpper){
                numberOfUpperCase++;
            }
            else if(character.ToCar.IsLower){
                numberOfLowerCase++;
            }
            
        }


        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

    }
}
