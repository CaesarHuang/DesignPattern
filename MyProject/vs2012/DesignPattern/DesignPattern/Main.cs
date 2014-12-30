using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent(); 
            BindtvMenu(); 
        }

        public void BindtvMenu()
        {
            TreeNode mainNode = new TreeNode();
            mainNode.Name = "";
            mainNode.Text = "Design Pattern";
            this.tvMenu.Nodes.Add(mainNode);
            mainNode.Nodes.Add("DesignPattern.SimpleFactory", "SimpleFactory");
            mainNode.Nodes.Add("DesignPattern.Strategy", "Strategy");
            mainNode.Nodes.Add("DesignPattern.Prototype", "Prototype");
            this.tvMenu.ExpandAll();
        }

        private void tvMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name.ToString() != "")
            {
                string fullFormName = e.Node.Name.ToString();
                Type formType = Type.GetType(fullFormName);

                if (formType != null) //查看反射是否成功
                {
                    if (typeof (Form).IsAssignableFrom(formType)) //反射结果是否为窗体Form
                    {
                        LoadPanel(formType);
                    }
                    else
                    {
                        MessageBox.Show("指定的类型不能是从Form类型继承", "温馨提示");
                    }
                }
                else
                {
                    MessageBox.Show("指定的类型不存在", "温馨提示");
                }
            }
        }

        public void LoadPanel(Type formType)
        {
            this.splitContainer1.Panel2.Controls.Clear(); //关闭父窗体中的所有子窗体
            Form form = (Form)Activator.CreateInstance(formType); //创建反射窗体实例 
            form.TopLevel = false; //指示子窗体非顶级窗体
            this.splitContainer1.Panel2.Controls.Add(form); //将子窗体载入panel
            form.Show();
        }
    }
}
