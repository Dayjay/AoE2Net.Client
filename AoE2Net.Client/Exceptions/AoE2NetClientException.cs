using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoE2Net.Client.Exceptions
{
    public class AoE2NetClientException : Exception
    {
        public AoE2NetClientException() 
        { 
        }

        public AoE2NetClientException(string message) : base(message)
        {
        }
        public AoE2NetClientException(string message, Exception inner) : base(message, inner)
        {
        }

        public override string HelpLink
        {
            get
            {
                return "You can get more information here: https://github.com/Dayjay/AoE2Net.Client";
            }
        }
    }
}
