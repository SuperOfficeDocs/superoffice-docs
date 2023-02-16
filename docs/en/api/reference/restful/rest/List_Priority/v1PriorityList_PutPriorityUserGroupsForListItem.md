---
title: PUT List/Priority/Items/{id}/UserGroups
uid: v1PriorityList_PutPriorityUserGroupsForListItem
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/Priority/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 577,
    "Name": "Roberts LLC",
    "ToolTip": "Labore aperiam explicabo omnis praesentium quo voluptatibus.",
    "Deleted": true,
    "Rank": 461,
    "Type": "doloremque",
    "ColorBlock": 101,
    "IconHint": "facere",
    "Selected": true,
    "LastChanged": "1995-12-30T14:19:11.3524087+01:00",
    "ChildItems": [
      {
        "Id": 363,
        "Name": "Rolfson, Hickle and Casper",
        "ToolTip": "Dolorem molestias et dicta nisi corrupti.",
        "Deleted": false,
        "Rank": 859,
        "Type": "et",
        "ColorBlock": 469,
        "IconHint": "quisquam",
        "Selected": true,
        "LastChanged": "2000-01-21T14:19:11.3524087+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "illo",
        "Hidden": false,
        "FullName": "Moshe Tillman"
      }
    ],
    "ExtraInfo": "ullam",
    "StyleHint": "assumenda",
    "Hidden": false,
    "FullName": "Camden Amari Lebsack V"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 525,
    "Name": "Wunsch Inc and Sons",
    "ToolTip": "Sit similique id.",
    "Deleted": false,
    "Rank": 279,
    "Type": "in",
    "ColorBlock": 167,
    "IconHint": "molestiae",
    "Selected": true,
    "LastChanged": "2015-04-22T14:19:11.3524087+02:00",
    "ChildItems": [
      {
        "Id": 876,
        "Name": "Tillman Inc and Sons",
        "ToolTip": "Consectetur similique temporibus magni quo.",
        "Deleted": true,
        "Rank": 557,
        "Type": "quo",
        "ColorBlock": 495,
        "IconHint": "dignissimos",
        "Selected": false,
        "LastChanged": "2012-11-15T14:19:11.3524087+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quisquam",
        "StyleHint": "itaque",
        "Hidden": false,
        "FullName": "Dr. Freida Eda White",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 362
          }
        }
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "quia",
    "Hidden": false,
    "FullName": "Mr. Anahi Braun IV",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 445
      }
    }
  }
]
```