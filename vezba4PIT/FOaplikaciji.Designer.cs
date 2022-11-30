
namespace vezba4PIT
{
    partial class FOaplikaciji
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Opste informacije");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Pregled autora");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Unos novog autora");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Aktivnosti", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Statisticki pregled");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Zatvaranje aplikacije");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Dodatni zahtevi");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Autor");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(112, 242);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1206, 450);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Opste informacije";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Pregled autora";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Unos novog autora";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Aktivnosti";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Statisticki pregled";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Zatvaranje aplikacije";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Dodatni zahtevi";
            treeNode8.Name = "Node7";
            treeNode8.Text = "Autor";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.treeView2.Size = new System.Drawing.Size(402, 450);
            this.treeView2.TabIndex = 0;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // FOaplikaciji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.treeView1);
            this.Name = "FOaplikaciji";
            this.Text = "FOaplikaciji";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label1;
    }
}