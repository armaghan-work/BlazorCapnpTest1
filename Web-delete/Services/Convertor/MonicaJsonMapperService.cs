using System;
using System.Collections.Generic;
using System.IO;
using Services.Share;
using Models.MonicaData;
using Models.Share;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Services.Convertor
{
    public class MonicaJsonMapperService : IMonicaJsonMapperService<StreamReader>
    {
        public List<MonicaBaseData> Map(StreamReader data)
        {
            int dataCounter = 0;
            var lstMonicaBaseData = new List<MonicaBaseData>();

            using (JsonTextReader reader = new JsonTextReader(data))
            {
                JObject jObject = (JObject)JToken.ReadFrom(reader);

                foreach (var mData in jObject["data"])
                {
                    var monicaBaseData = new MonicaBaseData(dataCounter++);

                    string OrigSpec = (string)mData[MonicaConstFields.OrigSpec];
                    OrigSpec = OrigSpec.RemoveQuotation();
                    monicaBaseData.OrigSpec = OrigSpec;

                    int outputIdIndex = 0;

                    foreach (var outId in mData[MonicaConstFields.OutputIds])  // like Daily, Yearly, Crop
                    {
                        var monicaSerie = new MonicaSerie();
                        var outIdName = (string)outId[MonicaConstFields.Name];
                        var results = (JArray)mData[MonicaConstFields.Results][outputIdIndex];

                        if (results.Count > 0)
                        {
                            var firstResult = results[0];

                            if (firstResult is JArray) // the result is series of arrays
                            {
                                for (int i = 0; i < ((JArray)firstResult).Count; i++)
                                {
                                    monicaSerie = new MonicaSerie();
                                    monicaSerie.SerieTitle = outIdName + "-" + (i + 1);

                                    foreach (var result in results)
                                    {
                                        monicaSerie.Values.Add(result[i].ToString().Replace(",", ".")); // replace , by . in numbers for sub arrays
                                    }

                                    monicaBaseData.MonicaSeries.Add(monicaSerie);
                                }
                            }
                            else
                            {
                                monicaSerie.SerieTitle = outIdName;
                                foreach (var result in results)
                                {
                                    monicaSerie.Values.Add(result.ToString().Replace(",", "."));
                                }
                                monicaBaseData.MonicaSeries.Add(monicaSerie);
                            }
                        }

                        outputIdIndex++;
                    }

                    lstMonicaBaseData.Add(monicaBaseData);
                }
            }

            return lstMonicaBaseData; //return data for selected chart
        }
    }
}
