using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoveringMetaData
{
    public class MetadataPrinter
    {
        private readonly Type _type;

        public MetadataPrinter(Type type)
        {
            _type = type;
        }
        public void Print()
        {
            PrintMainInfo();
            PrintMethodInfo();
            PrintPropertyInfo();
            //PrintFieldInfo();
        }

        //private void PrintFieldInfo()
        //{
        //    throw new NotImplementedException();
        //}

        private void PrintPropertyInfo()
        {
            Console.WriteLine($"******** Information of methods {_type.Name} ********");

            var propertyInfo = _type.GetProperties();
            foreach (var property in propertyInfo)
            {
                Console.WriteLine($"{property.PropertyType} {property.Name}");
            }
        }

        private void PrintMethodInfo()
        {
            Console.WriteLine($"******** Information of methods {_type.Name} ********");
            var methodInfo = _type.GetMethods();
            foreach (var method in methodInfo)
            {
                Console.WriteLine(method.Name);
                var param = method.GetParameters();

                foreach (var parameter in param)
                {
                    Console.WriteLine($"param {parameter.ParameterType} {parameter.Name }");
                }
            }
        }

        private void PrintMainInfo()
        {
            Console.WriteLine($"******** Information of type {_type.Name} ********");
            Console.WriteLine($"{_type.FullName}");
            Console.WriteLine($"{_type.AssemblyQualifiedName}");
            Console.WriteLine($"{_type.BaseType}");
            Console.WriteLine($"{_type.Namespace}");
            Console.WriteLine($"{_type.IsAbstract}");
            Console.WriteLine($"{_type.IsEnum}");
        }
    }
}
