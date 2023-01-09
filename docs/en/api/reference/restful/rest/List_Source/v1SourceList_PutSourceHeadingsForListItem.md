---
title: PUT List/Source/Items/{id}/Headings
uid: v1SourceList_PutSourceHeadingsForListItem
---

# PUT List/Source/Items/{id}/Headings

```http
PUT /api/v1/List/Source/Items/{itemId}/Headings
```

Saves headings for the Source list's item.


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
PUT /api/v1/List/Source/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 32,
    "Name": "Metz, Pacocha and Runolfsson",
    "ToolTip": "Dolorem est.",
    "Deleted": false,
    "Rank": 56,
    "Type": "voluptas",
    "ColorBlock": 779,
    "IconHint": "quia",
    "Selected": true,
    "LastChanged": "2004-10-08T17:37:40.3775007+02:00",
    "ChildItems": [
      {
        "Id": 206,
        "Name": "Keeling, Keeling and Gorczany",
        "ToolTip": "Laudantium quia quae tempore illum molestiae.",
        "Deleted": false,
        "Rank": 993,
        "Type": "sapiente",
        "ColorBlock": 957,
        "IconHint": "culpa",
        "Selected": true,
        "LastChanged": "2008-05-03T17:37:40.3775007+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "recusandae",
        "StyleHint": "aut",
        "Hidden": false,
        "FullName": "Braulio Abshire"
      }
    ],
    "ExtraInfo": "minima",
    "StyleHint": "quia",
    "Hidden": true,
    "FullName": "Pearl O'Hara"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 961,
    "Name": "Raynor, Funk and Vandervort",
    "ToolTip": "Iure adipisci modi accusantium cupiditate sunt quo.",
    "Deleted": false,
    "Rank": 548,
    "Type": "autem",
    "ColorBlock": 850,
    "IconHint": "sit",
    "Selected": false,
    "LastChanged": "2007-01-23T17:37:40.3795079+01:00",
    "ChildItems": [
      {
        "Id": 887,
        "Name": "Hilpert LLC",
        "ToolTip": "Dolores quia et.",
        "Deleted": true,
        "Rank": 179,
        "Type": "quaerat",
        "ColorBlock": 926,
        "IconHint": "deleniti",
        "Selected": false,
        "LastChanged": "2014-07-22T17:37:40.3795079+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ullam",
        "StyleHint": "voluptas",
        "Hidden": true,
        "FullName": "Claudie Kiehn",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 558
          }
        }
      }
    ],
    "ExtraInfo": "quod",
    "StyleHint": "distinctio",
    "Hidden": true,
    "FullName": "Mrs. Brandy Sigmund Roberts",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 986
      }
    }
  }
]
```