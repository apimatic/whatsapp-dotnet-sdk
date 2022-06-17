
# Get Phone Number by ID Response

## Structure

`GetPhoneNumberByIDResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VerifiedName` | `string` | Required | The verified name associated with the phone number. |
| `DisplayPhoneNumber` | `string` | Required | The string representation of the phone number. |
| `Id` | `string` | Required | The ID associated with the phone number. |
| `QualityRating` | [`Models.QualityRatingEnum`](../../doc/models/quality-rating-enum.md) | Required | The quality rating of the phone number based on how messages have been received by recipients in recent days. |

## Example (as JSON)

```json
{
  "verified_name": "Jasper's Market",
  "display_phone_number": "+1 631-555-5555",
  "id": "1906385232743451",
  "quality_rating": "GREEN"
}
```

