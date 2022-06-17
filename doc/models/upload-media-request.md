
# Upload Media Request

## Structure

`UploadMediaRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MessagingProduct` | `string` | Required | Messaging service used for the request. In this case, use whatsapp. |
| `File` | `string` | Required | Path to the file stored in your local directory. For example: "@/local/path/file.jpg". |
| `Type` | `string` | Required | Type of media file being uploaded. See Supported Media Types for more information.<br><br>Supported options for images are: `image/jpeg`, `image/png`<br><br>Supported options for documents are: `text/plain`, `application/pdf`, `application/vnd.ms-powerpoint`, `application/msword`, `application/vnd.ms-excel`, `application/vnd.openxmlformats-officedocument.wordprocessingml.document`, `application/vnd.openxmlformats-officedocument.presentationml.presentation`, `application/vnd.openxmlformats-officedocument.spreadsheetml.sheet`<br><br>Supported options for audio are: `audio/aac`, `audio/mp4`, `audio/mpeg`, `audio/amr`, `audio/ogg`, `audio/opus`<br><br>Supported options for video are: `video/mp4`, `video/3gp`<br><br>Supported options for stickers are: `image/webp` |

## Example (as JSON)

```json
{
  "messaging_product": "whatsapp",
  "file": "@/local/path/file.jpg",
  "type": "<MEDIA_TYPE>"
}
```

