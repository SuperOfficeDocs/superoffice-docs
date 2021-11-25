---
title: PUT Dash/{id}
id: v1Dash_PutDash
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
| DashboardId | int32 | Primary key |
| UniqueId | string | GUID identifying a default dashboard from SuperOffice |
| Name | string | The name of this dashboard |
| Description | string | Detailed description |
| AssociateId | int32 | Associate who owns this dashboard |
| Columns | int32 | How many columns there will be in the dashboard. |
| Theme |  | The theme for this dashboard |
| VisibleForAll | int32 | True if visible for all |
| VisibleForAssociates | array | Array of references to the visible for associates |
| VisibleForGroups | array | Array of references to the visible for groups |
| PinForAll | int32 | True if pinned for all |
| PinForAssociates | array | Array of references to the pinned associates |
| PinForGroups | array | Array of references to the pinned groups |


## Response: object

Dashboard configuration



Dash entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | Dash updated. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| DashboardId | int32 | Primary key |
| UniqueId | string | GUID identifying a default dashboard from SuperOffice |
| Name | string | The name of this dashboard |
| Description | string | Detailed description |
| AssociateId | int32 | Associate who owns this dashboard |
| Columns | int32 | How many columns there will be in the dashboard. |
| Theme |  | The theme for this dashboard |
| VisibleForAll | int32 | True if visible for all |
| VisibleForAssociates | array | Array of references to the visible for associates |
| VisibleForGroups | array | Array of references to the visible for groups |
| PinForAll | int32 | True if pinned for all |
| PinForAssociates | array | Array of references to the pinned associates |
| PinForGroups | array | Array of references to the pinned groups |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Dash/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 950,
  "UniqueId": "dolores",
  "Name": "McClure Inc and Sons",
  "Description": "Monitored global utilisation",
  "AssociateId": 128,
  "Columns": 823,
  "Theme": {
    "DashboardThemeId": 902,
    "Name": "Wolff, Williamson and Walker",
    "Config": "ut",
    "Rank": 461,
    "Client": "soluta"
  },
  "VisibleForAll": 933,
  "VisibleForAssociates": [
    905,
    614
  ],
  "VisibleForGroups": [
    328,
    437
  ],
  "PinForAll": 915,
  "PinForAssociates": [
    65,
    421
  ],
  "PinForGroups": [
    903,
    461
  ]
}
```

```http_
HTTP/1.1 200 Dash updated.
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 850,
  "UniqueId": "aperiam",
  "Name": "McDermott, Friesen and Runolfsson",
  "Description": "Reduced directional knowledge user",
  "AssociateId": 878,
  "Columns": 7,
  "Theme": {
    "DashboardThemeId": 512,
    "Name": "Nolan, Paucek and Raynor",
    "Config": "rem",
    "Rank": 397,
    "Client": "qui",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 976
      }
    }
  },
  "VisibleForAll": 735,
  "VisibleForAssociates": [
    832,
    464
  ],
  "VisibleForGroups": [
    822,
    384
  ],
  "PinForAll": 665,
  "PinForAssociates": [
    498,
    824
  ],
  "PinForGroups": [
    638,
    240
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
      "FieldType": "System.String",
      "FieldLength": 646
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```