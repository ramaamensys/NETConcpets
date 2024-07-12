using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCode
{
    internal class ChildClassSample : ExcelUtility
    {
        public void ChildMethod1()
        {
            ExcelUtility excelUtility = new ExcelUtility();


            ChildClassSample childclass = new ChildClassSample();
            childclass.delExcelData(); //accessing protected method through child class
            childclass.getRowData();  //acces through child class object

        }
    }
}
