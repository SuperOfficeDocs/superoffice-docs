---
title: PUT List/ProductFamily/Items/{id}/Headings
uid: v1ProductFamilyList_PutProductFamilyHeadingsForListItem
generated: true
---

# PUT List/ProductFamily/Items/{id}/Headings

```http
PUT /api/v1/List/ProductFamily/Items/{itemId}/Headings
```

Saves headings for the ProductFamily list's item.


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
PUT /api/v1/List/ProductFamily/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 754,
    "Name": "Tromp, Weissnat and Hickle",
    "ToolTip": "Sint corporis modi consequatur est non qui.",
    "Deleted": true,
    "Rank": 637,
    "Type": "sit",
    "ColorBlock": 380,
    "IconHint": "dolores",
    "Selected": true,
    "LastChanged": "2006-02-03T12:19:54.7114903+01:00",
    "ChildItems": [
      {
        "Id": 789,
        "Name": "Pagac-Keebler",
        "ToolTip": "Est rerum ipsam est voluptas dolorem est provident.",
        "Deleted": true,
        "Rank": 36,
        "Type": "aut",
        "ColorBlock": 136,
        "IconHint": "qui",
        "Selected": false,
        "LastChanged": "2017-03-28T12:19:54.7114903+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "vero",
        "StyleHint": "necessitatibus",
        "Hidden": false,
        "FullName": "Alejandrin Johns"
      }
    ],
    "ExtraInfo": "nesciunt",
    "StyleHint": "nulla",
    "Hidden": false,
    "FullName": "Kenyatta Altenwerth"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 285,
    "Name": "Herman-Renner",
    "ToolTip": "Enim ut ab nobis.",
    "Deleted": false,
    "Rank": 952,
    "Type": "est",
    "ColorBlock": 459,
    "IconHint": "est",
    "Selected": false,
    "LastChanged": "2008-03-22T12:19:54.7114903+01:00",
    "ChildItems": [
      {
        "Id": 283,
        "Name": "Nolan Group",
        "ToolTip": "Aliquid quod aut.",
        "Deleted": true,
        "Rank": 68,
        "Type": "doloribus",
        "ColorBlock": 66,
        "IconHint": "magnam",
        "Selected": false,
        "LastChanged": "2021-11-24T12:19:54.7114903+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ut",
        "StyleHint": "quia",
        "Hidden": false,
        "FullName": "Miss Keanu Aron Klocko",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 223
          }
        }
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "enim",
    "Hidden": false,
    "FullName": "Dr. Dino Harris",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 289
      }
    }
  }
]
```