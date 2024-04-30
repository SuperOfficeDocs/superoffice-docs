---
title: POST Hierarchy
uid: v1HierarchyEntity_PostHierarchyEntity
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Hierarchy
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 341,
  "Domain": "Dashboards",
  "Name": "Mueller-Wisoky",
  "Fullname": "sint",
  "ParentId": 339,
  "Children": [
    {
      "HierarchyId": 589,
      "Domain": "Dashboards",
      "Name": "Harber Inc and Sons",
      "Fullname": "perferendis",
      "ParentId": 891,
      "Children": [
        {},
        {}
      ],
      "Registered": "2020-09-28T11:16:13.93321+02:00",
      "RegisteredAssociateId": 773,
      "Updated": "2016-01-21T11:16:13.93321+01:00",
      "UpdatedAssociateId": 535
    }
  ],
  "Registered": "2009-06-12T11:16:13.93321+02:00",
  "RegisteredAssociateId": 708,
  "Updated": "2007-06-15T11:16:13.93321+02:00",
  "UpdatedAssociateId": 127
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 570,
  "Domain": "Dashboards",
  "Name": "Frami Group",
  "Fullname": "consequatur",
  "ParentId": 338,
  "Children": [
    {
      "HierarchyId": 10,
      "Domain": "Dashboards",
      "Name": "Roob-Kovacek",
      "Fullname": "ab",
      "ParentId": 177,
      "Children": [
        {},
        {}
      ],
      "Registered": "2022-06-10T11:16:13.93321+02:00",
      "RegisteredAssociateId": 695,
      "Updated": "2008-03-09T11:16:13.93321+01:00",
      "UpdatedAssociateId": 449,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 494
        }
      }
    }
  ],
  "Registered": "2022-05-27T11:16:13.93321+02:00",
  "RegisteredAssociateId": 908,
  "Updated": "2011-09-08T11:16:13.93321+02:00",
  "UpdatedAssociateId": 770,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 834
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```