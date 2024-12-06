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
  "DiaryViewId": 942,
  "Name": "Barrows-Jerde",
  "Tooltip": "deserunt",
  "VisibleColumns": 712,
  "Rank": 577,
  "AssocId": 555,
  "AssociateList": [
    {
      "Id": 256,
      "Name": "Funk LLC",
      "ToolTip": "Minima aut sunt libero aut nostrum.",
      "Deleted": false,
      "Rank": 62,
      "Type": "sed",
      "ColorBlock": 350,
      "IconHint": "itaque",
      "Selected": false,
      "LastChanged": "2006-01-02T10:17:55.2227659+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "atque",
      "StyleHint": "vitae",
      "Hidden": false,
      "FullName": "Dr. Mathias Howe PhD"
    }
  ],
  "TzLocationId": 983
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 948,
  "Name": "Cummings, Marks and Ullrich",
  "Tooltip": "est",
  "VisibleColumns": 109,
  "Rank": 157,
  "AssocId": 431,
  "AssociateList": [
    {
      "Id": 150,
      "Name": "D'Amore Inc and Sons",
      "ToolTip": "Cupiditate reiciendis quod excepturi soluta.",
      "Deleted": false,
      "Rank": 501,
      "Type": "odit",
      "ColorBlock": 300,
      "IconHint": "facere",
      "Selected": true,
      "LastChanged": "2019-09-01T10:17:55.2227659+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "in",
      "Hidden": false,
      "FullName": "Arlie Ledner",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 871
        }
      }
    }
  ],
  "TzLocationId": 144,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 851
    }
  }
}
```