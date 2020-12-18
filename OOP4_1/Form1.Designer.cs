namespace OOP4_1
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
            this.Circle_Panel = new System.Windows.Forms.Panel();
            this.Coord_label = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Del_button = new System.Windows.Forms.Button();
            this.СlearStorage_button = new System.Windows.Forms.Button();
            this.ShowCircle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Circle_Panel
            // 
            this.Circle_Panel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Circle_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Circle_Panel.Location = new System.Drawing.Point(10, 8);
            this.Circle_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Circle_Panel.Name = "Circle_Panel";
            this.Circle_Panel.Size = new System.Drawing.Size(824, 490);
            this.Circle_Panel.TabIndex = 0;
            this.Circle_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Circle_Panel_MouseDown);
            this.Circle_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Circle_Panel_MouseMove);
            // 
            // Coord_label
            // 
            this.Coord_label.AutoSize = true;
            this.Coord_label.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.Coord_label.Location = new System.Drawing.Point(891, 9);
            this.Coord_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Coord_label.Name = "Coord_label";
            this.Coord_label.Size = new System.Drawing.Size(55, 18);
            this.Coord_label.TabIndex = 1;
            this.Coord_label.Text = "label1";
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Clear_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear_button.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.Clear_button.ForeColor = System.Drawing.Color.Olive;
            this.Clear_button.Location = new System.Drawing.Point(884, 190);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(2);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(216, 74);
            this.Clear_button.TabIndex = 2;
            this.Clear_button.Text = "Очистить панель";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Del_button
            // 
            this.Del_button.BackColor = System.Drawing.Color.DeepPink;
            this.Del_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Del_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Del_button.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.Del_button.ForeColor = System.Drawing.Color.Maroon;
            this.Del_button.Location = new System.Drawing.Point(884, 268);
            this.Del_button.Margin = new System.Windows.Forms.Padding(2);
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(216, 74);
            this.Del_button.TabIndex = 3;
            this.Del_button.Text = "Удалить объекты";
            this.Del_button.UseVisualStyleBackColor = false;
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // СlearStorage_button
            // 
            this.СlearStorage_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.СlearStorage_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.СlearStorage_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.СlearStorage_button.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.СlearStorage_button.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.СlearStorage_button.Location = new System.Drawing.Point(884, 346);
            this.СlearStorage_button.Margin = new System.Windows.Forms.Padding(2);
            this.СlearStorage_button.Name = "СlearStorage_button";
            this.СlearStorage_button.Size = new System.Drawing.Size(216, 74);
            this.СlearStorage_button.TabIndex = 4;
            this.СlearStorage_button.Text = "Очистить хранилище";
            this.СlearStorage_button.UseVisualStyleBackColor = false;
            this.СlearStorage_button.Click += new System.EventHandler(this.СlearStorage_button_Click);
            // 
            // ShowCircle_button
            // 
            this.ShowCircle_button.BackColor = System.Drawing.Color.PaleGreen;
            this.ShowCircle_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowCircle_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowCircle_button.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.ShowCircle_button.ForeColor = System.Drawing.Color.DarkGreen;
            this.ShowCircle_button.Location = new System.Drawing.Point(884, 424);
            this.ShowCircle_button.Margin = new System.Windows.Forms.Padding(2);
            this.ShowCircle_button.Name = "ShowCircle_button";
            this.ShowCircle_button.Size = new System.Drawing.Size(216, 74);
            this.ShowCircle_button.TabIndex = 5;
            this.ShowCircle_button.Text = "Показать объекты хранилища";
            this.ShowCircle_button.UseVisualStyleBackColor = false;
            this.ShowCircle_button.Click += new System.EventHandler(this.ShowCircle_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 621);
            this.Controls.Add(this.ShowCircle_button);
            this.Controls.Add(this.СlearStorage_button);
            this.Controls.Add(this.Del_button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Coord_label);
            this.Controls.Add(this.Circle_Panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №4";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Circle_Panel;
        private System.Windows.Forms.Label Coord_label;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Del_button;
        private System.Windows.Forms.Button СlearStorage_button;
        private System.Windows.Forms.Button ShowCircle_button;
    }
}

