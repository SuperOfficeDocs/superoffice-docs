---
title: PUT List/PaymentType/Items/{id}/UserGroups
uid: v1PaymentTypeList_PutPaymentTypeUserGroupsForListItem
---

# PUT List/PaymentType/Items/{id}/UserGroups

```http
PUT /api/v1/List/PaymentType/Items/{itemId}/UserGroups
```

Saves user groups visible for the PaymentType list's item.


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
PUT /api/v1/List/PaymentType/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 184,
    "Name": "Quitzon-Swift",
    "ToolTip": "Iusto omnis ullam in qui ratione.",
    "Deleted": true,
    "Rank": 155,
    "Type": "culpa",
    "ColorBlock": 288,
    "IconHint": "provident",
    "Selected": false,
    "LastChanged": "2006-03-10T12:15:28.227618+01:00",
    "ChildItems": [
      {
        "Id": 947,
        "Name": "Jakubowski Inc and Sons",
        "ToolTip": "Quia necessitatibus mollitia.",
        "Deleted": true,
        "Rank": 195,
        "Type": "libero",
        "ColorBlock": 414,
        "IconHint": "consequatur",
        "Selected": false,
        "LastChanged": "2023-01-14T12:15:28.227618+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "provident",
        "StyleHint": "et",
        "Hidden": true,
        "FullName": "Mrs. Wendy Morar III"
      }
    ],
    "ExtraInfo": "rerum",
    "StyleHint": "aut",
    "Hidden": true,
    "FullName": "Prof. Leann Louisa Lubowitz DVM"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 548,
    "Name": "Miller, Lubowitz and Douglas",
    "ToolTip": "Odit ut exercitationem debitis aut quo laborum.",
    "Deleted": true,
    "Rank": 424,
    "Type": "soluta",
    "ColorBlock": 457,
    "IconHint": "porro",
    "Selected": false,
    "LastChanged": "2014-04-24T12:15:28.2286168+02:00",
    "ChildItems": [
      {
        "Id": 222,
        "Name": "Reilly-Emard",
        "ToolTip": "Voluptate magnam.",
        "Deleted": true,
        "Rank": 86,
        "Type": "est",
        "ColorBlock": 616,
        "IconHint": "repellendus",
        "Selected": true,
        "LastChanged": "2015-08-15T12:15:28.2296174+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "repudiandae",
        "StyleHint": "corrupti",
        "Hidden": false,
        "FullName": "Ms. Aleen Jacobson",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 836
          }
        }
      }
    ],
    "ExtraInfo": "tenetur",
    "StyleHint": "molestiae",
    "Hidden": false,
    "FullName": "Rodrigo Hand PhD",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 342
      }
    }
  }
]
```