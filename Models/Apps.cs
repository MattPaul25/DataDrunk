using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataDrunk.Models
{
    public class Cipher
    {
        [Display(Name="Your Message")]
        [DataType(DataType.MultilineText)]
        public string myMessage { get; set; }
         
        [Display(Name="Your Key")]
        public string myKey { get; set; }

        [Display(Name = "Your Encrypted Text")]
        public string myEncryptedText { get; set; }
       
        public Blenders SelectedBlender { get; set; }

        public enum Blenders
        {
            Merge,
            Swap,
            OutIn,
            InOut,
            Push,
            Pull,
            RigUp,
            RigDown

        }


    }
}