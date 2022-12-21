---
title: PUT Hierarchy/{domain}/{path}
uid: v1HierarchyEntity_UpdateHierarchyFromPath
---

# PUT Hierarchy/{domain}/{path}

```http
PUT /api/v1/Hierarchy/{domain}/{path}
```

Update a hierarchy item from a path






| Path Part | Type | Description |
|-----------|------|-------------|
| domain | Enum: Unknown, ExtraTables, ScreenDefinitions, Scripts, Selections, ExternalDocuments, UserGroups, ExternalDocumentRelatedToSpmMessage, Dashboards | Type of items to get **Required** |
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


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/Hierarchy/{domain}/{path}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 767,
  "Domain": "Dashboards",
  "Name": "McClure-Lueilwitz",
  "Fullname": "repellendus",
  "ParentId": 520,
  "Children": [
    {
      "HierarchyId": 930,
      "Domain": "Dashboards",
      "Name": "Kreiger-Reynolds",
      "Fullname": "est",
      "ParentId": 95,
      "Children": [
        {},
        {}
      ],
      "Registered": "2007-11-28T02:49:50.9952888+01:00",
      "RegisteredAssociateId": 422,
      "Updated": "2014-01-24T02:49:50.9952888+01:00",
      "UpdatedAssociateId": 438
    }
  ],
  "Registered": "2008-02-26T02:49:50.9952888+01:00",
  "RegisteredAssociateId": 981,
  "Updated": "2011-06-12T02:49:50.9952888+02:00",
  "UpdatedAssociateId": 308
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 14,
  "Domain": "Dashboards",
  "Name": "Mitchell-Prohaska",
  "Fullname": "vel",
  "ParentId": 673,
  "Children": [
    {
      "HierarchyId": 678,
      "Domain": "Dashboards",
      "Name": "Paucek, Wilderman and Willms",
      "Fullname": "iusto",
      "ParentId": 778,
      "Children": [
        {},
        {}
      ],
      "Registered": "2021-02-14T02:49:50.9952888+01:00",
      "RegisteredAssociateId": 591,
      "Updated": "2002-05-01T02:49:50.9952888+02:00",
      "UpdatedAssociateId": 972,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 351
        }
      }
    }
  ],
  "Registered": "2009-01-19T02:49:50.9952888+01:00",
  "RegisteredAssociateId": 18,
  "Updated": "2001-06-11T02:49:50.9952888+02:00",
  "UpdatedAssociateId": 415,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 851
    }
  }
}
```