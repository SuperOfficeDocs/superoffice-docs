---
title: POST Agents/List/UpdateHierarchyFromPath
id: v1ListAgent_UpdateHierarchyFromPath
---

# POST Agents/List/UpdateHierarchyFromPath

```http
POST /api/v1/Agents/List/UpdateHierarchyFromPath
```

Update a hierarchy item from a path







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/UpdateHierarchyFromPath?$select=name,department,category/id
```


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

## Request Body: request  

Domain, Path, Entity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Domain | string |  |
| Path | string |  |
| Entity |  | Folder structures <para /> Carrier object for HierarchyEntity. Services for the HierarchyEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>. |


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
POST /api/v1/Agents/List/UpdateHierarchyFromPath
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Domain": "Dashboards",
  "Path": "maiores",
  "Entity": {
    "HierarchyId": 470,
    "Domain": "Dashboards",
    "Name": "Skiles, Schuster and Nikolaus",
    "Fullname": "iure",
    "ParentId": 809,
    "Children": [
      {},
      {}
    ],
    "Registered": "2013-06-08T16:48:29.8099291+02:00",
    "RegisteredAssociateId": 35,
    "Updated": "1995-10-17T16:48:29.8099291+02:00",
    "UpdatedAssociateId": 797
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 384,
  "Domain": "Dashboards",
  "Name": "Waters Inc and Sons",
  "Fullname": "ut",
  "ParentId": 543,
  "Children": [
    {
      "HierarchyId": 611,
      "Domain": "Dashboards",
      "Name": "Vandervort, Harber and Dach",
      "Fullname": "cum",
      "ParentId": 977,
      "Children": [
        {},
        {}
      ],
      "Registered": "2007-11-06T16:48:29.8109297+01:00",
      "RegisteredAssociateId": 459,
      "Updated": "2013-03-02T16:48:29.8109297+01:00",
      "UpdatedAssociateId": 231,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 345
        }
      }
    }
  ],
  "Registered": "1994-02-26T16:48:29.8109297+01:00",
  "RegisteredAssociateId": 821,
  "Updated": "2011-05-11T16:48:29.8109297+02:00",
  "UpdatedAssociateId": 845,
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
      "FieldLength": 814
    }
  }
}
```