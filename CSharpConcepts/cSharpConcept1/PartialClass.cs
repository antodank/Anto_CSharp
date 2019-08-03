using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept1
{
    class PartialClass
    {
    }

    //nested class
    public class Container
    {
        //Nested types of a class can be public, protected, internal, protected internal, private or private protected
        //A nested type has access to all of the members that are accessible to its containing type
        //both parts of partial class must belong to same assembly
        public class Nested
        {
            private Container parent;

            public Nested()
            {
            }
            public Nested(Container parent)
            {
                this.parent = parent;
            }
        }
    }

    //Partial method - one part of partial class contains method declaration and other parts contains implementation
    //both must be marked with partial 
    //method may or may not be implemented. and if it is not implemented then compiler removes it 
    public partial class CoOrds
    {
        private int x;
        private int y;

        public CoOrds(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        partial void PrintCoOrds();
    }

    public partial class CoOrds
    {
        partial void PrintCoOrds()
        {
            Console.WriteLine("CoOrds: {0},{1}", x, y);
        }

    }

    //partial methods are private and void only and cant be virtual
    //partial methods can contain ref and in but not out parameter
    //partial method can be static or extern

}
