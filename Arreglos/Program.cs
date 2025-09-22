namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pila pila = new Pila(5);

                pila.Agregar("A");
                pila.Agregar("B");
                pila.Agregar("C");
                pila.Agregar("D");
                pila.Agregar("E");
                

                Console.WriteLine(pila.Imprimir());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
