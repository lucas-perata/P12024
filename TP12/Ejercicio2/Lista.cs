using System;

namespace Ejercicio2
{
    internal class Lista
    {
        public Cancion NodoInicial = null;
        public Cancion NodoFinal = null;

        public void AgregarPrincipio(Cancion nueva)
        {
            if (NodoInicial == null)
            {
                nueva.Numero = 1;
                NodoInicial = nueva;
                NodoFinal = nueva;
                NodoFinal.Siguiente = NodoInicial;
                NodoInicial.Anterior = NodoFinal;
            }
            else
            {
                nueva.Siguiente = NodoInicial;
                NodoInicial.Anterior = nueva;
                NodoInicial = nueva;
                NodoFinal.Siguiente = NodoInicial;
                NodoInicial.Anterior = NodoFinal;
                ActualizarNumeros();
            }
        }

        public void AgregarFinal(Cancion nueva)
        {
            if (NodoInicial == null)
            {
                AgregarPrincipio(nueva);
            }
            else
            {
                nueva.Numero = ProximoNumero();
                nueva.Anterior = NodoFinal;
                NodoFinal.Siguiente = nueva;
                NodoFinal = nueva;
                NodoFinal.Siguiente = NodoInicial;
                NodoInicial.Anterior = NodoFinal;
            }
        }

        public void AgregarPosition(int numero, Cancion nueva)
        {
            if(NodoInicial == null)
            {
                AgregarPrincipio(nueva);
                return;
            } 
            else if (numero == 1)
            {
                nueva.Siguiente = NodoInicial;
                NodoFinal.Siguiente = nueva;
                NodoInicial = nueva;

                AcomodarNumeros(NodoInicial);
                return; 
            }

            Cancion actual = NodoInicial;
            int posicionActual = 1;

            do
            {
                if (posicionActual == numero - 1)
                {
                    nueva.Siguiente = actual.Siguiente;
                    actual.Siguiente = nueva;

                    if (actual == NodoFinal)
                        NodoFinal = nueva;

                    AcomodarNumeros(NodoInicial);
                    return;
                }

                actual = actual.Siguiente;
                posicionActual++;
            } while (actual != NodoInicial); 
        }

        public void QuitarPrimero()
        {
            if (NodoInicial != null)
            {
                if (NodoInicial == NodoFinal) 
                {
                    NodoInicial = null;
                    NodoFinal = null;
                }
                else
                {
                    NodoInicial = NodoInicial.Siguiente;
                    NodoInicial.Anterior = NodoFinal;
                    NodoFinal.Siguiente = NodoInicial;
                }
            }
        }

        public int ProximoNumero()
        {
            if (NodoInicial == null)
                return 1; 
            int maxNumero = NodoInicial.Numero;
            Cancion actual = NodoInicial.Siguiente;

            while (actual != NodoInicial)
            {
                if (actual.Numero > maxNumero)
                {
                    maxNumero = actual.Numero;
                }
                actual = actual.Siguiente;
            }

            return maxNumero + 1; 
        }

        public void QuitarUltimo()
        {
            if (NodoInicial != null)
            {
                if (NodoInicial == NodoFinal) 
                {
                    NodoInicial = null;
                    NodoFinal = null;
                }
                else
                {
                    Cancion anteultimo = BuscarAnteultimo();
                    if (anteultimo != null)
                    {
                        anteultimo.Siguiente = NodoInicial; 
                        NodoFinal = anteultimo;
                    }
                }
                ActualizarNumeros();
            }
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
                    Cancion anterior = BuscarAnterior(numero);
                    if (anterior != null && anterior.Siguiente != null)
                    {
                        if (anterior.Siguiente == NodoFinal) 
                        {
                            QuitarUltimo();
                        }
                        else 
                        {
                            anterior.Siguiente = anterior.Siguiente.Siguiente;
                        }
                        ActualizarNumeros();
                    }
                }
            }
        }

        private void ActualizarNumeros()
        {
            if (NodoInicial == null) return;

            int numero = 1;
            Cancion actual = NodoInicial;
            do
            {
                actual.Numero = numero++;
                actual = actual.Siguiente;
            } while (actual != NodoInicial);
        }

        private void AcomodarNumeros(Cancion nodo)
        {
            if (nodo == null) return;

            Cancion actual = nodo;
            int numeroActual = 1;

            do
            {
                actual.Numero = numeroActual;
                numeroActual++;
                actual = actual.Siguiente;
            } while (actual != NodoInicial); 
        }

        private Cancion BuscarAnteultimo()
        {
            if (NodoInicial == null || NodoInicial == NodoFinal) return null;

            Cancion actual = NodoInicial;
            while (actual.Siguiente != NodoFinal)
            {
                actual = actual.Siguiente;
            }
            return actual;
        }

        private Cancion BuscarAnterior(int numero)
        {
            if (NodoInicial == null) return null;

            Cancion actual = NodoInicial;
            do
            {
                if (actual.Siguiente != null && actual.Siguiente.Numero == numero)
                    return actual;

                actual = actual.Siguiente;
            } while (actual != NodoInicial);

            return null;
        }

        private Cancion BuscarCancionPorNumero(int numero)
        {
            Cancion actual = NodoInicial;

            if (actual == null)
                return null; 

            do
            {
                if (actual.Numero == numero)
                {
                    return actual; 
                }
                actual = actual.Siguiente;
            } while (actual != NodoInicial); 

            return null; 
        }

        public void IntercambiarDerecha(int numero)
        {
            Cancion cancion = BuscarCancionPorNumero(numero);

            if (cancion != null)
            {
                int tempNumero = cancion.Numero;
                string tempNombre = cancion.Nombre;
                decimal tempDur = cancion.Duracion;

                cancion.Numero = cancion.Siguiente.Numero;
                cancion.Nombre = cancion.Siguiente.Nombre;
                cancion.Duracion = cancion.Siguiente.Duracion;

                cancion.Siguiente.Numero = tempNumero;
                cancion.Siguiente.Nombre = tempNombre;
                cancion.Siguiente.Duracion = tempDur;
            }
        }
    }
}

