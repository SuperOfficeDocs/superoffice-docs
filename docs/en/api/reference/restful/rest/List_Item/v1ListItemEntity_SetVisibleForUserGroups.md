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
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 101,
    "Name": "Baumbach, Kshlerin and Stark",
    "ToolTip": "Sed sit.",
    "Deleted": true,
    "Rank": 200,
    "Type": "vitae",
    "ColorBlock": 619,
    "IconHint": "nihil",
    "Selected": true,
    "LastChanged": "2015-08-06T13:28:32.6479022+02:00",
    "ChildItems": [
      {
        "Id": 730,
        "Name": "Hoeger, Thiel and Dickinson",
        "ToolTip": "Magni facere consequatur id explicabo.",
        "Deleted": false,
        "Rank": 52,
        "Type": "odio",
        "ColorBlock": 647,
        "IconHint": "aut",
        "Selected": true,
        "LastChanged": "2022-03-08T13:28:32.6479022+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tempore",
        "StyleHint": "dolorem",
        "Hidden": false,
        "FullName": "Finn Franecki"
      }
    ],
    "ExtraInfo": "ullam",
    "StyleHint": "repellendus",
    "Hidden": false,
    "FullName": "Francesca Kirlin"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 307,
    "Name": "Runolfsdottir-Schimmel",
    "ToolTip": "Aut esse fuga libero.",
    "Deleted": true,
    "Rank": 57,
    "Type": "libero",
    "ColorBlock": 823,
    "IconHint": "rerum",
    "Selected": false,
    "LastChanged": "2015-05-21T13:28:32.6479022+02:00",
    "ChildItems": [
      {
        "Id": 760,
        "Name": "Cronin Group",
        "ToolTip": "Voluptates nobis sunt consequatur qui commodi quo minus.",
        "Deleted": false,
        "Rank": 692,
        "Type": "doloremque",
        "ColorBlock": 354,
        "IconHint": "aut",
        "Selected": true,
        "LastChanged": "1999-09-01T13:28:32.6479022+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "distinctio",
        "StyleHint": "eum",
        "Hidden": false,
        "FullName": "Vesta Hodkiewicz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 329
          }
        }
      }
    ],
    "ExtraInfo": "excepturi",
    "StyleHint": "incidunt",
    "Hidden": false,
    "FullName": "Miss Ila Kassulke V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 699
      }
    }
  }
]
```