---
title: POST Agents/List/SaveFromListDefinition
uid: v1ListAgent_SaveFromListDefinition
---

# POST Agents/List/SaveFromListDefinition

```http
POST /api/v1/Agents/List/SaveFromListDefinition
```

Save a list item for the specified list defintion

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/SaveFromListDefinition?$select=name,department,category/id
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

Id, UdListDefinitionId, Item

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 |  |
| UdListDefinitionId | int32 |  |
| Item |  | The list item entity contains generic list item information <para /> Carrier object for ListItemEntity. Services for the ListItemEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>. |

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The identity of the list item |
| Name | string | The name of the list item |
| Tooltip | string | The tooltip of the list item |
| Deleted | bool | True if the list item is marked as deleted |
| UdListDefinitionId | int32 | The id of the list which this list item belongs to |
| Rank | int32 | The rank of the list item |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/List/SaveFromListDefinition
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Id": 935,
  "UdListDefinitionId": 548,
  "Item": null
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 160,
  "Name": "Orn-Parisian",
  "Tooltip": "est",
  "Deleted": true,
  "UdListDefinitionId": 472,
  "Rank": 101,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 941
    }
  }
}
```
