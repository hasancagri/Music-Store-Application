#pragma checksum "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf93051b5d1adaa5d4ce787586f49f3a9d6554e3"
// <auto-generated/>
#pragma warning disable 1591
namespace MusicStore_blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using MusicStore_blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using MusicStore_blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using MusicStore_blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using MusicStore_blazor.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using MusicStore_blazor.Stores.AlbumStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\_Imports.razor"
using MusicStore_blazor.Utilities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\Pages\Login.razor"
                 UserForLoginDto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\Pages\Login.razor"
                                                 LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "<label for=\"title\">Title</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "Type", "email");
                __builder2.AddAttribute(11, "Class", "form-control");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\Pages\Login.razor"
                                UserForLoginDto.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserForLoginDto.Email = __value, UserForLoginDto.Email))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserForLoginDto.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __Blazor.MusicStore_blazor.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 16, 17, 
#nullable restore
#line 12 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\Pages\Login.razor"
                                  ()=>UserForLoginDto.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label for=\"password\">Password</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "Type", "password");
                __builder2.AddAttribute(24, "Class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\Pages\Login.razor"
                                UserForLoginDto.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserForLoginDto.Password = __value, UserForLoginDto.Password))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserForLoginDto.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __Blazor.MusicStore_blazor.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 29, 30, 
#nullable restore
#line 17 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\Pages\Login.razor"
                                  ()=>UserForLoginDto.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.AddMarkupContent(32, "<button class=\"btn btn-primary\" type=\"submit\">Login</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\Pages\Login.razor"
       
    UserForLoginDto UserForLoginDto = new UserForLoginDto();
    public async Task LoginUser()
    {
        try
        {
            AccessToken accessToken = await AuthService.Login(UserForLoginDto);
            await localStorage.SetItemAsync<string>("token", accessToken.Token);
            NavigationManager.NavigateTo("/dashboard");
        }
        catch
        {
            await jsRuntime.InvokeVoidAsync("alert", "Login İşlemi Esnasında Hata Meydana Geldi!");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
namespace __Blazor.MusicStore_blazor.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
