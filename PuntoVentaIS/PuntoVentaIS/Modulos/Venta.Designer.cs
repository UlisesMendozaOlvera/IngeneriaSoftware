namespace PuntoVentaIS.Modulos
{
    partial class Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pNombreTicket = new System.Windows.Forms.Panel();
            this.btnAceptar = new PuntoVentaIS.Controles.RJButton();
            this.btnCancelar = new PuntoVentaIS.Controles.RJButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreT = new PuntoVentaIS.Controles.RJTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pCambio = new System.Windows.Forms.Panel();
            this.listBoxT = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPendiente = new PuntoVentaIS.Controles.RJButton();
            this.btnCambiar = new PuntoVentaIS.Controles.RJButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnVerificador = new PuntoVentaIS.Controles.RJButton();
            this.btnSalidas = new PuntoVentaIS.Controles.RJButton();
            this.btnEntradas = new PuntoVentaIS.Controles.RJButton();
            this.btnBuscarA = new PuntoVentaIS.Controles.RJButton();
            this.btnInsertarVarios = new PuntoVentaIS.Controles.RJButton();
            this.btnAgregar = new PuntoVentaIS.Controles.RJButton();
            this.btnEliminarT = new PuntoVentaIS.Controles.RJButton();
            this.tbNombre = new PuntoVentaIS.Controles.RJTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pNombreTicket.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pCambio.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 34);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.HotPink;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14.25F);
            this.button1.Location = new System.Drawing.Point(735, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 34);
            this.label4.TabIndex = 25;
            this.label4.Text = "VENTA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pNombreTicket);
            this.panel2.Controls.Add(this.pCambio);
            this.panel2.Controls.Add(this.btnPendiente);
            this.panel2.Controls.Add(this.btnCambiar);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.btnVerificador);
            this.panel2.Controls.Add(this.btnSalidas);
            this.panel2.Controls.Add(this.btnEntradas);
            this.panel2.Controls.Add(this.btnBuscarA);
            this.panel2.Controls.Add(this.btnInsertarVarios);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.btnEliminarT);
            this.panel2.Controls.Add(this.tbNombre);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 431);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pNombreTicket
            // 
            this.pNombreTicket.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pNombreTicket.Controls.Add(this.btnAceptar);
            this.pNombreTicket.Controls.Add(this.btnCancelar);
            this.pNombreTicket.Controls.Add(this.label5);
            this.pNombreTicket.Controls.Add(this.tbNombreT);
            this.pNombreTicket.Controls.Add(this.panel6);
            this.pNombreTicket.Location = new System.Drawing.Point(407, 314);
            this.pNombreTicket.Name = "pNombreTicket";
            this.pNombreTicket.Size = new System.Drawing.Size(307, 116);
            this.pNombreTicket.TabIndex = 2;
            this.pNombreTicket.Paint += new System.Windows.Forms.PaintEventHandler(this.pNombreTicket_Paint);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAceptar.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAceptar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAceptar.BorderRadius = 20;
            this.btnAceptar.BorderSize = 0;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.Location = new System.Drawing.Point(106, 74);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 31);
            this.btnAceptar.TabIndex = 41;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.SystemColors.Window;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.HotPink;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.HotPink;
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.Location = new System.Drawing.Point(195, 73);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 32);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.SystemColors.Window;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(17, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Nombre:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbNombreT
            // 
            this.tbNombreT.BackColor = System.Drawing.SystemColors.Window;
            this.tbNombreT.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbNombreT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbNombreT.BorderRadius = 8;
            this.tbNombreT.BorderSize = 2;
            this.tbNombreT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreT.ForeColor = System.Drawing.Color.DimGray;
            this.tbNombreT.Location = new System.Drawing.Point(83, 36);
            this.tbNombreT.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombreT.Multiline = false;
            this.tbNombreT.Name = "tbNombreT";
            this.tbNombreT.Padding = new System.Windows.Forms.Padding(7);
            this.tbNombreT.PasswordChar = false;
            this.tbNombreT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNombreT.PlaceholderText = "";
            this.tbNombreT.Size = new System.Drawing.Size(201, 31);
            this.tbNombreT.TabIndex = 28;
            this.tbNombreT.Texts = "";
            this.tbNombreT.UnderlinedStyle = false;
            this.tbNombreT._TextChanged += new System.EventHandler(this.rjTextBox1__TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(307, 29);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.HotPink;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14.25F);
            this.button3.Location = new System.Drawing.Point(258, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 29);
            this.button3.TabIndex = 30;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "¿Que nombre desea asignar al ticket pendiente?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pCambio
            // 
            this.pCambio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pCambio.Controls.Add(this.listBoxT);
            this.pCambio.Controls.Add(this.panel5);
            this.pCambio.Controls.Add(this.panel4);
            this.pCambio.Location = new System.Drawing.Point(470, 76);
            this.pCambio.Name = "pCambio";
            this.pCambio.Size = new System.Drawing.Size(295, 286);
            this.pCambio.TabIndex = 40;
            this.pCambio.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // listBoxT
            // 
            this.listBoxT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxT.FormattingEnabled = true;
            this.listBoxT.Location = new System.Drawing.Point(14, 79);
            this.listBoxT.Name = "listBoxT";
            this.listBoxT.Size = new System.Drawing.Size(269, 182);
            this.listBoxT.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(295, 38);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 38);
            this.label2.TabIndex = 28;
            this.label2.Text = "CAMBIO TICKET";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 38);
            this.panel4.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.HotPink;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 14.25F);
            this.button2.Location = new System.Drawing.Point(246, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 38);
            this.button2.TabIndex = 28;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cambio de Ticket";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPendiente
            // 
            this.btnPendiente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPendiente.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPendiente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPendiente.BorderRadius = 20;
            this.btnPendiente.BorderSize = 0;
            this.btnPendiente.FlatAppearance.BorderSize = 0;
            this.btnPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPendiente.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F);
            this.btnPendiente.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPendiente.Location = new System.Drawing.Point(102, 315);
            this.btnPendiente.Name = "btnPendiente";
            this.btnPendiente.Size = new System.Drawing.Size(83, 31);
            this.btnPendiente.TabIndex = 39;
            this.btnPendiente.Text = "Pendiente";
            this.btnPendiente.TextColor = System.Drawing.SystemColors.Window;
            this.btnPendiente.UseVisualStyleBackColor = false;
            this.btnPendiente.Click += new System.EventHandler(this.btnPendiente_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCambiar.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCambiar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCambiar.BorderRadius = 20;
            this.btnCambiar.BorderSize = 0;
            this.btnCambiar.FlatAppearance.BorderSize = 0;
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiar.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F);
            this.btnCambiar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCambiar.Location = new System.Drawing.Point(13, 315);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(83, 31);
            this.btnCambiar.TabIndex = 38;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.TextColor = System.Drawing.SystemColors.Window;
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(13, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 229);
            this.tabControl1.TabIndex = 37;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // btnVerificador
            // 
            this.btnVerificador.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVerificador.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVerificador.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVerificador.BorderRadius = 20;
            this.btnVerificador.BorderSize = 0;
            this.btnVerificador.FlatAppearance.BorderSize = 0;
            this.btnVerificador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificador.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F);
            this.btnVerificador.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVerificador.Location = new System.Drawing.Point(625, 42);
            this.btnVerificador.Name = "btnVerificador";
            this.btnVerificador.Size = new System.Drawing.Size(147, 31);
            this.btnVerificador.TabIndex = 36;
            this.btnVerificador.Text = "Verificador";
            this.btnVerificador.TextColor = System.Drawing.SystemColors.Window;
            this.btnVerificador.UseVisualStyleBackColor = false;
            // 
            // btnSalidas
            // 
            this.btnSalidas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalidas.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalidas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalidas.BorderRadius = 20;
            this.btnSalidas.BorderSize = 0;
            this.btnSalidas.FlatAppearance.BorderSize = 0;
            this.btnSalidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalidas.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F);
            this.btnSalidas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSalidas.Location = new System.Drawing.Point(472, 42);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Size = new System.Drawing.Size(147, 31);
            this.btnSalidas.TabIndex = 35;
            this.btnSalidas.Text = "Salidas";
            this.btnSalidas.TextColor = System.Drawing.SystemColors.Window;
            this.btnSalidas.UseVisualStyleBackColor = false;
            // 
            // btnEntradas
            // 
            this.btnEntradas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEntradas.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEntradas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEntradas.BorderRadius = 20;
            this.btnEntradas.BorderSize = 0;
            this.btnEntradas.FlatAppearance.BorderSize = 0;
            this.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradas.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F);
            this.btnEntradas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEntradas.Location = new System.Drawing.Point(319, 42);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(147, 31);
            this.btnEntradas.TabIndex = 34;
            this.btnEntradas.Text = "Entradas";
            this.btnEntradas.TextColor = System.Drawing.SystemColors.Window;
            this.btnEntradas.UseVisualStyleBackColor = false;
            // 
            // btnBuscarA
            // 
            this.btnBuscarA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscarA.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscarA.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscarA.BorderRadius = 20;
            this.btnBuscarA.BorderSize = 0;
            this.btnBuscarA.FlatAppearance.BorderSize = 0;
            this.btnBuscarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarA.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F);
            this.btnBuscarA.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscarA.Location = new System.Drawing.Point(166, 42);
            this.btnBuscarA.Name = "btnBuscarA";
            this.btnBuscarA.Size = new System.Drawing.Size(147, 31);
            this.btnBuscarA.TabIndex = 33;
            this.btnBuscarA.Text = "Buscar";
            this.btnBuscarA.TextColor = System.Drawing.SystemColors.Window;
            this.btnBuscarA.UseVisualStyleBackColor = false;
            // 
            // btnInsertarVarios
            // 
            this.btnInsertarVarios.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInsertarVarios.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInsertarVarios.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInsertarVarios.BorderRadius = 20;
            this.btnInsertarVarios.BorderSize = 0;
            this.btnInsertarVarios.FlatAppearance.BorderSize = 0;
            this.btnInsertarVarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarVarios.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F);
            this.btnInsertarVarios.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInsertarVarios.Location = new System.Drawing.Point(13, 42);
            this.btnInsertarVarios.Name = "btnInsertarVarios";
            this.btnInsertarVarios.Size = new System.Drawing.Size(147, 31);
            this.btnInsertarVarios.TabIndex = 32;
            this.btnInsertarVarios.Text = "INS Varios";
            this.btnInsertarVarios.TextColor = System.Drawing.SystemColors.Window;
            this.btnInsertarVarios.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Location = new System.Drawing.Point(330, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 31);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.TextColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEliminarT
            // 
            this.btnEliminarT.BackColor = System.Drawing.Color.HotPink;
            this.btnEliminarT.BackgroundColor = System.Drawing.Color.HotPink;
            this.btnEliminarT.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminarT.BorderRadius = 20;
            this.btnEliminarT.BorderSize = 0;
            this.btnEliminarT.FlatAppearance.BorderSize = 0;
            this.btnEliminarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarT.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9.75F);
            this.btnEliminarT.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminarT.Location = new System.Drawing.Point(191, 314);
            this.btnEliminarT.Name = "btnEliminarT";
            this.btnEliminarT.Size = new System.Drawing.Size(85, 32);
            this.btnEliminarT.TabIndex = 30;
            this.btnEliminarT.Text = "Eliminar";
            this.btnEliminarT.TextColor = System.Drawing.SystemColors.Window;
            this.btnEliminarT.UseVisualStyleBackColor = false;
            this.btnEliminarT.Click += new System.EventHandler(this.btnEliminarT_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.Window;
            this.tbNombre.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbNombre.BorderRadius = 8;
            this.tbNombre.BorderSize = 2;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.Color.DimGray;
            this.tbNombre.Location = new System.Drawing.Point(13, 4);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Multiline = false;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Padding = new System.Windows.Forms.Padding(7);
            this.tbNombre.PasswordChar = false;
            this.tbNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbNombre.PlaceholderText = "";
            this.tbNombre.Size = new System.Drawing.Size(310, 31);
            this.tbNombre.TabIndex = 27;
            this.tbNombre.Texts = "";
            this.tbNombre.UnderlinedStyle = false;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pNombreTicket.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pCambio.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Controles.RJButton btnAgregar;
        private Controles.RJButton btnEliminarT;
        private Controles.RJTextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private Controles.RJButton btnVerificador;
        private Controles.RJButton btnSalidas;
        private Controles.RJButton btnEntradas;
        private Controles.RJButton btnBuscarA;
        private Controles.RJButton btnInsertarVarios;
        private System.Windows.Forms.TabControl tabControl1;
        private Controles.RJButton btnPendiente;
        private Controles.RJButton btnCambiar;
        private System.Windows.Forms.Panel pCambio;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxT;
        private System.Windows.Forms.Panel pNombreTicket;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private Controles.RJTextBox tbNombreT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private Controles.RJButton btnAceptar;
        private Controles.RJButton btnCancelar;
    }
}