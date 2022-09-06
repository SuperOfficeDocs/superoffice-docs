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
| DiaryViewId | int32 |  |
| Name | string |  |
| Tooltip | string |  |
| VisibleColumns | int32 |  |
| Rank | int32 |  |
| AssocId | int32 |  |
| AssociateList | array |  |
| TzLocationId | int32 |  |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Configuration/SaveDiaryViewEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 355,
  "Name": "Schulist Group",
  "Tooltip": "est",
  "VisibleColumns": 558,
  "Rank": 419,
  "AssocId": 523,
  "AssociateList": [
    {
      "Id": 378,
      "Name": "Crooks, Fritsch and Collier",
      "ToolTip": "Maxime animi recusandae sed reiciendis.",
      "Deleted": false,
      "Rank": 121,
      "Type": "cum",
      "ColorBlock": 479,
      "IconHint": "aliquid",
      "Selected": true,
      "LastChanged": "2002-05-07T11:10:26.1955254+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "labore",
      "StyleHint": "repudiandae",
      "Hidden": false,
      "FullName": "Prof. Jessie Andres Greenholt PhD"
    }
  ],
  "TzLocationId": 627
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 543,
  "Name": "Rutherford, Lakin and Dare",
  "Tooltip": "dolore",
  "VisibleColumns": 527,
  "Rank": 956,
  "AssocId": 298,
  "AssociateList": [
    {
      "Id": 995,
      "Name": "Pacocha, Weissnat and Sanford",
      "ToolTip": "Velit quisquam nisi sunt.",
      "Deleted": false,
      "Rank": 131,
      "Type": "sunt",
      "ColorBlock": 713,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2018-04-30T11:10:26.1965257+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officia",
      "StyleHint": "eum",
      "Hidden": true,
      "FullName": "Ms. Clifton Marilie Parker DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 165
        }
      }
    }
  ],
  "TzLocationId": 544,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 299
    }
  }
}
```
