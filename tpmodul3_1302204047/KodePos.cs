public class KodePos
{
    public namaKelurahan Kelurahan;

    public KodePos(namaKelurahan Kelurahan)
    {
        this.Kelurahan = Kelurahan;
    }

    public String getKodePos()
    {
        switch (this.Kelurahan)
        {
            case namaKelurahan.Batununggal:
                return "40266";
            case namaKelurahan.Kujangsari:
                return "40287";
            case namaKelurahan.Mengger:
                return "40267";
            case namaKelurahan.Wates:
                return "40256";
            case namaKelurahan.Cijaura:
                return "40287";
            case namaKelurahan.Jatisari:
                return "40286";
            case namaKelurahan.Margasari:
                return "40286";
            case namaKelurahan.Sekejati:
                return "40286";
            case namaKelurahan.Kebonwaru:
                return "40272";
            case namaKelurahan.Maleer:
                return "40274";
            default:
                return "40273";
        }

    }
}

public enum namaKelurahan
{
    Batununggal,
    Kujangsari,
    Mengger,
    Wates,
    Cijaura,
    Jatisari,
    Margasari,
    Sekejati,
    Kebonwaru,
    Maleer,
    Samoja,
}