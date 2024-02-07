---
title: PUT List/LegalBase/Items/{id}/Headings
uid: v1LegalBaseList_PutLegalBaseHeadingsForListItem
generated: true
---

# PUT List/LegalBase/Items/{id}/Headings

```http
PUT /api/v1/List/LegalBase/Items/{itemId}/Headings
```

Saves headings for the LegalBase list's item.


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
PUT /api/v1/List/LegalBase/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 716,
    "Name": "Hilll, Sawayn and Willms",
    "ToolTip": "Nesciunt qui dolores esse asperiores asperiores dolorem.",
    "Deleted": false,
    "Rank": 889,
    "Type": "ea",
    "ColorBlock": 269,
    "IconHint": "totam",
    "Selected": false,
    "LastChanged": "2007-08-29T16:55:30.7072794+02:00",
    "ChildItems": [
      {
        "Id": 243,
        "Name": "McLaughlin, Hamill and Kuphal",
        "ToolTip": "Sed ut pariatur exercitationem non dolorum iusto.",
        "Deleted": false,
        "Rank": 143,
        "Type": "voluptatem",
        "ColorBlock": 295,
        "IconHint": "fugiat",
        "Selected": true,
        "LastChanged": "2018-08-07T16:55:30.7072794+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "nam",
        "Hidden": false,
        "FullName": "Adelle Franecki"
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "ipsa",
    "Hidden": false,
    "FullName": "Mariam Bogisich I"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 754,
    "Name": "Rogahn-Bauch",
    "ToolTip": "Voluptatem non quo.",
    "Deleted": true,
    "Rank": 237,
    "Type": "laboriosam",
    "ColorBlock": 223,
    "IconHint": "consectetur",
    "Selected": true,
    "LastChanged": "2020-10-14T16:55:30.7082709+02:00",
    "ChildItems": [
      {
        "Id": 408,
        "Name": "Considine, Herzog and Lowe",
        "ToolTip": "Molestiae et delectus nihil quia at quia.",
        "Deleted": true,
        "Rank": 580,
        "Type": "eius",
        "ColorBlock": 691,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2012-05-31T16:55:30.7082709+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "beatae",
        "Hidden": true,
        "FullName": "Annamae Mertz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 386
          }
        }
      }
    ],
    "ExtraInfo": "voluptatem",
    "StyleHint": "temporibus",
    "Hidden": false,
    "FullName": "Mr. Vaughn Columbus Hettinger MD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 731
      }
    }
  }
]
```