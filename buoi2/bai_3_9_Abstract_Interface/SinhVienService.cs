using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_9_Abstract_Interface
{
    internal class SinhVienService : ISinhVienService
    {
        //1 lớp có thể Implement nhiều interface
        public void suaSV()
        {
            throw new NotImplementedException();
        }

        public void themSV()
        {
            throw new NotImplementedException();
        }
    }
}
