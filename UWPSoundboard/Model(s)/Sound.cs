using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundboard.Model_s_
{
    public enum Soundcategory
    { Animals,
      Cartoons,
      Taunts,
      Warnings}
        public class Sound
    {
        public string Name { get; set; }
        public Soundcategory Category { get; set; }
        public string AudioFile { get; set; }
    }
}
