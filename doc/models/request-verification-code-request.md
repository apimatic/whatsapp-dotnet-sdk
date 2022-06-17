
# Request Verification Code Request

## Structure

`RequestVerificationCodeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CodeMethod` | [`Models.RequestVerificationCodeMethodEnum`](../../doc/models/request-verification-code-method-enum.md) | Required | Chosen method for verification. |
| `Locale` | `string` | Required | Your locale. For example: "en_US". |

## Example (as JSON)

```json
{
  "code_method": "SMS",
  "locale": "en_US"
}
```

