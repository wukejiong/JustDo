using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustDo.Model;
using JustDo.Repository;

namespace Justdo
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        public AddForm(ToDoModel model)
        {
            InitializeComponent();
            //show detial
            txtContent.Text = model.Content;
            this.Text = "查看内容";
            btnSave.Visible = false;
            btnCancel.Visible = false;
            labelContent.Visible = false;
            labelEsc.Visible = false;
            labelSave.Visible = false;
        }

       /// <summary>
       /// 快捷键
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void AddForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (((int)e.Modifiers == (int)Keys.Shift || (int)e.Modifiers == (int)Keys.Control) && e.KeyCode == Keys.S)
            {
                //save 
                btnSave_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                //cancel
                btnCancel_Click(null, null);

            } 
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtContent.Text == "")
            {
                MessageBox.Show("your plan is empty");
                return;
            }
            var model = new ToDoModel()
            {
                Content = txtContent.Text,
                AddTime = DateTime.Now,
            };
            if (TodoDao.Add(model))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("fail");
            }  
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
