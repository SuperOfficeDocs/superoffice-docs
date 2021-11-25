---
title: PUT List/{id}/Items/{id}/UserGroups
id: v1ListItemEntity_SetVisibleForUserGroups
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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 660,
    "Name": "Hauck, Baumbach and Swaniawski",
    "ToolTip": "Non tempore amet delectus.",
    "Deleted": false,
    "Rank": 152,
    "Type": "qui",
    "ColorBlock": 534,
    "IconHint": "voluptas",
    "Selected": true,
    "LastChanged": "2014-08-24T18:25:51.5782944+02:00",
    "ChildItems": [
      {
        "Id": 903,
        "Name": "Cummerata, Hackett and Friesen",
        "ToolTip": "Alias ipsam.",
        "Deleted": true,
        "Rank": 244,
        "Type": "ad",
        "ColorBlock": 253,
        "IconHint": "aut",
        "Selected": false,
        "LastChanged": "1999-03-20T18:25:51.5782944+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tempora",
        "StyleHint": "animi",
        "Hidden": true,
        "FullName": "Quincy Hammes"
      }
    ],
    "ExtraInfo": "reiciendis",
    "StyleHint": "deleniti",
    "Hidden": true,
    "FullName": "Kara Schinner"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 783,
    "Name": "Ebert, Corkery and Keeling",
    "ToolTip": "Sit omnis mollitia laboriosam quos.",
    "Deleted": true,
    "Rank": 3,
    "Type": "et",
    "ColorBlock": 354,
    "IconHint": "officia",
    "Selected": true,
    "LastChanged": "2020-01-19T18:25:51.5792947+01:00",
    "ChildItems": [
      {
        "Id": 573,
        "Name": "Kovacek Inc and Sons",
        "ToolTip": "Omnis molestiae dolore praesentium veniam odio dolorum.",
        "Deleted": true,
        "Rank": 386,
        "Type": "porro",
        "ColorBlock": 425,
        "IconHint": "explicabo",
        "Selected": false,
        "LastChanged": "2009-12-06T18:25:51.5792947+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quo",
        "StyleHint": "hic",
        "Hidden": true,
        "FullName": "Tamia Harris",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 849
          }
        }
      }
    ],
    "ExtraInfo": "totam",
    "StyleHint": "quis",
    "Hidden": true,
    "FullName": "Margret Quitzon",
    "TableRight": {
      "Mask": "Delete",
      "Reason": "envisioneer customized metrics"
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 86
      }
    }
  }
]
```