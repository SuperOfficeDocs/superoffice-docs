---
title: POST Agents/List/GetLink
id: v1ListAgent_GetLink
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
POST /api/v1/Agents/List/GetLink?linkId=398
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


## Response: object

Links two entities (contacts/projects/sales/URLs) together.



Carrier object for Link.
Services for the Link Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

| Property Name | Type |  Description |
|----------------|------|--------------|
| EntityName | string | Name of the entity the link points to (The destination/target entity) |
| Id | int32 | Id of the entity the link points to (The destination/target entity primary key) |
| Description | string | Link description. |
| ExtraInfo | string | Extrainfo for link. Use for information that does not have a primary key |
| LinkId | int32 | Primary key |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
POST /api/v1/Agents/List/GetLink
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "EntityName": "Howe, Roberts and Bruen",
  "Id": 452,
  "Description": "Intuitive systematic policy",
  "ExtraInfo": "assumenda",
  "LinkId": 927,
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
      "FieldLength": 165
    }
  }
}
```