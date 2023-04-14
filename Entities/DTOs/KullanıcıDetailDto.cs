using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class KullanıcıDetailDto:IDto
    {
        public int anketId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public int size { get; set; }
        public int userId { get; set; }
        public int weight { get; set; }
    }
}
