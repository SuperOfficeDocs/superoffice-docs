---
title: PUT List/ConsentPurpose/Items/{id}/Headings
uid: v1ConsentPurposeList_PutConsentPurposeHeadingsForListItem
generated: true
---

# PUT List/ConsentPurpose/Items/{id}/Headings

```http
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/Headings
```

Saves headings for the ConsentPurpose list's item.


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
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 897,
    "Name": "Reinger-Morar",
    "ToolTip": "Deleniti maxime et iusto.",
    "Deleted": false,
    "Rank": 1001,
    "Type": "pariatur",
    "ColorBlock": 378,
    "IconHint": "dolore",
    "Selected": true,
    "LastChanged": "2003-01-08T13:28:32.7416326+01:00",
    "ChildItems": [
      {
        "Id": 244,
        "Name": "Brekke, Moen and Kozey",
        "ToolTip": "Ipsum architecto ea est totam facilis.",
        "Deleted": false,
        "Rank": 399,
        "Type": "magnam",
        "ColorBlock": 731,
        "IconHint": "itaque",
        "Selected": false,
        "LastChanged": "2022-02-11T13:28:32.7416326+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eius",
        "StyleHint": "molestiae",
        "Hidden": false,
        "FullName": "Isaac Rosenbaum Jr."
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "quia",
    "Hidden": false,
    "FullName": "Meagan Yost"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 664,
    "Name": "Watsica LLC",
    "ToolTip": "Eius molestiae ullam qui.",
    "Deleted": false,
    "Rank": 597,
    "Type": "nisi",
    "ColorBlock": 297,
    "IconHint": "exercitationem",
    "Selected": true,
    "LastChanged": "2012-08-24T13:28:32.7416326+02:00",
    "ChildItems": [
      {
        "Id": 78,
        "Name": "Purdy-Weimann",
        "ToolTip": "Et cupiditate consectetur.",
        "Deleted": false,
        "Rank": 163,
        "Type": "dolores",
        "ColorBlock": 52,
        "IconHint": "nesciunt",
        "Selected": false,
        "LastChanged": "2004-04-22T13:28:32.7416326+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "harum",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Andreane Brown",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 840
          }
        }
      }
    ],
    "ExtraInfo": "tempora",
    "StyleHint": "assumenda",
    "Hidden": true,
    "FullName": "Darion Bergstrom",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 733
      }
    }
  }
]
```