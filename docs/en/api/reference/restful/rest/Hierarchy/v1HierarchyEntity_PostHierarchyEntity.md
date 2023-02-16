---
title: POST Hierarchy
uid: v1HierarchyEntity_PostHierarchyEntity
---

# POST Hierarchy

```http
POST /api/v1/Hierarchy
```

Creates a new HierarchyEntity


Calls the List agent service SaveHierarchyEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Hierarchy?$select=name,department,category/id
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

The HierarchyEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| HierarchyId | Integer | The primary key (auto-incremented) |
| Domain | String | Domain seperating the different hierarchy |
| Name | String | Name of this hierarchy folder. |
| Fullname | String | The full name of this category, i.e. Foo/bar/test. |
| ParentId | Integer | Parent table |
| Children | Array | Sub-items, if any. |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociateId | Integer | Registered by whom |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociateId | Integer | Last updated by whom |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

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
POST /api/v1/Hierarchy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 39,
  "Domain": "Dashboards",
  "Name": "Auer-Schaden",
  "Fullname": "cupiditate",
  "ParentId": 313,
  "Children": [
    {
      "HierarchyId": 92,
      "Domain": "Dashboards",
      "Name": "Stroman Inc and Sons",
      "Fullname": "occaecati",
      "ParentId": 697,
      "Children": [
        {},
        {}
      ],
      "Registered": "2018-09-28T14:19:10.3654771+02:00",
      "RegisteredAssociateId": 496,
      "Updated": "2020-11-06T14:19:10.3654771+01:00",
      "UpdatedAssociateId": 994
    }
  ],
  "Registered": "2018-02-14T14:19:10.3654771+01:00",
  "RegisteredAssociateId": 407,
  "Updated": "2008-02-11T14:19:10.3654771+01:00",
  "UpdatedAssociateId": 385
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 67,
  "Domain": "Dashboards",
  "Name": "Champlin-Skiles",
  "Fullname": "perferendis",
  "ParentId": 534,
  "Children": [
    {
      "HierarchyId": 350,
      "Domain": "Dashboards",
      "Name": "Gleichner Group",
      "Fullname": "illo",
      "ParentId": 86,
      "Children": [
        {},
        {}
      ],
      "Registered": "2000-11-28T14:19:10.3654771+01:00",
      "RegisteredAssociateId": 262,
      "Updated": "2018-11-19T14:19:10.3654771+01:00",
      "UpdatedAssociateId": 74,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 828
        }
      }
    }
  ],
  "Registered": "2022-01-28T14:19:10.3654771+01:00",
  "RegisteredAssociateId": 824,
  "Updated": "2009-07-04T14:19:10.3654771+02:00",
  "UpdatedAssociateId": 727,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 278
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```