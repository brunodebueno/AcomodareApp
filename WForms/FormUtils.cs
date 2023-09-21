using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForms.Forms {   
    internal class FormUtils {
        public static void KeyUp(Form form,object sender, KeyEventArgs e) {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return)) {
                form.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

    }
}
