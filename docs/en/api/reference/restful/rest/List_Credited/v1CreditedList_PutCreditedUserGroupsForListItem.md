---
title: PUT List/Credited/Items/{id}/UserGroups
uid: v1CreditedList_PutCreditedUserGroupsForListItem
generated: true
---

# PUT List/Credited/Items/{id}/UserGroups

```http
PUT /api/v1/List/Credited/Items/{itemId}/UserGroups
```

Saves user groups visible for the Credited list's item.


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
PUT /api/v1/List/Credited/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 311,
    "Name": "Nader-Cummings",
    "ToolTip": "Eaque ea omnis architecto rerum.",
    "Deleted": false,
    "Rank": 722,
    "Type": "fugiat",
    "ColorBlock": 880,
    "IconHint": "optio",
    "Selected": false,
    "LastChanged": "2018-11-20T23:04:05.4074994+01:00",
    "ChildItems": [
      {
        "Id": 867,
        "Name": "Flatley Group",
        "ToolTip": "Recusandae rerum.",
        "Deleted": true,
        "Rank": 64,
        "Type": "sequi",
        "ColorBlock": 717,
        "IconHint": "nostrum",
        "Selected": true,
        "LastChanged": "2005-11-27T23:04:05.4074994+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "earum",
        "StyleHint": "maxime",
        "Hidden": false,
        "FullName": "Angela Bailey II"
      }
    ],
    "ExtraInfo": "quod",
    "StyleHint": "ipsam",
    "Hidden": false,
    "FullName": "Ms. Forrest Benton Harvey I"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 415,
    "Name": "O'Kon, Wiza and Brekke",
    "ToolTip": "Doloremque dolores architecto ipsa autem.",
    "Deleted": false,
    "Rank": 366,
    "Type": "dolores",
    "ColorBlock": 836,
    "IconHint": "est",
    "Selected": false,
    "LastChanged": "2010-12-20T23:04:05.4100004+01:00",
    "ChildItems": [
      {
        "Id": 781,
        "Name": "Cole LLC",
        "ToolTip": "Et ut.",
        "Deleted": false,
        "Rank": 384,
        "Type": "eos",
        "ColorBlock": 587,
        "IconHint": "dolorem",
        "Selected": true,
        "LastChanged": "2021-10-23T23:04:05.4100004+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "similique",
        "StyleHint": "magnam",
        "Hidden": true,
        "FullName": "Miss Claud Wiegand",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 9
          }
        }
      }
    ],
    "ExtraInfo": "facilis",
    "StyleHint": "fugit",
    "Hidden": false,
    "FullName": "Laisha Beatty",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 867
      }
    }
  }
]
```