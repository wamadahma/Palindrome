using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Palindrome
{
    /* 
        * Task: Create a web page that takes as input a string of any length and when submitted, lets the user know if the string input is a palindrome
        *  
        * Palindrome definition: A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward. 
        *  Allowances may be made for adjustments to capital letters, punctuation, and word dividers. Famous examples include
        *  "A man, a plan, a canal, Panama!", "Amor, Roma", "race car", "taco cat", "Was it a car or a cat I saw?" and "No 'x' in Nixon".
    */
    public partial class index : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            /* Used to select the text box after the CheckForPalindrome button is pressed 
                   making it easier for the user to enter in a different string */
            InputBox.ID = "InputBox";
            SubmitButton.ID = "SubmitButton";
            InputBox.Attributes.Add("onfocus", "this.select()");
        }

        protected void CheckForPalimdrone(object sender, EventArgs e)
        {
            try
            {
               // used to hold the value the output label will display
                // Gets user input from the input text box storing the raw input into one and reversing a string to test for palindrome
                string inputString = InputBox
                                        .Text
                                        .Trim();
               
                if (inputString == String.Empty)
                {
                    ReportLabel.Text = "You have entered an empty string";
                }
                else if (inputString.Length == 1)
                {
                    ReportLabel.Text = "";
                }
                else 
                {
                    string ReportText = ""; 
                    string reverseString = StringReverse(inputString);


                    // Convert the string to upper so there is no problems with casing
                    inputString = inputString.ToUpper();
                    reverseString = reverseString.ToUpper();

                    // we also want to remove spaces inside the strings so we can do phrases like "Was it a car or a cat I saw"
                    // additionally the removal of symbols allows us to test something like "A man, a plan, a canal, Panama!"
                    inputString = RemoveSymbolsandSpaces(inputString);
                    reverseString = RemoveSymbolsandSpaces(reverseString);



                    if (inputString == reverseString)
                    {
                        // the inputString is a palimdrone
                        ReportText = "The string that was input is a palindrome";
                    }
                    else
                    {
                        ReportText = "The value that was input is not a palindrome";
                    }

                    ReportLabel.Text = ReportText;
                    InputBox.Focus();
                    

                }

       
            }
            catch (Exception ex)
            {
                ReportLabel.Text= ex.Message;
                throw;
            }
        }


        private string RemoveSymbolsandSpaces(string removalString)
        {
             // Covers most common symbols found in sentences
            string[] RemovalSymbols = {
                                          " ",
                                          "!",
                                          ".",
                                          "?",
                                          ",",
                                          "(",
                                          ")",
                                          ";",
                                          "-",
                                          "_",
                                          "\"",
                                          "\'"
                                      };

            foreach (var symbol in RemovalSymbols)
            {
                removalString = removalString.Replace(symbol, "");
            }

            return removalString;
        }

        protected string StringReverse(string reverseString)
        {
            char[] reverseStringArray = reverseString.ToCharArray();
            Array.Reverse(reverseStringArray);
            string returnString = new string(reverseStringArray);
            return returnString;
        }



    }
}