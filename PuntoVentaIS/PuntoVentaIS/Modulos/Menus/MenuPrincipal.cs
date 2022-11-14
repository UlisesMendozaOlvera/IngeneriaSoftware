using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoVentaIS.Modulos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        int posX = 0;
        int posY = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void rjButton7_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            this.Hide();
            u.ShowDialog();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Venta V = new Venta();
            this.Hide();
            V.ShowDialog();
        
    }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            Modulos.Menus.MenuProductos p = new Modulos.Menus.MenuProductos();
            this.Hide();
            p.ShowDialog();
        }
    }
}
