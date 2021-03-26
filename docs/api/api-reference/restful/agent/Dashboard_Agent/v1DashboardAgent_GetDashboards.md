---
title: POST Agents/Dashboard/GetDashboards
id: v1DashboardAgent_GetDashboards
---

# POST Agents/Dashboard/GetDashboards

```http
POST /api/v1/Agents/Dashboard/GetDashboards
```

Gets all dashboards for an associate







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dashboard/GetDashboards?$select=name,department,category/id
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

AssociateId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| AssociateId | int32 |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | The dashboard id |
| AssociateId | int32 | Id of the associate who owns this dashboard |
| Caption | string | The caption for this dashboard |
| Layout | string | The dashboard layout, how the tiles are organized on the screen |
| Tiles | array | The tiles associated with this dashboard |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Dashboard/GetDashboards
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "AssociateId": 189
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DashboardId": 10,
    "AssociateId": 511,
    "Caption": "dolor",
    "Layout": "Four",
    "Tiles": [
      {
        "DashboardTileId": 379,
        "Caption": "ut",
        "Description": "Proactive maximized open architecture",
        "ChartName": "Watsica Inc and Sons",
        "ChartId": "impedit",
        "IsDefault": false,
        "AssociateId": 299,
        "GroupId": 684,
        "SelectionId": 534,
        "Config": "nihil",
        "Type": "Bignum",
        "EntityType": "Activity",
        "Options": [
          {},
          {}
        ],
        "VisibleFor": [
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
            "FieldLength": 823
          }
        }
      }
    ],
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
        "FieldLength": 151
      }
    }
  }
]
```