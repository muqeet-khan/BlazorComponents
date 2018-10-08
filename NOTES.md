## 0.4.0

There are a few changes in 0.4 that you should be aware of before you upgrade your project. 

### Breaking Changes

In previous releases you would declare a chart as follows:

```csharp
    blazorBarChartJS = new ChartJSChart<ChartJsBarDataset>()
    {
        ...
        Data = new ChartJsData<ChartJsBarDataset>()
        {
            ...
            Datasets = new List<ChartJsBarDataset>()
            {
                new ChartJsBarDataset()
                {
                    Label = "# of Votes from blazor",
                    BackgroundColor = "#cc65fe",
                    Data = new List<int>(){ 19,12,5,3,3,2}
                },
                new ChartJsBarDataset()
                {
                    Label = "# of Likes from blazor",
                    BackgroundColor = "#36a2eb",
                    Data = new List<int>(){ 30,10,15,13,13,12}
                }
            }
        }
    };
```

I have moved things around to get rid of the generic chart declaration. So the new declaration will look as follows:

```csharp
        blazorBarChartJS = new ChartJSBarChart()
        {
            ...
            Data = new ChartJsBarData()
            {
                ...
                Datasets = new List<ChartJsBarDataset>()
                {
                    new ChartJsBarDataset()
                    {
                        Label = "# of Votes from blazor",
                        BackgroundColor = new List<string>(){"#cc65fe" },
                        ... ...
                        Data = new List<double>(){ 19.187,12.2253,5.5,3,3,2}
                    },
                    new ChartJsBarDataset()
                    {
                        Label = "# of Likes from blazor",
                        BackgroundColor = new List<string>() {
                            "#a4cef0",
                            "#3498db", ...},
                        ... ...
                        Data = new List<int>(){ 30,10,15,13,13,12}.Select<int,double>(i=> i).ToList()
                    }
                }
            }
        };
```

Look at this [sample](https://github.com/muqeet-khan/BlazorComponents/blob/master/samples/TestApplication/Pages/Index.cshtml) for a complete example. 

You will notice there are a couple of other changes. 

1. BackgroundColor is now a `List` instead of `string`. 
2. Data is now a double instead of int. 

The `backgroundcolor` property was changed to accomodate a larger set of scenarios than was possible with previous versions. 

Data was made double as well to accomodate a larger set of scenarios.


Because of the dynamic nature and possibility in JS, ChartJS has multiple types assigned to some of their proerpties as a result what works OOB in ChartJS will need some thinking in Blazor. 

## Important

There is no need to call the Update methods in the interop when updating the charts. This was done because I did not understand how Blazor was updating JS props. 


## Contributions

### Thanks

[@tenickl](https://github.com/tenickl) - For the Piechart update

[@fische17](https://github.com/fische17) - For the move to Blazor 0.6.0

[@srowan](https://github.com/srowan) - For the readme update. 