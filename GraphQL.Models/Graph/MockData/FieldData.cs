using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Models.Entities;

namespace GraphQL.Models.Graph.MockData
{
    public class FieldData
    {
        private List<Field> _fields = new List<Field>();

        public FieldData()
        {
            string homesteadId = "e907a300-542a-4869-8784-3f34d769be30";
            string westCreekId = "30023a10-9092-410d-aa14-f696deb1de98";

            var homesteadField = new Field()
            {
                Id = homesteadId,
                Name = "Homestead",
                Notes = "Small plot near farmhouse.",
                Version = ByteHelper.GenerateRandomByte()
            };

            var westCreekField = new Field()
            {
                Id = westCreekId,
                Name = "West Creek",
                Notes = "South-east border of the creek to the service road.",
                Version = ByteHelper.GenerateRandomByte()
            };

            _fields.Add(homesteadField);
            _fields.Add(westCreekField);
        }

        internal Task<List<Field>> GetFieldsAsync()
        {
            return Task.FromResult(_fields);
        }

        public Task<Field> GetFieldByIdAsync(string id)
        {
            return Task.FromResult(_fields.FirstOrDefault(h => h.Id == id));
        }

        public Field AddField(Field field)
        {
            field.Id = Guid.NewGuid().ToString();
            field.Version = ByteHelper.GenerateRandomByte();
            _fields.Add(field);
            return field;
        }
    }

    public static class ByteHelper
    {
        private static Random _random = new Random();

        public static byte[] GenerateRandomByte(int size = 8)
        {
            byte[] randomByte = new byte[size];

            _random.NextBytes(randomByte);

            return randomByte;
        }
    }
}
