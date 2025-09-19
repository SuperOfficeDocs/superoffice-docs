---
title: PUT List/Priority/Items/{id}/UserGroups
uid: v1PriorityList_PutPriorityUserGroupsForListItem
generated: true
content_type: reference
---

# PUT List/Priority/Items/{id}/UserGroups

```http
PUT /api/v1/List/Priority/Items/{itemId}/UserGroups
```

Saves user groups visible for the Priority list's item.


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
PUT /api/v1/List/Priority/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 630,
    "Name": "Sawayn-Carroll",
    "ToolTip": "Eos ex molestiae qui blanditiis.",
    "Deleted": false,
    "Rank": 581,
    "Type": "est",
    "ColorBlock": 997,
    "IconHint": "excepturi",
    "Selected": false,
    "LastChanged": "2007-09-13T03:41:59.4648585+02:00",
    "ChildItems": [
      {
        "Id": 917,
        "Name": "Blick Group",
        "ToolTip": "Autem praesentium ut sint quod.",
        "Deleted": false,
        "Rank": 824,
        "Type": "minus",
        "ColorBlock": 614,
        "IconHint": "non",
        "Selected": false,
        "LastChanged": "2012-04-03T03:41:59.4648585+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "cum",
        "StyleHint": "modi",
        "Hidden": true,
        "FullName": "Nelson Erdman"
      }
    ],
    "ExtraInfo": "aut",
    "StyleHint": "mollitia",
    "Hidden": false,
    "FullName": "Cory Wintheiser I"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 677,
    "Name": "Kovacek-Stokes",
    "ToolTip": "Quos necessitatibus quaerat quia reiciendis.",
    "Deleted": false,
    "Rank": 733,
    "Type": "tempora",
    "ColorBlock": 149,
    "IconHint": "deserunt",
    "Selected": true,
    "LastChanged": "2005-12-02T03:41:59.4648585+01:00",
    "ChildItems": [
      {
        "Id": 903,
        "Name": "Langworth-Hartmann",
        "ToolTip": "Molestiae dolorem eaque.",
        "Deleted": false,
        "Rank": 17,
        "Type": "placeat",
        "ColorBlock": 979,
        "IconHint": "unde",
        "Selected": false,
        "LastChanged": "2017-05-02T03:41:59.4648585+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quae",
        "StyleHint": "commodi",
        "Hidden": false,
        "FullName": "Ms. Durward Nienow",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 662
          }
        }
      }
    ],
    "ExtraInfo": "velit",
    "StyleHint": "enim",
    "Hidden": true,
    "FullName": "Prof. Skyla Ritchie I",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 195
      }
    }
  }
]
```