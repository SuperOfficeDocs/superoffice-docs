---
title: PUT List/ReasonSold/Items/{id}/UserGroups
uid: v1ReasonSoldList_PutReasonSoldUserGroupsForListItem
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/ReasonSold/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 849,
    "Name": "O'Connell Group",
    "ToolTip": "Doloremque optio ut unde.",
    "Deleted": false,
    "Rank": 724,
    "Type": "officiis",
    "ColorBlock": 404,
    "IconHint": "expedita",
    "Selected": false,
    "LastChanged": "2016-07-24T12:15:28.4366175+02:00",
    "ChildItems": [
      {
        "Id": 179,
        "Name": "Franecki-Wilkinson",
        "ToolTip": "Earum modi ut voluptas est.",
        "Deleted": false,
        "Rank": 238,
        "Type": "sapiente",
        "ColorBlock": 943,
        "IconHint": "numquam",
        "Selected": true,
        "LastChanged": "2013-01-13T12:15:28.4366175+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quaerat",
        "StyleHint": "iste",
        "Hidden": false,
        "FullName": "Camylle Goldner"
      }
    ],
    "ExtraInfo": "libero",
    "StyleHint": "vero",
    "Hidden": false,
    "FullName": "Tracy Crona"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 275,
    "Name": "Murray-Hermann",
    "ToolTip": "Excepturi sint sapiente magni adipisci est laudantium vel.",
    "Deleted": false,
    "Rank": 892,
    "Type": "sequi",
    "ColorBlock": 669,
    "IconHint": "omnis",
    "Selected": false,
    "LastChanged": "1999-01-20T12:15:28.4376144+01:00",
    "ChildItems": [
      {
        "Id": 898,
        "Name": "Lehner-Hahn",
        "ToolTip": "Quidem aut maiores est enim cumque.",
        "Deleted": false,
        "Rank": 509,
        "Type": "nisi",
        "ColorBlock": 950,
        "IconHint": "sit",
        "Selected": false,
        "LastChanged": "1999-06-19T12:15:28.4376144+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "necessitatibus",
        "StyleHint": "quia",
        "Hidden": true,
        "FullName": "Rylee Ethel Predovic MD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 541
          }
        }
      }
    ],
    "ExtraInfo": "nobis",
    "StyleHint": "libero",
    "Hidden": false,
    "FullName": "Ms. Anastacio Samara Howe",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 535
      }
    }
  }
]
```