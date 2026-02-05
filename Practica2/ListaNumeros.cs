using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class ListaNumeros<T> : List<T> where T : struct {

        private readonly List<T> _datos = new();

        public Type Tipo => typeof(T);

        public void AgregarNumero(string input)
        {
            object convertido;

            if (Tipo == typeof(int)) convertido = int.Parse(input);
            else if(Tipo == typeof(double)) convertido = double.Parse(input);
            else if(Tipo == typeof(float)) convertido = float.Parse(input);
            else if (Tipo == typeof(decimal)) convertido = float.Parse(input);
            else
                throw new NotSupportedException($"Tipo no soportado: {typeof(T).Name}");

            _datos.Add((T)convertido);
        }

        public float Sumar()
        {
            float suma = 0;

            foreach (var item in this) {
                float valor = float.Parse(item.ToString());
                suma += valor;
            }

            return suma;
        }

        public void Multiplicar()
        {

        }

        public void Divide() {
        
        }

        public float Restar()
        {
            float resta = float.Parse(this[0].ToString());

            for (int i = 0; i < this.Count; i++) {
                var item = this[i+1];

                float valor = float.Parse(item.ToString());

                resta -= valor;

            }

            return resta;
        }


    }

    
}
