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
  "HierarchyId": 881,
  "Domain": "Dashboards",
  "Name": "Stracke, Adams and Homenick",
  "Fullname": "aut",
  "ParentId": 452,
  "Children": [
    {
      "HierarchyId": 675,
      "Domain": "Dashboards",
      "Name": "Osinski, Cole and Emard",
      "Fullname": "consequatur",
      "ParentId": 871,
      "Children": [
        {},
        {}
      ],
      "Registered": "2015-04-08T03:41:58.7773879+02:00",
      "RegisteredAssociateId": 823,
      "Updated": "1999-05-30T03:41:58.7773879+02:00",
      "UpdatedAssociateId": 737
    }
  ],
  "Registered": "2013-07-06T03:41:58.7773879+02:00",
  "RegisteredAssociateId": 860,
  "Updated": "2016-10-30T03:41:58.7773879+01:00",
  "UpdatedAssociateId": 314
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 885,
  "Domain": "Dashboards",
  "Name": "Roberts, Hintz and Erdman",
  "Fullname": "accusantium",
  "ParentId": 989,
  "Children": [
    {
      "HierarchyId": 938,
      "Domain": "Dashboards",
      "Name": "Flatley, Hoeger and Goldner",
      "Fullname": "vitae",
      "ParentId": 145,
      "Children": [
        {},
        {}
      ],
      "Registered": "2015-04-12T03:41:58.7773879+02:00",
      "RegisteredAssociateId": 236,
      "Updated": "2018-09-24T03:41:58.7773879+02:00",
      "UpdatedAssociateId": 519,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 905
        }
      }
    }
  ],
  "Registered": "2009-04-23T03:41:58.7773879+02:00",
  "RegisteredAssociateId": 728,
  "Updated": "2021-09-30T03:41:58.7773879+02:00",
  "UpdatedAssociateId": 598,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 546
    }
  }
}
```