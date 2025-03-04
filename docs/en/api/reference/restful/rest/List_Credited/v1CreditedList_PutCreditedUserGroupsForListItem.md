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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 319,
    "Name": "Boyle, Maggio and Hickle",
    "ToolTip": "Aut est natus qui perspiciatis.",
    "Deleted": false,
    "Rank": 548,
    "Type": "nihil",
    "ColorBlock": 283,
    "IconHint": "animi",
    "Selected": false,
    "LastChanged": "2024-09-02T14:13:49.7429847+02:00",
    "ChildItems": [
      {
        "Id": 713,
        "Name": "Mertz, Crona and Collier",
        "ToolTip": "Minus quisquam excepturi explicabo ad.",
        "Deleted": true,
        "Rank": 935,
        "Type": "quis",
        "ColorBlock": 138,
        "IconHint": "est",
        "Selected": false,
        "LastChanged": "2017-01-31T14:13:49.7429847+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "expedita",
        "StyleHint": "ad",
        "Hidden": false,
        "FullName": "Carlos Gibson"
      }
    ],
    "ExtraInfo": "totam",
    "StyleHint": "quibusdam",
    "Hidden": false,
    "FullName": "Cleora Earlene Vandervort IV"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 820,
    "Name": "Ritchie, Hahn and Waelchi",
    "ToolTip": "Nesciunt non ut vel unde quod ut.",
    "Deleted": false,
    "Rank": 548,
    "Type": "quos",
    "ColorBlock": 977,
    "IconHint": "mollitia",
    "Selected": true,
    "LastChanged": "1999-04-09T14:13:49.7586101+02:00",
    "ChildItems": [
      {
        "Id": 565,
        "Name": "Tillman-Gorczany",
        "ToolTip": "Qui corporis voluptatem ut consequuntur non.",
        "Deleted": false,
        "Rank": 92,
        "Type": "sint",
        "ColorBlock": 910,
        "IconHint": "quam",
        "Selected": false,
        "LastChanged": "2017-11-29T14:13:49.7586101+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sint",
        "StyleHint": "laudantium",
        "Hidden": false,
        "FullName": "Ms. Alejandrin Dane Kreiger",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 66
          }
        }
      }
    ],
    "ExtraInfo": "assumenda",
    "StyleHint": "nam",
    "Hidden": true,
    "FullName": "Alverta Schuster",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 251
      }
    }
  }
]
```