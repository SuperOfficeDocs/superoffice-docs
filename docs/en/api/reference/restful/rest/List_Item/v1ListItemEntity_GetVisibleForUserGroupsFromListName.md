---
title: GET List/{udListDefinitionName}/Items/{id}/UserGroups
uid: v1ListItemEntity_GetVisibleForUserGroupsFromListName
---

# GET List/{udListDefinitionName}/Items/{id}/UserGroups

```http
GET /api/v1/List/{udListDefinitionName}/Items/{listItemId}/UserGroups
```

List of User groups that this list item is visible for






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionName | string | The name of the list definition. **Required** |
| listItemId | int32 | The id of the list item **Required** |



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
GET /api/v1/List/{udListDefinitionName}/Items/{listItemId}/UserGroups
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
    "Id": 825,
    "Name": "Huel-Legros",
    "ToolTip": "Natus libero omnis modi suscipit doloremque.",
    "Deleted": false,
    "Rank": 339,
    "Type": "in",
    "ColorBlock": 538,
    "IconHint": "totam",
    "Selected": true,
    "LastChanged": "2001-08-11T17:37:39.6234305+02:00",
    "ChildItems": [
      {
        "Id": 80,
        "Name": "Schmeler-Nienow",
        "ToolTip": "Consequuntur et molestiae sed eos delectus ut.",
        "Deleted": false,
        "Rank": 137,
        "Type": "omnis",
        "ColorBlock": 576,
        "IconHint": "aut",
        "Selected": false,
        "LastChanged": "2016-08-29T17:37:39.6234305+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "eius",
        "Hidden": false,
        "FullName": "Theresia Bartell",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 971
          }
        }
      }
    ],
    "ExtraInfo": "officia",
    "StyleHint": "nemo",
    "Hidden": false,
    "FullName": "Mrs. Malika Michale Upton II",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 539
      }
    }
  }
]
```