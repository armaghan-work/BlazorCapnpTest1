#pragma checksum "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\Setting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee36d02946a2edf69ac2fc32467524cd43cedd68"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blzCapnp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using blzCapnp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using blzCapnp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using NetMQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using NetMQ.Sockets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\Setting.razor"
using Core.Share;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\Setting.razor"
using blzCapnp.Services.Github;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/setting")]
    public partial class Setting : Shared.BasePage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\Setting.razor"
       

    Boolean value;

    private string somePath = string.Empty;

    void Change(bool value)
    {
        // do something
    }



    //somePath = UserSetting.MonicaParametersPathOnGithub;



    async Task GithubPathValidation()
    {
        if (!string.IsNullOrWhiteSpace(somePath))
        {

            string repoPath = GithubService.GetRepoResultPath(somePath);
            UserSetting.MonicaPathOnGitIsValid = GithubService.PathValidator(UserSetting.MonicaResultsPathOnGithub, UserSetting.GithubUserName, UserSetting.GithubPassword, repoPath);
            await SaveUserSettingsInLocalStorageAsync();
        }
    }

    async Task PathChangedAsync()
    {
        UserSetting.MonicaPathOnGitIsValid = false;
        await SaveUserSettingsInLocalStorageAsync();
    }

    async Task UpdateLocalStorageSettingsAsync()
    {
        await SaveUserSettingsInLocalStorageAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGithubService GithubService { get; set; }
    }
}
#pragma warning restore 1591
