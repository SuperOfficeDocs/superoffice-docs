---
title: PUT Hierarchy/{domain}/{path}
uid: v1HierarchyEntity_UpdateHierarchyFromPath
generated: true
---

# PUT Hierarchy/{domain}/{path}

```http
PUT /api/v1/Hierarchy/{domain}/{path}
```

Update a hierarchy item from a path






| Path Part | Type | Description |
|-----------|------|-------------|
| domain | Enum: Unknown, ExtraTables, ScreenDefinitions, Scripts, Selections, ExternalDocuments, UserGroups, ExternalDocumentRelatedToSpmMessage, Dashboards, EmailFlows | Type of items to get **Required** |
| path | string | Hierarchy path to item **Required** |



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

## Request Body: entity 

The hierarchy node to update. 

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
PUT /api/v1/Hierarchy/{domain}/{path}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 642,
  "Domain": "Dashboards",
  "Name": "Runolfsson LLC",
  "Fullname": "quis",
  "ParentId": 328,
  "Children": [
    {
      "HierarchyId": 184,
      "Domain": "Dashboards",
      "Name": "Schuppe Inc and Sons",
      "Fullname": "deleniti",
      "ParentId": 253,
      "Children": [
        {},
        {}
      ],
      "Registered": "2002-11-08T13:28:31.7104853+01:00",
      "RegisteredAssociateId": 162,
      "Updated": "2009-04-18T13:28:31.7104853+02:00",
      "UpdatedAssociateId": 360
    }
  ],
  "Registered": "2006-01-06T13:28:31.7104853+01:00",
  "RegisteredAssociateId": 258,
  "Updated": "2011-10-15T13:28:31.7104853+02:00",
  "UpdatedAssociateId": 541
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 536,
  "Domain": "Dashboards",
  "Name": "Balistreri-Runte",
  "Fullname": "perspiciatis",
  "ParentId": 822,
  "Children": [
    {
      "HierarchyId": 308,
      "Domain": "Dashboards",
      "Name": "Mante LLC",
      "Fullname": "animi",
      "ParentId": 850,
      "Children": [
        {},
        {}
      ],
      "Registered": "2004-01-11T13:28:31.7104853+01:00",
      "RegisteredAssociateId": 753,
      "Updated": "2019-03-09T13:28:31.7104853+01:00",
      "UpdatedAssociateId": 877,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 621
        }
      }
    }
  ],
  "Registered": "2014-03-08T13:28:31.7104853+01:00",
  "RegisteredAssociateId": 136,
  "Updated": "2007-05-13T13:28:31.7104853+02:00",
  "UpdatedAssociateId": 615,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 967
    }
  }
}
```