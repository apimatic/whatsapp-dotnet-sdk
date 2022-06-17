
# Location

## Structure

`Location`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Latitude` | `string` | Required | Latitude of the location. |
| `Longitude` | `string` | Required | Longitude of the location. |
| `Name` | `string` | Optional | Name of the location. |
| `Address` | `string` | Optional | Address of the location. Only displayed if name is present. |

## Example (as JSON)

```json
{
  "latitude": "<LOCATION_LATITUDE>",
  "longitude": "<LOCATION_LONGITUDE>",
  "name": "<LOCATION_NAME>",
  "address": "<LOCATION_ADDRESS>"
}
```

