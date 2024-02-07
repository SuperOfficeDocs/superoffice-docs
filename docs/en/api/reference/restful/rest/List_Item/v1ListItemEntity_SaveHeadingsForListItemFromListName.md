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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 178,
    "Name": "Walsh Inc and Sons",
    "ToolTip": "Laudantium eum laudantium et tempora voluptas dolorem est.",
    "Deleted": false,
    "Rank": 366,
    "Type": "cupiditate",
    "ColorBlock": 266,
    "IconHint": "quo",
    "Selected": true,
    "LastChanged": "2015-04-19T16:55:30.508697+02:00",
    "ChildItems": [
      {
        "Id": 529,
        "Name": "Murray, Jacobi and Pouros",
        "ToolTip": "Inventore et minus voluptas inventore sed.",
        "Deleted": false,
        "Rank": 365,
        "Type": "cum",
        "ColorBlock": 550,
        "IconHint": "eum",
        "Selected": true,
        "LastChanged": "2017-06-19T16:55:30.508697+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "accusantium",
        "StyleHint": "occaecati",
        "Hidden": true,
        "FullName": "Kaci Morissette"
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "repudiandae",
    "Hidden": false,
    "FullName": "Dr. Arely Deven Hudson Jr."
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 119,
    "Name": "Cartwright Inc and Sons",
    "ToolTip": "Accusantium consequatur qui aspernatur autem.",
    "Deleted": true,
    "Rank": 526,
    "Type": "minima",
    "ColorBlock": 575,
    "IconHint": "aperiam",
    "Selected": false,
    "LastChanged": "2005-02-17T16:55:30.5116967+01:00",
    "ChildItems": [
      {
        "Id": 36,
        "Name": "Frami, Fahey and Orn",
        "ToolTip": "Facilis expedita suscipit iure.",
        "Deleted": false,
        "Rank": 359,
        "Type": "blanditiis",
        "ColorBlock": 798,
        "IconHint": "explicabo",
        "Selected": true,
        "LastChanged": "2014-03-01T16:55:30.5116967+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "enim",
        "StyleHint": "sit",
        "Hidden": false,
        "FullName": "Kaleigh Kuhn",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 760
          }
        }
      }
    ],
    "ExtraInfo": "officiis",
    "StyleHint": "eveniet",
    "Hidden": true,
    "FullName": "Mr. Isabel Terence Corkery Jr.",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 993
      }
    }
  }
]
```