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
PUT /api/v1/List/Source/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 333,
    "Name": "Kassulke-Dooley",
    "ToolTip": "Ratione nemo quisquam corporis voluptates.",
    "Deleted": false,
    "Rank": 360,
    "Type": "et",
    "ColorBlock": 392,
    "IconHint": "ipsa",
    "Selected": false,
    "LastChanged": "2019-09-12T02:49:52.5471998+02:00",
    "ChildItems": [
      {
        "Id": 1000,
        "Name": "Schroeder, Fadel and Kreiger",
        "ToolTip": "Laudantium molestiae repellat ut officiis sit.",
        "Deleted": false,
        "Rank": 145,
        "Type": "nesciunt",
        "ColorBlock": 591,
        "IconHint": "omnis",
        "Selected": false,
        "LastChanged": "2010-08-20T02:49:52.5471998+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ea",
        "StyleHint": "qui",
        "Hidden": false,
        "FullName": "Thea Corkery"
      }
    ],
    "ExtraInfo": "natus",
    "StyleHint": "architecto",
    "Hidden": false,
    "FullName": "Otto Boyer"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 849,
    "Name": "Simonis, Lebsack and Johns",
    "ToolTip": "Saepe rerum sed id sunt dolor.",
    "Deleted": true,
    "Rank": 121,
    "Type": "ratione",
    "ColorBlock": 150,
    "IconHint": "quam",
    "Selected": false,
    "LastChanged": "2013-08-30T02:49:52.5471998+02:00",
    "ChildItems": [
      {
        "Id": 436,
        "Name": "Reilly-Bernier",
        "ToolTip": "Sed nihil corrupti nam consequatur cupiditate blanditiis.",
        "Deleted": false,
        "Rank": 320,
        "Type": "vel",
        "ColorBlock": 646,
        "IconHint": "beatae",
        "Selected": true,
        "LastChanged": "2022-09-15T02:49:52.5471998+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "minima",
        "StyleHint": "nulla",
        "Hidden": false,
        "FullName": "Krystina Considine",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 191
          }
        }
      }
    ],
    "ExtraInfo": "laborum",
    "StyleHint": "sit",
    "Hidden": false,
    "FullName": "Miss Berniece Barrows",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 242
      }
    }
  }
]
```