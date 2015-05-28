using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataDrunk.Models
{
    public class Cipher
    {
        public string myMessage { get; set; }

        public string recipients { get; set; }

        public string myPassword { get; set; }

        private string key;


    }
}