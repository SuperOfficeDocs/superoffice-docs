---
title: POST Agents/Dashboard/GetDashboardTiles
id: v1DashboardAgent_GetDashboardTiles
---

# POST Agents/Dashboard/GetDashboardTiles

```http
POST /api/v1/Agents/Dashboard/GetDashboardTiles
```

Gets an array of dashboard tiles for the provided ids







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Dashboard/GetDashboardTiles?$select=name,department,category/id
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

DashboardTileIds 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileIds | array |  |


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardTileId | int32 | The tile id |
| Caption | string | The tile caption |
| Description | string | The tile description |
| ChartName | string | The original chart name |
| ChartId | string | The original chart Id |
| IsDefault | bool | True if this is one of the default tiles |
| AssociateId | int32 | Id of the associate who owns this tile |
| GroupId | int32 | Id of the associates primary group at storage time |
| SelectionId | int32 | The selection that defines the data filter/restrictions |
| Config | string | The tile config |
| Type | string | The tile type, what kind of tile this is |
| EntityType | string | The tile entity type |
| Options | array | The tile options |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/Dashboard/GetDashboardTiles
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardTileIds": [
    786,
    857
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "DashboardTileId": 997,
    "Caption": "earum",
    "Description": "Customizable 4th generation model",
    "ChartName": "Graham, Herzog and Kilback",
    "ChartId": "dolorum",
    "IsDefault": true,
    "AssociateId": 589,
    "GroupId": 199,
    "SelectionId": 51,
    "Config": "quas",
    "Type": "Bignum",
    "EntityType": "Activity",
    "Options": [
      {
        "Name": "Carter-Schaden",
        "Description": "Streamlined even-keeled definition",
        "Type": "Boolean",
        "ListName": "Cruickshank Inc and Sons",
        "ListItems": [
          {},
          {}
        ],
        "Value": "eligendi",
        "DefaultDataOption": false,
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 342
          }
        }
      }
    ],
    "VisibleFor": [
      {
        "VisibleId": 675,
        "Visibility": "All",
        "DisplayValue": "id",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "synergize leading-edge bandwidth"
            },
            "FieldType": "System.Int32",
            "FieldLength": 113
          }
        }
      },
      {
        "VisibleId": 675,
        "Visibility": "All",
        "DisplayValue": "id",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "synergize leading-edge bandwidth"
            },
            "FieldType": "System.Int32",
            "FieldLength": 113
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
        "FieldLength": 876
      }
    }
  }
]
```