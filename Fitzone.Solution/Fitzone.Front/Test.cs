using Fitzone.Controller;

namespace Fitzone.Front
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var socios = SociosController.Get();
        }
    }
}
