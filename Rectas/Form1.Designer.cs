namespace Rectas
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
            this.lienzo = new System.Windows.Forms.PictureBox();
            this.zoomBtnIn = new System.Windows.Forms.Button();
            this.zoomBtnOut = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txtBoxX1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxY1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxX2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxY2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataDatos = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPendiente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.xEnter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lienzo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lienzo
            // 
            this.lienzo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lienzo.Location = new System.Drawing.Point(0, 0);
            this.lienzo.Name = "lienzo";
            this.lienzo.Size = new System.Drawing.Size(700, 742);
            this.lienzo.TabIndex = 2;
            this.lienzo.TabStop = false;
            this.lienzo.SizeChanged += new System.EventHandler(this.lienzo_SizeChanged);
            this.lienzo.Click += new System.EventHandler(this.lienzo_Click_2);
            // 
            // zoomBtnIn
            // 
            this.zoomBtnIn.Location = new System.Drawing.Point(729, 12);
            this.zoomBtnIn.Name = "zoomBtnIn";
            this.zoomBtnIn.Size = new System.Drawing.Size(99, 54);
            this.zoomBtnIn.TabIndex = 3;
            this.zoomBtnIn.Text = "Zoom +";
            this.zoomBtnIn.UseVisualStyleBackColor = true;
            this.zoomBtnIn.Click += new System.EventHandler(this.zoomBtnIn_Click);
            // 
            // zoomBtnOut
            // 
            this.zoomBtnOut.Location = new System.Drawing.Point(853, 12);
            this.zoomBtnOut.Name = "zoomBtnOut";
            this.zoomBtnOut.Size = new System.Drawing.Size(99, 54);
            this.zoomBtnOut.TabIndex = 4;
            this.zoomBtnOut.Text = "Zoom -";
            this.zoomBtnOut.UseVisualStyleBackColor = true;
            this.zoomBtnOut.Click += new System.EventHandler(this.zoomBtnOut_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 20);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Basico";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(57, 20);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "DDA";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(97, 20);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Text = "Bresenham";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // txtBoxX1
            // 
            this.txtBoxX1.Location = new System.Drawing.Point(40, 3);
            this.txtBoxX1.Name = "txtBoxX1";
            this.txtBoxX1.Size = new System.Drawing.Size(47, 22);
            this.txtBoxX1.TabIndex = 8;
            this.txtBoxX1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "X1";
            // 
            // txtBoxY1
            // 
            this.txtBoxY1.Location = new System.Drawing.Point(146, 3);
            this.txtBoxY1.Name = "txtBoxY1";
            this.txtBoxY1.Size = new System.Drawing.Size(48, 22);
            this.txtBoxY1.TabIndex = 10;
            this.txtBoxY1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "X2";
            // 
            // txtBoxX2
            // 
            this.txtBoxX2.Location = new System.Drawing.Point(40, 53);
            this.txtBoxX2.Name = "txtBoxX2";
            this.txtBoxX2.Size = new System.Drawing.Size(47, 22);
            this.txtBoxX2.TabIndex = 12;
            this.txtBoxX2.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Y2";
            // 
            // txtBoxY2
            // 
            this.txtBoxY2.Location = new System.Drawing.Point(146, 53);
            this.txtBoxY2.Name = "txtBoxY2";
            this.txtBoxY2.Size = new System.Drawing.Size(48, 22);
            this.txtBoxY2.TabIndex = 14;
            this.txtBoxY2.Text = "-5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(743, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algoritmo";
            // 
            // dataDatos
            // 
            this.dataDatos.AutoGenerateColumns = false;
            this.dataDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.xEnter});
            this.dataDatos.DataSource = this.puntoBindingSource;
            this.dataDatos.Location = new System.Drawing.Point(719, 477);
            this.dataDatos.Name = "dataDatos";
            this.dataDatos.RowHeadersWidth = 51;
            this.dataDatos.RowTemplate.Height = 24;
            this.dataDatos.Size = new System.Drawing.Size(432, 265);
            this.dataDatos.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(766, 294);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(152, 48);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.88889F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxX1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxX2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxY2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxY1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(743, 188);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.labelPendiente);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.labelB);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(752, 360);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 100);
            this.flowLayoutPanel1.TabIndex = 20;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pendiente";
            // 
            // labelPendiente
            // 
            this.labelPendiente.AutoSize = true;
            this.labelPendiente.Location = new System.Drawing.Point(77, 0);
            this.labelPendiente.Name = "labelPendiente";
            this.labelPendiente.Size = new System.Drawing.Size(14, 16);
            this.labelPendiente.TabIndex = 1;
            this.labelPendiente.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 2;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(103, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(0, 16);
            this.labelB.TabIndex = 3;
            // 
            // xEnter
            // 
            this.xEnter.DataPropertyName = "xEnter";
            this.xEnter.HeaderText = "xEnter";
            this.xEnter.MinimumWidth = 6;
            this.xEnter.Name = "xEnter";
            this.xEnter.Width = 125;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.Width = 125;
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            this.yDataGridViewTextBoxColumn.Width = 125;
            // 
            // puntoBindingSource
            // 
            this.puntoBindingSource.DataSource = typeof(Rectas.Punto);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 754);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dataDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zoomBtnOut);
            this.Controls.Add(this.zoomBtnIn);
            this.Controls.Add(this.lienzo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lienzo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDatos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox lienzo;
        private System.Windows.Forms.Button zoomBtnIn;
        private System.Windows.Forms.Button zoomBtnOut;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txtBoxX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxY1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxX2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxY2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataDatos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource puntoBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPendiente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEnter;
    }
}

