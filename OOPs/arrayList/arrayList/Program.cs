using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
		/*
		 *  the use of an ordered collection of an object that can be indexed individually.
		 *  data ne add karva obj.add
		 *  delete karva	obj.remove
		 *  range ne remove karvi hoy to .remove(x , y) 2 parameter pass thay 
		 */ 


		static void Main(string[] args)
        {
            ArrayList arlist = new ArrayList();
			var arlist1 = new ArrayList();
			arlist1.Add(1);
			arlist1.Add("Bill");
			arlist1.Add(" ");
			arlist1.Add(true);
			arlist1.Add(4.5);
			arlist1.Add(null);

			// adding elements using object initializer syntax
			var arlist2 = new ArrayList()
					{
						2, "Steve", true, 4.5, null
					};
			Console.WriteLine("ArrayList 1 Elements");

			for (int i = 0; i < arlist1.Count; i++)
				Console.WriteLine(arlist1[i]);

			Console.WriteLine("ArrayList 2 Elements");

			for (int i = 0; i < arlist2.Count; i++)
				Console.WriteLine(arlist2[i]);
		}
	
    }
}
