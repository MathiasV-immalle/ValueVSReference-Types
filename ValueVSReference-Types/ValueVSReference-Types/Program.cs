using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVSReference_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            OefMyClass();
            OefMyClass();
            OefMyClass();
            OefMyStruct();
            OefMyStruct();
            OefMyStruct();
        }

        public static void OefMyClass()
        {
            MyClass mc;
            mc = new MyClass();
            Console.WriteLine(mc);
            Console.WriteLine(mc.GetHashCode());
        }
        public static void OefMyStruct()
        {
            MyStruct ms;
            ms = new MyStruct();
            Console.WriteLine(ms);
            Console.WriteLine(ms.GetHashCode());
        }

    }

    struct MyStruct
    {
        public string Beschrijving;
        public int Hoeveelheid;
        public override string ToString()
        {
            return String.Format("Beschrijving: [{0}] - Hoeveelheid: [{1}]", Beschrijving, Hoeveelheid);
        }
    }
    struct MyInheritedStruct /* : MyStruct */ { }
    // gaat niet -> ("Type 'MyStruct' in interface list is not an interface")
    class MyClass
    {
        public string Beschrijving { get; set; }
        public int Hoeveelheid { get; set; }

        public override string ToString()
        {
            return String.Format("Beschrijving: [{0}] - Hoeveelheid: [{1}]", Beschrijving, Hoeveelheid);
        }
    }
    class MyInheritedClass : MyClass { }
}
