using System.Drawing;
// Guía:5
// Ejercicio:#2
// Fecha: 18/9/2022
// Autor: BRANDON WILLIAM GOMEZ MONGE
// Carnet: GM21057
// GL: #1
// Instructora: ING. NELLY LISSETTE HENRIQUEZ SANCHEZ

namespace GM21057Guia5Ejercicio2
{
    //La Cátedra de Matemática IV desea realizar un Concurso, para el cual necesita saber  las mejores notas obtenidas en el parcial final.
    //Diseñe y codifique un programa con formularios en donde se ingrese el nombre del estudiante y su nota obtenida
    //en el  mencionado parcial, si el estudiante tiene nota mayor a 8, se debe mostrar en la pantalla que ha sido seleccionado para participar en el Concurso
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {

            //DECLARACION DE VARIABLES
            Alumno alumno = new Alumno();

            //ENTRADA DE DATOS
            alumno.NombreAlumno = textNombre.Text;
            alumno.NotaAlumno = double.Parse(textNota.Text);

            //PROCESO DE DATOS
            if (alumno.NotaAlumno >8 & alumno.NotaAlumno < 11)
            {
                //SALIDA DE DATOS
                imprimir.Text = "\"HAS SIDO SELECIONADO PARA PARTICIPAR EN EL CONCURSO\"";
            }
            else if (alumno.NotaAlumno > 0 & alumno.NotaAlumno <=8 ) 
            {
                imprimir.Text = "\"NO HAS SIDO SELECIONADO PARA PARTICIPAR EN EL CONCURSO\"";
            }else
            {
                imprimir.Text = "\"SE INGRESO VALORES NO PERMITIDOS\"";
            }

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textNombre.Clear();
            textNota.Clear();
            imprimir.Text="";

        }
    }
}