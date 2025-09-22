---
title: PUT Hierarchy/{domain}/{path}
uid: v1HierarchyEntity_UpdateHierarchyFromPath
generated: true
content_type: reference
---

# PUT Hierarchy/{domain}/{path}

```http
PUT /api/v1/Hierarchy/{domain}/{path}
```

Update a hierarchy item from a path






| Path Part | Type | Description |
|-----------|------|-------------|
| domain | Enum: Unknown, ExtraTables, ScreenDefinitions, Scripts, Selections, ExternalDocuments, UserGroups, ExternalDocumentRelatedToSpmMessage, Dashboards, EmailFlows | Type of items to get **Required** |
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
| HierarchyId | Integer | The primary key (auto-incremented) |
| Domain | String | Domain seperating the different hierarchy |
| Name | String | Name of this hierarchy folder. |
| Fullname | String | The full name of this category, i.e. Foo/bar/test. |
| ParentId | Integer | Parent table |
| Children | Array | Sub-items, if any. |
| Registered | String | Registered when  in UTC. |
| RegisteredAssociateId | Integer | Registered by whom |
| Updated | String | Last updated when  in UTC. |
| UpdatedAssociateId | Integer | Last updated by whom |

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
PUT /api/v1/Hierarchy/{domain}/{path}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 221,
  "Domain": "Dashboards",
  "Name": "Pfeffer, Oberbrunner and Beahan",
  "Fullname": "unde",
  "ParentId": 770,
  "Children": [
    {
      "HierarchyId": 930,
      "Domain": "Dashboards",
      "Name": "Oberbrunner-Hayes",
      "Fullname": "sit",
      "ParentId": 491,
      "Children": [
        {},
        {}
      ],
      "Registered": "2023-07-01T11:24:53.3124447+02:00",
      "RegisteredAssociateId": 386,
      "Updated": "2023-04-26T11:24:53.3124447+02:00",
      "UpdatedAssociateId": 551
    }
  ],
  "Registered": "1999-08-09T11:24:53.3124447+02:00",
  "RegisteredAssociateId": 399,
  "Updated": "2002-10-07T11:24:53.3124447+02:00",
  "UpdatedAssociateId": 760
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HierarchyId": 305,
  "Domain": "Dashboards",
  "Name": "Cummings, Cummings and Greenfelder",
  "Fullname": "facilis",
  "ParentId": 538,
  "Children": [
    {
      "HierarchyId": 254,
      "Domain": "Dashboards",
      "Name": "Bernier, Rodriguez and Stark",
      "Fullname": "molestiae",
      "ParentId": 518,
      "Children": [
        {},
        {}
      ],
      "Registered": "2000-04-21T11:24:53.3124447+02:00",
      "RegisteredAssociateId": 322,
      "Updated": "2010-06-26T11:24:53.3124447+02:00",
      "UpdatedAssociateId": 105,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 591
        }
      }
    }
  ],
  "Registered": "2020-03-27T11:24:53.3124447+01:00",
  "RegisteredAssociateId": 42,
  "Updated": "2020-11-02T11:24:53.3124447+01:00",
  "UpdatedAssociateId": 515,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 443
    }
  }
}
```