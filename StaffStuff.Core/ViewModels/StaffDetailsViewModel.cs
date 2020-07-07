using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using StaffStuff.Core.Models;
using System.Threading.Tasks;

namespace StaffStuff.Core.ViewModels
{
    public class StaffDetailsViewModel : MvxViewModel<Employee>
    {
        private readonly IMvxNavigationService _navigationService;

        public IMvxAsyncCommand GoBackCommand => new MvxAsyncCommand(GoBack);

        public StaffDetailsViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private Employee _employee;
        public Employee Employee
        {
            get => _employee;
            set => SetProperty(ref _employee, value);
        }

        public override void Prepare(Employee parameter)
        {
            Employee = parameter;
        }

        private async Task GoBack()
        {
            await _navigationService.Close(this);
        }
    }
}
