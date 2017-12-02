using System;

namespace Prime {
    class Prime {
        public static bool isPrime(ulong i, bool d, bool c) {
            DateTime start = DateTime.Now;
            if(i==0 || i % 2 == 0) {
                return false;
            }
            for(ulong k = 0; k<i; k++) {
                if (d) Console.WriteLine("Now checking if {0} is a prime compared to {1}", i, k);
                if(k==0||k==1||k==i) {
                    continue;
                }
                if(i % k == 0) {
                    return false;
                }
            }
            if(c) Console.WriteLine("Checked if prime in {0}ms", DateTime.Now.Subtract(start).TotalMilliseconds);
            return true;
        }
        public static ulong generateLongPrime(bool d) {
            DateTime start = DateTime.Now;
            ulong r;
            byte[] buffer = new byte[8];
            Random rand = new Random();
            do {
                rand.NextBytes(buffer);
                r = BitConverter.ToUInt64(buffer, 0);
            } while(!isPrime(r, d, false));
            Console.WriteLine("generated a number in {0}ms", DateTime.Now.Subtract(start).TotalMilliseconds);
            return r;
        }
        public static uint generatePrime(bool d) {
            DateTime start = DateTime.Now;
            uint r;
            byte[] buffer = new byte[4];
            Random rand = new Random();
            do {
                rand.NextBytes(buffer);
                r = BitConverter.ToUInt32(buffer, 0);
            } while(!isPrime(r, d, false));
            Console.WriteLine("generated a number in {0}ms", DateTime.Now.Subtract(start).TotalMilliseconds);
            return r;
        }
        public static UInt16 generateShortPrime(bool d) {
            DateTime start = DateTime.Now;
            UInt16 r;
            byte[] buffer = new byte[2];
            Random rand = new Random();
            do {
                rand.NextBytes(buffer);
                r = BitConverter.ToUInt16(buffer, 0);
            } while(!isPrime(r, d, false));
            Console.WriteLine("generated a number in {0}ms", DateTime.Now.Subtract(start).TotalMilliseconds);
            return r;
        }
    }
}
