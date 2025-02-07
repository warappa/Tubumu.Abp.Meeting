﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Sample.Web
{
    [Dependency(ReplaceServices = true)]
    public class SampleBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Sample";
    }
}
