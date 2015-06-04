using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataDrunk.Applications
{
    public class Encrypt : DataDrunk.Models.Cipher
    {
        public string EncryptedMessage { get; protected set; }
        public string Key { get; protected set; }
        
        public Encrypt(Blenders b, string message, string key)
        {
            Key = key;
            switch (b)
            {
                case Blenders.InOut:
                    break;
                case Blenders.Merge:
                    EncryptedMessage = mergeText(message);
                    Key = Key == null ? "m" : Key + "m";
                    break;
                case Blenders.Push:
                    break;
                case Blenders.Pull:
                    break;
                case Blenders.Swap:
                    break;
                default:
                    break;

            }
        }
        private string mergeText(string someText)
        {
            int strLength = someText.Length - 1;
            for (int i = 0; i <= strLength; i = i + 2)
            {
                string myChar = someText.Substring(strLength, 1);
                string left = StringUtils.Left(someText, i);
                string right = StringUtils.Right(someText, i);
                someText = left + myChar + right;
                someText = someText.Substring(0, strLength + 1);
            }
            return someText;
        }
    }
}