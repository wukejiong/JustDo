using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class MainForm : Form
    {
        private const string SHORT_TIME_TEMP = "MM/dd HH:mm";
        private List<ToDoModel> todoList;
        private List<ToDoModel> completeList;
        private ToDoModel selectTodo;
        private ToDoModel selectComplete;

        public MainForm()
        {
            InitializeComponent();
            initListView();
            initListData();
        }

        #region 初始化listView
        /// <summary>
        ///  初始化视图
        /// </summary>
        public void initListView()
        {

            var oneword = ConfigurationSettings.AppSettings["oneword"];
            if (!string.IsNullOrEmpty(oneword))
            {
                labelOneWord.Text = oneword;
            }

            //==todo listView===========================
            //更改属性
            this.todoView.GridLines = true; //显示表格线
            this.todoView.View = View.Details;//显示表格细节
            this.todoView.LabelEdit = true; //是否可编辑,ListView只可编辑第一列。
            this.todoView.Scrollable = true;//有滚动条
            this.todoView.HeaderStyle = ColumnHeaderStyle.Clickable;//对表头进行设置
            this.todoView.FullRowSelect = true;//是否可以选择行
            //设置行高40   
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, 40);//分别是宽和高
            this.todoView.SmallImageList = imgList;   //这里设置listView的SmallImageList ,用imgList将其撑大
            //this.todoView.HotTracking = true;// 当选择此属性时则HoverSelection自动为true和Activation属性为oneClick
            //this.todoView.HoverSelection = true;
            ////this.todoView.Activation = ItemActivation.Standard;
            //添加表头
            this.todoView.Columns.Add("", 0);
            this.todoView.Columns.Add("", 280);
            this.todoView.Columns.Add("", 150);


            //==complete listView==================================
            //更改属性
            this.completeView.GridLines = true; //显示表格线
            this.completeView.View = View.Details;//显示表格细节
            this.completeView.LabelEdit = true; //是否可编辑,ListView只可编辑第一列。
            this.completeView.Scrollable = true;//有滚动条
            this.completeView.HeaderStyle = ColumnHeaderStyle.Clickable;//对表头进行设置
            this.completeView.FullRowSelect = true;//是否可以选择行
            //设置行高40   
            ImageList completeImgList = new ImageList();
            completeImgList.ImageSize = new Size(1, 40);//分别是宽和高
            this.completeView.SmallImageList = completeImgList;   //这里设置listView的SmallImageList ,用imgList将其撑大
            //this.completeView.HotTracking = true;// 当选择此属性时则HoverSelection自动为true和Activation属性为oneClick
            //this.completeView.HoverSelection = true;
            //this.todoView.Activation = ItemActivation.Standard;
            //添加表头
            this.completeView.Columns.Add("", 0);
            this.completeView.Columns.Add("", 280);
            this.completeView.Columns.Add("", 150);

        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        public void initListData()
        {
            var allList = TodoDao.GetAllTodos();
            // init todo data
            todoList = allList.Where(p => !p.Done).OrderByDescending(p => p.AddTime).ToList();
            var itemList = new List<ListViewItem>();
            foreach (var todo in todoList)
            {
                var item = new ListViewItem(new string[] { "", todo.Content, todo.AddTime.ToString(SHORT_TIME_TEMP) });
                //item.SubItems[2].BackColor = Color.Red;
                item.ForeColor = Color.FromArgb(255, 128, 0);
                itemList.Add(item);
            }
            this.todoView.Items.Clear();
            this.todoView.Items.AddRange(itemList.ToArray());

            // init complete data
            itemList.Clear();
            completeList = allList.Where(p => p.Done).OrderByDescending(p => p.CompleteTime).ToList();
            foreach (var complete in completeList)
            {
                var item = new ListViewItem(new string[] { "", complete.Content, complete.CompleteTime.Value.ToString(SHORT_TIME_TEMP) });
                //item.SubItems[2].BackColor = Color.Red;
                item.ForeColor = Color.FromArgb(0, 192, 0);
                itemList.Add(item);
            }
            this.completeView.Items.Clear();
            this.completeView.Items.AddRange(itemList.ToArray());

            //==other method================================================
            //也可以用this.todoView.Items.Add();不过需要在使用的前后添加Begin... 和End...防止界面自动刷新
            // 添加分组
            //this.todoView.Groups.Add(new ListViewGroup("tou"));
            //this.todoView.Groups.Add(new ListViewGroup("wei"));

            //this.todoView.Items[0].Group = this.todoView.Groups[0];
            //this.todoView.Items[1].Group = this.todoView.Groups[1];
            //=====================================================
        }
        #endregion


        /// <summary>
        /// 刷新待办数据
        /// </summary>
        private void RefreshToDoList()
        {
            //todoList.Items.Clear();
            //toDoDataList = TodoDao.GetTodos2();
            //todoList.Items.AddRange(toDoDataList.ToArray());
        }


        #region 事件

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            /*========================example===========================
             * // check pressing the key of [Control + Alt + 0]
             else if ((int)e.Modifiers == ((int)Keys.Control + (int)Keys.Alt)
             * && e.KeyCode == Keys.D0)
             {
                 MessageBox.Show("you press down [Control + Alt + 0]");
             }.
             ===================================================*/

            if (e.KeyCode == Keys.F5)
            {
                //add 
                btnAdd_Click(null, null);
            }
            else if ((int)e.Modifiers == (int)Keys.Shift && e.KeyCode == Keys.C)
            {
                //complete the todo
                btnComplete_Click(null, null);
            }
            else if ((int)e.Modifiers == (int)Keys.Shift && e.KeyCode == Keys.D)
            {
                //close the todo of uncompleted
                btnCloseTodo_Click(null, null);
            }
            else if ((int)e.Modifiers == (int)Keys.Shift && e.KeyCode == Keys.R)
            {
                //restore the todo
                btnRestore_Click(null, null);
            }
            else if ((int)e.Modifiers == (int)Keys.Shift && e.KeyCode == Keys.A)
            {
                //add new todo
                btnAdd_Click(null, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            form.Owner = this;
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                initListData();
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("todo");
        }

        /// <summary>
        /// click coloumn header 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todoView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //sort by column
            //selectTodo = todoList[e.Column];
        }

        /// <summary>
        /// click coloumn header 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void completeView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // selectComplete = completeList[e.Column];
        }

        #endregion

        /// <summary>
        /// complete todo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComplete_Click(object sender, EventArgs e)
        {

            if (selectTodo == null)
            {
                MessageBox.Show("none selected");
                return;
            }

            if (TodoDao.Complete(selectTodo.AddTime))
            {
                selectTodo = null;
                initListData();
            }
            else
            {
                MessageBox.Show("fail");
            }

        }

        /// <summary>
        /// close todo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseTodo_Click(object sender, EventArgs e)
        {
            if (selectTodo == null && selectComplete == null)
            {
                MessageBox.Show("none selected");
                return;
            }

            var todo = selectTodo;
            if (todo == null)
            {
                todo = selectComplete;
            }

            if (MessageBox.Show("确定永久删除[" + todo.Content + "]吗?", "永久删除", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (TodoDao.Delete(todo.AddTime))
                {
                    selectTodo = null;
                    selectComplete = null;
                    initListData();
                }
                else
                {
                    MessageBox.Show("fail");
                }
            }
        }

        /// <summary>
        /// restore todo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestore_Click(object sender, EventArgs e)
        {

            if (selectComplete == null)
            {
                MessageBox.Show("none selected");
                return;
            }

            if (TodoDao.Restore(selectComplete.AddTime))
            {
                selectComplete = null;
                initListData();
            }
            else
            {
                MessageBox.Show("fail");
            }

        }

        /// <summary>
        /// close complete 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseComplete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定彻底删除吗?", "彻底删除", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (selectComplete == null)
                {
                    MessageBox.Show("none selected");
                    return;
                }

                if (TodoDao.Delete(selectComplete.AddTime))
                {
                    selectComplete = null;
                    initListData();
                }
                else
                {
                    MessageBox.Show("fail");
                }
            }
        }

        /// <summary>
        ///  select the item which to do 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todoView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectIndex = todoView.SelectedIndices;
            if (selectIndex != null && selectIndex.Count > 0)
            {
                selectTodo = todoList[selectIndex[0]];
            }
        }

        /// <summary>
        /// select the item completed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void completeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectIndex = completeView.SelectedIndices;
            if (selectIndex != null && selectIndex.Count > 0)
            {
                selectComplete = completeList[selectIndex[0]];
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("快捷键定义如下:\r\n shift + A 添加  \r\n shift + C 完成 \r\n shift + R 恢复  \r\n shift + D 删除", "说明", MessageBoxButtons.OKCancel);
        }

        private void todoView_DoubleClick(object sender, EventArgs e)
        {
            new AddForm(selectTodo).ShowDialog();
        }

        private void completeView_DoubleClick(object sender, EventArgs e)
        {
            new AddForm(selectComplete).ShowDialog();
        }
    }
}
