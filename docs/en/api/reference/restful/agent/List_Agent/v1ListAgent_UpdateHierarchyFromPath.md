---
title: POST Agents/List/UpdateHierarchyFromPath
uid: v1ListAgent_UpdateHierarchyFromPath
generated: true
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
| Domain | String |  |
| Path | String |  |
| Entity | HierarchyEntity | Folder structures <para /> Carrier object for HierarchyEntity. Services for the HierarchyEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>. |

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
POST /api/v1/Agents/List/UpdateHierarchyFromPath
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Domain": "Dashboards",
  "Path": "id",
  "Entity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 323,
  "Domain": "Dashboards",
  "Name": "Keeling-Kshlerin",
  "Fullname": "placeat",
  "ParentId": 403,
  "Children": [
    {
      "HierarchyId": 138,
      "Domain": "Dashboards",
      "Name": "Maggio, Beahan and Towne",
      "Fullname": "quam",
      "ParentId": 740,
      "Children": [
        {},
        {}
      ],
      "Registered": "2013-06-15T16:32:39.3051024+02:00",
      "RegisteredAssociateId": 255,
      "Updated": "2008-08-05T16:32:39.3051024+02:00",
      "UpdatedAssociateId": 525,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 253
        }
      }
    }
  ],
  "Registered": "2007-11-01T16:32:39.3051024+01:00",
  "RegisteredAssociateId": 609,
  "Updated": "1999-06-15T16:32:39.3051024+02:00",
  "UpdatedAssociateId": 915,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 738
    }
  }
}
```