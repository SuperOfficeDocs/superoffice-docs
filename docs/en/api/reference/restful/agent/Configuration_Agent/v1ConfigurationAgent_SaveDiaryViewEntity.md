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
  "DiaryViewId": 874,
  "Name": "Lakin-Heidenreich",
  "Tooltip": "aut",
  "VisibleColumns": 573,
  "Rank": 577,
  "AssocId": 556,
  "AssociateList": [
    {
      "Id": 472,
      "Name": "Lakin, Huel and Fahey",
      "ToolTip": "Rerum et.",
      "Deleted": false,
      "Rank": 597,
      "Type": "unde",
      "ColorBlock": 645,
      "IconHint": "possimus",
      "Selected": false,
      "LastChanged": "2012-04-26T11:44:32.9942315+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officia",
      "StyleHint": "sunt",
      "Hidden": false,
      "FullName": "Mr. Marilou Ken Brown"
    }
  ],
  "TzLocationId": 401
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 875,
  "Name": "Lueilwitz, Howell and Schamberger",
  "Tooltip": "fugiat",
  "VisibleColumns": 949,
  "Rank": 80,
  "AssocId": 230,
  "AssociateList": [
    {
      "Id": 24,
      "Name": "Ryan-Jacobs",
      "ToolTip": "Eius officiis ea quae reprehenderit suscipit pariatur.",
      "Deleted": false,
      "Rank": 128,
      "Type": "porro",
      "ColorBlock": 713,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2015-07-27T11:44:32.9942315+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dignissimos",
      "StyleHint": "consequuntur",
      "Hidden": false,
      "FullName": "Mr. Kamryn Josh Metz I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 413
        }
      }
    }
  ],
  "TzLocationId": 829,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 930
    }
  }
}
```