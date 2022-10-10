using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Plachetnice : Lod
    {
        private Boolean naple_plachty;
        public Plachetnice(string jmeno, double rychlost, Boolean plachty) : base(jmeno, rychlost)
        {
            this.naple_plachty = plachty;
        }

        public Boolean PLACHTY
        {
            get { return naple_plachty; }
            set { naple_plachty = value; }
        }

        public override string ToString()
        {
            return base.ToString()+"Plachetnice : "+naple_plachty;
        }
    }
}
