---
title: PUT List/{udListDefinitionName}/Items/{id}/Headings
id: v1ListItemEntity_SaveHeadingsForListItemFromListName
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


## Response: array



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample Request

```http!
PUT /api/v1/List/{udListDefinitionName}/Items/{listItemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 173,
    "Name": "Rohan, Kertzmann and Bednar",
    "ToolTip": "Fuga consectetur occaecati cupiditate minus debitis necessitatibus.",
    "Deleted": true,
    "Rank": 194,
    "Type": "alias",
    "ColorBlock": 250,
    "IconHint": "nam",
    "Selected": true,
    "LastChanged": "2011-11-11T09:41:00.1433617+01:00",
    "ChildItems": [
      {
        "Id": 633,
        "Name": "Gorczany Inc and Sons",
        "ToolTip": "Facere voluptatem libero eum consectetur maiores accusantium.",
        "Deleted": false,
        "Rank": 975,
        "Type": "fugiat",
        "ColorBlock": 418,
        "IconHint": "sequi",
        "Selected": true,
        "LastChanged": "2004-06-29T09:41:00.1433617+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "totam",
        "StyleHint": "magnam",
        "Hidden": false,
        "FullName": "Lia Hilpert"
      }
    ],
    "ExtraInfo": "nulla",
    "StyleHint": "voluptatem",
    "Hidden": false,
    "FullName": "Marisa Cruickshank PhD"
  }
]
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 721,
    "Name": "Funk, Mertz and Corwin",
    "ToolTip": "Quaerat explicabo provident.",
    "Deleted": true,
    "Rank": 503,
    "Type": "possimus",
    "ColorBlock": 812,
    "IconHint": "dolorem",
    "Selected": false,
    "LastChanged": "2014-05-27T09:41:00.1463613+02:00",
    "ChildItems": [
      {
        "Id": 275,
        "Name": "Ebert-Paucek",
        "ToolTip": "Distinctio qui tempora quia similique nihil.",
        "Deleted": false,
        "Rank": 75,
        "Type": "ut",
        "ColorBlock": 131,
        "IconHint": "velit",
        "Selected": false,
        "LastChanged": "2014-06-05T09:41:00.1463613+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "praesentium",
        "Hidden": true,
        "FullName": "Stephon Heathcote",
        "TableRight": {},
        "FieldProperties": {
          "fieldName": {
            "FieldRight": {
              "Mask": "FULL",
              "Reason": ""
            },
            "FieldType": "System.String",
            "FieldLength": 676
          }
        }
      }
    ],
    "ExtraInfo": "mollitia",
    "StyleHint": "eius",
    "Hidden": false,
    "FullName": "Dr. Larue Douglas",
    "TableRight": {
      "Mask": "Delete",
      "Reason": ""
    },
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 356
      }
    }
  }
]
```