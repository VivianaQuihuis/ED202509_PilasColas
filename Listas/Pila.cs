namespace Listas
{
    internal class Pila
    {
        List<string> _arreglo;

        public Pila(int elementos)
        {
            _arreglo = new List<string>(elementos);
        }

        public void Agregar(string dato)
        {
            if (_arreglo.Count >= _arreglo.Capacity) ;
            {
                throw new Exception("No hay espacio");
            }

            _arreglo.Add(dato);
        }

        public string Imprimir()
        {
            string datos = string.Empty;
            for (int i = 0; i < _arreglo.Count; i++)
            {
                string dato = _arreglo[i];
                datos += $"{dato}{Environment.NewLine}";
            }
            return datos;
        }

        public void Eliminar()
        {
            if (_arreglo.Count <= 0)
            {
                throw new Exception("No hay elementos");
            }
            _arreglo.RemoveAt(_arreglo.Count - 1);
        }
    }
}
