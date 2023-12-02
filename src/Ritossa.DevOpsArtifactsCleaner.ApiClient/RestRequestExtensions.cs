using RestSharp;
using System.Security;

namespace Ritossa.DevOpsArtifactsCleaner.ApiClient
{
    internal static class RestRequestExtensions
    {
        public static RestRequest AddAuthorization(this RestRequest request, SecureString pat)
        {
            var patAsBase64 = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($":{new System.Net.NetworkCredential(string.Empty, pat).Password}"));
            request.AddHeader("Authorization", $"Basic {patAsBase64}");

            return request;
        }
    }
}
