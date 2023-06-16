---
title: GET List/Priority/Items/{id}/UserGroups
uid: v1PriorityList_GetPriorityUserGroupsForListItem
generated: true
---

# GET List/Priority/Items/{id}/UserGroups

```http
GET /api/v1/List/Priority/Items/{itemId}/UserGroups
```

Gets user groups visible for the Priority list's item.


Calls the List agent service GetHeadings.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to get. **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/List/Priority/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 218,
    "Name": "Wiegand LLC",
    "ToolTip": "Exercitationem aut laudantium veniam cupiditate laudantium in quo.",
    "Deleted": false,
    "Rank": 527,
    "Type": "maxime",
    "ColorBlock": 869,
    "IconHint": "dolores",
    "Selected": false,
    "LastChanged": "2007-12-31T16:00:49.133322+01:00",
    "ChildItems": [
      {
        "Id": 219,
        "Name": "Marvin, Sipes and Streich",
        "ToolTip": "Aspernatur accusantium assumenda fugit.",
        "Deleted": false,
        "Rank": 942,
        "Type": "omnis",
        "ColorBlock": 717,
        "IconHint": "voluptates",
        "Selected": false,
        "LastChanged": "1996-10-24T16:00:49.133322+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "fugiat",
        "StyleHint": "ab",
        "Hidden": true,
        "FullName": "Sibyl Kovacek",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 209
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "odit",
    "Hidden": false,
    "FullName": "Cyrus Balistreri",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 787
      }
    }
  }
]
```