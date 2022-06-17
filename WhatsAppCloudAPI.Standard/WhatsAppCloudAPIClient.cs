// <copyright file="WhatsAppCloudAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace WhatsAppCloudAPI.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using WhatsAppCloudAPI.Standard.Authentication;
    using WhatsAppCloudAPI.Standard.Controllers;
    using WhatsAppCloudAPI.Standard.Http.Client;
    using WhatsAppCloudAPI.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class WhatsAppCloudAPIClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Server, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Server, string>>
        {
            {
                Environment.Production, new Dictionary<Server, string>
                {
                    { Server.Default, "https://graph.facebook.com/{Version}" },
                }
            },
        };

        private readonly IDictionary<string, IAuthManager> authManagers;
        private readonly IHttpClient httpClient;
        private readonly BearerAuthManager bearerAuthManager;

        private readonly Lazy<BusinessProfilesController> businessProfiles;
        private readonly Lazy<MessagesController> messages;
        private readonly Lazy<MediaController> media;
        private readonly Lazy<PhoneNumbersController> phoneNumbers;
        private readonly Lazy<RegistrationController> registration;
        private readonly Lazy<TwoStepVerificationController> twoStepVerification;

        private WhatsAppCloudAPIClient(
            Environment environment,
            string version,
            string accessToken,
            IDictionary<string, IAuthManager> authManagers,
            IHttpClient httpClient,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.Version = version;
            this.httpClient = httpClient;
            this.authManagers = (authManagers == null) ? new Dictionary<string, IAuthManager>() : new Dictionary<string, IAuthManager>(authManagers);
            this.HttpClientConfiguration = httpClientConfiguration;

            this.businessProfiles = new Lazy<BusinessProfilesController>(
                () => new BusinessProfilesController(this, this.httpClient, this.authManagers));
            this.messages = new Lazy<MessagesController>(
                () => new MessagesController(this, this.httpClient, this.authManagers));
            this.media = new Lazy<MediaController>(
                () => new MediaController(this, this.httpClient, this.authManagers));
            this.phoneNumbers = new Lazy<PhoneNumbersController>(
                () => new PhoneNumbersController(this, this.httpClient, this.authManagers));
            this.registration = new Lazy<RegistrationController>(
                () => new RegistrationController(this, this.httpClient, this.authManagers));
            this.twoStepVerification = new Lazy<TwoStepVerificationController>(
                () => new TwoStepVerificationController(this, this.httpClient, this.authManagers));

            if (this.authManagers.ContainsKey("global"))
            {
                this.bearerAuthManager = (BearerAuthManager)this.authManagers["global"];
            }

            if (!this.authManagers.ContainsKey("global")
                || !this.BearerAuthCredentials.Equals(accessToken))
            {
                this.bearerAuthManager = new BearerAuthManager(accessToken);
                this.authManagers["global"] = this.bearerAuthManager;
            }
        }

        /// <summary>
        /// Gets BusinessProfilesController controller.
        /// </summary>
        public BusinessProfilesController BusinessProfilesController => this.businessProfiles.Value;

        /// <summary>
        /// Gets MessagesController controller.
        /// </summary>
        public MessagesController MessagesController => this.messages.Value;

        /// <summary>
        /// Gets MediaController controller.
        /// </summary>
        public MediaController MediaController => this.media.Value;

        /// <summary>
        /// Gets PhoneNumbersController controller.
        /// </summary>
        public PhoneNumbersController PhoneNumbersController => this.phoneNumbers.Value;

        /// <summary>
        /// Gets RegistrationController controller.
        /// </summary>
        public RegistrationController RegistrationController => this.registration.Value;

        /// <summary>
        /// Gets TwoStepVerificationController controller.
        /// </summary>
        public TwoStepVerificationController TwoStepVerificationController => this.twoStepVerification.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets Version.
        /// Version value.
        /// </summary>
        public string Version { get; }

        /// <summary>
        /// Gets auth managers.
        /// </summary>
        internal IDictionary<string, IAuthManager> AuthManagers => this.authManagers;

        /// <summary>
        /// Gets http client.
        /// </summary>
        internal IHttpClient HttpClient => this.httpClient;

        /// <summary>
        /// Gets the credentials to use with BearerAuth.
        /// </summary>
        private IBearerAuthCredentials BearerAuthCredentials => this.bearerAuthManager;

        /// <summary>
        /// Gets the access token to use with OAuth 2 authentication.
        /// </summary>
        public string AccessToken => this.BearerAuthCredentials.AccessToken;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            StringBuilder url = new StringBuilder(EnvironmentsMap[this.Environment][alias]);
            ApiHelper.AppendUrlWithTemplateParameters(url, this.GetBaseUriParameters());

            return url.ToString();
        }

        /// <summary>
        /// Creates an object of the WhatsAppCloudAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .Version(this.Version)
                .AccessToken(this.BearerAuthCredentials.AccessToken)
                .HttpClient(this.httpClient)
                .AuthManagers(this.authManagers)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"Version = {this.Version}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> WhatsAppCloudAPIClient.</returns>
        internal static WhatsAppCloudAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("WHATS_APP_CLOUD_API_STANDARD_ENVIRONMENT");
            string version = System.Environment.GetEnvironmentVariable("WHATS_APP_CLOUD_API_STANDARD_VERSION");
            string accessToken = System.Environment.GetEnvironmentVariable("WHATS_APP_CLOUD_API_STANDARD_ACCESS_TOKEN");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (version != null)
            {
                builder.Version(version);
            }

            if (accessToken != null)
            {
                builder.AccessToken(accessToken);
            }

            return builder.Build();
        }

        /// <summary>
        /// Makes a list of the BaseURL parameters.
        /// </summary>
        /// <returns>Returns the parameters list.</returns>
        private List<KeyValuePair<string, object>> GetBaseUriParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("Version", this.Version),
            };
            return kvpList;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = WhatsAppCloudAPI.Standard.Environment.Production;
            private string version = "v13.0";
            private string accessToken = "";
            private IDictionary<string, IAuthManager> authManagers = new Dictionary<string, IAuthManager>();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private IHttpClient httpClient;

            /// <summary>
            /// Sets credentials for BearerAuth.
            /// </summary>
            /// <param name="accessToken">AccessToken.</param>
            /// <returns>Builder.</returns>
            public Builder AccessToken(string accessToken)
            {
                this.accessToken = accessToken ?? throw new ArgumentNullException(nameof(accessToken));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets Version.
            /// </summary>
            /// <param name="version"> Version. </param>
            /// <returns> Builder. </returns>
            public Builder Version(string version)
            {
                this.version = version ?? throw new ArgumentNullException(nameof(version));
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

            /// <summary>
            /// Sets the IHttpClient for the Builder.
            /// </summary>
            /// <param name="httpClient"> http client. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpClient(IHttpClient httpClient)
            {
                this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
                return this;
            }

            /// <summary>
            /// Sets the authentication managers for the Builder.
            /// </summary>
            /// <param name="authManagers"> auth managers. </param>
            /// <returns>Builder.</returns>
            internal Builder AuthManagers(IDictionary<string, IAuthManager> authManagers)
            {
                this.authManagers = authManagers ?? throw new ArgumentNullException(nameof(authManagers));
                return this;
            }

            /// <summary>
            /// Creates an object of the WhatsAppCloudAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>WhatsAppCloudAPIClient.</returns>
            public WhatsAppCloudAPIClient Build()
            {
                this.httpClient = new HttpClientWrapper(this.httpClientConfig.Build());

                return new WhatsAppCloudAPIClient(
                    this.environment,
                    this.version,
                    this.accessToken,
                    this.authManagers,
                    this.httpClient,
                    this.httpClientConfig.Build());
            }
        }
    }
}
