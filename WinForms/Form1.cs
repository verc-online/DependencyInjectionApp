using DiDemoLib;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private readonly IMessages _messages;

        public Form1(IMessages messages)
        {
            InitializeComponent();
            _messages = messages;
        }
    }
}
