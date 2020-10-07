namespace FormHZZ
{
    partial class HZZ_Poslovi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HZZ_Poslovi));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stupacPosaoNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stupacPosaoOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stupacPosaoUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stupacPosaoDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stupacPosaoGrad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bazaPosaoNaziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bazaPosaoOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bazaPosaoUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bazaPosaoDatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bazaPosaoGrad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(221, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Odabrana Kategorija";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stupacPosaoNaziv,
            this.stupacPosaoOpis,
            this.stupacPosaoUrl,
            this.stupacPosaoDatum,
            this.stupacPosaoGrad});
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stupacPosaoNaziv
            // 
            this.stupacPosaoNaziv.DataPropertyName = "sJobNaziv";
            this.stupacPosaoNaziv.HeaderText = "Naziv Posla";
            this.stupacPosaoNaziv.Name = "stupacPosaoNaziv";
            // 
            // stupacPosaoOpis
            // 
            this.stupacPosaoOpis.DataPropertyName = "sJobOpis";
            this.stupacPosaoOpis.HeaderText = "Opis Posla";
            this.stupacPosaoOpis.Name = "stupacPosaoOpis";
            // 
            // stupacPosaoUrl
            // 
            this.stupacPosaoUrl.DataPropertyName = "sJobUrl";
            this.stupacPosaoUrl.HeaderText = "Link";
            this.stupacPosaoUrl.Name = "stupacPosaoUrl";
            // 
            // stupacPosaoDatum
            // 
            this.stupacPosaoDatum.DataPropertyName = "sJobPubDate";
            this.stupacPosaoDatum.HeaderText = "Datum Objave";
            this.stupacPosaoDatum.Name = "stupacPosaoDatum";
            // 
            // stupacPosaoGrad
            // 
            this.stupacPosaoGrad.DataPropertyName = "sJobGrad";
            this.stupacPosaoGrad.HeaderText = "Grad";
            this.stupacPosaoGrad.Name = "stupacPosaoGrad";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database - Zadnje gledano";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bazaPosaoNaziv,
            this.bazaPosaoOpis,
            this.bazaPosaoUrl,
            this.bazaPosaoDatum,
            this.bazaPosaoGrad});
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(625, 388);
            this.dataGridView2.TabIndex = 0;
            // 
            // bazaPosaoNaziv
            // 
            this.bazaPosaoNaziv.DataPropertyName = "sJobNaziv";
            this.bazaPosaoNaziv.HeaderText = "Naziv Posla";
            this.bazaPosaoNaziv.Name = "bazaPosaoNaziv";
            // 
            // bazaPosaoOpis
            // 
            this.bazaPosaoOpis.DataPropertyName = "sJobOpis";
            this.bazaPosaoOpis.HeaderText = "Opis Posla";
            this.bazaPosaoOpis.Name = "bazaPosaoOpis";
            // 
            // bazaPosaoUrl
            // 
            this.bazaPosaoUrl.DataPropertyName = "sJobUrl";
            this.bazaPosaoUrl.HeaderText = "Link";
            this.bazaPosaoUrl.Name = "bazaPosaoUrl";
            // 
            // bazaPosaoDatum
            // 
            this.bazaPosaoDatum.DataPropertyName = "sJobPubDate";
            this.bazaPosaoDatum.HeaderText = "Datum Objave";
            this.bazaPosaoDatum.Name = "bazaPosaoDatum";
            // 
            // bazaPosaoGrad
            // 
            this.bazaPosaoGrad.DataPropertyName = "sJobGrad";
            this.bazaPosaoGrad.HeaderText = "Grad";
            this.bazaPosaoGrad.Name = "bazaPosaoGrad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "POSLOVI";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(99, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "OSVJEŽI";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 373);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(20, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "TRAŽI PO NAZIVU POSLA";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(20, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "PO NAZIVU A-Ž";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(20, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "PO NAZIVU Ž-A";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(17, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "SORTIRAJ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 298);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(20, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 43);
            this.button5.TabIndex = 8;
            this.button5.Text = "TRAŽI PO GRADU";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(20, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 43);
            this.button6.TabIndex = 9;
            this.button6.Text = "PO DATUMU";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // HZZ_Poslovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "HZZ_Poslovi";
            this.Size = new System.Drawing.Size(890, 460);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stupacPosaoNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn stupacPosaoOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn stupacPosaoUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn stupacPosaoDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn stupacPosaoGrad;
        private System.Windows.Forms.DataGridViewTextBoxColumn bazaPosaoNaziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn bazaPosaoOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn bazaPosaoUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn bazaPosaoDatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn bazaPosaoGrad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}
