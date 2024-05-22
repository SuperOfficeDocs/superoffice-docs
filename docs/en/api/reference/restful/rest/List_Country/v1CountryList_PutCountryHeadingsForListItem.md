---
title: PUT List/Country/Items/{id}/Headings
uid: v1CountryList_PutCountryHeadingsForListItem
generated: true
---

# PUT List/Country/Items/{id}/Headings

```http
PUT /api/v1/List/Country/Items/{itemId}/Headings
```

Saves headings for the Country list's item.


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
PUT /api/v1/List/Country/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 798,
    "Name": "Harvey, Fritsch and Frami",
    "ToolTip": "Iusto id omnis.",
    "Deleted": false,
    "Rank": 844,
    "Type": "nesciunt",
    "ColorBlock": 689,
    "IconHint": "id",
    "Selected": false,
    "LastChanged": "2010-01-29T12:57:43.402068+01:00",
    "ChildItems": [
      {
        "Id": 612,
        "Name": "Zboncak LLC",
        "ToolTip": "Numquam cumque.",
        "Deleted": false,
        "Rank": 1001,
        "Type": "tempore",
        "ColorBlock": 661,
        "IconHint": "sunt",
        "Selected": true,
        "LastChanged": "2012-06-21T12:57:43.402068+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ipsam",
        "StyleHint": "deleniti",
        "Hidden": true,
        "FullName": "Mr. Anjali Jewess Jr."
      }
    ],
    "ExtraInfo": "tempora",
    "StyleHint": "officiis",
    "Hidden": false,
    "FullName": "Mr. Sylvester Jay Von V"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 977,
    "Name": "Bergnaum LLC",
    "ToolTip": "Omnis necessitatibus commodi dicta ducimus error.",
    "Deleted": false,
    "Rank": 209,
    "Type": "vero",
    "ColorBlock": 8,
    "IconHint": "ab",
    "Selected": false,
    "LastChanged": "2021-12-27T12:57:43.402068+01:00",
    "ChildItems": [
      {
        "Id": 677,
        "Name": "Herman-Mosciski",
        "ToolTip": "Sed sunt voluptatem voluptas aliquid facere.",
        "Deleted": true,
        "Rank": 256,
        "Type": "reiciendis",
        "ColorBlock": 181,
        "IconHint": "rem",
        "Selected": false,
        "LastChanged": "2002-01-21T12:57:43.402068+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "molestiae",
        "StyleHint": "rerum",
        "Hidden": false,
        "FullName": "Ms. Frank Brekke",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 743
          }
        }
      }
    ],
    "ExtraInfo": "dolor",
    "StyleHint": "eius",
    "Hidden": false,
    "FullName": "Jamison Larkin MD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 248
      }
    }
  }
]
```