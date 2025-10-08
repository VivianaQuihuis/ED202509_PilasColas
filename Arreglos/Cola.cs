namespace Arreglos
{
    internal class Cola
    {
        int _inicio;
        int _final;
        string[] _arreglo;

        public Cola(int elementos)
        {
            _inicio = 0;
            _final = 0;
            _arreglo = new string[elementos];
        }

        public void Agregar(string dato)
        {
            int max = _arreglo.Length - 1;
            if (_final > max)
            {
                throw new Exception("Cola llena");
            }
            _arreglo[_final] = dato;
            _final++;
        }

        public void Eliminar()
        {
            if (_final==0 || _inicio == _final)
            {
               
            }
        }
    }
}
