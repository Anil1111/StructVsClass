using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVsClass
{
    public class Program
    {
        public struct semployeee
        {
            public int number;
            public int number2;

            public semployeee(int one, int two)
            {
                this.number = one;
                this.number2 = two;
            }


        }
        static void Main(string[] args)
        {
            employee em = new employee(1, 2);
            Console.WriteLine("this is the initial vale of the class" + em.number1 + "," + em.number2);
            Program mm = new Program();
            mm.mdata(em);
            Console.WriteLine(" this is the modified value of the employee class" + em.number1 + "," + em.number2);

            Console.WriteLine("................................................");


            semployeee emp = new semployeee(30, 20);
            Console.WriteLine(" the struct method values are " + emp.number + "," + emp.number2);
            mm.modifydata(emp);
            Console.WriteLine("afterthe mododification values are " + emp.number + "," + emp.number2);

            Console.ReadLine();
        }

        private void modifydata(semployeee emp)
        {
            emp.number = 2;
            emp.number2 = 4;
            Console.WriteLine(" here is the stuct modofied values" + emp.number + "," + emp.number2);
        }

        

        public void mdata(employee emp)
        {

            emp.number1 = 20;
            emp.number2 = 40;
            Console.WriteLine(" this is modified value of the " + emp.number1 + " , " + emp.number2);


        }

        

    }

}
