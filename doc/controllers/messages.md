# Messages

<!-- 
You can use this API to send text messages, media, and message templates to your customers. To send a message, create a **Message** object. Each message is identified by a unique ID. You can also mark an incoming message as read through the `/messages` endpoint. You can track message status with Webhooks by ID. 
-->
Use the **`/{{Phone-Number-ID}}/messages`** endpoint to send text messages, media (audio, documents, images, and video), and message templates to your customers. For more information relating to the messages you can send, see [Messages](#1f4f7644-cc97-40b5-b8e4-c19da268fff1).

Messages are identified by a unique ID. You can track message status in the Webhooks through its ID. You could also mark an incoming message as read through the **`/{{Phone-Number-ID}}/messages`** endpoint.

## Prerequisites

* [User Access Token](https://developers.facebook.com/docs/facebook-login/access-tokens#usertokens) with **`whatsapp_business_messaging`** permission
* `phone-number-id` for your registered WhatsApp account. See [Get Phone Number](#c72d9c17-554d-4ae1-8f9e-b28a94010b28).

```csharp
MessagesController messagesController = client.MessagesController;
```

## Class Name

`MessagesController`


# Send Message

Use this endpoint to send text messages, media, message templates to your customers.

```csharp
SendMessageAsync(
    string phoneNumberID,
    Models.Message body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `phoneNumberID` | `string` | Template, Required | - |
| `body` | [`Models.Message`](../../doc/models/message.md) | Body, Required | To send a message, you must first assemble a message object with the content you want to send. |

## Response Type

[`Task<Models.SendMessageResponse>`](../../doc/models/send-message-response.md)

## Example Usage

```csharp
string phoneNumberID = "Phone-Number-ID6";
var body = new Message();
body.MessagingProduct = "whatsapp";
body.To = "{{Recipient-Phone-Number}}";
body.Template = new Template();
body.Template.Name = "hello_world";
body.Template.Language = new Language();
body.Template.Language.Code = "en_US";
body.Type = MessageTypeEnum.Template;

try
{
    SendMessageResponse result = await messagesController.SendMessageAsync(phoneNumberID, body);
}
catch (ApiException e){};
```

## Example Response *(as JSON)*

```json
{
  "messaging_product": "whatsapp",
  "contacts": [
    {
      "input": "48XXXXXXXXX",
      "wa_id": "48XXXXXXXXX "
    }
  ],
  "messages": [
    {
      "id": "wamid.gBGGSFcCNEOPAgkO_KJ55r4w_ww"
    }
  ]
}
```

