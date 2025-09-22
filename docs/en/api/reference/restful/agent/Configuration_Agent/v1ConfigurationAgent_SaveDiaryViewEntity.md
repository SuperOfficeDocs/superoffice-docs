---
title: POST Agents/Configuration/SaveDiaryViewEntity
uid: v1ConfigurationAgent_SaveDiaryViewEntity
generated: true
content_type: reference
---

# POST Agents/Configuration/SaveDiaryViewEntity

```http
POST /api/v1/Agents/Configuration/SaveDiaryViewEntity
```

Updates the existing DiaryViewEntity or creates a new DiaryViewEntity if the id parameter is 0.








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

## Request Body: diaryViewEntity 

The DiaryViewEntity that is saved 

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
  "DiaryViewId": 578,
  "Name": "Beier Group",
  "Tooltip": "reprehenderit",
  "VisibleColumns": 364,
  "Rank": 223,
  "AssocId": 604,
  "AssociateList": [
    {
      "Id": 217,
      "Name": "Douglas-Wolff",
      "ToolTip": "Aliquid voluptatem explicabo officia laborum.",
      "Deleted": false,
      "Rank": 541,
      "Type": "cum",
      "ColorBlock": 383,
      "IconHint": "dolore",
      "Selected": false,
      "LastChanged": "2013-07-13T11:24:47.7189228+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tenetur",
      "StyleHint": "cumque",
      "Hidden": true,
      "FullName": "Mrs. Taylor Bradtke"
    }
  ],
  "TzLocationId": 206
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 763,
  "Name": "Cormier, Stanton and Pfeffer",
  "Tooltip": "asperiores",
  "VisibleColumns": 808,
  "Rank": 178,
  "AssocId": 882,
  "AssociateList": [
    {
      "Id": 665,
      "Name": "Aufderhar-Herzog",
      "ToolTip": "Omnis sapiente.",
      "Deleted": false,
      "Rank": 206,
      "Type": "et",
      "ColorBlock": 573,
      "IconHint": "dolores",
      "Selected": true,
      "LastChanged": "2024-06-05T11:24:47.7189228+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "unde",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Arvilla Rempel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 325
        }
      }
    }
  ],
  "TzLocationId": 866,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 301
    }
  }
}
```