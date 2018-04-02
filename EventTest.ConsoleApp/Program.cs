using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var testObject = new TestObject();
            testObject.RaiseTested();

            testObject.Tested += OnTested1;
            Console.WriteLine("Add 'OnTested1' event handler.");
            testObject.RaiseTested();

            testObject.Tested += OnTested2;
            Console.WriteLine("Add 'OnTested2' event handler.");
            testObject.RaiseTested();

            testObject.Tested -= OnTested2;
            Console.WriteLine("Removed 'OnTested2' event handler.");
            testObject.RaiseTested();

            testObject.Tested -= OnTested1;
            Console.WriteLine("Removed 'OnTested1' event handler.");
            testObject.RaiseTested();
        }

        private static void OnTested2(object sender, EventArgs e)
        {
            Console.WriteLine("Called 'OnTested2'.");
        }

        private static void OnTested1(object sender, EventArgs e)
        {
            Console.WriteLine("Called 'OnTested1'.");
        }
    }

    internal sealed class TestObject
    {
        public TestObject()
        {
            Console.WriteLine("Created TestObject.");
        }

        public event EventHandler Tested = delegate { };

        public void RaiseTested()
        {
            Console.WriteLine("Raised 'Tested' event.");
            Tested(this, EventArgs.Empty);
        }
    }
}
