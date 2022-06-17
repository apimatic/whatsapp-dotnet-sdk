
# Contact

## Structure

`Contact`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Addresses` | [`List<Models.Address>`](../../doc/models/address.md) | Optional | Full contact address(es) |
| `Birthday` | `string` | Optional | **Default**: `"YYYY-MM-DD formatted string."` |
| `Emails` | [`List<Models.EmailObject>`](../../doc/models/email-object.md) | Optional | Contact email address(es) |
| `Name` | [`Models.Name`](../../doc/models/name.md) | Required | Full contact name |
| `Org` | [`Models.Org`](../../doc/models/org.md) | Optional | Contact organization information |
| `Phones` | [`List<Models.PhoneObject>`](../../doc/models/phone-object.md) | Optional | Contact phone number(s) |
| `Urls` | [`List<Models.UrlObject>`](../../doc/models/url-object.md) | Optional | Contact URL(s) |

## Example (as JSON)

```json
{
  "addresses": [
    {
      "street": "<ADDRESS_STREET>",
      "city": "<ADDRESS_CITY>",
      "state": "<ADDRESS_STATE>",
      "zip": "<ADDRESS_ZIP>",
      "country": "<ADDRESS_COUNTRY>",
      "country_code": "<ADDRESS_COUNTRY_CODE>",
      "type": "WORK"
    }
  ],
  "birthday": "<CONTACT_BIRTHDAY>",
  "emails": [
    {
      "email": "<CONTACT_EMAIL>",
      "type": "HOME"
    }
  ],
  "name": {
    "formatted_name": "<CONTACT_FORMATTED_NAME>",
    "first_name": "<CONTACT_FIRST_NAME>",
    "last_name": "<CONTACT_LAST_NAME>",
    "middle_name": "<CONTACT_MIDDLE_NAME>",
    "suffix": "<CONTACT_SUFFIX>",
    "prefix": "<CONTACT_PREFIX>"
  },
  "org": {
    "company": "<CONTACT_ORG_COMPANY>",
    "department": "<CONTACT_ORG_DEPARTMENT>",
    "title": "<CONTACT_ORG_TITLE>"
  },
  "phones": [
    {
      "phone": "<CONTACT_PHONE>",
      "wa_id": "<CONTACT_WA_ID>",
      "type": "WORK"
    }
  ],
  "urls": [
    {
      "url": "<CONTACT_URL>",
      "type": "HOME"
    }
  ]
}
```

