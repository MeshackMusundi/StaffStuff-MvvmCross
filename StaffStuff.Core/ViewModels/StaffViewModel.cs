using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using StaffStuff.Core.Models;
using StaffStuff.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StaffStuff.Core.ViewModels
{
    public class StaffViewModel : MvxViewModel
    {
        private List<Employee> _employees;
        public List<Employee> Employees
        {
            get => _employees;
            set => SetProperty(ref _employees, value);
        }

        private readonly IStaffData _staffData;
        private readonly IMvxNavigationService _navigationService;
        public IMvxAsyncCommand<Employee> EmployeeDetailsCommand => new MvxAsyncCommand<Employee>(StaffDetails);

        public StaffViewModel(IStaffData staffData, IMvxNavigationService navigationService)
        {
            _staffData = staffData;
            _navigationService = navigationService;
        }

        private async Task StaffDetails(Employee employee)
        {
            await _navigationService.Navigate<StaffDetailsViewModel, Employee>(employee);
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            Employees = _staffData.GetEmployees();
        }
    }
}
