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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Domain": "Dashboards",
  "Path": "voluptas",
  "Entity": {
    "HierarchyId": 864,
    "Domain": "Dashboards",
    "Name": "Will Group",
    "Fullname": "suscipit",
    "ParentId": 509,
    "Children": [
      {},
      {}
    ],
    "Registered": "2001-09-29T18:28:49.3411223+02:00",
    "RegisteredAssociateId": 994,
    "Updated": "2013-11-17T18:28:49.3411223+01:00",
    "UpdatedAssociateId": 347
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 588,
  "Domain": "Dashboards",
  "Name": "Conn-Bruen",
  "Fullname": "qui",
  "ParentId": 848,
  "Children": [
    {
      "HierarchyId": 699,
      "Domain": "Dashboards",
      "Name": "Schiller-Krajcik",
      "Fullname": "autem",
      "ParentId": 410,
      "Children": [
        {},
        {}
      ],
      "Registered": "2006-12-08T18:28:49.3411223+01:00",
      "RegisteredAssociateId": 913,
      "Updated": "1995-09-05T18:28:49.3411223+02:00",
      "UpdatedAssociateId": 882,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 951
        }
      }
    }
  ],
  "Registered": "2012-05-18T18:28:49.3411223+02:00",
  "RegisteredAssociateId": 978,
  "Updated": "2012-01-06T18:28:49.3411223+01:00",
  "UpdatedAssociateId": 290,
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
      "FieldLength": 816
    }
  }
}
```