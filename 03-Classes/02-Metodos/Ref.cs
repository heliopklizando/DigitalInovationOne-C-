namespace Classes.Metodos
{
    public class Ref
    {
        static voi Inverter(ref in x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}"); // Escrever "2 1"
        }
    }
}