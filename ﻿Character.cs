using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    internal class _﻿Character
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Image { get; private set; }


        public int Level { get; set; }
        public int Experience { get; set; }


        private _Character(string name, string type, string image)
        {
            Name = name;
            Type = type;
            Image = image;
            Level = 1;
            Experience = 0;
        }


        public class CharacterFactory
        {
            private Dictionary<string, _Character> characters = new Dictionary<string, _Character>();

            public _Character GetCharacter(string name, string type, string image)
            {
                string key = $"{name}:{type}";

                if (!characters.ContainsKey(key))
                {
                    characters[key] = new _Character(name, type, image);
                }

                return characters[key];
            }
        }
    }
}
