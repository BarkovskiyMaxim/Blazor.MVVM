using System;
using System.Collections.Generic;
using System.Text;
using Blazor.MVVM.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Blazor.MVVM.Services {
    public interface ITemplateStorage {
        void AddTemplate<T>(string name, RenderFragment<T> fragment) where T : BaseViewModel;
        void ReplaceTemplate<T>(string name, RenderFragment<T> fragment) where T : BaseViewModel;
        RenderFragment<T> GetTemplate<T>(string name) where T: BaseViewModel;
    }

    public class TemplateStorage : ITemplateStorage {
        readonly Dictionary<string, object> templates = new Dictionary<string, object>();
        public void AddTemplate<T>(string name, RenderFragment<T> fragment) where T : BaseViewModel {
            if(!templates.ContainsKey(name))
                templates.Add(name, fragment.Clone());
        }

        public RenderFragment<T> GetTemplate<T>(string name) where T : BaseViewModel {
            if(templates.ContainsKey(name)) {
                return templates[name] as RenderFragment<T>;
            } else {
                return (model) => null;
            }
        }

        public void ReplaceTemplate<T>(string name, RenderFragment<T> fragment) where T : BaseViewModel {
            templates[name] = fragment.Clone();
        }
    }
}
