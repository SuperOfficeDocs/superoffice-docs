---
title: PUT List/Task/Items/{id}/Headings
uid: v1TaskList_PutTaskListItemHeadingsForListItem
generated: true
content_type: reference
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 699,
    "Name": "Spinka, Ziemann and Ratke",
    "ToolTip": "Sint culpa soluta.",
    "Deleted": false,
    "Rank": 164,
    "Type": "reprehenderit",
    "ColorBlock": 733,
    "IconHint": "error",
    "Selected": false,
    "LastChanged": "1999-08-10T02:30:53.4598845+02:00",
    "ChildItems": [
      {
        "Id": 667,
        "Name": "Hayes Inc and Sons",
        "ToolTip": "Perferendis sit saepe nihil id possimus velit at.",
        "Deleted": false,
        "Rank": 714,
        "Type": "sint",
        "ColorBlock": 327,
        "IconHint": "quae",
        "Selected": false,
        "LastChanged": "2007-12-02T02:30:53.4598845+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "ipsam",
        "Hidden": false,
        "FullName": "Lulu Mertz"
      }
    ],
    "ExtraInfo": "velit",
    "StyleHint": "vitae",
    "Hidden": false,
    "FullName": "Rosetta Renner"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 549,
    "Name": "Medhurst Group",
    "ToolTip": "Et aut atque pariatur temporibus repudiandae dolorum eos.",
    "Deleted": false,
    "Rank": 137,
    "Type": "vitae",
    "ColorBlock": 260,
    "IconHint": "facere",
    "Selected": true,
    "LastChanged": "2011-07-12T02:30:53.4598845+02:00",
    "ChildItems": [
      {
        "Id": 568,
        "Name": "Keeling Group",
        "ToolTip": "Neque sapiente consequuntur quasi consequatur minus amet.",
        "Deleted": false,
        "Rank": 639,
        "Type": "voluptatem",
        "ColorBlock": 540,
        "IconHint": "laboriosam",
        "Selected": false,
        "LastChanged": "2004-04-29T02:30:53.4598845+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sed",
        "StyleHint": "id",
        "Hidden": false,
        "FullName": "Giovanna Quigley DDS",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 279
          }
        }
      }
    ],
    "ExtraInfo": "nulla",
    "StyleHint": "rerum",
    "Hidden": true,
    "FullName": "Cara Kaitlyn Dach I",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 90
      }
    }
  }
]
```