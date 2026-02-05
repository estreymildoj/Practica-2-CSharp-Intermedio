using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class ListaNumeros<T> : List<T>{
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
