# Blazor.MVVM
## Why?
While you create a really big component and one of the requests is agile customization, you need to add a way to customize deep nodes for your component. But in the default mechanism its not easily 
I trust that this solution can help you do your components more customizable and great!

## How to use?
Use [AddMVVM](./Blazor.MVVM/Registration.cs) to register all necessary services to your application </br>
Use [MVVMTemplate](./Blazor.MVVM/MVVMTemplate.razor.cs) without ViewModel to register your template in storage  </br>
Use MVVMTemplate with [ViewModel](./Blazor.MVVM/BaseViewModel.cs) to render this on your page 

## Example
In this example, you can see how to use this mechanism  </br>
[Template Registration](./Example/Shared/RegistrateTemplates.razor)  </br>
[View Model](./Example/ViewModels.cs)  </br>
[MVVM Template usage](./Example/Pages/Index.razor)  </br>
