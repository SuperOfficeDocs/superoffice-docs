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
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 320,
    "Name": "Jacobi LLC",
    "ToolTip": "Qui esse quam mollitia tempore atque.",
    "Deleted": false,
    "Rank": 218,
    "Type": "voluptate",
    "ColorBlock": 547,
    "IconHint": "similique",
    "Selected": true,
    "LastChanged": "2008-10-27T12:57:43.4176894+01:00",
    "ChildItems": [
      {
        "Id": 169,
        "Name": "Boyer, Hackett and Labadie",
        "ToolTip": "Vitae aut sed expedita et sunt.",
        "Deleted": false,
        "Rank": 280,
        "Type": "accusamus",
        "ColorBlock": 69,
        "IconHint": "voluptate",
        "Selected": false,
        "LastChanged": "2021-11-01T12:57:43.4176894+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nam",
        "StyleHint": "voluptatem",
        "Hidden": false,
        "FullName": "Alize Daniel"
      }
    ],
    "ExtraInfo": "soluta",
    "StyleHint": "sint",
    "Hidden": false,
    "FullName": "Dr. Desmond Maggio V"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 650,
    "Name": "Klein, Kiehn and Feest",
    "ToolTip": "Eius omnis id incidunt.",
    "Deleted": false,
    "Rank": 563,
    "Type": "vel",
    "ColorBlock": 728,
    "IconHint": "quasi",
    "Selected": false,
    "LastChanged": "2000-04-30T12:57:43.4176894+02:00",
    "ChildItems": [
      {
        "Id": 244,
        "Name": "McDermott Inc and Sons",
        "ToolTip": "Quia ratione dicta.",
        "Deleted": true,
        "Rank": 365,
        "Type": "sapiente",
        "ColorBlock": 676,
        "IconHint": "aut",
        "Selected": false,
        "LastChanged": "2009-04-26T12:57:43.4176894+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sunt",
        "StyleHint": "illo",
        "Hidden": false,
        "FullName": "Larry Brown Sr.",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 535
          }
        }
      }
    ],
    "ExtraInfo": "ea",
    "StyleHint": "voluptatibus",
    "Hidden": false,
    "FullName": "Jon Lakin PhD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 116
      }
    }
  }
]
```