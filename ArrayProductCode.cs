//==============================================================================================================================
// Programmer: Kevin Fair
// Date: 11/25/2019
// C# CIST2341 Dr. Morguson
// Program Description: This program uses compile time initialization to set values for 2 arrays with different sizes 
//      of type double. The program will then multiply the 2 arrays to set values for the 3rd array, which has no initialized values.
//      There is a multiplier of 1 to account for the indexes which are greater in one array than the other.
//==============================================================================================================================      
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;

namespace ArrayProductCode
{
    class ArrayProductCode
    {
        //Beginning of Main() function.
            static void Main()
            {
            //Initializing values for the 2 arrays, declaring a 3rd array of size 10
            double[] array1 = { 1, 3, 6, 9, 12, 15, 18, 21, 24, 27 };
            double[] array2 = { 2, 4, 6, 8, 10, 12 };
            double[] array3 = new double[10];

            //Initializing the multiplier for the indexes which do not appear in both arrays.
            int multiplier = 1;

            //Initializing the strings used for outputting the data in a message box.
            string outputMsg = "", outputMsg2 = "", outputMsg3 = ""; //outputTotal = "";
            
            //for loop, with a nested if, else to calculate the values to be assigned in to the 3rd array.
            for (int i = 0; i < array1.Length; i++)
            {
                if (i < array2.Length)
                {
                    array3[i] = array1[i] * array2[i];
                }
                else
                {
                    array3[i] = (array1[i] * multiplier);
                }
            }

            //Creating the outputMsg strings to be displayed in the message box.
            outputMsg += "Array 1: \n";
            foreach (double aVal1 in array1)
                outputMsg += aVal1 + "\n";

            outputMsg2 += "Array2: \n";
            foreach (double aVal2 in array2)
                outputMsg2 += aVal2 + "\n";

            outputMsg3 += "Array 3 (Product): \n";
            foreach (double aVal3 in array3)
                outputMsg3 += aVal3 + "\n";

            
                //outputTotal = String.Format("{0,-15}   {1, -15}   {2, -15}", outputMsg, outputMsg2, outputMsg3);

            //Message box displaying the values of all 3 arrays.
            //I could not figure out how to format these arrays into 3 columns side-by-side. I looked for
            //formatting options through the book and online, but I wasn't able to find what I needed.
            //I remember in class you had some formatting in this line of code, if you dont mind refreshing me
            //I would be glad to re-format and re-submit.
            MessageBox.Show(String.Format("{0,-15}   {1, -15}   {2, -15}", outputMsg + outputMsg2 + outputMsg3, "Arrays"));              

            
            }
        }
    }



