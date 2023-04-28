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
        private static bool PerfectNumber(int n){
            int sm=1;
            for(int i=2;i<=n/2;i++)
                if(n%i==0)
                    sm+=i;
            return sm==n;
        }
        private static bool PrimeNumber(int n){
            for(int i=2;i<n;i++)
                if(n%i==0)
                    return false;
            return true;
        }
        public static void Main(string[] args){
            int n;
            //Console.Write("Enter limit for fibonacci series: ");
            //n=Convert.ToInt32(Console.ReadLine());
            //Fib(--n);
            //Console.Write("Enter a number: ");
            //n=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Is "+n+" a perfect number? "+PerfectNumber(n));
            Console.Write("Enter a number: ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is "+n+" a prime number? "+PrimeNumber(n));
        }
    }
}