using System.Text;

namespace MGAnchkov.ComVisual;

public partial class Form1 : Form
{
    byte[] byteStart = Array.Empty<byte>();

    public Form1()
    {
        InitializeComponent();
        byteStart = new byte[] { 10, 13 };

        RByte_CheckedChanged(TStartByte, RStartByteDec.Checked, RStartByteHex.Checked, RStartByteStr.Checked);
        RByte_CheckedChanged(TStopByte, RStopByteDec.Checked, RStopByteHex.Checked, RStopByteStr.Checked);
    }


    private void TStartByte_KeyPress(object sender, KeyPressEventArgs e)
    {
        /* less than 0 or greater than 9, and
         * less than a or greater than f, and
         * less than A or greater than F, and
         * not backspace, and
         * not delete or decimal (which is the same key as delete). */
        if (RStartByteHex.Checked)
            if (
                    ((e.KeyChar < 48) || (e.KeyChar > 57)) &&
                    ((e.KeyChar < 65) || (e.KeyChar > 70)) &&
                    ((e.KeyChar < 97) || (e.KeyChar > 102)) &&
                    (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) &&
                    ((e.KeyChar != (char)Keys.Delete) || (e.KeyChar == '.'))
               )
                e.Handled = true;
        if (RStartByteDec.Checked)
            if (
                    ((e.KeyChar < 48) || (e.KeyChar > 57)) &&
                    (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) &&
                    ((e.KeyChar != (char)Keys.Delete) || (e.KeyChar == '.'))
               )
                e.Handled = true;
    }
    private void TStopByte_KeyPress(object sender, KeyPressEventArgs e)
    {
        /* less than 0 or greater than 9, and
         * less than a or greater than f, and
         * less than A or greater than F, and
         * not backspace, and
         * not delete or decimal (which is the same key as delete). */
        if (RStartByteHex.Checked)
            if (
                    ((e.KeyChar < 48) || (e.KeyChar > 57)) &&
                    ((e.KeyChar < 65) || (e.KeyChar > 70)) &&
                    ((e.KeyChar < 97) || (e.KeyChar > 102)) &&
                    (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) &&
                    ((e.KeyChar != (char)Keys.Delete) || (e.KeyChar == '.'))
               )
                e.Handled = true;
        if (RStartByteDec.Checked)
            if (
                    ((e.KeyChar < 48) || (e.KeyChar > 57)) &&
                    (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) &&
                    ((e.KeyChar != (char)Keys.Delete) || (e.KeyChar == '.'))
               )
                e.Handled = true;
    }

    private void TStartByte_TextChanged(object sender, EventArgs e) => TByte_TextChanged(TStartByte, RStartByteDec.Checked, RStartByteHex.Checked, RStartByteStr.Checked);
    private void TStopByte_TextChanged(object sender, EventArgs e) => TByte_TextChanged(TStopByte, RStopByteDec.Checked, RStopByteHex.Checked, RStopByteStr.Checked);
    private void TByte_TextChanged(TextBox TB, bool dec, bool hex, bool str)
    {
        string text = TB.Text;
        if (hex)
        {
            string[] t = text.Split(' ');
            byteStart = new byte[t.Length];
            for (int i = 0; i < t.Length; i++)
                if (byte.TryParse(t[i], System.Globalization.NumberStyles.AllowHexSpecifier, null, out byte v))
                    byteStart[i] = v;
                else
                {
                    TB.BackColor = Color.Tomato;
                    return;
                }
        }
        else if (dec)
        {
            string[] t = text.Split(' ');
            byteStart = new byte[t.Length];
            for (int i = 0; i < t.Length; i++)
                if (byte.TryParse(t[i], System.Globalization.NumberStyles.Number, null, out byte v))
                    byteStart[i] = v;
                else
                {
                    TB.BackColor = Color.Tomato;
                    return;
                }
        }
        else if (str)
        {
            byteStart = Encoding.UTF8.GetBytes(text);
        }

        TB.BackColor = SystemColors.Window;
    }


    private void RStartByte_CheckedChanged(object sender, EventArgs e) => RByte_CheckedChanged(TStartByte, RStartByteDec.Checked, RStartByteHex.Checked, RStartByteStr.Checked);
    private void RStopByte_CheckedChanged(object sender, EventArgs e) => RByte_CheckedChanged(TStopByte, RStopByteDec.Checked, RStopByteHex.Checked, RStopByteStr.Checked);
    private void RByte_CheckedChanged(TextBox TB, bool dec, bool hex, bool str)
    {
        if (byteStart.Length > 0)
        {
            if (hex)
                TB.Text = BitConverter.ToString(byteStart).Replace('-', ' ');
            else if (dec)
                TB.Text = string.Join(' ', byteStart.Select(b => $"{b}"));
            else if (str)
                TB.Text = Encoding.UTF8.GetString(byteStart);
        }
        TByte_TextChanged(TB, dec, hex, str);
    }

    private void CBStart_CheckedChanged(object sender, EventArgs e) => GBStart.Enabled = CBStart.Checked;
    private void CBStop_CheckedChanged(object sender, EventArgs e) => GBStop.Enabled = CBStop.Checked;

    private void TBSkipByte_TextChanged(object sender, EventArgs e)
    {
        if (int.TryParse(TBSkipByte.Text, out int _))
            TBSkipByte.BackColor = SystemColors.Window;
        else
            TBSkipByte.BackColor = Color.Tomato;
    }
}
