using System;

namespace tpmodul6_1302210090
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        public SayaTubeVideo(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int count)
        {
            if (count <= 0 || count > 10000000)
            {
                throw new ArgumentOutOfRangeException("count", "Input penambahan play count harus berada di antara 1 dan 10.000.000.");
            }
            this.playCount += count;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play count: " + this.playCount);
        }
    }
}

