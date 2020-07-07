using MvvmCross;
using MvvmCross.ViewModels;
using StaffStuff.Core.Services;
using StaffStuff.Core.ViewModels;

namespace StaffStuff.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            Mvx.IoCProvider.RegisterSingleton<IStaffData>(new StaffData());

            RegisterAppStart<StaffViewModel>();
        }
    }
}
