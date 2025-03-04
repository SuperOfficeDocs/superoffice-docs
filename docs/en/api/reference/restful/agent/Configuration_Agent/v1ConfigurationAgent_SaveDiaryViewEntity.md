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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 176,
  "Name": "Braun-Schimmel",
  "Tooltip": "et",
  "VisibleColumns": 669,
  "Rank": 264,
  "AssocId": 853,
  "AssociateList": [
    {
      "Id": 597,
      "Name": "Strosin-Moen",
      "ToolTip": "Eum reprehenderit illum voluptas eius voluptatem cupiditate deleniti.",
      "Deleted": false,
      "Rank": 351,
      "Type": "error",
      "ColorBlock": 791,
      "IconHint": "sit",
      "Selected": false,
      "LastChanged": "2002-04-25T14:13:39.7347754+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Melvin Connelly"
    }
  ],
  "TzLocationId": 493
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 692,
  "Name": "Trantow, Turner and Walker",
  "Tooltip": "nulla",
  "VisibleColumns": 995,
  "Rank": 902,
  "AssocId": 159,
  "AssociateList": [
    {
      "Id": 862,
      "Name": "Gutmann LLC",
      "ToolTip": "Culpa quia architecto nemo consequatur.",
      "Deleted": true,
      "Rank": 603,
      "Type": "natus",
      "ColorBlock": 457,
      "IconHint": "suscipit",
      "Selected": true,
      "LastChanged": "2021-02-13T14:13:39.7347754+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "fugit",
      "StyleHint": "adipisci",
      "Hidden": true,
      "FullName": "Shakira Gislason",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 717
        }
      }
    }
  ],
  "TzLocationId": 459,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 642
    }
  }
}
```