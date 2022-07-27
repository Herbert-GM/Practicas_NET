using Calcu2.clases;
using Calcu2.modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calcu2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Calcular(int n1, int n2, int n3)
        {
            var objNumero = new Numero();
            var objOperacion = new Operacion();
            var objMensaje = new Mensaje();
            List<String> listaMensajes  = new List<String>();

            var acFase2 = 0;
            var acFase3Sumar = 0;
            var acFase3Restar = 0;
            var acFase3Multiplicar = 0;

            var acFase1 = objOperacion.CalcularX(n1, n2, cbOpciones.Text);


            listaMensajes.Add($"Resultado de la {cbOpciones.Text}: " + acFase1);

            
            if (rbtn5.Checked)
            {
                acFase2 = objOperacion.CalcularX(acFase1, 5, Constantes.OperacionSuma);
            }else if (rbtn10.Checked)
            {
                acFase2 = objOperacion.CalcularX(acFase1, 10, Constantes.OperacionSuma);
            }else if (rbtn20.Checked)
            {
                acFase2 = objOperacion.CalcularX(acFase1, 20, Constantes.OperacionSuma);
            }


            listaMensajes.Add("Resultado de la Suma Fase2 es de : " + acFase2);
            
            if (ckSumar.Checked)
            {
                acFase3Sumar = objOperacion.CalcularX(acFase2, n3, Constantes.OperacionSuma);
                listaMensajes.Add("Resultado de la Suma Fase3 es de : " + acFase3Sumar);                
            }

            if (ckRestar.Checked)
            {
                acFase3Restar = objOperacion.CalcularX(acFase2, n3, Constantes.OperacionResta);
                listaMensajes.Add("Resultado de la Resta Fase3 es de : " + acFase3Restar);
            }

            if (ckMultiplicar.Checked)
            {
                acFase3Multiplicar = objOperacion.CalcularX(acFase2, n3, Constantes.OperacionMultiplicar);
                listaMensajes.Add("Resultado de la Multiplicación Fase3 es de : " + acFase3Multiplicar);
            }

            MessageBox.Show(objMensaje.ConstruirCadena2(listaMensajes));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (ValidarNumeros(5, 10, 15))
            {
                Calcular(Convert.ToInt32(txtN1.Text), Convert.ToInt32(txtN2.Text), Convert.ToInt32(txtN3.Text));
            }
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            if (ValidarNumeros(15, 10, 5))
            {
                Calcular(Convert.ToInt32(txtN1.Text), Convert.ToInt32(txtN3.Text), Convert.ToInt32(txtN2.Text));
            }
            
        }

        public bool ValidarNumeros(int Criterio1, int Criterio2, int Criterio3)
        {
            Validacion objValidacion = new Validacion();

            if (objValidacion.validarNumero(Convert.ToInt32(txtN1.Text), Criterio1))
            {
                if (objValidacion.validarNumero(Convert.ToInt32(txtN2.Text), Criterio2))
                {
                    if (objValidacion.validarNumero(Convert.ToInt32(txtN3.Text), Criterio3))
                    {

                        return true;
                    }
                    MessageBox.Show("El número 3 debe ser mayor a: " + Criterio3);
                    return false;
                }
                MessageBox.Show("El número 2 debe ser mayor a: " + Criterio2);
                return false;
            }
            MessageBox.Show("El número 1 debe ser mayor a: " + Criterio1);
            return false;
        }
    }
}
