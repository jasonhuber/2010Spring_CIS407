using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDLL
{
    public class Calc
    {
           public int Add(int x, int y)
           {
               return x + y;

           }
           public int Subtract(int x, int y)
           {
               return x - y;

           }
           public int Divide(int x, int y)
           {
               try
               {
                   return x / y;

               }
               catch (Exception ex)
               {
                   throw ex;
               }
               
           }
           public int Multiply(int x, int y)
           {
               return x * y;

           }

    }
}
