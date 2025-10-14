---
title: PUT Hierarchy/{domain}/{path}
uid: v1HierarchyEntity_UpdateHierarchyFromPath
generated: true
content_type: reference
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
  "HierarchyId": 492,
  "Domain": "Dashboards",
  "Name": "Ondricka LLC",
  "Fullname": "accusamus",
  "ParentId": 343,
  "Children": [
    {
      "HierarchyId": 659,
      "Domain": "Dashboards",
      "Name": "Bechtelar-Wunsch",
      "Fullname": "sunt",
      "ParentId": 702,
      "Children": [
        {},
        {}
      ],
      "Registered": "2007-08-14T03:40:55.7886484+02:00",
      "RegisteredAssociateId": 733,
      "Updated": "2020-05-16T03:40:55.7886484+02:00",
      "UpdatedAssociateId": 551
    }
  ],
  "Registered": "2006-08-05T03:40:55.7886484+02:00",
  "RegisteredAssociateId": 844,
  "Updated": "2016-02-11T03:40:55.7886484+01:00",
  "UpdatedAssociateId": 436
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 430,
  "Domain": "Dashboards",
  "Name": "Romaguera Group",
  "Fullname": "omnis",
  "ParentId": 979,
  "Children": [
    {
      "HierarchyId": 648,
      "Domain": "Dashboards",
      "Name": "Prosacco, Kling and Upton",
      "Fullname": "nam",
      "ParentId": 536,
      "Children": [
        {},
        {}
      ],
      "Registered": "2012-02-17T03:40:55.7886484+01:00",
      "RegisteredAssociateId": 181,
      "Updated": "2007-08-09T03:40:55.7886484+02:00",
      "UpdatedAssociateId": 392,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 816
        }
      }
    }
  ],
  "Registered": "2016-11-03T03:40:55.7886484+01:00",
  "RegisteredAssociateId": 207,
  "Updated": "2005-09-12T03:40:55.7886484+02:00",
  "UpdatedAssociateId": 780,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 299
    }
  }
}
```