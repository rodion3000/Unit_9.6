using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyException myException = new MyException();
            ArgumentException argumentException = new ArgumentException();
            FileNotFoundException fileException = new FileNotFoundException();
            IndexOutOfRangeException indexOutOfRangeException = new IndexOutOfRangeException();
            DivideByZeroException divide = new DivideByZeroException();
            
            Exception[] ExceptionMassive = new Exception[] {myException,argumentException,fileException,indexOutOfRangeException,divide};
            foreach(Exception x in ExceptionMassive)
            {
                try
                {
                    throw x;


                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (MyException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
              
            }
            
        }
    }
}

