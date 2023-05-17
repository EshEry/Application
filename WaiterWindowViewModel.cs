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

namespace Practica.ViewModel
{
    public class WaiterWindowViewModel : BaseViewModel

    {
        private RelayCommand _addOrder;

        public RelayCommand AddOrder
        {
            get
            {
                return _addOrder ??
                (_addOrder = new RelayCommand(x =>
                {
                    CreateOrder create = new CreateOrder();
                    create.Show();
                }));
            }

        }

        private RelayCommand _changedStatus;
        public RelayCommand ChangedStatus
        {
            get
            {
                return _changedStatus ??
                    (_changedStatus = new RelayCommand(x =>
                    {
                        Cafe_2Context context = new Cafe_2Context();
                        if (x is Order order)
                        {
                            context.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                            if (order.IdStatusOrder == 4)
                            {
                                order.IdStatusOrder = 3;
                                order.IdStatusOrderNavigation = context.StatusOrders.Find(3);
                            }
                            else
                            {
                                order.IdStatusOrder = 4;
                                order.IdStatusOrderNavigation = context.StatusOrders.Find(4);
                            }
                        }
                        context.SaveChanges();
                        Orders = new ObservableCollection<Order>(context.Orders);
                    }));
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
        private ObservableCollection<StatusOrder> _statusOrders;
        public ObservableCollection<StatusOrder> StatusOrders
        {
            get => _statusOrders;
            set
            {
                _statusOrders=value;
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


        public WaiterWindowViewModel()
        {
            Cafe_2Context context = new Cafe_2Context();
            _orders = new ObservableCollection<Order>(context.Orders);
            _order = new Order();

            _dishes = new ObservableCollection<Dish>(context.Dishes);

            _statusOrders = new ObservableCollection<StatusOrder>(context.StatusOrders);
            _statusOrder = new StatusOrder();
        }


    }


}
