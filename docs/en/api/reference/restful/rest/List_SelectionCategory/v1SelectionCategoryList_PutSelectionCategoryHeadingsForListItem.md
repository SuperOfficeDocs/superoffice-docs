---
title: PUT List/SelectionCategory/Items/{id}/Headings
uid: v1SelectionCategoryList_PutSelectionCategoryHeadingsForListItem
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/SelectionCategory/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 692,
    "Name": "Beatty LLC",
    "ToolTip": "Dolorem sapiente et et libero ut sunt earum.",
    "Deleted": false,
    "Rank": 275,
    "Type": "enim",
    "ColorBlock": 887,
    "IconHint": "ipsam",
    "Selected": false,
    "LastChanged": "2003-10-09T17:37:40.3624952+02:00",
    "ChildItems": [
      {
        "Id": 767,
        "Name": "Daugherty-Walter",
        "ToolTip": "Pariatur laboriosam dolorem ab eos.",
        "Deleted": false,
        "Rank": 814,
        "Type": "repudiandae",
        "ColorBlock": 796,
        "IconHint": "qui",
        "Selected": true,
        "LastChanged": "2010-05-26T17:37:40.3624952+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sed",
        "StyleHint": "veniam",
        "Hidden": false,
        "FullName": "Yesenia Jerrold Pacocha PhD"
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "ducimus",
    "Hidden": true,
    "FullName": "Ms. Rodolfo Parker I"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 952,
    "Name": "Ryan-Gerlach",
    "ToolTip": "Ut accusantium voluptatem sit et esse neque.",
    "Deleted": false,
    "Rank": 815,
    "Type": "quidem",
    "ColorBlock": 283,
    "IconHint": "in",
    "Selected": false,
    "LastChanged": "2011-07-12T17:37:40.3645004+02:00",
    "ChildItems": [
      {
        "Id": 242,
        "Name": "Hudson Group",
        "ToolTip": "Rerum enim laboriosam maxime tempore saepe doloribus molestiae.",
        "Deleted": false,
        "Rank": 162,
        "Type": "officia",
        "ColorBlock": 5,
        "IconHint": "modi",
        "Selected": true,
        "LastChanged": "2017-03-06T17:37:40.3645004+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Prof. Fritz Bartoletti",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 341
          }
        }
      }
    ],
    "ExtraInfo": "neque",
    "StyleHint": "saepe",
    "Hidden": false,
    "FullName": "Ethan Nitzsche",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 330
      }
    }
  }
]
```