ImageProcessor imageProcessor = new ImageProcessor();

imageProcessor.Rezise(-20);
imageProcessor.Rezise(80);
imageProcessor.Rezise(150);
imageProcessor.Rezise(100);
imageProcessor.Rezise(15, 25);
imageProcessor.Rezise(300);


class ImageProcessor
{
    public void Rezise(int presentance)
    {
        if (presentance <= 0)
        {
            Console.WriteLine(" Eror presentase tidak boleh nol(0) atau negatif");
        }
        if (presentance < 100)
        {
            Console.WriteLine(" Mengecilkan gambar menjadi (presentase)%");
        }
        if (presentance > 100)
        {
            Console.WriteLine(" Membesarkan gambar menjadi (presentase)%");
        }
        else
        {
            Console.WriteLine(" Ukuran tetap (100%). Tidak ada perubahan");
        }
    }
    public void Rezise(int presentance, int lebar, int tinggi)
    {
        {
            Console.WriteLine($" Mengubah ukuran gambar menjadi {lebar}px X {tinggi}px");
        }
    }
    public void Rezise(string ukuran_kertas)
    {
        Console.WriteLine($" Menyesuaikan ke format kertas {ukuran_kertas}");
    }

}