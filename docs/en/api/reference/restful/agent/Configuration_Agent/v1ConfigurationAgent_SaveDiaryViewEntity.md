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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 107,
  "Name": "Mohr, Ortiz and Weber",
  "Tooltip": "blanditiis",
  "VisibleColumns": 111,
  "Rank": 954,
  "AssocId": 943,
  "AssociateList": [
    {
      "Id": 949,
      "Name": "Parisian, Luettgen and Hermann",
      "ToolTip": "Omnis quia blanditiis qui.",
      "Deleted": false,
      "Rank": 232,
      "Type": "quibusdam",
      "ColorBlock": 633,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2011-03-17T13:38:13.2646505+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "harum",
      "StyleHint": "nihil",
      "Hidden": true,
      "FullName": "Zack Parisian"
    }
  ],
  "TzLocationId": 28
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 750,
  "Name": "Feest, Goldner and Lindgren",
  "Tooltip": "sed",
  "VisibleColumns": 904,
  "Rank": 626,
  "AssocId": 266,
  "AssociateList": [
    {
      "Id": 568,
      "Name": "McKenzie, Miller and Koelpin",
      "ToolTip": "Ducimus consequatur minima illo.",
      "Deleted": false,
      "Rank": 384,
      "Type": "molestiae",
      "ColorBlock": 423,
      "IconHint": "aut",
      "Selected": false,
      "LastChanged": "2006-08-18T13:38:13.2646505+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "dolor",
      "Hidden": false,
      "FullName": "Annabel Gulgowski",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 903
        }
      }
    }
  ],
  "TzLocationId": 384,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 347
    }
  }
}
```