using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor.MVVM.ViewModels;
using Microsoft.AspNetCore.SignalR;

namespace Example {
    public class RootViewModel : BaseViewModel {
        public EndlessChildrenViewModel Child { get { return new EndlessChildrenViewModel(); } }
    }

    public class EndlessChildrenViewModel: BaseViewModel {
        public EndlessChildrenViewModel Child { get { return new EndlessChildrenViewModel(); } }
    }
}
