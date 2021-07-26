// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletealbum/{albumId:int}")]
    public partial class DeleteAlbum : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\Kodlar\Music Store Application\frontend\blazor\MusicStore-blazor\MusicStore-blazor\Pages\DeleteAlbum.razor"
       
    [Parameter]
    public int AlbumId { get; set; }

    AlbumDeleteForDto AlbumDeleteForDto;
    protected override async Task OnInitializedAsync()
    {
        var token = await localStorage.GetItemAsync<string>("token");
        AlbumDeleteForDto = await AlbumService.GetByIdForDeleting(AlbumId, token);
    }

    public async Task Delete()
    {
        var token = await localStorage.GetItemAsync<string>("token");
        await AlbumService.Delete(AlbumDeleteForDto, token);
        NavigationManager.NavigateTo("/dashboard");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlbumService AlbumService { get; set; }
    }
}
#pragma warning restore 1591
