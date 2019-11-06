using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager.Winforms.Forms
{
    public partial class AddPlayerForm : Form
    {
        public string PlayerName
        {
            get => NameTexbox.Text;
            set => NameTexbox.Text = value;
        }
        public AddPlayerForm()
        {
            InitializeComponent();
            OkayButton.Enabled = false;
        }

        private void DeletePlayerButton_Click(object sender, EventArgs e)
        {

        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
           
        }

        private void AddPlayerForm_Load(object sender, EventArgs e)
        {

        }

        private void NameTexbox_TextChanged(object sender, EventArgs e)
        {
           OkayButton.Enabled = !string.IsNullOrEmpty(PlayerName);
        }
    }
}
