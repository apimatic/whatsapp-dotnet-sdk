
# Template

## Structure

`Template`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | Name of the template. |
| `Language` | [`Models.Language`](../../doc/models/language.md) | Required | Specifies the language the template may be rendered in. Only the deterministic language policy works with media template messages. |
| `Components` | [`List<Models.Component>`](../../doc/models/component.md) | Optional | Array of components objects containing the parameters of the message. |

## Example (as JSON)

```json
{
  "name": "hello_world",
  "language": {
    "code": "en_US"
  }
}
```

