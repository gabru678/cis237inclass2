using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Hanoi
    {
        public void moveDisk(int n, char source, char auxilary, char destination)
        {
            //Base Case to exit recursive loop
            if (n == 1)
            {
                //Since we only have to move one disk. (n==1), we dont want to make another recursive call.  
                // we just want ot ouput the move that we are performing
                Console.WriteLine("Move disk from tower {0} to tower {1}", source, destination);
            }
            else
            {
                // Note: the desctriptions of the source, aux, and desstination are reffering to 
                // the fist time this moveDisk method is called.
                // As recursion works, it may not mae sense to assocaiate the work source with a peg letter


                // Attempt to move (n-1) disks from souce location (A) to the aux (B) to the destination (C)
                // Using the C peg as the temp storage
                moveDisk(n - 1, source, destination, auxilary);

                // Move the Source disk (A) to the Destination (C) using Aux (B) as temp storage
                moveDisk(1, source, auxilary, destination);

                // Move the (n-1) from Aux (B) to the Destination (C) using the beginning (A) as temp storage
                moveDisk(n - 1, auxilary, source, destination);

            }

        }
    }
}
