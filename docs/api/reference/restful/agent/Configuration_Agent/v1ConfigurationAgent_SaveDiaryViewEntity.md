---
title: POST Agents/Configuration/SaveDiaryViewEntity
id: v1ConfigurationAgent_SaveDiaryViewEntity
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


## Response: object



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Agents/Configuration/SaveDiaryViewEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 645,
  "Name": "Rowe-Gleichner",
  "Tooltip": "voluptatum",
  "VisibleColumns": 541,
  "Rank": 518,
  "AssocId": 412,
  "AssociateList": [
    {
      "Id": 662,
      "Name": "Kuvalis, Gottlieb and Schmidt",
      "ToolTip": "Aut vel.",
      "Deleted": true,
      "Rank": 641,
      "Type": "dolore",
      "ColorBlock": 624,
      "IconHint": "eos",
      "Selected": true,
      "LastChanged": "2012-03-22T18:28:48.4046525+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "necessitatibus",
      "StyleHint": "molestiae",
      "Hidden": true,
      "FullName": "Elvis Kris"
    }
  ],
  "TzLocationId": 302
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 47,
  "Name": "Pfeffer-Legros",
  "Tooltip": "hic",
  "VisibleColumns": 392,
  "Rank": 280,
  "AssocId": 281,
  "AssociateList": [
    {
      "Id": 229,
      "Name": "Doyle Group",
      "ToolTip": "Eum quo possimus omnis dolorem quo at.",
      "Deleted": true,
      "Rank": 736,
      "Type": "deserunt",
      "ColorBlock": 667,
      "IconHint": "aliquam",
      "Selected": true,
      "LastChanged": "2004-05-28T18:28:48.4056525+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "sed",
      "Hidden": true,
      "FullName": "Miss Verda Gottlieb",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 222
        }
      }
    }
  ],
  "TzLocationId": 288,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 488
    }
  }
}
```