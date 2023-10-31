namespace Laboratorium_3___Post_App.Models
{
    public interface IPostService
    {
        int Add(Post book);
        void Delete(int id);
        void Update(Post book);
        List<Post> FindAll();
        Post? FindById(int id);
    }
}
