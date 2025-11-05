---
title: PUT List/Rating/Items/{id}/Headings
uid: v1RatingList_PutSaleStageEntityHeadingsForListItem
generated: true
content_type: reference
---

# PUT List/Rating/Items/{id}/Headings

```http
PUT /api/v1/List/Rating/Items/{itemId}/Headings
```

Saves headings for the SaleStageEntity list's item.


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
PUT /api/v1/List/Rating/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 577,
    "Name": "Jewess Group",
    "ToolTip": "Dolores nostrum aut ipsam.",
    "Deleted": true,
    "Rank": 618,
    "Type": "quia",
    "ColorBlock": 404,
    "IconHint": "rerum",
    "Selected": true,
    "LastChanged": "2005-02-28T02:30:53.4130107+01:00",
    "ChildItems": [
      {
        "Id": 465,
        "Name": "Ferry-Koss",
        "ToolTip": "Odit excepturi mollitia commodi fuga rerum aperiam.",
        "Deleted": true,
        "Rank": 522,
        "Type": "consequatur",
        "ColorBlock": 237,
        "IconHint": "ut",
        "Selected": false,
        "LastChanged": "2011-02-19T02:30:53.4130107+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "expedita",
        "StyleHint": "doloremque",
        "Hidden": true,
        "FullName": "Mr. Maybell Heller"
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "ipsum",
    "Hidden": true,
    "FullName": "Gust Gorczany"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 309,
    "Name": "Crona-Hayes",
    "ToolTip": "Quia sapiente optio velit.",
    "Deleted": false,
    "Rank": 171,
    "Type": "iure",
    "ColorBlock": 212,
    "IconHint": "eum",
    "Selected": true,
    "LastChanged": "2018-07-17T02:30:53.4130107+02:00",
    "ChildItems": [
      {
        "Id": 496,
        "Name": "Ryan-Lockman",
        "ToolTip": "Corporis rerum est corrupti natus.",
        "Deleted": false,
        "Rank": 607,
        "Type": "est",
        "ColorBlock": 241,
        "IconHint": "sint",
        "Selected": false,
        "LastChanged": "2007-11-08T02:30:53.4130107+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "perspiciatis",
        "StyleHint": "commodi",
        "Hidden": false,
        "FullName": "Alf Kutch",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 114
          }
        }
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "ut",
    "Hidden": true,
    "FullName": "Mr. Jett Koss Sr.",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 458
      }
    }
  }
]
```