namespace proyecto.principal
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.dvgDatos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtSegundoNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDni = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFechNac = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservaciones = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGrado = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSeccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNivel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.control = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuevo = new Guna.UI2.WinForms.Guna2Button();
            this.btnGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatos)).BeginInit();
            this.control.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1031, 32);
            this.panelTop.TabIndex = 0;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = global::proyecto.Properties.Resources.window_minimize_icon_194428;
            this.btnMin.Location = new System.Drawing.Point(926, -4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 33);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = global::proyecto.Properties.Resources.window_maximize_icon_194441;
            this.btnMax.Location = new System.Drawing.Point(962, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(31, 26);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 3;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::proyecto.Properties.Resources.times_circle_icon_194499;
            this.btnClose.Location = new System.Drawing.Point(999, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTop;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // dvgDatos
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dvgDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dvgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dvgDatos.ColumnHeadersHeight = 15;
            this.dvgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDatos.DefaultCellStyle = dataGridViewCellStyle12;
            this.dvgDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgDatos.Location = new System.Drawing.Point(11, 219);
            this.dvgDatos.Name = "dvgDatos";
            this.dvgDatos.RowHeadersVisible = false;
            this.dvgDatos.Size = new System.Drawing.Size(1008, 124);
            this.dvgDatos.TabIndex = 1;
            this.dvgDatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgDatos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dvgDatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dvgDatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dvgDatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dvgDatos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dvgDatos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgDatos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dvgDatos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvgDatos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgDatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvgDatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dvgDatos.ThemeStyle.HeaderStyle.Height = 15;
            this.dvgDatos.ThemeStyle.ReadOnly = false;
            this.dvgDatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgDatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgDatos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgDatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dvgDatos.ThemeStyle.RowsStyle.Height = 22;
            this.dvgDatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dvgDatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BorderRadius = 13;
            this.txtSegundoNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSegundoNombre.DefaultText = "segundo nombre";
            this.txtSegundoNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSegundoNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSegundoNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSegundoNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSegundoNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSegundoNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSegundoNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSegundoNombre.Location = new System.Drawing.Point(295, 62);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.PasswordChar = '\0';
            this.txtSegundoNombre.PlaceholderText = "segundo nombre";
            this.txtSegundoNombre.SelectedText = "";
            this.txtSegundoNombre.Size = new System.Drawing.Size(136, 36);
            this.txtSegundoNombre.TabIndex = 2;
            this.txtSegundoNombre.Enter += new System.EventHandler(this.txtSegundoNombre_Enter);
            this.txtSegundoNombre.Leave += new System.EventHandler(this.txtSegundoNombre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRIMER NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TELÉFONO";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BorderRadius = 13;
            this.txtPrimerNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrimerNombre.DefaultText = "primer nombre";
            this.txtPrimerNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrimerNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrimerNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrimerNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrimerNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrimerNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrimerNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrimerNombre.Location = new System.Drawing.Point(154, 62);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.PasswordChar = '\0';
            this.txtPrimerNombre.PlaceholderText = "primer nombre";
            this.txtPrimerNombre.SelectedText = "";
            this.txtPrimerNombre.Size = new System.Drawing.Size(135, 36);
            this.txtPrimerNombre.TabIndex = 4;
            this.txtPrimerNombre.Enter += new System.EventHandler(this.txtPrimerNombre_Enter);
            this.txtPrimerNombre.Leave += new System.EventHandler(this.txtPrimerNombre_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(301, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "FECHA DE NACIMIENTO";
            // 
            // txtDni
            // 
            this.txtDni.BorderRadius = 13;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.DefaultText = "DNI";
            this.txtDni.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDni.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDni.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDni.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDni.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDni.Location = new System.Drawing.Point(437, 62);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.PlaceholderText = "DNI";
            this.txtDni.SelectedText = "";
            this.txtDni.Size = new System.Drawing.Size(136, 36);
            this.txtDni.TabIndex = 4;
            this.txtDni.Enter += new System.EventHandler(this.txtDni_Enter);
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(301, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "SEGUNDO NOMBRE";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BorderRadius = 13;
            this.txtSegundoApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSegundoApellido.DefaultText = "segundo apellido";
            this.txtSegundoApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSegundoApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSegundoApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSegundoApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSegundoApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSegundoApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSegundoApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSegundoApellido.Location = new System.Drawing.Point(153, 121);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.PasswordChar = '\0';
            this.txtSegundoApellido.PlaceholderText = "segundoapellido";
            this.txtSegundoApellido.SelectedText = "";
            this.txtSegundoApellido.Size = new System.Drawing.Size(136, 36);
            this.txtSegundoApellido.TabIndex = 10;
            this.txtSegundoApellido.Enter += new System.EventHandler(this.txtSegundoApellido_Enter);
            this.txtSegundoApellido.Leave += new System.EventHandler(this.txtSegundoApellido_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "PRIMER APELLIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(159, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "SEGUNDO APELLIDO";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BorderRadius = 13;
            this.txtPrimerApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrimerApellido.DefaultText = "primer apellido";
            this.txtPrimerApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrimerApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrimerApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrimerApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrimerApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrimerApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrimerApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrimerApellido.Location = new System.Drawing.Point(11, 121);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.PasswordChar = '\0';
            this.txtPrimerApellido.PlaceholderText = "primerapellido";
            this.txtPrimerApellido.SelectedText = "";
            this.txtPrimerApellido.Size = new System.Drawing.Size(136, 36);
            this.txtPrimerApellido.TabIndex = 10;
            this.txtPrimerApellido.Enter += new System.EventHandler(this.txtPrimerApellido_Enter);
            this.txtPrimerApellido.Leave += new System.EventHandler(this.txtPrimerApellido_Leave);
            // 
            // txtFechNac
            // 
            this.txtFechNac.AutoRoundedCorners = true;
            this.txtFechNac.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFechNac.BorderColor = System.Drawing.Color.DimGray;
            this.txtFechNac.BorderRadius = 17;
            this.txtFechNac.Checked = true;
            this.txtFechNac.FillColor = System.Drawing.Color.White;
            this.txtFechNac.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFechNac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFechNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechNac.Location = new System.Drawing.Point(295, 121);
            this.txtFechNac.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFechNac.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFechNac.Name = "txtFechNac";
            this.txtFechNac.Size = new System.Drawing.Size(136, 36);
            this.txtFechNac.TabIndex = 13;
            this.txtFechNac.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.txtFechNac.Value = new System.DateTime(2023, 9, 20, 0, 0, 0, 0);
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.BorderRadius = 13;
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "NOMBRE";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(153, 121);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "NOMBRE";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(136, 29);
            this.guna2TextBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(443, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "DNI";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderRadius = 13;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "teléfono";
            this.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.Location = new System.Drawing.Point(11, 179);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "teléfono";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.Size = new System.Drawing.Size(136, 36);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderRadius = 13;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.DefaultText = "dirección";
            this.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.Location = new System.Drawing.Point(153, 179);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PlaceholderText = "dirección";
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.Size = new System.Drawing.Size(136, 36);
            this.txtDireccion.TabIndex = 10;
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtDireccion_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(159, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "DIRECCIÓN";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BorderRadius = 13;
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservaciones.DefaultText = "observaciones";
            this.txtObservaciones.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtObservaciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtObservaciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObservaciones.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtObservaciones.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservaciones.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtObservaciones.Location = new System.Drawing.Point(295, 179);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.PasswordChar = '\0';
            this.txtObservaciones.PlaceholderText = "observaciones";
            this.txtObservaciones.SelectedText = "";
            this.txtObservaciones.Size = new System.Drawing.Size(136, 36);
            this.txtObservaciones.TabIndex = 10;
            this.txtObservaciones.Enter += new System.EventHandler(this.txtObservaciones_Enter);
            this.txtObservaciones.Leave += new System.EventHandler(this.txtObservaciones_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(301, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "OBSERVACIONES";
            // 
            // txtGrado
            // 
            this.txtGrado.BorderRadius = 13;
            this.txtGrado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGrado.DefaultText = "grado";
            this.txtGrado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGrado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGrado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGrado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGrado.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGrado.Location = new System.Drawing.Point(437, 121);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.PasswordChar = '\0';
            this.txtGrado.PlaceholderText = "grado";
            this.txtGrado.SelectedText = "";
            this.txtGrado.Size = new System.Drawing.Size(136, 36);
            this.txtGrado.TabIndex = 10;
            this.txtGrado.Enter += new System.EventHandler(this.txtGrado_Enter);
            this.txtGrado.Leave += new System.EventHandler(this.txtGrado_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(443, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "GRADO";
            // 
            // txtSeccion
            // 
            this.txtSeccion.BorderRadius = 13;
            this.txtSeccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeccion.DefaultText = "sección";
            this.txtSeccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSeccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeccion.Location = new System.Drawing.Point(437, 179);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.PasswordChar = '\0';
            this.txtSeccion.PlaceholderText = "seccion";
            this.txtSeccion.SelectedText = "";
            this.txtSeccion.Size = new System.Drawing.Size(136, 36);
            this.txtSeccion.TabIndex = 10;
            this.txtSeccion.Enter += new System.EventHandler(this.txtSeccion_Enter);
            this.txtSeccion.Leave += new System.EventHandler(this.txtSeccion_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(443, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "SECCIÓN";
            // 
            // txtNivel
            // 
            this.txtNivel.BorderRadius = 13;
            this.txtNivel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNivel.DefaultText = "nivel";
            this.txtNivel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNivel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNivel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNivel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNivel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNivel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNivel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNivel.Location = new System.Drawing.Point(579, 62);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.PasswordChar = '\0';
            this.txtNivel.PlaceholderText = "NIVEL";
            this.txtNivel.SelectedText = "";
            this.txtNivel.Size = new System.Drawing.Size(136, 36);
            this.txtNivel.TabIndex = 10;
            this.txtNivel.Enter += new System.EventHandler(this.txtNivel_Enter);
            this.txtNivel.Leave += new System.EventHandler(this.txtNivel_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(585, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "NIVEL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(591, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "SEXO";
            // 
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.Color.Transparent;
            this.txtSexo.BorderRadius = 13;
            this.txtSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSexo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtSexo.ItemHeight = 30;
            this.txtSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO",
            "OTROS"});
            this.txtSexo.Location = new System.Drawing.Point(579, 121);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(136, 36);
            this.txtSexo.TabIndex = 14;
            // 
            // control
            // 
            this.control.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.control.Controls.Add(this.btnModificar);
            this.control.Controls.Add(this.btnEliminar);
            this.control.Controls.Add(this.btnNuevo);
            this.control.Controls.Add(this.btnGuardar);
            this.control.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.control.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.control.Location = new System.Drawing.Point(825, 105);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(195, 110);
            this.control.TabIndex = 15;
            this.control.Text = "controles";
            // 
            // btnModificar
            // 
            this.btnModificar.BorderRadius = 13;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(3, 75);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 26);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "MODIFICAR";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BorderRadius = 13;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(98, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 26);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNuevo.BorderRadius = 13;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(95, 43);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(87, 26);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BorderRadius = 13;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(3, 43);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 26);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BorderRadius = 13;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "ID";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Location = new System.Drawing.Point(11, 62);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "ID";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(135, 36);
            this.txtID.TabIndex = 4;
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1031, 503);
            this.Controls.Add(this.control);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtFechNac);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.txtGrado);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.dvgDatos);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form1";
            this.Load += new System.EventHandler(this.form1_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatos)).EndInit();
            this.control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnMax;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView dvgDatos;
        private Guna.UI2.WinForms.Guna2TextBox txtSegundoNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPrimerNombre;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtDni;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtSegundoApellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPrimerApellido;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtFechNac;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtObservaciones;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtGrado;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtSeccion;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtNivel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ComboBox txtSexo;
        private Guna.UI2.WinForms.Guna2GroupBox control;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnNuevo;
        private Guna.UI2.WinForms.Guna2Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
    }
}