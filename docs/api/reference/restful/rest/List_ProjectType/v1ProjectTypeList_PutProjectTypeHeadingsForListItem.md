---
title: PUT List/ProjectType/Items/{id}/Headings
uid: v1ProjectTypeList_PutProjectTypeHeadingsForListItem
---

# PUT List/ProjectType/Items/{id}/Headings

```http
PUT /api/v1/List/ProjectType/Items/{itemId}/Headings
```

Saves headings for the ProjectType list's item.

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

OK

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

## Sample request

```http!
PUT /api/v1/List/ProjectType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 76,
    "Name": "Ondricka, Goodwin and Parisian",
    "ToolTip": "Omnis odit consequatur impedit consequuntur quibusdam.",
    "Deleted": false,
    "Rank": 909,
    "Type": "tenetur",
    "ColorBlock": 44,
    "IconHint": "delectus",
    "Selected": false,
    "LastChanged": "2021-04-21T11:10:54.4919301+02:00",
    "ChildItems": [
      {
        "Id": 175,
        "Name": "Halvorson, Turner and Abbott",
        "ToolTip": "Reprehenderit soluta.",
        "Deleted": true,
        "Rank": 690,
        "Type": "impedit",
        "ColorBlock": 694,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2012-03-21T11:10:54.4919301+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eum",
        "StyleHint": "non",
        "Hidden": false,
        "FullName": "Nikki Hermann"
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "laudantium",
    "Hidden": false,
    "FullName": "Miss Ernestina Jones DVM"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 275,
    "Name": "Gusikowski LLC",
    "ToolTip": "Ut et officia modi.",
    "Deleted": true,
    "Rank": 860,
    "Type": "voluptas",
    "ColorBlock": 391,
    "IconHint": "voluptatem",
    "Selected": false,
    "LastChanged": "2001-09-21T11:10:54.4929294+02:00",
    "ChildItems": [
      {
        "Id": 201,
        "Name": "Schimmel, Graham and Gislason",
        "ToolTip": "Incidunt quo et et sint necessitatibus.",
        "Deleted": false,
        "Rank": 927,
        "Type": "est",
        "ColorBlock": 8,
        "IconHint": "omnis",
        "Selected": false,
        "LastChanged": "2017-05-05T11:10:54.4929294+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tempore",
        "StyleHint": "tempore",
        "Hidden": false,
        "FullName": "Therese Shanahan",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 370
          }
        }
      }
    ],
    "ExtraInfo": "non",
    "StyleHint": "reprehenderit",
    "Hidden": true,
    "FullName": "Kody Murphy",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 647
      }
    }
  }
]
```
