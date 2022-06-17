
# Message

## Structure

`Message`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Audio` | [`Models.Audio`](../../doc/models/audio.md) | Optional | A media object containing audio. Required when type=audio. |
| `Contacts` | [`List<Models.Contact>`](../../doc/models/contact.md) | Optional | A contact object. Required when type=contacts. |
| `Document` | [`Models.Document`](../../doc/models/document.md) | Optional | A media object containing a document. Required when type=document. |
| `Image` | [`Models.Image`](../../doc/models/image.md) | Optional | A media object containing an image. Required when type=image. |
| `Interactive` | [`Models.Interactive`](../../doc/models/interactive.md) | Optional | This option is used to send List Messages and Reply Buttons. The components of each interactive object generally follow a consistent pattern: header, body, footer, and action. Required when type=interactive. |
| `Location` | [`Models.Location`](../../doc/models/location.md) | Optional | A location object. Required when type=location. |
| `MessagingProduct` | `string` | Required | Messaging service used for the request. |
| `RecipientType` | `string` | Optional | Currently, you can only send messages to individuals.<br>**Default**: `"individual"` |
| `Sticker` | [`Models.Sticker`](../../doc/models/sticker.md) | Optional | A media object containing a sticker. Currently, we support inbound both and outbound stickers: For outbound, we only support static third-party stickers. For inbound, we support all types of stickers. The sticker needs to be 512x512 pixels and the file’s size needs to be less than 100 KB. Required when type=sticker. |
| `Template` | [`Models.Template`](../../doc/models/template.md) | Optional | A template object. Required when type=template. |
| `Text` | [`Models.Text`](../../doc/models/text.md) | Optional | Required for text messages. |
| `To` | `string` | Required | WhatsApp ID or phone number for the person you want to send a message to. |
| `Type` | [`Models.MessageTypeEnum?`](../../doc/models/message-type-enum.md) | Optional | The type of message you want to send. |
| `Video` | [`Models.Video`](../../doc/models/video.md) | Optional | A media object containing a video. Required when type=video. |

## Example (as JSON)

```json
{
  "messaging_product": "whatsapp",
  "to": "{{Recipient-Phone-Number}}",
  "type": "template",
  "template": {
    "name": "hello_world",
    "language": {
      "code": "en_US"
    }
  }
}
```

