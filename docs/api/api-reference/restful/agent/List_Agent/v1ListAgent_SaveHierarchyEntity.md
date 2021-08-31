---
title: SaveHierarchyEntity
id: v1ListAgent_SaveHierarchyEntity
---

# SaveHierarchyEntity

```http
POST /api/v1/Agents/List/SaveHierarchyEntity
```

Updates the existing HierarchyEntity or creates a new HierarchyEntity if the id parameter is empty








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

The HierarchyEntity to be saved. 

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
POST /api/v1/Agents/List/SaveHierarchyEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 138,
  "Domain": "Dashboards",
  "Name": "Barton Inc and Sons",
  "Fullname": "nihil",
  "ParentId": 277,
  "Children": [
    {
      "HierarchyId": 419,
      "Domain": "Dashboards",
      "Name": "Kilback, Spinka and Gibson",
      "Fullname": "aliquam",
      "ParentId": 502,
      "Children": [
        {},
        {}
      ],
      "Registered": "1998-01-14T14:58:04.4714655+01:00",
      "RegisteredAssociateId": 390,
      "Updated": "2015-02-24T14:58:04.4714655+01:00",
      "UpdatedAssociateId": 601
    }
  ],
  "Registered": "2013-11-12T14:58:04.4714655+01:00",
  "RegisteredAssociateId": 809,
  "Updated": "1998-08-13T14:58:04.4714655+02:00",
  "UpdatedAssociateId": 790
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 957,
  "Domain": "Dashboards",
  "Name": "Wilkinson Group",
  "Fullname": "numquam",
  "ParentId": 656,
  "Children": [
    {
      "HierarchyId": 239,
      "Domain": "Dashboards",
      "Name": "Streich, Gleason and Connelly",
      "Fullname": "eveniet",
      "ParentId": 802,
      "Children": [
        {},
        {}
      ],
      "Registered": "2020-03-10T14:58:04.4714655+01:00",
      "RegisteredAssociateId": 984,
      "Updated": "2013-04-12T14:58:04.4714655+02:00",
      "UpdatedAssociateId": 62,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 86
        }
      }
    }
  ],
  "Registered": "2016-12-18T14:58:04.4724649+01:00",
  "RegisteredAssociateId": 67,
  "Updated": "2007-07-19T14:58:04.4724649+02:00",
  "UpdatedAssociateId": 352,
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
      "FieldType": "System.String",
      "FieldLength": 767
    }
  }
}
```