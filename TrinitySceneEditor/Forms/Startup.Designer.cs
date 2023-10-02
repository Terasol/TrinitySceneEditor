namespace TrinitySceneEditor.Forms
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
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 7, 0, 0);
            label1.Size = new Size(95, 27);
            label1.TabIndex = 1;
            label1.Text = "Mode Select:";
            // 
            // Label_File_Path
            // 
            Label_File_Path.AutoSize = true;
            Label_File_Path.Location = new Point(14, 49);
            Label_File_Path.Name = "Label_File_Path";
            Label_File_Path.Padding = new Padding(0, 13, 0, 0);
            Label_File_Path.Size = new Size(67, 33);
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
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(11, 13, 11, 13);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(582, 300);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel3.Controls.Add(label_GFPAKHashCache_status, 0, 0);
            tableLayoutPanel3.Controls.Add(button_regenerate_hashcache, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(172, 100);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(396, 37);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // label_GFPAKHashCache_status
            // 
            label_GFPAKHashCache_status.AutoSize = true;
            label_GFPAKHashCache_status.Location = new Point(3, 0);
            label_GFPAKHashCache_status.Name = "label_GFPAKHashCache_status";
            label_GFPAKHashCache_status.Padding = new Padding(0, 7, 0, 0);
            label_GFPAKHashCache_status.Size = new Size(50, 27);
            label_GFPAKHashCache_status.TabIndex = 1;
            label_GFPAKHashCache_status.Text = "label4";
            // 
            // button_regenerate_hashcache
            // 
            button_regenerate_hashcache.Dock = DockStyle.Fill;
            button_regenerate_hashcache.Location = new Point(59, 4);
            button_regenerate_hashcache.Margin = new Padding(3, 4, 3, 4);
            button_regenerate_hashcache.Name = "button_regenerate_hashcache";
            button_regenerate_hashcache.Size = new Size(334, 31);
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
            tableLayoutPanel2.Location = new Point(172, 53);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(396, 39);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // button_select_path
            // 
            button_select_path.Location = new Point(3, 4);
            button_select_path.Margin = new Padding(3, 4, 3, 4);
            button_select_path.Name = "button_select_path";
            button_select_path.Size = new Size(26, 31);
            button_select_path.TabIndex = 4;
            button_select_path.Text = "📂";
            button_select_path.UseVisualStyleBackColor = true;
            button_select_path.Click += Button_select_path_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(35, 4);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 27);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Mode";
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Single File", "Folder", "RomFS" });
            comboBox1.Location = new Point(172, 17);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.MaxDropDownItems = 3;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(396, 28);
            comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 96);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 13, 0, 0);
            label2.Size = new Size(152, 33);
            label2.TabIndex = 7;
            label2.Text = "GFPAKHashCache.bin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 141);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 7, 0, 0);
            label3.Size = new Size(146, 27);
            label3.TabIndex = 8;
            label3.Text = "oo2core_6_win64.dll:";
            // 
            // label_oodle_dll_status
            // 
            label_oodle_dll_status.AutoSize = true;
            label_oodle_dll_status.Location = new Point(172, 141);
            label_oodle_dll_status.Name = "label_oodle_dll_status";
            label_oodle_dll_status.Padding = new Padding(0, 7, 0, 7);
            label_oodle_dll_status.Size = new Size(50, 34);
            label_oodle_dll_status.TabIndex = 9;
            label_oodle_dll_status.Text = "label4";
            // 
            // button_load
            // 
            button_load.Dock = DockStyle.Fill;
            button_load.Location = new Point(172, 179);
            button_load.Margin = new Padding(3, 4, 3, 4);
            button_load.Name = "button_load";
            button_load.Size = new Size(396, 104);
            button_load.TabIndex = 10;
            button_load.Text = "button1";
            button_load.UseVisualStyleBackColor = true;
            button_load.Click += Button_load_Click;
            // 
            // Startup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 300);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
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