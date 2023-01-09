---
title: PUT Dashboard/{id}
uid: v1Dashboard_PutDashboard
---

# PUT Dashboard/{id}

```http
PUT /api/v1/Dashboard/{id}
```

Updates the existing Dashboard






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Dashboard id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Dashboard/{id}?$select=name,department,category/id
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

## Request Body: entity 

The Dashboard to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | Integer | The dashboard id |
| AssociateId | Integer | Id of the associate who owns this dashboard |
| Caption | String | The caption for this dashboard |
| Layout | String | The dashboard layout, how the tiles are organized on the screen |
| Tiles | Array | The tiles associated with this dashboard |

## Response:

Dashboard updated.

| Response | Description |
|----------------|-------------|
| 200 | Dashboard updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: DashboardWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | The dashboard id |
| AssociateId | int32 | Id of the associate who owns this dashboard |
| Caption | string | The caption for this dashboard |
| Layout | string | The dashboard layout, how the tiles are organized on the screen |
| Tiles | array | The tiles associated with this dashboard |
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Dashboard/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 785,
  "AssociateId": 938,
  "Caption": "harum",
  "Layout": "Four",
  "Tiles": [
    {
      "DashboardTileId": 13,
      "Caption": "quae",
      "Description": "Versatile eco-centric moratorium",
      "ChartName": "Jacobi LLC",
      "ChartId": "consequatur",
      "IsDefault": false,
      "AssociateId": 974,
      "GroupId": 314,
      "SelectionId": 221,
      "Config": "nam",
      "Type": "Bignum",
      "EntityType": "Activity",
      "Options": [
        {},
        {}
      ],
      "VisibleFor": [
        {},
        {}
      ]
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 Dashboard updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 653,
  "AssociateId": 808,
  "Caption": "ratione",
  "Layout": "Four",
  "Tiles": [
    {
      "DashboardTileId": 667,
      "Caption": "voluptatem",
      "Description": "Vision-oriented bi-directional Graphic Interface",
      "ChartName": "Kerluke, Ward and Bergstrom",
      "ChartId": "illo",
      "IsDefault": true,
      "AssociateId": 298,
      "GroupId": 936,
      "SelectionId": 345,
      "Config": "voluptas",
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
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 880
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```