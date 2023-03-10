---
title: POST Agents/Configuration/SaveDiaryViewEntity
uid: v1ConfigurationAgent_SaveDiaryViewEntity
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

### Response body: TableRight

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Configuration/SaveDiaryViewEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 817,
  "Name": "Baumbach Group",
  "Tooltip": "dicta",
  "VisibleColumns": 702,
  "Rank": 570,
  "AssocId": 553,
  "AssociateList": [
    {
      "Id": 984,
      "Name": "Kovacek, Deckow and Tillman",
      "ToolTip": "Et vero odio officiis corporis qui earum perspiciatis.",
      "Deleted": true,
      "Rank": 974,
      "Type": "aliquid",
      "ColorBlock": 718,
      "IconHint": "odit",
      "Selected": false,
      "LastChanged": "2010-01-30T12:15:18.4157599+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "est",
      "StyleHint": "molestias",
      "Hidden": false,
      "FullName": "Mr. Lee Domenica Considine Jr."
    }
  ],
  "TzLocationId": 167
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 283,
  "Name": "Runte-Armstrong",
  "Tooltip": "corporis",
  "VisibleColumns": 7,
  "Rank": 140,
  "AssocId": 493,
  "AssociateList": [
    {
      "Id": 765,
      "Name": "Kunze Group",
      "ToolTip": "Odit earum.",
      "Deleted": false,
      "Rank": 158,
      "Type": "nobis",
      "ColorBlock": 720,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2012-12-06T12:15:18.4167596+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "excepturi",
      "Hidden": false,
      "FullName": "Mr. Rebecca Rau",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 859
        }
      }
    }
  ],
  "TzLocationId": 402,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 377
    }
  }
}
```