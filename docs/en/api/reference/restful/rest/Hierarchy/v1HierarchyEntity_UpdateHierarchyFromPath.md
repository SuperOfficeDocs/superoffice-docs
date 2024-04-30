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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 392,
  "Domain": "Dashboards",
  "Name": "Koss Group",
  "Fullname": "nihil",
  "ParentId": 115,
  "Children": [
    {
      "HierarchyId": 480,
      "Domain": "Dashboards",
      "Name": "Kertzmann-Nikolaus",
      "Fullname": "rerum",
      "ParentId": 620,
      "Children": [
        {},
        {}
      ],
      "Registered": "1997-04-24T11:44:42.0077636+02:00",
      "RegisteredAssociateId": 268,
      "Updated": "1999-10-06T11:44:42.0077636+02:00",
      "UpdatedAssociateId": 875
    }
  ],
  "Registered": "2016-02-26T11:44:42.0077636+01:00",
  "RegisteredAssociateId": 259,
  "Updated": "2001-07-05T11:44:42.0077636+02:00",
  "UpdatedAssociateId": 418
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 562,
  "Domain": "Dashboards",
  "Name": "Schaden Group",
  "Fullname": "sint",
  "ParentId": 513,
  "Children": [
    {
      "HierarchyId": 415,
      "Domain": "Dashboards",
      "Name": "Stracke Group",
      "Fullname": "et",
      "ParentId": 970,
      "Children": [
        {},
        {}
      ],
      "Registered": "1998-12-24T11:44:42.0077636+01:00",
      "RegisteredAssociateId": 654,
      "Updated": "2020-02-03T11:44:42.0077636+01:00",
      "UpdatedAssociateId": 916,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 615
        }
      }
    }
  ],
  "Registered": "2023-12-09T11:44:42.0077636+01:00",
  "RegisteredAssociateId": 276,
  "Updated": "2003-01-03T11:44:42.0077636+01:00",
  "UpdatedAssociateId": 33,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 626
    }
  }
}
```