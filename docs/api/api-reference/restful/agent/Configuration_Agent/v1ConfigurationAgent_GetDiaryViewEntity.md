---
title: POST Agents/Configuration/GetDiaryViewEntity
id: v1ConfigurationAgent_GetDiaryViewEntity
---

# POST Agents/Configuration/GetDiaryViewEntity

```http
POST /api/v1/Agents/Configuration/GetDiaryViewEntity
```

Gets a DiaryViewEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| diaryViewEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Configuration/GetDiaryViewEntity?diaryViewEntityId=677
POST /api/v1/Agents/Configuration/GetDiaryViewEntity?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
POST /api/v1/Agents/Configuration/GetDiaryViewEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DiaryViewId": 28,
  "Name": "Legros-Cormier",
  "Tooltip": "consequuntur",
  "VisibleColumns": 466,
  "Rank": 93,
  "AssocId": 269,
  "AssociateList": [
    {
      "Id": 30,
      "Name": "Johnson Inc and Sons",
      "ToolTip": "Adipisci et cupiditate occaecati repellat id.",
      "Deleted": false,
      "Rank": 175,
      "Type": "aut",
      "ColorBlock": 103,
      "IconHint": "omnis",
      "Selected": true,
      "LastChanged": "1995-01-28T18:28:48.3946235+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officia",
      "StyleHint": "quae",
      "Hidden": true,
      "FullName": "Libbie Prosacco",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 80
        }
      }
    }
  ],
  "TzLocationId": 794,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "cultivate sexy e-tailers"
      },
      "FieldType": "System.Int32",
      "FieldLength": 42
    }
  }
}
```