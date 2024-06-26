using System;


class Empleado {
	//creamos el molde
	//atributos y metodos
	private string nombre {get : set};
	int edad;
	double salario;

	public void trabajar(){

		Console.WriteLine("Soy un empleado y trabajo");
	}
}

class Gerente: Empleado {

	string departamento;

	public void planificar(){

		Console.WriteLine("Soy un gerente y voy a planificar");

	}
}

class Operario: Empleado {
	string turno;

	public void operarMaquina(){

		Console.WriteLine("Operando maquina");
	}
}

namespace SistemaEmpleado

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Te damos la bienvenida al sistema de empleados");
        }
    }
}
