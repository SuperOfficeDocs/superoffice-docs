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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 17,
  "Name": "O'Keefe, Blick and Gibson",
  "Tooltip": "ut",
  "VisibleColumns": 533,
  "Rank": 520,
  "AssocId": 173,
  "AssociateList": [
    {
      "Id": 586,
      "Name": "Denesik Inc and Sons",
      "ToolTip": "Hic ut perferendis.",
      "Deleted": false,
      "Rank": 887,
      "Type": "impedit",
      "ColorBlock": 803,
      "IconHint": "enim",
      "Selected": true,
      "LastChanged": "1999-09-19T03:46:54.4570178+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "voluptatem",
      "Hidden": false,
      "FullName": "Prof. Elbert Bergnaum MD"
    }
  ],
  "TzLocationId": 903
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 843,
  "Name": "Koelpin, Wolf and Simonis",
  "Tooltip": "accusamus",
  "VisibleColumns": 597,
  "Rank": 476,
  "AssocId": 522,
  "AssociateList": [
    {
      "Id": 636,
      "Name": "Rutherford, Welch and Toy",
      "ToolTip": "Ipsa porro atque explicabo possimus aut blanditiis illo.",
      "Deleted": false,
      "Rank": 472,
      "Type": "quisquam",
      "ColorBlock": 56,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "2020-03-07T03:46:54.4570178+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "iste",
      "StyleHint": "nam",
      "Hidden": false,
      "FullName": "Shanna Pagac",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 445
        }
      }
    }
  ],
  "TzLocationId": 274,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 557
    }
  }
}
```