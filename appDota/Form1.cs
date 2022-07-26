using appDota.Clases;
using appDota.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace appDota
{
    public partial class Form1 : Form
    {
        // Lista para cargar ID y Valor del CB
        List<clsEstructruraCombo> objListaCbPlayer = new List<clsEstructruraCombo>();

        // Lista de Players
        List<Player> objListaPlayer = new List<Player>();
        Medalla obtenerMedalla = new Medalla();

        int vuelta = 0;
        int mmrActual = 0;
        int mmrxROL = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComboPlayer();
        }

        public void CargarComboPlayer()
        {
            // Datos del ComboBox
            objListaCbPlayer.Add(new clsEstructruraCombo() { ID = 0, Valor = "Seleccione un jugador" });
            objListaCbPlayer.Add(new clsEstructruraCombo() { ID = 1, Valor = "IR7" });
            objListaCbPlayer.Add(new clsEstructruraCombo() { ID = 2, Valor = "Nishino" });
            objListaCbPlayer.Add(new clsEstructruraCombo() { ID = 3, Valor = "Kido" });
            objListaCbPlayer.Add(new clsEstructruraCombo() { ID = 4, Valor = "Dblood" });
            objListaCbPlayer.Add(new clsEstructruraCombo() { ID = 5, Valor = "Kai" });
            objListaCbPlayer.Add(new clsEstructruraCombo() { ID = 6, Valor = "Muji" });

            // Lista con información de los jugadores
            objListaPlayer.Add(new Player() { PlayerID = 1, Name = "Inardy C.", MMR = 4125 });
            objListaPlayer.Add(new Player() { PlayerID = 2, Name = "Herbert GM", MMR = 3500 });
            objListaPlayer.Add(new Player() { PlayerID = 3, Name = "Daniel Kdo", MMR = 2341 });
            objListaPlayer.Add(new Player() { PlayerID = 4, Name = "DanielCC", MMR = 1800 });
            objListaPlayer.Add(new Player() { PlayerID = 5, Name = "Luis Kai", MMR = 1300 });
            objListaPlayer.Add(new Player() { PlayerID = 6, Name = "Mujica M.", MMR = 20 });

            // Origen de los datos para el ComboBOX
            // Cuando se generael Combo Box el índice se genera en -1
            cbPlayer.DataSource = objListaCbPlayer;

            // Se cambia  el índice a 0 -> Llama al evento 1ra vez
            cbPlayer.DisplayMember = "Valor";
            // Se vuelve a cambiar el índice a 0 -> Llama al evento 2da vez
            cbPlayer.ValueMember = "ID";
        }

        
        private void cbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Entra por 1ra vez en la linea 60;
            // Entra por 2da vez en la linea 62;
            vuelta++;
            if (vuelta <= 2)
            {
                return;
            }
            MessageBox.Show("Evento: " + vuelta);

            if (cbPlayer.SelectedIndex == 0)
            {
                // Reseteamos los campos en blanco
                LimpiarTexto();
            }
            else
            {
                int idSeleccionadoCB = cbPlayer.SelectedIndex;

                // Llenamos los campos de texto con información
                cargarTexto(idSeleccionadoCB);

                // Verificar checkbox activos al escoger índice
                if (cbPlayer.SelectedIndex != 0)
                {
                    if (chkHC.Checked)
                    {
                        datosFC2(chkHC.Checked);
                    }

                    if (chkMID.Checked)
                    {
                        datosFC2(chkMID.Checked);
                    }

                    if (chkSupport.Checked)
                    {
                        datosFC2(chkSupport.Checked);
                    }
                }

            }

        }

        // Resetear texto
        public void LimpiarTexto()
        {
            txtNombre.Text = string.Empty;
            txtMMR.Text = string.Empty;
            txtMedalla.Text = string.Empty;

            txtMMR2.Text = string.Empty;
            txtMedalla2.Text = string.Empty;

            txtMMR3.Text = string.Empty;
            txtMedalla3.Text = string.Empty;

            chkHC.Checked = false;
            chkMID.Checked = false;
            chkSupport.Checked = false;
        }


        // 
        public void cargarTexto(int codigo)
        {

            foreach (var item in objListaPlayer)
            {
                if (item.PlayerID == codigo)
                {
                    txtNombre.Text = item.Name;
                    txtMMR.Text = item.MMR.ToString();
                    txtMedalla.Text = obtenerMedalla.CalcularMedalla(item.MMR);
                }
            }
        }


        public void datosFC2(bool checkBox)
        {
            // Contador de checks xROL activos
            int contadorChecks = 0;
            bool[] Hc_Mid_Support = new bool[] {chkHC.Checked,chkMID.Checked,chkSupport.Checked};

            foreach (var item in Hc_Mid_Support)
            {
                if (item)
                {
                    contadorChecks++;
                }
            }
            

            if (txtMMR.Text != string.Empty)
            {

                SetMMRxRol(checkBox, txtMMR.Text);

                // Si hay más de 1 chkBox marcado  y desmarcamos 1, que el mmr siga contando el chkBox activo
                //Al desmarcar el checkbox el dato es falso, lo convertimos a true

                #region Código Muji
                /*
                if (checkBox == false && contadorChecks >= 1)
                {
                    // Calcula el mmr adicional V2
                    mmrActual = Convert.ToInt32(txtMMR2.Text);
                    mmrxROL = obtenerMedalla.MMRxROL(mmrActual, true);
                    txtMMR2.Text = mmrxROL.ToString();
                }

                if (checkBox == false && contadorChecks >= 2)
                {
                    // Calcula el mmr adicional V3
                    mmrActual = Convert.ToInt32(txtMMR2.Text);
                    mmrxROL = obtenerMedalla.MMRxROL(mmrActual, true);
                    txtMMR2.Text = mmrxROL.ToString();
                }
                */
                #endregion

                if (checkBox == false && contadorChecks >= 1)
                {
                    for (int i = 0; i < contadorChecks; i++)
                    {
                        SetMMRxRol(true, txtMMR2.Text);
                    }
                }

                // Verificamos y llenamos medalla x ROL
                //txtMedalla2.Text = obtenerMedalla.CalcularMedalla(mmrxROL);
                if (txtMMR.Text != string.Empty && contadorChecks >= 2)
                {
                    SetMMRxRol(checkBox, txtMMR2.Text);

                    if (contadorChecks > 2)
                    {
                        SetMMRxRol(checkBox, txtMMR2.Text);
                    }
                }


            }

            if (contadorChecks == 0)
            {
                txtMMR2.Text = String.Empty;
                txtMedalla2.Text = String.Empty;
            }

        }

        public void SetMMRxRol(bool checkBox, string txtBox)
        {
            mmrActual = Convert.ToInt32(txtBox);
            mmrxROL = obtenerMedalla.MMRxROL(mmrActual, checkBox);

            //Llenando campo de texto de MMR x ROL
            txtMMR2.Text = mmrxROL.ToString();

            //Verificamos y llenamos medalla x ROL
            txtMedalla2.Text = obtenerMedalla.CalcularMedalla(mmrxROL);
        }

        private void chkHC_CheckedChanged(object sender, EventArgs e)
        {
            // Agregar string para diferenciar qué botón se accionó
            datosFC2(chkHC.Checked);
        }

        private void chkMID_CheckedChanged(object sender, EventArgs e)
        {
            datosFC2(chkMID.Checked);
        }

        private void chkSupport_CheckedChanged(object sender, EventArgs e)
        {
            datosFC2(chkSupport.Checked);
        }

        private void chkHCMuji_CheckedChanged(object sender, EventArgs e)
        {
            datosFC2(chkHCMuji.Checked);
        }
        //private void btnVer_Click(object sender, EventArgs e)
        //{

        //    int CodigoPlayer = (int)cbPlayer.SelectedValue;
        //    ConstruirMensaje mensajeArmado = new ConstruirMensaje();
        //    List <string> armarMensaje = new List<string>();            


        //    mostrarDato(CodigoPlayer);

        //    int nuevoMMR = Convert.ToInt32(txtMMR.Text);

        //    // Si hay ROL activo, se crea nuevo MMR y añade mensaje
        //    if (chkHC.Checked || chkMID.Checked || chkSupport.Checked)
        //    {
        //        nuevoMMR = Convert.ToInt32(txtMMR.Text);
        //        if (chkHC.Checked)
        //        {
        //            nuevoMMR += 500;
        //        }

        //        if (chkMID.Checked)
        //        {
        //            nuevoMMR += 500;
        //        }

        //        if (chkSupport.Checked)
        //        {
        //            nuevoMMR += 500;
        //        }
        //        armarMensaje.Add("El nuevo MMR por ROL es: " + nuevoMMR);                
        //        armarMensaje.Add("La nueva Medalla por ROL es. " + medalla.MostrarMedalla(nuevoMMR));
        //    }


        //    //RadioButton activo
        //    if (rbtnJBien.Checked)
        //    {
        //        nuevoMMR += 1000;
        //        armarMensaje.Add("El nuevo MMR por Juego es: " + nuevoMMR);
        //        armarMensaje.Add("La nueva Medalla por Juego es. " + medalla.MostrarMedalla(nuevoMMR));
        //    }
        //    if (rbtnJMal.Checked)
        //    {
        //        nuevoMMR -= 1000;
        //        armarMensaje.Add("El nuevo MMR por Juego es: " + nuevoMMR);
        //        armarMensaje.Add("La nueva Medalla por Juego es. " + medalla.MostrarMedalla(nuevoMMR));
        //    }


        //    //TODO: Corregir mensaje en blanco

        //    MessageBox.Show(mensajeArmado.ArmarMensaje(armarMensaje));
        //}

        // Muestra datos del player
        //public void mostrarDato(int codigo)
        //{

        //    foreach (var item in listaPlayer)
        //    {
        //        if (item.PlayerID == codigo)
        //        {
        //            txtNombre.Text = item.Name;
        //            txtMedalla.Text = medalla.MostrarMedalla(item.MMR);
        //            txtMMR.Text = item.MMR.ToString();
        //            break;
        //        }

        //    }
        //}

    }
}
