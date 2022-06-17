
# Date Time Object

## Structure

`DateTimeObject`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FallbackValue` | `string` | Required | Default text. For Cloud API, we always use the fallback value, and we do not attempt to localize using other optional fields. |
| `DayOfWeek` | `int?` | Optional | - |
| `Year` | `int?` | Optional | - |
| `Month` | `int?` | Optional | - |
| `DayOfMonth` | `int?` | Optional | - |
| `Hour` | `int?` | Optional | - |
| `Minute` | `int?` | Optional | - |
| `Calendar` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "fallback_value": "February 25, 1977",
  "day_of_week": 5,
  "year": 1977,
  "month": 2,
  "day_of_month": 25,
  "hour": 15,
  "minute": 33,
  "calendar": "GREGORIAN"
}
```

