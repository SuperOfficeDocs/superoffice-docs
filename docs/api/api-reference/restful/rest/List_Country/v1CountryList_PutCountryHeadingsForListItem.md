---
title: PUT List/Country/Items/{id}/Headings
id: v1CountryList_PutCountryHeadingsForListItem
---

# PUT List/Country/Items/{id}/Headings

```http
PUT /api/v1/List/Country/Items/{itemId}/Headings
```

Saves headings for the Country list's item.

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
PUT /api/v1/List/Country/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 980,
    "Name": "Mertz-Borer",
    "ToolTip": "Praesentium aliquid.",
    "Deleted": true,
    "Rank": 65,
    "Type": "sint",
    "ColorBlock": 83,
    "IconHint": "qui",
    "Selected": true,
    "LastChanged": "2021-03-31T18:25:51.7563301+02:00",
    "ChildItems": [
      {
        "Id": 80,
        "Name": "Jacobs-O'Connell",
        "ToolTip": "Eius et dicta velit facere aut at.",
        "Deleted": false,
        "Rank": 104,
        "Type": "non",
        "ColorBlock": 61,
        "IconHint": "quod",
        "Selected": true,
        "LastChanged": "2021-04-03T18:25:51.7563301+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "optio",
        "StyleHint": "enim",
        "Hidden": false,
        "FullName": "Dr. Audreanne Walker"
      }
    ],
    "ExtraInfo": "voluptatum",
    "StyleHint": "maiores",
    "Hidden": false,
    "FullName": "Kailee Thiel IV"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 879,
    "Name": "Spencer-Stamm",
    "ToolTip": "Aperiam corrupti.",
    "Deleted": false,
    "Rank": 528,
    "Type": "cupiditate",
    "ColorBlock": 738,
    "IconHint": "consequatur",
    "Selected": true,
    "LastChanged": "2005-11-11T18:25:51.757334+01:00",
    "ChildItems": [
      {
        "Id": 233,
        "Name": "Bradtke Group",
        "ToolTip": "Natus modi rerum.",
        "Deleted": false,
        "Rank": 433,
        "Type": "repellat",
        "ColorBlock": 252,
        "IconHint": "error",
        "Selected": true,
        "LastChanged": "2006-09-02T18:25:51.757334+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nihil",
        "StyleHint": "veritatis",
        "Hidden": false,
        "FullName": "Murray Kunze",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 20
          }
        }
      }
    ],
    "ExtraInfo": "iure",
    "StyleHint": "nemo",
    "Hidden": false,
    "FullName": "Chad Ledner",
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
        "FieldLength": 329
      }
    }
  }
]
```