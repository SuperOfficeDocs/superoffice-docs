---
title: PUT List/Category/Items/{id}/Headings
uid: v1CategoryList_PutCategoryHeadingsForListItem
generated: true
content_type: reference
---

# PUT List/Category/Items/{id}/Headings

```http
PUT /api/v1/List/Category/Items/{itemId}/Headings
```

Saves headings for the Category list's item.


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
PUT /api/v1/List/Category/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 823,
    "Name": "Feest Group",
    "ToolTip": "Est vel eius ut rem at nobis neque.",
    "Deleted": false,
    "Rank": 149,
    "Type": "quo",
    "ColorBlock": 163,
    "IconHint": "quo",
    "Selected": false,
    "LastChanged": "2008-05-04T11:24:53.8592973+02:00",
    "ChildItems": [
      {
        "Id": 651,
        "Name": "Kohler LLC",
        "ToolTip": "Aliquam sunt magni non.",
        "Deleted": true,
        "Rank": 516,
        "Type": "fugit",
        "ColorBlock": 60,
        "IconHint": "enim",
        "Selected": true,
        "LastChanged": "2019-01-28T11:24:53.8592973+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "at",
        "StyleHint": "optio",
        "Hidden": true,
        "FullName": "Johnny Durgan"
      }
    ],
    "ExtraInfo": "eum",
    "StyleHint": "explicabo",
    "Hidden": false,
    "FullName": "Arne Schulist"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 732,
    "Name": "Farrell-Brown",
    "ToolTip": "Voluptate debitis molestias velit nemo laborum.",
    "Deleted": false,
    "Rank": 930,
    "Type": "dolore",
    "ColorBlock": 45,
    "IconHint": "possimus",
    "Selected": false,
    "LastChanged": "1999-11-24T11:24:53.8749217+01:00",
    "ChildItems": [
      {
        "Id": 616,
        "Name": "Funk, Gislason and Waters",
        "ToolTip": "Consequuntur impedit rerum eum nisi et.",
        "Deleted": true,
        "Rank": 162,
        "Type": "ducimus",
        "ColorBlock": 233,
        "IconHint": "dolor",
        "Selected": false,
        "LastChanged": "2023-05-19T11:24:53.8749217+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Raleigh Langosh",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 578
          }
        }
      }
    ],
    "ExtraInfo": "ut",
    "StyleHint": "modi",
    "Hidden": true,
    "FullName": "Fiona Shields",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 783
      }
    }
  }
]
```