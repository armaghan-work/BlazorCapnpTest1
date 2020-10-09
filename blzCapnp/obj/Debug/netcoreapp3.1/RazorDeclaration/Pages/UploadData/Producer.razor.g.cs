#pragma checksum "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Producer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "263973e3f75043752ab7d384632aeb61889ba154"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blzZmq1.Pages.UploadData
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using blzZmq1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using blzZmq1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using NetMQ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using NetMQ.Sockets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Producer.razor"
using blzZmq1.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Producer.razor"
using blzZmq1.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Producer.razor"
using blzZmq1.Services.ChartData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Producer.razor"
using Core.Daily;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Producer.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chartdata/charthistory")]
    public partial class Producer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\armaghan\source\repos\blzZmq1\blzZmq1\Pages\UploadData\Producer.razor"
          
        int selectedButton;
        string str;
        string filesTable = "";
        int dirsLenght;
        string[] dirs;
        long length;


        private long GetTheLength()
        {
            length = new System.IO.FileInfo(System.IO.Path.GetFullPath(_selectedFile)).Length / 1024;
            return (length);
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            dirs = Directory.GetFiles(@"wwwroot/export/", "*.json");
            dirsLenght = dirs.Length;
        }


        private enum ChartType { None, Daily };
        private bool isLoading = true;
        //private DailyData _dailyData = null;
        private ChartType _chartType = ChartType.None;
        private string _selectedFile;
        private string chartjson;

        //public string jsonToChartPath = "Data/fromServer.json";
        public string jsonToChartPath = "wwwroot/export/fromServer.json";

        [Parameter]
        public DailyData ParentDailyData { get; set; } = null;


        private void UnloadChart()
        {
            _chartType = ChartType.None;
        }

        private async Task LoadDailyChartAsync()
        {
            ParentDailyData = await DailyChartService.GetDailyChartDataAsync(_selectedFile);
            _chartType = ChartType.Daily;
        }

        private void ChangeFile(ChangeEventArgs e)
        {
            _selectedFile = e.Value.ToString();
            UnloadChart();
        }



        //protected override async Task OnInitializedAsync()
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                //await DrawChart();
            }
            if (isLoading)  // prevent a forever loop
            {
                isLoading = false;
                StateHasChanged();
            }
            //isLoading = false;
            //StateHasChanged();
        }

        //    protected async Task DrawChart()
        //    {

        //        _dailyData = await DailyChartService.GetDailyChartDataAsync(jsonToChartPath);

        //        string chartTypeName = "area";  // has to get from json
        //        string chartTitleName = "Monica Model from json message";
        //        string chartOrigSpec = "Daily";

        //        string xAxsis = "";


        //        for (int i = 0; i < dailyData.Dates.Count; i++)
        //        {
        //            xAxsis += "'" + dailyData.Dates[i] + "' , ";
        //        }

        //        Boolean isFirstSerie = true;
        //        string series = "[";
        //        foreach (var outputId in dailyData.DailyOutputIds)
        //        {
        //            if (outputId.Name == Core.Share.MonicaConstFields.Crop)
        //                continue;

        //            series += "{ name: '" + outputId.Name + "', data: [";

        //            for (int i = 0; i < outputId.Results.Count; i++)
        //            {
        //                series += outputId.Results[i].ToString().Replace(",", ".") + " , ";
        //            }

        //            // Only enable the first serie & let the user enable the rest if wants
        //            //series += "], visible: false },";
        //            series += "]";
        //            if (isFirstSerie)
        //            {
        //                series += " },";
        //                isFirstSerie = false;
        //            }
        //            else
        //            {
        //                series += ", visible: false },";
        //            }

        //        }
        //        series += "]";

        //        chartjson = @" {
        //chart: {
        //zoomType: 'x',
        //height: 600,
        //type: '" + chartTypeName + @"',

        //},
        //colors: [
        //'#063c75',
        //'#1c8c44',
        //'#881452',
        //'#280137',
        //'#63a194',
        //'#2c3539',
        //'#428bca',
        //'#d9534f',
        //'#96ceb4',
        //'#80699B',
        //'#3D96AE',
        //'#DB843D',
        //'#92A8CD',
        //'#A47D7C',
        //'#B5CA92'],
        //loading: {
        //hideDuration: 1000,
        //showDuration: 1000
        //},
        //title: {
        //text: '" + chartTitleName + @"'
        //},

        //subtitle: {
        //text: '" + chartOrigSpec + @"'
        //},

        //yAxis: {
        //title: {
        //text: ' '
        //},
        //maxZoom: 2
        //},

        //xAxis: {
        //title: {
        //text: 'Date'
        //},
        //categories: [" + xAxsis + @"],
        //},

        //legend: {
        //layout: 'vertical',
        //align: 'right',
        //verticalAlign: 'middle'
        //},

        //plotOptions: {
        //area: {
        //fillColor: {
        //linearGradient: {
        //x1: 0,
        //y1: 0,
        //x2: 0,
        //y2: 0.6
        //},
        //stops: [
        //    [0, Highcharts.getOptions().colors[0]],
        //    [1, Highcharts.color(Highcharts.getOptions().colors[0]).setOpacity(0).get('rgba')]
        //]
        //},
        //marker: {
        //radius: 2
        //},
        //lineWidth: 1,
        //states: {
        //hover: {
        //lineWidth: 1
        //}
        //},
        //threshold: null
        //}
        //},

        //series:" + series + @",

        //responsive: {
        //rules: [{
        //condition: {
        //maxWidth: 500
        //},
        //chartOptions: {
        //legend: {
        //layout: 'horizontal',
        //align: 'center',
        //verticalAlign: 'bottom'
        //}
        //}
        //}]
        //},
        //navigation: {
        //buttonOptions: {
        //align: 'right'
        //}
        //},
        //exporting: {
        //sourceWidth: 1600,
        //scale: 1
        //},


        //}";
        //    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDailyChartService DailyChartService { get; set; }
    }
}
#pragma warning restore 1591
