using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedCode;


namespace OopsConcpets
{
    class UsingCLasslibrary
    {
        public void ReadDatatable()
        {
           DatabaseUtility db = new DatabaseUtility(); //with out namespace
           SharedCode.DatabaseUtility db2 = new SharedCode.DatabaseUtility(); //with namespace
           db.SaveData();

        }


    }
}
