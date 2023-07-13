namespace delegates
{
    internal class Program
    {
        delegate void mydelegate(int say1, int say2);
        static void Main(string[] args)
        {
            mydelegate menimdelegate = new mydelegate(topla);
            menimdelegate.Invoke(4, 5);
            Console.WriteLine("Hello, World!");
        }
        static void topla(int eded1,int eded2) 
        {
            Console.WriteLine(eded1+eded2);
        }
    }
}