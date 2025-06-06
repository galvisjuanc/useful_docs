using System.Collections;
using System.Text;

namespace SingleResponsability
{
    public class ExportHelper<T>
    {
        public void ExportToCSV(IEnumerable<T> items)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string header = "";
            string[] dataRows = new string[items.Count()];
            foreach (var prop in typeof(T).GetProperties())
            {
                header += $"{prop.Name};";
                for (int i = 0; i < items.Count(); i++)
                {
                    var propValue = prop.GetValue(items.ToArray()[i]);
                    var propType = propValue.GetType();
                    if (propType.Name != nameof(String)
                        && propType.GetInterface(nameof(IEnumerable)) != null)
                    {
                        dataRows[i] += $"{String.Join("|", (propValue as IEnumerable).Cast<object>().Select(x => x.ToString()))};";

                    }
                    else
                    {
                        dataRows[i] += $"{propValue};";
                    }
                }
            }
            sb.AppendLine(header.Trim(';'));
            foreach (var dataRow in dataRows)
            {
                sb.AppendLine(dataRow.Trim(';'));
            }
            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Export_{typeof(T).ToString()}.csv"), sb.ToString(), Encoding.Unicode);
        }
    }
}