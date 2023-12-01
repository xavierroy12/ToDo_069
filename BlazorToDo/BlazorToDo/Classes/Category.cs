using BlazorToDo.Components;

namespace BlazorToDo.Classes
{
    public class Category
    {
        public static Category Default { get; } = new Category(1, "");
        public static Category DefaultInternal { get; set; } = Default;
        public int Id { get; set; }
        public string name { get; set; }
        public Category(int id, string name)
        {
            this.Id = id;
            this.name = name;
        }
        public void clear()
        {
            Id = Default.Id;
            name = Default.name;
        }
        public void clearInternal()
        {
            Id = DefaultInternal.Id;
            name = DefaultInternal.name;
        }
        public Category copy() 
        { 
            return new Category(this.Id, this.name);
        }
    }
}
