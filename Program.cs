namespace Program
{

    class App
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();

            Console.WriteLine("Ingresa una serie de números para el árbol (separados por espacio):");
            string entrada = Console.ReadLine();
            string[] numeros = entrada.Split(' ');

            foreach (string num in numeros)
            {
                arbol.Insertar(int.Parse(num));
            }

            Console.WriteLine("\nRecorrido Inorder:");
            arbol.Inorder(arbol.Raiz);

            Console.WriteLine("\nRecorrido Preorder:");
            arbol.Preorder(arbol.Raiz);

            Console.WriteLine("\nRecorrido Postorder:");
            arbol.Postorder(arbol.Raiz);

            Console.WriteLine("\n\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

    public class Nodo
    {
        public int Valor;
        public Nodo Izquierdo;
        public Nodo Derecho;

        public Nodo(int valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }
    }

    public class ArbolBinario
    {
        public Nodo Raiz;

        public ArbolBinario()
        {
            Raiz = null;
        }

        // Método para insertar valores
        public void Insertar(int valor)
        {
            Raiz = InsertarRecursivo(Raiz, valor);
        }

        private Nodo InsertarRecursivo(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                return new Nodo(valor);
            }

            if (valor < nodo.Valor)
            {
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, valor);
            }
            else if (valor > nodo.Valor)
            {
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, valor);
            }

            return nodo;
        }

        public void Inorder(Nodo nodo)
        {
            if (nodo != null)
            {
                Inorder(nodo.Izquierdo);
                Console.Write(nodo.Valor + " ");
                Inorder(nodo.Derecho);
            }
        }

        public void Preorder(Nodo nodo)
        {
            if (nodo != null)
            {
                Console.Write(nodo.Valor + " ");
                Preorder(nodo.Izquierdo);
                Preorder(nodo.Derecho);
            }
        }

        public void Postorder(Nodo nodo)
        {
            if (nodo != null)
            {
                Postorder(nodo.Izquierdo);
                Postorder(nodo.Derecho);
                Console.Write(nodo.Valor + " ");
            }
        }
    }


}
