
# Send Message Response

## Structure

`SendMessageResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MessagingProduct` | `string` | Required | - |
| `Contacts` | [`List<Models.ResponseContact>`](../../doc/models/response-contact.md) | Required | - |
| `Messages` | [`List<Models.ResponseMessage>`](../../doc/models/response-message.md) | Required | - |

## Example (as JSON)

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

