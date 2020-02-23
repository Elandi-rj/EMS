using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Logic
{
    public enum StateEnum
    {
        Fail,
        Success
    }
    public class State<T>
    {
        public StateEnum StateResult { get; set; }

        public T Data { get; set; }
    }
}
