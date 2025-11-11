using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lababa.Frontend.UserControls
{
    public partial class LabeledTextBox : UserControl
    {
        public LabeledTextBox()
        {
            InitializeComponent();
        }

        public new event EventHandler TextChanged
        {
            add => textBox1.TextChanged += value;
            remove => textBox1.TextChanged -= value;
        }

        [Category("Custom Properties")]
        [Browsable(true)]
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        [Category("Custom Properties")]
        [Browsable(true)]
        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
    }
}
