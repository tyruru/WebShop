using DataAccess.Entities.Users;

namespace DataAccess.MockDb;

public static partial class MockDb_Operators
{
    public static Dictionary<int, OperatorEntity> Operators = new Dictionary<int, OperatorEntity>()
    {
        {1, new OperatorEntity(1, "Operator1", "12345")}
    };
}