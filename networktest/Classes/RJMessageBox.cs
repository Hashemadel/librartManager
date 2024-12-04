using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace networktest
{
    public abstract class RJMessageBox
    {
        public static DialogResult Shows(string text)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Shows(string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Shows(string text, string caption,Image image)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Shows(string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Shows(string text, string caption, string button1Text, string button2Text,string button3Text,String name)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, button1Text, button2Text, button3Text, name))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Shows(string text, string button1Text, string button2Text)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, button1Text, button2Text))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Shows(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Shows(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog();
            return result;
        }
        /*-> IWin32Window Owner:
            *      Displays a message box in front of the specified object and with the other specified parameters.
            *      An implementation of IWin32Window that will own the modal dialog box.*/
        public static DialogResult Shows()
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox())
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Shows(IWin32Window owner, string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Shows(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Shows(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon))
                result = msgForm.ShowDialog(owner);
            return result;
        }
        public static DialogResult Shows(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            DialogResult result;
            using (var msgForm = new FormMessageBox(text, caption, buttons, icon, defaultButton))
                result = msgForm.ShowDialog(owner);
            return result;
        }
    }
}
