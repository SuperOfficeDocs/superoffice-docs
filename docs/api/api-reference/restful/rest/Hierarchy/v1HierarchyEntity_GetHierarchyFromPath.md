---
title: GET Hierarchy/{domain}/{path}
id: v1HierarchyEntity_GetHierarchyFromPath
---

# GET Hierarchy/{domain}/{path}

```http
GET /api/v1/Hierarchy/{domain}/{path}
```

Get a hierarchy item from a path






| Path Part | Type | Description |
|-----------|------|-------------|
| domain | Enum: Unknown, ExtraTables, ScreenDefinitions, Scripts, Selections, ExternalDocuments, UserGroups, ExternalDocumentRelatedToSpmMessage, Dashboards | Type of items to get **Required** |
| path | string | Hierarchy path to item **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| children | bool |  Include sub-items? |

```http
GET /api/v1/Hierarchy/{domain}/{path}?children=True
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/Hierarchy/{domain}/{path}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 305,
  "Domain": "Dashboards",
  "Name": "Kilback, Kling and Walter",
  "Fullname": "at",
  "ParentId": 873,
  "Children": [
    {
      "HierarchyId": 24,
      "Domain": "Dashboards",
      "Name": "Altenwerth Group",
      "Fullname": "ut",
      "ParentId": 199,
      "Children": [
        {},
        {}
      ],
      "Registered": "2010-09-19T09:40:59.239663+02:00",
      "RegisteredAssociateId": 558,
      "Updated": "1999-12-28T09:40:59.239663+01:00",
      "UpdatedAssociateId": 524,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": "visualize transparent functionalities"
          },
          "FieldType": "System.String",
          "FieldLength": 46
        }
      }
    }
  ],
  "Registered": "2013-10-01T09:40:59.239663+02:00",
  "RegisteredAssociateId": 305,
  "Updated": "2010-09-26T09:40:59.239663+02:00",
  "UpdatedAssociateId": 551,
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": "transition rich technologies"
      },
      "FieldType": "System.Int32",
      "FieldLength": 414
    }
  }
}
```