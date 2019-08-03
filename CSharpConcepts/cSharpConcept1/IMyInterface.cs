using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpConcept1
{
    //can contains events, indexers, methods, and properties.
    //An interface can't contain constants, fields, operators, instance constructors, finalizers, or types
    //Interface members are public only and cant be static
    interface IMyInterface
    {
        string firstname { get; set; }
        string lastname { get; set; }

        void getSalary();
        Single getHike();
    }
}
