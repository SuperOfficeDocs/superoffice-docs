---
title: PUT List/Reason/Items/{id}/UserGroups
uid: v1ReasonList_PutReasonUserGroupsForListItem
---

# PUT List/Reason/Items/{id}/UserGroups

```http
PUT /api/v1/List/Reason/Items/{itemId}/UserGroups
```

Saves user groups visible for the Reason list's item.


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
PUT /api/v1/List/Reason/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 169,
    "Name": "Stracke Group",
    "ToolTip": "Aut soluta qui occaecati in quisquam corporis facere.",
    "Deleted": true,
    "Rank": 744,
    "Type": "accusamus",
    "ColorBlock": 475,
    "IconHint": "dolore",
    "Selected": false,
    "LastChanged": "2006-04-20T15:29:31.5309754+02:00",
    "ChildItems": [
      {
        "Id": 60,
        "Name": "Rowe, Swift and Schaefer",
        "ToolTip": "Ducimus maxime neque fugiat ipsum veniam.",
        "Deleted": true,
        "Rank": 144,
        "Type": "a",
        "ColorBlock": 196,
        "IconHint": "ea",
        "Selected": false,
        "LastChanged": "2002-07-12T15:29:31.5314745+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sequi",
        "StyleHint": "nemo",
        "Hidden": false,
        "FullName": "Fabiola Littel"
      }
    ],
    "ExtraInfo": "pariatur",
    "StyleHint": "reprehenderit",
    "Hidden": true,
    "FullName": "Jodie Blick"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 993,
    "Name": "Schaefer-Renner",
    "ToolTip": "Maxime aliquam ducimus deserunt velit aut possimus consequuntur.",
    "Deleted": false,
    "Rank": 604,
    "Type": "voluptatum",
    "ColorBlock": 627,
    "IconHint": "quae",
    "Selected": true,
    "LastChanged": "2009-09-24T15:29:31.5334768+02:00",
    "ChildItems": [
      {
        "Id": 277,
        "Name": "Sauer-Kuvalis",
        "ToolTip": "Unde quasi molestiae.",
        "Deleted": false,
        "Rank": 809,
        "Type": "rerum",
        "ColorBlock": 510,
        "IconHint": "vero",
        "Selected": true,
        "LastChanged": "2016-08-05T15:29:31.5334768+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatibus",
        "StyleHint": "architecto",
        "Hidden": false,
        "FullName": "Prof. Magali Marshall Keeling Jr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 724
          }
        }
      }
    ],
    "ExtraInfo": "nihil",
    "StyleHint": "dolores",
    "Hidden": true,
    "FullName": "Stanley Bradtke",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 611
      }
    }
  }
]
```