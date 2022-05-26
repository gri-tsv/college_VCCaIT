
namespace OAIP305
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("China", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Russia", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("USSR", 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ОАИП");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("РМП");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Колледж", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("GTAV");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cyberpunk");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Игры", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("D:\\", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("N:\\");
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(22, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 110);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "China.jpg");
            this.imageList1.Images.SetKeyName(1, "Rus.jpeg");
            this.imageList1.Images.SetKeyName(2, "SSSR_Flag.jpg");
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Location = new System.Drawing.Point(198, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node3";
            treeNode1.Text = "ОАИП";
            treeNode2.Name = "Node4";
            treeNode2.Text = "РМП";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Колледж";
            treeNode4.Name = "Node5";
            treeNode4.Text = "GTAV";
            treeNode5.Name = "Node6";
            treeNode5.Text = "Cyberpunk";
            treeNode6.Name = "Node2";
            treeNode6.Text = "Игры";
            treeNode7.Name = "Node0";
            treeNode7.Text = "D:\\";
            treeNode8.Name = "Node7";
            treeNode8.Text = "N:\\";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(133, 123);
            this.treeView1.TabIndex = 1;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(45, 167);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(266, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущее значение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(22, 237);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

