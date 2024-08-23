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
  "HierarchyId": 181,
  "Domain": "Dashboards",
  "Name": "Cormier, Boyer and Bergstrom",
  "Fullname": "doloremque",
  "ParentId": 494,
  "Children": [
    {
      "HierarchyId": 802,
      "Domain": "Dashboards",
      "Name": "Cartwright-Schowalter",
      "Fullname": "consequatur",
      "ParentId": 964,
      "Children": [
        {},
        {}
      ],
      "Registered": "2014-05-01T13:28:31.6948645+02:00",
      "RegisteredAssociateId": 872,
      "Updated": "2019-07-20T13:28:31.6948645+02:00",
      "UpdatedAssociateId": 722
    }
  ],
  "Registered": "2008-03-07T13:28:31.6948645+01:00",
  "RegisteredAssociateId": 597,
  "Updated": "2014-05-25T13:28:31.6948645+02:00",
  "UpdatedAssociateId": 334
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 846,
  "Domain": "Dashboards",
  "Name": "Bechtelar-Balistreri",
  "Fullname": "voluptatibus",
  "ParentId": 936,
  "Children": [
    {
      "HierarchyId": 932,
      "Domain": "Dashboards",
      "Name": "Tremblay-Erdman",
      "Fullname": "qui",
      "ParentId": 26,
      "Children": [
        {},
        {}
      ],
      "Registered": "2017-06-09T13:28:31.6948645+02:00",
      "RegisteredAssociateId": 235,
      "Updated": "2001-07-08T13:28:31.6948645+02:00",
      "UpdatedAssociateId": 164,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 487
        }
      }
    }
  ],
  "Registered": "2011-03-14T13:28:31.6948645+01:00",
  "RegisteredAssociateId": 512,
  "Updated": "2000-09-25T13:28:31.6948645+02:00",
  "UpdatedAssociateId": 464,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 695
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```