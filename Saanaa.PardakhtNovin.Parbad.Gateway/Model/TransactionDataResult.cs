using System;

namespace Saanaa.PardakhtNovin.Parbad.Gateway.Model
{
    [Serializable]
    public class TransactionDataResult
    {
        public string Result { get; set; }
        public string DataToSign { get; set; }
        public string UniqueId { get; set; }
    }
}
