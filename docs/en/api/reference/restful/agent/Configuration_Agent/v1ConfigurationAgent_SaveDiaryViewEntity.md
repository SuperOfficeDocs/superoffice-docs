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
  "DiaryViewId": 887,
  "Name": "Krajcik-Beahan",
  "Tooltip": "est",
  "VisibleColumns": 410,
  "Rank": 734,
  "AssocId": 828,
  "AssociateList": [
    {
      "Id": 750,
      "Name": "Terry LLC",
      "ToolTip": "Velit voluptatibus optio quidem.",
      "Deleted": false,
      "Rank": 146,
      "Type": "ab",
      "ColorBlock": 831,
      "IconHint": "quis",
      "Selected": true,
      "LastChanged": "2023-07-02T13:28:22.1636887+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "neque",
      "StyleHint": "aliquid",
      "Hidden": false,
      "FullName": "Gail Kling"
    }
  ],
  "TzLocationId": 889
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 917,
  "Name": "Senger-Cruickshank",
  "Tooltip": "commodi",
  "VisibleColumns": 62,
  "Rank": 48,
  "AssocId": 458,
  "AssociateList": [
    {
      "Id": 800,
      "Name": "Sawayn, Mosciski and Beatty",
      "ToolTip": "Assumenda modi accusantium aut.",
      "Deleted": false,
      "Rank": 702,
      "Type": "et",
      "ColorBlock": 553,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "1998-11-26T13:28:22.1636887+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ad",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Miss Josefa Vandervort",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 25
        }
      }
    }
  ],
  "TzLocationId": 357,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 453
    }
  }
}
```