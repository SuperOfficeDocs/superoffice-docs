---
title: PUT List/ProjectType/Items/{id}
uid: v1ProjectTypeList_PutProjectType
generated: true
---

# PUT List/ProjectType/Items/{id}

```http
PUT /api/v1/List/ProjectType/Items/{id}
```

Updates an existing ProjectType list item.






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The id of ProjectType to be saved. **Required** |



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

## Request Body: listItem 

The details of ProjectType list item to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | Integer | The identity of the list item |
| Name | String | The name of the list item |
| Tooltip | String | The tooltip of the list item |
| Deleted | Boolean | True if the list item is marked as deleted |
| UdListDefinitionId | Integer | The id of the list which this list item belongs to |
| Rank | Integer | The rank of the list item |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: ListItemEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The identity of the list item |
| Name | string | The name of the list item |
| Tooltip | string | The tooltip of the list item |
| Deleted | bool | True if the list item is marked as deleted |
| UdListDefinitionId | int32 | The id of the list which this list item belongs to |
| Rank | int32 | The rank of the list item |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/ProjectType/Items/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Id": 933,
  "Name": "Hudson-Mitchell",
  "Tooltip": "eligendi",
  "Deleted": false,
  "UdListDefinitionId": 390,
  "Rank": 935
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 85,
  "Name": "Legros, Senger and Gutkowski",
  "Tooltip": "quisquam",
  "Deleted": false,
  "UdListDefinitionId": 591,
  "Rank": 629,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 149
    }
  }
}
```