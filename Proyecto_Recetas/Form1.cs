using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Recetas
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> POSTRES = new Dictionary<string, List<string>>();
        List<string> Ingredientes = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void refreshlistaing()
        {
            lbing.Items.Clear();
            foreach (string ingrediente in Ingredientes)
            {
                lbing.Items.Add(ingrediente);
            }
        }

        private void refreshdgw()
        {
            dgw.Rows.Clear();
            foreach (string postreName in POSTRES.Keys.OrderBy(name => name))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgw);
                row.Cells[0].Value = postreName;
                dgw.Rows.Add(row);
            }
        }

        private void bttaddpost_Click(object sender, EventArgs e)
        {
            string postreName = txting.Text.Trim();

            if (!string.IsNullOrWhiteSpace(postreName))
            {
                POSTRES[postreName] = new List<string>(); // Creamos una nueva lista de ingredientes para el postre
                txting.Clear();
                refreshdgw();
            }
            else
            {
                MessageBox.Show("Campo en blanco. Por favor, ingresa un nombre de postre.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgw.Rows.Count)
            {
                string postreName = dgw.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (POSTRES.ContainsKey(postreName))
                {
                    lblname.Text = postreName;
                    lbing.Items.Clear();
                    foreach (string ingrediente in POSTRES[postreName])
                    {
                        lbing.Items.Add(ingrediente);
                    }
                }

            }
        }

        private void bttadding_Click(object sender, EventArgs e)
        {
            string nuevoIngrediente = txtadding.Text;
            string postreSeleccionado = lblname.Text;

            if (!string.IsNullOrWhiteSpace(nuevoIngrediente) && POSTRES.ContainsKey(postreSeleccionado))
            {
                POSTRES[postreSeleccionado].Add(nuevoIngrediente);
                refreshlistaing();
            }
            else
            {
                MessageBox.Show("Campo en blanco. Por favor, ingresa un ingrediente para agregar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtadding.Clear();
        }

        private void bttdeling_Click(object sender, EventArgs e)
        {
            string ingredienteEliminar = txtdeling.Text;
            string postreSeleccionado = lblname.Text;

            if (!string.IsNullOrWhiteSpace(ingredienteEliminar) && POSTRES.ContainsKey(postreSeleccionado))
            {
                POSTRES[postreSeleccionado].Remove(ingredienteEliminar);
                refreshlistaing();
            }
            else
            {
                MessageBox.Show("Campo en blanco. Por favor, ingresa un ingrediente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtdeling.Clear();
        }

        private void bttbuscar_Click(object sender, EventArgs e)
        {
            string palabraBuscada = txtbuscar.Text.ToLower();

            if (string.IsNullOrWhiteSpace(palabraBuscada))
            {
                MessageBox.Show("Campo en blanco. Por favor, ingresa una palabra para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in dgw.Rows)
            {
                if (row.Cells[0].Value != null) // Verificar si la celda no está vacía
                {
                    string postreName = row.Cells[0].Value.ToString().ToLower();
                    if (postreName.Contains(palabraBuscada))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow; // Cambiar color de fondo
                        dgw.CurrentCell = row.Cells[0]; // Seleccionar la celda
                        dgw.FirstDisplayedScrollingRowIndex = row.Index; // Centrar la vista en la celda
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White; // Volver al color original
                    }
                }
            }
        }


        private void bttdel_Click(object sender, EventArgs e)
        {
            string postreSeleccionado = lblname.Text;
            if (!string.IsNullOrEmpty(postreSeleccionado) && POSTRES.ContainsKey(postreSeleccionado))
            {
                POSTRES.Remove(postreSeleccionado);
                lblname.Text = "-";
                Ingredientes.Clear(); // Limpiar la lista de ingredientes
                refreshlistaing(); // Actualizar la lista de ingredientes
                refreshdgw();
            }
        }
    }
}