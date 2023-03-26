using tpmodul6_1302210090;

class MainClass{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [NAMA_PRAKTIKAN]");
        try{
            video.IncreasePlayCount(-1);
        }
        catch (ArgumentOutOfRangeException ex){
            Console.WriteLine("Error: " + ex.Message);
        }

        try{
            video.IncreasePlayCount(15000000);
        }
        catch (ArgumentOutOfRangeException ex){
            Console.WriteLine("Error: " + ex.Message);
        }
        try{
            for (int i = 0; i < 1000000; i++)
            {
                checked
                {
                    video.IncreasePlayCount(10000);
                }
            }
        }
        catch (OverflowException ex){
            Console.WriteLine("Error: " + ex.Message);
        }

        video.PrintVideoDetails();
    }
}
