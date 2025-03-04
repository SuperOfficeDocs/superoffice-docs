---
title: POST Agents/List/CreateDefaultHierarchyEntity
uid: v1ListAgent_CreateDefaultHierarchyEntity
generated: true
---

# POST Agents/List/CreateDefaultHierarchyEntity

```http
POST /api/v1/Agents/List/CreateDefaultHierarchyEntity
```

Set default values into a new HierarchyEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance







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

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: HierarchyEntity

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

## Sample request

```http!
POST /api/v1/Agents/List/CreateDefaultHierarchyEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 361,
  "Domain": "Dashboards",
  "Name": "Stracke-Lakin",
  "Fullname": "exercitationem",
  "ParentId": 4,
  "Children": [
    {
      "HierarchyId": 770,
      "Domain": "Dashboards",
      "Name": "Barton-Champlin",
      "Fullname": "voluptatem",
      "ParentId": 875,
      "Children": [
        {},
        {}
      ],
      "Registered": "2006-06-18T14:13:40.5315763+02:00",
      "RegisteredAssociateId": 940,
      "Updated": "2003-04-19T14:13:40.5315763+02:00",
      "UpdatedAssociateId": 262,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 152
        }
      }
    }
  ],
  "Registered": "2002-03-25T14:13:40.5315763+01:00",
  "RegisteredAssociateId": 107,
  "Updated": "2014-12-09T14:13:40.5315763+01:00",
  "UpdatedAssociateId": 917,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 4
    }
  }
}
```