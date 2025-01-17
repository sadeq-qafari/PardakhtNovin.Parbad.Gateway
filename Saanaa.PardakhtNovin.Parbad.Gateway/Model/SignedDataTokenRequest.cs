﻿using System;
using Ardalis.GuardClauses;

namespace Saanaa.PardakhtNovin.Parbad.Gateway.Model
{
    [Serializable]
    public class SignedDataTokenRequest
    {
        public SignedDataTokenRequest(WSContext wsContext, string signature, string uniqueId)
        {
            Guard.Against.Null(wsContext, nameof(wsContext));
            Guard.Against.NullOrEmpty(signature, nameof(signature));
            Guard.Against.NullOrEmpty(uniqueId, nameof(uniqueId));

            WSContext = wsContext;
            Signature = signature;
            UniqueId = uniqueId;
        }
        public WSContext WSContext { get; private set; }
        public string Signature { get; private set; }
        public string UniqueId { get; private set; }
    }
}
