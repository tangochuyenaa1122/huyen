using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_9_Abstract_Interface
{
    public interface ISinhVienService
    {
        /*
         * trong interface ko đc private
         * tên interface luôn đi kèm với tên service và có chữ i đứng đầu
         * các phương thức trong interface luôn là public và là dạng abstract
         */
        void suaSV();
        void themSV();
        
    }
}
