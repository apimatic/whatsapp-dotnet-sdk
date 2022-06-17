
# Component

## Structure

`Component`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | [`Models.ComponentTypeEnum`](../../doc/models/component-type-enum.md) | Required | Describes the component type. For text-based templates, we only support the type=body. |
| `SubType` | [`Models.SubTypeEnum?`](../../doc/models/sub-type-enum.md) | Optional | Required when type=button. Not used for the other types. Type of button to create. |
| `Parameters` | `object` | Required | Required when type=button. Array of parameter objects with the content of the message. For components of type=button, see the button parameter object. |
| `Index` | `string` | Optional | Required when type=button. Not used for the other types. Position index of the button. You can have up to 3 buttons using index values of 0 to 2. |

## Example (as JSON)

```json
{
  "type": "button",
  "sub_type": null,
  "parameters": [
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "index": null
}
```

