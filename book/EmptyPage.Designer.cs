namespace book
{
    partial class EmptyPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmptyPage));
            this.eraserSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.penSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.clearButton = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eraserButton = new System.Windows.Forms.Button();
            this.pencilButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.eraserSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // eraserSizeTrackBar
            // 
            this.eraserSizeTrackBar.Location = new System.Drawing.Point(45, 357);
            this.eraserSizeTrackBar.Name = "eraserSizeTrackBar";
            this.eraserSizeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.eraserSizeTrackBar.TabIndex = 10;
            // 
            // penSizeTrackBar
            // 
            this.penSizeTrackBar.Location = new System.Drawing.Point(45, 226);
            this.penSizeTrackBar.Name = "penSizeTrackBar";
            this.penSizeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.penSizeTrackBar.TabIndex = 9;
            this.penSizeTrackBar.Scroll += new System.EventHandler(this.penSizeTrackBar_Scroll);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(646, 372);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 30);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(241, 36);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(424, 330);
            this.canvas.TabIndex = 7;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pen Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Eraser Size";
            // 
            // eraserButton
            // 
            this.eraserButton.Location = new System.Drawing.Point(50, 84);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(30, 30);
            this.eraserButton.TabIndex = 13;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.pencilButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // pencilButton
            // 
            this.pencilButton.Image = ((System.Drawing.Image)(resources.GetObject("pencilButton.Image")));
            this.pencilButton.Location = new System.Drawing.Point(45, 36);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(35, 31);
            this.pencilButton.TabIndex = 14;
            this.pencilButton.UseVisualStyleBackColor = true;
            this.pencilButton.Click += new System.EventHandler(this.pencilButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(58, 136);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(82, 35);
            this.colorButton.TabIndex = 15;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.pencilButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // EmptyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.pencilButton);
            this.Controls.Add(this.eraserButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eraserSizeTrackBar);
            this.Controls.Add(this.penSizeTrackBar);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.canvas);
            this.Name = "EmptyPage";
            this.Text = "EmptyPage";
            ((System.ComponentModel.ISupportInitialize)(this.eraserSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penSizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar eraserSizeTrackBar;
        private System.Windows.Forms.TrackBar penSizeTrackBar;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button pencilButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}