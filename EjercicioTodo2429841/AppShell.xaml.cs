using EjercicioTodo2429841.Views;

namespace EjercicioTodo2429841
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
        }
    }
}
