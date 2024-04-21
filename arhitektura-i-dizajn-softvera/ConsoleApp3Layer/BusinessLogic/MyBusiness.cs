using DataAccess;

namespace BusinessLogic
{
    public class MyBusiness
    {
        private readonly ManageData _manageData;

        public MyBusiness()
        {
            _manageData = new ManageData();
        }

        public void ProcessData()
        {
            _manageData.GetData();
            // Code to process data
        }
    }
}
