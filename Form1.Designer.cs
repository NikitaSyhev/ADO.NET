namespace Lesson2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connect = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tbBD = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.buttonFill = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn3 = new System.Windows.Forms.Button();
            this.tb_TT = new System.Windows.Forms.TextBox();
            this.checkBoxBD = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.createNewTable = new System.Windows.Forms.Button();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSelectTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(658, 74);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(104, 43);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(26, 74);
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(189, 38);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.Text = "1";
            // 
            // tbBD
            // 
            this.tbBD.Location = new System.Drawing.Point(26, 141);
            this.tbBD.Multiline = true;
            this.tbBD.Name = "tbBD";
            this.tbBD.Size = new System.Drawing.Size(433, 120);
            this.tbBD.TabIndex = 3;
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(658, 141);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(104, 43);
            this.buttonFill.TabIndex = 4;
            this.buttonFill.Text = "Fill BD";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(255, 176);
            this.dataGridView1.TabIndex = 5;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(658, 294);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(104, 43);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "Show BD";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // tb_TT
            // 
            this.tb_TT.Location = new System.Drawing.Point(270, 74);
            this.tb_TT.Multiline = true;
            this.tb_TT.Name = "tb_TT";
            this.tb_TT.Size = new System.Drawing.Size(189, 38);
            this.tb_TT.TabIndex = 7;
            // 
            // checkBoxBD
            // 
            this.checkBoxBD.AutoSize = true;
            this.checkBoxBD.Location = new System.Drawing.Point(505, 88);
            this.checkBoxBD.Name = "checkBoxBD";
            this.checkBoxBD.Size = new System.Drawing.Size(73, 17);
            this.checkBoxBD.TabIndex = 8;
            this.checkBoxBD.Text = "DataBase";
            this.checkBoxBD.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(658, 383);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 43);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update BD";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // createNewTable
            // 
            this.createNewTable.Location = new System.Drawing.Point(658, 220);
            this.createNewTable.Name = "createNewTable";
            this.createNewTable.Size = new System.Drawing.Size(104, 41);
            this.createNewTable.TabIndex = 10;
            this.createNewTable.Text = "createNewTable";
            this.createNewTable.UseVisualStyleBackColor = true;
            this.createNewTable.Click += new System.EventHandler(this.createNewTable_Click);
            // 
            // tbSQL
            // 
            this.tbSQL.Location = new System.Drawing.Point(373, 294);
            this.tbSQL.Multiline = true;
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.Size = new System.Drawing.Size(189, 64);
            this.tbSQL.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(373, 502);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // btnSelectTable
            // 
            this.btnSelectTable.Location = new System.Drawing.Point(578, 490);
            this.btnSelectTable.Name = "btnSelectTable";
            this.btnSelectTable.Size = new System.Drawing.Size(104, 43);
            this.btnSelectTable.TabIndex = 13;
            this.btnSelectTable.Text = "Select Table";
            this.btnSelectTable.UseVisualStyleBackColor = true;
            this.btnSelectTable.Click += new System.EventHandler(this.btnSelectTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.btnSelectTable);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbSQL);
            this.Controls.Add(this.createNewTable);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.checkBoxBD);
            this.Controls.Add(this.tb_TT);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.tbBD);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tbBD;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox tb_TT;
        private System.Windows.Forms.CheckBox checkBoxBD;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button createNewTable;
        private System.Windows.Forms.TextBox tbSQL;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSelectTable;
    }
}

