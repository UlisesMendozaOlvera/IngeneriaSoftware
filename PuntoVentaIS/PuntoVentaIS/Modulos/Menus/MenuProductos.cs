using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using PuntoVentaIS.Controles;

namespace PuntoVentaIS.Modulos.Menus
{
    public partial class MenuProductos : Form
    {
        public MenuProductos()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        int posY = 0;
        int posX = 0;
        private const int cGrip = 16;
        private const int cCaption = 32;

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

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        private void limpiar(Panel panel)
        {
            foreach (var c in panel.Controls)
            {
                if (c is RJTextBox) { ((RJTextBox)c).Texts = ""; }
                if (c is RJComboBox) { ((RJComboBox)c).SelectedIndex = 0; }

            }
        }
        private void buscar_producto()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.Canexion.conexion;
                con.Open();
                da = new SqlDataAdapter("buscar_producto", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", tbBuscar.Texts);
                da.Fill(dt);
                dgvProductos.DataSource = dt;
                con.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.Canexion.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_departamentos", con);
                da.Fill(dt);
                dgvDepartamentos.DataSource = null;

                dgvDepartamentos.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mostrar_productos()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.Canexion.conexion;
                con.Open();
                da = new SqlDataAdapter("mostrar_productos", con);
                da.Fill(dt);
                dgvProductosT.DataSource = null;

                dgvProductosT.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buscar_departamento()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.Canexion.conexion;
                con.Open();
                da = new SqlDataAdapter("buscar_departamento", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", tbbuscarD.Texts);
                da.Fill(dt);
                dgvDepartamentos.DataSource = null;
                dgvDepartamentos.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pNuevoP.Dock = DockStyle.Fill;
            pEditarP.Visible = false;
            pEliminarP.Visible = false;
            pDepartamento.Visible = false;
            pCatalogo.Visible = false;
            pNuevoP.Visible = true;

        }

        private void btnCambios_Click(object sender, EventArgs e)
        {

        }

        private void pNuevoProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbNombre__TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuProductos_Load(object sender, EventArgs e)
        {
            button4.Visible = false;
            pNuevoP.Visible = false;
            pEditarP.Visible = false;
            pEliminarP.Visible = false;
            pDepartamento.Visible = false;
            pCatalogo.Dock = DockStyle.Fill;

            mostrar_productos();



        }

        private void pNuevoP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gbInventario_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            //El form se maximizó

            //Ocultamos el botón maximiza
            button2.Visible = false;
            button3.Visible = true;
            //Mostramos el botón restablecer
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //El form se restableció a su tamaño

            //Ocultamos el botón restablecer
            button4.Visible = false;

            //Mostramos el botón maximizar
            button2.Visible = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button!= MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;

            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);

            }
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void pNuevoP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;

            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);

            }
        }

        private void rjTextBox8__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pEditarP.Dock = DockStyle.Fill;
            pEditarP.Visible = true;
            pNuevoP.Visible = false;
            pDepartamento.Visible = false;
            pEliminarP.Visible = false;
            pCatalogo.Visible = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar_producto();
        }

        private void tbBuscar__TextChanged(object sender, EventArgs e)
        {
            buscar_producto();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            pNuevoP.Visible = false;
            pEditarP.Visible = false;
            pDepartamento.Visible = false;
            pCatalogo.Visible = false;
            pEliminarP.Dock = DockStyle.Fill;
            pEliminarP.Visible = true;
        }

        private void rjTextBox19__TextChanged(object sender, EventArgs e)
        {
            buscar_departamento();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            buscar_departamento();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            pEliminarP.Visible = false;
            pEditarP.Visible = false;
            pNuevoP.Visible = false;
            pCatalogo.Visible = false;
            pDepartamento.Dock = DockStyle.Fill;
            pDepartamento.Visible = true;
            mostrar();

        }

        private void dgvDepartamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar(pDepartamento);
            tbNombreDepartamento.Texts = dgvDepartamentos.SelectedCells[0].Value.ToString();

        }

        private void btnGaurdarD_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.Canexion.conexion;
                con.Open();
                SqlCommand query = new SqlCommand();
                query = new SqlCommand("insertar_departamento", con);
                query.CommandType = CommandType.StoredProcedure;
                query.Parameters.AddWithValue("@nombre", tbNombreDepartamento.Texts);
         


                query.ExecuteNonQuery();
                con.Close();
                mostrar();
                limpiar(pDepartamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show("¿Esta seguro que desea Eliminar este Departamento?", "Eliminando Deaprtamento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = Conexion.Canexion.conexion;
                    con.Open();
                    SqlCommand query = new SqlCommand();
                    query = new SqlCommand("eliminar_departamento", con);
                    query.CommandType = CommandType.StoredProcedure;
                    query.Parameters.AddWithValue("@nombre", tbNombreDepartamento.Texts);
                 


                    query.ExecuteNonQuery();
                    con.Close();
                    mostrar();
                    limpiar(pDepartamento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            pEliminarP.Visible = false;
            pEditarP.Visible = false;
            pNuevoP.Visible = false;
            pDepartamento.Visible = false;
            pCatalogo.Dock = DockStyle.Fill;
            pCatalogo.Visible = true;
            mostrar_productos();
           
        }
    }
}
