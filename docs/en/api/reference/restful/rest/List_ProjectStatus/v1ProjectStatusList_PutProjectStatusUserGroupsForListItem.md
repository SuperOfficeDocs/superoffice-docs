---
title: PUT List/ProjectStatus/Items/{id}/UserGroups
uid: v1ProjectStatusList_PutProjectStatusUserGroupsForListItem
---

# PUT List/ProjectStatus/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProjectStatus/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProjectStatus list's item.


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
PUT /api/v1/List/ProjectStatus/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 259,
    "Name": "West-Schiller",
    "ToolTip": "Deleniti nihil sit id.",
    "Deleted": false,
    "Rank": 705,
    "Type": "recusandae",
    "ColorBlock": 702,
    "IconHint": "laudantium",
    "Selected": false,
    "LastChanged": "1999-01-15T15:29:31.4484779+01:00",
    "ChildItems": [
      {
        "Id": 956,
        "Name": "Kiehn-Walsh",
        "ToolTip": "Quia dolor.",
        "Deleted": true,
        "Rank": 167,
        "Type": "quasi",
        "ColorBlock": 641,
        "IconHint": "quia",
        "Selected": true,
        "LastChanged": "2011-10-12T15:29:31.4484779+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vitae",
        "StyleHint": "itaque",
        "Hidden": true,
        "FullName": "Kaycee Mueller"
      }
    ],
    "ExtraInfo": "accusamus",
    "StyleHint": "id",
    "Hidden": false,
    "FullName": "Mr. Dannie Aufderhar Sr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 262,
    "Name": "Block, Berge and Considine",
    "ToolTip": "Qui qui non amet sit dolor nihil at.",
    "Deleted": true,
    "Rank": 137,
    "Type": "aut",
    "ColorBlock": 502,
    "IconHint": "explicabo",
    "Selected": false,
    "LastChanged": "1997-08-08T15:29:31.4499762+02:00",
    "ChildItems": [
      {
        "Id": 951,
        "Name": "Schamberger, Schowalter and Erdman",
        "ToolTip": "Qui maiores et corporis ipsam magnam nihil explicabo.",
        "Deleted": true,
        "Rank": 101,
        "Type": "dignissimos",
        "ColorBlock": 73,
        "IconHint": "libero",
        "Selected": false,
        "LastChanged": "2021-12-18T15:29:31.4499762+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "cupiditate",
        "StyleHint": "id",
        "Hidden": true,
        "FullName": "Prof. Malika Cassin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 728
          }
        }
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "deserunt",
    "Hidden": false,
    "FullName": "Berta Schuster",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 498
      }
    }
  }
]
```