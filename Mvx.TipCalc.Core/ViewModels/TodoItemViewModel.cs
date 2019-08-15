using MvvmCross.ViewModels;

namespace Mvx.TipCalc.Core.ViewModels
{
    public class TodoItemViewModel:MvxViewModel
    {
         string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
                
            }
        }
        
        bool _done;
        public bool Done
        {
            get => _done;
            set
            {
                _done = value;
                RaisePropertyChanged(() => Done);
                
            }
        }
        
        string _id;
        public string Id
        {
            get => _id;
            set
            {
                _id = value;
                RaisePropertyChanged(() => Id);
                
            }
        }
        
        
    }
}