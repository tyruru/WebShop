using DataAccess.Entities;

namespace DataAccess.MockDb;

public static partial class MockDb
{
    public static Dictionary<int, List<ReviewEntity>> Reviews = new Dictionary<int, List<ReviewEntity>>()
    {
        { 1, new List<ReviewEntity>(){new ReviewEntity(1, 4.5f, "Text1", 1)}},
        { 2, new List<ReviewEntity>(){new ReviewEntity (2, 5f, "Text2", 2)}},
        { 3, new List<ReviewEntity>(){new ReviewEntity(3, 4.2f, "Text3", 3)}},
        { 4, new List<ReviewEntity>(){new ReviewEntity(4, 3f, "Text4", 1)}},
    };
}