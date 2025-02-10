---
title: POST Agents/List/GetHierarchyEntity
uid: v1ListAgent_GetHierarchyEntity
generated: true
---

# POST Agents/List/GetHierarchyEntity

```http
POST /api/v1/Agents/List/GetHierarchyEntity
```

Gets a HierarchyEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| hierarchyEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetHierarchyEntity?hierarchyEntityId=950
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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 125,
  "Domain": "Dashboards",
  "Name": "Murphy, Kozey and Donnelly",
  "Fullname": "odio",
  "ParentId": 63,
  "Children": [
    {
      "HierarchyId": 153,
      "Domain": "Dashboards",
      "Name": "Ryan, Hilll and Conroy",
      "Fullname": "saepe",
      "ParentId": 553,
      "Children": [
        {},
        {}
      ],
      "Registered": "2012-12-23T12:01:27.9627939+01:00",
      "RegisteredAssociateId": 620,
      "Updated": "1998-02-27T12:01:27.9627939+01:00",
      "UpdatedAssociateId": 530,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 317
        }
      }
    }
  ],
  "Registered": "2013-12-03T12:01:27.9627939+01:00",
  "RegisteredAssociateId": 412,
  "Updated": "2024-04-23T12:01:27.9627939+02:00",
  "UpdatedAssociateId": 655,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 91
    }
  }
}
```