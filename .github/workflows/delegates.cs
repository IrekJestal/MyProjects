using System;
using System.IO;
using Sys = System;
 namespace delega
{

   class deliga
   {
       public delegate void wypisz(string s); 

public delegate void eventowy();
public event eventowy UruchomEvent;

protected virtual void OnUruchomEvent()
{
   Console.WriteLine("Event uruchomiony");
}

       public static  string stri{get;set;}
        
 
      public static void WypNaConsoli(string str)
      {
          Console.WriteLine(str);
      }

      public static void ZapDoPliku(string str)
      {
         FileStream fs = new FileStream("C:\\TMP\\testowy.txt",FileMode.Truncate,FileAccess.Write,FileShare.Read);
         StreamWriter sw = new StreamWriter(fs);
         sw.WriteLine(str);
         sw.Flush();
         sw.Close();
         fs.Close();
      }

    public static void Strumien(wypisz yp)
    {
        yp(stri);
    }

    public void NaConsole(string wyyy)
    {
        stri = wyyy;
        Strumien(WypNaConsoli);
    }

public void NaCOnsole2(wypisz strii) => Strumien(strii); 




public Action<string> fun2 = (string stry) => {stri = stry; Strumien(WypNaConsoli);Strumien(ZapDoPliku);};

     public delegate int cozrobic(int a, int b);

     public int sumuj(int a, int b)
     {
        return a+b;
     }
     
     int nr;

     public int Nr
     {
         set {nr = value< 0 ?  0 :  value;}
         get {return nr;}
     }
         
         int ju;
         public int Ju
         {get;set;}

        string text;
        public string Text
        {
            get{return text[3].ToString();}
            set{text = value;}
        }

       string jakis = "Jakis napis".Substring(2,2);
       
      

   }
}