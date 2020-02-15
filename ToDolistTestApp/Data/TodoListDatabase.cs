using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using ToDolistTestApp.Models;

namespace ToDolistTestApp.Data
{
    public class TodoDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public TodoDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Todo>().Wait();
        }

        public Task<List<Todo>> GetNotesAsync()
        {
            return _database.Table<Todo>().ToListAsync();
        }

        public Task<Todo> GetNoteAsync(int id)
        {
            return _database.Table<Todo>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Todo todo)
        {
            if (todo.ID != 0)
            {
                return _database.UpdateAsync(todo);
            }
            else
            {
                return _database.InsertAsync(todo);
            }
        }

        public Task<int> DeleteNoteAsync(Todo todo)
        {
            return _database.DeleteAsync(todo);
        }
    }
}
