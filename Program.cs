
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameList
{
    //------------------------------------------------------------------------------------------------------------------//
    // <summary>
    // The Program class contains the Main method.
    // </summary>
    class Program
    {
        //-------------------------------------------------//
        // Main method - entry point of the program
        static void Main(string[] args)
        {
            //-------------------------------------------------//
            // Create a NameList instance
            NameList myNames = new NameList();
            //-------------------------------------------------//

            //-------------------------------------------------//
            // Add names using the indexer
            myNames[0] = "Dylan Shortt";
            myNames[1] = "John Doe";
            myNames[2] = "Jane Smith";
            //-------------------------------------------------//

            //-------------------------------------------------//
            // Update a name
            myNames[1] = "John Smith";
            //-------------------------------------------------//

            //-------------------------------------------------//
            // Print all names
            Console.WriteLine("Name List:");
            for (int i = 0; i < myNames.Count; i++)
            {
                Console.WriteLine($"Index {i}: {myNames[i]}");
            }
            //-------------------------------------------------//

            //-------------------------------------------------//
            // Try accessing out-of-range index
            Console.WriteLine($"Index 10: {myNames[10]}");
            //-------------------------------------------------//
        }
        //-------------------------------------------------//
    }
    //------------------------------------------------------------------------------------------------------------------//
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//