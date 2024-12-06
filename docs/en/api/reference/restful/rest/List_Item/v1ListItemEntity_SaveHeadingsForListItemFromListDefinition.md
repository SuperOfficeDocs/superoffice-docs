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
    "Id": 262,
    "Name": "Gibson, Hammes and Mann",
    "ToolTip": "Aliquam culpa asperiores odit.",
    "Deleted": false,
    "Rank": 230,
    "Type": "quia",
    "ColorBlock": 650,
    "IconHint": "ex",
    "Selected": false,
    "LastChanged": "2006-08-20T10:18:00.926237+02:00",
    "ChildItems": [
      {
        "Id": 472,
        "Name": "Hackett Inc and Sons",
        "ToolTip": "Et iure cupiditate.",
        "Deleted": false,
        "Rank": 628,
        "Type": "cumque",
        "ColorBlock": 119,
        "IconHint": "aut",
        "Selected": true,
        "LastChanged": "1998-08-26T10:18:00.926237+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "necessitatibus",
        "StyleHint": "laborum",
        "Hidden": true,
        "FullName": "Paxton Hamill"
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "eos",
    "Hidden": false,
    "FullName": "Kennedi Prohaska"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 806,
    "Name": "Douglas-Stracke",
    "ToolTip": "Sed optio non quibusdam quisquam quia deserunt.",
    "Deleted": false,
    "Rank": 518,
    "Type": "quo",
    "ColorBlock": 711,
    "IconHint": "suscipit",
    "Selected": false,
    "LastChanged": "2009-06-15T10:18:00.926237+02:00",
    "ChildItems": [
      {
        "Id": 811,
        "Name": "Mohr-Waters",
        "ToolTip": "Architecto distinctio libero.",
        "Deleted": false,
        "Rank": 614,
        "Type": "vitae",
        "ColorBlock": 273,
        "IconHint": "dolores",
        "Selected": true,
        "LastChanged": "2017-11-03T10:18:00.926237+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "rerum",
        "StyleHint": "saepe",
        "Hidden": true,
        "FullName": "Carmen Nolan",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 256
          }
        }
      }
    ],
    "ExtraInfo": "consequuntur",
    "StyleHint": "iste",
    "Hidden": false,
    "FullName": "Ms. Rocky Immanuel Heller IV",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 22
      }
    }
  }
]
```