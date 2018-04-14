using Utf8Json;

namespace DotNetStandardLib
{
    public static class TestSerialization
    {
        public static string Serialize()
        {
            var data = new MyData();

            return JsonSerializer.ToJsonString(data);
        }
    }

    public class MyData
    {
        public string Test { get; set; } = "foo";
    }
}
