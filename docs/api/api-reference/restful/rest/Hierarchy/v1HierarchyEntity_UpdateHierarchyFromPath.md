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
  "HierarchyId": 586,
  "Domain": "Dashboards",
  "Name": "Gaylord-O'Reilly",
  "Fullname": "ad",
  "ParentId": 887,
  "Children": [
    {
      "HierarchyId": 613,
      "Domain": "Dashboards",
      "Name": "Howe-Flatley",
      "Fullname": "quo",
      "ParentId": 114,
      "Children": [
        {},
        {}
      ],
      "Registered": "2020-11-10T18:25:50.5845944+01:00",
      "RegisteredAssociateId": 818,
      "Updated": "2021-09-16T18:25:50.5845944+02:00",
      "UpdatedAssociateId": 983
    }
  ],
  "Registered": "2008-06-13T18:25:50.5845944+02:00",
  "RegisteredAssociateId": 922,
  "Updated": "2002-12-17T18:25:50.5845944+01:00",
  "UpdatedAssociateId": 413
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 93,
  "Domain": "Dashboards",
  "Name": "Buckridge-Prohaska",
  "Fullname": "iure",
  "ParentId": 805,
  "Children": [
    {
      "HierarchyId": 916,
      "Domain": "Dashboards",
      "Name": "Ryan Inc and Sons",
      "Fullname": "autem",
      "ParentId": 599,
      "Children": [
        {},
        {}
      ],
      "Registered": "2002-05-01T18:25:50.5845944+02:00",
      "RegisteredAssociateId": 371,
      "Updated": "1997-11-10T18:25:50.5845944+01:00",
      "UpdatedAssociateId": 402,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 131
        }
      }
    }
  ],
  "Registered": "2015-10-04T18:25:50.5845944+02:00",
  "RegisteredAssociateId": 739,
  "Updated": "2003-12-24T18:25:50.5845944+01:00",
  "UpdatedAssociateId": 328,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.Int32",
      "FieldLength": 881
    }
  }
}
```