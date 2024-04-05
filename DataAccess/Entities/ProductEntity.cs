namespace DataAccess.Entities;

public sealed class ProductEntity
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get;}
    public float Price { get; }
    public List<ReviewEntity> Reviews { get;}

    public ProductEntity(int id, string name, string description, float price, List<ReviewEntity> reviews)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Reviews = reviews;
    }
    
    public ProductEntity(int id, string name, string description, float price)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Reviews = new List<ReviewEntity>();
    }
}