using Google_Sheets_API_.NET_Quickstart.Read;
using Google_Sheets_API_.NET_Quickstart.Write;

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
