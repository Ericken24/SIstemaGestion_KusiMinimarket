using System;
using System.Collections.Generic;
using System.Text;

namespace SIstemaGestion_KusiMinimarket
{
        public class ClienteCaja
        {
            public int IdCliente { get; set; }
            public string Nombre { get; set; }
            public DateTime HoraLlegada { get; set; }
            public int CantidadProductos { get; set; }

            public override string ToString()
            {
                return $"{Nombre} - {CantidadProductos} productos - {HoraLlegada:HH:mm:ss}";
            }
        }

        // Nodo genérico de la lista enlazada
        public class Nodo<T>
        {
            public T Dato { get; set; }
            public Nodo<T> Siguiente { get; set; }

            public Nodo(T dato)
            {
                Dato = dato;
                Siguiente = null;
            }
        }

        // Lista enlazada simple (estructura base)
        public class ListaEnlazada<T>
        {
            public Nodo<T> Cabeza;
            public Nodo<T> Cola; // referencia al último nodo, útil para encolar en O(1)
            public int Cantidad { get; protected set; }

            public bool EstaVacia => Cantidad == 0;

            // Inserta al final
            public void AgregarAlFinal(T dato)
            {
                Nodo<T> nuevo = new Nodo<T>(dato);
                if (EstaVacia)
                {
                    Cabeza = nuevo;
                    Cola = nuevo;
                }
                else
                {
                    Cola.Siguiente = nuevo;
                    Cola = nuevo;
                }
                Cantidad++;
            }

            // Recorre la lista y la devuelve como List<T> para mostrarla en un DataGridView o ListBox
            public List<T> ObtenerTodos()
            {
                List<T> resultado = new List<T>();
                Nodo<T> actual = Cabeza;
                while (actual != null)
                {
                    resultado.Add(actual.Dato);
                    actual = actual.Siguiente;
                }
                return resultado;
            }
        }

        // Cola FIFO construida sobre la lista enlazada
        public class ColaCaja : ListaEnlazada<ClienteCaja>
        {
            // Encolar = el cliente llega y se pone al final de la fila
            public void Encolar(ClienteCaja cliente)
            {
                cliente.HoraLlegada = DateTime.Now;
                AgregarAlFinal(cliente);
            }

            // Desencolar = se atiende al que lleva más tiempo esperando (cabeza de la fila)
            public ClienteCaja Desencolar()
            {
                if (EstaVacia)
                    throw new InvalidOperationException("No hay clientes en espera en caja.");

                ClienteCaja cliente = Cabeza.Dato;
                Cabeza = Cabeza.Siguiente;
                Cantidad--;

                if (Cabeza == null)
                    Cola = null; // la fila quedó vacía

                return cliente;
            }

            // Ver quién sigue en la fila sin sacarlo (para mostrarlo en pantalla como "Siguiente")
            public ClienteCaja VerSiguiente()
            {
                return EstaVacia ? null : Cabeza.Dato;
            }
        }
}
