using GoogleSheets.Read;
using GoogleSheets.Write;

namespace SheetsQuickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            var read = new simpleReadExample();
            read.readData();

            //var insert = new insertExample();
            //insert.insertData();

            //var update = new updateExample();
            //update.updateData();

            //var delete = new deleteExample();
            //delete.deleteData();

        }
    }
}
