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
  "HierarchyId": 847,
  "Domain": "Dashboards",
  "Name": "Kuhic, Keebler and Dibbert",
  "Fullname": "repellendus",
  "ParentId": 620,
  "Children": [
    {
      "HierarchyId": 246,
      "Domain": "Dashboards",
      "Name": "D'Amore Inc and Sons",
      "Fullname": "ut",
      "ParentId": 501,
      "Children": [
        {},
        {}
      ],
      "Registered": "1996-04-11T12:15:26.9816353+02:00",
      "RegisteredAssociateId": 232,
      "Updated": "2005-01-14T12:15:26.9816353+01:00",
      "UpdatedAssociateId": 562
    }
  ],
  "Registered": "1998-07-30T12:15:26.9816353+02:00",
  "RegisteredAssociateId": 152,
  "Updated": "1996-05-22T12:15:26.9816353+02:00",
  "UpdatedAssociateId": 726
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 759,
  "Domain": "Dashboards",
  "Name": "O'Connell-Hammes",
  "Fullname": "veniam",
  "ParentId": 320,
  "Children": [
    {
      "HierarchyId": 285,
      "Domain": "Dashboards",
      "Name": "Olson-Gleason",
      "Fullname": "omnis",
      "ParentId": 971,
      "Children": [
        {},
        {}
      ],
      "Registered": "2022-05-26T12:15:26.9816353+02:00",
      "RegisteredAssociateId": 343,
      "Updated": "1998-10-16T12:15:26.9816353+02:00",
      "UpdatedAssociateId": 856,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 5
        }
      }
    }
  ],
  "Registered": "2019-08-20T12:15:26.9816353+02:00",
  "RegisteredAssociateId": 478,
  "Updated": "2008-07-06T12:15:26.9816353+02:00",
  "UpdatedAssociateId": 313,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 61
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```