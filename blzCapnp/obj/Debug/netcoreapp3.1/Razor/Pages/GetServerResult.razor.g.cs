#pragma checksum "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df4b9a746d3e004f488429a42ce18a335344a697"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
using blzCapnp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
using NetMQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
using Core.Share;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/GetServerResult")]
    public partial class GetServerResult : Shared.BasePage
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Recive ENV via ZMQ</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary m-2");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
                                              GetMassage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Recieve message from server and put in CSV");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 17 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
 if (gotAnswer)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "p");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "href", 
#nullable restore
#line 19 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
                 csvLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, "Download CSV file");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 20 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, 
#nullable restore
#line 23 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
        csvLink

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 24 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "class", "fixwidth");
            __builder.AddContent(18, 
#nullable restore
#line 25 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
                     answer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\armaghan\source\repos\blzCapnp\blzCapnp\Pages\GetServerResult.razor"
       

    Boolean gotAnswer = false;
    public string answer { get; set; } = " ";
    private string csvLink { get; set; } = " ";
    private string repositoryPathToExport = "";


    /// <summary>
    /// //////////////////   IN CONSUMER SHOULD CHECK TO STOR DATA ON GITHUB ONLY IF USER PROVIDES HIS GITHUB!
    /// </summary>
    /// <returns></returns>

    async Task GetMassage() // call ZmqProducer calss
    {

        //RunConsumer();

        using (var consumer = new PullSocket())
        //using (var producer = new RequestSocket())
        {
            //consumer.Connect("tcp://localhost:7777");
            consumer.Connect(UserSetting.ServerPullAddress + ":" + UserSetting.ServerPullPort);
            answer = consumer.ReceiveFrameString();

            System.Threading.Thread.Sleep(2000);
            gotAnswer = true;
            consumer.Disconnect(UserSetting.ServerPullAddress + ":" + UserSetting.ServerPullPort);

            // create path
            string fileName = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string filePath = "wwwroot/export/" + fileName;

            //write the answer into a file
            string jsonFile = (filePath + ".json");

            if (!File.Exists(jsonFile))
                File.WriteAllText(jsonFile, answer);


            // call runConsumer Method(). get ths csv path and csv string, remove wwwroot from path and use the link in razor section

            string csvLinkLong = "";
            string csvContent = "";//ZmqConsumer.RunConsumer(answer, filePath, out csvLinkLong);

            //write csv in Folder
            if (!File.Exists(csvLink))
                File.WriteAllText(csvLink, csvContent);

            csvLink = csvLinkLong.Substring(csvLinkLong.IndexOf("/"));

            //commit the Json and CSV file
            GithubService.CommitOnGit(fileName, answer, csvContent, UserSetting.GithubUserName, UserSetting.GithubPassword, UserSetting.MonicaResultsPathOnGithub);

            System.Threading.Thread.Sleep(1500);
            NavigationManager.NavigateTo("/monicaCharts/monicaChart");

        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ZmqConsumer ZmqConsumer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private blzCapnp.Services.Github.IGithubService GithubService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
