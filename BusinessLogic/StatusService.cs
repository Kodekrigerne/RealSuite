using DataAccess;

namespace BusinessLogic
{
    public class StatusService
    {
        StatusDBService statusDBService = new StatusDBService();

        public bool DbCheck()
        {
            return statusDBService.DbCheck();
        }
    }
}
