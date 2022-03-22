using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Exceptions
{
  public class OperationFaildedException :Exception
    {
        public OperationFaildedException() :base ("Operation Faild")
        {

        }
    }
}
