---
title: SaveDiaryViewEntity
id: v1ConfigurationAgent_SaveDiaryViewEntity
---

# SaveDiaryViewEntity

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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 882,
  "Name": "Haley, Quitzon and Bashirian",
  "Tooltip": "est",
  "VisibleColumns": 386,
  "Rank": 171,
  "AssocId": 593,
  "AssociateList": [
    {
      "Id": 551,
      "Name": "Hyatt-Fadel",
      "ToolTip": "Quia esse beatae in.",
      "Deleted": false,
      "Rank": 760,
      "Type": "et",
      "ColorBlock": 206,
      "IconHint": "non",
      "Selected": false,
      "LastChanged": "2017-03-28T14:58:03.5283103+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestias",
      "StyleHint": "delectus",
      "Hidden": false,
      "FullName": "Ms. Bettie Feeney"
    }
  ],
  "TzLocationId": 594
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 512,
  "Name": "Shanahan-White",
  "Tooltip": "dolorem",
  "VisibleColumns": 977,
  "Rank": 635,
  "AssocId": 124,
  "AssociateList": [
    {
      "Id": 9,
      "Name": "Cronin LLC",
      "ToolTip": "Incidunt harum inventore voluptatem alias quod.",
      "Deleted": false,
      "Rank": 150,
      "Type": "necessitatibus",
      "ColorBlock": 210,
      "IconHint": "ab",
      "Selected": true,
      "LastChanged": "1994-11-05T14:58:03.5293106+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "error",
      "StyleHint": "neque",
      "Hidden": true,
      "FullName": "Duncan Lind",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 759
        }
      }
    }
  ],
  "TzLocationId": 718,
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
      "FieldType": "System.Int32",
      "FieldLength": 472
    }
  }
}
```