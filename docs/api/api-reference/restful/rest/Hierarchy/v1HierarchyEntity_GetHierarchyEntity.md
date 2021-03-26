---
title: GET Hierarchy/{id}
id: v1HierarchyEntity_GetHierarchyEntity
---

# GET Hierarchy/{id}

```http
GET /api/v1/Hierarchy/{id}
```

Gets a HierarchyEntity object.

Calls the List agent service GetHierarchyEntity.




| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of the HierarchyEntity to return. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
GET /api/v1/Hierarchy/{id}?$select=name,department,category/id
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

Folder structures



HierarchyEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | HierarchyEntity found. |
| 404 | Not Found. |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| HierarchyId | int32 | The primary key (auto-incremented) |
| Domain | string | Domain seperating the different hierarchy |
| Name | string | Name of this hierarchy folder. |
| Fullname | string | The full name of this category, i.e. Foo/bar/test. |
| ParentId | int32 | Parent table |
| Children | array | Sub-items, if any. |
| Registered | date-time | Registered when  in UTC. |
| RegisteredAssociateId | int32 | Registered by whom |
| Updated | date-time | Last updated when  in UTC. |
| UpdatedAssociateId | int32 | Last updated by whom |
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
GET /api/v1/Hierarchy/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 HierarchyEntity found.
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 826,
  "Domain": "Dashboards",
  "Name": "Braun Group",
  "Fullname": "voluptatem",
  "ParentId": 5,
  "Children": [
    {
      "HierarchyId": 479,
      "Domain": "Dashboards",
      "Name": "Greenholt, Douglas and Franecki",
      "Fullname": "voluptas",
      "ParentId": 415,
      "Children": [
        {},
        {}
      ],
      "Registered": "2020-05-12T09:40:59.2356629+02:00",
      "RegisteredAssociateId": 291,
      "Updated": "1995-06-30T09:40:59.2356629+02:00",
      "UpdatedAssociateId": 241,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 784
        }
      }
    }
  ],
  "Registered": "2008-02-17T09:40:59.2356629+01:00",
  "RegisteredAssociateId": 964,
  "Updated": "2018-05-23T09:40:59.2356629+02:00",
  "UpdatedAssociateId": 933,
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
      "FieldLength": 844
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```