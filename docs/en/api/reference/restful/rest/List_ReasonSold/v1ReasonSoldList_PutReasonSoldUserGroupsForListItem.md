---
title: PUT List/ReasonSold/Items/{id}/UserGroups
uid: v1ReasonSoldList_PutReasonSoldUserGroupsForListItem
generated: true
---

# PUT List/ReasonSold/Items/{id}/UserGroups

```http
PUT /api/v1/List/ReasonSold/Items/{itemId}/UserGroups
```

Saves user groups visible for the ReasonSold list's item.


Calls the List agent service SaveHeadingsForListItemFromListDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the item to save. **Required** |



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
PUT /api/v1/List/ReasonSold/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 867,
    "Name": "Lubowitz LLC",
    "ToolTip": "At quia et odio veritatis.",
    "Deleted": false,
    "Rank": 758,
    "Type": "harum",
    "ColorBlock": 992,
    "IconHint": "eum",
    "Selected": true,
    "LastChanged": "2012-12-08T23:04:05.7634964+01:00",
    "ChildItems": [
      {
        "Id": 314,
        "Name": "Kuphal-VonRueden",
        "ToolTip": "Expedita saepe et omnis est.",
        "Deleted": true,
        "Rank": 769,
        "Type": "harum",
        "ColorBlock": 583,
        "IconHint": "quibusdam",
        "Selected": false,
        "LastChanged": "2021-11-06T23:04:05.7634964+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "unde",
        "StyleHint": "repudiandae",
        "Hidden": true,
        "FullName": "Patsy Christiansen"
      }
    ],
    "ExtraInfo": "rerum",
    "StyleHint": "sint",
    "Hidden": false,
    "FullName": "Linwood Quitzon"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 435,
    "Name": "Johns, Miller and Jenkins",
    "ToolTip": "Aut laboriosam at.",
    "Deleted": false,
    "Rank": 92,
    "Type": "est",
    "ColorBlock": 532,
    "IconHint": "ea",
    "Selected": false,
    "LastChanged": "1998-04-24T23:04:05.7644957+02:00",
    "ChildItems": [
      {
        "Id": 170,
        "Name": "Stamm Inc and Sons",
        "ToolTip": "Deleniti quia fuga accusantium explicabo eos voluptatem.",
        "Deleted": false,
        "Rank": 761,
        "Type": "illo",
        "ColorBlock": 58,
        "IconHint": "cumque",
        "Selected": false,
        "LastChanged": "1999-08-23T23:04:05.7649976+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "laudantium",
        "StyleHint": "eum",
        "Hidden": false,
        "FullName": "Immanuel Wiza",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 566
          }
        }
      }
    ],
    "ExtraInfo": "est",
    "StyleHint": "laborum",
    "Hidden": false,
    "FullName": "Dr. Lexie Ryan IV",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 760
      }
    }
  }
]
```