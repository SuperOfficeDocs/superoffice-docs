---
title: POST Agents/List/AddFromListDefinition
id: v1ListAgent_AddFromListDefinition
---

# POST Agents/List/AddFromListDefinition

```http
POST /api/v1/Agents/List/AddFromListDefinition
```

Save a new list item for the specified list defintion

## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/List/AddFromListDefinition?$select=name,department,category/id
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

UdListDefinitionId, Item

| Property Name | Type |  Description |
|----------------|------|--------------|
| UdListDefinitionId | int32 |  |
| Item |  | The list item entity contains generic list item information <br /> Carrier object for ListItemEntity. Services for the ListItemEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>. |

## Response: object

The list item entity contains generic list item information

Carrier object for ListItemEntity.
Services for the ListItemEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Agents/List/AddFromListDefinition
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "UdListDefinitionId": 802,
  "Item": {
    "Id": 41,
    "Name": "Strosin-Lehner",
    "Tooltip": "autem",
    "Deleted": false,
    "UdListDefinitionId": 163,
    "Rank": 181
  }
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 486,
  "Name": "Smith Group",
  "Tooltip": "autem",
  "Deleted": true,
  "UdListDefinitionId": 4,
  "Rank": 169,
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
      "FieldLength": 967
    }
  }
}
```
