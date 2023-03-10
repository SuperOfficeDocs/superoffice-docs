---
title: PUT List/MrMrs/Items/{id}/UserGroups
uid: v1MrMrsList_PutMrMrsUserGroupsForListItem
---

# PUT List/MrMrs/Items/{id}/UserGroups

```http
PUT /api/v1/List/MrMrs/Items/{itemId}/UserGroups
```

Saves user groups visible for the MrMrs list's item.


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
PUT /api/v1/List/MrMrs/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 4,
    "Name": "Trantow, Gulgowski and Pacocha",
    "ToolTip": "Est temporibus saepe officia voluptate aut.",
    "Deleted": false,
    "Rank": 388,
    "Type": "distinctio",
    "ColorBlock": 717,
    "IconHint": "non",
    "Selected": false,
    "LastChanged": "2010-09-01T12:15:28.1916176+02:00",
    "ChildItems": [
      {
        "Id": 361,
        "Name": "Schaefer-Ullrich",
        "ToolTip": "Et rerum aut unde qui a voluptatem voluptas.",
        "Deleted": false,
        "Rank": 984,
        "Type": "repellendus",
        "ColorBlock": 908,
        "IconHint": "velit",
        "Selected": false,
        "LastChanged": "2007-08-29T12:15:28.1916176+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "autem",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Prof. Bell Mariela Will V"
      }
    ],
    "ExtraInfo": "consequatur",
    "StyleHint": "repellendus",
    "Hidden": false,
    "FullName": "Beverly Davis"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 625,
    "Name": "Gislason-Kessler",
    "ToolTip": "Ad accusantium dolores ut aliquid.",
    "Deleted": false,
    "Rank": 312,
    "Type": "dolores",
    "ColorBlock": 408,
    "IconHint": "laboriosam",
    "Selected": false,
    "LastChanged": "1996-06-07T12:15:28.1926178+02:00",
    "ChildItems": [
      {
        "Id": 735,
        "Name": "Barrows Inc and Sons",
        "ToolTip": "Voluptas qui praesentium.",
        "Deleted": false,
        "Rank": 612,
        "Type": "sed",
        "ColorBlock": 634,
        "IconHint": "corporis",
        "Selected": false,
        "LastChanged": "1997-07-02T12:15:28.1926178+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "commodi",
        "StyleHint": "autem",
        "Hidden": true,
        "FullName": "Kelley Bruen",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 572
          }
        }
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "natus",
    "Hidden": true,
    "FullName": "Mr. Guillermo Johanna Fritsch V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 419
      }
    }
  }
]
```