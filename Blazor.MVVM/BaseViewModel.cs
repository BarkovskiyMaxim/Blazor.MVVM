using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Blazor.MVVM.ViewModels {
    public class BaseViewModel {
        public event EventHandler ChangeState;

        public void InvokeChangeState() {
            ChangeState?.Invoke(this, new EventArgs());
        }
    }
}
