using System;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace SwaggerOperationIdGenerator
{
    class Program
    {
        static string UppercaseFirstLetter(string before)
        {
            return char.ToUpper(before.First()) + before.Substring(1).ToLower();
        }

        static string GenerateControllerName(string pathName)
        {
            // return the second segment in the path
            var controllerParts = pathName.Split('/')
                .Where(p => !p.Contains("{") && !string.IsNullOrWhiteSpace(p))
                .Skip(1)
                .Select(x => SanitizeName(x));

            return controllerParts.FirstOrDefault();
        }

        static string SanitizeName(string name)
        {
            var segments = name.Split(new char[] {'_', '-'}).Select(x => UppercaseFirstLetter(x));
            return string.Join("", segments);
        }

        static string GenerateMethodName(string pathName)
        {
            var segments = pathName.Split('/')
                .Where(p => !p.Contains("{") && !string.IsNullOrWhiteSpace(p))
                .ToList();

            // this is the class name that we pulled out above.
            segments.RemoveAt(1);

            return string.Join("", segments.Select(x=> SanitizeName(x)));
        }


        static void Main(string[] args)
        {
            var json = JsonConvert.DeserializeObject(File.ReadAllText(args[0])) as JObject;

            var paths = json["paths"] as JObject;
            foreach (var pathToken in paths.Children())
            {
                var path = pathToken as Newtonsoft.Json.Linq.JProperty;

                var controllerName = GenerateControllerName(path.Name);
                var methodName = GenerateMethodName(path.Name);

                bool insertMethodIntoName = path.Value.Children().Count() > 1;

                foreach (var methodToken in path.Value.Children())
                {
                    var method = methodToken as JProperty;

                    var operationId = controllerName + "_" + methodName;

                    if (insertMethodIntoName)
                    {
                        operationId += SanitizeName(method.Name);
                    }

                    if (method.Value.Children().Contains("operationId"))
                    {
                        var prop = method.Value["operationId"] as JProperty;
                        prop.Value = operationId;
                    }
                    else
                    {
                        method.Value.Children().First().AddAfterSelf(new JProperty("operationId", operationId));
                    }
                }
            }

            Console.WriteLine(JsonConvert.SerializeObject(json, Formatting.Indented));        

        }
    }
}
