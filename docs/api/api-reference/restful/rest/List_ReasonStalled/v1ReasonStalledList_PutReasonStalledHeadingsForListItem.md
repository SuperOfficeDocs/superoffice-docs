---
title: PUT List/ReasonStalled/Items/{id}/Headings
id: v1ReasonStalledList_PutReasonStalledHeadingsForListItem
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

## Sample Request

```http!
PUT /api/v1/List/ReasonStalled/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 948,
    "Name": "Conn Group",
    "ToolTip": "Sed aut sint.",
    "Deleted": true,
    "Rank": 595,
    "Type": "natus",
    "ColorBlock": 90,
    "IconHint": "voluptatem",
    "Selected": true,
    "LastChanged": "2006-08-27T18:25:52.1720185+02:00",
    "ChildItems": [
      {
        "Id": 427,
        "Name": "Kunde, Thompson and Willms",
        "ToolTip": "Aut voluptatem iste ut recusandae consequatur.",
        "Deleted": true,
        "Rank": 692,
        "Type": "omnis",
        "ColorBlock": 261,
        "IconHint": "cum",
        "Selected": true,
        "LastChanged": "1997-09-10T18:25:52.1720185+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "dolorem",
        "Hidden": false,
        "FullName": "Mr. Jessica Parker"
      }
    ],
    "ExtraInfo": "nobis",
    "StyleHint": "rerum",
    "Hidden": true,
    "FullName": "Caden Ratke"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 285,
    "Name": "Cartwright, Metz and Huel",
    "ToolTip": "Quo temporibus expedita consequatur error impedit.",
    "Deleted": true,
    "Rank": 21,
    "Type": "et",
    "ColorBlock": 965,
    "IconHint": "quo",
    "Selected": false,
    "LastChanged": "1995-05-21T18:25:52.1749846+02:00",
    "ChildItems": [
      {
        "Id": 548,
        "Name": "Keeling-Funk",
        "ToolTip": "Magnam est exercitationem eum.",
        "Deleted": true,
        "Rank": 593,
        "Type": "necessitatibus",
        "ColorBlock": 573,
        "IconHint": "eius",
        "Selected": false,
        "LastChanged": "1999-06-12T18:25:52.1749846+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sunt",
        "StyleHint": "nisi",
        "Hidden": false,
        "FullName": "Eugenia King DDS",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 179
          }
        }
      }
    ],
    "ExtraInfo": "neque",
    "StyleHint": "id",
    "Hidden": false,
    "FullName": "Evie Tremblay",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 976
      }
    }
  }
]
```