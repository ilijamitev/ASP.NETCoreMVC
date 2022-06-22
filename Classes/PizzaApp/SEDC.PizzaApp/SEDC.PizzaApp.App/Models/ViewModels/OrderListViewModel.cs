namespace SEDC.PizzaApp.App.Models.ViewModels
{
    public class OrderListViewModel
    {
        public string PizzaName { get; set; }
        public string UserFullName { get; set; }

        public OrderListViewModel() { }
        public OrderListViewModel(string pizzaName, string userFullName)
        {
            PizzaName = pizzaName;
            UserFullName = userFullName;
        }
    }
}
