# Business Profiles

```csharp
BusinessProfilesController businessProfilesController = client.BusinessProfilesController;
```

## Class Name

`BusinessProfilesController`

## Methods

* [Update Business Profile](../../doc/controllers/business-profiles.md#update-business-profile)
* [Get Business Profile ID](../../doc/controllers/business-profiles.md#get-business-profile-id)


# Update Business Profile

Use this endpoint to update your business’ profile information such as the business description, email or address.

```csharp
UpdateBusinessProfileAsync(
    string phoneNumberID,
    Models.UpdateBusinessProfileRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `phoneNumberID` | `string` | Template, Required | - |
| `body` | [`Models.UpdateBusinessProfileRequest`](../../doc/models/update-business-profile-request.md) | Body, Required | - |

## Response Type

[`Task<Models.SuccessResponse>`](../../doc/models/success-response.md)

## Example Usage

```csharp
string phoneNumberID = "Phone-Number-ID6";
var body = new UpdateBusinessProfileRequest();
body.MessagingProduct = "whatsapp";
body.Address = "ADDRESS";
body.Description = "DESCRIPTION";
body.Vertical = VerticalEnum.UNDEFINED;
body.Email = "EMAIL";
body.Websites = new List<string>();
body.Websites.Add("https://WEBSITE-1");
body.Websites.Add("https://WEBSITE-2");
body.ProfilePictureUrl = "https://URL";

try
{
    SuccessResponse result = await businessProfilesController.UpdateBusinessProfileAsync(phoneNumberID, body);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "success": true
}
```


# Get Business Profile ID

Use this endpoint to retrieve your business’ profile. This business profile is visible to consumers in the chat thread next to the profile photo. The profile information will contain a business profile ID which you can use to make API calls.

```csharp
GetBusinessProfileIDAsync(
    string phoneNumberID,
    string fields = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `phoneNumberID` | `string` | Template, Required | - |
| `fields` | `string` | Query, Optional | Here you can specify what you want to know from your business as a comma separated list of fields. Available fields include: id, about, messaging_product, address, description, vertical, email, websites, profile_picture_url |

## Response Type

[`Task<Models.GetBusinessProfileIDResponse>`](../../doc/models/get-business-profile-id-response.md)

## Example Usage

```csharp
string phoneNumberID = "Phone-Number-ID6";
string fields = "about,address,description,email,profile_picture_url,websites,vertical";

try
{
    GetBusinessProfileIDResponse result = await businessProfilesController.GetBusinessProfileIDAsync(phoneNumberID, fields);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "data": [
    {
      "messaging_product": "whatsapp",
      "address": "ADDRESS",
      "description": "DESCRIPTION",
      "vertical": "UNDEFINED",
      "email": "EMAIL",
      "websites": [
        "https://WEBSITE-1",
        "https://WEBSITE-2"
      ],
      "profile_picture_url": "https://URL",
      "id": "BUSINESS_PROFILE_ID"
    }
  ]
}
```

