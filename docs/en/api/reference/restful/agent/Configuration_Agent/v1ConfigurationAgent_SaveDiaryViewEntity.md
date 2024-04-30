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
  "DiaryViewId": 926,
  "Name": "Toy, Schultz and Kuhic",
  "Tooltip": "quo",
  "VisibleColumns": 452,
  "Rank": 820,
  "AssocId": 931,
  "AssociateList": [
    {
      "Id": 314,
      "Name": "Grady, Mertz and Huel",
      "ToolTip": "Beatae iste magnam dolorum mollitia illum quia minus.",
      "Deleted": true,
      "Rank": 133,
      "Type": "architecto",
      "ColorBlock": 499,
      "IconHint": "libero",
      "Selected": true,
      "LastChanged": "2013-11-06T11:16:08.8347248+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quae",
      "StyleHint": "dolores",
      "Hidden": true,
      "FullName": "Jaida Mohr"
    }
  ],
  "TzLocationId": 276
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 478,
  "Name": "Rippin LLC",
  "Tooltip": "id",
  "VisibleColumns": 70,
  "Rank": 709,
  "AssocId": 302,
  "AssociateList": [
    {
      "Id": 55,
      "Name": "Balistreri Group",
      "ToolTip": "Sit et.",
      "Deleted": false,
      "Rank": 402,
      "Type": "perspiciatis",
      "ColorBlock": 559,
      "IconHint": "dolores",
      "Selected": false,
      "LastChanged": "2010-09-05T11:16:08.8347248+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repudiandae",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Clinton Paucek",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 430
        }
      }
    }
  ],
  "TzLocationId": 463,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 184
    }
  }
}
```