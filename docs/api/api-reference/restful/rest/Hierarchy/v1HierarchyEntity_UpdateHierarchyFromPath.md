---
title: PUT Hierarchy/{domain}/{path}
id: v1HierarchyEntity_UpdateHierarchyFromPath
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


## Response: object

Folder structures



Carrier object for HierarchyEntity.
Services for the HierarchyEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
PUT /api/v1/Hierarchy/{domain}/{path}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 458,
  "Domain": "Dashboards",
  "Name": "Kunze Group",
  "Fullname": "exercitationem",
  "ParentId": 589,
  "Children": [
    {
      "HierarchyId": 91,
      "Domain": "Dashboards",
      "Name": "Hane, Vandervort and Friesen",
      "Fullname": "qui",
      "ParentId": 184,
      "Children": [
        {},
        {}
      ],
      "Registered": "2004-02-26T09:40:59.239663+01:00",
      "RegisteredAssociateId": 528,
      "Updated": "2012-03-01T09:40:59.239663+01:00",
      "UpdatedAssociateId": 592
    }
  ],
  "Registered": "2005-05-19T09:40:59.239663+02:00",
  "RegisteredAssociateId": 569,
  "Updated": "2003-09-27T09:40:59.239663+02:00",
  "UpdatedAssociateId": 486
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 620,
  "Domain": "Dashboards",
  "Name": "Bergnaum LLC",
  "Fullname": "recusandae",
  "ParentId": 471,
  "Children": [
    {
      "HierarchyId": 991,
      "Domain": "Dashboards",
      "Name": "Bartell-Collier",
      "Fullname": "omnis",
      "ParentId": 256,
      "Children": [
        {},
        {}
      ],
      "Registered": "2014-02-02T09:40:59.2406626+01:00",
      "RegisteredAssociateId": 496,
      "Updated": "1996-06-17T09:40:59.2406626+02:00",
      "UpdatedAssociateId": 274,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 81
        }
      }
    }
  ],
  "Registered": "2013-01-30T09:40:59.2406626+01:00",
  "RegisteredAssociateId": 543,
  "Updated": "2016-02-07T09:40:59.2406626+01:00",
  "UpdatedAssociateId": 202,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "implement one-to-one architectures"
      },
      "FieldType": "System.String",
      "FieldLength": 355
    }
  }
}
```