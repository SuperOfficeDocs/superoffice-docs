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
    "Id": 458,
    "Name": "Stokes Inc and Sons",
    "ToolTip": "Vel quo.",
    "Deleted": true,
    "Rank": 127,
    "Type": "laudantium",
    "ColorBlock": 680,
    "IconHint": "est",
    "Selected": false,
    "LastChanged": "1998-08-12T18:25:52.2079863+02:00",
    "ChildItems": [
      {
        "Id": 368,
        "Name": "D'Amore Group",
        "ToolTip": "Provident omnis facere aut necessitatibus.",
        "Deleted": true,
        "Rank": 406,
        "Type": "totam",
        "ColorBlock": 551,
        "IconHint": "voluptas",
        "Selected": true,
        "LastChanged": "1994-10-11T18:25:52.2079863+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eaque",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Rosalind Wiegand"
      }
    ],
    "ExtraInfo": "officia",
    "StyleHint": "quis",
    "Hidden": false,
    "FullName": "Art Wisozk"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 885,
    "Name": "Douglas Group",
    "ToolTip": "Architecto porro perspiciatis debitis architecto.",
    "Deleted": false,
    "Rank": 999,
    "Type": "in",
    "ColorBlock": 292,
    "IconHint": "quidem",
    "Selected": true,
    "LastChanged": "2005-04-06T18:25:52.2089862+02:00",
    "ChildItems": [
      {
        "Id": 973,
        "Name": "Jones Inc and Sons",
        "ToolTip": "Laudantium eum consequatur qui.",
        "Deleted": false,
        "Rank": 994,
        "Type": "est",
        "ColorBlock": 530,
        "IconHint": "vel",
        "Selected": true,
        "LastChanged": "2003-09-07T18:25:52.2089862+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatem",
        "StyleHint": "nihil",
        "Hidden": false,
        "FullName": "Esteban Upton",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 49
          }
        }
      }
    ],
    "ExtraInfo": "nemo",
    "StyleHint": "sint",
    "Hidden": false,
    "FullName": "Jada Beier",
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
        "FieldLength": 993
      }
    }
  }
]
```