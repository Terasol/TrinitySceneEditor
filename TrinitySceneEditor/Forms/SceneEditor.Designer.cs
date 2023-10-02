namespace TrinitySceneEditor.Forms
{
    partial class SceneEditor
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openTRSOT = new ToolStripMenuItem();
            saveTRSOT = new ToolStripMenuItem();
            closeTRSOT = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            sceneContext = new ContextMenuStrip(components);
            expandToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            sceneView = new TreeView();
            propertyGrid1 = new PropertyGrid();
            menuStrip1.SuspendLayout();
            sceneContext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(542, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openTRSOT, saveTRSOT, closeTRSOT });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openTRSOT
            // 
            openTRSOT.Name = "openTRSOT";
            openTRSOT.Size = new Size(175, 22);
            openTRSOT.Text = "Open Scene Object";
            openTRSOT.Visible = false;
            openTRSOT.Click += openTRSOT_Click;
            // 
            // saveTRSOT
            // 
            saveTRSOT.Name = "saveTRSOT";
            saveTRSOT.Size = new Size(175, 22);
            saveTRSOT.Text = "Save Scene Object";
            saveTRSOT.Visible = false;
            saveTRSOT.Click += saveTRSOT_Click;
            // 
            // closeTRSOT
            // 
            closeTRSOT.Name = "closeTRSOT";
            closeTRSOT.Size = new Size(175, 22);
            closeTRSOT.Text = "Close Scene Object";
            closeTRSOT.Click += closeTRSOT_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(54, 20);
            toolStripMenuItem1.Text = "Search";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "open Search";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // sceneContext
            // 
            sceneContext.Items.AddRange(new ToolStripItem[] { expandToolStripMenuItem });
            sceneContext.Name = "sceneContext";
            sceneContext.Size = new Size(114, 26);
            // 
            // expandToolStripMenuItem
            // 
            expandToolStripMenuItem.Name = "expandToolStripMenuItem";
            expandToolStripMenuItem.Size = new Size(113, 22);
            expandToolStripMenuItem.Text = "Expand";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(sceneView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(propertyGrid1);
            splitContainer1.Size = new Size(542, 426);
            splitContainer1.SplitterDistance = 180;
            splitContainer1.TabIndex = 3;
            // 
            // sceneView
            // 
            sceneView.Dock = DockStyle.Fill;
            sceneView.Location = new Point(0, 0);
            sceneView.Name = "sceneView";
            sceneView.Size = new Size(180, 426);
            sceneView.TabIndex = 3;
            sceneView.AfterSelect += sceneView_AfterSelect;
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.Location = new Point(0, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.PropertySort = PropertySort.NoSort;
            propertyGrid1.Size = new Size(358, 426);
            propertyGrid1.TabIndex = 4;
            // 
            // SceneEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SceneEditor";
            Text = "Trinity Scene Editor";
            FormClosing += SceneEditor_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            sceneContext.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openTRSOT;
        private ContextMenuStrip sceneContext;
        private ToolStripMenuItem expandToolStripMenuItem;
        private ToolStripMenuItem closeTRSOT;
        private ToolStripMenuItem saveTRSOT;
        private SplitContainer splitContainer1;
        private TreeView sceneView;
        private PropertyGrid propertyGrid1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}