using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Luke Duell
 * Instructor: Instructor Murray
 * CSCI 312
 * Hashing Assignment
 * Description: This program uses hashing to translate user ID numbers into
 *              smaller data sizes to decrease the size of the file. This in turn 
 *              makes the compiling quicker.
 */

namespace CSCI312_LukeDuell_HashingAssignment
{
    class Program
    {
        static int HashFunction(string s, string[] array)
        {
            char[] character;
            int sum = 0;
            int output = 0;
            character = s.ToCharArray();

            //using ASCII values to sum alphabet in the string and make the hash code
            for (int i = 0; i <= character.GetUpperBound(0); i++)
                sum = sum + (int)character[i];

            output = sum % array.GetUpperBound(0);

            return output;
        }

        static void Main()
        {
            string[] studentid = new string[100];
            string tempstr;

            //student id values
            string[] keys = new string[] {"99999999", "75000000", "50000000", "25000", "15000", "10000", "5000", "1"};

            int hashCode;

            for (int i = 0; i < 8; i++)
            {
                tempstr = keys[i];

                //using hash function to shorten the values
                hashCode = HashFunction(tempstr, studentid);

                studentid[hashCode] = tempstr;
            }

            //output of hashcode to console
            for (int i = 0; i < (studentid.GetUpperBound(0)); i++)
            {
                if (studentid[i] != null)
                    Console.WriteLine(i + " " + studentid[i]);
            }
        }
    }
}
