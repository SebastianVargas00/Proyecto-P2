
namespace Proyecto_P2
{
    partial class Producto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textstock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textfecha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textdes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textestado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 201);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(9, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textcode
            // 
            this.textcode.Location = new System.Drawing.Point(81, 126);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(137, 20);
            this.textcode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(4, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(81, 22);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(137, 20);
            this.textnombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(228, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo";
            // 
            // textcodigo
            // 
            this.textcodigo.Location = new System.Drawing.Point(299, 19);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(137, 20);
            this.textcodigo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(238, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stock";
            // 
            // textstock
            // 
            this.textstock.Location = new System.Drawing.Point(299, 60);
            this.textstock.Name = "textstock";
            this.textstock.Size = new System.Drawing.Size(137, 20);
            this.textstock.TabIndex = 9;
            this.textstock.TextChanged += new System.EventHandler(this.textstock_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(401, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha Vencimiento";
            // 
            // textfecha
            // 
            this.textfecha.Location = new System.Drawing.Point(570, 126);
            this.textfecha.Name = "textfecha";
            this.textfecha.Size = new System.Drawing.Size(137, 20);
            this.textfecha.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(452, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripcion";
            // 
            // textdes
            // 
            this.textdes.Location = new System.Drawing.Point(570, 19);
            this.textdes.Name = "textdes";
            this.textdes.Size = new System.Drawing.Size(137, 20);
            this.textdes.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(452, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID-Categoria";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(570, 62);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(137, 20);
            this.textid.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(9, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Estado";
            // 
            // textestado
            // 
            this.textestado.Location = new System.Drawing.Point(81, 72);
            this.textestado.Name = "textestado";
            this.textestado.Size = new System.Drawing.Size(137, 20);
            this.textestado.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(76, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(320, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(232, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 31);
            this.button3.TabIndex = 20;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textestado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textdes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textfecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textstock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textstock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textdes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textestado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}