using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustomControlCafe
{

    public class RequireValueTextBox : TextBox
    {
        public ErrorProvider errorProvider;
        public RequireValueTextBox()
        {
            errorProvider = new ErrorProvider();
            this.TextChanged += RequireValueTextBox_TextChanged;
            SetDefaultErr(this);
        }

        private void RequireValueTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length <= 0)
            {
                errorProvider.SetError(tb, "trường này không được trống");
            }
            else
            {
                errorProvider.SetError(tb, "");
            }
        }

        private void SetDefaultErr(TextBox tb)
        {
            errorProvider.SetError(tb, "trường này không được trống");
        }
    }
}
