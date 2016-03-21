using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustDo.Model
{
    /// <summary>
    /// model of todo 
    /// </summary>
    public class ToDoModel
    {
        /// <summary>
        /// what the content?
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// the time of add
        /// </summary>
        public DateTime AddTime { get; set; }

        /// <summary>
        /// the time of complete
        /// </summary>
        public DateTime? CompleteTime { get; set; }

        /// <summary>
        /// has do
        /// </summary>
        public bool Done { get; set; }
    }
}
