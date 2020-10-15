using System;
using System.Threading;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string SENHA, senhaSecreta="1234abcd";
            int sair=0;
          do
          {
            Console.Clear();
            print("*********",14,0,15,0);
            print("* SENHA *",14,0,15,1);
            print("*********",14,0,15,2);

            print(" Entre com a senha secreta:",0,10,5,4);
            SENHA = Console.ReadLine();
              if (SENHA == senhaSecreta)
                  {sair=1; 
                  print("                           ",0,0,5,4);
                  print("                                 ",0,10,10,4); 
                  print("         Acesso Autorizado !     ",0,10,10,5);
                  print("                                 ",0,10,10,6);                                   
                  }
              else{ 
                    Console.Beep();                                
                   print("                           ",0,0,5,4);
                   print("                                ",0,12,10,4);
                   print("          Acesso Negado!        ",0,12,10,5);
                   print("                                ",0,12,10,6);                                    
                  }   
            Thread.Sleep(1000);
            Console.Beep();
           } //Fecha do
          
           while (sair!=1);
           Console.Clear();            
         }// fecha Main


         static void print(String S, int COR_Caracter,int COR_Fundo, int X,int Y)
          {
           ConsoleColor CorC = (ConsoleColor)COR_Caracter;
           ConsoleColor CorF = (ConsoleColor)COR_Fundo;
           Console.ForegroundColor = CorC;
           Console.BackgroundColor = CorF;
           Console.SetCursorPosition(X, Y);
           Console.Write(S);
           Console.ResetColor();
          }//fecha print
    }
}
