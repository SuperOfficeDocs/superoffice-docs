---
title: GET Hierarchy/{id}
uid: v1HierarchyEntity_GetHierarchyEntity
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


## Response:

HierarchyEntity found.

| Response | Description |
|----------------|-------------|
| 200 | HierarchyEntity found. |
| 404 | Not Found. |

### Response body: HierarchyEntityWithLinks

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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
GET /api/v1/Hierarchy/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
```

## Sample response

```http_
HTTP/1.1 200 HierarchyEntity found.
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 920,
  "Domain": "Dashboards",
  "Name": "Hahn Group",
  "Fullname": "magni",
  "ParentId": 633,
  "Children": [
    {
      "HierarchyId": 790,
      "Domain": "Dashboards",
      "Name": "Abernathy, Fisher and Feeney",
      "Fullname": "doloremque",
      "ParentId": 447,
      "Children": [
        {},
        {}
      ],
      "Registered": "1996-05-07T14:19:10.3654771+02:00",
      "RegisteredAssociateId": 952,
      "Updated": "2003-10-07T14:19:10.3654771+02:00",
      "UpdatedAssociateId": 232,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 230
        }
      }
    }
  ],
  "Registered": "2003-05-28T14:19:10.3654771+02:00",
  "RegisteredAssociateId": 570,
  "Updated": "2010-06-15T14:19:10.3654771+02:00",
  "UpdatedAssociateId": 481,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 498
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```