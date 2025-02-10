---
title: PUT List/Task/Items/{id}/Headings
uid: v1TaskList_PutTaskListItemHeadingsForListItem
generated: true
---

# PUT List/Task/Items/{id}/Headings

```http
PUT /api/v1/List/Task/Items/{itemId}/Headings
```

Saves headings for the TaskListItem list's item.


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
PUT /api/v1/List/Task/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 269,
    "Name": "Paucek-Tromp",
    "ToolTip": "Tempore voluptas.",
    "Deleted": false,
    "Rank": 760,
    "Type": "suscipit",
    "ColorBlock": 259,
    "IconHint": "ratione",
    "Selected": true,
    "LastChanged": "2014-05-01T12:01:33.6832402+02:00",
    "ChildItems": [
      {
        "Id": 19,
        "Name": "Hirthe, Torphy and Pfannerstill",
        "ToolTip": "Ipsum placeat.",
        "Deleted": false,
        "Rank": 963,
        "Type": "voluptatem",
        "ColorBlock": 178,
        "IconHint": "eos",
        "Selected": false,
        "LastChanged": "2023-11-29T12:01:33.6832402+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "aut",
        "Hidden": true,
        "FullName": "Lavinia Gulgowski"
      }
    ],
    "ExtraInfo": "nesciunt",
    "StyleHint": "aut",
    "Hidden": false,
    "FullName": "Casandra McDermott"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 645,
    "Name": "Johnson Inc and Sons",
    "ToolTip": "Voluptas aut.",
    "Deleted": false,
    "Rank": 182,
    "Type": "et",
    "ColorBlock": 1000,
    "IconHint": "voluptas",
    "Selected": false,
    "LastChanged": "2019-09-11T12:01:33.6832402+02:00",
    "ChildItems": [
      {
        "Id": 946,
        "Name": "Ward Group",
        "ToolTip": "Consectetur eos rerum velit voluptatibus voluptas.",
        "Deleted": true,
        "Rank": 177,
        "Type": "nam",
        "ColorBlock": 940,
        "IconHint": "beatae",
        "Selected": true,
        "LastChanged": "2014-11-03T12:01:33.6832402+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "fuga",
        "StyleHint": "similique",
        "Hidden": true,
        "FullName": "Kurtis Dare",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 657
          }
        }
      }
    ],
    "ExtraInfo": "cum",
    "StyleHint": "optio",
    "Hidden": false,
    "FullName": "Mrs. Buddy Dibbert I",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 625
      }
    }
  }
]
```