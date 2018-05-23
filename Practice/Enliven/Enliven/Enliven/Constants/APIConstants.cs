using System;
using System.Globalization;
using System.Text;

namespace Enliven.Constants
{
    public static class APIConstants
{
    public static string Tenant { get; } = "379b88e8-5f77-421c-b489-21c1da71cfea";
    public static string AADInstance { get; } = @"https://login.microsoftonline.com/{0}";

    public static string Authority { get; } = "https://login.windows.net/common";
      //  string.Format(CultureInfo.InvariantCulture, AADInstance, Tenant);
    public static string ClientId { get; } = @"35823ebf-ba37-4f27-ad18-2b3689a4d9df";

    //Graph URI 
    public static string GraphResourceUri { get; } = @"https://graph.windows.net";
    public static string GraphApiVersion { get; } = @"2013-11-08";

    public static string Dump()
    {
        StringBuilder sb = new StringBuilder(1024);
        // sb.AppendLine($"{nameof()}: {}");
        sb.AppendLine($"{nameof(AADInstance)}: {AADInstance}");
        sb.AppendLine($"{nameof(Authority)}: {Authority}");
        sb.AppendLine("RedirectUri: PLEASE USE THE IADALHelper dependency service to get RedirUrl strings");
        sb.AppendLine($"{nameof(Tenant)}: {Tenant}");
        sb.AppendLine($"{nameof(GraphResourceUri)}: {GraphResourceUri}");
        sb.AppendLine($"{nameof(GraphApiVersion)}: {GraphApiVersion}");
        return sb.ToString();
    }
}
}
