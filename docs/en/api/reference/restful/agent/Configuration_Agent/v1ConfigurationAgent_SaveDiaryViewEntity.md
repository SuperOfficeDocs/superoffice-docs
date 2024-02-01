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
  "DiaryViewId": 326,
  "Name": "Ernser, Welch and Rogahn",
  "Tooltip": "nobis",
  "VisibleColumns": 88,
  "Rank": 980,
  "AssocId": 594,
  "AssociateList": [
    {
      "Id": 580,
      "Name": "Ebert Group",
      "ToolTip": "Est blanditiis.",
      "Deleted": false,
      "Rank": 402,
      "Type": "minima",
      "ColorBlock": 636,
      "IconHint": "blanditiis",
      "Selected": false,
      "LastChanged": "2019-10-17T23:03:55.2286406+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "a",
      "StyleHint": "quae",
      "Hidden": true,
      "FullName": "Mrs. Nichole Dagmar Stark MD"
    }
  ],
  "TzLocationId": 136
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 499,
  "Name": "Welch-Rau",
  "Tooltip": "ipsum",
  "VisibleColumns": 388,
  "Rank": 893,
  "AssocId": 460,
  "AssociateList": [
    {
      "Id": 883,
      "Name": "Schuppe-Shanahan",
      "ToolTip": "Libero ea.",
      "Deleted": false,
      "Rank": 393,
      "Type": "nostrum",
      "ColorBlock": 221,
      "IconHint": "rerum",
      "Selected": false,
      "LastChanged": "2009-03-15T23:03:55.229639+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "sint",
      "Hidden": false,
      "FullName": "Magnolia Monahan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 474
        }
      }
    }
  ],
  "TzLocationId": 568,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 145
    }
  }
}
```