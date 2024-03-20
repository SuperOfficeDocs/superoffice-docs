---
title: PUT List/{udListDefinitionName}/Items/{id}/UserGroups
uid: v1ListItemEntity_SetVisibleForUserGroupsFromListName
generated: true
---

# PUT List/{udListDefinitionName}/Items/{id}/UserGroups

```http
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/UserGroups
```

Update User groups that this list item is visible for






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionName | string | The name of the list definition, indicating which list to update the items from. **Required** |
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
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 552,
    "Name": "Medhurst-Strosin",
    "ToolTip": "Nisi nisi labore qui.",
    "Deleted": false,
    "Rank": 502,
    "Type": "iure",
    "ColorBlock": 223,
    "IconHint": "facilis",
    "Selected": false,
    "LastChanged": "2018-01-07T12:19:54.2740906+01:00",
    "ChildItems": [
      {
        "Id": 198,
        "Name": "O'Connell-Beatty",
        "ToolTip": "Est qui odio nisi laborum quos odio ut.",
        "Deleted": false,
        "Rank": 111,
        "Type": "non",
        "ColorBlock": 383,
        "IconHint": "officiis",
        "Selected": false,
        "LastChanged": "2006-06-03T12:19:54.2740906+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "occaecati",
        "StyleHint": "hic",
        "Hidden": true,
        "FullName": "Jalyn Howe"
      }
    ],
    "ExtraInfo": "voluptas",
    "StyleHint": "delectus",
    "Hidden": false,
    "FullName": "Rafaela Margaretta Stiedemann II"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 660,
    "Name": "Yundt, Ortiz and Goodwin",
    "ToolTip": "Laboriosam corrupti enim nemo eius voluptatem voluptatem minima.",
    "Deleted": false,
    "Rank": 275,
    "Type": "iste",
    "ColorBlock": 527,
    "IconHint": "cum",
    "Selected": false,
    "LastChanged": "2023-09-09T12:19:54.2740906+02:00",
    "ChildItems": [
      {
        "Id": 474,
        "Name": "Watsica-Larkin",
        "ToolTip": "Fugit neque nobis nam fugiat saepe.",
        "Deleted": false,
        "Rank": 675,
        "Type": "non",
        "ColorBlock": 938,
        "IconHint": "aut",
        "Selected": true,
        "LastChanged": "1997-11-14T12:19:54.2740906+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quis",
        "StyleHint": "rem",
        "Hidden": false,
        "FullName": "Keagan Bogan",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 938
          }
        }
      }
    ],
    "ExtraInfo": "dolorem",
    "StyleHint": "saepe",
    "Hidden": false,
    "FullName": "Jaylin Corkery",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 485
      }
    }
  }
]
```