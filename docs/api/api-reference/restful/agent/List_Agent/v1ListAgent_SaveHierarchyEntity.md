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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 357,
  "Domain": "Dashboards",
  "Name": "Schuppe-Hegmann",
  "Fullname": "laborum",
  "ParentId": 727,
  "Children": [
    {
      "HierarchyId": 50,
      "Domain": "Dashboards",
      "Name": "Thiel-Balistreri",
      "Fullname": "porro",
      "ParentId": 965,
      "Children": [
        {},
        {}
      ],
      "Registered": "2018-10-17T16:48:29.9229229+02:00",
      "RegisteredAssociateId": 193,
      "Updated": "1997-05-09T16:48:29.9229229+02:00",
      "UpdatedAssociateId": 984
    }
  ],
  "Registered": "2014-02-27T16:48:29.9229229+01:00",
  "RegisteredAssociateId": 316,
  "Updated": "2009-04-15T16:48:29.9229229+02:00",
  "UpdatedAssociateId": 206
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 657,
  "Domain": "Dashboards",
  "Name": "Sporer, Johns and Abernathy",
  "Fullname": "occaecati",
  "ParentId": 53,
  "Children": [
    {
      "HierarchyId": 865,
      "Domain": "Dashboards",
      "Name": "Wisoky-Kuhlman",
      "Fullname": "in",
      "ParentId": 968,
      "Children": [
        {},
        {}
      ],
      "Registered": "1995-11-11T16:48:29.9249269+01:00",
      "RegisteredAssociateId": 181,
      "Updated": "2000-10-10T16:48:29.9249269+02:00",
      "UpdatedAssociateId": 811,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 97
        }
      }
    }
  ],
  "Registered": "2012-12-10T16:48:29.9249269+01:00",
  "RegisteredAssociateId": 253,
  "Updated": "2000-09-16T16:48:29.9249269+02:00",
  "UpdatedAssociateId": 906,
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
      "FieldLength": 944
    }
  }
}
```