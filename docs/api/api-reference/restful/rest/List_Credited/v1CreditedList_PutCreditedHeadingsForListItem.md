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
    "Id": 282,
    "Name": "Mayer, Lowe and Bradtke",
    "ToolTip": "Natus laborum.",
    "Deleted": false,
    "Rank": 763,
    "Type": "eius",
    "ColorBlock": 808,
    "IconHint": "iure",
    "Selected": false,
    "LastChanged": "2014-03-31T15:05:43.3915101+02:00",
    "ChildItems": [
      {
        "Id": 721,
        "Name": "Heathcote Group",
        "ToolTip": "Deleniti esse porro qui ipsum aut quod.",
        "Deleted": true,
        "Rank": 167,
        "Type": "in",
        "ColorBlock": 939,
        "IconHint": "commodi",
        "Selected": true,
        "LastChanged": "2006-12-07T15:05:43.3915101+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "impedit",
        "StyleHint": "pariatur",
        "Hidden": false,
        "FullName": "Maureen White"
      }
    ],
    "ExtraInfo": "rerum",
    "StyleHint": "sint",
    "Hidden": false,
    "FullName": "Name Schiller"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 860,
    "Name": "Runolfsdottir Group",
    "ToolTip": "Doloremque consequatur facere autem explicabo animi ad.",
    "Deleted": true,
    "Rank": 465,
    "Type": "suscipit",
    "ColorBlock": 685,
    "IconHint": "est",
    "Selected": true,
    "LastChanged": "2015-08-21T15:05:43.3935101+02:00",
    "ChildItems": [
      {
        "Id": 769,
        "Name": "Witting-Stroman",
        "ToolTip": "Quidem et quasi nihil.",
        "Deleted": false,
        "Rank": 724,
        "Type": "iure",
        "ColorBlock": 449,
        "IconHint": "consequuntur",
        "Selected": false,
        "LastChanged": "2016-08-26T15:05:43.3935101+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "non",
        "StyleHint": "modi",
        "Hidden": true,
        "FullName": "Toy Becker",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 592
          }
        }
      }
    ],
    "ExtraInfo": "accusantium",
    "StyleHint": "quisquam",
    "Hidden": true,
    "FullName": "Pedro Boehm",
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
        "FieldLength": 173
      }
    }
  }
]
```