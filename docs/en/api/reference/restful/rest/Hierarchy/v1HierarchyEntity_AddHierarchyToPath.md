---
title: POST Hierarchy/{domain}/{path}
uid: v1HierarchyEntity_AddHierarchyToPath
generated: true
---

# POST Hierarchy/{domain}/{path}

```http
POST /api/v1/Hierarchy/{domain}/{path}
```

Add a hierarchy item to a path






| Path Part | Type | Description |
|-----------|------|-------------|
| domain | Enum: Unknown, ExtraTables, ScreenDefinitions, Scripts, Selections, ExternalDocuments, UserGroups, ExternalDocumentRelatedToSpmMessage, Dashboards, EmailFlows | Type of items to get **Required** |
| path | string | Hierarchy path to parent item **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Content-Type | Content-type of the request body: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/x-www-form-urlencoded`, `text/plain`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |

## Request Body: name 

Name of node to add 


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
POST /api/v1/Hierarchy/{domain}/{path}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 312,
  "Domain": "Dashboards",
  "Name": "Hoeger Group",
  "Fullname": "molestiae",
  "ParentId": 250,
  "Children": [
    {
      "HierarchyId": 900,
      "Domain": "Dashboards",
      "Name": "Barton LLC",
      "Fullname": "alias",
      "ParentId": 365,
      "Children": [
        {},
        {}
      ],
      "Registered": "2023-11-24T13:28:31.7104853+01:00",
      "RegisteredAssociateId": 432,
      "Updated": "2018-05-18T13:28:31.7104853+02:00",
      "UpdatedAssociateId": 17,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 151
        }
      }
    }
  ],
  "Registered": "2001-08-27T13:28:31.7104853+02:00",
  "RegisteredAssociateId": 301,
  "Updated": "2009-08-31T13:28:31.7104853+02:00",
  "UpdatedAssociateId": 224,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 350
    }
  }
}
```