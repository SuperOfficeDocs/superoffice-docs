---
title: PUT List/{udListDefinitionName}/Items/{id}/Headings
uid: v1ListItemEntity_SaveHeadingsForListItemFromListName
---

# PUT List/{udListDefinitionName}/Items/{id}/Headings

```http
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings
```

Saves the headings for the list item.






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionName | string | The name of the list definition, indicating which list to update. **Required** |
| listItemId | int32 | The identity of the list item **Required** |



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

## Request Body: headings 

The headings to save. 

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
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 225,
    "Name": "Bernier, Rau and Nitzsche",
    "ToolTip": "Excepturi unde alias.",
    "Deleted": false,
    "Rank": 879,
    "Type": "assumenda",
    "ColorBlock": 461,
    "IconHint": "magnam",
    "Selected": true,
    "LastChanged": "2005-06-28T17:37:39.6344312+02:00",
    "ChildItems": [
      {
        "Id": 844,
        "Name": "Cormier, Gulgowski and Waelchi",
        "ToolTip": "Adipisci quo rerum fugit dolorum praesentium.",
        "Deleted": true,
        "Rank": 572,
        "Type": "nobis",
        "ColorBlock": 315,
        "IconHint": "omnis",
        "Selected": false,
        "LastChanged": "1997-12-17T17:37:39.6344312+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "culpa",
        "StyleHint": "sed",
        "Hidden": true,
        "FullName": "Izabella Treutel"
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "culpa",
    "Hidden": false,
    "FullName": "Ms. Jules Tommie Kling I"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 332,
    "Name": "Heidenreich, Gerhold and Rempel",
    "ToolTip": "Tenetur sed illum quo nisi debitis.",
    "Deleted": false,
    "Rank": 324,
    "Type": "ut",
    "ColorBlock": 56,
    "IconHint": "ad",
    "Selected": true,
    "LastChanged": "2008-08-25T17:37:39.6364307+02:00",
    "ChildItems": [
      {
        "Id": 441,
        "Name": "Greenholt, Breitenberg and Dickens",
        "ToolTip": "Blanditiis consequatur earum doloribus sed et.",
        "Deleted": false,
        "Rank": 590,
        "Type": "ut",
        "ColorBlock": 821,
        "IconHint": "non",
        "Selected": true,
        "LastChanged": "2017-08-23T17:37:39.6364307+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consectetur",
        "StyleHint": "aut",
        "Hidden": false,
        "FullName": "Cornelius Herzog",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 459
          }
        }
      }
    ],
    "ExtraInfo": "ipsum",
    "StyleHint": "quisquam",
    "Hidden": true,
    "FullName": "Earline Daugherty",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 197
      }
    }
  }
]
```