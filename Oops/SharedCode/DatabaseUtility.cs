namespace SharedCode
{
    public class DatabaseUtility
    {
        public void SaveData()
        {
            ExcelUtility ex1 = new ExcelUtility();
            ex1.UpdateExcel();
            ex1.path = "test1";
            ex1.getRowData(); //access protected internal method with in same assembley.
        }

        public void ReadData()
        {

        }

    }
}