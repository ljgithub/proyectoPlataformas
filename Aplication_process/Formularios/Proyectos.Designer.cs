namespace Aplication_process
{
    partial class Proyectos
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_actualizar_registro = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.rh_alcance = new System.Windows.Forms.RichTextBox();
            this.rh_objetivo = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rh_descrip = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_porcentaje = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_presupuesto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chb_estado = new System.Windows.Forms.CheckBox();
            this.Estado = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.tipeproyectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdd_helpdeskDataSet1 = new Aplication_process.bdd_helpdeskDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_usu = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdd_helpdeskDataSet = new Aplication_process.bdd_helpdeskDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.dp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.dp_fecha_ini = new System.Windows.Forms.DateTimePicker();
            this.txt_empresa = new System.Windows.Forms.TextBox();
            this.txt_link_Proy = new System.Windows.Forms.TextBox();
            this.txt_Porc_Proy = new System.Windows.Forms.TextBox();
            this.txt_nomProy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Empresa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_actualizar_grid = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usuarioTableAdapter = new Aplication_process.bdd_helpdeskDataSetTableAdapters.usuarioTableAdapter();
            this.tipe_proyectTableAdapter = new Aplication_process.bdd_helpdeskDataSet1TableAdapters.tipe_proyectTableAdapter();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipeproyectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_helpdeskDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_helpdeskDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_actualizar_registro);
            this.panel4.Controls.Add(this.btn_eliminar);
            this.panel4.Controls.Add(this.btn_guardar);
            this.panel4.Location = new System.Drawing.Point(806, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 428);
            this.panel4.TabIndex = 6;
            // 
            // btn_actualizar_registro
            // 
            this.btn_actualizar_registro.Location = new System.Drawing.Point(27, 143);
            this.btn_actualizar_registro.Name = "btn_actualizar_registro";
            this.btn_actualizar_registro.Size = new System.Drawing.Size(150, 80);
            this.btn_actualizar_registro.TabIndex = 2;
            this.btn_actualizar_registro.Text = "Actualizar";
            this.btn_actualizar_registro.UseVisualStyleBackColor = true;
            this.btn_actualizar_registro.Click += new System.EventHandler(this.btn_actualizar_registro_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(27, 283);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(150, 80);
            this.btn_eliminar.TabIndex = 1;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(27, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(150, 80);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.rh_alcance);
            this.panel3.Controls.Add(this.rh_objetivo);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.rh_descrip);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_porcentaje);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_presupuesto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.chb_estado);
            this.panel3.Controls.Add(this.Estado);
            this.panel3.Controls.Add(this.cmb_tipo);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cmb_usu);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dp_fecha_fin);
            this.panel3.Controls.Add(this.dp_fecha_ini);
            this.panel3.Controls.Add(this.txt_empresa);
            this.panel3.Controls.Add(this.txt_link_Proy);
            this.panel3.Controls.Add(this.txt_Porc_Proy);
            this.panel3.Controls.Add(this.txt_nomProy);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Empresa);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(60, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 428);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Alcance";
            // 
            // rh_alcance
            // 
            this.rh_alcance.Location = new System.Drawing.Point(123, 347);
            this.rh_alcance.Name = "rh_alcance";
            this.rh_alcance.Size = new System.Drawing.Size(564, 67);
            this.rh_alcance.TabIndex = 29;
            this.rh_alcance.Text = "";
            // 
            // rh_objetivo
            // 
            this.rh_objetivo.Location = new System.Drawing.Point(487, 218);
            this.rh_objetivo.Name = "rh_objetivo";
            this.rh_objetivo.Size = new System.Drawing.Size(200, 96);
            this.rh_objetivo.TabIndex = 28;
            this.rh_objetivo.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Objetivo";
            // 
            // rh_descrip
            // 
            this.rh_descrip.Location = new System.Drawing.Point(123, 218);
            this.rh_descrip.Name = "rh_descrip";
            this.rh_descrip.Size = new System.Drawing.Size(200, 96);
            this.rh_descrip.TabIndex = 26;
            this.rh_descrip.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Descripción";
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(487, 153);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(200, 20);
            this.txt_porcentaje.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Porcentaje";
            // 
            // txt_presupuesto
            // 
            this.txt_presupuesto.Location = new System.Drawing.Point(134, 54);
            this.txt_presupuesto.Name = "txt_presupuesto";
            this.txt_presupuesto.Size = new System.Drawing.Size(134, 20);
            this.txt_presupuesto.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Presupuesto";
            // 
            // chb_estado
            // 
            this.chb_estado.AutoSize = true;
            this.chb_estado.Location = new System.Drawing.Point(134, 20);
            this.chb_estado.Name = "chb_estado";
            this.chb_estado.Size = new System.Drawing.Size(15, 14);
            this.chb_estado.TabIndex = 20;
            this.chb_estado.UseVisualStyleBackColor = true;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(43, 20);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(40, 13);
            this.Estado.TabIndex = 19;
            this.Estado.Text = "Estado";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipeproyectBindingSource, "id_tproy", true));
            this.cmb_tipo.DataSource = this.tipeproyectBindingSource;
            this.cmb_tipo.DisplayMember = "nombre_tproy";
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(487, 119);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(200, 21);
            this.cmb_tipo.TabIndex = 18;
            this.cmb_tipo.ValueMember = "id_tproy";
            // 
            // tipeproyectBindingSource
            // 
            this.tipeproyectBindingSource.DataMember = "tipe_proyect";
            this.tipeproyectBindingSource.DataSource = this.bdd_helpdeskDataSet1;
            // 
            // bdd_helpdeskDataSet1
            // 
            this.bdd_helpdeskDataSet1.DataSetName = "bdd_helpdeskDataSet1";
            this.bdd_helpdeskDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipo";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmb_usu
            // 
            this.cmb_usu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuarioBindingSource, "id_user", true));
            this.cmb_usu.DataSource = this.usuarioBindingSource;
            this.cmb_usu.DisplayMember = "name_user";
            this.cmb_usu.FormattingEnabled = true;
            this.cmb_usu.Location = new System.Drawing.Point(134, 181);
            this.cmb_usu.Name = "cmb_usu";
            this.cmb_usu.Size = new System.Drawing.Size(134, 21);
            this.cmb_usu.TabIndex = 15;
            this.cmb_usu.ValueMember = "id_user";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.bdd_helpdeskDataSet;
            // 
            // bdd_helpdeskDataSet
            // 
            this.bdd_helpdeskDataSet.DataSetName = "bdd_helpdeskDataSet";
            this.bdd_helpdeskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Usuario";
            // 
            // dp_fecha_fin
            // 
            this.dp_fecha_fin.Location = new System.Drawing.Point(487, 53);
            this.dp_fecha_fin.Name = "dp_fecha_fin";
            this.dp_fecha_fin.Size = new System.Drawing.Size(200, 20);
            this.dp_fecha_fin.TabIndex = 13;
            // 
            // dp_fecha_ini
            // 
            this.dp_fecha_ini.Location = new System.Drawing.Point(487, 19);
            this.dp_fecha_ini.Name = "dp_fecha_ini";
            this.dp_fecha_ini.Size = new System.Drawing.Size(200, 20);
            this.dp_fecha_ini.TabIndex = 12;
            // 
            // txt_empresa
            // 
            this.txt_empresa.Location = new System.Drawing.Point(487, 86);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(200, 20);
            this.txt_empresa.TabIndex = 11;
            // 
            // txt_link_Proy
            // 
            this.txt_link_Proy.Location = new System.Drawing.Point(134, 151);
            this.txt_link_Proy.Name = "txt_link_Proy";
            this.txt_link_Proy.Size = new System.Drawing.Size(134, 20);
            this.txt_link_Proy.TabIndex = 8;
            // 
            // txt_Porc_Proy
            // 
            this.txt_Porc_Proy.Location = new System.Drawing.Point(134, 121);
            this.txt_Porc_Proy.Name = "txt_Porc_Proy";
            this.txt_Porc_Proy.Size = new System.Drawing.Size(134, 20);
            this.txt_Porc_Proy.TabIndex = 7;
            // 
            // txt_nomProy
            // 
            this.txt_nomProy.Location = new System.Drawing.Point(134, 90);
            this.txt_nomProy.Name = "txt_nomProy";
            this.txt_nomProy.Size = new System.Drawing.Size(134, 20);
            this.txt_nomProy.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha final";
            // 
            // Empresa
            // 
            this.Empresa.AutoSize = true;
            this.Empresa.Location = new System.Drawing.Point(405, 86);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(48, 13);
            this.Empresa.TabIndex = 4;
            this.Empresa.Text = "Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Link";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Porcentaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombres";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(60, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 164);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(990, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_actualizar_grid);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(512, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 52);
            this.panel1.TabIndex = 7;
            // 
            // btn_actualizar_grid
            // 
            this.btn_actualizar_grid.Location = new System.Drawing.Point(444, 15);
            this.btn_actualizar_grid.Name = "btn_actualizar_grid";
            this.btn_actualizar_grid.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar_grid.TabIndex = 3;
            this.btn_actualizar_grid.Text = "Actualizar";
            this.btn_actualizar_grid.UseVisualStyleBackColor = true;
            this.btn_actualizar_grid.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(351, 17);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tipe_proyectTableAdapter
            // 
            this.tipe_proyectTableAdapter.ClearBeforeFill = true;
            // 
            // Proyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Proyectos";
            this.Text = "Proyectos";
            this.Load += new System.EventHandler(this.Proyectos_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipeproyectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_helpdeskDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdd_helpdeskDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_actualizar_registro;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_empresa;
        private System.Windows.Forms.TextBox txt_link_Proy;
        private System.Windows.Forms.TextBox txt_Porc_Proy;
        private System.Windows.Forms.TextBox txt_nomProy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Empresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_actualizar_grid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_usu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dp_fecha_fin;
        private System.Windows.Forms.DateTimePicker dp_fecha_ini;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bdd_helpdeskDataSet bdd_helpdeskDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private bdd_helpdeskDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private bdd_helpdeskDataSet1 bdd_helpdeskDataSet1;
        private System.Windows.Forms.BindingSource tipeproyectBindingSource;
        private bdd_helpdeskDataSet1TableAdapters.tipe_proyectTableAdapter tipe_proyectTableAdapter;
        private System.Windows.Forms.CheckBox chb_estado;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.TextBox txt_presupuesto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_porcentaje;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rh_descrip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rh_objetivo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rh_alcance;
    }
}