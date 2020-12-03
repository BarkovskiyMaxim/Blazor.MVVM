# Blazor.MVVM

## How to use?
Use [AddMVVM](./Blazor.MVVM/Registration.cs) to register all necessary services to your application </br>
Use [MVVMTemplate](./Blazor.MVVM/MVVMTemplate.razor.cs) without ViewModel to register your template in storage  </br>
Use MVVMTemplate with [ViewModel](./Blazor.MVVM/BaseViewModel.cs) to render this on your page 

## Example
In this example, you can see how to use this mechanism  </br>
[Template Registration](./Example/Shared/RegistrateTemplates.razor)  </br>
[View Model](./Example/ViewModels.cs)  </br>
[MVVM Template usage](./Example/Pages/Index.razor)  </br>
