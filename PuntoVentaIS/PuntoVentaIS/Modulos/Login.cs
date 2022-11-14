using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoVentaIS.Controles;
using System.IO;
using System.Collections;
using System.Runtime.InteropServices;

namespace PuntoVentaIS.Modulos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }
        string usuario = "";
        int contador;
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
        public void DibujarUsuarios()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Conexion.Canexion.conexion;
            con.Open();
            SqlCommand query = new SqlCommand();
            query = new SqlCommand("select * from usuario where estado='ACTIVO'", con);
            SqlDataReader rdr = query.ExecuteReader();
            while (rdr.Read())
            {
                RJButton nuevo = new RJButton();
                nuevo.Text = rdr["usuario"].ToString();
                nuevo.Tag = rdr["usuario"].ToString();

                nuevo.Name = rdr["id_usuario"].ToString();
                nuevo.Size = new System.Drawing.Size(176, 159);
                nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
                nuevo.FlatStyle = FlatStyle.Flat;
                nuevo.BackColor = Color.FromArgb(51, 153, 255);
                nuevo.ForeColor = Color.Black;
                if (rdr["rol"].ToString() == "admin")
                {
                    Bitmap imagen = new Bitmap(@"D:\Documents\Visual Studio 2015\Projects\PuntoVentaIS\PuntoVentaIS\Iconos\user_kids_avatar_user_profile_icon_149314.ico");
                    nuevo.Image = imagen;
                }
                else
                {
                    Bitmap imagen = new Bitmap(@"D:\Documents\Visual Studio 2015\Projects\PuntoVentaIS\PuntoVentaIS\Iconos\user_kids_avatar_icon_149311.ico");
                    nuevo.Image = imagen;
                }
           
                nuevo.ImageAlign = ContentAlignment.TopCenter;
                nuevo.TextAlign = ContentAlignment.BottomCenter;
               
                nuevo.BorderRadius = 20;
                flowLayoutPanel1.Controls.Add(nuevo);
                nuevo.Click +=new EventHandler(miEventoBoton);
            }

            
            con.Close();
        }
        private void IniciarSesion(string c)
        {
            validar_usuario(c);
            contar();
            if (contador > 0)
            {
                MenuPrincipal menu = new MenuPrincipal();
                this.Hide();
                menu.ShowDialog();
            }
        }
        private void contar()
        {
            int x;
            x = dgvUsuarios.Rows.Count;
            contador = (x);
        }
        private void validar_usuario(string c)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Conexion.Canexion.conexion;
                con.Open();
                da = new SqlDataAdapter("validar_usuario", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@contra",c);
                da.SelectCommand.Parameters.AddWithValue("@usuario",usuario);
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
                con.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Clases.Tamaño_automatico_de_datatables.Multilinea(ref dgvUsuarios);
        }
        private void miEventoBoton(Object sender,EventArgs e)
        {
            panel3.Visible = true;
            panel3.Location = new Point(130, 50);
            usuario = ((RJButton)sender).Text.ToString();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            dgvUsuarios.Visible = false;
            DibujarUsuarios();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btnCambios_Click(object sender, EventArgs e)
        {
            
            IniciarSesion(tbcontra.Texts);
        }

        private void tbcontra__TextChanged(object sender, EventArgs e)
        {
            

        }
        int posX = 0;
        int posY = 0;

        private void label1_MouseMove(object sender, MouseEventArgs e)
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

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
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

        private void tbcontra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
