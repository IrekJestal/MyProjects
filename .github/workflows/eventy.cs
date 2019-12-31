using System;
namespace eventyk
{

class Fool
{
   public event delus eventowy;
   public event delus event2
   {
      add{eventowy+= value; Console.WriteLine("ADD");}
       remove{eventowy-= value;Console.WriteLine("REMOVE");}

   }


   public delegate void delus(string g); 

   public void fun(string r)
   {
     Console.WriteLine(r);
   }

private string npek;
   public string napis
   {
       get{return npek;}
       set{npek = value; Console.WriteLine("Event poszed i wypisal:"); eventowy(value);}
   }

  }
}