
# Button

## Structure

`Button`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | **Default**: `"reply"` |
| `Title` | `string` | Optional | Button title. It cannot be an empty string and must be unique within the message. Emojis are supported, markdown is not.<br>**Constraints**: *Maximum Length*: `20` |
| `Id` | `string` | Optional | Unique identifier for your button. This ID is returned in the webhook when the button is clicked by the user.<br>**Constraints**: *Maximum Length*: `256` |

## Example (as JSON)

```json
{
  "type": "reply"
}
```

