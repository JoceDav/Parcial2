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
    class Persona //clase padre
    {
        //atributos
        //Se usa Protected para limitar el acceso a un determinado miembro
        protected string NombreCompleto;
        protected string FechaN;                 
        protected int Edad;                     
        protected int DNIMatricula;
        protected string CarreraPuesto;
        //Tipo de dato String.      Tipo de acceso: Public
        public string nombrecompleto //Caja de memoria
        {
            get { return NombreCompleto; }
            //al usar return nos regresa la respuesta donde lo necesitamos imprimir
            set { NombreCompleto = value; } //se escribe el nombre completo de la persona a registrar
        }
        //Tipo de dato String.      Tipo de acceso: Public
        public string fechan 
        {
            //Modifica y accede la fecha de nacimiento.
            get { return FechaN; } 
            set { FechaN = value; }
        }
        //Tipo de dato Int.      Tipo de acceso: Public
        public int edad 
        {
            //Modifica y accede la fecha de nacimiento.
            get { return Edad; }
            set { Edad = value; }
        }
        //Tipo de dato Int.      Tipo de acceso: Public
        public int dnimatricula  
        {
            //Modifica y accede al DNI y/o  matricula.
            get { return DNIMatricula; }
            set { DNIMatricula = value; }
        }
        //Tipo de dato String.      Tipo de acceso: Public
        public string carreraPuesto
        {
            //Modifica y accede a la carrera / puesto.

            get { return CarreraPuesto; }
            set { CarreraPuesto = value; }
        }
    }
}

class Alumno :Persona //clase hija alumno
    //Los : hacen que se establezca una relacion de herencia entre las clases Alumno y persona
    {
    //Tipo de dato String.      Tipo de acceso: Public
    public string Matricula
    {
        //Modifica y accede a la matricula.
        get { return Matricula; }
        set { Matricula = value; }
    }
    //Tipo de dato String.      Tipo de acceso: Public
    //Modifica y accede a la carrera.
    public string Carrera
    {
        get { return Carrera; }
        set { Carrera = value; }
    }

}
class Empleado :persona //clase hija
//Los : hacen que se establezca una relacion de herencia entre las clases Alumno y persona

{
    //Se usa Protected para limitar el acceso a un determinado miembro
    protected int Sueldo;
    //Tipo de dato Int.      Tipo de acceso: Public
    public int sueldo
    {
        get { return Sueldo; }
        set { Sueldo = value; }
    }
    // Propiedad para el DNI
    //Tipo de dato string.      Tipo de acceso: Public
    public string DNI
    {
        get { return DNI; }
        set { DNI = value; }
    }

    // Propiedad para el puesto
    //Tipo de dato string      Tipo de acceso: Public
    public string Puesto
    {
        get { return Puesto; }
        set { Puesto = value; }
    }
}

class Docente :Persona //clase Hija
   //Los : hacen que se establezca una relacion de herencia entre las clases Alumno y persona
{
    //Se usa Protected para limitar el acceso a un determinado miembro
    protected int Sueldo;
    //Tipo de dato int       Tipo de acceso: Public
    public int sueldo
    {
        get { return Sueldo; }
        set { Sueldo = value; }
    }
    //Tipo de dato string      Tipo de acceso: Public
    public string DNI
    {
        get { return DNI; }
        set { DNI = value; }
    }
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