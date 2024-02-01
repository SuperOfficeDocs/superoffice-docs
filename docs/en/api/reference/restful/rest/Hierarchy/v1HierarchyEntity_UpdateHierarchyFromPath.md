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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 799,
  "Domain": "Dashboards",
  "Name": "Abernathy, Leuschke and Braun",
  "Fullname": "et",
  "ParentId": 37,
  "Children": [
    {
      "HierarchyId": 437,
      "Domain": "Dashboards",
      "Name": "Terry-Mann",
      "Fullname": "dolores",
      "ParentId": 235,
      "Children": [
        {},
        {}
      ],
      "Registered": "2002-06-25T23:04:04.2390177+02:00",
      "RegisteredAssociateId": 26,
      "Updated": "2013-09-20T23:04:04.2390177+02:00",
      "UpdatedAssociateId": 1000
    }
  ],
  "Registered": "2001-02-08T23:04:04.2390177+01:00",
  "RegisteredAssociateId": 240,
  "Updated": "2006-06-10T23:04:04.2390177+02:00",
  "UpdatedAssociateId": 383
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 184,
  "Domain": "Dashboards",
  "Name": "Crona Group",
  "Fullname": "recusandae",
  "ParentId": 437,
  "Children": [
    {
      "HierarchyId": 621,
      "Domain": "Dashboards",
      "Name": "VonRueden Inc and Sons",
      "Fullname": "deserunt",
      "ParentId": 23,
      "Children": [
        {},
        {}
      ],
      "Registered": "2001-03-23T23:04:04.2395177+01:00",
      "RegisteredAssociateId": 496,
      "Updated": "2023-10-20T23:04:04.2395177+02:00",
      "UpdatedAssociateId": 481,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 844
        }
      }
    }
  ],
  "Registered": "2011-03-28T23:04:04.2395177+02:00",
  "RegisteredAssociateId": 2,
  "Updated": "2010-01-02T23:04:04.2395177+01:00",
  "UpdatedAssociateId": 367,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 712
    }
  }
}
```