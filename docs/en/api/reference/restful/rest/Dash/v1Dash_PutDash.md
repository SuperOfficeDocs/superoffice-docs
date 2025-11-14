---
title: PUT Dash/{id}
uid: v1Dash_PutDash
generated: true
content_type: reference
---

# PUT Dash/{id}

```http
PUT /api/v1/Dash/{id}
```

Updates the existing Dash


NsApiSlow threshold: 5000 ms.





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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 15,
  "UniqueId": "cum",
  "Name": "Russel Group",
  "Description": "Right-sized explicit website",
  "AssociateId": 822,
  "Columns": 340,
  "Theme": null,
  "VisibleForAll": 517,
  "VisibleForAssociates": [
    128,
    917
  ],
  "VisibleForGroups": [
    241,
    114
  ],
  "PinForAll": 696,
  "PinForAssociates": [
    286,
    981
  ],
  "PinForGroups": [
    890,
    96
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 Dash updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 259,
  "UniqueId": "velit",
  "Name": "Hartmann LLC",
  "Description": "Compatible regional throughput",
  "AssociateId": 762,
  "Columns": 976,
  "Theme": null,
  "VisibleForAll": 283,
  "VisibleForAssociates": [
    46,
    790
  ],
  "VisibleForGroups": [
    111,
    991
  ],
  "PinForAll": 365,
  "PinForAssociates": [
    954,
    110
  ],
  "PinForGroups": [
    122,
    114
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 85
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```