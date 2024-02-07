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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 840,
  "Domain": "Dashboards",
  "Name": "Dare, Jakubowski and Eichmann",
  "Fullname": "voluptas",
  "ParentId": 795,
  "Children": [
    {
      "HierarchyId": 268,
      "Domain": "Dashboards",
      "Name": "Smitham-Hudson",
      "Fullname": "nam",
      "ParentId": 3,
      "Children": [
        {},
        {}
      ],
      "Registered": "2001-06-20T16:55:29.6644398+02:00",
      "RegisteredAssociateId": 44,
      "Updated": "2005-10-17T16:55:29.6644398+02:00",
      "UpdatedAssociateId": 824
    }
  ],
  "Registered": "2004-03-24T16:55:29.6644398+01:00",
  "RegisteredAssociateId": 780,
  "Updated": "2008-10-10T16:55:29.6644398+02:00",
  "UpdatedAssociateId": 688
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 886,
  "Domain": "Dashboards",
  "Name": "Mraz, Abernathy and Schuppe",
  "Fullname": "repellendus",
  "ParentId": 900,
  "Children": [
    {
      "HierarchyId": 480,
      "Domain": "Dashboards",
      "Name": "Stark, Treutel and Heidenreich",
      "Fullname": "quo",
      "ParentId": 215,
      "Children": [
        {},
        {}
      ],
      "Registered": "2014-06-01T16:55:29.6654609+02:00",
      "RegisteredAssociateId": 921,
      "Updated": "2001-04-12T16:55:29.6654609+02:00",
      "UpdatedAssociateId": 306,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 29
        }
      }
    }
  ],
  "Registered": "2016-08-25T16:55:29.6654609+02:00",
  "RegisteredAssociateId": 402,
  "Updated": "2023-07-20T16:55:29.6654609+02:00",
  "UpdatedAssociateId": 83,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 256
    }
  }
}
```