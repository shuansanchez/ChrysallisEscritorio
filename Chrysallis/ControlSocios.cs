﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis
{
    public partial class Control_de_Usuarios : Form
    {
        usuaris userLogin = new usuaris();
        public Control_de_Usuarios(usuaris userLogin)
        {
            InitializeComponent();
            this.userLogin = userLogin;
        }
        
        

        private void Control_de_Usuarios_Activated(object sender, EventArgs e)
        {
            
            if (userLogin.id_rol == 5)
            {
                socis socioDelUsuario = new socis();
                socioDelUsuario = ConsultaOrm.SelectSociosAdmins(userLogin);
                dataGridViewSocios.ReadOnly = true;
                dataGridViewSocios.DataSource = null;
                dataGridViewSocios.DataSource = ConsultaOrm.SelectSociosComunidadUser(socioDelUsuario);

                dataGridViewSocios.AutoGenerateColumns = false;
            }
            else if(userLogin.id_rol == 6)
            {
                dataGridViewSocios.ReadOnly = true;
                dataGridViewSocios.DataSource = null;
                dataGridViewSocios.DataSource = ConsultaOrm.SelectSocios();
                dataGridViewSocios.AutoGenerateColumns = false;
            }
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            ControlValoraciones nuevoValoraciones = new ControlValoraciones(false, (socis)dataGridViewSocios.SelectedRows[0].DataBoundItem);
            nuevoValoraciones.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Modificar_Socios nuevoUsuario = new Modificar_Socios(false, userLogin);
            nuevoUsuario.ShowDialog();
        }

        private void toolStripButtonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewSocios.SelectedRows[0].DataBoundItem == null)
            {
                MessageBox.Show("Nada seleccionado");
            }
            else
            {
                Modificar_Socios cambiaSocio = new Modificar_Socios(true, (socis)dataGridViewSocios.SelectedRows[0].DataBoundItem, userLogin);
                cambiaSocio.ShowDialog();
            }
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            
            socis socioElegido = (socis)dataGridViewSocios.SelectedRows[0].DataBoundItem;
            if (dataGridViewSocios.SelectedRows.Count > 0)
            {
                DialogResult dialogConfirmaBorra = MessageBox.Show("¿Estás segure de borrar?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogConfirmaBorra == DialogResult.OK)
                {
                    List<valoracions> listaValoraciones = ConsultaOrm.SelectValoracionesSocio(socioElegido);
                    if (listaValoraciones.Count >= 1)
                    {
                        //aqui borramos las valoraciones del evento a borrar
                        for (int i = 0; i < listaValoraciones.Count; i++)
                        {
                            ConsultaOrm.DeleteValoracion(listaValoraciones[i]);
                        }
                    }
                    List<menors_socis> listaRelaciones = ConsultaOrm.SelectRelacionesSocio(socioElegido);
                    if (listaRelaciones.Count >= 1)
                    {
                        //aqui borramos los menores 
                        for (int i = 0; i < listaRelaciones.Count; i++)
                        {
                            List<menors> listaMenor = ConsultaOrm.SelectRelacionMenor(listaRelaciones[i]);
                            ConsultaOrm.DeleteRelacion(listaRelaciones[i]);
                            ConsultaOrm.DeleteMenor(listaMenor[i]);
                        }
                    }
                    if (ConsultaOrm.SelectUsuarioSocio(socioElegido) != null)
                    {
                        usuaris user = new usuaris();
                        user = ConsultaOrm.SelectUsuarioSocio(socioElegido);
                        ConsultaOrm.DeleteUser(user);
                    }
                    //List<menors_socis> listaRelaciones = ConsultaOrm.SelectRelacionesSocio((socis)dataGridViewSocios.SelectedRows[0].DataBoundItem);
                    //List<menors> resultado = new List<menors>();
                    //for (int i = 0; i < listaRelaciones.Count; i++)
                    //{
                    //    resultado.Add(ConsultaOrm.SelectRelacionSocio(listaRelaciones[i]));
                    //}

                    ConsultaOrm.DeleteSocio(socioElegido);

                    this.Control_de_Usuarios_Activated(sender, e);
                }
            }
        }

        private void buttonMenores_Click(object sender, EventArgs e)
        {
            ControlMenores gestionaMenores = new ControlMenores((socis)dataGridViewSocios.SelectedRows[0].DataBoundItem);
            gestionaMenores.ShowDialog();
        }

        private void dataGridViewSocios_DoubleClick(object sender, EventArgs e)
        {
            toolStripButtonModificar_Click(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (userLogin.id_rol == 6)
            {
                Control_Usuario c = new Control_Usuario();
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tiene permisos");
            }
        }

        private void Control_de_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void dataGridViewSocios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }
    }
}
