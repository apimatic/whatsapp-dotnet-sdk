
# Header

## Structure

`Header`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Models.HeaderTypeEnum`](../../doc/models/header-type-enum.md) | Required | The header type you would like to use. |
| `Text` | `string` | Optional | Required if type is set to text. Text for the header. Formatting allows emojis, but not markdown.<br>**Constraints**: *Maximum Length*: `60` |
| `Video` | [`Models.Video`](../../doc/models/video.md) | Optional | Required if type is set to video. Contains the media object for this video. |
| `Image` | [`Models.Image`](../../doc/models/image.md) | Optional | Required if type is set to image. Contains the media object for this image. |
| `Document` | [`Models.Document`](../../doc/models/document.md) | Optional | Required if type is set to document. Contains the media object for this document. |

## Example (as JSON)

```json
{
  "type": "text",
  "text": "<Header List Message>"
}
```

