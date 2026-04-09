class Calculator
{
	static void Main (string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan: {o} + {1} = {2}", a, b, Penambahan(a, b));
		Console.WriteLine("Hasil Pengurangan: {o} - {1} = {2}", a, b, Pengurangan(a, b));
		
		Console.WriteLine("\nTekan Sembarang Key Untuk Keluar");
		Console.ReadKey();
	}
	
	static int Penambahan(int a, int b,)
	{
		return a + b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
	
}