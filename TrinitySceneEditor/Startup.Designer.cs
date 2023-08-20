namespace TrinitySceneView
{
    partial class Startup
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
            label1 = new Label();
            Label_File_Path = new Label();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label_GFPAKHashCache_status = new Label();
            button_regenerate_hashcache = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button_select_path = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label_oodle_dll_status = new Label();
            button_load = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 0, 0);
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Mode Select:";
            // 
            // Label_File_Path
            // 
            Label_File_Path.AutoSize = true;
            Label_File_Path.Location = new Point(13, 39);
            Label_File_Path.Name = "Label_File_Path";
            Label_File_Path.Padding = new Padding(0, 10, 0, 0);
            Label_File_Path.Size = new Size(55, 25);
            Label_File_Path.TabIndex = 2;
            Label_File_Path.Text = "File Path:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(Label_File_Path, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label_oodle_dll_status, 1, 3);
            tableLayoutPanel1.Controls.Add(button_load, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(509, 225);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(label_GFPAKHashCache_status, 0, 0);
            tableLayoutPanel3.Controls.Add(button_regenerate_hashcache, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(144, 77);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(352, 28);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // label_GFPAKHashCache_status
            // 
            label_GFPAKHashCache_status.AutoSize = true;
            label_GFPAKHashCache_status.Location = new Point(3, 0);
            label_GFPAKHashCache_status.Name = "label_GFPAKHashCache_status";
            label_GFPAKHashCache_status.Padding = new Padding(0, 5, 0, 0);
            label_GFPAKHashCache_status.Size = new Size(38, 20);
            label_GFPAKHashCache_status.TabIndex = 1;
            label_GFPAKHashCache_status.Text = "label4";
            // 
            // button_regenerate_hashcache
            // 
            button_regenerate_hashcache.Dock = DockStyle.Fill;
            button_regenerate_hashcache.Location = new Point(47, 3);
            button_regenerate_hashcache.Name = "button_regenerate_hashcache";
            button_regenerate_hashcache.Size = new Size(302, 23);
            button_regenerate_hashcache.TabIndex = 2;
            button_regenerate_hashcache.Text = "Regenerate from PokeDocs Github";
            button_regenerate_hashcache.TextAlign = ContentAlignment.MiddleLeft;
            button_regenerate_hashcache.UseVisualStyleBackColor = true;
            button_regenerate_hashcache.Click += Button_regenerate_hashcache_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button_select_path, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(144, 42);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(352, 29);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // button_select_path
            // 
            button_select_path.Location = new Point(3, 3);
            button_select_path.Name = "button_select_path";
            button_select_path.Size = new Size(23, 23);
            button_select_path.TabIndex = 4;
            button_select_path.Text = "📂";
            button_select_path.UseVisualStyleBackColor = true;
            button_select_path.Click += Button_select_path_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(32, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 23);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Mode";
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Single File", "Folder", "RomFS" });
            comboBox1.Location = new Point(144, 13);
            comboBox1.MaxDropDownItems = 3;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(352, 23);
            comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 74);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 10, 0, 0);
            label2.Size = new Size(125, 25);
            label2.TabIndex = 7;
            label2.Text = "GFPAKHashCache.bin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 108);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 5, 0, 0);
            label3.Size = new Size(116, 20);
            label3.TabIndex = 8;
            label3.Text = "oo2core_6_win64.dll:";
            // 
            // label_oodle_dll_status
            // 
            label_oodle_dll_status.AutoSize = true;
            label_oodle_dll_status.Location = new Point(144, 108);
            label_oodle_dll_status.Name = "label_oodle_dll_status";
            label_oodle_dll_status.Padding = new Padding(0, 5, 0, 5);
            label_oodle_dll_status.Size = new Size(38, 25);
            label_oodle_dll_status.TabIndex = 9;
            label_oodle_dll_status.Text = "label4";
            // 
            // button_load
            // 
            button_load.Dock = DockStyle.Fill;
            button_load.Location = new Point(144, 136);
            button_load.Name = "button_load";
            button_load.Size = new Size(352, 76);
            button_load.TabIndex = 10;
            button_load.Text = "button1";
            button_load.UseVisualStyleBackColor = true;
            button_load.Click += Button_load_Click;
            // 
            // Startup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 225);
            Controls.Add(tableLayoutPanel1);
            Name = "Startup";
            Text = "Startup";
            FormClosing += Startup_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label Label_File_Path;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button_select_path;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label_GFPAKHashCache_status;
        private Button button_regenerate_hashcache;
        private Label label3;
        private Label label_oodle_dll_status;
        private Button button_load;
    }
}