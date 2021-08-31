---
title: PUT List/SelectionCategory/Items/{id}/Headings
id: v1SelectionCategoryList_PutSelectionCategoryHeadingsForListItem
---

# PUT List/SelectionCategory/Items/{id}/Headings

```http
PUT /api/v1/List/SelectionCategory/Items/{itemId}/Headings
```

Saves headings for the SelectionCategory list's item.

Calls the List agent service SaveHeadingsForListItemFromListDefinition.




| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be saved. **Required** |



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
PUT /api/v1/List/SelectionCategory/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 3,
    "Name": "Nienow, Douglas and Bode",
    "ToolTip": "Sed voluptates id ullam et.",
    "Deleted": true,
    "Rank": 668,
    "Type": "molestiae",
    "ColorBlock": 779,
    "IconHint": "sit",
    "Selected": false,
    "LastChanged": "2021-07-21T15:05:43.818117+02:00",
    "ChildItems": [
      {
        "Id": 428,
        "Name": "Kozey-Shanahan",
        "ToolTip": "In earum porro corporis quia accusantium.",
        "Deleted": false,
        "Rank": 127,
        "Type": "labore",
        "ColorBlock": 299,
        "IconHint": "eaque",
        "Selected": false,
        "LastChanged": "2002-09-06T15:05:43.818117+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "necessitatibus",
        "StyleHint": "ipsum",
        "Hidden": true,
        "FullName": "Rosalee Mante PhD"
      }
    ],
    "ExtraInfo": "quo",
    "StyleHint": "fugiat",
    "Hidden": false,
    "FullName": "Ezekiel Hahn"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 879,
    "Name": "McKenzie, Corkery and Rau",
    "ToolTip": "Neque repellendus ut magnam quisquam.",
    "Deleted": true,
    "Rank": 927,
    "Type": "et",
    "ColorBlock": 288,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2005-12-07T15:05:43.8211025+01:00",
    "ChildItems": [
      {
        "Id": 873,
        "Name": "Roberts, Leuschke and Wiza",
        "ToolTip": "Assumenda delectus quod dolores quisquam commodi.",
        "Deleted": false,
        "Rank": 497,
        "Type": "laudantium",
        "ColorBlock": 497,
        "IconHint": "impedit",
        "Selected": true,
        "LastChanged": "2009-08-16T15:05:43.8211025+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "impedit",
        "StyleHint": "quidem",
        "Hidden": false,
        "FullName": "Carson Tillman",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 982
          }
        }
      }
    ],
    "ExtraInfo": "dolores",
    "StyleHint": "aut",
    "Hidden": true,
    "FullName": "Wellington Rutherford I",
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
        "FieldType": "System.String",
        "FieldLength": 431
      }
    }
  }
]
```