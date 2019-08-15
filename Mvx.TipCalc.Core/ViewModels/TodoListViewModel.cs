using MvvmCross.ViewModels;

namespace Mvx.TipCalc.Core.ViewModels
{
    public class TodoListViewModel: MvxViewModel
    {
        private MvxObservableCollection<TodoItemViewModel> _todoItems;
        public MvxObservableCollection<TodoItemViewModel> TodoItems
        {
            get => _todoItems;
            set
            {
                _todoItems = value;
                RaisePropertyChanged(() => TodoItems);
            }
        }
    }
}