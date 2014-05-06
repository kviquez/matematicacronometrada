namespace practica2
{
    partial class Form1
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlusRightLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Suma = new System.Windows.Forms.NumericUpDown();
            this.diferencia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.minusrightlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minusleftlabel = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.timesrightlabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timesleftlabel = new System.Windows.Forms.Label();
            this.cociente = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.dividedrightlabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dividedleftlabel = new System.Windows.Forms.Label();
            this.StartButtom = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Suma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cociente)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(283, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo Restante";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(25, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 3;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlusRightLabel
            // 
            this.PlusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusRightLabel.Location = new System.Drawing.Point(171, 75);
            this.PlusRightLabel.Name = "PlusRightLabel";
            this.PlusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusRightLabel.TabIndex = 5;
            this.PlusRightLabel.Text = "?";
            this.PlusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Suma
            // 
            this.Suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.Location = new System.Drawing.Point(334, 84);
            this.Suma.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(100, 35);
            this.Suma.TabIndex = 2;
            this.Suma.Enter += new System.EventHandler(this.Suma_Enter);
            // 
            // diferencia
            // 
            this.diferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diferencia.Location = new System.Drawing.Point(334, 151);
            this.diferencia.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.diferencia.Name = "diferencia";
            this.diferencia.Size = new System.Drawing.Size(100, 35);
            this.diferencia.TabIndex = 3;
            this.diferencia.Enter += new System.EventHandler(this.Suma_Enter);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 11;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusrightlabel
            // 
            this.minusrightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusrightlabel.Location = new System.Drawing.Point(171, 136);
            this.minusrightlabel.Name = "minusrightlabel";
            this.minusrightlabel.Size = new System.Drawing.Size(60, 50);
            this.minusrightlabel.TabIndex = 10;
            this.minusrightlabel.Text = "?";
            this.minusrightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 9;
            this.label7.Text = "-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusleftlabel
            // 
            this.minusleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusleftlabel.Location = new System.Drawing.Point(25, 136);
            this.minusleftlabel.Name = "minusleftlabel";
            this.minusleftlabel.Size = new System.Drawing.Size(60, 50);
            this.minusleftlabel.TabIndex = 8;
            this.minusleftlabel.Text = "?";
            this.minusleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Producto
            // 
            this.Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.Location = new System.Drawing.Point(334, 219);
            this.Producto.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(100, 35);
            this.Producto.TabIndex = 4;
            this.Producto.Enter += new System.EventHandler(this.Suma_Enter);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(237, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 16;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesrightlabel
            // 
            this.timesrightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesrightlabel.Location = new System.Drawing.Point(171, 210);
            this.timesrightlabel.Name = "timesrightlabel";
            this.timesrightlabel.Size = new System.Drawing.Size(60, 50);
            this.timesrightlabel.TabIndex = 15;
            this.timesrightlabel.Text = "?";
            this.timesrightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 14;
            this.label11.Text = "*";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesleftlabel
            // 
            this.timesleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesleftlabel.Location = new System.Drawing.Point(25, 210);
            this.timesleftlabel.Name = "timesleftlabel";
            this.timesleftlabel.Size = new System.Drawing.Size(60, 50);
            this.timesleftlabel.TabIndex = 13;
            this.timesleftlabel.Text = "?";
            this.timesleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cociente
            // 
            this.cociente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cociente.Location = new System.Drawing.Point(334, 275);
            this.cociente.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.cociente.Name = "cociente";
            this.cociente.Size = new System.Drawing.Size(100, 35);
            this.cociente.TabIndex = 5;
            this.cociente.Enter += new System.EventHandler(this.Suma_Enter);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(237, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 21;
            this.label13.Text = "=";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedrightlabel
            // 
            this.dividedrightlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedrightlabel.Location = new System.Drawing.Point(171, 266);
            this.dividedrightlabel.Name = "dividedrightlabel";
            this.dividedrightlabel.Size = new System.Drawing.Size(60, 50);
            this.dividedrightlabel.TabIndex = 20;
            this.dividedrightlabel.Text = "?";
            this.dividedrightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(105, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 50);
            this.label15.TabIndex = 19;
            this.label15.Text = "/";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedleftlabel
            // 
            this.dividedleftlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedleftlabel.Location = new System.Drawing.Point(25, 266);
            this.dividedleftlabel.Name = "dividedleftlabel";
            this.dividedleftlabel.Size = new System.Drawing.Size(60, 50);
            this.dividedleftlabel.TabIndex = 18;
            this.dividedleftlabel.Text = "?";
            this.dividedleftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButtom
            // 
            this.StartButtom.AutoSize = true;
            this.StartButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButtom.Location = new System.Drawing.Point(141, 319);
            this.StartButtom.Name = "StartButtom";
            this.StartButtom.Size = new System.Drawing.Size(156, 34);
            this.StartButtom.TabIndex = 1;
            this.StartButtom.Text = "Iniciar la prueba";
            this.StartButtom.UseVisualStyleBackColor = true;
            this.StartButtom.Click += new System.EventHandler(this.StartButtom_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.StartButtom);
            this.Controls.Add(this.cociente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dividedrightlabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dividedleftlabel);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timesrightlabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.timesleftlabel);
            this.Controls.Add(this.diferencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minusrightlabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minusleftlabel);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PlusRightLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Prueba Matematica";
            ((System.ComponentModel.ISupportInitialize)(this.Suma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cociente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PlusRightLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Suma;
        private System.Windows.Forms.NumericUpDown diferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minusrightlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label minusleftlabel;
        private System.Windows.Forms.NumericUpDown Producto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label timesrightlabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label timesleftlabel;
        private System.Windows.Forms.NumericUpDown cociente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label dividedrightlabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label dividedleftlabel;
        private System.Windows.Forms.Button StartButtom;
        private System.Windows.Forms.Timer timer1;
    }
}

