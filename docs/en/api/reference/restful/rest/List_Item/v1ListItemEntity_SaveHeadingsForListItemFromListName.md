---
title: PUT List/{udListDefinitionName}/Items/{id}/Headings
uid: v1ListItemEntity_SaveHeadingsForListItemFromListName
generated: true
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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 395,
    "Name": "Gaylord-Hermiston",
    "ToolTip": "Est iure.",
    "Deleted": false,
    "Rank": 110,
    "Type": "incidunt",
    "ColorBlock": 891,
    "IconHint": "porro",
    "Selected": true,
    "LastChanged": "2018-04-12T13:28:32.6635259+02:00",
    "ChildItems": [
      {
        "Id": 522,
        "Name": "Lockman Inc and Sons",
        "ToolTip": "Incidunt commodi sit velit atque veritatis et facere.",
        "Deleted": false,
        "Rank": 965,
        "Type": "aut",
        "ColorBlock": 924,
        "IconHint": "aliquid",
        "Selected": true,
        "LastChanged": "2019-06-21T13:28:32.6635259+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tempore",
        "StyleHint": "odio",
        "Hidden": false,
        "FullName": "Prof. Adam Madison Spencer I"
      }
    ],
    "ExtraInfo": "sed",
    "StyleHint": "repellendus",
    "Hidden": true,
    "FullName": "Mr. Magdalena Renner"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 990,
    "Name": "Kuphal-Bartoletti",
    "ToolTip": "Placeat tempore deserunt perferendis commodi adipisci.",
    "Deleted": false,
    "Rank": 499,
    "Type": "ab",
    "ColorBlock": 126,
    "IconHint": "ut",
    "Selected": true,
    "LastChanged": "2012-12-22T13:28:32.6635259+01:00",
    "ChildItems": [
      {
        "Id": 119,
        "Name": "Carroll, Monahan and Hauck",
        "ToolTip": "Similique nesciunt at et facere et et.",
        "Deleted": false,
        "Rank": 45,
        "Type": "ut",
        "ColorBlock": 212,
        "IconHint": "molestiae",
        "Selected": false,
        "LastChanged": "2009-12-27T13:28:32.6635259+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "magnam",
        "StyleHint": "aspernatur",
        "Hidden": false,
        "FullName": "Jovani Boehm",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 318
          }
        }
      }
    ],
    "ExtraInfo": "nobis",
    "StyleHint": "quis",
    "Hidden": false,
    "FullName": "General Smith",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 598
      }
    }
  }
]
```