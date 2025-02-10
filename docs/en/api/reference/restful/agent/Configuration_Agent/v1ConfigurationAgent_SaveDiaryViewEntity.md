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
  "DiaryViewId": 242,
  "Name": "Gleichner, Lindgren and Harber",
  "Tooltip": "sunt",
  "VisibleColumns": 923,
  "Rank": 155,
  "AssocId": 589,
  "AssociateList": [
    {
      "Id": 315,
      "Name": "Paucek, Hudson and Veum",
      "ToolTip": "Incidunt modi sunt architecto.",
      "Deleted": false,
      "Rank": 258,
      "Type": "doloribus",
      "ColorBlock": 318,
      "IconHint": "eveniet",
      "Selected": false,
      "LastChanged": "2014-11-22T12:01:27.4471334+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "asperiores",
      "StyleHint": "iste",
      "Hidden": false,
      "FullName": "Prof. Briana Jacky Cremin"
    }
  ],
  "TzLocationId": 314
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 923,
  "Name": "Windler Inc and Sons",
  "Tooltip": "a",
  "VisibleColumns": 493,
  "Rank": 696,
  "AssocId": 685,
  "AssociateList": [
    {
      "Id": 775,
      "Name": "McCullough Inc and Sons",
      "ToolTip": "Sequi eligendi incidunt quis voluptatibus fugit in.",
      "Deleted": false,
      "Rank": 260,
      "Type": "accusantium",
      "ColorBlock": 406,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "2019-07-10T12:01:27.4471334+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tenetur",
      "StyleHint": "quam",
      "Hidden": false,
      "FullName": "Garth Rodriguez",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 609
        }
      }
    }
  ],
  "TzLocationId": 835,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 722
    }
  }
}
```