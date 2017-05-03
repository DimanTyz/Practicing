using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace MatDesignTest
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            MaterialSkinManager man = MaterialSkinManager.Instance;
            man.AddFormToManage(this);
            man.Theme = MaterialSkinManager.Themes.LIGHT;

        }
    }
}
