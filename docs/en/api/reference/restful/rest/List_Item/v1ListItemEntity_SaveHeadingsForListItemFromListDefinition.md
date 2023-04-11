---
title: PUT List/{id}/Items/{id}/Headings
uid: v1ListItemEntity_SaveHeadingsForListItemFromListDefinition
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 595,
    "Name": "Kiehn, Ledner and Franecki",
    "ToolTip": "Et possimus.",
    "Deleted": false,
    "Rank": 240,
    "Type": "corporis",
    "ColorBlock": 353,
    "IconHint": "non",
    "Selected": false,
    "LastChanged": "2020-03-17T15:29:31.0459467+01:00",
    "ChildItems": [
      {
        "Id": 549,
        "Name": "Upton, Quigley and Mertz",
        "ToolTip": "Suscipit beatae ut dicta ipsam.",
        "Deleted": false,
        "Rank": 880,
        "Type": "sapiente",
        "ColorBlock": 667,
        "IconHint": "eius",
        "Selected": true,
        "LastChanged": "2022-03-15T15:29:31.0459467+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "architecto",
        "StyleHint": "aut",
        "Hidden": false,
        "FullName": "Myra Durgan"
      }
    ],
    "ExtraInfo": "dolore",
    "StyleHint": "nisi",
    "Hidden": true,
    "FullName": "Prof. Sibyl Ward Jr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 48,
    "Name": "Hudson-Kautzer",
    "ToolTip": "Aliquid odit tenetur necessitatibus occaecati.",
    "Deleted": true,
    "Rank": 629,
    "Type": "incidunt",
    "ColorBlock": 334,
    "IconHint": "laudantium",
    "Selected": true,
    "LastChanged": "2001-03-29T15:29:31.0474468+02:00",
    "ChildItems": [
      {
        "Id": 33,
        "Name": "Lueilwitz, Fahey and Paucek",
        "ToolTip": "Illum et corporis consequuntur qui at ad.",
        "Deleted": false,
        "Rank": 424,
        "Type": "sapiente",
        "ColorBlock": 123,
        "IconHint": "ipsa",
        "Selected": false,
        "LastChanged": "2016-07-16T15:29:31.0474468+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "neque",
        "StyleHint": "animi",
        "Hidden": false,
        "FullName": "Ms. Christophe Lind Jr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 128
          }
        }
      }
    ],
    "ExtraInfo": "iste",
    "StyleHint": "inventore",
    "Hidden": false,
    "FullName": "Ciara Ernser",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 136
      }
    }
  }
]
```