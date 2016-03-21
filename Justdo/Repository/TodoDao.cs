using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using JustDo.Model;
using JustDo.Utility;

namespace JustDo.Repository
{
    public static class TodoDao
    {
        private static string treePath = Tool.GetResoucePath("/Resources/Data/todo.xml");
        public static string TIME_TEMP = "yyyy-MM-dd HH:mm:ss";

        #region 读取待办
        /// <summary>
        /// 获取待办
        /// </summary>
        /// <param name="deadline"></param>
        /// <returns></returns>
        public static ToDoModel Get(DateTime addTime)
        {
            ToDoModel result = null;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(treePath);
            var xmlPath = "/Todos/Todo[AddTime='" + addTime.ToString(TIME_TEMP) + "']";
            XmlNode node = xmlDoc.SelectSingleNode(xmlPath);
            if (node != null)
            {
                result = parseNoteNode(node);
            }
            return result;
        }
        #endregion

        #region  获取所有待办
        /// <summary>
        /// 获取所有待办
        /// </summary>
        /// <returns></returns>
        public static List<ToDoModel> GetAllTodos()
        {
            var result = new List<ToDoModel>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(treePath);
            XmlNodeList todoList = xmlDoc.SelectNodes("/Todos/Todo");
            foreach (XmlNode node in todoList)
            {
                result.Add(parseNoteNode(node));
            }
            return result;
        }
        #endregion

        #region 添加待办

        /// <summary>
        /// 添加待办
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Add(ToDoModel model)
        {
            try
            {
                var xPath = "/Todos";
                var nodeName = "Todo";
                var innerXml = string.Format(@"<AddTime>{0}</AddTime>" +
                                         "<Content><![CDATA[{1}]]> </Content>",
                                         model.AddTime.ToString(TIME_TEMP), model.Content);
                var attrName = "Done";
                var attrValue = "0";
                return XMLHelper.CreateXmlNodeByXPath(treePath, xPath, nodeName, innerXml, attrName, attrValue);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region 完成待办
        /// <summary>
        /// 完成待办
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool Complete(DateTime addTime)
        {
            try
            {
                var xmlPath = "/Todos/Todo[@Done=0][AddTime='" + addTime.ToString(TIME_TEMP) + "']";
                var xmlAttributeName = "Done";
                var xmlAttributeValue = "1";
                if (XMLHelper.CreateOrUpdateXmlAttributeByXPath(treePath, xmlPath, xmlAttributeName, xmlAttributeValue)) {
                     xmlPath = "/Todos/Todo[AddTime='" + addTime.ToString(TIME_TEMP) + "']";
                     var xmlNodeName = "CompleteTime";
                     var xmlNodeValue = DateTime.Now.ToString(TIME_TEMP);
                     return XMLHelper.CreateOrUpdateXmlNodeByXPath(treePath, xmlPath, xmlNodeName, xmlNodeValue);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        #endregion

        #region 删除待办
        /// <summary>
        /// 删除待办
        /// </summary>
        /// <param name="deadline"></param>
        /// <returns></returns>
        public static bool Delete(DateTime addTime)
        {
           var xmlPath = "/Todos/Todo[AddTime='" + addTime.ToString(TIME_TEMP) + "']";
           return XMLHelper.DeleteXmlNodeByXPath(treePath, xmlPath);
        }
        #endregion

        #region 恢复待办
        /// <summary>
        /// 恢复待办
        /// </summary>
        /// <param name="addTime"></param>
        /// <returns></returns>
        public static bool Restore(DateTime addTime) {
            try
            {
                var xmlPath = "/Todos/Todo[AddTime='" + addTime.ToString(TIME_TEMP) + "']";
                var xmlAttributeName = "Done";
                var xmlAttributeValue = "0";
                return XMLHelper.CreateOrUpdateXmlAttributeByXPath(treePath, xmlPath, xmlAttributeName, xmlAttributeValue);
            }
            catch (Exception ex)
            {
                return false;
            }
        } 

        #endregion

        #region 解析待办
        /// <summary>
        /// 解析 XmlNode 为 model
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private static ToDoModel parseNoteNode(XmlNode node)
        {
            var completeTime =node.SelectSingleNode("CompleteTime").GetInnerText();
            var addTime = node.SelectSingleNode("AddTime").GetInnerText();

             var model =new ToDoModel()
            {
                AddTime =DateTime.Parse(addTime),
                Content = node.SelectSingleNode("Content").GetInnerText(),
                Done = node.GetAttribute("Done", "0") == "1"
            };

            if(!string.IsNullOrEmpty(completeTime)){
                model.CompleteTime =DateTime.Parse(completeTime);
            }
            return model;
        }
        #endregion 
    }
}
