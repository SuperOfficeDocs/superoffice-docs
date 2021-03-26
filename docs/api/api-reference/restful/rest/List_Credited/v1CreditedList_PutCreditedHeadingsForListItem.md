---
title: PUT List/Credited/Items/{id}/Headings
id: v1CreditedList_PutCreditedHeadingsForListItem
---

# PUT List/Credited/Items/{id}/Headings

```http
PUT /api/v1/List/Credited/Items/{itemId}/Headings
```

Saves headings for the Credited list's item.

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
PUT /api/v1/List/Credited/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 623,
    "Name": "Stamm Inc and Sons",
    "ToolTip": "Aut deleniti.",
    "Deleted": true,
    "Rank": 54,
    "Type": "ut",
    "ColorBlock": 705,
    "IconHint": "velit",
    "Selected": false,
    "LastChanged": "1999-10-18T09:41:00.3213814+02:00",
    "ChildItems": [
      {
        "Id": 649,
        "Name": "Kovacek, Hauck and Mills",
        "ToolTip": "Quibusdam eaque.",
        "Deleted": true,
        "Rank": 921,
        "Type": "non",
        "ColorBlock": 389,
        "IconHint": "cumque",
        "Selected": false,
        "LastChanged": "2011-09-30T09:41:00.3213814+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quis",
        "StyleHint": "dolor",
        "Hidden": true,
        "FullName": "Mr. Kaela Volkman"
      }
    ],
    "ExtraInfo": "sunt",
    "StyleHint": "exercitationem",
    "Hidden": true,
    "FullName": "Syble Homenick"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 692,
    "Name": "Legros Group",
    "ToolTip": "Distinctio et quis dolorum fugit.",
    "Deleted": true,
    "Rank": 238,
    "Type": "qui",
    "ColorBlock": 237,
    "IconHint": "omnis",
    "Selected": false,
    "LastChanged": "1994-10-10T09:41:00.3223815+02:00",
    "ChildItems": [
      {
        "Id": 47,
        "Name": "Casper LLC",
        "ToolTip": "Tempora vel magnam eos.",
        "Deleted": false,
        "Rank": 110,
        "Type": "recusandae",
        "ColorBlock": 858,
        "IconHint": "incidunt",
        "Selected": false,
        "LastChanged": "2008-10-18T09:41:00.3223815+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "incidunt",
        "StyleHint": "qui",
        "Hidden": false,
        "FullName": "Davonte Cormier",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 590
          }
        }
      }
    ],
    "ExtraInfo": "rerum",
    "StyleHint": "ab",
    "Hidden": true,
    "FullName": "Kenyatta Williamson",
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
        "FieldLength": 689
      }
    }
  }
]
```