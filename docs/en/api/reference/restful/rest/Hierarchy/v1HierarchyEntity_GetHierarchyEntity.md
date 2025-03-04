---
title: GET Hierarchy/{id}
uid: v1HierarchyEntity_GetHierarchyEntity
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
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
  "HierarchyId": 584,
  "Domain": "Dashboards",
  "Name": "Goyette-Daniel",
  "Fullname": "ut",
  "ParentId": 76,
  "Children": [
    {
      "HierarchyId": 624,
      "Domain": "Dashboards",
      "Name": "Schoen, Renner and Balistreri",
      "Fullname": "nobis",
      "ParentId": 179,
      "Children": [
        {},
        {}
      ],
      "Registered": "2024-04-13T14:13:48.8993207+02:00",
      "RegisteredAssociateId": 767,
      "Updated": "2018-07-22T14:13:48.8993207+02:00",
      "UpdatedAssociateId": 3,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    }
  ],
  "Registered": "2017-04-11T14:13:48.8993207+02:00",
  "RegisteredAssociateId": 361,
  "Updated": "2012-01-19T14:13:48.8993207+01:00",
  "UpdatedAssociateId": 60,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 743
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```