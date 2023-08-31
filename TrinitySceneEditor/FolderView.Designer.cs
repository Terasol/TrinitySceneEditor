namespace TrinitySceneEditor
{
    partial class FolderView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            treeView1 = new TreeView();
            tableLayoutPanel2 = new TableLayoutPanel();
            Button_Open_File = new Button();
            Button_Revert_File_Changes = new Button();
            Button_Save_Changed_Files = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(treeView1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(700, 338);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.ItemHeight = 18;
            treeView1.Location = new Point(3, 2);
            treeView1.Margin = new Padding(3, 2, 3, 2);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(474, 334);
            treeView1.TabIndex = 0;
            treeView1.DoubleClick += OpenSelectedFile;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(Button_Open_File, 0, 1);
            tableLayoutPanel2.Controls.Add(Button_Revert_File_Changes, 0, 2);
            tableLayoutPanel2.Controls.Add(Button_Save_Changed_Files, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(483, 2);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333435F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Size = new Size(214, 334);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // Button_Open_File
            // 
            Button_Open_File.Location = new Point(3, 85);
            Button_Open_File.Margin = new Padding(3, 2, 3, 2);
            Button_Open_File.Name = "Button_Open_File";
            Button_Open_File.Size = new Size(82, 22);
            Button_Open_File.TabIndex = 0;
            Button_Open_File.Text = "Open";
            Button_Open_File.UseVisualStyleBackColor = true;
            Button_Open_File.Click += OpenSelectedFile;
            // 
            // Button_Revert_File_Changes
            // 
            Button_Revert_File_Changes.Location = new Point(3, 112);
            Button_Revert_File_Changes.Name = "Button_Revert_File_Changes";
            Button_Revert_File_Changes.Size = new Size(82, 23);
            Button_Revert_File_Changes.TabIndex = 1;
            Button_Revert_File_Changes.Text = "Revert";
            Button_Revert_File_Changes.UseVisualStyleBackColor = true;
            Button_Revert_File_Changes.Click += Button_Revert_File_Changes_Click;
            // 
            // Button_Save_Changed_Files
            // 
            Button_Save_Changed_Files.Location = new Point(3, 141);
            Button_Save_Changed_Files.Name = "Button_Save_Changed_Files";
            Button_Save_Changed_Files.Size = new Size(125, 23);
            Button_Save_Changed_Files.TabIndex = 2;
            Button_Save_Changed_Files.Text = "Saved Changed Files";
            Button_Save_Changed_Files.UseVisualStyleBackColor = true;
            // 
            // FolderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FolderView";
            Text = "FolderView";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TreeView treeView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Button_Open_File;
        private Button Button_Revert_File_Changes;
        private Button Button_Save_Changed_Files;
    }
}