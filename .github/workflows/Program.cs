using System;
using WORD2;
  
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Diagnostics;
using przewany = delega.deliga; //synonim typu clasy deliga na przewany
using ev = eventyk.Fool;
using et = over.overek;
namespace WORD
{
    class Program
    {
      


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

void fuk2(string f)
{
    Console.WriteLine(f);
}


    
          et clis = new et();
     
           clis.event2 += fuk2;
           clis.napis = "fsfsdf alem zem teraz zrobil";
           
         ev evid = new ev();

          //evid.napis = "moj testowy napis bez podpietej funkcji";
       przewany g = new przewany();  //Costruowanie nowego obiektu g typu deliga z przewaniem jej na przewany
       g.NaConsole("tu dodaje do eventu");

        evid.event2 += fuk2;
 
        evid.napis = "evencik jest ok";
       g.NaConsole("tu kasuje z eventu");     
     evid.event2 -= fuk2;
     
       g.NaConsole("tu dodaje do starego eventu");
     evid.eventowy += fuk2;
    evid.napis = "evencik jest ok?";
     przewany.stri = "Ale w koncu";  //Nadanie wartoi poczatkowej
    
    
    ev.delus[] dd = new ev.delus[4];
    dd[0] =   new ev.delus(fuk2);
    dd[0].Invoke("fsfsdf");


      przewany.Strumien(przewany.WypNaConsoli);  //Ustawienie strumienia i wypisanie stri funkcja statyczna;
      przewany.Strumien(przewany.ZapDoPliku);   //Ustawienie strumienia i wypisanie stri funkcja statyczna;
     
      g.NaConsole("To nowa funkcja lokalna do testw"); //uzycie funkcji niestatycznej ktora ustawia strumien i wypisuje 

      przewany.cozrobic fun = g.sumuj;
       int suma =  fun(5,7);
       g.NaConsole(suma.ToString());
       g.Text ="BlaBal";
       g.NaCOnsole2(przewany.WypNaConsoli);
       g.fun2("Tu jest ostra konbinacja");

        przewany.wypisz delu = new przewany.wypisz(przewany.WypNaConsoli);
       delu.Invoke("To ju wogle jest kombinacja alpijskla");
     
     void toJak(string doWyp)
     {
          Console.WriteLine(doWyp);
     }
     przewany.wypisz delu2 = new przewany.wypisz(toJak);

   delu2+= toJak;
   delu2.Invoke("No zobaczymy czy dwa razy");

    Action<string > nowys   = toJak;

    przewany.wypisz delu3 = new przewany.wypisz(new Action<string>(toJak));

    delu3("Wypisuj cos bo 33333333333...");

            NOWAClassa cs = new NOWAClassa();
            Console.WriteLine($"tu zwraca-> {cs.GetNewMesage()}");
            var sss = new Noew2();
            Console.WriteLine($"Moja nowa->> {sss.zwroc(4)}");
            sss.Zmien = 1000;
            Console.WriteLine($"zwrca{sss.Zmien}");

            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));


        Task [] tasks = new Task[10];

FileStream str1 = new FileStream("C:\\TMP\\testowy.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.Read);
FileStream str2 = new FileStream("C:\\TMP\\testowy2.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.Read);

FileStream out1 = new FileStream("C:\\TMP\\testowyOut1.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.Read);
FileStream out2 = new FileStream("C:\\TMP\\testowyOut2.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.Read);

 

void obsuz1()
{
  List<Task> lit = new List<Task>();
  lit.Add(licz(str1,out1,1));
  lit.Add(licz(str2,out2,2));
  lit.Add(fu1(1)); 

   


 Task.WhenAll(lit);
  while(lit[0].IsCompleted == false)
  {
    fu2(2);
  }
}

async Task fu1(int a)
{
  Console.WriteLine("Start Task 1");
  await Task.Delay(50);
  Console.WriteLine("Po czekaniu Task 1");
   
}
void fu2(int a)
{
  Console.WriteLine("Start Task 2");
  System.Threading.Thread.Sleep(2000);
  Console.WriteLine("Po czekaniu Task 2");
   
}


async Task licz(FileStream file, FileStream outi, int numer)
{
   var sWatcher = new Stopwatch();
   sWatcher.Start();
   Console.WriteLine($"Wystartowal o nr{numer}");
   long endy =  file.Length;
   await Task.Run(() => {
     for(long u = 0 ; u < file.Length; u++)
     {
     file.Position = u;
     int bb  = file.ReadByte();
     file.Position = endy;
     bb  += file.ReadByte();
     endy--;
     outi.WriteByte((byte)bb);
     }
   });
   sWatcher.Stop();
   Console.WriteLine($"Koniec tasku o nr{numer}");
   Console.WriteLine($"Summary of task {numer} {sWatcher.ElapsedTicks} {sWatcher.ElapsedMilliseconds} {sWatcher.Elapsed}  " );
   
}
void licz2(FileStream file, FileStream outi, int numer)
{
   var sWatcher = new Stopwatch();
   sWatcher.Start();
   Console.WriteLine($"Wystartowal o nr{numer}");
   long endy =  file.Length;
   
   for(long u = 0 ; u < file.Length; u++)
   {
     file.Position = u;
     int bb  = file.ReadByte();
     file.Position = endy;
     bb  += file.ReadByte();
     endy--;
     outi.WriteByte((byte)bb);
   }
   sWatcher.Stop();
   Console.WriteLine($"Koniec tasku o nr{numer}");
   Console.WriteLine($"Summary of task {numer} {sWatcher.ElapsedTicks} {sWatcher.ElapsedMilliseconds} {sWatcher.Elapsed}  " );
   
}

obsuz1();
 Console.WriteLine("Wylaz ");
 
  Console.WriteLine("A co teraz");
return;

//FileStream fs = new FileStream("testowy.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.Read);
//fs.Position = 0;



ArrayList array = new ArrayList();
IList<List<byte[]>> gg= new List<List<byte[]>>();
List<byte[]> li = new List<byte[]>();

gg.Add(li);

array.Add("rewrew");
array.Add(1);
Random r = new Random();




int fufu()
{
 Console.WriteLine("trtyr");
return 4;
}

Func<int> t = fufu;


var ts  = new Task[3];
int funy (int te, int y){
    return 6;
}

Func<int,int,int> gtg = funy;
var ggg = funy(4,5);


 async Task DoWork()
{
    int res = await Task.FromResult<int>(funy(4,5));   
}

 DoWork().Start();

         Action<object> fu = (object o) => {Console.WriteLine(o);};

           Task t2 = new Task(fu,"1");

      
        }


   delegate int funia(int a);
funia f = (a) => 6*a;



    }
}
