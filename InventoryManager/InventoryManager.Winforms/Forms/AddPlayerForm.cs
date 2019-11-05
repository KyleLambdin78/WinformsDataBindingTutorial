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
            get => nameTextbox.Text;
            set => nameTextbox.Text = value; 
        }
        public AddPlayerForm()
        {
            InitializeComponent();
        }

       
    }
}
