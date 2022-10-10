using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Majitel
    {
        private String jmeno_prijmeni;
        private Lod lod;

        public Majitel(String jemeno_prijmeni, Lod lod)
        {
            this.jmeno_prijmeni = jemeno_prijmeni;
            this.lod = lod;
        }

        public String JMENO
        {
            get { return jmeno_prijmeni; }
            set { jmeno_prijmeni = value; }
        }
        public Lod LOD
        {
            get { return lod; }
            set { lod = value; }
        }
        public override string ToString()
        {
            return String.Format("Jmeno majitele: {0} \n" +
                "Lod : {1}",this.jmeno_prijmeni,this.lod.ToString());
        }

    }
}
