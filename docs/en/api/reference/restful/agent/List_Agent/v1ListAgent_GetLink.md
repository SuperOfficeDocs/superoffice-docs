---
title: POST Agents/List/GetLink
uid: v1ListAgent_GetLink
---

# POST Agents/List/GetLink

```http
POST /api/v1/Agents/List/GetLink
```

Gets a Link object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| linkId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/GetLink?linkId=194
POST /api/v1/Agents/List/GetLink?$select=name,department,category/id
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


## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: Link

| Property Name | Type |  Description |
|----------------|------|--------------|
| EntityName | string | Name of the entity the link points to (The destination/target entity) |
| Id | int32 | Id of the entity the link points to (The destination/target entity primary key) |
| Description | string | Link description. |
| ExtraInfo | string | Extrainfo for link. Use for information that does not have a primary key |
| LinkId | int32 | Primary key |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/GetLink
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EntityName": "Berge, Kuhlman and Sipes",
  "Id": 130,
  "Description": "Networked hybrid framework",
  "ExtraInfo": "fugiat",
  "LinkId": 305,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 26
    }
  }
}
```