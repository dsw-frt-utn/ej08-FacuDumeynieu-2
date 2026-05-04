namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var helper = new ProductHelper();
            string resultado = helper.ObtenerEtiquetaProducto(01, "sobre mundial", 2000);
            Console.WriteLine(resultado);
        }
    }
}
