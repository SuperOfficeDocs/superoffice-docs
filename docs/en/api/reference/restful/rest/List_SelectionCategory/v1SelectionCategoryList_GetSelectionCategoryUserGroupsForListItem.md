---
title: GET List/SelectionCategory/Items/{id}/UserGroups
uid: v1SelectionCategoryList_GetSelectionCategoryUserGroupsForListItem
---

# GET List/SelectionCategory/Items/{id}/UserGroups

```http
GET /api/v1/List/SelectionCategory/Items/{itemId}/UserGroups
```

Gets user groups visible for the SelectionCategory list's item.


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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
GET /api/v1/List/SelectionCategory/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 734,
    "Name": "Kirlin, Christiansen and Kiehn",
    "ToolTip": "Aut reiciendis ducimus rerum.",
    "Deleted": true,
    "Rank": 896,
    "Type": "dolore",
    "ColorBlock": 445,
    "IconHint": "labore",
    "Selected": false,
    "LastChanged": "1997-08-11T17:37:40.3575059+02:00",
    "ChildItems": [
      {
        "Id": 57,
        "Name": "Flatley, Kiehn and Okuneva",
        "ToolTip": "Veritatis aliquid odit.",
        "Deleted": false,
        "Rank": 504,
        "Type": "maxime",
        "ColorBlock": 767,
        "IconHint": "nihil",
        "Selected": false,
        "LastChanged": "2016-11-03T17:37:40.3575059+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eos",
        "StyleHint": "dolor",
        "Hidden": true,
        "FullName": "Trystan Trantow II",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 869
          }
        }
      }
    ],
    "ExtraInfo": "saepe",
    "StyleHint": "doloribus",
    "Hidden": true,
    "FullName": "Mrs. Viola Durgan",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 732
      }
    }
  }
]
```