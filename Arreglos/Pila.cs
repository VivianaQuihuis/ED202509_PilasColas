namespace Arreglos
{
    internal class Pila
    {
        string[] _arreglo;
        int _tope;

        public Pila(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
        }

        public void Agregar(string dato) 
        {
            int max = _arreglo.Length -1;
            if(_tope > max) 
            {
                throw new Exception("No hay espacio");
            }

            _arreglo[_tope] = dato;
            _tope++;
        }

        public string Imprimir()
        {
            string datos = string.Empty;
            for (int i = 0; i < _tope; i++)
            {
                string dato = _arreglo[i];
                datos += $"{dato}{Environment.NewLine}";
            }
            return datos;
        }

    }
}
