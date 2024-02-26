---
title: PUT List/{id}/Items/{id}/UserGroups
uid: v1ListItemEntity_SetVisibleForUserGroups
generated: true
---

# PUT List/{id}/Items/{id}/UserGroups

```http
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
```

Update User groups that this list item is visible for






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
| listItemId | int32 | The id of the list item **Required** |



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

## Request Body: userGroups 

The selectable user groups. 

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
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 704,
    "Name": "Russel LLC",
    "ToolTip": "Autem molestiae maiores.",
    "Deleted": false,
    "Rank": 423,
    "Type": "sint",
    "ColorBlock": 682,
    "IconHint": "quam",
    "Selected": false,
    "LastChanged": "2015-03-07T10:30:32.8269372+01:00",
    "ChildItems": [
      {
        "Id": 443,
        "Name": "Dickens LLC",
        "ToolTip": "Aut illum dolorem.",
        "Deleted": false,
        "Rank": 817,
        "Type": "numquam",
        "ColorBlock": 673,
        "IconHint": "tempore",
        "Selected": false,
        "LastChanged": "2014-03-24T10:30:32.8269372+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "possimus",
        "StyleHint": "ut",
        "Hidden": true,
        "FullName": "Friedrich Turner"
      }
    ],
    "ExtraInfo": "optio",
    "StyleHint": "illum",
    "Hidden": false,
    "FullName": "Chaya Graham"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 713,
    "Name": "Hagenes, Nicolas and Ondricka",
    "ToolTip": "Blanditiis atque aut minima fuga.",
    "Deleted": true,
    "Rank": 232,
    "Type": "consectetur",
    "ColorBlock": 873,
    "IconHint": "aspernatur",
    "Selected": false,
    "LastChanged": "2010-09-16T10:30:32.8269372+02:00",
    "ChildItems": [
      {
        "Id": 774,
        "Name": "Daugherty, Considine and Toy",
        "ToolTip": "Voluptate pariatur iusto.",
        "Deleted": false,
        "Rank": 718,
        "Type": "quam",
        "ColorBlock": 731,
        "IconHint": "quo",
        "Selected": false,
        "LastChanged": "2021-03-31T10:30:32.8269372+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "animi",
        "StyleHint": "earum",
        "Hidden": true,
        "FullName": "Herminio Franecki",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 405
          }
        }
      }
    ],
    "ExtraInfo": "ipsum",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Dr. Vanessa Spencer MD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 48
      }
    }
  }
]
```