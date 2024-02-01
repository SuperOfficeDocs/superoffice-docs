---
title: PUT List/Position/Items/{id}/UserGroups
uid: v1PositionList_PutPositionUserGroupsForListItem
generated: true
---

# PUT List/Position/Items/{id}/UserGroups

```http
PUT /api/v1/List/Position/Items/{itemId}/UserGroups
```

Saves user groups visible for the Position list's item.


Calls the List agent service SaveHeadingsForListItemFromListDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to save. **Required** |



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
PUT /api/v1/List/Position/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 752,
    "Name": "Mante LLC",
    "ToolTip": "Cumque optio quis at explicabo.",
    "Deleted": true,
    "Rank": 564,
    "Type": "provident",
    "ColorBlock": 111,
    "IconHint": "deleniti",
    "Selected": false,
    "LastChanged": "2016-02-18T23:04:05.5699982+01:00",
    "ChildItems": [
      {
        "Id": 159,
        "Name": "Hoeger, Rowe and Turcotte",
        "ToolTip": "Consequatur eius praesentium esse et enim iusto ut.",
        "Deleted": false,
        "Rank": 301,
        "Type": "officia",
        "ColorBlock": 786,
        "IconHint": "quas",
        "Selected": false,
        "LastChanged": "2002-05-05T23:04:05.5699982+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quod",
        "StyleHint": "est",
        "Hidden": false,
        "FullName": "Josianne Hand"
      }
    ],
    "ExtraInfo": "pariatur",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Darien Roberts"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 95,
    "Name": "Ankunding-Schroeder",
    "ToolTip": "Eos sit repudiandae ipsum esse dolorem dolorem.",
    "Deleted": false,
    "Rank": 886,
    "Type": "sed",
    "ColorBlock": 369,
    "IconHint": "excepturi",
    "Selected": true,
    "LastChanged": "2013-06-27T23:04:05.5724997+02:00",
    "ChildItems": [
      {
        "Id": 833,
        "Name": "Wiegand, Powlowski and Schimmel",
        "ToolTip": "Voluptatum magni magni modi.",
        "Deleted": false,
        "Rank": 13,
        "Type": "sint",
        "ColorBlock": 577,
        "IconHint": "sunt",
        "Selected": false,
        "LastChanged": "2023-06-06T23:04:05.5724997+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aperiam",
        "StyleHint": "quae",
        "Hidden": false,
        "FullName": "Wilton Lueilwitz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 779
          }
        }
      }
    ],
    "ExtraInfo": "voluptas",
    "StyleHint": "deleniti",
    "Hidden": false,
    "FullName": "Adelbert Oberbrunner",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 655
      }
    }
  }
]
```