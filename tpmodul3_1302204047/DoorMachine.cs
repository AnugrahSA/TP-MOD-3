public class DoorMachine
{
    private Keadaan keadaan = Keadaan.Terkunci;

    public void setKeadaan(Keadaan keadaan)
    {
        this.keadaan = keadaan;
    }

    public void printStatus()
    {
        switch (this.keadaan)
        {
            case Keadaan.Terkunci:
                Console.WriteLine("Pintu Terkunci");
                break;
            case Keadaan.Terbuka:
                Console.WriteLine("Pintu Tidak Terkunci");
                break;
        }
    }
}

public enum Keadaan
{
    Terkunci,
    Terbuka,
}
