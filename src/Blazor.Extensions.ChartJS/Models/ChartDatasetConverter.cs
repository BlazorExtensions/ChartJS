using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blazor.Extensions.ChartJS
{
    internal class ChartDatasetConverter : JsonConverter<IChartDataset[]>
    {
        public override IChartDataset[]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }

        public override void Write(Utf8JsonWriter writer, IChartDataset[] value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();

            foreach (var ds in value)
            {
                switch (ds.ChartType)
                {
                    case ChartType.Bar:
                        JsonSerializer.Serialize(writer, ds as BarDataset);
                        break;
                    // case ChartType.Bubble:
                    //     JsonSerializer.Serialize(writer, ds as BubbleDataset);
                    //     break;
                    case ChartType.Doughnut:
                        JsonSerializer.Serialize(writer, ds as DoughnutDataset);
                        break;
                    case ChartType.Line:
                        JsonSerializer.Serialize(writer, ds as LineDataset);
                        break;
                    case ChartType.Pie:
                        JsonSerializer.Serialize(writer, ds as PieDataset);
                        break;
                    // case ChartType.PolarArea:
                    //     JsonSerializer.Serialize(writer, ds as PolarAreaDataset);
                    //     break;
                    case ChartType.Radar:
                        JsonSerializer.Serialize(writer, ds as RadarDataset);
                        break;
                    case ChartType.Scatter:
                        JsonSerializer.Serialize(writer, ds as ScatterDataset);
                        break;
                }
            }

            writer.WriteEndArray();
        }
    }
}