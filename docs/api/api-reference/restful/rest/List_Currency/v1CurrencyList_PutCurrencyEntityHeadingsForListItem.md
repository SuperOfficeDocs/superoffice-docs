---
title: PUT List/Currency/Items/{id}/Headings
id: v1CurrencyList_PutCurrencyEntityHeadingsForListItem
---

# PUT List/Currency/Items/{id}/Headings

```http
PUT /api/v1/List/Currency/Items/{itemId}/Headings
```

Saves headings for the CurrencyEntity list's item.

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
PUT /api/v1/List/Currency/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 361,
    "Name": "Herzog-Legros",
    "ToolTip": "Earum atque saepe.",
    "Deleted": false,
    "Rank": 690,
    "Type": "sunt",
    "ColorBlock": 831,
    "IconHint": "voluptatem",
    "Selected": false,
    "LastChanged": "2005-10-18T15:05:43.4065101+02:00",
    "ChildItems": [
      {
        "Id": 447,
        "Name": "Abbott, Block and Barton",
        "ToolTip": "Qui quasi ut.",
        "Deleted": true,
        "Rank": 579,
        "Type": "libero",
        "ColorBlock": 244,
        "IconHint": "rem",
        "Selected": false,
        "LastChanged": "1996-04-07T15:05:43.4065101+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "omnis",
        "StyleHint": "ullam",
        "Hidden": true,
        "FullName": "Rocio Abshire DDS"
      }
    ],
    "ExtraInfo": "eveniet",
    "StyleHint": "sit",
    "Hidden": true,
    "FullName": "Susie Abernathy"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 206,
    "Name": "Senger-Vandervort",
    "ToolTip": "Eligendi quasi.",
    "Deleted": false,
    "Rank": 220,
    "Type": "iusto",
    "ColorBlock": 267,
    "IconHint": "aspernatur",
    "Selected": true,
    "LastChanged": "1997-01-30T15:05:43.4075101+01:00",
    "ChildItems": [
      {
        "Id": 203,
        "Name": "Barrows Inc and Sons",
        "ToolTip": "Iure similique rerum maiores.",
        "Deleted": true,
        "Rank": 374,
        "Type": "ex",
        "ColorBlock": 548,
        "IconHint": "temporibus",
        "Selected": false,
        "LastChanged": "2013-08-11T15:05:43.4075101+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "deleniti",
        "StyleHint": "officiis",
        "Hidden": true,
        "FullName": "Edwin McKenzie",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.Int32",
            "FieldLength": 970
          }
        }
      }
    ],
    "ExtraInfo": "quo",
    "StyleHint": "iure",
    "Hidden": true,
    "FullName": "Johnnie Wolf",
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
        "FieldLength": 805
      }
    }
  }
]
```