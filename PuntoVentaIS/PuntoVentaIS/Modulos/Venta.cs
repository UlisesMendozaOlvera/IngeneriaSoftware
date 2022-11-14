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
    public partial class Venta : Form
    {

        public Venta()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


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
        private void CrearTicket()
        {
            if (tabControl1.TabPages.Count > 5)
            {
                MessageBox.Show("No se puede agregar mas Tickets maximo de Tickets 5");
            }
            else
            {


                for (int i = 0; i <= tabControl1.TabPages.Count; i++)
                {


                    if (tabControl1.TabPages.ContainsKey(tabControl1.Name = "ticket 1") == false)
                    {

                        string t = "TICKET 1";

                        tabControl1.SelectedIndex = 1;
                        tabControl1.Name = t;
                        tabControl1.TabPages.Add("ticket 1", t);
                        listBoxT.Items.Add(t);
                        tabControl1.SelectTab(1);
                        break;
                    }
                    if (tabControl1.TabPages.ContainsKey(tabControl1.Name = "ticket 2") == false)
                    {

                        string t = "TICKET 2";

                        tabControl1.SelectedIndex = 2;
                        tabControl1.Name = t;
                        tabControl1.TabPages.Add("ticket 2", t);
                        listBoxT.Items.Add(t);
                        tabControl1.SelectTab(2);
                        break;
                    }
                    if (tabControl1.TabPages.ContainsKey(tabControl1.Name = "ticket 3") == false)
                    {

                        string t = "TICKET 3";

                        tabControl1.SelectedIndex = 3;
                        tabControl1.Name = t;
                        tabControl1.TabPages.Add("ticket 3", t);
                        listBoxT.Items.Add(t);
                        tabControl1.SelectTab(3);
                        break;
                    }
                    if (tabControl1.TabPages.ContainsKey(tabControl1.Name = "ticket 4") == false)
                    {

                        string t = "TICKET 4";

                        tabControl1.SelectedIndex = 4;
                        tabControl1.Name = t;
                        tabControl1.TabPages.Add("ticket 4", t);
                        listBoxT.Items.Add(t);
                        tabControl1.SelectTab(4);
                        break;
                    }
                    if (tabControl1.TabPages.ContainsKey(tabControl1.Name = "ticket 5") == false)
                    {

                        string t = "TICKET 5";

                        tabControl1.SelectedIndex = 5;
                        tabControl1.Name = t;
                        tabControl1.TabPages.Add("ticket 5", t);
                        listBoxT.Items.Add(t);
                        tabControl1.SelectTab(5);
                        break;
                    }
                }


            }
        }
        
        
            public static void centraX(Control padre, Control hijo)
            {
                int x = 0;

                //un poco de matematicas, restando los anchos y dividiendo entre 2
                x = (padre.Width / 2) - (hijo.Width / 2);

                //asignamos la nueva ubicación
                hijo.Location = new System.Drawing.Point(x, hijo.Location.Y);
            }
        
        private void Venta_Load(object sender, EventArgs e)
        {
            pCambio.Visible = false;
            pNombreTicket.Visible = false;
            tabControl1.TabPages.Add("ticket1", "TICKET");
            tabControl1.SelectedIndex = 1;
            string n = "TICKET";
            tabControl1.Name = n;
            listBoxT.Items.Add(n);
            


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
           
           
            pNombreTicket.Visible = true;
            pNombreTicket.Location = new Point(240, 100);

            tbNombreT.Texts = tabControl1.SelectedTab.Text;

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void btnEliminarT_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count == 1)
            {
                MessageBox.Show("No hay Tickets para eliminar");
            }
            else if (tabControl1.SelectedTab.Text == "TICKET")
            {
                MessageBox.Show("No se puede elimianr el Ticket");

            }
            else
            {   
                for(int i=0;i<listBoxT.Items.Count;i++)
                {
                    if (listBoxT.Items[i].ToString() == tabControl1.SelectedTab.Text)
                    {
                        listBoxT.Items.Remove(listBoxT.Items[i]);
                        tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                        tabControl1.SelectTab(i-1);
                    }
                }
                
                  
            }
          }
            
        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            pCambio.Visible = true;
            
            pCambio.Location = new Point(130, 50);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            pCambio.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pNombreTicket_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pNombreTicket.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CrearTicket();
            pNombreTicket.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pNombreTicket.Visible = false;
        }
    }
}
