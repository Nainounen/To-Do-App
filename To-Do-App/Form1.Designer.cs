namespace To_Do_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            dgv = new DataGridView();
            titel = new DataGridViewTextBoxColumn();
            beschreibung = new DataGridViewTextBoxColumn();
            kategorie = new DataGridViewTextBoxColumn();
            datum = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripComboBox2 = new ToolStripComboBox();
            cmdedit = new Button();
            cmddelete = new Button();
            cmdsave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.Items.AddRange(new object[] { "School", "Work", "Home" });
            comboBox1.Location = new Point(1062, 530);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(412, 45);
            comboBox1.TabIndex = 13;
            comboBox1.TabStop = false;
            comboBox1.Text = "Kategorie Auswählen";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(646, 643);
            button1.Name = "button1";
            button1.Size = new Size(406, 95);
            button1.TabIndex = 2;
            button1.Text = "Hinzufügen";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 674);
            label1.MaximumSize = new Size(1000, 50);
            label1.Name = "label1";
            label1.Size = new Size(129, 50);
            label1.TabIndex = 3;
            label1.Text = "To-Do";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(218, 659);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(415, 65);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(13, 744);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(620, 95);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1157, 469);
            label2.MaximumSize = new Size(1000, 50);
            label2.Name = "label2";
            label2.Size = new Size(202, 50);
            label2.TabIndex = 6;
            label2.Text = "Kategorie:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(1062, 582);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(412, 43);
            dateTimePicker1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cyan;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1490, 41);
            label3.TabIndex = 11;
            label3.Text = "To-Do                                                                                                                                by Max and Nino               \r\n";
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { titel, beschreibung, kategorie, datum });
            dgv.Location = new Point(13, 74);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(1039, 551);
            dgv.TabIndex = 12;
            // 
            // titel
            // 
            titel.FillWeight = 85.56149F;
            titel.HeaderText = "Titel";
            titel.MinimumWidth = 6;
            titel.Name = "titel";
            // 
            // beschreibung
            // 
            beschreibung.FillWeight = 85.56149F;
            beschreibung.HeaderText = "Beschreibung";
            beschreibung.MinimumWidth = 6;
            beschreibung.Name = "beschreibung";
            // 
            // kategorie
            // 
            kategorie.FillWeight = 85.56149F;
            kategorie.HeaderText = "Kategorie";
            kategorie.MinimumWidth = 6;
            kategorie.Name = "kategorie";
            // 
            // datum
            // 
            datum.FillWeight = 85.56149F;
            datum.HeaderText = "Datum";
            datum.MinimumWidth = 6;
            datum.Name = "datum";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1, toolStripTextBox1, toolStripComboBox2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(182, 97);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 28);
            // 
            // cmdedit
            // 
            cmdedit.BackColor = Color.Blue;
            cmdedit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmdedit.Location = new Point(1062, 643);
            cmdedit.Name = "cmdedit";
            cmdedit.Size = new Size(406, 95);
            cmdedit.TabIndex = 16;
            cmdedit.Text = "Bearbeiten\r\n(keine Zeit mehr)";
            cmdedit.UseVisualStyleBackColor = false;
            // 
            // cmddelete
            // 
            cmddelete.BackColor = Color.Red;
            cmddelete.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmddelete.Location = new Point(646, 744);
            cmddelete.Name = "cmddelete";
            cmddelete.Size = new Size(406, 95);
            cmddelete.TabIndex = 17;
            cmddelete.Text = "Löschen";
            cmddelete.UseVisualStyleBackColor = false;
            cmddelete.Click += cmddelete_Click;
            // 
            // cmdsave
            // 
            cmdsave.BackColor = Color.Purple;
            cmdsave.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            cmdsave.Location = new Point(1062, 744);
            cmdsave.Name = "cmdsave";
            cmdsave.Size = new Size(406, 95);
            cmdsave.TabIndex = 18;
            cmdsave.Text = "Speichern";
            cmdsave.UseVisualStyleBackColor = false;
            cmdsave.Click += cmdsave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 856);
            Controls.Add(cmdsave);
            Controls.Add(cmddelete);
            Controls.Add(cmdedit);
            Controls.Add(comboBox1);
            Controls.Add(dgv);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DataGridView dgv;
        private ComboBox comboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripComboBox toolStripComboBox2;
        private Button cmdedit;
        private Button cmddelete;
        private Button cmdsave;
        private DataGridViewTextBoxColumn titel;
        private DataGridViewTextBoxColumn beschreibung;
        private DataGridViewTextBoxColumn kategorie;
        private DataGridViewTextBoxColumn datum;
    }
}