namespace LeafQuiz
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnQ_Create = new System.Windows.Forms.Button();
            this.btnQ_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQ_Create
            // 
            this.btnQ_Create.BackColor = System.Drawing.Color.Transparent;
            this.btnQ_Create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQ_Create.BackgroundImage")));
            this.btnQ_Create.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQ_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQ_Create.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnQ_Create.Location = new System.Drawing.Point(0, 0);
            this.btnQ_Create.Name = "btnQ_Create";
            this.btnQ_Create.Size = new System.Drawing.Size(1184, 100);
            this.btnQ_Create.TabIndex = 1;
            this.btnQ_Create.Text = "Create Quiz";
            this.btnQ_Create.UseVisualStyleBackColor = false;
            // 
            // btnQ_Connect
            // 
            this.btnQ_Connect.BackColor = System.Drawing.Color.Transparent;
            this.btnQ_Connect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQ_Connect.BackgroundImage")));
            this.btnQ_Connect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnQ_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQ_Connect.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnQ_Connect.Location = new System.Drawing.Point(0, 661);
            this.btnQ_Connect.Name = "btnQ_Connect";
            this.btnQ_Connect.Size = new System.Drawing.Size(1184, 100);
            this.btnQ_Connect.TabIndex = 2;
            this.btnQ_Connect.Text = "Create Quiz";
            this.btnQ_Connect.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnQ_Connect);
            this.Controls.Add(this.btnQ_Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQ_Create;
        private System.Windows.Forms.Button btnQ_Connect;
    }
}

