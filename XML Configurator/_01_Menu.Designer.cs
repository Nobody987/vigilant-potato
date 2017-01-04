namespace XML_Configurator
{
    partial class _01_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_01_Menu));
            this.button_database_connection = new System.Windows.Forms.Button();
            this.button_object_creator = new System.Windows.Forms.Button();
            this.button_create_connection = new System.Windows.Forms.Button();
            this.button_transformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_database_connection
            // 
            this.button_database_connection.Location = new System.Drawing.Point(111, 193);
            this.button_database_connection.Name = "button_database_connection";
            this.button_database_connection.Size = new System.Drawing.Size(145, 33);
            this.button_database_connection.TabIndex = 0;
            this.button_database_connection.Text = "Data Extraction";
            this.button_database_connection.UseVisualStyleBackColor = true;
            this.button_database_connection.Click += new System.EventHandler(this.button_database_connection_Click);
            // 
            // button_object_creator
            // 
            this.button_object_creator.Location = new System.Drawing.Point(111, 89);
            this.button_object_creator.Name = "button_object_creator";
            this.button_object_creator.Size = new System.Drawing.Size(145, 33);
            this.button_object_creator.TabIndex = 1;
            this.button_object_creator.Text = "Generator";
            this.button_object_creator.UseVisualStyleBackColor = true;
            this.button_object_creator.Click += new System.EventHandler(this.button_object_creator_Click);
            // 
            // button_create_connection
            // 
            this.button_create_connection.Location = new System.Drawing.Point(111, 37);
            this.button_create_connection.Name = "button_create_connection";
            this.button_create_connection.Size = new System.Drawing.Size(145, 33);
            this.button_create_connection.TabIndex = 2;
            this.button_create_connection.Text = "Create New Connection";
            this.button_create_connection.UseVisualStyleBackColor = true;
            this.button_create_connection.Click += new System.EventHandler(this.button_create_connection_Click);
            // 
            // button_transformation
            // 
            this.button_transformation.Location = new System.Drawing.Point(111, 141);
            this.button_transformation.Name = "button_transformation";
            this.button_transformation.Size = new System.Drawing.Size(145, 33);
            this.button_transformation.TabIndex = 3;
            this.button_transformation.Text = "Transformation";
            this.button_transformation.UseVisualStyleBackColor = true;
            this.button_transformation.Click += new System.EventHandler(this.button_transformation_Click);
            // 
            // _01_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 264);
            this.Controls.Add(this.button_transformation);
            this.Controls.Add(this.button_create_connection);
            this.Controls.Add(this.button_object_creator);
            this.Controls.Add(this.button_database_connection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_01_Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_database_connection;
        private System.Windows.Forms.Button button_object_creator;
        private System.Windows.Forms.Button button_create_connection;
        private System.Windows.Forms.Button button_transformation;
    }
}