namespace BlazorToDo.Classes
{
    public class ToDoItem
    {
        public static ToDoItem Default { get; } = new ToDoItem(0, "", Category.Default);
        public int toDoID { get; set; }
        public string toDo { get; set; }
        public Category category { get; set; }
        public ToDoItem(int toDoID, string toDo, Category category)
        {
            this.toDoID = toDoID;
            this.toDo = toDo;
            this.category = category;
        }
        public ToDoItem(int toDoID, string toDo, int categoryID, string category)
        {
            this.toDoID = toDoID;
            this.toDo = toDo;
            this.category = new Category(categoryID, category);
        }
        public void clear()
        {
            toDoID = Default.toDoID;
            category.clear();
            toDo = Default.toDo;
        }
        public void clearInternal()
        {
            toDoID = Default.toDoID;
            category.clearInternal();
            toDo = Default.toDo;
        }
        public ToDoItem copy()
        {
            return new ToDoItem(this.toDoID, this.toDo, this.category.copy());
        }
    }
}
