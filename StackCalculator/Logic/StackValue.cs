using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator.Logic
{
    class StackValue
    {
        private string content;
        public string Value {
            get
            {
                return content;
            }
            set
            {
                content = value;
                FormatContent();
            }
        }

        private void FormatContent()
        {
           if(content.Length > 1 && content.StartsWith("0"))
            {
                content = content.Substring(1);
            }
        }

        public StackValue(int initValue)
        {
            this.Value = initValue.ToString();
        }

        public StackValue(string initValue)
        {
            this.Value = initValue;
        }      

        public override string ToString() {
            return content;
        }
    }
}
