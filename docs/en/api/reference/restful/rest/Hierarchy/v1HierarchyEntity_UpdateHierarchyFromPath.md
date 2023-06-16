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
  "HierarchyId": 753,
  "Domain": "Dashboards",
  "Name": "O'Conner, Mayert and Skiles",
  "Fullname": "amet",
  "ParentId": 416,
  "Children": [
    {
      "HierarchyId": 228,
      "Domain": "Dashboards",
      "Name": "Mayert-Hartmann",
      "Fullname": "eaque",
      "ParentId": 333,
      "Children": [
        {},
        {}
      ],
      "Registered": "2008-06-03T16:00:47.9928249+02:00",
      "RegisteredAssociateId": 115,
      "Updated": "2022-08-14T16:00:47.9928249+02:00",
      "UpdatedAssociateId": 5
    }
  ],
  "Registered": "2014-03-17T16:00:47.9928249+01:00",
  "RegisteredAssociateId": 393,
  "Updated": "2005-09-27T16:00:47.9928249+02:00",
  "UpdatedAssociateId": 698
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 307,
  "Domain": "Dashboards",
  "Name": "Mohr LLC",
  "Fullname": "omnis",
  "ParentId": 695,
  "Children": [
    {
      "HierarchyId": 547,
      "Domain": "Dashboards",
      "Name": "Murazik-Cummings",
      "Fullname": "enim",
      "ParentId": 434,
      "Children": [
        {},
        {}
      ],
      "Registered": "2004-03-18T16:00:47.9928249+01:00",
      "RegisteredAssociateId": 791,
      "Updated": "2001-11-17T16:00:47.9928249+01:00",
      "UpdatedAssociateId": 133,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 259
        }
      }
    }
  ],
  "Registered": "2019-07-21T16:00:47.9928249+02:00",
  "RegisteredAssociateId": 790,
  "Updated": "2010-12-21T16:00:47.9928249+01:00",
  "UpdatedAssociateId": 504,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 454
    }
  }
}
```