---
title: PUT List/DocumentTemplate/Items/{id}/Headings
uid: v1DocumentTemplateList_PutDocumentTemplateEntityHeadingsForListItem
generated: true
---

# PUT List/DocumentTemplate/Items/{id}/Headings

```http
PUT /api/v1/List/DocumentTemplate/Items/{itemId}/Headings
```

Saves headings for the DocumentTemplateEntity list's item.


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
PUT /api/v1/List/DocumentTemplate/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 499,
    "Name": "Lindgren, Waelchi and Skiles",
    "ToolTip": "Dolorum temporibus quam sapiente voluptatibus veritatis saepe maxime.",
    "Deleted": true,
    "Rank": 305,
    "Type": "nihil",
    "ColorBlock": 576,
    "IconHint": "dolore",
    "Selected": false,
    "LastChanged": "2005-05-14T16:32:48.6807732+02:00",
    "ChildItems": [
      {
        "Id": 251,
        "Name": "Blanda, Klein and O'Connell",
        "ToolTip": "Eaque nesciunt.",
        "Deleted": false,
        "Rank": 616,
        "Type": "quibusdam",
        "ColorBlock": 966,
        "IconHint": "natus",
        "Selected": true,
        "LastChanged": "2013-09-10T16:32:48.6807732+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "accusamus",
        "StyleHint": "esse",
        "Hidden": false,
        "FullName": "Judd Schumm"
      }
    ],
    "ExtraInfo": "dolore",
    "StyleHint": "dolor",
    "Hidden": false,
    "FullName": "Marion Labadie"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 401,
    "Name": "Abernathy-Adams",
    "ToolTip": "Corrupti veritatis.",
    "Deleted": false,
    "Rank": 917,
    "Type": "reprehenderit",
    "ColorBlock": 657,
    "IconHint": "aut",
    "Selected": false,
    "LastChanged": "2001-03-28T16:32:48.6807732+02:00",
    "ChildItems": [
      {
        "Id": 164,
        "Name": "Dicki-Gleason",
        "ToolTip": "Nesciunt repellendus et suscipit rerum voluptatum eum ut.",
        "Deleted": true,
        "Rank": 708,
        "Type": "corporis",
        "ColorBlock": 666,
        "IconHint": "ipsa",
        "Selected": false,
        "LastChanged": "2016-02-02T16:32:48.6807732+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quam",
        "StyleHint": "perspiciatis",
        "Hidden": true,
        "FullName": "Ebony Beatty",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 957
          }
        }
      }
    ],
    "ExtraInfo": "magni",
    "StyleHint": "nam",
    "Hidden": false,
    "FullName": "Ms. Kailyn Rosalind Wolf",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 516
      }
    }
  }
]
```