using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamePrototype
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Trie t = new Trie();
            t.init("shrink.txt");
            Console.WriteLine(t.find("congratulations"));
        }
    }
}
