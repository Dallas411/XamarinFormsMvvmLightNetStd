using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using XfMvvmLnetStd.Interface;
using XfMvvmLnetStd.Service;
using XfMvvmLnetStd.ViewModel;

namespace XfMvvmLnetStd
{
    public class Locator
    {
        public Locator()
        {
            // ViewModels
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<DetailViewModel>();

            // Services
            SimpleIoc.Default.Register<IPeopleService, PeopleServiceStub>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainViewModel Main
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public DetailViewModel Detail
        {
            get
            {
                return SimpleIoc.Default.GetInstance<DetailViewModel>();
            }
        }
    }
}
