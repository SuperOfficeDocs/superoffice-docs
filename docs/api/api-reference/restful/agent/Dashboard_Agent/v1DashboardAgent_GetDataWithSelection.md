---
title: GetDataWithSelection
id: v1DashboardAgent_GetDataWithSelection
---

# GetDataWithSelection

```http
POST /api/v1/Agents/Dashboard/GetDataWithSelection
```

Get data for this tile







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dashboard/GetDataWithSelection?$select=name,department,category/id
```


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

## Request Body: request  

DashboardTileId, SelectionId, Restrictions 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 |  |
| SelectionId | int32 |  |
| Restrictions | string |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Columns | array | Column information |
| Result |  | The result set |

## Sample Request

```http!
POST /api/v1/Agents/Dashboard/GetDataWithSelection
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardTileId": 475,
  "SelectionId": 6,
  "Restrictions": "accusantium"
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Columns": [
      {
        "DisplayName": "Bergstrom Inc and Sons",
        "DisplayTooltip": "dolorem",
        "DisplayType": "blanditiis",
        "CanOrderBy": false,
        "Name": "Buckridge LLC",
        "CanRestrictBy": true,
        "RestrictionType": "minus",
        "RestrictionListName": "Huel-Greenholt",
        "IsVisible": true,
        "ExtraInfo": "eos",
        "Width": "vel",
        "IconHint": "ipsa",
        "HeadingIconHint": "dolorem"
      }
    ],
    "Result": {
      "RowCount": 374,
      "Rows": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    }
  },
  {
    "Columns": [
      {
        "DisplayName": "Bergstrom Inc and Sons",
        "DisplayTooltip": "dolorem",
        "DisplayType": "blanditiis",
        "CanOrderBy": false,
        "Name": "Buckridge LLC",
        "CanRestrictBy": true,
        "RestrictionType": "minus",
        "RestrictionListName": "Huel-Greenholt",
        "IsVisible": true,
        "ExtraInfo": "eos",
        "Width": "vel",
        "IconHint": "ipsa",
        "HeadingIconHint": "dolorem"
      }
    ],
    "Result": {
      "RowCount": 374,
      "Rows": [
        {},
        {}
      ],
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 74
        }
      }
    }
  }
]
```