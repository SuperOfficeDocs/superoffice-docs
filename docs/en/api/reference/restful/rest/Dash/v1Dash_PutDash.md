---
title: PUT Dash/{id}
uid: v1Dash_PutDash
generated: true
---

# PUT Dash/{id}

```http
PUT /api/v1/Dash/{id}
```

Updates the existing Dash






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The Dash id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Dash/{id}?$select=name,department,category/id
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

The Dash to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | Integer | Primary key |
| UniqueId | String | GUID identifying a default dashboard from SuperOffice |
| Name | String | The name of this dashboard |
| Description | String | Detailed description |
| AssociateId | Integer | Associate who owns this dashboard |
| Columns | Integer | How many columns there will be in the dashboard. |
| Theme | DashTheme | The theme for this dashboard |
| VisibleForAll | Integer | True if visible for all |
| VisibleForAssociates | Array | Array of references to the visible for associates |
| VisibleForGroups | Array | Array of references to the visible for groups |
| PinForAll | Integer | True if pinned for all |
| PinForAssociates | Array | Array of references to the pinned associates |
| PinForGroups | Array | Array of references to the pinned groups |

## Response:

Dash updated.

| Response | Description |
|----------------|-------------|
| 200 | Dash updated. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: DashWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | Primary key |
| UniqueId | string | GUID identifying a default dashboard from SuperOffice |
| Name | string | The name of this dashboard |
| Description | string | Detailed description |
| AssociateId | int32 | Associate who owns this dashboard |
| Columns | int32 | How many columns there will be in the dashboard. |
| Theme | DashTheme | The theme for this dashboard |
| VisibleForAll | int32 | True if visible for all |
| VisibleForAssociates | array | Array of references to the visible for associates |
| VisibleForGroups | array | Array of references to the visible for groups |
| PinForAll | int32 | True if pinned for all |
| PinForAssociates | array | Array of references to the pinned associates |
| PinForGroups | array | Array of references to the pinned groups |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Dash/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 982,
  "UniqueId": "temporibus",
  "Name": "O'Kon Group",
  "Description": "Cross-platform hybrid support",
  "AssociateId": 40,
  "Columns": 194,
  "Theme": null,
  "VisibleForAll": 160,
  "VisibleForAssociates": [
    686,
    954
  ],
  "VisibleForGroups": [
    291,
    50
  ],
  "PinForAll": 796,
  "PinForAssociates": [
    740,
    324
  ],
  "PinForGroups": [
    224,
    988
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 Dash updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 456,
  "UniqueId": "sed",
  "Name": "Schuster Group",
  "Description": "Inverse bi-directional productivity",
  "AssociateId": 649,
  "Columns": 925,
  "Theme": null,
  "VisibleForAll": 874,
  "VisibleForAssociates": [
    165,
    469
  ],
  "VisibleForGroups": [
    602,
    258
  ],
  "PinForAll": 773,
  "PinForAssociates": [
    96,
    253
  ],
  "PinForGroups": [
    116,
    332
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 276
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```