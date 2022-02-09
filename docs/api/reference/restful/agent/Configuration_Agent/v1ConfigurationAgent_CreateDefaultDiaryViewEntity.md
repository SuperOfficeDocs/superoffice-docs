---
title: POST Agents/Configuration/CreateDefaultDiaryViewEntity
id: v1ConfigurationAgent_CreateDefaultDiaryViewEntity
---

# POST Agents/Configuration/CreateDefaultDiaryViewEntity

```http
POST /api/v1/Agents/Configuration/CreateDefaultDiaryViewEntity
```

Set default values into a new DiaryViewEntity.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DiaryViewId | int32 |  |
| Name | string |  |
| Tooltip | string |  |
| VisibleColumns | int32 |  |
| Rank | int32 |  |
| AssocId | int32 |  |
| AssociateList | array |  |
| TzLocationId | int32 |  |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Configuration/CreateDefaultDiaryViewEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 304,
  "Name": "Emmerich-Schaefer",
  "Tooltip": "quia",
  "VisibleColumns": 746,
  "Rank": 262,
  "AssocId": 47,
  "AssociateList": [
    {
      "Id": 90,
      "Name": "Larkin Inc and Sons",
      "ToolTip": "Enim eos eveniet consequatur veniam assumenda.",
      "Deleted": true,
      "Rank": 787,
      "Type": "iste",
      "ColorBlock": 22,
      "IconHint": "non",
      "Selected": false,
      "LastChanged": "2016-10-01T18:28:48.4046525+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ad",
      "StyleHint": "debitis",
      "Hidden": true,
      "FullName": "Mabelle Smitham",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 763
        }
      }
    }
  ],
  "TzLocationId": 323,
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
      "FieldLength": 450
    }
  }
}
```