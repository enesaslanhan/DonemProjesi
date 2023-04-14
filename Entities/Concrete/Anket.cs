using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Anket:IEntity
    {
        public int anketId { get; set; }
        public int age { get; set; }
        public int size { get; set; }
        public int weight { get; set; }
        public string horoscope { get; set; }
        public int userId { get; set; }
    }
}
