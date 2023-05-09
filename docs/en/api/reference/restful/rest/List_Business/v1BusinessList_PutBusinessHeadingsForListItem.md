---
title: PUT List/Business/Items/{id}/Headings
uid: v1BusinessList_PutBusinessHeadingsForListItem
---

# PUT List/Business/Items/{id}/Headings

```http
PUT /api/v1/List/Business/Items/{itemId}/Headings
```

Saves headings for the Business list's item.


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
PUT /api/v1/List/Business/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 842,
    "Name": "Howe, Marks and Smith",
    "ToolTip": "Eligendi qui sequi voluptas qui et.",
    "Deleted": false,
    "Rank": 915,
    "Type": "quia",
    "ColorBlock": 372,
    "IconHint": "sequi",
    "Selected": false,
    "LastChanged": "2023-01-30T03:51:34.3802934+01:00",
    "ChildItems": [
      {
        "Id": 515,
        "Name": "Kuhlman-Balistreri",
        "ToolTip": "Error voluptatum et odio eos eum dolorem.",
        "Deleted": false,
        "Rank": 79,
        "Type": "sit",
        "ColorBlock": 329,
        "IconHint": "accusamus",
        "Selected": false,
        "LastChanged": "1996-07-17T03:51:34.3802934+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "veritatis",
        "StyleHint": "magnam",
        "Hidden": false,
        "FullName": "Mrs. Vanessa Schiller"
      }
    ],
    "ExtraInfo": "dolorem",
    "StyleHint": "iusto",
    "Hidden": true,
    "FullName": "Mrs. Justine Sandrine Balistreri MD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 571,
    "Name": "Kulas, Jerde and Lemke",
    "ToolTip": "Et necessitatibus natus facilis ut nulla.",
    "Deleted": false,
    "Rank": 722,
    "Type": "occaecati",
    "ColorBlock": 294,
    "IconHint": "molestias",
    "Selected": false,
    "LastChanged": "2003-01-04T03:51:34.3802934+01:00",
    "ChildItems": [
      {
        "Id": 90,
        "Name": "Mante-Simonis",
        "ToolTip": "Harum ut suscipit voluptatem fugiat autem sint.",
        "Deleted": false,
        "Rank": 568,
        "Type": "pariatur",
        "ColorBlock": 95,
        "IconHint": "rem",
        "Selected": false,
        "LastChanged": "2012-09-14T03:51:34.3802934+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "enim",
        "StyleHint": "repellendus",
        "Hidden": false,
        "FullName": "Malcolm Blanda",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 696
          }
        }
      }
    ],
    "ExtraInfo": "vero",
    "StyleHint": "nostrum",
    "Hidden": false,
    "FullName": "Mr. Barry Emmanuelle Feil V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 823
      }
    }
  }
]
```