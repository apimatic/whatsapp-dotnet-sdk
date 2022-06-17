# Registration

You need to register your phone number in the following scenarios:

* Account Creation: When you implement this API, you need to register the phone number you want to use to send messages. We enforce [setting two-step verification](#fc57a30c-97e0-4e06-b74b-89fd7fc5f783) during account creation to add an extra layer of security of your accounts.
* Name Change: In this case, your phone is already registered and you want to change your display name. To do that, you must first [file for a name change on WhatsApp Manager](https://www.facebook.com/business/help/378834799515077). Once the name is approved, you need to register your phone again under the new name.

Before registering your phone, you need to verify that you own that phone number with a SMS or voice code. For details, see [Verify Phone Ownership](https://developers.facebook.com/docs/whatsapp/business-management-api/guides/migrate-phone-to-different-waba#step-2--verify-phone-ownership).

In case you would like to remove your phone from the Cloud API, you can deregister a phone. This can be used in cases where you want to move to the On-Premises API or you want to use your phone number in the regular WhatsApp customer app. You can always reregister your phone with Cloud API later by repeating the registration process.

**You set up** [**two-factor verification**](#fc57a30c-97e0-4e06-b74b-89fd7fc5f783) **and** [**register a phone number**](#b22af3db-9d13-4467-a7a6-4026f71984cb) **in the same API call.**

#### Reminders

* To use these endpoints, you need to authenticate yourself with a system user access token with the **`whatsapp_business_messaging`** permission.
* If you need to find your phone number ID, see [Get Phone Number ID](#c72d9c17-554d-4ae1-8f9e-b28a94010b28).

```csharp
RegistrationController registrationController = client.RegistrationController;
```

## Class Name

`RegistrationController`

## Methods

* [Register Phone](../../doc/controllers/registration.md#register-phone)
* [Deregister Phone](../../doc/controllers/registration.md#deregister-phone)


# Register Phone

Used to register a phone number or to migrate WhatsApp Business Accounts from a current On-Premises deployment to the new Cloud-Based API. Business Solution Providers (BSPs) must authenticate themselves with an access token with the whatsapp_business_management permission.

```csharp
RegisterPhoneAsync(
    string phoneNumberID,
    Models.RegisterPhoneRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `phoneNumberID` | `string` | Template, Required | - |
| `body` | [`Models.RegisterPhoneRequest`](../../doc/models/register-phone-request.md) | Body, Required | - |

## Response Type

[`Task<Models.SuccessResponse>`](../../doc/models/success-response.md)

## Example Usage

```csharp
string phoneNumberID = "Phone-Number-ID6";
var body = new RegisterPhoneRequest();
body.MessagingProduct = "whatsapp";
body.Pin = "<your-6-digit-pin>";

try
{
    SuccessResponse result = await registrationController.RegisterPhoneAsync(phoneNumberID, body);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "success": true
}
```


# Deregister Phone

Used to deregister a phone number. Deregister phone removes a previously registered phone. You can always re-register your phone using by repeating the registration process. Business Solution Providers (BSPs) must authenticate themselves with an access token with the whatsapp_business_management permission.

```csharp
DeregisterPhoneAsync(
    Models.ContentTypeEnum contentType,
    string phoneNumberID)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `contentType` | [`Models.ContentTypeEnum`](../../doc/models/content-type-enum.md) | Header, Required | - |
| `phoneNumberID` | `string` | Template, Required | - |

## Response Type

[`Task<Models.SuccessResponse>`](../../doc/models/success-response.md)

## Example Usage

```csharp
ContentTypeEnum contentType = ContentTypeEnum.EnumApplicationjson;
string phoneNumberID = "Phone-Number-ID6";

try
{
    SuccessResponse result = await registrationController.DeregisterPhoneAsync(contentType, phoneNumberID);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "success": true
}
```

