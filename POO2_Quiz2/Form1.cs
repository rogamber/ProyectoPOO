using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO2_Quiz2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notas nota;
            nota = new notas();
            calculos calcular;
            calcular = new calculos();
            nota.ptos_tarea1(txtptstarea1.Text);
            lbl_porc_obt_tarea1.Text = calcular.porcentaje_tarea1(nota.pts_tarea1)+"%";
            nota.ptos_tarea2(txtptstarea2.Text);
            lbl_porc_obt_tarea2.Text = calcular.porcentaje_tarea2(nota.pts_tarea2) + "%";
            nota.ptos_examen1(txtptsexamen1.Text);
            lbl_porc_obt_examen1.Text = calcular.porcentaje_examen1(nota.pts_examen1) + "%";
            nota.ptos_examen2(txtptsexamen2.Text);
            lbl_porc_obt_examen2.Text = calcular.porcentaje_examen2(nota.pts_examen2) + "%";
            nota.ptos_proyecto(txtptsproyecto.Text);
            lbl_porc_obt_proyecto.Text = calcular.porcentaje_proyecto(nota.pts_proyecto) + "%";
            lblnotatotal.Text = calcular.nota_final() + "%";
            lblcondicion.Text = calcular.ver_condicion();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


    //clase para capturar los puntos de las notas obtenidas por el estudiante
    public class notas
    {
        public int pts_tarea1;
        public int pts_tarea2;
        public int pts_examen1;
        public int pts_examen2;
        public int pts_proyecto;
       

        public void ptos_tarea1(string pts)
        {
            
            //si no se ingreso nada al cuadro de texto se le asigna un cero a pts
            if (pts == "")
            {
                pts = "0";
            }

            //se verifica si lo ingresado en el cuadro de texto es un numero
            if (pts.All(char.IsDigit))
            {
                pts_tarea1 = int.Parse(pts);
            }
            else
            {
                pts_tarea1 = 0;
            }

           
        }

        
        public void ptos_tarea2(string pts)
        {
            //si no se ingreso nada al cuadro de texto se le asigna un cero a pts
            if (pts == "")
            {
                pts = "0";
            }

            //se verifica si lo ingresado en el cuadro de texto es un numero
            if (pts.All(char.IsDigit))
            {
                pts_tarea2 = int.Parse(pts);
            }
            else
            {
                pts_tarea2 = 0;
            }

        }

        public void ptos_examen1(string pts)
        {
            //si no se ingreso nada al cuadro de texto se le asigna un cero a pts
            if (pts == "")
            {
                pts = "0";
            }

            //se verifica si lo ingresado en el cuadro de texto es un numero
            if (pts.All(char.IsDigit))
            {
                pts_examen1 = int.Parse(pts);
            }
            else
            {
                pts_examen1 = 0;
            }


        }

        public void ptos_examen2(string pts)
        {
            //si no se ingreso nada al cuadro de texto se le asigna un cero a pts
            if (pts == "")
            {
                pts = "0";
            }

            //se verifica si lo ingresado en el cuadro de texto es un numero
            if (pts.All(char.IsDigit))
            {
                pts_examen2 = int.Parse(pts);
            }
            else
            {
                pts_examen2 = 0;
            }


        }

        public void ptos_proyecto(string pts)
        {
            //si no se ingreso nada al cuadro de texto se le asigna un cero a pts
            if (pts == "")
            {
                pts = "0";
            }

            //se verifica si lo ingresado en el cuadro de texto es un numero
            if (pts.All(char.IsDigit))
            {
                pts_proyecto = int.Parse(pts);
            }
            else
            {
                pts_proyecto = 0;
            }


        }
    }

    //clase para calcular los porcentajes de las notas obtenidas
    public class calculos
    {
        private float tarea1;
        private float tarea2;
        private float examen1;
        private float examen2;
        private float proyecto;
        private string condicion;


        public string porcentaje_tarea1(float pts)
        {
            float resultado;
            if (pts == 0.0f)
            {
                resultado = 0.0f;
            }
            else
            {
                resultado = pts / 35.0f;
                resultado = resultado * 15; 
            }

            //si se ingresa un valor de pts mayor al maximo se asigna el porcentaje maximo de la nota
            if (resultado > 15.0f) {
                resultado = 15.0F;
            }

            tarea1 = resultado;
            return String.Format("{0:0.00}", resultado); 
            // return  resultado.ToString();
        }

        public string porcentaje_tarea2(float pts)
        {
            float resultado;
            if (pts == 0.0f)
            {
                resultado = 0.0f;
            }
            else
            {
                resultado = pts / 35.0f;
                resultado = resultado * 15;
            }

            //si se ingresa un valor de pts mayor al maximo se asigna el porcentaje maximo de la nota
            if (resultado > 15.0f)
            {
                resultado = 15.0F;
            }

            tarea2 = resultado;
            return String.Format("{0:0.00}", resultado);
            // return  resultado.ToString();
        }
        public string porcentaje_examen1(float pts)
        {
            float resultado;
            if (pts == 0.0f)
            {
                resultado = 0.0f;
            }
            else
            {
                resultado = pts / 55.0f;
                resultado = resultado * 25;
            }

            //si se ingresa un valor de pts mayor al maximo se asigna el porcentaje maximo de la nota
            if (resultado > 25.0f)
            {
                resultado = 25.0F;
            }

            examen1 = resultado;
            return String.Format("{0:0.00}", resultado);
            // return  resultado.ToString();
        }

        public string porcentaje_examen2(float pts)
        {
            float resultado;
            if (pts == 0.0f)
            {
                resultado = 0.0f;
            }
            else
            {
                resultado = pts / 55.0f;
                resultado = resultado * 25;
            }

            //si se ingresa un valor de pts mayor al maximo se asigna el porcentaje maximo de la nota
            if (resultado > 25.0f)
            {
                resultado = 25.0F;
            }

            examen2 = resultado;
            return String.Format("{0:0.00}", resultado);
            // return  resultado.ToString();
        }

        public string porcentaje_proyecto(float pts)
        {
            float resultado;
            if (pts == 0.0f)
            {
                resultado = 0.0f;
            }
            else
            {
                resultado = pts / 45.0f;
                resultado = resultado * 20;
            }

            //si se ingresa un valor de pts mayor al maximo se asigna el porcentaje maximo de la nota
            if (resultado > 20.0f)
            {
                resultado = 20.0F;
            }

            proyecto = resultado;
            return String.Format("{0:0.00}", resultado);
            // return  resultado.ToString();
        }

        public string nota_final()
        {
            float resultado;
            resultado = tarea1 + tarea2 + examen1 + examen2 + proyecto;
            if (resultado < 20)
            {
                condicion = "Deserto";
            }
            else if(resultado < 70)
            {
                condicion = "Reprobo";
            }
            else
            {
                condicion = "Aprobo";
            }

            return String.Format("{0:0.00}", resultado);

        }

        public string ver_condicion()
        {
            return condicion;
        }
    }
}
