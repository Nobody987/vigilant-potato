namespace XML_Configurator
{
    partial class _04_ConnectionCreator
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
            this.button_create_new = new System.Windows.Forms.Button();
            this.button_load_connections = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.openFileDialogLocation = new System.Windows.Forms.OpenFileDialog();
            this.button_remove = new System.Windows.Forms.Button();
            this.listBox_connections = new System.Windows.Forms.ListBox();
            this.button_add_to_list = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_create_new
            // 
            this.button_create_new.Location = new System.Drawing.Point(93, 12);
            this.button_create_new.Name = "button_create_new";
            this.button_create_new.Size = new System.Drawing.Size(75, 23);
            this.button_create_new.TabIndex = 0;
            this.button_create_new.Text = "Create New";
            this.button_create_new.UseVisualStyleBackColor = true;
            this.button_create_new.Click += new System.EventHandler(this.button_create_new_Click);
            // 
            // button_load_connections
            // 
            this.button_load_connections.Location = new System.Drawing.Point(12, 12);
            this.button_load_connections.Name = "button_load_connections";
            this.button_load_connections.Size = new System.Drawing.Size(75, 23);
            this.button_load_connections.TabIndex = 1;
            this.button_load_connections.Text = "Load";
            this.button_load_connections.UseVisualStyleBackColor = true;
            this.button_load_connections.Click += new System.EventHandler(this.button_load_connections_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(531, 12);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // openFileDialogLocation
            // 
            this.openFileDialogLocation.FileName = "openFileDialogLocation";
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(450, 12);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 52;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // listBox_connections
            // 
            this.listBox_connections.FormattingEnabled = true;
            this.listBox_connections.Location = new System.Drawing.Point(450, 41);
            this.listBox_connections.Name = "listBox_connections";
            this.listBox_connections.Size = new System.Drawing.Size(156, 511);
            this.listBox_connections.TabIndex = 53;
            this.listBox_connections.SelectedIndexChanged += new System.EventHandler(this.listBox_connections_SelectedIndexChanged);
            // 
            // button_add_to_list
            // 
            this.button_add_to_list.Location = new System.Drawing.Point(369, 12);
            this.button_add_to_list.Name = "button_add_to_list";
            this.button_add_to_list.Size = new System.Drawing.Size(75, 23);
            this.button_add_to_list.TabIndex = 54;
            this.button_add_to_list.Text = "Add To List";
            this.button_add_to_list.UseVisualStyleBackColor = true;
            this.button_add_to_list.Click += new System.EventHandler(this.button_add_to_list_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(288, 12);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 55;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // _04_ConnectionCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 564);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add_to_list);
            this.Controls.Add(this.listBox_connections);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_load_connections);
            this.Controls.Add(this.button_create_new);
            this.Name = "ConnectionCreator";
            this.Text = "ConnectionCreator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_create_new;
        private System.Windows.Forms.Button button_load_connections;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.OpenFileDialog openFileDialogLocation;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ListBox listBox_connections;
        private System.Windows.Forms.Button button_add_to_list;
        private System.Windows.Forms.Button button_update;
    }
}