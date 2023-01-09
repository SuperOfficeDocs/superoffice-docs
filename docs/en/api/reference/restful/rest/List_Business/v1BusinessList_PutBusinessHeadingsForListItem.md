---
title: PUT List/Business/Items/{id}/Headings
uid: v1BusinessList_PutBusinessHeadingsForListItem
---

# PUT List/Business/Items/{id}/Headings

```http
PUT /api/v1/List/Business/Items/{itemId}/Headings
```

Saves headings for the Business list's item.


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
PUT /api/v1/List/Business/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 896,
    "Name": "Monahan, Walker and Hamill",
    "ToolTip": "Qui voluptates rerum nesciunt sit et repellendus et.",
    "Deleted": false,
    "Rank": 694,
    "Type": "et",
    "ColorBlock": 975,
    "IconHint": "doloremque",
    "Selected": false,
    "LastChanged": "2022-12-30T17:37:39.6644005+01:00",
    "ChildItems": [
      {
        "Id": 439,
        "Name": "Stokes LLC",
        "ToolTip": "Impedit eaque maxime rerum libero quas et eius.",
        "Deleted": false,
        "Rank": 199,
        "Type": "veritatis",
        "ColorBlock": 806,
        "IconHint": "sint",
        "Selected": true,
        "LastChanged": "2001-05-02T17:37:39.6644005+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "optio",
        "StyleHint": "aut",
        "Hidden": false,
        "FullName": "Dr. Bill Joelle Koepp V"
      }
    ],
    "ExtraInfo": "sint",
    "StyleHint": "non",
    "Hidden": false,
    "FullName": "Mr. Anissa Hermann Wolf"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 892,
    "Name": "White-VonRueden",
    "ToolTip": "Nihil autem ratione vitae consequatur non omnis sapiente.",
    "Deleted": false,
    "Rank": 729,
    "Type": "distinctio",
    "ColorBlock": 387,
    "IconHint": "eum",
    "Selected": false,
    "LastChanged": "2001-05-23T17:37:39.666432+02:00",
    "ChildItems": [
      {
        "Id": 159,
        "Name": "Deckow, Stamm and Wolff",
        "ToolTip": "Quibusdam veniam id recusandae ducimus est nesciunt.",
        "Deleted": false,
        "Rank": 749,
        "Type": "deleniti",
        "ColorBlock": 673,
        "IconHint": "pariatur",
        "Selected": false,
        "LastChanged": "2011-12-09T17:37:39.666432+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "aut",
        "StyleHint": "enim",
        "Hidden": false,
        "FullName": "Orval Bernhard",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 726
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "est",
    "Hidden": false,
    "FullName": "Fannie Davis",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 145
      }
    }
  }
]
```