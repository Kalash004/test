using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lod
    {
        private String jmeno;
        private double rychlost;

        public Lod(String jmeno, double rychlost) 
        {
            // check
            JMENO = jmeno;
            RYCHLOST = rychlost;

        }

        public String JMENO
        {
            get 
            {
                return jmeno; 
            }
            set 
            { 
                jmeno = value; 
            }
        }

        public double RYCHLOST
        {
            get 
            {
                return rychlost;
            }
            set 
            { 
                if (value > -1)
                {
                    rychlost = value; 
                } else
                {
                    Console.WriteLine("Rychlost byla zmenena na 0, protoze nemuze byt zaporna");
                    rychlost = 0;
                }
            }
        }

        public double ChangeToKm()
        {
            return this.rychlost * 1.852;
        }

        public override string ToString()
        {
            return String.Format("Jmeno lode : {0} \n" +
                "Rychlost lode: {1} \n",this.jmeno,this.rychlost);
        }
    }
}
