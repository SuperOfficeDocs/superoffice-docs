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
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 357,
  "Name": "Ernser, Funk and Paucek",
  "Tooltip": "dolor",
  "VisibleColumns": 18,
  "Rank": 586,
  "AssocId": 858,
  "AssociateList": [
    {
      "Id": 764,
      "Name": "Kihn, Hartmann and Streich",
      "ToolTip": "Repudiandae natus explicabo sed velit.",
      "Deleted": true,
      "Rank": 509,
      "Type": "sit",
      "ColorBlock": 28,
      "IconHint": "sed",
      "Selected": true,
      "LastChanged": "1997-02-22T16:48:29.0029243+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quam",
      "StyleHint": "quia",
      "Hidden": false,
      "FullName": "Caitlyn Turcotte",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 917
        }
      }
    }
  ],
  "TzLocationId": 912,
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
      "FieldLength": 937
    }
  }
}
```