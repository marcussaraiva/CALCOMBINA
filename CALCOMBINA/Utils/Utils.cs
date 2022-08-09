namespace CALCOMBINA.Utils
{
    public class Utils
    {
        public static long CalcularFatorial(long variavel)
        {
            long fatorial;

            if (variavel <= 1)
            {
                return 1;
            }
            else
            {
                fatorial = variavel * CalcularFatorial(variavel - 1);
                return fatorial;
            }
        }
    }
}
