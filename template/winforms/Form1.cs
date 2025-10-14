using System.Windows.Forms;

namespace winforms_template
{
    public partial class Form1 : Form
    {
        private Button btnClickThis;
        private Label lblHelloWorld;
        public Form1()
        {

            btnClickThis = new Button();
            btnClickThis.Text = "Click this";
            btnClickThis.Left = 100;
            btnClickThis.Top = 100;
            btnClickThis.Click += (sender, e) =>
            {
                lblHelloWorld.Text = "Hello World!";
            };



            lblHelloWorld = new Label();
            lblHelloWorld.Text = "Label 1";
            lblHelloWorld.Left = 100;
            lblHelloWorld.Top = 130;


            Controls.Add(btnClickThis);
            Controls.Add(lblHelloWorld);




        }
    }
}
