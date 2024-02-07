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
    "Id": 187,
    "Name": "Macejkovic-Morar",
    "ToolTip": "Nemo assumenda est sunt necessitatibus.",
    "Deleted": false,
    "Rank": 869,
    "Type": "quo",
    "ColorBlock": 627,
    "IconHint": "voluptatibus",
    "Selected": false,
    "LastChanged": "2010-08-27T16:55:30.6901606+02:00",
    "ChildItems": [
      {
        "Id": 734,
        "Name": "Schaden, Raynor and Champlin",
        "ToolTip": "Fuga quasi animi.",
        "Deleted": false,
        "Rank": 504,
        "Type": "cum",
        "ColorBlock": 988,
        "IconHint": "omnis",
        "Selected": false,
        "LastChanged": "2011-03-16T16:55:30.6911912+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "possimus",
        "StyleHint": "aliquid",
        "Hidden": false,
        "FullName": "Prof. Frankie Desiree Auer"
      }
    ],
    "ExtraInfo": "error",
    "StyleHint": "et",
    "Hidden": false,
    "FullName": "Dr. Ayden Roosevelt Hoppe"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 926,
    "Name": "Flatley-Hansen",
    "ToolTip": "Placeat incidunt itaque nesciunt non.",
    "Deleted": false,
    "Rank": 904,
    "Type": "autem",
    "ColorBlock": 743,
    "IconHint": "quia",
    "Selected": false,
    "LastChanged": "2016-06-20T16:55:30.6921911+02:00",
    "ChildItems": [
      {
        "Id": 53,
        "Name": "Erdman, Mosciski and Torp",
        "ToolTip": "Aliquam expedita voluptas.",
        "Deleted": false,
        "Rank": 310,
        "Type": "debitis",
        "ColorBlock": 641,
        "IconHint": "placeat",
        "Selected": false,
        "LastChanged": "2021-12-14T16:55:30.6921911+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "et",
        "StyleHint": "fuga",
        "Hidden": false,
        "FullName": "Sophia Rosenbaum",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 819
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "ipsam",
    "Hidden": false,
    "FullName": "Mr. Amara Grace Hand V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 776
      }
    }
  }
]
```