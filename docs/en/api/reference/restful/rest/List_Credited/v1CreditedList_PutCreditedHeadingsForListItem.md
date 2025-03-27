---
title: PUT List/Credited/Items/{id}/Headings
uid: v1CreditedList_PutCreditedHeadingsForListItem
generated: true
---

# PUT List/Credited/Items/{id}/Headings

```http
PUT /api/v1/List/Credited/Items/{itemId}/Headings
```

Saves headings for the Credited list's item.


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
PUT /api/v1/List/Credited/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 271,
    "Name": "Jakubowski, Abshire and Hahn",
    "ToolTip": "Quam repellendus.",
    "Deleted": true,
    "Rank": 30,
    "Type": "cum",
    "ColorBlock": 181,
    "IconHint": "voluptates",
    "Selected": true,
    "LastChanged": "2024-10-10T02:38:26.7299042+02:00",
    "ChildItems": [
      {
        "Id": 673,
        "Name": "Prosacco Inc and Sons",
        "ToolTip": "Quasi nam placeat quia architecto ullam sit ad.",
        "Deleted": true,
        "Rank": 980,
        "Type": "voluptatem",
        "ColorBlock": 928,
        "IconHint": "esse",
        "Selected": true,
        "LastChanged": "2012-02-29T02:38:26.7299042+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "est",
        "StyleHint": "nihil",
        "Hidden": false,
        "FullName": "Mr. Vivian Dean Lockman PhD"
      }
    ],
    "ExtraInfo": "delectus",
    "StyleHint": "ducimus",
    "Hidden": false,
    "FullName": "Mrs. Reginald Deckow"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 683,
    "Name": "Flatley LLC",
    "ToolTip": "Laboriosam cupiditate.",
    "Deleted": false,
    "Rank": 917,
    "Type": "sed",
    "ColorBlock": 151,
    "IconHint": "consequatur",
    "Selected": false,
    "LastChanged": "2006-04-14T02:38:26.7299042+02:00",
    "ChildItems": [
      {
        "Id": 495,
        "Name": "Predovic, Berge and Towne",
        "ToolTip": "Dignissimos nesciunt dolorem consequuntur nemo perspiciatis.",
        "Deleted": false,
        "Rank": 81,
        "Type": "eum",
        "ColorBlock": 920,
        "IconHint": "nostrum",
        "Selected": false,
        "LastChanged": "2016-01-06T02:38:26.7299042+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "molestiae",
        "StyleHint": "similique",
        "Hidden": false,
        "FullName": "Prof. Werner Hane III",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 871
          }
        }
      }
    ],
    "ExtraInfo": "natus",
    "StyleHint": "inventore",
    "Hidden": false,
    "FullName": "Gisselle Beatty",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 424
      }
    }
  }
]
```