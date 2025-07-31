//------------------------------------------------------------------------------------------------------------------//
// Name: Dylan Shortt
// Group: 1
// Student Number: ST-10438409
//------------------------------------------------------------------------------------------------------------------//

//------------------------------------------------------------------------------------------------------------------//
// Reference: 
// GitHub Copilot. (2025). AI programming assistant. [online] Available at: https://copilot.github.com/ [Accessed: 2025].
//------------------------------------------------------------------------------------------------------------------//

//------------------------------------------------------------------------------------------------------------------//
// <summary>
// These import statements are used to import the necessary libraries for the program to run.
// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//------------------------------------------------------------------------------------------------------------------//

//------------------------------------------------------------------------------------------------------------------//
// <summary>
// The namespace is used to group classes that are logically related.
// </summary>
namespace NameList
{
    //------------------------------------------------------------------------------------------------------------------//
    // <summary>
    // The Program class contains the Main method, which is the entry point of the program.
    // </summary>
    public class NameList
    {
        //-------------------------------------------------//
        // Private list to store names
        private List<string> names = new List<string>();
        //-------------------------------------------------//

        //-------------------------------------------------//
        // Indexer to get or set names
        public string this[int index]
        {
            //----------------------------------------------//
            // If index is valid, return the name at that index
            get
            {
                //----------------------------------------------//
                // Check if index is within the range of the list
                if (index >= 0 && index < names.Count)
                {
                    return names[index];
                }
                //----------------------------------------------//
                else
                    return "Index out of range.";
            }
            //----------------------------------------------//

            //----------------------------------------------//
            // If index is valid, set the name at that index
            set
            {
                //----------------------------------------------//
                // Check if index is within the range of the list
                if (index >= 0 && index < names.Count)
                    names[index] = value;
                //----------------------------------------------//

                //-----------------------------------------------//
                // If index is -1, add the name to the end of the list
                else if (index == -1)
                    names.Add(value);
                //-----------------------------------------------//

                //-----------------------------------------------//
                // If index is equal to the count of names,
                // add the name to the end of the list
                else if (index == names.Count)
                    names.Add(value);
                //-----------------------------------------------//

                //-----------------------------------------------//
                // If index is invalid, do not insert the name
                else
                    Console.WriteLine("Invalid index. Cannot insert.");
                //-----------------------------------------------//
            }
            //----------------------------------------------//
        }
        //------------------------------------------------//

        //-------------------------------------------------//
        // Property to get total count (optional)
        public int Count => names.Count;
    }
    //------------------------------------------------------------------------------------------------------------------//
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//