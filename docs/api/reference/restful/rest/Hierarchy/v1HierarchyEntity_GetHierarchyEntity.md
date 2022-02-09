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
Accept-Language: *
```

```http_
HTTP/1.1 200 HierarchyEntity found.
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 799,
  "Domain": "Dashboards",
  "Name": "Kuhic Group",
  "Fullname": "quos",
  "ParentId": 719,
  "Children": [
    {
      "HierarchyId": 682,
      "Domain": "Dashboards",
      "Name": "Veum, Waelchi and Johnson",
      "Fullname": "sed",
      "ParentId": 551,
      "Children": [
        {},
        {}
      ],
      "Registered": "2010-01-03T18:25:50.5805945+01:00",
      "RegisteredAssociateId": 555,
      "Updated": "2007-05-18T18:25:50.5805945+02:00",
      "UpdatedAssociateId": 179,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "exploit innovative bandwidth"
          },
          "FieldType": "System.Int32",
          "FieldLength": 668
        }
      }
    }
  ],
  "Registered": "2010-02-08T18:25:50.5805945+01:00",
  "RegisteredAssociateId": 650,
  "Updated": "2019-02-05T18:25:50.5805945+01:00",
  "UpdatedAssociateId": 995,
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
      "FieldLength": 954
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```