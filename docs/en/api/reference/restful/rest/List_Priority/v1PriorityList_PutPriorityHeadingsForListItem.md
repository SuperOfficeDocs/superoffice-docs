---
title: PUT List/Priority/Items/{id}/Headings
uid: v1PriorityList_PutPriorityHeadingsForListItem
generated: true
---

# PUT List/Priority/Items/{id}/Headings

```http
PUT /api/v1/List/Priority/Items/{itemId}/Headings
```

Saves headings for the Priority list's item.


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
| Id | Integer | The Id of the ListItem |
| Name | String | The name of the ListItem |
| ToolTip | String | The tooltip of the ListItem |
| Deleted | Boolean | The deleted status of the ListItem |
| Rank | Integer | The rank of the ListItem |
| Type | String | The type of the ListItem. Custom field. |
| ColorBlock | Integer | The color indicator of the ListItem color block |
| IconHint | String | The Icon hint of the ListItem. Custom field. |
| Selected | Boolean | True if the ListItem is selected |
| LastChanged | String | Time of last change. |
| ChildItems | Array | The child items of the SelectableMDOListItem |
| ExtraInfo | String | Extra information added to the ListItem. Could be information such as sort order etc or other meta data. Custom field. |
| StyleHint | String | Style hint indicating, information such as background color etc. Custom field. |
| Hidden | Boolean | True if the ListItem is hidden |
| FullName | String | The name of the ListItem in its context |

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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/Priority/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 27,
    "Name": "Okuneva Inc and Sons",
    "ToolTip": "Quaerat ipsam aut est beatae consequatur.",
    "Deleted": true,
    "Rank": 748,
    "Type": "sed",
    "ColorBlock": 426,
    "IconHint": "sed",
    "Selected": true,
    "LastChanged": "2018-03-30T13:38:18.1244081+02:00",
    "ChildItems": [
      {
        "Id": 337,
        "Name": "Littel Inc and Sons",
        "ToolTip": "Quidem quia.",
        "Deleted": true,
        "Rank": 398,
        "Type": "iste",
        "ColorBlock": 41,
        "IconHint": "sequi",
        "Selected": true,
        "LastChanged": "2008-02-04T13:38:18.1244081+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "porro",
        "StyleHint": "molestiae",
        "Hidden": true,
        "FullName": "Lilla O'Conner"
      }
    ],
    "ExtraInfo": "quo",
    "StyleHint": "necessitatibus",
    "Hidden": false,
    "FullName": "Ronny Bogisich I"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 603,
    "Name": "Ondricka, Morissette and Balistreri",
    "ToolTip": "Dolorem facilis.",
    "Deleted": true,
    "Rank": 917,
    "Type": "facere",
    "ColorBlock": 858,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2009-05-12T13:38:18.1244081+02:00",
    "ChildItems": [
      {
        "Id": 295,
        "Name": "Abbott Inc and Sons",
        "ToolTip": "Necessitatibus culpa.",
        "Deleted": false,
        "Rank": 515,
        "Type": "ipsa",
        "ColorBlock": 696,
        "IconHint": "sit",
        "Selected": false,
        "LastChanged": "2001-07-22T13:38:18.1244081+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "officiis",
        "StyleHint": "sit",
        "Hidden": false,
        "FullName": "Ariane Pfannerstill",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 391
          }
        }
      }
    ],
    "ExtraInfo": "aspernatur",
    "StyleHint": "necessitatibus",
    "Hidden": false,
    "FullName": "Rod McLaughlin",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 889
      }
    }
  }
]
```