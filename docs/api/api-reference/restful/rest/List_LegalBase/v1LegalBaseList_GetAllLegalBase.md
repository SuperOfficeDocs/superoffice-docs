---
title: GET List/LegalBase/Items
id: v1LegalBaseList_GetAllLegalBase
---

# GET List/LegalBase/Items

```http
GET /api/v1/List/LegalBase/Items
```

Gets a list of all LegalBase list items.

Calls the List agent service GetAllLegalBase.






## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| LegalBaseId | int32 | Primary key |
| Name | string | Name of legal base |
| Tooltip | string | Tooltip for this consent source |
| Rank | int32 | Rank of this consent source |
| Key | string | The key used to uniquely identify this legal base |
| Deleted | bool | true if the LegalBase is deleted |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
GET /api/v1/List/LegalBase/Items
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "LegalBaseId": 906,
    "Name": "Kub-Cole",
    "Tooltip": "est",
    "Rank": 923,
    "Key": "autem",
    "Deleted": true,
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 398
      }
    }
  }
]
```