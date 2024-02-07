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
  "DiaryViewId": 530,
  "Name": "Kilback-Nikolaus",
  "Tooltip": "quod",
  "VisibleColumns": 293,
  "Rank": 790,
  "AssocId": 120,
  "AssociateList": [
    {
      "Id": 614,
      "Name": "Cartwright-Rogahn",
      "ToolTip": "Necessitatibus deserunt ducimus eius omnis officia.",
      "Deleted": true,
      "Rank": 593,
      "Type": "est",
      "ColorBlock": 1000,
      "IconHint": "voluptas",
      "Selected": true,
      "LastChanged": "1998-06-28T16:54:54.8821705+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "odio",
      "StyleHint": "odit",
      "Hidden": false,
      "FullName": "Dion Gulgowski"
    }
  ],
  "TzLocationId": 279
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 437,
  "Name": "Kovacek Inc and Sons",
  "Tooltip": "atque",
  "VisibleColumns": 165,
  "Rank": 899,
  "AssocId": 720,
  "AssociateList": [
    {
      "Id": 887,
      "Name": "Schaefer-Schmidt",
      "ToolTip": "Quis et dignissimos blanditiis aut qui est.",
      "Deleted": false,
      "Rank": 84,
      "Type": "et",
      "ColorBlock": 713,
      "IconHint": "tempore",
      "Selected": true,
      "LastChanged": "2004-05-05T16:54:54.8831705+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "porro",
      "StyleHint": "rerum",
      "Hidden": true,
      "FullName": "Emilio Wyman MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 441
        }
      }
    }
  ],
  "TzLocationId": 117,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 131
    }
  }
}
```