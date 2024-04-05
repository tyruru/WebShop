using DataAccess.Entities;

namespace DataAccess.MockDb;

public static partial class MockDb
{
    public static Dictionary<int, ProductEntity> Products = new Dictionary<int, ProductEntity>()
    {
        {1, new ProductEntity(1, "Product1", "Description1", 250f, new List<ReviewEntity>(){new ReviewEntity(1, 4.5f, "Text1", 0, "User1")}) },
        {2, new ProductEntity(2, "Product2", "Description2", 350f, new List<ReviewEntity>(){new ReviewEntity (2, 5f, "Text2", 2, "User2")}) },
        {3, new ProductEntity(3, "Product3", "Description3", 1500f, new List<ReviewEntity>(){new ReviewEntity(3, 4.2f, "Text3", 3, "User3")}) },
        {4, new ProductEntity(4, "Product4", "Description4", 999.99f, new List<ReviewEntity>(){new ReviewEntity(4, 3f, "Text4", 1, "User4")})},
        {5, new ProductEntity(5, "Product5", "Description5", 100f, new List<ReviewEntity>(){new ReviewEntity(4, 3f, "Text5", 1, "User4")})}
    };
}