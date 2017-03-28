using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoryBook.Models
{
    public class HumanCharacters
    {
        [Key]
        public int HCID { get; set; }

        public string CharacterName { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public string HairType { get; set; }
        public string HairColor { get; set; }
        public string ShirtColor { get; set; }
        public string PantsColor { get; set; }

        public bool Bald { get; set; }
        public bool Freckles { get; set; }
    }
}