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
    "Id": 434,
    "Name": "Torphy, Shields and Shanahan",
    "ToolTip": "Consequuntur illum blanditiis quos.",
    "Deleted": false,
    "Rank": 330,
    "Type": "distinctio",
    "ColorBlock": 961,
    "IconHint": "fuga",
    "Selected": true,
    "LastChanged": "2014-03-11T11:06:42.6628226+01:00",
    "ChildItems": [
      {
        "Id": 424,
        "Name": "Kreiger-Kshlerin",
        "ToolTip": "Voluptatibus nihil vel aperiam quod aut et.",
        "Deleted": true,
        "Rank": 561,
        "Type": "in",
        "ColorBlock": 295,
        "IconHint": "rerum",
        "Selected": true,
        "LastChanged": "2019-05-22T11:06:42.6628226+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptas",
        "StyleHint": "eveniet",
        "Hidden": false,
        "FullName": "Belle Reynolds"
      }
    ],
    "ExtraInfo": "consequatur",
    "StyleHint": "nisi",
    "Hidden": true,
    "FullName": "Odessa Jaskolski"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 918,
    "Name": "McLaughlin Inc and Sons",
    "ToolTip": "Officia iusto necessitatibus voluptate perspiciatis libero.",
    "Deleted": false,
    "Rank": 834,
    "Type": "qui",
    "ColorBlock": 208,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "2015-05-01T11:06:42.6628226+02:00",
    "ChildItems": [
      {
        "Id": 755,
        "Name": "Bogisich Group",
        "ToolTip": "Ea perspiciatis modi fuga ipsa qui voluptates ut.",
        "Deleted": false,
        "Rank": 77,
        "Type": "quo",
        "ColorBlock": 43,
        "IconHint": "natus",
        "Selected": true,
        "LastChanged": "2006-08-13T11:06:42.6628226+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "accusantium",
        "StyleHint": "omnis",
        "Hidden": false,
        "FullName": "Mr. Lourdes Kiehn",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 141
          }
        }
      }
    ],
    "ExtraInfo": "repudiandae",
    "StyleHint": "quia",
    "Hidden": true,
    "FullName": "Ezra Raynor",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 297
      }
    }
  }
]
```