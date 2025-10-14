---
title: POST Agents/List/GetHierarchyEntity
uid: v1ListAgent_GetHierarchyEntity
generated: true
content_type: reference
---

# POST Agents/List/GetHierarchyEntity

```http
POST /api/v1/Agents/List/GetHierarchyEntity
```

Gets a HierarchyEntity object.


NsApiSlow threshold: 5000 ms.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| hierarchyEntityId | int32 | **Required** The identifier of the HierarchyEntity object |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetHierarchyEntity?hierarchyEntityId=351
POST /api/v1/Agents/List/GetHierarchyEntity?$select=name,department,category/id
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
POST /api/v1/Agents/List/GetHierarchyEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 480,
  "Domain": "Dashboards",
  "Name": "Hilpert, Hettinger and Rowe",
  "Fullname": "laboriosam",
  "ParentId": 152,
  "Children": [
    {
      "HierarchyId": 330,
      "Domain": "Dashboards",
      "Name": "Franecki, Schumm and Shanahan",
      "Fullname": "harum",
      "ParentId": 268,
      "Children": [
        {},
        {}
      ],
      "Registered": "2006-09-19T03:40:47.2030415+02:00",
      "RegisteredAssociateId": 162,
      "Updated": "2000-10-11T03:40:47.2030415+02:00",
      "UpdatedAssociateId": 695,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 3
        }
      }
    }
  ],
  "Registered": "2004-05-29T03:40:47.2030415+02:00",
  "RegisteredAssociateId": 754,
  "Updated": "2004-11-05T03:40:47.2030415+01:00",
  "UpdatedAssociateId": 871,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 972
    }
  }
}
```