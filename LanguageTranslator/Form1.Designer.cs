namespace LanguageTranslator
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
            splitContainer1 = new SplitContainer();
            keyLabel = new Label();
            currentLabel = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            prevBtn = new Button();
            nextBtn = new Button();
            label1 = new Label();
            infoLabel = new Label();
            exportBtn = new Button();
            loadBtn = new Button();
            listView = new ListView();
            No = new ColumnHeader();
            Key = new ColumnHeader();
            Value = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(keyLabel);
            splitContainer1.Panel1.Controls.Add(currentLabel);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(prevBtn);
            splitContainer1.Panel1.Controls.Add(nextBtn);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(infoLabel);
            splitContainer1.Panel2.Controls.Add(exportBtn);
            splitContainer1.Panel2.Controls.Add(loadBtn);
            splitContainer1.Panel2.Controls.Add(listView);
            splitContainer1.Size = new Size(712, 597);
            splitContainer1.SplitterDistance = 293;
            splitContainer1.TabIndex = 0;
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(56, 24);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(0, 15);
            keyLabel.TabIndex = 15;
            // 
            // currentLabel
            // 
            currentLabel.AutoSize = true;
            currentLabel.Location = new Point(56, 50);
            currentLabel.Name = "currentLabel";
            currentLabel.Size = new Size(0, 15);
            currentLabel.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 12;
            label3.Text = "New";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 11;
            label2.Text = "Current";
            // 
            // prevBtn
            // 
            prevBtn.Location = new Point(12, 119);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(117, 31);
            prevBtn.TabIndex = 10;
            prevBtn.Text = "Previous ";
            prevBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(148, 119);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(130, 31);
            nextBtn.TabIndex = 9;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 8;
            label1.Text = "Key";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(11, 557);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(0, 15);
            infoLabel.TabIndex = 3;
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(313, 552);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(86, 33);
            exportBtn.TabIndex = 2;
            exportBtn.Text = "export File";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(208, 552);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(93, 33);
            loadBtn.TabIndex = 1;
            loadBtn.Text = "Load file";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // listView
            // 
            listView.Columns.AddRange(new ColumnHeader[] { No, Key, Value });
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.Location = new Point(3, 3);
            listView.Name = "listView";
            listView.Size = new Size(405, 535);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // No
            // 
            No.Text = "No";
            No.Width = 40;
            // 
            // Key
            // 
            Key.Tag = "";
            Key.Text = "Key";
            Key.Width = 180;
            // 
            // Value
            // 
            Value.Tag = "";
            Value.Text = "Value";
            Value.Width = 180;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 597);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label keyLabel;
        private Label currentLabel;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button prevBtn;
        private Button nextBtn;
        private Label label1;
        private Button exportBtn;
        private Button loadBtn;
        private ListView listView;
        private Label infoLabel;
        private ColumnHeader Key;
        private ColumnHeader Value;
        private ColumnHeader No;
    }
}