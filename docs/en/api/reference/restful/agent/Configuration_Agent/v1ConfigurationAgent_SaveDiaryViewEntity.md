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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 329,
  "Name": "Muller, Gerhold and Witting",
  "Tooltip": "ut",
  "VisibleColumns": 569,
  "Rank": 820,
  "AssocId": 757,
  "AssociateList": [
    {
      "Id": 491,
      "Name": "Lebsack LLC",
      "ToolTip": "Repudiandae sed explicabo itaque animi.",
      "Deleted": false,
      "Rank": 952,
      "Type": "aliquid",
      "ColorBlock": 861,
      "IconHint": "quo",
      "Selected": true,
      "LastChanged": "2012-10-03T02:38:20.995206+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatum",
      "StyleHint": "nihil",
      "Hidden": true,
      "FullName": "Kathleen Koss"
    }
  ],
  "TzLocationId": 204
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 231,
  "Name": "Oberbrunner-Jones",
  "Tooltip": "iure",
  "VisibleColumns": 138,
  "Rank": 383,
  "AssocId": 711,
  "AssociateList": [
    {
      "Id": 935,
      "Name": "Rice Group",
      "ToolTip": "Incidunt ut in possimus totam a ipsam enim.",
      "Deleted": false,
      "Rank": 875,
      "Type": "porro",
      "ColorBlock": 290,
      "IconHint": "sunt",
      "Selected": false,
      "LastChanged": "2013-12-21T02:38:20.995206+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quae",
      "StyleHint": "quae",
      "Hidden": true,
      "FullName": "Luisa Stracke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 735
        }
      }
    }
  ],
  "TzLocationId": 870,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 989
    }
  }
}
```