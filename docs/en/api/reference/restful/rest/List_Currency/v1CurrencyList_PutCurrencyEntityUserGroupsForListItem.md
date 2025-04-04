---
title: PUT List/Currency/Items/{id}/UserGroups
uid: v1CurrencyList_PutCurrencyEntityUserGroupsForListItem
generated: true
---

# PUT List/Currency/Items/{id}/UserGroups

```http
PUT /api/v1/List/Currency/Items/{itemId}/UserGroups
```

Saves user groups visible for the CurrencyEntity list's item.


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
PUT /api/v1/List/Currency/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 282,
    "Name": "Hackett-Strosin",
    "ToolTip": "Omnis nemo neque eos.",
    "Deleted": false,
    "Rank": 147,
    "Type": "nam",
    "ColorBlock": 223,
    "IconHint": "eos",
    "Selected": true,
    "LastChanged": "2002-02-09T13:14:09.7285208+01:00",
    "ChildItems": [
      {
        "Id": 393,
        "Name": "Goldner-Hettinger",
        "ToolTip": "Animi commodi non aut accusamus iure dolor.",
        "Deleted": false,
        "Rank": 827,
        "Type": "molestiae",
        "ColorBlock": 87,
        "IconHint": "sint",
        "Selected": true,
        "LastChanged": "2001-06-01T13:14:09.7285208+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "voluptatibus",
        "StyleHint": "nisi",
        "Hidden": false,
        "FullName": "Miss Alessia Jarred Anderson"
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "quibusdam",
    "Hidden": true,
    "FullName": "Pauline Robbie Glover DDS"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 364,
    "Name": "Gleason, Yundt and West",
    "ToolTip": "Voluptates nam facere laborum nostrum.",
    "Deleted": false,
    "Rank": 697,
    "Type": "occaecati",
    "ColorBlock": 769,
    "IconHint": "repudiandae",
    "Selected": true,
    "LastChanged": "2006-03-27T13:14:09.7285208+02:00",
    "ChildItems": [
      {
        "Id": 202,
        "Name": "Homenick, Hickle and Marquardt",
        "ToolTip": "Qui sunt fugit quo ipsum iste.",
        "Deleted": true,
        "Rank": 754,
        "Type": "beatae",
        "ColorBlock": 324,
        "IconHint": "ut",
        "Selected": false,
        "LastChanged": "2013-04-17T13:14:09.7285208+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "eos",
        "StyleHint": "reiciendis",
        "Hidden": true,
        "FullName": "Eleazar Lubowitz",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 902
          }
        }
      }
    ],
    "ExtraInfo": "eum",
    "StyleHint": "voluptas",
    "Hidden": false,
    "FullName": "Earlene Keeling",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 551
      }
    }
  }
]
```