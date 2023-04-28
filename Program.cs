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
        private static int ReverseNumber(int n){
            int rev=0;
            while(n>0){
                rev=(rev*10)+(n%10);
                n/=10;
            }
            return rev;
        }
        public static void Main(string[] args){
            //int n;
            //Console.Write("Enter limit for fibonacci series: ");
            //n=Convert.ToInt32(Console.ReadLine());
            //Fib(--n);
            //Console.Write("Enter a number: ");
            //n=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Is "+n+" a perfect number? "+PerfectNumber(n));
            //Console.Write("Enter a number: ");
            //n=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Is "+n+" a prime number? "+PrimeNumber(n));
            //Console.Write("Enter a number: ");
            //n=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Reversed Number of "+n+" is: "+ReverseNumber(n));
            /*Console.Write("Enter number of Distinct coupan numbers [upto 100000]: ");
            n=Convert.ToInt32(Console.ReadLine());
            bool [] Dist=new bool[100000];
            for(int i=0;i<n;i++)
                Dist[Convert.ToInt32(Console.ReadLine())]=true;
            Random rnd=new Random();
            int ans=0,r;
            while(true){
                r=rnd.Next(100000);
                if(Dist[r]) break;
                ans++;
            }
            Console.WriteLine(ans+" random number generated for new one");
            */
            Console.Write("Enter start and end time[in 00:00:00 Format]: ");
            string st,ed;
            st=Console.ReadLine();
            ed=Console.ReadLine();
            Console.WriteLine(
              Convert.ToInt16(ed.Substring(0,2))-Convert.ToInt16(st.Substring(0,2))+":"
             +(Convert.ToInt16(ed.Substring(3,2))-Convert.ToInt16(st.Substring(3,2)))+":"
             +(Convert.ToInt16(ed.Substring(6,2))-Convert.ToInt16(st.Substring(6,2)))
            );
        }
    }
}