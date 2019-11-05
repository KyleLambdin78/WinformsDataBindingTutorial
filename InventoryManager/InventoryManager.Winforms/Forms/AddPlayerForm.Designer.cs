namespace InventoryManager.Winforms.Forms
{
    partial class AddPlayerForm
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
            this.SuspendLayout();
            // 
            // AddPlayerForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "AddPlayerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox playerNameTexbox;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label nameLabel;
    }
}