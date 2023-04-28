namespace BlDay6Problems{
    class Program{
        private static void Fib(int n){
            int a=0,b=1;
            Console.Write("First "+(n+1)+" Fibonacci numbers: 0 1 ");
            while(--n>0){
                b=a+b;
                a=b-a;
                Console.Write(b+" ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args){
            int n;
            Console.Write("Enter limit for fibonacci series: ");
            n=Convert.ToInt32(Console.ReadLine());
            Fib(--n);
        }
    }
}