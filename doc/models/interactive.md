
# Interactive

## Structure

`Interactive`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | [`Models.Action`](../../doc/models/action.md) | Required | Action you want the user to perform after reading the message. |
| `Body` | [`Models.Body`](../../doc/models/body.md) | Required | The body of the message. Emojis and markdown are supported. |
| `Footer` | [`Models.Footer`](../../doc/models/footer.md) | Optional | The footer of the message. Emojis and markdown are supported. |
| `Header` | [`Models.Header`](../../doc/models/header.md) | Optional | Header content displayed on top of a message. |
| `Type` | [`Models.InteractiveTypeEnum`](../../doc/models/interactive-type-enum.md) | Required | The type of interactive message you want to send. |

## Example (as JSON)

```json
{
  "type": "list",
  "header": {
    "type": "text",
    "text": "<Header List Message>"
  },
  "body": {
    "text": "<List Body Message>"
  },
  "footer": {
    "text": "<Footer Message>"
  },
  "action": {
    "button": "Send",
    "sections": [
      {
        "title": "<List Category Item>",
        "rows": [
          {
            "id": "<Item ID>",
            "title": "<Item Title>",
            "description": "<Item Description>"
          },
          {
            "id": "<Item ID>",
            "title": "<Item Title>",
            "description": "<Item Description>"
          }
        ]
      },
      {
        "title": "<List Item>",
        "rows": [
          {
            "id": "<Item ID>",
            "title": "<Item Title>",
            "description": "<Item Description>"
          },
          {
            "id": "<Item ID>",
            "title": "<Item Title>",
            "description": "<Item Description>"
          }
        ]
      }
    ]
  }
}
```

