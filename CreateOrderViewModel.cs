using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleWpf;
using Practica_2.View;
using System.Collections.ObjectModel;
using Practica_2.ViewModel;
using Practica_2;

namespace Practica_2.ViewModel
{
    public class CreateOrderViewModel : BaseViewModel
    {


        private RelayCommand _createOrder;
        public RelayCommand CreateOrder
        {
            get
            {
                return _createOrder ??
                (_createOrder = new RelayCommand(x =>
                {
                    Cafe_2Context context = new Cafe_2Context();
                    Order order = Order;
                    order.IdStatusOrder = StatusOrder.IdStatusOrder;
                    order.IdPlace = Place.IdPlace;
                    order.IdDish = Dish.IdDish;
                   
                    context.Orders.Add(order);
                    context.SaveChanges();
                    Orders = new ObservableCollection<Order>(context.Orders);

                }
                ));
            }
        }
        private Order _order;
        public Order Order
        {
            get => _order;
            set
            {
                _order = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<Order> _orders;
        public ObservableCollection<Order> Orders
        {
            get => _orders;
            set
            {
                _orders = value;
                OnPropertyChanged();
            }
        }



        private ObservableCollection<StatusOrder> _statusOrders;
        public ObservableCollection<StatusOrder> StatusOrders
        {
            get => _statusOrders;
            set
            {
                _statusOrders = value;
                OnPropertyChanged();
            }
        }
        private StatusOrder _statusOrder;
        public StatusOrder StatusOrder
        {
            get => _statusOrder;
            set
            {
                _statusOrder = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Place> _places;
        public ObservableCollection<Place> Places
        {
            get => _places;
            set
            {
                _places = value;
                OnPropertyChanged();
            }
        }
        private Place _place;
        public Place Place
        {
            get => _place;
            set
            {
                _place = value;
                OnPropertyChanged();
            }
        }
       



        private ObservableCollection<Dish> _dishes;
        public ObservableCollection<Dish> Dishes
        {
            get => _dishes;
            set
            {
                _dishes = value;
                OnPropertyChanged();
            }
        }
        private Dish _dish;
        public Dish Dish
        {
            get => _dish;
            set
            {
                _dish = value;
                OnPropertyChanged();
            }
        }
        public CreateOrderViewModel()
        {
            Cafe_2Context context = new Cafe_2Context();

            _dishes = new ObservableCollection<Dish>(context.Dishes);

            _statusOrders = new ObservableCollection<StatusOrder>(context.StatusOrders);

            _places = new ObservableCollection<Place>(context.Places);
            _order = new Order();
        }
    }
}
