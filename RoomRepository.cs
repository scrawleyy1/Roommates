using Roommates.Repositories;

namespace Roommates
{
    internal class RoomRepository : ChoreRepository
    {
        public RoomRepository(string connectionString) : base(connectionString)
        {
        }
    }
}