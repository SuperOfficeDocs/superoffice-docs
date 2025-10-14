---
title: POST Agents/List/CreateDefaultHierarchyEntity
uid: v1ListAgent_CreateDefaultHierarchyEntity
generated: true
content_type: reference
---

# POST Agents/List/CreateDefaultHierarchyEntity

```http
POST /api/v1/Agents/List/CreateDefaultHierarchyEntity
```

Loading default values into a new HierarchyEntity.


NsApiSlow threshold: 5000 ms.







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
  "HierarchyId": 777,
  "Domain": "Dashboards",
  "Name": "Goldner-Ruecker",
  "Fullname": "ut",
  "ParentId": 509,
  "Children": [
    {
      "HierarchyId": 212,
      "Domain": "Dashboards",
      "Name": "Effertz, Johns and Von",
      "Fullname": "fugit",
      "ParentId": 138,
      "Children": [
        {},
        {}
      ],
      "Registered": "2010-08-03T03:40:47.2030415+02:00",
      "RegisteredAssociateId": 623,
      "Updated": "2007-03-11T03:40:47.2030415+01:00",
      "UpdatedAssociateId": 908,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 202
        }
      }
    }
  ],
  "Registered": "2000-05-07T03:40:47.2030415+02:00",
  "RegisteredAssociateId": 138,
  "Updated": "2018-02-01T03:40:47.2030415+01:00",
  "UpdatedAssociateId": 738,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 878
    }
  }
}
```