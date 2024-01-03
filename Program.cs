namespace Mantiqiy_toifa_boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine("isTrue qiymati: " + isTrue);
            Console.WriteLine("isFalse qiymati: " + isFalse);

            // Mantiqiy operatorlar: && (va), || (yoki), ! (not)
            bool resultAnd = isTrue && isFalse;
            bool resultOr = isTrue || isFalse;
            bool resultNot = !isTrue;

            Console.WriteLine("Va (&&) operatori: " + resultAnd);
            Console.WriteLine("Yoki (||) operatori: " + resultOr);
            Console.WriteLine("Not (!) operatori: " + resultNot);

            Console.WriteLine(Math.Sign(-423234));
        }
    }
}
