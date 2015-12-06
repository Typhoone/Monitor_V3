using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor_V3
{
    class FileManager
    {
        List<Log> data;

        public FileManager(List<Log> data)
        {
            this.data = data;
        }
    }
}
