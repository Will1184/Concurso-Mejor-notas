using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM21057Guia5Ejercicio2
{
    internal class Alumno
    {
        //DECLARACION DE VARIABLES
        private String nombreAlumno;
        private double notaAlumno;
        
        public Alumno() { }
        public Alumno(string nombreAlumno, double notaAlumno)
        {
            this.nombreAlumno = nombreAlumno;
            this.notaAlumno = notaAlumno;
        }
        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }
        public double NotaAlumno
        {
            get { return notaAlumno; }
            set { notaAlumno = value; }
        }

    }
}
