
# Currency

## Structure

`Currency`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FallbackValue` | `string` | Required | Default text if localization fails. |
| `Code` | `string` | Required | Currency code as defined in ISO 4217. |
| `Amount1000` | `int` | Required | Amount multiplied by 1000. |

## Example (as JSON)

```json
{
  "fallback_value": "$100.99",
  "code": "USD",
  "amount_1000": 100990
}
```

