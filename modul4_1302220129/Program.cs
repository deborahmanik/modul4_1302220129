
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;

public class KodeBuah
{
    public static void Main(string[] args)
    {
        KodeBuah a = new KodeBuah();
        Console.WriteLine("kode buah semangka");
        a.getKodeBuah("Semangka");
    }

    Dictionary<string, string> buah = new Dictionary<string, string>()
    {
        { "Apel" ,"A00" },
        {"Aprikot", "B00" }, 
        {"Alpukat", "C00" }, 
        {"Pisang", "D00" }, 
        {"Paprika", "E00" }, 
        {" Blackberry"," F00" },
        {"Ceri"," H00" },
        {"Kelapa"," I00" },
        {"Jagung"," J00" },
        {"Kurma"," K00" },{"Durian"," L00" },{"Anggur"," M00" },{"Melon"," N00" },{"Semangka"," O00" }

    };

    public void getKodeBuah (string kode)
    {
        if (buah.ContainsKey(kode))
        {
            Console.WriteLine( kode + ":" + buah[kode]);
        }
        else
        {
            Console.WriteLine(kode + "tidak ditemukan");
        }
    }
    /*public static string getKodeBuah(NamaBuah buah)
    {
        return KodeBuah[(int)NamaBuah];
    }
    public enum NamaBuah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka;
    }
    public static string getKodeBuah(KodeBuah n)
    {
       
    }*/
}
