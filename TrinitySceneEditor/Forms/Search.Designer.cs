namespace TrinitySceneEditor.Forms
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripComboBox_SearchType = new ToolStripComboBox();
            toolStripLabel2 = new ToolStripLabel();
            toolStripTextBox_SearchValue = new ToolStripTextBox();
            toolStripButton_Search = new ToolStripButton();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            SceneFile = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripComboBox_SearchType, toolStripLabel2, toolStripTextBox_SearchValue, toolStripButton_Search });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(58, 22);
            toolStripLabel1.Text = "DataType:";
            // 
            // toolStripComboBox_SearchType
            // 
            toolStripComboBox_SearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox_SearchType.Items.AddRange(new object[] { "string", "int", "float" });
            toolStripComboBox_SearchType.Name = "toolStripComboBox_SearchType";
            toolStripComboBox_SearchType.Size = new Size(121, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(76, 22);
            toolStripLabel2.Text = "Search Value:";
            // 
            // toolStripTextBox_SearchValue
            // 
            toolStripTextBox_SearchValue.Name = "toolStripTextBox_SearchValue";
            toolStripTextBox_SearchValue.Size = new Size(100, 25);
            // 
            // toolStripButton_Search
            // 
            toolStripButton_Search.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton_Search.Image = (Image)resources.GetObject("toolStripButton_Search.Image");
            toolStripButton_Search.ImageTransparentColor = Color.Magenta;
            toolStripButton_Search.Name = "toolStripButton_Search";
            toolStripButton_Search.Size = new Size(46, 22);
            toolStripButton_Search.Text = "Search";
            toolStripButton_Search.Click += toolStripButton_Search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Value, SceneFile });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 425);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Value
            // 
            Value.HeaderText = "Value";
            Value.Name = "Value";
            Value.ReadOnly = true;
            // 
            // SceneFile
            // 
            SceneFile.HeaderText = "SceneFile";
            SceneFile.Name = "SceneFile";
            SceneFile.ReadOnly = true;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Text = "Search";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox toolStripComboBox_SearchType;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox toolStripTextBox_SearchValue;
        private ToolStripButton toolStripButton_Search;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Value;
        private DataGridViewTextBoxColumn SceneFile;
    }
}