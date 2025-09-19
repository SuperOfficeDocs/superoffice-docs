---
title: PUT List/Credited/Items/{id}/UserGroups
uid: v1CreditedList_PutCreditedUserGroupsForListItem
generated: true
content_type: reference
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
    "Id": 158,
    "Name": "Kautzer-Stamm",
    "ToolTip": "Quibusdam harum facilis eos corporis quibusdam in.",
    "Deleted": false,
    "Rank": 587,
    "Type": "aut",
    "ColorBlock": 973,
    "IconHint": "autem",
    "Selected": true,
    "LastChanged": "2007-11-14T03:41:59.3867375+01:00",
    "ChildItems": [
      {
        "Id": 39,
        "Name": "Rippin-Murphy",
        "ToolTip": "Fugiat libero sint porro autem a.",
        "Deleted": true,
        "Rank": 849,
        "Type": "vel",
        "ColorBlock": 397,
        "IconHint": "eius",
        "Selected": false,
        "LastChanged": "2017-05-14T03:41:59.3867375+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "fugit",
        "StyleHint": "vitae",
        "Hidden": false,
        "FullName": "Brianne Bosco"
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "id",
    "Hidden": true,
    "FullName": "Dr. Garland Myles Yundt V"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 683,
    "Name": "Moore, Steuber and Pfannerstill",
    "ToolTip": "Sunt et ea officia voluptas dolor dicta praesentium.",
    "Deleted": false,
    "Rank": 627,
    "Type": "sit",
    "ColorBlock": 21,
    "IconHint": "et",
    "Selected": true,
    "LastChanged": "2008-04-24T03:41:59.3867375+02:00",
    "ChildItems": [
      {
        "Id": 675,
        "Name": "Morar-Schuppe",
        "ToolTip": "Ut quaerat consequuntur.",
        "Deleted": false,
        "Rank": 678,
        "Type": "maxime",
        "ColorBlock": 432,
        "IconHint": "quos",
        "Selected": false,
        "LastChanged": "2005-05-02T03:41:59.3867375+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "consequatur",
        "StyleHint": "et",
        "Hidden": false,
        "FullName": "Leonard Bernhard",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 169
          }
        }
      }
    ],
    "ExtraInfo": "aut",
    "StyleHint": "ad",
    "Hidden": false,
    "FullName": "Mrs. Vesta Labadie DVM",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 43
      }
    }
  }
]
```