using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShawzinBot.Models
{
    public class GameInfoModel
    {
        public string Name { get; private set; }

        public string Value { get; private set; }

        public GameInfoModel(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
