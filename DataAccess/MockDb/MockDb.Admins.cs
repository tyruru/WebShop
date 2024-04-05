using DataAccess.Entities.Users;

namespace DataAccess.MockDb;

public static partial class MockDb
{
   public static Dictionary<int, AdminEntity> Admins = new Dictionary<int, AdminEntity>()
   {
      { 1, new AdminEntity(1, "Admin", "12345") }
   };
}