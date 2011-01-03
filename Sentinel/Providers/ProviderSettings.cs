﻿using System;
using Sentinel.Providers.Interfaces;

namespace Sentinel.Providers
{
    public class ProviderSettings : IProviderSettings
    {
        #region Implementation of IProviderSettings

        public string Name { get; set; }

        public virtual string Summary
        {
            get
            {
                return string.Format("Provider named {0}", Name);
            }
        }

        /// <summary>
        /// Reference back to the provider this setting is appropriate to.
        /// </summary>
        public ProviderInfo Info { get; set; }

        #endregion
    }
}