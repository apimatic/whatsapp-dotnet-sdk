
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Version` | `string` | *Default*: `"v13.0"` |
| `Environment` | Environment | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `AccessToken` | `string` | The OAuth 2.0 Access Token to use for API requests. |

The API client can be initialized as follows:

```csharp
WhatsAppCloudAPI.Standard.WhatsAppCloudAPIClient client = new WhatsAppCloudAPI.Standard.WhatsAppCloudAPIClient.Builder()
    .AccessToken("AccessToken")
    .Environment(WhatsAppCloudAPI.Standard.Environment.Production)
    .Version("v13.0")
    .HttpClientConfig(config => config.NumberOfRetries(0))
    .Build();
```

## WhatsApp Cloud APIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| BusinessProfilesController | Gets BusinessProfilesController controller. |
| MessagesController | Gets MessagesController controller. |
| MediaController | Gets MediaController controller. |
| PhoneNumbersController | Gets PhoneNumbersController controller. |
| RegistrationController | Gets RegistrationController controller. |
| TwoStepVerificationController | Gets TwoStepVerificationController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | `IHttpClientConfiguration` |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| Version | Version value. | `string` |
| AccessTokenCredentials | Gets the access token to use with OAuth 2 authentication. | `IAccessTokenCredentials` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the WhatsApp Cloud APIClient using the values provided for the builder. | `Builder` |

## WhatsApp Cloud APIClient Builder Class

Class to build instances of WhatsApp Cloud APIClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<HttpClientConfiguration.Builder> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `Version(string version)` | Version value. | `Builder` |
| `AccessTokenCredentials(IAccessTokenCredentials accessTokenCredentials)` | Gets the access token to use with OAuth 2 authentication. | `Builder` |

