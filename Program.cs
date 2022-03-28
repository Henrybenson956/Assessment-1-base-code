//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file

            console.writeline( "input '1' or '2' \n 1. Do you want to enter the text via the keyboard? \n 2. Do you want to read in the text from a file?");
            string val = console.ReadLine();
            if(val == "1"){
                string text = Input.manualTextInput()

            }
            else if(val == "2"){
                string text = Input.fileTextInput(string fileName);
            }


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            int[] report = Report.analyseText(text);


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}
