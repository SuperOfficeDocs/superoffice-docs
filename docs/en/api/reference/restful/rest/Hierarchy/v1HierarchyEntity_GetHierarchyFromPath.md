---
title: GET Hierarchy/{domain}/{path}
uid: v1HierarchyEntity_GetHierarchyFromPath
---

# GET Hierarchy/{domain}/{path}

```http
GET /api/v1/Hierarchy/{domain}/{path}
```

Get a hierarchy item from a path






| Path Part | Type | Description |
|-----------|------|-------------|
| domain | Enum: Unknown, ExtraTables, ScreenDefinitions, Scripts, Selections, ExternalDocuments, UserGroups, ExternalDocumentRelatedToSpmMessage, Dashboards, EmailFlows | Type of items to get **Required** |
| path | string | Hierarchy path to item **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| children | bool |  Include sub-items? |

```http
GET /api/v1/Hierarchy/{domain}/{path}?children=False
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
GET /api/v1/Hierarchy/{domain}/{path}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 500,
  "Domain": "Dashboards",
  "Name": "Sipes-Cruickshank",
  "Fullname": "tempore",
  "ParentId": 937,
  "Children": [
    {
      "HierarchyId": 452,
      "Domain": "Dashboards",
      "Name": "Upton-Ritchie",
      "Fullname": "consequatur",
      "ParentId": 60,
      "Children": [
        {},
        {}
      ],
      "Registered": "2006-09-02T15:29:29.7866983+02:00",
      "RegisteredAssociateId": 442,
      "Updated": "2012-02-07T15:29:29.7866983+01:00",
      "UpdatedAssociateId": 510,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 776
        }
      }
    }
  ],
  "Registered": "2002-11-17T15:29:29.787198+01:00",
  "RegisteredAssociateId": 177,
  "Updated": "2002-01-11T15:29:29.787198+01:00",
  "UpdatedAssociateId": 470,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 550
    }
  }
}
```