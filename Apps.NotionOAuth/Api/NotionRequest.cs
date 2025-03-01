using Apps.NotionOAuth.Constants;
using Blackbird.Applications.Sdk.Common.Authentication;
using Blackbird.Applications.Sdk.Utils.Extensions.Sdk;
using Blackbird.Applications.Sdk.Utils.RestSharp;
using RestSharp;

namespace Apps.NotionOAuth.Api;

public class NotionRequest(string resource, Method method, IEnumerable<AuthenticationCredentialsProvider> creds)
    : BlackBirdRestRequest(resource, method, creds)
{
    protected override void AddAuth(IEnumerable<AuthenticationCredentialsProvider> creds)
    {
        var token = creds.Get(CredsNames.AccessToken).Value;

        this.AddHeader("Authorization", $"Bearer {token}")
            .AddHeader("Notion-Version", ApiConstants.ApiVersion);
    }
}