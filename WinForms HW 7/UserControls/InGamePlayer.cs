using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_HW_7.UserControls
{
    public partial class InGamePlayer : UserControl
    {
        public InGamePlayer(Models.Player player) : this() {
            lbl_Name.Text = player.Name;
            lbl_Number.Text = player.Number.ToString();
            lbl_Position.Text = player.Position.ToString();
        }


        public InGamePlayer()
        {
            InitializeComponent();
        }
    }
}
