
# Retrieve Media URL Response

## Structure

`RetrieveMediaURLResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MessagingProduct` | `string` | Required | - |
| `Url` | `string` | Required | - |
| `MimeType` | `string` | Required | - |
| `Sha256` | `string` | Required | - |
| `FileSize` | `string` | Required | - |
| `Id` | `string` | Required | - |

## Example (as JSON)

```json
{
  "messaging_product": "whatsapp",
  "url": "<URL>",
  "mime_type": "image/jpeg",
  "sha256": "<HASH>",
  "file_size": "303833",
  "id": "2621233374848975"
}
```

