---
title: POST Agents/List/SaveHeadingFromName
uid: v1ListAgent_SaveHeadingFromName
generated: true
---

# POST Agents/List/SaveHeadingFromName

```http
POST /api/v1/Agents/List/SaveHeadingFromName
```

Save new heading for list resolved by the provided name.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SaveHeadingFromName?$select=name,department,category/id
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

Name, Entity 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | String |  |
| Entity | HeadingEntity | The heading entity contains generic list item information <para /> Carrier object for HeadingEntity. Services for the HeadingEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: HeadingEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| HeadingId | int32 | Primary key |
| Name | string | The visible heading |
| Tooltip | string | Tooltip or other description |
| Deleted | bool | True if the heading is marked as deleted |
| Rank | int32 | Rank order |
| UdListDefinitionId | int32 | The id of the list which this heading belongs to |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/SaveHeadingFromName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "Name": "Terry-Fay",
  "Entity": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "HeadingId": 257,
  "Name": "Langworth-Walter",
  "Tooltip": "harum",
  "Deleted": false,
  "Rank": 897,
  "UdListDefinitionId": 910,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 670
    }
  }
}
```