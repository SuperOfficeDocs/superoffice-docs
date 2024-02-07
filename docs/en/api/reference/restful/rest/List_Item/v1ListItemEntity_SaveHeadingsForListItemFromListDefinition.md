---
title: PUT List/{id}/Items/{id}/Headings
uid: v1ListItemEntity_SaveHeadingsForListItemFromListDefinition
generated: true
---

# PUT List/{id}/Items/{id}/Headings

```http
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
```

Saves the active headings for the list item.






| Path Part | Type | Description |
|-----------|------|-------------|
| udListDefinitionId | int32 | The id of the list definition, indicating which list to delete the items from. Negative numbers indicate TableNumber value instead of UDListDefId. e.g. -64 = category. **Required** |
| listItemId | int32 | The identity of the list item to delete **Required** |



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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/{udListDefinitionId}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 40,
    "Name": "Kub, Baumbach and Casper",
    "ToolTip": "Dolore aut velit.",
    "Deleted": true,
    "Rank": 797,
    "Type": "a",
    "ColorBlock": 277,
    "IconHint": "hic",
    "Selected": false,
    "LastChanged": "1999-01-24T16:55:30.5056973+01:00",
    "ChildItems": [
      {
        "Id": 530,
        "Name": "Walter, Marquardt and McCullough",
        "ToolTip": "Et et cumque nesciunt cupiditate aperiam eveniet.",
        "Deleted": false,
        "Rank": 925,
        "Type": "consequatur",
        "ColorBlock": 959,
        "IconHint": "vel",
        "Selected": false,
        "LastChanged": "2014-04-29T16:55:30.5056973+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vero",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Mrs. Woodrow Maudie Bartoletti"
      }
    ],
    "ExtraInfo": "ipsam",
    "StyleHint": "in",
    "Hidden": true,
    "FullName": "Bridget Kulas"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 924,
    "Name": "Kuvalis LLC",
    "ToolTip": "Ea ex suscipit veniam corrupti aut consequatur.",
    "Deleted": true,
    "Rank": 507,
    "Type": "doloribus",
    "ColorBlock": 358,
    "IconHint": "dolorem",
    "Selected": false,
    "LastChanged": "2003-08-28T16:55:30.5076975+02:00",
    "ChildItems": [
      {
        "Id": 683,
        "Name": "Bahringer, Goyette and Collins",
        "ToolTip": "Sit deserunt quis qui.",
        "Deleted": false,
        "Rank": 11,
        "Type": "voluptates",
        "ColorBlock": 814,
        "IconHint": "quis",
        "Selected": false,
        "LastChanged": "2006-08-14T16:55:30.5076975+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "at",
        "StyleHint": "ex",
        "Hidden": false,
        "FullName": "Sebastian Loy Bayer V",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 412
          }
        }
      }
    ],
    "ExtraInfo": "maxime",
    "StyleHint": "commodi",
    "Hidden": false,
    "FullName": "Anjali Maggio",
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