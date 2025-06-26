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
  "DiaryViewId": 940,
  "Name": "Ernser-Hamill",
  "Tooltip": "non",
  "VisibleColumns": 264,
  "Rank": 427,
  "AssocId": 634,
  "AssociateList": [
    {
      "Id": 644,
      "Name": "Daniel-Streich",
      "ToolTip": "Facilis et dolores iure molestiae.",
      "Deleted": false,
      "Rank": 829,
      "Type": "dicta",
      "ColorBlock": 258,
      "IconHint": "perferendis",
      "Selected": false,
      "LastChanged": "2011-05-10T03:45:23.0767156+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequuntur",
      "StyleHint": "vel",
      "Hidden": true,
      "FullName": "Mrs. Joe Samara Collier DDS"
    }
  ],
  "TzLocationId": 626
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 291,
  "Name": "Crona-Cremin",
  "Tooltip": "et",
  "VisibleColumns": 74,
  "Rank": 916,
  "AssocId": 542,
  "AssociateList": [
    {
      "Id": 835,
      "Name": "Kirlin, Jakubowski and Satterfield",
      "ToolTip": "Et aspernatur debitis et modi.",
      "Deleted": false,
      "Rank": 259,
      "Type": "eveniet",
      "ColorBlock": 633,
      "IconHint": "perspiciatis",
      "Selected": true,
      "LastChanged": "2018-10-22T03:45:23.0767156+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "corporis",
      "StyleHint": "officiis",
      "Hidden": false,
      "FullName": "Eunice Bins",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 527
        }
      }
    }
  ],
  "TzLocationId": 831,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 667
    }
  }
}
```