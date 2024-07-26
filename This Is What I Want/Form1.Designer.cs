namespace This_Is_What_I_Want
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnBack = new PictureBox();
            btnNext = new PictureBox();
            imageList = new ImageList(components);
            listView = new ListView();
            txtPath = new TextBox();
            Tick = new PictureBox();
            CHECK_BOX = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tick).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Image = Properties.Resources.icons8_left_96;
            btnBack.Location = new Point(642, 402);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(40, 40);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 0;
            btnBack.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Image = Properties.Resources.icons8_right_96;
            btnNext.Location = new Point(685, 402);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 40);
            btnNext.SizeMode = PictureBoxSizeMode.Zoom;
            btnNext.TabIndex = 1;
            btnNext.TabStop = false;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageSize = new Size(64, 64);
            imageList.TransparentColor = Color.Transparent;
            // 
            // listView
            // 
            listView.BackColor = Color.Black;
            listView.ForeColor = Color.White;
            listView.LargeImageList = imageList;
            listView.Location = new Point(192, 12);
            listView.Name = "listView";
            listView.Size = new Size(596, 384);
            listView.TabIndex = 3;
            listView.UseCompatibleStateImageBehavior = false;
            listView.ItemSelectionChanged += listView_ItemSelectionChanged;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // txtPath
            // 
            txtPath.BackColor = Color.Black;
            txtPath.ForeColor = Color.White;
            txtPath.Location = new Point(92, 412);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(543, 23);
            txtPath.TabIndex = 4;
            txtPath.TextChanged += txtPath_TextChanged;
            txtPath.KeyDown += txtPath_KeyDown;
            // 
            // Tick
            // 
            Tick.Image = Properties.Resources.icons8_checked_radio_button_96;
            Tick.Location = new Point(728, 402);
            Tick.Name = "Tick";
            Tick.Size = new Size(40, 40);
            Tick.SizeMode = PictureBoxSizeMode.Zoom;
            Tick.TabIndex = 5;
            Tick.TabStop = false;
            Tick.Click += Tick_Click;
            // 
            // CHECK_BOX
            // 
            CHECK_BOX.Appearance = Appearance.Button;
            CHECK_BOX.BackColor = Color.Black;
            CHECK_BOX.FlatStyle = FlatStyle.Flat;
            CHECK_BOX.ForeColor = Color.White;
            CHECK_BOX.Location = new Point(59, 412);
            CHECK_BOX.Margin = new Padding(0);
            CHECK_BOX.Name = "CHECK_BOX";
            CHECK_BOX.Size = new Size(23, 23);
            CHECK_BOX.TabIndex = 6;
            CHECK_BOX.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 35, 35);
            ClientSize = new Size(800, 450);
            Controls.Add(CHECK_BOX);
            Controls.Add(Tick);
            Controls.Add(txtPath);
            Controls.Add(listView);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "This Is What I Want";
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tick).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnBack;
        private PictureBox btnNext;
        private ImageList imageList;
        private ListView listView;
        private TextBox txtPath;
        private PictureBox Tick;
        private CheckBox CHECK_BOX;
    }
}
