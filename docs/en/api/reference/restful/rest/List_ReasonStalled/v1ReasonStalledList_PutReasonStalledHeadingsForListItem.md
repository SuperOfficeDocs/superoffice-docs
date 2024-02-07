---
title: PUT List/ReasonStalled/Items/{id}/Headings
uid: v1ReasonStalledList_PutReasonStalledHeadingsForListItem
generated: true
---

# PUT List/ReasonStalled/Items/{id}/Headings

```http
PUT /api/v1/List/ReasonStalled/Items/{itemId}/Headings
```

Saves headings for the ReasonStalled list's item.


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
PUT /api/v1/List/ReasonStalled/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 898,
    "Name": "Hessel-Wolff",
    "ToolTip": "Autem iusto.",
    "Deleted": false,
    "Rank": 638,
    "Type": "expedita",
    "ColorBlock": 33,
    "IconHint": "reprehenderit",
    "Selected": false,
    "LastChanged": "1996-12-29T16:55:31.0521831+01:00",
    "ChildItems": [
      {
        "Id": 932,
        "Name": "Douglas, Lowe and Funk",
        "ToolTip": "Sed rerum magnam aut reprehenderit qui quis reiciendis.",
        "Deleted": false,
        "Rank": 92,
        "Type": "dolores",
        "ColorBlock": 766,
        "IconHint": "libero",
        "Selected": true,
        "LastChanged": "2017-01-14T16:55:31.0521831+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "necessitatibus",
        "StyleHint": "dolorem",
        "Hidden": true,
        "FullName": "Van Torphy II"
      }
    ],
    "ExtraInfo": "provident",
    "StyleHint": "quam",
    "Hidden": false,
    "FullName": "Blanca Dach V"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 513,
    "Name": "Adams LLC",
    "ToolTip": "Voluptas neque et quis.",
    "Deleted": false,
    "Rank": 298,
    "Type": "accusantium",
    "ColorBlock": 517,
    "IconHint": "ut",
    "Selected": false,
    "LastChanged": "2004-06-16T16:55:31.0531835+02:00",
    "ChildItems": [
      {
        "Id": 417,
        "Name": "Marquardt Group",
        "ToolTip": "Iure fugit.",
        "Deleted": false,
        "Rank": 76,
        "Type": "unde",
        "ColorBlock": 279,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2010-10-22T16:55:31.0531835+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequuntur",
        "StyleHint": "sequi",
        "Hidden": true,
        "FullName": "Antwan Janis Anderson I",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 28
          }
        }
      }
    ],
    "ExtraInfo": "dolorem",
    "StyleHint": "voluptatem",
    "Hidden": false,
    "FullName": "Dr. Dillan Maegan Marvin II",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 457
      }
    }
  }
]
```