using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VinSolutions
{
    public partial class _Default : System.Web.UI.Page
    {
        StringBuilder buildOutputSentence;// = new StringBuilder(150);
        protected void Page_Load(object sender, EventArgs e)
        {
            buildOutputSentence = new StringBuilder();
        }

        protected void ProcessSentence_Click(object sender, EventArgs e)
        {                    
            int inputSentenceLength = txtEnterSentence.Text.Length;  //set length of sentence once...not each time thru loop
            int[] numbers = new int[5];

            int inputArraySub = 0;  //begin looking for whitespace 1 position ahead            

            for (; inputArraySub < inputSentenceLength; inputArraySub++)
            {
                StringBuilder parseWord = new StringBuilder(150);
                int subParseWord = 0;
                if (Char.IsLetter(txtEnterSentence.Text, inputArraySub))
                {
                    do
                    {                        
                        parseWord.Insert(subParseWord++, txtEnterSentence.Text[inputArraySub++]);
                    }                    
                    while (Char.IsLetter(txtEnterSentence.Text, inputArraySub));
                    inputArraySub--;                    
                    buildOutputSentence.Append(
                        parseWord.ToString(0,1) 
                        +
                        UniqueCharacters(parseWord)
                        +
                        parseWord.ToString(parseWord.Length -1, 1)
                        );
                    //inputArraySub = endOfWordSub;
                }
                else
                {
                    buildOutputSentence.Append(txtEnterSentence.Text[inputArraySub]);
                    // buildOutputSentence.Insert(endOfWordSub, txtEnterSentence.Text[inputArraySub]);                                    
                }
            }

            lblSentenceResults.Text = buildOutputSentence.ToString(); // +"  test   test";
        }

        // This method finds and returns the number of unique characters 
        // from the StringBuilder object passed to it omitting the first and last characters.
        private int UniqueCharacters(StringBuilder currentWord)
        {
            int numOfUniqueChars = 0;
            if (currentWord.Length > 1)
            {
                string word = currentWord.ToString();
                string code = word.Substring(1, word.Length - 2);  //drop first and last letters           
                string answer = new String(code.Distinct().ToArray());
                numOfUniqueChars = answer.Length;
            }
            else
            {
                numOfUniqueChars = 0;
            }
            return numOfUniqueChars;
        }
    }
}
