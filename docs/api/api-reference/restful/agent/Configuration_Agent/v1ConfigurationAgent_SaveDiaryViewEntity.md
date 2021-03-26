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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 538,
  "Name": "Zemlak Group",
  "Tooltip": "doloremque",
  "VisibleColumns": 950,
  "Rank": 482,
  "AssocId": 762,
  "AssociateList": [
    {
      "Id": 237,
      "Name": "Tremblay-Nitzsche",
      "ToolTip": "Nihil est nisi veniam quia fugiat.",
      "Deleted": true,
      "Rank": 480,
      "Type": "consequatur",
      "ColorBlock": 700,
      "IconHint": "dolores",
      "Selected": true,
      "LastChanged": "2019-08-08T16:48:29.0040442+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sit",
      "StyleHint": "magni",
      "Hidden": false,
      "FullName": "Nadia Daniel"
    }
  ],
  "TzLocationId": 725
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 635,
  "Name": "Padberg Group",
  "Tooltip": "laborum",
  "VisibleColumns": 551,
  "Rank": 729,
  "AssocId": 532,
  "AssociateList": [
    {
      "Id": 765,
      "Name": "O'Conner LLC",
      "ToolTip": "Iusto id eius nesciunt et.",
      "Deleted": true,
      "Rank": 488,
      "Type": "occaecati",
      "ColorBlock": 178,
      "IconHint": "delectus",
      "Selected": false,
      "LastChanged": "1999-09-03T16:48:29.0049251+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolore",
      "StyleHint": "nesciunt",
      "Hidden": true,
      "FullName": "Hazel Thompson",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 351
        }
      }
    }
  ],
  "TzLocationId": 970,
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
      "FieldLength": 457
    }
  }
}
```