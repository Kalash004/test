
/*
 Vytvořte třídu Lod, která bude mít jako vlastnosti jméno lodi a rychlost lodi v uzlech. Vlastnosti třídy zapouzdřete a vytvořte metodu ToString(). Do třídy Lod přidejte metodu, která převede rychlost v uzlech na kilometry za hodinu. 

Uzel (knot, značka kt nebo kn) je jednotka rychlosti používaná v mořeplavbě, letectví a meteorologii (tam k určování rychlosti větru). Uzel je definován jako jedna námořní míle (1852 m) za hodinu. 1 kt = 1,852 km·h−1 ≈ 0,5144 m·s−1

Od třídy Lod odděďte třídu Plachetnice, která bude mít jako vlastnost navíc informaci o tom, jestli má napnuté plachty. Vlastnosti třídy zapouzdřete a vytvořte metodu ToString(). 

Dále vytvořte třídu Majitel, která bude mít vlastnosti jméno a příjmení majitele a loď, kterou dotyčný vlastní (bude stačit, aby majitel mohl mít pouze jednu loď). Vlastnosti třídy zapouzdřete a vytvořte metodu ToString(). 

V metodě Main vytvořte jednu loď jménem Helena, která jede rychlostí 40 uzlů a jednu plachetnici jménem Vlašťovka, která jede rychlostí 8 uzlů a má napnuté plachty. Pokuste se změnit lodi Helena její rychlost ze 40 uzlů na -20 uzlů (bylo by vhodné, aby byl váš kód napsán tak, aby tato změna nebyla možná). Dále vytvořte dva majitele - Janu Novákovi přiřaďte jako majiteli loď Helenu a Karlu Sýkorovi přiřaďte jako majiteli plachetnici Vlašťovka. Informace o obou majitelích vypište na obrazovku pomocí metody ToString().

 
 */

namespace ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("started");
        Lod lod = new Lod("Helena",40);
        Lod plachetnice = new Plachetnice("Vlastovka",8,true);

        lod.RYCHLOST=-20;

        Majitel majitel1 = new Majitel("Jana Novakova",lod);
        Majitel majitel2 = new Majitel("Karel Syrkov", plachetnice);

        Console.WriteLine(majitel1.ToString());
        Console.WriteLine(majitel2.ToString());

    }
}
