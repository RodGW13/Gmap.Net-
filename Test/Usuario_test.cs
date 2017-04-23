using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;

namespace Test
{
   public  class Program
    {
        public static void Main(string[] args)
        {
            UsuarioDaoImpl us = new UsuarioDaoImpl();
            Console.WriteLine("Ingrese el nombre de usuario");
            string usua;
            usua = Console.ReadLine();
            int jer = 2;//nivel usuario normal

            Console.WriteLine("Ingrese la contraseña");
            string passw;
            passw = Console.ReadLine();

            string estado = "True"; // o remplace por False;

            int x = us.insertar(usua, jer, passw, estado);
            if (x == 1) {
                Console.Write("Resultado grabo");
            }





            ClienteDaoImpl cl = new ClienteDaoImpl();
            Console.WriteLine("Ingrese el rut solo numeros");
            string rut;
            rut = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre");
            string nombre;
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido paterno");
            string apellido_p;
            apellido_p = Console.ReadLine();

            Console.WriteLine("Ingrese el apllido materno");
            string apellido_m;
            apellido_m = Console.ReadLine();

            Console.WriteLine("Ingrese el telefono");
            string telefono;
            telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el celular");
            string celular;
            celular = Console.ReadLine();

            Console.WriteLine("Ingrese la direccion");
            string direccion;
            direccion = Console.ReadLine();

            Console.WriteLine("Ingrese el id usuario");
            string id_us;
            id_us = Console.ReadLine();

            Console.WriteLine("Ingrese la tarjeta");
            string tarjeta;
            tarjeta = Console.ReadLine();

            Console.WriteLine("Ingrese la comuna");
            string comuna;
            comuna = Console.ReadLine();

            Console.WriteLine("Ingrese la edad");
            string edad;
            edad = Console.ReadLine();

            //string patente=null; //si se quiere agregar patente se reemplaza sino se puede dejar null

            int xx = cl.grabarCliente(Int32.Parse(rut), nombre, apellido_p, apellido_m, Int32.Parse(telefono), Int32.Parse(celular), direccion, Int32.Parse(id_us), null, Int32.Parse(tarjeta), comuna, Int32.Parse(edad));

            if (xx == 1)
            {
                Console.Write("Resultado grabo");

            }
              



        }


    }
}
