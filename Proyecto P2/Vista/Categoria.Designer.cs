
namespace Proyecto_P2
{
    partial class Categoria
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
            this.textcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textestado = new System.Windows.Forms.TextBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonalter = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 212);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textcodigo
            // 
            this.textcodigo.Location = new System.Drawing.Point(42, 81);
            this.textcodigo.Name = "textcodigo";
            this.textcodigo.Size = new System.Drawing.Size(105, 20);
            this.textcodigo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(83, 31);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(182, 20);
            this.textnombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(283, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estado";
            // 
            // textestado
            // 
            this.textestado.Location = new System.Drawing.Point(350, 34);
            this.textestado.Name = "textestado";
            this.textestado.Size = new System.Drawing.Size(182, 20);
            this.textestado.TabIndex = 8;
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.Teal;
            this.buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonadd.Location = new System.Drawing.Point(15, 374);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(117, 29);
            this.buttonadd.TabIndex = 9;
            this.buttonadd.Text = "AGREGAR";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonalter
            // 
            this.buttonalter.BackColor = System.Drawing.Color.Teal;
            this.buttonalter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonalter.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonalter.Location = new System.Drawing.Point(227, 374);
            this.buttonalter.Name = "buttonalter";
            this.buttonalter.Size = new System.Drawing.Size(117, 29);
            this.buttonalter.TabIndex = 10;
            this.buttonalter.Text = "MODIFICAR";
            this.buttonalter.UseVisualStyleBackColor = false;
            this.buttonalter.Click += new System.EventHandler(this.buttonalter_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.Teal;
            this.buttondelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttondelete.Location = new System.Drawing.Point(178, 75);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(117, 29);
            this.buttondelete.TabIndex = 11;
            this.buttondelete.Text = "ELIMINAR";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(579, 413);
            this.Controls.Add(this.buttondelete);
            this.Controls.Add(this.buttonalter);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textestado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textestado;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonalter;
        private System.Windows.Forms.Button buttondelete;
    }
}