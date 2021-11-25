---
title: PUT List/Reason/Items/{id}/Headings
id: v1ReasonList_PutReasonHeadingsForListItem
---

# PUT List/Reason/Items/{id}/Headings

```http
PUT /api/v1/List/Reason/Items/{itemId}/Headings
```

Saves headings for the Reason list's item.

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
PUT /api/v1/List/Reason/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 818,
    "Name": "McKenzie Inc and Sons",
    "ToolTip": "Delectus magni quae nemo impedit tempore eos.",
    "Deleted": false,
    "Rank": 698,
    "Type": "qui",
    "ColorBlock": 398,
    "IconHint": "veritatis",
    "Selected": true,
    "LastChanged": "2014-01-08T18:25:52.1380188+01:00",
    "ChildItems": [
      {
        "Id": 492,
        "Name": "Botsford, McGlynn and Purdy",
        "ToolTip": "In aliquam esse.",
        "Deleted": true,
        "Rank": 161,
        "Type": "quia",
        "ColorBlock": 277,
        "IconHint": "cumque",
        "Selected": false,
        "LastChanged": "2000-06-03T18:25:52.1380188+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "architecto",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Maximo Rosenbaum"
      }
    ],
    "ExtraInfo": "nobis",
    "StyleHint": "consequuntur",
    "Hidden": true,
    "FullName": "Andres Lynch"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 31,
    "Name": "Sipes-VonRueden",
    "ToolTip": "Ratione error dicta alias quam ex.",
    "Deleted": false,
    "Rank": 399,
    "Type": "impedit",
    "ColorBlock": 169,
    "IconHint": "corporis",
    "Selected": true,
    "LastChanged": "2007-01-04T18:25:52.1390187+01:00",
    "ChildItems": [
      {
        "Id": 543,
        "Name": "Kirlin Group",
        "ToolTip": "Quo consequuntur et.",
        "Deleted": false,
        "Rank": 339,
        "Type": "nemo",
        "ColorBlock": 581,
        "IconHint": "modi",
        "Selected": false,
        "LastChanged": "2005-07-15T18:25:52.1390187+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "facere",
        "StyleHint": "sint",
        "Hidden": false,
        "FullName": "Ola Corkery",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 905
          }
        }
      }
    ],
    "ExtraInfo": "vitae",
    "StyleHint": "reiciendis",
    "Hidden": false,
    "FullName": "Ward Conn",
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
        "FieldLength": 258
      }
    }
  }
]
```