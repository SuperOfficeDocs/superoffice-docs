---
title: PUT List/Task/Items/{id}/UserGroups
uid: v1TaskList_PutTaskListItemUserGroupsForListItem
generated: true
content_type: reference
---

# PUT List/Task/Items/{id}/UserGroups

```http
PUT /api/v1/List/Task/Items/{itemId}/UserGroups
```

Saves user groups visible for the TaskListItem list's item.


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
PUT /api/v1/List/Task/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 366,
    "Name": "Reichert, Walsh and Reichert",
    "ToolTip": "Facere quaerat fugit ducimus perferendis sunt qui omnis.",
    "Deleted": false,
    "Rank": 725,
    "Type": "beatae",
    "ColorBlock": 473,
    "IconHint": "et",
    "Selected": true,
    "LastChanged": "1999-12-24T11:24:54.1561606+01:00",
    "ChildItems": [
      {
        "Id": 614,
        "Name": "Marks Inc and Sons",
        "ToolTip": "Rem dolorem error.",
        "Deleted": false,
        "Rank": 443,
        "Type": "sed",
        "ColorBlock": 364,
        "IconHint": "iure",
        "Selected": false,
        "LastChanged": "2006-05-24T11:24:54.1717846+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "id",
        "StyleHint": "sit",
        "Hidden": false,
        "FullName": "Aric Dejah Turcotte II"
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "at",
    "Hidden": false,
    "FullName": "Tianna Cruz Kreiger DVM"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 836,
    "Name": "Kovacek Group",
    "ToolTip": "Harum aut itaque a atque ipsam quisquam expedita.",
    "Deleted": true,
    "Rank": 458,
    "Type": "ex",
    "ColorBlock": 106,
    "IconHint": "architecto",
    "Selected": false,
    "LastChanged": "1999-10-25T11:24:54.1717846+02:00",
    "ChildItems": [
      {
        "Id": 596,
        "Name": "Nicolas-McLaughlin",
        "ToolTip": "Non sit voluptas suscipit sit.",
        "Deleted": false,
        "Rank": 750,
        "Type": "facere",
        "ColorBlock": 546,
        "IconHint": "quae",
        "Selected": false,
        "LastChanged": "2024-02-06T11:24:54.1717846+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quis",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Rodrick Marks MD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 179
          }
        }
      }
    ],
    "ExtraInfo": "consequatur",
    "StyleHint": "dignissimos",
    "Hidden": true,
    "FullName": "Ms. Anastacio Hills II",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 279
      }
    }
  }
]
```