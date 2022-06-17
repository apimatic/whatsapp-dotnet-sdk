
# Language

## Structure

`Language`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `string` | Required | The code of the language or locale to use. Accepts both language and language_locale formats (e.g., en and en_US). |
| `Policy` | `string` | Optional | The language policy the message should follow.<br>**Default**: `"deterministic"` |

## Example (as JSON)

```json
{
  "code": "en_US"
}
```

