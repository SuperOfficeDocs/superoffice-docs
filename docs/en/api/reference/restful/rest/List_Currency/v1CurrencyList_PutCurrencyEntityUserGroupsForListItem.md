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
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 983,
    "Name": "Nicolas Inc and Sons",
    "ToolTip": "Tempore nobis sint eos facere.",
    "Deleted": false,
    "Rank": 699,
    "Type": "rerum",
    "ColorBlock": 265,
    "IconHint": "totam",
    "Selected": true,
    "LastChanged": "2003-06-10T16:55:30.6333021+02:00",
    "ChildItems": [
      {
        "Id": 416,
        "Name": "Wuckert Group",
        "ToolTip": "Sint unde et qui accusamus ullam debitis.",
        "Deleted": false,
        "Rank": 100,
        "Type": "alias",
        "ColorBlock": 369,
        "IconHint": "minima",
        "Selected": false,
        "LastChanged": "2016-06-26T16:55:30.6333021+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aliquid",
        "StyleHint": "vitae",
        "Hidden": false,
        "FullName": "Lila Dulce Ratke I"
      }
    ],
    "ExtraInfo": "enim",
    "StyleHint": "possimus",
    "Hidden": true,
    "FullName": "Mrs. Grayson Jenkins"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 764,
    "Name": "Ullrich Inc and Sons",
    "ToolTip": "Iusto ut sit ducimus quia.",
    "Deleted": false,
    "Rank": 851,
    "Type": "occaecati",
    "ColorBlock": 527,
    "IconHint": "pariatur",
    "Selected": false,
    "LastChanged": "2008-08-20T16:55:30.6342169+02:00",
    "ChildItems": [
      {
        "Id": 951,
        "Name": "Gottlieb-Stroman",
        "ToolTip": "Omnis laudantium quis dignissimos autem recusandae odio repellat.",
        "Deleted": true,
        "Rank": 158,
        "Type": "et",
        "ColorBlock": 722,
        "IconHint": "natus",
        "Selected": false,
        "LastChanged": "2015-06-03T16:55:30.6352172+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sint",
        "StyleHint": "odio",
        "Hidden": false,
        "FullName": "Lilliana Cummings",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 592
          }
        }
      }
    ],
    "ExtraInfo": "quia",
    "StyleHint": "officia",
    "Hidden": true,
    "FullName": "Lewis Gulgowski",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 518
      }
    }
  }
]
```