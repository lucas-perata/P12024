using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Lista
    {
        public Cancion NodoInicial = null;
        public void AgregarPrincipio(Cancion nueva)
        {

            if(NodoInicial == null)
            {
                nueva.Numero = 1; 
                NodoInicial = nueva;
            }
            else
            {
                Cancion aux = NodoInicial;
                NodoInicial = nueva;
                NodoInicial.Siguiente = aux; 
                AcomodarNumeros(NodoInicial);
            }
        }

        private void AcomodarNumeros(Cancion cancion)
        {
                            cancion.Numero += 1;
            if(cancion.Siguiente != null)
                AcomodarNumeros(cancion.Siguiente);
        }

        public void AgregarFinal(Cancion nueva)
        {
            nueva.Numero = ProximoNumero();
            Cancion ultimo = BuscarUltimo(NodoInicial);
            ultimo.Siguiente = nueva;

        }

        private int BuscarMaximo(Cancion cancion, int numero)
        {
            int max = cancion.Numero > numero ? cancion.Numero : numero; 

            if(cancion.Siguiente != null)
            {
                return BuscarMaximo(cancion.Siguiente, max);
            }
            else
            {
                return max; 
            }
        }

        private int ProximoNumero()
        {
            if (NodoInicial == null) return 1;

            int max = BuscarMaximo(NodoInicial, NodoInicial.Numero);

            return max + 1; 
        }

        private Cancion BuscarUltimo(Cancion cancion)
        {
            //la lista este vacia
            if (cancion == null) return null;
            //que no sea el ultimo
            if (cancion.Siguiente != null)
                return BuscarUltimo(cancion.Siguiente);
            else
                return cancion;
        }
        public void QuitarPrimero()
        {
            if (NodoInicial != null)
            {
                NodoInicial = NodoInicial.Siguiente;
            }
        }
        public void QuitarUltimo()
        {
            //necesitamos buscar el anteultimo
            Cancion anteultimo = BuscarAnteultimo(NodoInicial);
            if (anteultimo != null)
                anteultimo.Siguiente = null;
            else
                NodoInicial = null;
        }

        private Cancion BuscarAnteultimo(Cancion cancion)
        {
            if (cancion == null) return null; //lista vacia
            if (cancion.Siguiente == null) return null; //hay un solo elemento
            if (cancion.Siguiente.Siguiente != null)
                return BuscarAnteultimo(cancion.Siguiente);
            else
                return cancion;
        }

        private Cancion BuscarAnterior(Cancion cancion, int numero)
        {
            if (cancion.Siguiente != null && cancion.Siguiente.Numero == numero)
                return cancion;
            if (cancion.Siguiente != null)
                return BuscarAnterior(cancion.Siguiente, numero);
            return null;
        }

        public void QuitarPosicion(int numero)
        {
            if (NodoInicial != null)
            {
                if (NodoInicial.Numero == numero)
                {
                    QuitarPrimero();
                }
                else
                {
                    Cancion ultimo = BuscarUltimo(NodoInicial);
                    if (ultimo != null && ultimo.Numero == numero)
                        QuitarUltimo();
                    else
                    { 
                       Cancion nodoAnteriorAlElegido =
                       BuscarAnterior(NodoInicial, numero);
                        if (nodoAnteriorAlElegido != null)
                            nodoAnteriorAlElegido.Siguiente =
                           nodoAnteriorAlElegido.Siguiente.Siguiente;
                    }
                }
            }
        }
    }
}
