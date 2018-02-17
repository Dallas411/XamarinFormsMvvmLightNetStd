﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XfMvvmLnetStd.Model;

namespace XfMvvmLnetStd.ViewModel
{
    public class DetailViewModel : ViewModelBase
    {
        public DetailViewModel()
        {
            ClickMeCallBackAction = () => { };
            ClickMeCommand = new RelayCommand(() => ClickMeCallBackAction());
        }

        public ICommand ClickMeCommand { get; set; }
        public Person Person { get; set; }

        public Action ClickMeCallBackAction { get; set; }
    }
}
