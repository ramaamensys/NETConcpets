using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCode
{
    internal class ExcelUtility
    {
        private int filesize;
        public string path;
        DateTime dob;

        protected internal void getRowData()
        {

        }

        protected void delExcelData()
        {

        }

        void getExcelData()
        {

        }

        public void UpdateExcel()
        {
            SaveExcel();
            path = "test2";
            dob = DateTime.Now;
            getRowData(); //access with in the same class
        }

        private void SaveExcel()
        {

        }
    }
}
