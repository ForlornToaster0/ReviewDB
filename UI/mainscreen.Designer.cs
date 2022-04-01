namespace UI
{
    partial class mainscreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AddReview = new FontAwesome.Sharp.IconButton();
            this.btn_addMovie = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.ProgramName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.btn_AddReview);
            this.panel1.Controls.Add(this.btn_addMovie);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Controls.Add(this.ProgramName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 451);
            this.panel1.TabIndex = 0;
            // 
            // btn_AddReview
            // 
            this.btn_AddReview.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddReview.FlatAppearance.BorderSize = 0;
            this.btn_AddReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddReview.ForeColor = System.Drawing.Color.White;
            this.btn_AddReview.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_AddReview.IconColor = System.Drawing.Color.White;
            this.btn_AddReview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AddReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddReview.Location = new System.Drawing.Point(0, 196);
            this.btn_AddReview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddReview.Name = "btn_AddReview";
            this.btn_AddReview.Size = new System.Drawing.Size(201, 75);
            this.btn_AddReview.TabIndex = 7;
            this.btn_AddReview.Tag = "AddReview";
            this.btn_AddReview.Text = "Add Review";
            this.btn_AddReview.UseVisualStyleBackColor = true;
            // 
            // btn_addMovie
            // 
            this.btn_addMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_addMovie.FlatAppearance.BorderSize = 0;
            this.btn_addMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMovie.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addMovie.ForeColor = System.Drawing.Color.White;
            this.btn_addMovie.IconChar = FontAwesome.Sharp.IconChar.Tv;
            this.btn_addMovie.IconColor = System.Drawing.Color.White;
            this.btn_addMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_addMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addMovie.Location = new System.Drawing.Point(0, 121);
            this.btn_addMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addMovie.Name = "btn_addMovie";
            this.btn_addMovie.Size = new System.Drawing.Size(201, 75);
            this.btn_addMovie.TabIndex = 6;
            this.btn_addMovie.Tag = "AddMovie";
            this.btn_addMovie.Text = "Add Movie";
            this.btn_addMovie.UseVisualStyleBackColor = true;
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Home.IconColor = System.Drawing.Color.White;
            this.btn_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 46);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(201, 75);
            this.btn_Home.TabIndex = 5;
            this.btn_Home.Tag = "Home";
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgramName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgramName.ForeColor = System.Drawing.Color.White;
            this.ProgramName.Location = new System.Drawing.Point(0, 0);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(146, 46);
            this.ProgramName.TabIndex = 4;
            this.ProgramName.Text = "Reviwer";
            this.ProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "mainscreen";
            this.Text = "mainscreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_AddReview;
        private FontAwesome.Sharp.IconButton btn_addMovie;
        private FontAwesome.Sharp.IconButton btn_Home;
        private Label ProgramName;
    }
}