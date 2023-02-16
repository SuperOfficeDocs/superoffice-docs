---
title: PUT List/{id}/Items/{id}/UserGroups
uid: v1ListItemEntity_SetVisibleForUserGroups
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 286,
    "Name": "Watsica Group",
    "ToolTip": "Et ut.",
    "Deleted": true,
    "Rank": 849,
    "Type": "est",
    "ColorBlock": 69,
    "IconHint": "sed",
    "Selected": false,
    "LastChanged": "2021-08-30T14:19:11.0855578+02:00",
    "ChildItems": [
      {
        "Id": 229,
        "Name": "Kris, Halvorson and Johns",
        "ToolTip": "Corrupti alias et nihil.",
        "Deleted": true,
        "Rank": 585,
        "Type": "voluptate",
        "ColorBlock": 646,
        "IconHint": "reprehenderit",
        "Selected": false,
        "LastChanged": "2021-07-23T14:19:11.0855578+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "molestiae",
        "Hidden": false,
        "FullName": "Bertrand Armstrong"
      }
    ],
    "ExtraInfo": "quidem",
    "StyleHint": "nihil",
    "Hidden": false,
    "FullName": "Brian Lockman"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 409,
    "Name": "Labadie Group",
    "ToolTip": "Ea neque deserunt corrupti.",
    "Deleted": false,
    "Rank": 756,
    "Type": "adipisci",
    "ColorBlock": 140,
    "IconHint": "iure",
    "Selected": false,
    "LastChanged": "2020-07-12T14:19:11.1012251+02:00",
    "ChildItems": [
      {
        "Id": 396,
        "Name": "Lakin, Heidenreich and Ruecker",
        "ToolTip": "Alias ipsum non labore est.",
        "Deleted": false,
        "Rank": 976,
        "Type": "non",
        "ColorBlock": 404,
        "IconHint": "aspernatur",
        "Selected": false,
        "LastChanged": "1997-06-15T14:19:11.1012251+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "qui",
        "StyleHint": "at",
        "Hidden": false,
        "FullName": "Louisa Roob",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 100
          }
        }
      }
    ],
    "ExtraInfo": "tempora",
    "StyleHint": "aut",
    "Hidden": false,
    "FullName": "Ms. Dianna Kulas PhD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 879
      }
    }
  }
]
```