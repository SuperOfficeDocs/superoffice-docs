---
title: PUT List/PaymentTerm/Items/{id}/UserGroups
uid: v1PaymentTermsList_PutPaymentTermUserGroupsForListItem
generated: true
content_type: reference
---

# PUT List/PaymentTerm/Items/{id}/UserGroups

```http
PUT /api/v1/List/PaymentTerm/Items/{itemId}/UserGroups
```

Saves user groups visible for the PaymentTerm list's item.


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
PUT /api/v1/List/PaymentTerm/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 620,
    "Name": "Rohan, Ryan and Collins",
    "ToolTip": "Autem consequatur.",
    "Deleted": false,
    "Rank": 644,
    "Type": "voluptate",
    "ColorBlock": 226,
    "IconHint": "sunt",
    "Selected": false,
    "LastChanged": "2017-12-08T03:41:59.4336101+01:00",
    "ChildItems": [
      {
        "Id": 102,
        "Name": "Hills, Koepp and Eichmann",
        "ToolTip": "Non sint quam.",
        "Deleted": true,
        "Rank": 78,
        "Type": "qui",
        "ColorBlock": 796,
        "IconHint": "veniam",
        "Selected": false,
        "LastChanged": "2019-05-22T03:41:59.4336101+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sapiente",
        "StyleHint": "ut",
        "Hidden": false,
        "FullName": "Jailyn Walker"
      }
    ],
    "ExtraInfo": "dignissimos",
    "StyleHint": "eius",
    "Hidden": true,
    "FullName": "Dr. Monique Smith"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 755,
    "Name": "Champlin-Olson",
    "ToolTip": "Sint corrupti esse beatae dolores nisi ea fugiat.",
    "Deleted": false,
    "Rank": 769,
    "Type": "quia",
    "ColorBlock": 368,
    "IconHint": "necessitatibus",
    "Selected": true,
    "LastChanged": "2019-06-16T03:41:59.4336101+02:00",
    "ChildItems": [
      {
        "Id": 848,
        "Name": "Daugherty-Gorczany",
        "ToolTip": "Accusamus aut beatae facere ipsa consequatur at et.",
        "Deleted": true,
        "Rank": 35,
        "Type": "voluptas",
        "ColorBlock": 324,
        "IconHint": "est",
        "Selected": false,
        "LastChanged": "2019-08-17T03:41:59.4336101+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "nostrum",
        "StyleHint": "nam",
        "Hidden": false,
        "FullName": "Maximillia Lakin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 978
          }
        }
      }
    ],
    "ExtraInfo": "adipisci",
    "StyleHint": "recusandae",
    "Hidden": true,
    "FullName": "Immanuel Dorthy Fahey V",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 367
      }
    }
  }
]
```