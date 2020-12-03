using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Blazor.MVVM.Services;
using Blazor.MVVM.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Blazor.MVVM {
    public partial class MVVMTemplate<TIn> : ComponentBase, IDisposable where TIn : BaseViewModel {
        [Parameter]
        public TIn ViewModel { get; set; }
        [Parameter]
        public bool Replace { get; set; } = false;
        [Parameter]
        public RenderFragment<TIn> ChildContent { get; set; }
        [Parameter]
        public string Name { get; set; }
        [Inject]
        ITemplateStorage engine { get; set; }
        bool Render { get; set; }

        RenderFragment<TIn> Template {
            get {
                return engine.GetTemplate<TIn>(Name);
            }
        }

        protected override Task OnParametersSetAsync() {
            Render = ViewModel != null;
            if(!Render) {
                if(Replace)
                    engine.ReplaceTemplate(Name, ChildContent);
                else
                    engine.AddTemplate(Name, ChildContent);
            }
            return base.OnParametersSetAsync();
        }

        protected override async Task OnInitializedAsync() {
            if(ViewModel != null)
                ViewModel.ChangeState += Call_ChangeState;
            await base.OnInitializedAsync();
        }

        void Call_ChangeState(object sender, EventArgs e) {
            StateHasChanged();
        }

        public void Dispose() {
            if(ViewModel != null)
                ViewModel.ChangeState -= Call_ChangeState;
        }
    }
}
