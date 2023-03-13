using System.Text.Json;

namespace JsonEscape
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnJsonToEscapedJson_Click_1(object sender, EventArgs e)
        {
            var json = JsonTextBox.Text;

            if (string.IsNullOrWhiteSpace(json))
            {
                return;
            }

            EscapedJsonTextBox.Text = JsonSerializer.Serialize(json);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            JsonTextBox.Clear();
            EscapedJsonTextBox.Clear();

            MainSplitContainer.SplitterDistance = Convert.ToInt32(MainSplitContainer.Width / 2);

            JsonTextBox.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(EscapedJsonTextBox.Text))
            {
                Clipboard.SetText(EscapedJsonTextBox.Text);
            }
        }
    }
}
