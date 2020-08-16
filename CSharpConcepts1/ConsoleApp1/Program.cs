using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ============ parent child relation 


            #region Prenthild
            Parent p = new child();
            p.Method();
            p.MethodA();
            p.MethodB();

            Parent p2 = new Parent();
            p2.Method();
            p2.MethodA();
            p2.MethodB();

            child c = new child();
            c.Method();
            c.MethodA();
            c.MethodB();
            c.MethodC();

            ////Child c1 = new Parent();  // will throw error

            Employee emp = null;

            if(emp != null && emp.name == "")
            {
                Write("fff");
            }

            string abc = null;
            Write(abc.Length);

            #endregion


            // =============== deep copy shallow copy
            #region Object Copying technnique

            //Person p1 = new Person() { Name = "Ankit", Age = 30 };
            //Person p2 = p1;

            //p2.Name = "Viraj";
            //p2.Age = 28;

            ////If a field is a value type, a bit-by-bit copy of the field is performed. If a field is a reference type, the reference is copied but the referred object is not
            //Person p3 = p1.ShallowCopy();

            //p3.Name = "Sachin";
            //p3.Age = 32;

            ////== deep copy

            //Employee emp1 = new Employee();
            //emp1.name = "Ankit";
            //emp1.id = "E01";
            //emp1.department = new Department();
            //emp1.department.id = "D01";

            //Employee e2 = emp1.shallowCopy();
            //e2.name = "Viraj";
            //e2.id = "E02";
            //e2.department.id = "D02";

            //Employee e3 = emp1.deepCopy();
            //e3.name = "Sachin";
            //e3.id = "E03";
            //e3.department.id = "D03";

            //ABC aBC = new ABC();
            //aBC.eat(); 

            #endregion


            #region Collections

            //Collection classes are helpful to maintain the state of the data In-Memory, which is later available for read / write operations.

            CollectionClass collectionClass = new CollectionClass();

            int[] arr = collectionClass.getArray();

            ArrayList arrayList = collectionClass.getArrayList();

            Hashtable hastable = collectionClass.getHashTable();

            HashSet<string> hashSet = collectionClass.getHashSet(); // removes duplicate element from coolection as well as strongly typed

            #endregion


            #region Enum

            //int dayValue = (int)EnumTypes.Days.FRI;

            //string Severityname = Enum.GetName(typeof(EnumTypes.Severity), 5);

            //int chrval = (int)EnumTypes.ColorCode.GREEN; 

            #endregion

            //Abstract

            //ClassAbstract objabstract = new ClassAbstract();  // not possible to instatiate

            classDerived derived = new classDerived("Ankit");
            derived.MethodA();
            derived.MethodB();
            derived.MethodC();
            derived.MethodD();

            ClassAbstract objAbstract = new classDerived("Viraj");
            objAbstract.MethodA();
            objAbstract.MethodB();
            objAbstract.MethodC();
            //objAbstract.MethodD(); // not available


            // Delegate

            CallBackA callBackA = new CallBackA();
            delCallBack callback = callBackA.methodcallbackA;

            CallBack testCallBack = new CallBack();

           testCallBack.StartNewTask(callback);


            // collection

            System.Collections.ArrayList fruits = new System.Collections.ArrayList(4);
            fruits.Add("Mango");
            fruits.Add("Orange");
            fruits.Add("Apple");
            fruits.Add(3.0);
            fruits.Add("Banana");






            //int applier = 2;
            //int approver = -1;

            //Console.WriteLine(CheckProfileHierarchy(list, applier,approver));

            ReadLine(); // this is console.ReadLine but since we added static import stmt


        }

        static bool CheckProfileHierarchy(List<ItemInfo> list, int applier, int approver)
        {
            if (applier == approver)
                return true;
            if ((!list.Exists(x => x.ID == applier)) || (!list.Exists(x => x.ID == approver)))
                return false;

            //check parent
            int? prentid = list.FirstOrDefault(x => x.ID == applier).ParentID;

            if (prentid == null) // aplier has no approver 
                return false;
            else if (prentid == approver)
                return true;
            else
                return CheckProfileHierarchy(list, (int)prentid, approver);
        }

        static List<ItemInfo> fillList()
        {
            var list = new List<ItemInfo>()
            {
                new ItemInfo(){ID = -1,ParentID = null, Name = "Administrator" },
                new ItemInfo(){ID = 1,ParentID = 2, Name = "BA" },
                new ItemInfo(){ID = 2,ParentID = 3, Name = "SMT" },
                new ItemInfo(){ID = 3,ParentID = -1, Name = "Store Manager" },
                new ItemInfo(){ID = 4,ParentID = 2, Name = "Cashier" },
                new ItemInfo(){ID = 5,ParentID = 2, Name = "Accountant" },
            };

            return list;
        }

        private class ItemInfo
        {
            public int ID;
            public int? ParentID;
            public string Name;

            public string domain;
        }

        private static double AddNumbers(double num1, double num2) => num1 + num2;


    }
}
