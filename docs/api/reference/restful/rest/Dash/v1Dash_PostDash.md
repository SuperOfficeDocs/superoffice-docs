---
title: POST Dash
id: v1Dash_PostDash
---

# POST Dash

```http
POST /api/v1/Dash
```

Creates a new Dash

Calls the Dash agent service SaveDash.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Dash?$select=name,department,category/id
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

## Request Body: newEntity  

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
| 200 | OK |

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
POST /api/v1/Dash
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 931,
  "UniqueId": "qui",
  "Name": "Simonis, Franecki and Effertz",
  "Description": "Multi-layered bandwidth-monitored access",
  "AssociateId": 47,
  "Columns": 401,
  "Theme": {
    "DashboardThemeId": 987,
    "Name": "Rohan, Reichel and Douglas",
    "Config": "voluptas",
    "Rank": 278,
    "Client": "praesentium"
  },
  "VisibleForAll": 146,
  "VisibleForAssociates": [
    69,
    946
  ],
  "VisibleForGroups": [
    828,
    767
  ],
  "PinForAll": 367,
  "PinForAssociates": [
    980,
    847
  ],
  "PinForGroups": [
    363,
    521
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "DashboardId": 807,
  "UniqueId": "tempora",
  "Name": "Ward-Schiller",
  "Description": "Multi-lateral zero tolerance ability",
  "AssociateId": 279,
  "Columns": 590,
  "Theme": {
    "DashboardThemeId": 41,
    "Name": "Purdy-Stoltenberg",
    "Config": "temporibus",
    "Rank": 600,
    "Client": "cum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "exploit global platforms"
        },
        "FieldType": "System.Int32",
        "FieldLength": 172
      }
    }
  },
  "VisibleForAll": 829,
  "VisibleForAssociates": [
    169,
    114
  ],
  "VisibleForGroups": [
    17,
    107
  ],
  "PinForAll": 800,
  "PinForAssociates": [
    476,
    614
  ],
  "PinForGroups": [
    158,
    556
  ],
  "TableRight": {
    "Mask": "Delete",
    "Reason": "aggregate value-added applications"
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 488
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```