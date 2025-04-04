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
    "Id": 619,
    "Name": "Harris Group",
    "ToolTip": "Ab sunt quis delectus.",
    "Deleted": false,
    "Rank": 212,
    "Type": "velit",
    "ColorBlock": 701,
    "IconHint": "eius",
    "Selected": false,
    "LastChanged": "2002-03-04T13:14:09.7128949+01:00",
    "ChildItems": [
      {
        "Id": 299,
        "Name": "O'Connell-Nitzsche",
        "ToolTip": "Velit nam nam.",
        "Deleted": true,
        "Rank": 339,
        "Type": "nam",
        "ColorBlock": 974,
        "IconHint": "unde",
        "Selected": false,
        "LastChanged": "2006-06-02T13:14:09.7128949+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nemo",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Lizeth Waelchi"
      }
    ],
    "ExtraInfo": "dolores",
    "StyleHint": "qui",
    "Hidden": false,
    "FullName": "Jettie Ritchie"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 271,
    "Name": "Stiedemann-Dach",
    "ToolTip": "Repudiandae suscipit nam ab assumenda.",
    "Deleted": false,
    "Rank": 818,
    "Type": "ducimus",
    "ColorBlock": 85,
    "IconHint": "placeat",
    "Selected": false,
    "LastChanged": "2010-07-26T13:14:09.7128949+02:00",
    "ChildItems": [
      {
        "Id": 501,
        "Name": "Kemmer Group",
        "ToolTip": "Maiores culpa voluptas maiores et minus voluptas.",
        "Deleted": false,
        "Rank": 74,
        "Type": "autem",
        "ColorBlock": 639,
        "IconHint": "adipisci",
        "Selected": false,
        "LastChanged": "2010-04-19T13:14:09.7128949+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolorem",
        "StyleHint": "consequatur",
        "Hidden": true,
        "FullName": "Mrs. Daren Cremin III",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 117
          }
        }
      }
    ],
    "ExtraInfo": "id",
    "StyleHint": "est",
    "Hidden": true,
    "FullName": "Leif Ullrich MD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 598
      }
    }
  }
]
```