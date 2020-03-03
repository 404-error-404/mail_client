using System.Windows.Forms;

namespace mail_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 这是一个调用dll的例子
        // 下边两行，将dll中的函数引入，这里引入的是一个test函数，直接返回整数 1
        [System.Runtime.InteropServices.DllImport(@"K:\C# Project\mail_client\Release\mail_dll.dll", EntryPoint = "test")]
        public static extern int test();

        private void button1_Click(object sender, System.EventArgs e)
        {
            // 这里对上边的test函数进行调用，获取值之后将button的text改为获取的内容
            int x = test();
            button1.Text = System.Convert.ToString(x);
        }
    }
}
