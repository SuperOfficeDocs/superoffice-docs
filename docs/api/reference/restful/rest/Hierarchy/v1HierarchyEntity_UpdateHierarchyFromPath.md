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

## Response

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 14,
  "Domain": "Dashboards",
  "Name": "Weimann, Bednar and Hyatt",
  "Fullname": "reprehenderit",
  "ParentId": 324,
  "Children": [
    {
      "HierarchyId": 79,
      "Domain": "Dashboards",
      "Name": "Murray, Schulist and Russel",
      "Fullname": "tenetur",
      "ParentId": 847,
      "Children": [
        {},
        {}
      ],
      "Registered": "2012-05-03T11:10:52.9181833+02:00",
      "RegisteredAssociateId": 713,
      "Updated": "2004-03-12T11:10:52.9181833+01:00",
      "UpdatedAssociateId": 413
    }
  ],
  "Registered": "2004-12-03T11:10:52.9181833+01:00",
  "RegisteredAssociateId": 424,
  "Updated": "2003-05-22T11:10:52.9181833+02:00",
  "UpdatedAssociateId": 606
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 769,
  "Domain": "Dashboards",
  "Name": "Breitenberg-Kovacek",
  "Fullname": "soluta",
  "ParentId": 772,
  "Children": [
    {
      "HierarchyId": 625,
      "Domain": "Dashboards",
      "Name": "D'Amore-Cormier",
      "Fullname": "rerum",
      "ParentId": 343,
      "Children": [
        {},
        {}
      ],
      "Registered": "2018-10-22T11:10:52.9191854+02:00",
      "RegisteredAssociateId": 687,
      "Updated": "2015-06-01T11:10:52.9191854+02:00",
      "UpdatedAssociateId": 863,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 486
        }
      }
    }
  ],
  "Registered": "2014-04-24T11:10:52.9191854+02:00",
  "RegisteredAssociateId": 34,
  "Updated": "2021-05-12T11:10:52.9191854+02:00",
  "UpdatedAssociateId": 228,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 678
    }
  }
}
```
