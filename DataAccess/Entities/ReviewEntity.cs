namespace DataAccess.Entities;

public class ReviewEntity
{
    public int Id { get; }
    public float Grade { get; }
    public string Text { get; }
    public int UserId { get; }

    public ReviewEntity(int id, float grade, string text, int userId)
    {
        Id = id;
        Grade = grade;
        Text = text;
        UserId = userId;
    }
}