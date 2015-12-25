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
            this.Field.GenerateSquares();
        }
        

        public class Square : Button
        {
            int clicked;

        }

        partial class FIELD : System.Windows.Forms.Panel
        {
            Model model;
            public String seq;
            public int block_size;
            int clicked=0;
            public FIELD()
            {
                model = new Model();
            }
            
            public void GenerateSquares()
            {
                int panelWidth = this.Width;
                int panelHeight = this.Height;
                int squareMargin = 5;
                int width = panelWidth / 4;
                int height = panelHeight / 4;
                int size = panelWidth / 4 - squareMargin * 2;
                

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Square block = new Square();
                        model.board[i, j].square = block;

                        block.Text =  model.board[i,j].letter.ToString();//未知的结果
                        block.Top = j * size + squareMargin;
                        block.Left = i * size + squareMargin;
                        block.Width = size;
                        block.Height = size;
                        block.Visible = true;
                        block.Font = new Font(new FontFamily("微软雅黑"), 20);
                        block.MouseMove += Block_MouseMove;
                        //block.MouseEnter += Block_MouseEnter;
                        block.MouseLeave += Block_MouseLeave;
                        this.Controls.Add(block);
                    }
                }
            }

            private void Block_MouseLeave(object sender, EventArgs e)
            {
                Console.WriteLine("leave");
            }

            private void Block_MouseMove(object sender, MouseEventArgs e)
            {
                
            }

            private void Block_MouseEnter(object sender, EventArgs e)
            {
                Console.WriteLine(sender);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
