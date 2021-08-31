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
  "HierarchyId": 551,
  "Domain": "Dashboards",
  "Name": "Moen-Schaden",
  "Fullname": "vel",
  "ParentId": 868,
  "Children": [
    {
      "HierarchyId": 838,
      "Domain": "Dashboards",
      "Name": "Hamill LLC",
      "Fullname": "qui",
      "ParentId": 764,
      "Children": [
        {},
        {}
      ],
      "Registered": "2006-11-27T15:05:42.256664+01:00",
      "RegisteredAssociateId": 277,
      "Updated": "2006-12-15T15:05:42.256664+01:00",
      "UpdatedAssociateId": 940
    }
  ],
  "Registered": "2011-09-06T15:05:42.256664+02:00",
  "RegisteredAssociateId": 243,
  "Updated": "2012-05-15T15:05:42.256664+02:00",
  "UpdatedAssociateId": 739
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 381,
  "Domain": "Dashboards",
  "Name": "Senger, Schimmel and Marvin",
  "Fullname": "et",
  "ParentId": 897,
  "Children": [
    {
      "HierarchyId": 221,
      "Domain": "Dashboards",
      "Name": "Sporer-Runolfsson",
      "Fullname": "cumque",
      "ParentId": 833,
      "Children": [
        {},
        {}
      ],
      "Registered": "2006-12-12T15:05:42.256664+01:00",
      "RegisteredAssociateId": 313,
      "Updated": "1997-08-18T15:05:42.256664+02:00",
      "UpdatedAssociateId": 251,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 545
        }
      }
    }
  ],
  "Registered": "2001-08-31T15:05:42.256664+02:00",
  "RegisteredAssociateId": 155,
  "Updated": "2018-06-28T15:05:42.256664+02:00",
  "UpdatedAssociateId": 836,
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
      "FieldLength": 793
    }
  }
}
```