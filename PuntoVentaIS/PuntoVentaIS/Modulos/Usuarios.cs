using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PuntoVentaIS.Controles;
using System.Runtime.InteropServices;

namespace PuntoVentaIS.Modulos
{
    public partial class Usuarios : Form
    {
        
        public Usuarios()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            btnCambios.Visible = false;
            btnGuardar.Visible = false;
            btnEliminar.Visible = false;
            mostrar();
        }
        //Metodos
        private void limpiar(Panel panel)
        {
            foreach (var c in panel.Controls)
            {
                if (c is RJTextBox) { ((RJTextBox)c).Texts = ""; }
                if (c is RJComboBox) { ((RJComboBox)c).SelectedIndex = 0; }

            }
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
     );
        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.Canexion.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
                con.Close();
                dgvUsuarios.Columns[0].Visible = false;
                dgvUsuarios.Columns[4].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // Clases.Tamaño_automatico_de_datatables.Multilinea(ref dgvUsuarios);
        }
       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox4__TextChanged(object sender, EventArgs e)
        {

        }
        //Boton Guardar
        private void rjButton2_Click(object sender, EventArgs e)
        {
            string rol="";
            if ( tbNombre.Texts != "" && tbUsuario.Texts != "" && tbContra.Texts != "" && tbConfirmar.Texts != "")
            {
                if (tgAdmin.Checked)
                {
                    rol = "admin";
                }
                if (tgCajero.Checked)
                {
                    rol = "cajero";
                }
                if (tbContra.Texts != tbConfirmar.Texts)
                {
                    MessageBox.Show("Las contraseña no considen ");
                }
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.Canexion.conexion;
                        con.Open();
                        SqlCommand query = new SqlCommand();
                        query = new SqlCommand("insertar_usuario", con);
                        query.CommandType = CommandType.StoredProcedure;
                        query.Parameters.AddWithValue("@nombre", tbNombre.Texts);
                        query.Parameters.AddWithValue("@usuario", tbUsuario.Texts);
                        query.Parameters.AddWithValue("@rol", rol);
                        query.Parameters.AddWithValue("@contrasena", tbContra.Texts);
                        query.Parameters.AddWithValue("@estado", "ACTIVO");


                        query.ExecuteNonQuery();
                        con.Close();
                        mostrar();
                        limpiar(panelUsuario);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
              
            }
             else
            {
                MessageBox.Show("Hay campos vacios");
            }
        }
        //Boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string rol = "";
            if (tbNombre.Texts != "" && tbUsuario.Texts != "" && tbContra.Texts != "" && tbConfirmar.Texts != "")
            {
                if (tgAdmin.Checked)
                {
                    rol = "admin";
                }
                if (tgCajero.Checked)
                {
                    rol = "cajero";
                }
                if (tbContra.Texts != tbConfirmar.Texts)
                {
                    MessageBox.Show("Las contraseña no considen ");
                }
                else
                {
                    try
                    {
                        DialogResult result;
                        result = MessageBox.Show("¿Esta seguro que desea Eliminar este Usuario?", "Eliminando Usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            SqlConnection con = new SqlConnection();
                            con.ConnectionString = Conexion.Canexion.conexion;
                            con.Open();
                            SqlCommand query = new SqlCommand();
                            query = new SqlCommand("eliminar_usuario", con);
                            query.CommandType = CommandType.StoredProcedure;
                            query.Parameters.AddWithValue("@id_usuario", dgvUsuarios.SelectedCells[0].Value.ToString());
                            query.Parameters.AddWithValue("@rol", rol);


                            query.ExecuteNonQuery();
                            con.Close();
                            mostrar();
                            limpiar(panelUsuario);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Hay campos vacios");
            }
        }

        private void tgCajero_CheckedChanged(object sender, EventArgs e)
        {
            if (tgCajero.Checked)
            {
                tgAdmin.Checked = false;
            }
        }

        private void tgAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (tgAdmin.Checked)
            {
                tgCajero.Checked = false;
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar(panelUsuario);
            string rol = "";
            tbNombre.Texts = dgvUsuarios.SelectedCells[1].Value.ToString();
            tbUsuario.Texts = dgvUsuarios.SelectedCells[2].Value.ToString();
            rol = dgvUsuarios.SelectedCells[3].Value.ToString();
            tbContra.Texts = dgvUsuarios.SelectedCells[4].Value.ToString();
            if (rol == "cajero")
            {
                tgCajero.Checked = true;
                tgAdmin.Checked = false;

            }
            else if (rol == "admin")
            {
                tgCajero.Checked = false;
                tgAdmin.Checked = true;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            limpiar(panelUsuario);

            btnEliminar.Visible = false;
            btnCambios.Visible = false;
            btnGuardar.Visible = true;
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            limpiar(panelUsuario);

            btnCambios.Visible = false;
            btnGuardar.Visible = false;
            btnEliminar.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            limpiar(panelUsuario);
            btnGuardar.Visible = false;
            btnEliminar.Visible = false;
            btnCambios.Visible = true;
           
        }

        private void btnCambios_Click(object sender, EventArgs e)
        {
            string rol = "";
            if (tbNombre.Texts != "" && tbUsuario.Texts != "" && tbContra.Texts != "" && tbConfirmar.Texts != "")
            {
                if (tgAdmin.Checked)
                {
                    rol = "admin";
                }
                if (tgCajero.Checked)
                {
                    rol = "cajero";
                }
                if (tbContra.Texts != tbConfirmar.Texts)
                {
                    MessageBox.Show("Las contraseña no considen ");
                }
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Conexion.Canexion.conexion;
                        con.Open();
                        SqlCommand query = new SqlCommand();
                        query = new SqlCommand("editar_usuario", con);
                        query.CommandType = CommandType.StoredProcedure;
                        query.Parameters.AddWithValue("@id_usuario", dgvUsuarios.SelectedCells[0].Value.ToString());
                        query.Parameters.AddWithValue("@nombre", tbNombre.Texts);
                        query.Parameters.AddWithValue("@usuario", tbUsuario.Texts);
                        query.Parameters.AddWithValue("@rol", rol);
                        query.Parameters.AddWithValue("@contrasena", tbContra.Texts);

                        query.ExecuteNonQuery();
                        con.Close();
                        mostrar();
                        limpiar(panelUsuario);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Hay campos vacios");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar_usuario();
        }
        private void buscar_usuario()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.Canexion.conexion;
                con.Open();
                da = new SqlDataAdapter("buscar_usuario", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", tbBuscar.Texts);
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
                con.Close();
                dgvUsuarios.Columns[0].Visible = false;
                dgvUsuarios.Columns[4].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void tbBuscar__TextChanged(object sender, EventArgs e)
        {
           
                buscar_usuario();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
