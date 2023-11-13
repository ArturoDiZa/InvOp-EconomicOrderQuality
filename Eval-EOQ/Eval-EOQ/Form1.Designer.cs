namespace Eval_EOQ
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudH = new System.Windows.Forms.NumericUpDown();
            this.btnClean = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudD = new System.Windows.Forms.NumericUpDown();
            this.nudK = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudL = new System.Windows.Forms.NumericUpDown();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcularQ = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudQ = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCalcularTodo = new System.Windows.Forms.Button();
            this.btnCalcularT = new System.Windows.Forms.Button();
            this.btnCalcularTC = new System.Windows.Forms.Button();
            this.btnCalcularR = new System.Windows.Forms.Button();
            this.btnCalcularD = new System.Windows.Forms.Button();
            this.btnCalcularN = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nudTC = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.nudR = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudDd = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nudT = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demanda anual (Unidades) (D)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nudH);
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudDias);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudD);
            this.groupBox1.Controls.Add(this.nudK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudL);
            this.groupBox1.Controls.Add(this.nudC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 428);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entradas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Costo de mantener inventario (h)";
            // 
            // nudH
            // 
            this.nudH.DecimalPlaces = 2;
            this.nudH.Location = new System.Drawing.Point(6, 265);
            this.nudH.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudH.Name = "nudH";
            this.nudH.Size = new System.Drawing.Size(120, 20);
            this.nudH.TabIndex = 17;
            this.nudH.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(66, 397);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 15;
            this.btnClean.Text = "Limpiar Datos";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pararmetros necesarios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Parametros opcionales";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(6, 345);
            this.nudDias.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(120, 20);
            this.nudDias.TabIndex = 12;
            this.nudDias.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Días hábiles por año (360 por omisión)";
            // 
            // nudD
            // 
            this.nudD.Location = new System.Drawing.Point(6, 61);
            this.nudD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudD.Name = "nudD";
            this.nudD.Size = new System.Drawing.Size(120, 20);
            this.nudD.TabIndex = 2;
            this.nudD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudK
            // 
            this.nudK.DecimalPlaces = 2;
            this.nudK.Location = new System.Drawing.Point(6, 160);
            this.nudK.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudK.Name = "nudK";
            this.nudK.Size = new System.Drawing.Size(120, 20);
            this.nudK.TabIndex = 6;
            this.nudK.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Costo por preparación (K)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Costo por unidad (C)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tiempo de entrega (días) (L)";
            // 
            // nudL
            // 
            this.nudL.DecimalPlaces = 1;
            this.nudL.Location = new System.Drawing.Point(6, 211);
            this.nudL.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudL.Name = "nudL";
            this.nudL.Size = new System.Drawing.Size(120, 20);
            this.nudL.TabIndex = 8;
            this.nudL.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // nudC
            // 
            this.nudC.DecimalPlaces = 2;
            this.nudC.Location = new System.Drawing.Point(6, 110);
            this.nudC.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(120, 20);
            this.nudC.TabIndex = 4;
            this.nudC.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnCalcularQ);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudQ);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.btnCalcularTodo);
            this.groupBox2.Controls.Add(this.btnCalcularT);
            this.groupBox2.Controls.Add(this.btnCalcularTC);
            this.groupBox2.Controls.Add(this.btnCalcularR);
            this.groupBox2.Controls.Add(this.btnCalcularD);
            this.groupBox2.Controls.Add(this.btnCalcularN);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.nudTC);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.nudR);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.nudDd);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.nudT);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nudN);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(241, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 428);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculados";
            // 
            // btnCalcularQ
            // 
            this.btnCalcularQ.Location = new System.Drawing.Point(124, 58);
            this.btnCalcularQ.Name = "btnCalcularQ";
            this.btnCalcularQ.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularQ.TabIndex = 41;
            this.btnCalcularQ.Text = "Calcular";
            this.btnCalcularQ.UseVisualStyleBackColor = true;
            this.btnCalcularQ.Click += new System.EventHandler(this.btnCalcularQ_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 39);
            this.label5.TabIndex = 40;
            this.label5.Text = "Requiere:\r\n*Demanda anual\r\n*Volumen de orden";
            // 
            // nudQ
            // 
            this.nudQ.Location = new System.Drawing.Point(6, 61);
            this.nudQ.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudQ.Name = "nudQ";
            this.nudQ.ReadOnly = true;
            this.nudQ.Size = new System.Drawing.Size(112, 20);
            this.nudQ.TabIndex = 39;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(218, 45);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 13);
            this.label21.TabIndex = 38;
            this.label21.Text = "Ordenes por año (N)";
            // 
            // btnCalcularTodo
            // 
            this.btnCalcularTodo.Location = new System.Drawing.Point(550, 382);
            this.btnCalcularTodo.Name = "btnCalcularTodo";
            this.btnCalcularTodo.Size = new System.Drawing.Size(118, 38);
            this.btnCalcularTodo.TabIndex = 37;
            this.btnCalcularTodo.Text = "Calcular todo";
            this.btnCalcularTodo.UseVisualStyleBackColor = true;
            this.btnCalcularTodo.Click += new System.EventHandler(this.btnCalcularTodo_Click);
            // 
            // btnCalcularT
            // 
            this.btnCalcularT.Location = new System.Drawing.Point(548, 58);
            this.btnCalcularT.Name = "btnCalcularT";
            this.btnCalcularT.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularT.TabIndex = 35;
            this.btnCalcularT.Text = "Calcular";
            this.btnCalcularT.UseVisualStyleBackColor = true;
            this.btnCalcularT.Click += new System.EventHandler(this.btnCalcularT_Click);
            // 
            // btnCalcularTC
            // 
            this.btnCalcularTC.Location = new System.Drawing.Point(548, 231);
            this.btnCalcularTC.Name = "btnCalcularTC";
            this.btnCalcularTC.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularTC.TabIndex = 34;
            this.btnCalcularTC.Text = "Calcular";
            this.btnCalcularTC.UseVisualStyleBackColor = true;
            this.btnCalcularTC.Click += new System.EventHandler(this.btnCalcularTC_Click);
            // 
            // btnCalcularR
            // 
            this.btnCalcularR.Location = new System.Drawing.Point(336, 231);
            this.btnCalcularR.Name = "btnCalcularR";
            this.btnCalcularR.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularR.TabIndex = 33;
            this.btnCalcularR.Text = "Calcular";
            this.btnCalcularR.UseVisualStyleBackColor = true;
            this.btnCalcularR.Click += new System.EventHandler(this.btnCalcularR_Click);
            // 
            // btnCalcularD
            // 
            this.btnCalcularD.Location = new System.Drawing.Point(124, 231);
            this.btnCalcularD.Name = "btnCalcularD";
            this.btnCalcularD.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularD.TabIndex = 32;
            this.btnCalcularD.Text = "Calcular";
            this.btnCalcularD.UseVisualStyleBackColor = true;
            this.btnCalcularD.Click += new System.EventHandler(this.btnCalcularD_Click);
            // 
            // btnCalcularN
            // 
            this.btnCalcularN.Location = new System.Drawing.Point(336, 58);
            this.btnCalcularN.Name = "btnCalcularN";
            this.btnCalcularN.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularN.TabIndex = 31;
            this.btnCalcularN.Text = "Calcular";
            this.btnCalcularN.UseVisualStyleBackColor = true;
            this.btnCalcularN.Click += new System.EventHandler(this.btnCalcularN_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(435, 257);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 78);
            this.label20.TabIndex = 30;
            this.label20.Text = "Requiere:\r\n*Demanda anual\r\n*Costo por unidad\r\n*Costo por preparacion\r\n*Volumen de" +
    " orden\r\n*Costos de mantener inventario";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(223, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 39);
            this.label19.TabIndex = 29;
            this.label19.Text = "Requiere:\n*Demanda diaria\n*Tiempo de entrega";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 257);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 39);
            this.label18.TabIndex = 28;
            this.label18.Text = "Requiere:\r\n*Demanda anual\r\n*Dias hábiles por año";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(435, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 39);
            this.label17.TabIndex = 27;
            this.label17.Text = "Requiere:\r\n*Ordenes por año\r\n*Dias hábiles por año";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 52);
            this.label15.TabIndex = 25;
            this.label15.Text = "Requiere:\r\n*Demanda anual\r\n*Costos de preparación\r\n*Costos de mantener inventario" +
    "";
            // 
            // nudTC
            // 
            this.nudTC.DecimalPlaces = 2;
            this.nudTC.Location = new System.Drawing.Point(430, 234);
            this.nudTC.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudTC.Name = "nudTC";
            this.nudTC.ReadOnly = true;
            this.nudTC.Size = new System.Drawing.Size(112, 20);
            this.nudTC.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(430, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Costo total (TC)";
            // 
            // nudR
            // 
            this.nudR.Location = new System.Drawing.Point(218, 234);
            this.nudR.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudR.Name = "nudR";
            this.nudR.ReadOnly = true;
            this.nudR.Size = new System.Drawing.Size(112, 20);
            this.nudR.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(218, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Punto de reorden Unidades (R)";
            // 
            // nudDd
            // 
            this.nudDd.Location = new System.Drawing.Point(6, 234);
            this.nudDd.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudDd.Name = "nudDd";
            this.nudDd.ReadOnly = true;
            this.nudDd.Size = new System.Drawing.Size(112, 20);
            this.nudDd.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Demanda diaria (Unidades) (d)";
            // 
            // nudT
            // 
            this.nudT.DecimalPlaces = 1;
            this.nudT.Location = new System.Drawing.Point(430, 61);
            this.nudT.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudT.Name = "nudT";
            this.nudT.ReadOnly = true;
            this.nudT.Size = new System.Drawing.Size(112, 20);
            this.nudT.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(430, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tiempo entre ordenes (días) (T)";
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(218, 61);
            this.nudN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.ReadOnly = true;
            this.nudN.Size = new System.Drawing.Size(112, 20);
            this.nudN.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Volumen de orden (Unidades) (Q)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudTC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudDd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCalcularT;
        private System.Windows.Forms.Button btnCalcularTC;
        private System.Windows.Forms.Button btnCalcularR;
        private System.Windows.Forms.Button btnCalcularD;
        private System.Windows.Forms.Button btnCalcularN;
        private System.Windows.Forms.Button btnCalcularTodo;
        private System.Windows.Forms.Button btnCalcularQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudQ;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudL;
    }
}

