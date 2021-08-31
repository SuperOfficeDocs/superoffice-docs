---
title: PUT List/ProjectStatus/Items/{id}/UserGroups
id: v1ProjectStatusList_PutProjectStatusUserGroupsForListItem
---

# PUT List/ProjectStatus/Items/{id}/UserGroups

```http
PUT /api/v1/List/ProjectStatus/Items/{itemId}/UserGroups
```

Saves user groups visible for the ProjectStatus list's item.

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
PUT /api/v1/List/ProjectStatus/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 894,
    "Name": "Hessel Inc and Sons",
    "ToolTip": "Cupiditate quia et error cumque perferendis.",
    "Deleted": true,
    "Rank": 799,
    "Type": "qui",
    "ColorBlock": 286,
    "IconHint": "sequi",
    "Selected": true,
    "LastChanged": "2021-01-03T15:05:43.6951117+01:00",
    "ChildItems": [
      {
        "Id": 7,
        "Name": "Roberts-Cassin",
        "ToolTip": "Voluptatem aut earum fugit quo sapiente.",
        "Deleted": false,
        "Rank": 618,
        "Type": "accusamus",
        "ColorBlock": 132,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2018-09-29T15:05:43.6951117+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quia",
        "StyleHint": "labore",
        "Hidden": false,
        "FullName": "Ms. Demetris Lehner"
      }
    ],
    "ExtraInfo": "doloremque",
    "StyleHint": "delectus",
    "Hidden": true,
    "FullName": "General Huel"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 91,
    "Name": "Goodwin-Beer",
    "ToolTip": "Excepturi dolorum suscipit reiciendis dolor.",
    "Deleted": true,
    "Rank": 368,
    "Type": "ut",
    "ColorBlock": 569,
    "IconHint": "sunt",
    "Selected": false,
    "LastChanged": "2009-07-18T15:05:43.6971125+02:00",
    "ChildItems": [
      {
        "Id": 356,
        "Name": "Toy-Legros",
        "ToolTip": "Quos sunt odio aut ut omnis quasi.",
        "Deleted": false,
        "Rank": 858,
        "Type": "esse",
        "ColorBlock": 805,
        "IconHint": "dolor",
        "Selected": true,
        "LastChanged": "1996-02-24T15:05:43.6971125+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tempore",
        "StyleHint": "dolor",
        "Hidden": false,
        "FullName": "Myles Kessler",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 541
          }
        }
      }
    ],
    "ExtraInfo": "expedita",
    "StyleHint": "velit",
    "Hidden": false,
    "FullName": "Kennith Armstrong",
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
        "FieldLength": 358
      }
    }
  }
]
```