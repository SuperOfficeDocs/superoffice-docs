---
title: PUT List/Position/Items/{id}/UserGroups
uid: v1PositionList_PutPositionUserGroupsForListItem
generated: true
---

# PUT List/Position/Items/{id}/UserGroups

```http
PUT /api/v1/List/Position/Items/{itemId}/UserGroups
```

Saves user groups visible for the Position list's item.


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
PUT /api/v1/List/Position/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 148,
    "Name": "Kertzmann Group",
    "ToolTip": "Est accusamus sit eveniet libero cumque.",
    "Deleted": true,
    "Rank": 415,
    "Type": "libero",
    "ColorBlock": 213,
    "IconHint": "voluptas",
    "Selected": true,
    "LastChanged": "2000-01-25T12:01:33.5582313+01:00",
    "ChildItems": [
      {
        "Id": 331,
        "Name": "Hyatt-Walker",
        "ToolTip": "Vel facilis culpa accusamus corporis nisi in nesciunt.",
        "Deleted": false,
        "Rank": 440,
        "Type": "adipisci",
        "ColorBlock": 173,
        "IconHint": "et",
        "Selected": true,
        "LastChanged": "2001-02-06T12:01:33.5582313+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "earum",
        "StyleHint": "qui",
        "Hidden": true,
        "FullName": "Mrs. Janae Brekke DDS"
      }
    ],
    "ExtraInfo": "sequi",
    "StyleHint": "voluptate",
    "Hidden": true,
    "FullName": "Mackenzie Zulauf"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 156,
    "Name": "Konopelski, Hamill and Shanahan",
    "ToolTip": "Aliquam voluptatem qui et.",
    "Deleted": false,
    "Rank": 275,
    "Type": "nulla",
    "ColorBlock": 570,
    "IconHint": "laboriosam",
    "Selected": true,
    "LastChanged": "1997-11-07T12:01:33.5582313+01:00",
    "ChildItems": [
      {
        "Id": 445,
        "Name": "Rempel-Roberts",
        "ToolTip": "Culpa aliquid perspiciatis nisi.",
        "Deleted": false,
        "Rank": 208,
        "Type": "iusto",
        "ColorBlock": 602,
        "IconHint": "ut",
        "Selected": false,
        "LastChanged": "2023-05-05T12:01:33.5582313+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "eos",
        "Hidden": false,
        "FullName": "Juanita Hayes",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 475
          }
        }
      }
    ],
    "ExtraInfo": "quas",
    "StyleHint": "deserunt",
    "Hidden": false,
    "FullName": "Selena Hilpert",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 374
      }
    }
  }
]
```