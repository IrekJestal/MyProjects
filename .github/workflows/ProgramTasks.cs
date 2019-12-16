using System;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Test
{
   class static void Main(string[] arg)
   {
      
      List<Task> li = new List<Task>();
      Action<object> fu = (object o) => {Console.WriteLine(o);};

          Task t = new Task(fu,"1");
      
   }
}
