---
title: PUT List/PaymentType
uid: v1PaymentTypeList_SetListDefinition
generated: true
---

# PUT List/PaymentType

```http
PUT /api/v1/List/PaymentType
```

Save the description of PaymentType list








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

## Request Body: listEntity 

The list entity contains information about a specific list
<para />
Carrier object for ListEntity.
Services for the ListEntity Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IListAgent">List Agent</see>. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | Integer | The identity of the list |
| Name | String | The name of the list |
| Tooltip | String | The tooltip of the list |
| Deleted | Boolean | True if the list item is marked as deleted |
| Rank | Integer | The rank of the list |
| IsCustomList | Boolean | Indicates if this is a custom list or a standard list |
| IsMDOList | Boolean | Indicates if this is a MDO list |
| UseGroupsAndHeadings | Boolean | Indicates if this list should use groups and headings |
| ListType | String | The type of this list, often indicated by the database name, but not necessarily |
| InUseByUserDefinedFields | Boolean | True if this in use by one or more udfields |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ListEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The identity of the list |
| Name | string | The name of the list |
| Tooltip | string | The tooltip of the list |
| Deleted | bool | True if the list item is marked as deleted |
| Rank | int32 | The rank of the list |
| IsCustomList | bool | Indicates if this is a custom list or a standard list |
| IsMDOList | bool | Indicates if this is a MDO list |
| UseGroupsAndHeadings | bool | Indicates if this list should use groups and headings |
| ListType | string | The type of this list, often indicated by the database name, but not necessarily |
| InUseByUserDefinedFields | bool | True if this in use by one or more udfields |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/PaymentType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Id": 771,
  "Name": "O'Reilly-Prosacco",
  "Tooltip": "aut",
  "Deleted": true,
  "Rank": 565,
  "IsCustomList": false,
  "IsMDOList": false,
  "UseGroupsAndHeadings": false,
  "ListType": "dicta",
  "InUseByUserDefinedFields": true
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Id": 934,
  "Name": "Wiza-Farrell",
  "Tooltip": "omnis",
  "Deleted": false,
  "Rank": 520,
  "IsCustomList": true,
  "IsMDOList": true,
  "UseGroupsAndHeadings": false,
  "ListType": "quo",
  "InUseByUserDefinedFields": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 95
    }
  }
}
```