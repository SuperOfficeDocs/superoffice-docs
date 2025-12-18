---
title: GET Contact/Duplicates/{name}
uid: v1ContactEntity_GetNameDepartmentDuplicates
generated: true
content_type: reference
---

# GET Contact/Duplicates/{name}

```http
GET /api/v1/Contact/Duplicates/{name}
```

Get duplicates based on the contact name and department






| Path Part | Type | Description |
|-----------|------|-------------|
| name | string | Name used for lookup **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| department | string |  Department used for lookup (if any) |

```http
GET /api/v1/Contact/Duplicates/{name}?department=vero
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


## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| RuleName | string | Identifying name for rule |
| SoPrimaryKey | int32 | Identity of an entry in the SuperOffice database. Should be 0 for matches from external systems. |
| EntryName | string | Name of duplicate entry |
| EntryIdentifier | string | String identifier for entry. Typically used to identify an entry in an external system. |
| RuleDisplayName | string | Short name of rule to display to user |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

[!include[sample request](../../samples/rest/request/v1ContactEntity_GetNameDepartmentDuplicates.md)]

## Sample response

[!include[sample response](../../samples/rest/response/v1ContactEntity_GetNameDepartmentDuplicates.md)]