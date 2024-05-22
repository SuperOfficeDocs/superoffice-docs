---
title: PUT List/Currency/Items/{id}/UserGroups
uid: v1CurrencyList_PutCurrencyEntityUserGroupsForListItem
generated: true
---

# PUT List/Currency/Items/{id}/UserGroups

```http
PUT /api/v1/List/Currency/Items/{itemId}/UserGroups
```

Saves user groups visible for the CurrencyEntity list's item.


Calls the List agent service SaveHeadingsForListItemFromListDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to save. **Required** |



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

## Request Body: entities 

The headings to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | Integer | The Id of the ListItem |
| Name | String | The name of the ListItem |
| ToolTip | String | The tooltip of the ListItem |
| Deleted | Boolean | The deleted status of the ListItem |
| Rank | Integer | The rank of the ListItem |
| Type | String | The type of the ListItem. Custom field. |
| ColorBlock | Integer | The color indicator of the ListItem color block |
| IconHint | String | The Icon hint of the ListItem. Custom field. |
| Selected | Boolean | True if the ListItem is selected |
| LastChanged | String | Time of last change. |
| ChildItems | Array | The child items of the SelectableMDOListItem |
| ExtraInfo | String | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | String | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | Boolean | True if the ListItem is hidden |
| FullName | String | The name of the ListItem in its context |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Id | int32 | The Id of the ListItem |
| Name | string | The name of the ListItem |
| ToolTip | string | The tooltip of the ListItem |
| Deleted | bool | The deleted status of the ListItem |
| Rank | int32 | The rank of the ListItem |
| Type | string | The type of the ListItem. Custom field. |
| ColorBlock | int32 | The color indicator of the ListItem color block |
| IconHint | string | The Icon hint of the ListItem. Custom field. |
| Selected | bool | True if the ListItem is selected |
| LastChanged | date-time | Time of last change. |
| ChildItems | array | The child items of the SelectableMDOListItem |
| ExtraInfo | string | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | string | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | bool | True if the ListItem is hidden |
| FullName | string | The name of the ListItem in its context |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/Currency/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 288,
    "Name": "Marquardt Inc and Sons",
    "ToolTip": "Nulla magnam praesentium consectetur.",
    "Deleted": false,
    "Rank": 860,
    "Type": "dolor",
    "ColorBlock": 723,
    "IconHint": "corporis",
    "Selected": false,
    "LastChanged": "2009-10-22T12:57:43.4333137+02:00",
    "ChildItems": [
      {
        "Id": 122,
        "Name": "Lubowitz LLC",
        "ToolTip": "Aut illum.",
        "Deleted": false,
        "Rank": 493,
        "Type": "esse",
        "ColorBlock": 946,
        "IconHint": "quia",
        "Selected": true,
        "LastChanged": "2017-06-02T12:57:43.4333137+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "culpa",
        "StyleHint": "quia",
        "Hidden": false,
        "FullName": "Jonas Hermiston"
      }
    ],
    "ExtraInfo": "aut",
    "StyleHint": "qui",
    "Hidden": false,
    "FullName": "Ms. Aurelia Theodora Grant"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 43,
    "Name": "Bergstrom-Bosco",
    "ToolTip": "Ipsam consequatur.",
    "Deleted": false,
    "Rank": 968,
    "Type": "commodi",
    "ColorBlock": 951,
    "IconHint": "est",
    "Selected": false,
    "LastChanged": "2008-06-16T12:57:43.4333137+02:00",
    "ChildItems": [
      {
        "Id": 196,
        "Name": "Yost-Waters",
        "ToolTip": "Explicabo sed ipsam est et recusandae ad quia.",
        "Deleted": false,
        "Rank": 481,
        "Type": "quam",
        "ColorBlock": 106,
        "IconHint": "aut",
        "Selected": true,
        "LastChanged": "2014-11-18T12:57:43.4333137+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sunt",
        "StyleHint": "nemo",
        "Hidden": true,
        "FullName": "Moses Rippin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 395
          }
        }
      }
    ],
    "ExtraInfo": "neque",
    "StyleHint": "quo",
    "Hidden": false,
    "FullName": "Henriette Thurman O'Conner MD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 691
      }
    }
  }
]
```