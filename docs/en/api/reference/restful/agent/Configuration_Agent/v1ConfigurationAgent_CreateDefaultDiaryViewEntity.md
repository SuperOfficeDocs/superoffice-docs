---
title: POST Agents/Configuration/CreateDefaultDiaryViewEntity
uid: v1ConfigurationAgent_CreateDefaultDiaryViewEntity
generated: true
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: TimeZoneData

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Configuration/CreateDefaultDiaryViewEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 145,
  "Name": "Wolf, Heaney and Hansen",
  "Tooltip": "in",
  "VisibleColumns": 522,
  "Rank": 570,
  "AssocId": 677,
  "AssociateList": [
    {
      "Id": 839,
      "Name": "Schimmel Inc and Sons",
      "ToolTip": "In ea non facere consequatur quisquam voluptatibus error.",
      "Deleted": false,
      "Rank": 444,
      "Type": "est",
      "ColorBlock": 156,
      "IconHint": "quos",
      "Selected": true,
      "LastChanged": "2010-11-12T13:13:59.6881883+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Beverly Strosin",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 375
        }
      }
    }
  ],
  "TzLocationId": 704,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 372
    }
  }
}
```