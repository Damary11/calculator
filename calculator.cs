class Calculator
{
	static void Main (string[] args)
	{
		int a =10;
		int b =6;
		
		Console.WriteLine("Hasil Penambahan: (0) + (1) =(2)",a,b, Penambahan(a,b));
		Console.WriteLine("Hasil Penambahan: (0) - (1) =(2)",a,b, pengurangan(a,b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.ReadKey();
	}
	static int penambahan(int a. int b)
	{
		return a+b;
	}
	static int pengurangan(inta a,int b)
	{
		return a-b;
	}
}