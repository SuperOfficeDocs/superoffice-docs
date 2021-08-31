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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 815,
    "Name": "Simonis-Wehner",
    "ToolTip": "Et vel aperiam eius hic esse autem.",
    "Deleted": false,
    "Rank": 900,
    "Type": "dolores",
    "ColorBlock": 794,
    "IconHint": "qui",
    "Selected": true,
    "LastChanged": "2020-03-04T15:05:43.2108983+01:00",
    "ChildItems": [
      {
        "Id": 749,
        "Name": "Lubowitz, Kihn and Becker",
        "ToolTip": "Tempora ullam.",
        "Deleted": false,
        "Rank": 26,
        "Type": "est",
        "ColorBlock": 767,
        "IconHint": "quis",
        "Selected": true,
        "LastChanged": "2012-10-02T15:05:43.2108983+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "velit",
        "StyleHint": "dolorum",
        "Hidden": false,
        "FullName": "Cheyenne Schuster"
      }
    ],
    "ExtraInfo": "pariatur",
    "StyleHint": "voluptas",
    "Hidden": false,
    "FullName": "Adolphus Hauck"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 538,
    "Name": "Heaney Group",
    "ToolTip": "Sapiente possimus sed harum esse et ipsa.",
    "Deleted": false,
    "Rank": 308,
    "Type": "error",
    "ColorBlock": 952,
    "IconHint": "voluptatem",
    "Selected": false,
    "LastChanged": "1999-04-29T15:05:43.2118983+02:00",
    "ChildItems": [
      {
        "Id": 654,
        "Name": "Nitzsche-Spencer",
        "ToolTip": "Est officia voluptatem delectus.",
        "Deleted": true,
        "Rank": 402,
        "Type": "quia",
        "ColorBlock": 939,
        "IconHint": "totam",
        "Selected": false,
        "LastChanged": "2006-03-09T15:05:43.2118983+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "optio",
        "StyleHint": "libero",
        "Hidden": false,
        "FullName": "Hermann Johnston",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": "harness ubiquitous vortals"
            },
            "FieldType": "System.String",
            "FieldLength": 422
          }
        }
      }
    ],
    "ExtraInfo": "rerum",
    "StyleHint": "cumque",
    "Hidden": false,
    "FullName": "Elva Cummings",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 423
      }
    }
  }
]
```