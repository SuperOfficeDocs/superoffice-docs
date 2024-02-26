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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 685,
  "Name": "Auer LLC",
  "Tooltip": "neque",
  "VisibleColumns": 598,
  "Rank": 926,
  "AssocId": 802,
  "AssociateList": [
    {
      "Id": 650,
      "Name": "Runolfsson-Walsh",
      "ToolTip": "Vero consequatur animi alias nobis quia molestiae.",
      "Deleted": false,
      "Rank": 364,
      "Type": "suscipit",
      "ColorBlock": 764,
      "IconHint": "tempore",
      "Selected": false,
      "LastChanged": "2000-06-14T10:30:23.2418173+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "deleniti",
      "Hidden": false,
      "FullName": "Sophie Kub"
    }
  ],
  "TzLocationId": 421
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 76,
  "Name": "Boyle LLC",
  "Tooltip": "et",
  "VisibleColumns": 417,
  "Rank": 895,
  "AssocId": 648,
  "AssociateList": [
    {
      "Id": 548,
      "Name": "Heller, Rau and Nolan",
      "ToolTip": "Laborum qui velit nihil.",
      "Deleted": true,
      "Rank": 813,
      "Type": "rerum",
      "ColorBlock": 7,
      "IconHint": "illo",
      "Selected": false,
      "LastChanged": "2017-06-11T10:30:23.2418173+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "maiores",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Mrs. Patsy Ruth Wyman II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 249
        }
      }
    }
  ],
  "TzLocationId": 543,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 590
    }
  }
}
```