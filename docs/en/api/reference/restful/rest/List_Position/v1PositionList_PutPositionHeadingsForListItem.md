---
title: PUT List/Position/Items/{id}/Headings
uid: v1PositionList_PutPositionHeadingsForListItem
---

# PUT List/Position/Items/{id}/Headings

```http
PUT /api/v1/List/Position/Items/{itemId}/Headings
```

Saves headings for the Position list's item.


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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/Position/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 227,
    "Name": "Luettgen Group",
    "ToolTip": "Unde nihil et ratione quos asperiores.",
    "Deleted": false,
    "Rank": 809,
    "Type": "reiciendis",
    "ColorBlock": 40,
    "IconHint": "dolor",
    "Selected": false,
    "LastChanged": "2010-09-24T12:15:28.2476166+02:00",
    "ChildItems": [
      {
        "Id": 426,
        "Name": "Abernathy, Armstrong and Lakin",
        "ToolTip": "Tenetur fugit labore et incidunt molestiae placeat.",
        "Deleted": true,
        "Rank": 824,
        "Type": "quo",
        "ColorBlock": 390,
        "IconHint": "voluptatem",
        "Selected": false,
        "LastChanged": "1999-05-13T12:15:28.2476166+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "possimus",
        "StyleHint": "qui",
        "Hidden": true,
        "FullName": "Mr. Joanny Lang"
      }
    ],
    "ExtraInfo": "eum",
    "StyleHint": "tempore",
    "Hidden": true,
    "FullName": "Kaelyn Bradtke"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 443,
    "Name": "Emard Inc and Sons",
    "ToolTip": "Quod nihil suscipit sit ea accusamus quis est.",
    "Deleted": false,
    "Rank": 374,
    "Type": "eos",
    "ColorBlock": 880,
    "IconHint": "enim",
    "Selected": false,
    "LastChanged": "2009-04-11T12:15:28.249617+02:00",
    "ChildItems": [
      {
        "Id": 84,
        "Name": "Bartoletti, O'Hara and McCullough",
        "ToolTip": "Facilis optio occaecati et hic.",
        "Deleted": false,
        "Rank": 973,
        "Type": "qui",
        "ColorBlock": 702,
        "IconHint": "ut",
        "Selected": true,
        "LastChanged": "2009-05-22T12:15:28.249617+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "tempora",
        "StyleHint": "sit",
        "Hidden": true,
        "FullName": "Kris Lang",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 906
          }
        }
      }
    ],
    "ExtraInfo": "minima",
    "StyleHint": "sed",
    "Hidden": false,
    "FullName": "Shea Rohan",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 257
      }
    }
  }
]
```