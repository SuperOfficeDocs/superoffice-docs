---
title: POST Agents/List/SaveHierarchyEntity
id: v1ListAgent_SaveHierarchyEntity
---

# POST Agents/List/SaveHierarchyEntity

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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 675,
  "Domain": "Dashboards",
  "Name": "Cremin Group",
  "Fullname": "odit",
  "ParentId": 33,
  "Children": [
    {
      "HierarchyId": 545,
      "Domain": "Dashboards",
      "Name": "Kshlerin LLC",
      "Fullname": "illum",
      "ParentId": 594,
      "Children": [
        {},
        {}
      ],
      "Registered": "2009-03-08T18:28:49.4400903+01:00",
      "RegisteredAssociateId": 736,
      "Updated": "2019-02-11T18:28:49.4400903+01:00",
      "UpdatedAssociateId": 922
    }
  ],
  "Registered": "1997-12-28T18:28:49.4400903+01:00",
  "RegisteredAssociateId": 357,
  "Updated": "2009-08-04T18:28:49.4400903+02:00",
  "UpdatedAssociateId": 86
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 656,
  "Domain": "Dashboards",
  "Name": "Nitzsche Inc and Sons",
  "Fullname": "aut",
  "ParentId": 304,
  "Children": [
    {
      "HierarchyId": 502,
      "Domain": "Dashboards",
      "Name": "Welch Inc and Sons",
      "Fullname": "adipisci",
      "ParentId": 788,
      "Children": [
        {},
        {}
      ],
      "Registered": "2014-09-11T18:28:49.4420901+02:00",
      "RegisteredAssociateId": 187,
      "Updated": "2017-10-08T18:28:49.4420901+02:00",
      "UpdatedAssociateId": 622,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 210
        }
      }
    }
  ],
  "Registered": "2001-01-25T18:28:49.4420901+01:00",
  "RegisteredAssociateId": 524,
  "Updated": "2009-08-26T18:28:49.4420901+02:00",
  "UpdatedAssociateId": 286,
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
      "FieldLength": 96
    }
  }
}
```