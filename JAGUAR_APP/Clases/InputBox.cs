using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_PRO.Clases
{
    public  class InputBox
    {
        public InputBox() { }
        public  bool IsOk { get; set; }
        public decimal ShowNumeric(string prompt, string title = "")
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = prompt;

            buttonOk.Text = "OK";
            buttonOk.DialogResult = DialogResult.OK;
            
            buttonCancel.Text = "Cancelar";
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(310, 72, 75, 23);
            buttonCancel.SetBounds(234,72,75,23);

            label.AutoSize = true;
            form.ClientSize = new System.Drawing.Size(320, 104);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new System.Drawing.Size(Math.Max(420, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;

            // Validación para permitir solo números
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true; // Bloquea el carácter
                }

                // Si se presiona Enter, simula clic en OK
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true; // Evita el beep del Enter
                    buttonOk.PerformClick();
                }
            };

            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                IsOk = true;
            }
            else
            {
                IsOk = true;
            }

            return dialogResult == DialogResult.OK ? Convert.ToDecimal(textBox.Text) : 0;
        }
    }
}
