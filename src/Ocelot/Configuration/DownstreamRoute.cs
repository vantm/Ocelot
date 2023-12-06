using Ocelot.Configuration.Creator;
using Ocelot.Values;

namespace Ocelot.Configuration
{
    public class DownstreamRoute
    {
        public DownstreamRoute(
            string key,
            UpstreamPathTemplate upstreamPathTemplate,
            List<HeaderFindAndReplace> upstreamHeadersFindAndReplace,
            List<HeaderFindAndReplace> downstreamHeadersFindAndReplace,
            List<DownstreamHostAndPort> downstreamAddresses,
            string serviceName,
            string serviceNamespace,
            HttpHandlerOptions httpHandlerOptions,
            bool useServiceDiscovery,
            bool enableEndpointEndpointRateLimiting,
            QoSOptions qosOptions,
            string downstreamScheme,
            string requestIdKey,
            bool isCached,
            CacheOptions cacheOptions,
            LoadBalancerOptions loadBalancerOptions,
            RateLimitOptions rateLimitOptions,
            Dictionary<string, string> routeClaimsRequirement,
            List<ClaimToThing> claimsToQueries,
            List<ClaimToThing> claimsToHeaders,
            List<ClaimToThing> claimsToClaims,
            List<ClaimToThing> claimsToPath,
            bool isAuthenticated,
            bool isAuthorized,
            AuthenticationOptions authenticationOptions,
            DownstreamPathTemplate downstreamPathTemplate,
            string loadBalancerKey,
            List<string> delegatingHandlers,
            List<AddHeader> addHeadersToDownstream,
            List<AddHeader> addHeadersToUpstream,
            bool dangerousAcceptAnyServerCertificateValidator,
            SecurityOptions securityOptions,
            string downstreamHttpMethod,
            Version downstreamHttpVersion,
            HttpVersionPolicy downstreamHttpVersionPolicy,
            Dictionary<string, UpstreamHeaderTemplate> upstreamHeaders,
            Dictionary<string, string> metadata)
        {
            DangerousAcceptAnyServerCertificateValidator = dangerousAcceptAnyServerCertificateValidator;
            AddHeadersToDownstream = addHeadersToDownstream;
            DelegatingHandlers = delegatingHandlers;
            Key = key;
            UpstreamPathTemplate = upstreamPathTemplate;
            UpstreamHeadersFindAndReplace = upstreamHeadersFindAndReplace ?? new List<HeaderFindAndReplace>();
            DownstreamHeadersFindAndReplace = downstreamHeadersFindAndReplace ?? new List<HeaderFindAndReplace>();
            DownstreamAddresses = downstreamAddresses ?? new List<DownstreamHostAndPort>();
            ServiceName = serviceName;
            ServiceNamespace = serviceNamespace;
            HttpHandlerOptions = httpHandlerOptions;
            UseServiceDiscovery = useServiceDiscovery;
            EnableEndpointEndpointRateLimiting = enableEndpointEndpointRateLimiting;
            QosOptions = qosOptions;
            DownstreamScheme = downstreamScheme;
            RequestIdKey = requestIdKey;
            IsCached = isCached;
            CacheOptions = cacheOptions;
            LoadBalancerOptions = loadBalancerOptions;
            RateLimitOptions = rateLimitOptions;
            RouteClaimsRequirement = routeClaimsRequirement;
            ClaimsToQueries = claimsToQueries ?? new List<ClaimToThing>();
            ClaimsToHeaders = claimsToHeaders ?? new List<ClaimToThing>();
            ClaimsToClaims = claimsToClaims ?? new List<ClaimToThing>();
            ClaimsToPath = claimsToPath ?? new List<ClaimToThing>();
            IsAuthenticated = isAuthenticated;
            IsAuthorized = isAuthorized;
            AuthenticationOptions = authenticationOptions;
            DownstreamPathTemplate = downstreamPathTemplate;
            LoadBalancerKey = loadBalancerKey;
            AddHeadersToUpstream = addHeadersToUpstream;
            SecurityOptions = securityOptions;
            DownstreamHttpMethod = downstreamHttpMethod;
            DownstreamHttpVersion = downstreamHttpVersion;
            DownstreamHttpVersionPolicy = downstreamHttpVersionPolicy;
            UpstreamHeaders = upstreamHeaders ?? new();
            Metadata = metadata;
        }

        public string Key { get; }
        public UpstreamPathTemplate UpstreamPathTemplate { get; }
        public List<HeaderFindAndReplace> UpstreamHeadersFindAndReplace { get; }
        public List<HeaderFindAndReplace> DownstreamHeadersFindAndReplace { get; }
        public List<DownstreamHostAndPort> DownstreamAddresses { get; }
        public string ServiceName { get; }
        public string ServiceNamespace { get; }
        public HttpHandlerOptions HttpHandlerOptions { get; }
        public bool UseServiceDiscovery { get; }
        public bool EnableEndpointEndpointRateLimiting { get; }
        public QoSOptions QosOptions { get; }
        public string DownstreamScheme { get; }
        public string RequestIdKey { get; }
        public bool IsCached { get; }
        public CacheOptions CacheOptions { get; }
        public LoadBalancerOptions LoadBalancerOptions { get; }
        public RateLimitOptions RateLimitOptions { get; }
        public Dictionary<string, string> RouteClaimsRequirement { get; }
        public List<ClaimToThing> ClaimsToQueries { get; }
        public List<ClaimToThing> ClaimsToHeaders { get; }
        public List<ClaimToThing> ClaimsToClaims { get; }
        public List<ClaimToThing> ClaimsToPath { get; }
        public bool IsAuthenticated { get; }
        public bool IsAuthorized { get; }
        public AuthenticationOptions AuthenticationOptions { get; }
        public DownstreamPathTemplate DownstreamPathTemplate { get; }
        public string LoadBalancerKey { get; }
        public List<string> DelegatingHandlers { get; }
        public List<AddHeader> AddHeadersToDownstream { get; }
        public List<AddHeader> AddHeadersToUpstream { get; }
        public bool DangerousAcceptAnyServerCertificateValidator { get; }
        public SecurityOptions SecurityOptions { get; }
        public string DownstreamHttpMethod { get; }
        public Version DownstreamHttpVersion { get; }

        /// <summary>The <see cref="HttpVersionPolicy"/> enum specifies behaviors for selecting and negotiating the HTTP version for a request.</summary>
        /// <value>An <see cref="HttpVersionPolicy"/> enum value being mapped from a <see cref="VersionPolicies"/> constant.</value>
        /// <remarks>
        /// Related to the <see cref="DownstreamHttpVersion"/> property.
        /// <list type="bullet">
        ///   <item><see href="https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpversionpolicy">HttpVersionPolicy Enum</see></item>
        ///   <item><see href="https://learn.microsoft.com/en-us/dotnet/api/system.net.httpversion">HttpVersion Class</see></item>
        ///   <item><see href="https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestmessage.versionpolicy">HttpRequestMessage.VersionPolicy Property</see></item>
        /// </list>
        /// </remarks>
        public HttpVersionPolicy DownstreamHttpVersionPolicy { get; }
        public Dictionary<string, UpstreamHeaderTemplate> UpstreamHeaders { get; }
        public Dictionary<string, string> Metadata { get; }
    }
}
