using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    //08.05.2024
    //Este esun programa que funciona para que una persona proporcione sus datos en una "base de datos"
    //PRIMER INTENTO :C
    //09.05.24
    //Segundo intento
    class Persona //clase padre
    {
        //atributos
        //Se usa Protected para limitar el acceso a un determinado miembro
        protected int Edad; //CAJA QUE GUARDA EDAD
        protected string Nombre; //CAJA QUE GUARDA NOMBRE
        protected string FechaNacimiento;//CAJA QUE GUARDA FECHA DE NACIMIENTO              

        //Tipo de dato String.      Tipo de acceso: Public
        public string nombre//Caja de memoria
        {
            get { return Nombre; }
            //al usar return nos regresa la respuesta donde lo necesitamos imprimir
            set { Nombre = value; } //se escribe el nombre completo de la persona a registrar
        }
        //Tipo de dato String.      Tipo de acceso: Public
        public string fechanacimiento
        {
            //Modifica y accede la fecha de nacimiento.
            get { return FechaNacimiento; } 
            set { FechaNacimiento = value; }
        }
        //Tipo de dato Int.      Tipo de acceso: Public
        public int edad 
        {
            //Modifica y accede la fecha de nacimiento.
            get { return Edad; }
            set { Edad = value; }
        }
    }
}

class Alumno :Persona //clase hija alumno
    //Los : hacen que se establezca una relacion de herencia entre las clases Alumno y persona
    {
    protected string Matricula; //CAJA QUE GUARDA MATRICULA
    //Tipo de dato String.      Tipo de acceso: Public
    public string Matricula
    {
        //Modifica y accede a la matricula.
        get { return Matricula; }
        set { Matricula = value; }
    }
    //Modifica y accede a la carrera.
    public string Carrera
    {
        get { return Carrera; }
        set { Carrera = value; }
    }

}
class Empleado :Persona: //clase hija
//Los : hacen que se establezca una relacion de herencia entre las clases Alumno y persona

{
    protected int Sueldo; //CAJA QUE GUARDA SUELDO
//Se usa Protected para limitar el acceso a un determinado miembro
protected int Sueldo;
    //Tipo de dato Int.      Tipo de acceso: Public
    public int sueldo
    {
        get { return Sueldo; }
        set { Sueldo = value; }
    }
    protected string DNI //CAJA QUE GUARDA DNI
    // Propiedad para el DNI
    //Tipo de dato string.      Tipo de acceso: Public
    public string dni
    {
        get { return DNI; }
        set { DNI = value; }
    }
    protected string Puesto //CAJA QUE GUARDA PUESTO
    // Propiedad para el puesto
    //Tipo de dato string      Tipo de acceso: Public
    public string Puesto
    {
        get { return Puesto; }
        set { Puesto = value; }
    }
}

class Docente :Empleado //clase Hija
   //Los : hacen que se establezca una relacion de herencia entre las clases Alumno y persona
{
    //Se usa Protected para limitar el acceso a un determinado miembro
    protected int Sueldo;//CAJA QUE GUARDA SUELDO
    //Tipo de dato int       Tipo de acceso: Public
    public int sueldo
    {
        get { return Sueldo; }
        set { Sueldo = value; }
    }
    protected string DNI;//CAJA QUE GUARDA DNI
    //Tipo de dato string      Tipo de acceso: Public
    public string DNI
    {
        get { return DNI; }
        set { DNI = value; }
    }
    protected string Puesto;//CAJA QUE GUARDA PUESTO
    //Tipo de dato string      Tipo de acceso: Public
    public string Puesto
    {
        get { return Puesto; }
        set { Puesto = value; }
    }
}
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }