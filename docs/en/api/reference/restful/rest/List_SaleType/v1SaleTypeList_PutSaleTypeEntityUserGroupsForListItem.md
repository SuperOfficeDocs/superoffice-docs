---
title: PUT List/SaleType/Items/{id}/UserGroups
uid: v1SaleTypeList_PutSaleTypeEntityUserGroupsForListItem
generated: true
---

# PUT List/SaleType/Items/{id}/UserGroups

```http
PUT /api/v1/List/SaleType/Items/{itemId}/UserGroups
```

Saves user groups visible for the SaleTypeEntity list's item.


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
PUT /api/v1/List/SaleType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 823,
    "Name": "Littel, Brakus and Walsh",
    "ToolTip": "Dolorem ratione aliquam natus fugit.",
    "Deleted": false,
    "Rank": 135,
    "Type": "voluptate",
    "ColorBlock": 521,
    "IconHint": "qui",
    "Selected": false,
    "LastChanged": "2007-12-05T10:18:01.1606262+01:00",
    "ChildItems": [
      {
        "Id": 502,
        "Name": "Bogan-Becker",
        "ToolTip": "Qui voluptatem a hic labore aut.",
        "Deleted": true,
        "Rank": 798,
        "Type": "aut",
        "ColorBlock": 466,
        "IconHint": "est",
        "Selected": true,
        "LastChanged": "2005-06-11T10:18:01.1606262+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "occaecati",
        "StyleHint": "ipsa",
        "Hidden": false,
        "FullName": "Mr. Collin Carmelo Cartwright Sr."
      }
    ],
    "ExtraInfo": "libero",
    "StyleHint": "eum",
    "Hidden": false,
    "FullName": "Ms. Katelynn Sibyl Pfeffer DDS"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 890,
    "Name": "Von, Koelpin and Lynch",
    "ToolTip": "Quia assumenda.",
    "Deleted": false,
    "Rank": 567,
    "Type": "qui",
    "ColorBlock": 347,
    "IconHint": "voluptatem",
    "Selected": true,
    "LastChanged": "2020-12-26T10:18:01.1606262+01:00",
    "ChildItems": [
      {
        "Id": 74,
        "Name": "Pagac, Toy and Kreiger",
        "ToolTip": "Excepturi recusandae hic et dolores et qui exercitationem.",
        "Deleted": false,
        "Rank": 19,
        "Type": "sint",
        "ColorBlock": 841,
        "IconHint": "omnis",
        "Selected": false,
        "LastChanged": "2021-03-17T10:18:01.1606262+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "provident",
        "StyleHint": "numquam",
        "Hidden": false,
        "FullName": "Sandy Effertz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 24
          }
        }
      }
    ],
    "ExtraInfo": "rerum",
    "StyleHint": "aut",
    "Hidden": true,
    "FullName": "Ms. Americo Adolph O'Hara",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 170
      }
    }
  }
]
```