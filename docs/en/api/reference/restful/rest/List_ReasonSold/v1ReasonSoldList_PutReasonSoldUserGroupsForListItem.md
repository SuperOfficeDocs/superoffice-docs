---
title: PUT List/ReasonSold/Items/{id}/UserGroups
uid: v1ReasonSoldList_PutReasonSoldUserGroupsForListItem
generated: true
---

# PUT List/ReasonSold/Items/{id}/UserGroups

```http
PUT /api/v1/List/ReasonSold/Items/{itemId}/UserGroups
```

Saves user groups visible for the ReasonSold list's item.


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
PUT /api/v1/List/ReasonSold/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 139,
    "Name": "Beer Group",
    "ToolTip": "Reiciendis labore nulla necessitatibus facilis debitis et.",
    "Deleted": false,
    "Rank": 71,
    "Type": "ullam",
    "ColorBlock": 68,
    "IconHint": "voluptatem",
    "Selected": false,
    "LastChanged": "2003-09-27T10:18:01.1450002+02:00",
    "ChildItems": [
      {
        "Id": 203,
        "Name": "Christiansen Group",
        "ToolTip": "Magni nostrum voluptates.",
        "Deleted": true,
        "Rank": 878,
        "Type": "quos",
        "ColorBlock": 340,
        "IconHint": "eaque",
        "Selected": false,
        "LastChanged": "2007-10-25T10:18:01.1450002+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "minus",
        "StyleHint": "quae",
        "Hidden": true,
        "FullName": "Winifred Cloyd Fay III"
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "corrupti",
    "Hidden": false,
    "FullName": "Herman Cruickshank"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 834,
    "Name": "Satterfield, Pfannerstill and Stanton",
    "ToolTip": "Minima similique.",
    "Deleted": true,
    "Rank": 488,
    "Type": "tempore",
    "ColorBlock": 340,
    "IconHint": "delectus",
    "Selected": false,
    "LastChanged": "2014-01-05T10:18:01.1450002+01:00",
    "ChildItems": [
      {
        "Id": 612,
        "Name": "Greenfelder-Hilll",
        "ToolTip": "Cumque velit.",
        "Deleted": false,
        "Rank": 796,
        "Type": "magnam",
        "ColorBlock": 654,
        "IconHint": "doloremque",
        "Selected": true,
        "LastChanged": "2004-02-06T10:18:01.1450002+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "impedit",
        "StyleHint": "sed",
        "Hidden": false,
        "FullName": "Dr. Angus Aufderhar I",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 494
          }
        }
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "neque",
    "Hidden": true,
    "FullName": "Dasia Gibson",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 405
      }
    }
  }
]
```