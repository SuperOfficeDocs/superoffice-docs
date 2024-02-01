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
    "Id": 263,
    "Name": "Ferry-Abshire",
    "ToolTip": "Adipisci quis nemo vero.",
    "Deleted": false,
    "Rank": 505,
    "Type": "exercitationem",
    "ColorBlock": 244,
    "IconHint": "rem",
    "Selected": false,
    "LastChanged": "2005-10-25T23:04:05.4240003+02:00",
    "ChildItems": [
      {
        "Id": 567,
        "Name": "Streich, Kulas and McLaughlin",
        "ToolTip": "Autem voluptates porro aut eaque ex minus.",
        "Deleted": true,
        "Rank": 209,
        "Type": "non",
        "ColorBlock": 802,
        "IconHint": "eum",
        "Selected": false,
        "LastChanged": "2008-08-31T23:04:05.4240003+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vero",
        "StyleHint": "iure",
        "Hidden": true,
        "FullName": "Macey Mya Stokes DVM"
      }
    ],
    "ExtraInfo": "pariatur",
    "StyleHint": "quas",
    "Hidden": false,
    "FullName": "Alvah Bailey"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 913,
    "Name": "Donnelly-Mertz",
    "ToolTip": "Iste soluta illum similique et tempore qui sequi.",
    "Deleted": false,
    "Rank": 627,
    "Type": "qui",
    "ColorBlock": 948,
    "IconHint": "nihil",
    "Selected": false,
    "LastChanged": "2009-09-24T23:04:05.4260008+02:00",
    "ChildItems": [
      {
        "Id": 52,
        "Name": "Kling-O'Reilly",
        "ToolTip": "Voluptas ipsum totam odit ad voluptatem recusandae.",
        "Deleted": false,
        "Rank": 229,
        "Type": "perferendis",
        "ColorBlock": 882,
        "IconHint": "optio",
        "Selected": true,
        "LastChanged": "2020-02-05T23:04:05.4265014+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nemo",
        "StyleHint": "consequatur",
        "Hidden": false,
        "FullName": "Miss Tressie Annette Conn",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 735
          }
        }
      }
    ],
    "ExtraInfo": "suscipit",
    "StyleHint": "sit",
    "Hidden": true,
    "FullName": "Nicholas Stokes",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 990
      }
    }
  }
]
```