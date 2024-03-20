---
title: POST Agents/Configuration/SaveDiaryViewEntity
uid: v1ConfigurationAgent_SaveDiaryViewEntity
generated: true
---

# POST Agents/Configuration/SaveDiaryViewEntity

```http
POST /api/v1/Agents/Configuration/SaveDiaryViewEntity
```

Updates the existing DiaryViewEntity or creates a new DiaryViewEntity if the id parameter is empty








## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: entity 

The DiaryViewEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DiaryViewId | Integer |  |
| Name | String |  |
| Tooltip | String |  |
| VisibleColumns | Integer |  |
| Rank | Integer |  |
| AssocId | Integer |  |
| AssociateList | Array |  |
| TzLocationId | Integer |  |

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
POST /api/v1/Agents/Configuration/SaveDiaryViewEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 534,
  "Name": "McLaughlin Group",
  "Tooltip": "quis",
  "VisibleColumns": 723,
  "Rank": 938,
  "AssocId": 680,
  "AssociateList": [
    {
      "Id": 954,
      "Name": "Schumm, Kassulke and Frami",
      "ToolTip": "Qui quod deleniti aliquam nesciunt tenetur.",
      "Deleted": false,
      "Rank": 341,
      "Type": "nihil",
      "ColorBlock": 954,
      "IconHint": "rem",
      "Selected": false,
      "LastChanged": "2003-08-10T12:19:44.8361197+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "suscipit",
      "StyleHint": "expedita",
      "Hidden": false,
      "FullName": "Ferne Cartwright"
    }
  ],
  "TzLocationId": 235
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 72,
  "Name": "Bednar-O'Connell",
  "Tooltip": "minus",
  "VisibleColumns": 277,
  "Rank": 965,
  "AssocId": 66,
  "AssociateList": [
    {
      "Id": 644,
      "Name": "O'Hara Group",
      "ToolTip": "Fuga officiis vel officiis reprehenderit ut.",
      "Deleted": false,
      "Rank": 155,
      "Type": "ea",
      "ColorBlock": 131,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "1997-03-20T12:19:44.8361197+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minus",
      "StyleHint": "omnis",
      "Hidden": false,
      "FullName": "Dr. Alexzander Hilpert",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 596
        }
      }
    }
  ],
  "TzLocationId": 80,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 876
    }
  }
}
```