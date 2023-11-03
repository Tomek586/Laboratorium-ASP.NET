namespace Laboratorium_3___Post_App.Models
{
    public class MemoryPostService : IPostService
    {
        private Dictionary<int, Post> _items = new Dictionary<int, Post>();
        private readonly IDateTimeProvider _dateTimeProvider;
        public MemoryPostService(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
            
        }
        public int Add(Post item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            item.Created = _dateTimeProvider.GetDateTime();
            _items.Add(item.Id, item);
            return item.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Post> FindAll()
        {
            return _items.Values.ToList();
        }

        public Post? FindById(int id)
        {
            return _items[id];
        }

        public void Update(Post item)
        {
            _items[item.Id] = item;
        }
    }
}
