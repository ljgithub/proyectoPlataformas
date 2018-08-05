namespace Aplication_process
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_filtro1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bdd_helpdeskDataSet = new Aplication_process.bdd_helpdeskDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Aplication_process.bdd_helpdeskDataSetTableAdapters.usuarioTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_perfil = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_empresa = new System.Windows.Forms.TextBox();
            this.txt_telefono2 = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Empresa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bddhelpdeskDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter = new Aplication_process.bdd_helpdeskDataSetTableAdapters.roleTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_helpdeskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bddhelpdeskDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_filtro1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(343, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 60);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_filtro1
            // 
            this.txt_filtro1.Location = new System.Drawing.Point(109, 20);
            this.txt_filtro1.Name = "txt_filtro1";
            this.txt_filtro1.Size = new System.Drawing.Size(461, 20);
            this.txt_filtro1.TabIndex = 2;
            this.txt_filtro1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(343, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 307);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 307);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(6, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 60);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(151, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(39, 29);
            this.button6.TabIndex = 3;
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(112, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 29);
            this.button5.TabIndex = 2;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(73, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 29);
            this.button4.TabIndex = 1;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(25, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 29);
            this.button3.TabIndex = 0;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bdd_helpdeskDataSet
            // 
            this.bdd_helpdeskDataSet.DataSetName = "bdd_helpdeskDataSet";
            this.bdd_helpdeskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.bdd_helpdeskDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(134, 26);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(163, 20);
            this.txt_nombre.TabIndex = 6;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(134, 57);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(163, 20);
            this.txt_apellido.TabIndex = 7;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(134, 87);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(163, 20);
            this.txt_email.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Perfil";
            // 
            // cb_perfil
            // 
            this.cb_perfil.DataSource = this.roleBindingSource;
            this.cb_perfil.DisplayMember = "name_role";
            this.cb_perfil.FormattingEnabled = true;
            this.cb_perfil.Location = new System.Drawing.Point(134, 115);
            this.cb_perfil.Name = "cb_perfil";
            this.cb_perfil.Size = new System.Drawing.Size(163, 21);
            this.cb_perfil.TabIndex = 13;
            this.cb_perfil.ValueMember = "id_role";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "role";
            this.roleBindingSource.DataSource = this.bdd_helpdeskDataSet;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.cb_estado);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_empresa);
            this.panel3.Controls.Add(this.txt_telefono2);
            this.panel3.Controls.Add(this.txt_telefono);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Empresa);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cb_perfil);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_email);
            this.panel3.Controls.Add(this.txt_apellido);
            this.panel3.Controls.Add(this.txt_nombre);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(6, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 307);
            this.panel3.TabIndex = 2;
            // 
            // cb_estado
            // 
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Activo ",
            "Inactivo"});
            this.cb_estado.Location = new System.Drawing.Point(134, 245);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(163, 21);
            this.cb_estado.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Estado";
            // 
            // txt_empresa
            // 
            this.txt_empresa.Location = new System.Drawing.Point(134, 219);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(163, 20);
            this.txt_empresa.TabIndex = 19;
            this.txt_empresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_empresa_KeyPress);
            // 
            // txt_telefono2
            // 
            this.txt_telefono2.Location = new System.Drawing.Point(134, 190);
            this.txt_telefono2.Name = "txt_telefono2";
            this.txt_telefono2.Size = new System.Drawing.Size(163, 20);
            this.txt_telefono2.TabIndex = 18;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(134, 151);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(163, 20);
            this.txt_telefono.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Teléfono 2";
            // 
            // Empresa
            // 
            this.Empresa.AutoSize = true;
            this.Empresa.Location = new System.Drawing.Point(43, 223);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(48, 13);
            this.Empresa.TabIndex = 15;
            this.Empresa.Text = "Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Teléfono";
            // 
            // bddhelpdeskDataSetBindingSource
            // 
            this.bddhelpdeskDataSetBindingSource.DataSource = this.bdd_helpdeskDataSet;
            this.bddhelpdeskDataSetBindingSource.Position = 0;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 458);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Usuarios";
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdd_helpdeskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bddhelpdeskDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_filtro1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private bdd_helpdeskDataSet bdd_helpdeskDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private bdd_helpdeskDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_perfil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_empresa;
        private System.Windows.Forms.TextBox txt_telefono2;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Empresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bddhelpdeskDataSetBindingSource;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private bdd_helpdeskDataSetTableAdapters.roleTableAdapter roleTableAdapter;
        private System.Windows.Forms.Button button6;
    }
}