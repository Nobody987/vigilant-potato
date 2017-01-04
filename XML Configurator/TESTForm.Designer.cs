namespace XML_Configurator
{
    partial class TESTForm
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
            this.textBox_file_name = new System.Windows.Forms.TextBox();
            this.label_file_name = new System.Windows.Forms.Label();
            this.button_browse = new System.Windows.Forms.Button();
            this.textBox_folder_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_file_name
            // 
            this.textBox_file_name.Location = new System.Drawing.Point(103, 6);
            this.textBox_file_name.Name = "textBox_file_name";
            this.textBox_file_name.Size = new System.Drawing.Size(323, 20);
            this.textBox_file_name.TabIndex = 50;
            this.textBox_file_name.Text = "text.xml";
            // 
            // label_file_name
            // 
            this.label_file_name.AutoSize = true;
            this.label_file_name.Location = new System.Drawing.Point(12, 9);
            this.label_file_name.Name = "label_file_name";
            this.label_file_name.Size = new System.Drawing.Size(74, 13);
            this.label_file_name.TabIndex = 49;
            this.label_file_name.Text = "XML file name";
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(991, 41);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(71, 24);
            this.button_browse.TabIndex = 48;
            this.button_browse.Text = "Browse...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // textBox_folder_path
            // 
            this.textBox_folder_path.Location = new System.Drawing.Point(103, 44);
            this.textBox_folder_path.Name = "textBox_folder_path";
            this.textBox_folder_path.Size = new System.Drawing.Size(882, 20);
            this.textBox_folder_path.TabIndex = 47;
            this.textBox_folder_path.Text = "C:\\Users\\slobodan.sredojevic\\Desktop\\VS Projects\\XML Configurator\\XML Configurato" +
    "r\\bin\\Debug";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "XML file location";
            // 
            // TESTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1406, 615);
            this.Controls.Add(this.textBox_file_name);
            this.Controls.Add(this.label_file_name);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.textBox_folder_path);
            this.Controls.Add(this.label1);
            this.Name = "TESTForm";
            this.Text = "TESTForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_file_name;
        private System.Windows.Forms.Label label_file_name;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.TextBox textBox_folder_path;
        private System.Windows.Forms.Label label1;
    }
}