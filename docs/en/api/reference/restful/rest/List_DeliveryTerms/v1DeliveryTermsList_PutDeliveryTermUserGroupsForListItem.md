---
title: PUT List/DeliveryTerm/Items/{id}/UserGroups
uid: v1DeliveryTermsList_PutDeliveryTermUserGroupsForListItem
generated: true
---

# PUT List/DeliveryTerm/Items/{id}/UserGroups

```http
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/UserGroups
```

Saves user groups visible for the DeliveryTerm list's item.


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
PUT /api/v1/List/DeliveryTerm/Items/{itemId}/UserGroups
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 742,
    "Name": "Adams LLC",
    "ToolTip": "Atque maxime quo sunt at consectetur distinctio.",
    "Deleted": false,
    "Rank": 124,
    "Type": "recusandae",
    "ColorBlock": 392,
    "IconHint": "deleniti",
    "Selected": true,
    "LastChanged": "2005-12-01T04:22:35.9247166+01:00",
    "ChildItems": [
      {
        "Id": 24,
        "Name": "Goodwin, Lakin and Cole",
        "ToolTip": "Aut saepe.",
        "Deleted": false,
        "Rank": 137,
        "Type": "numquam",
        "ColorBlock": 726,
        "IconHint": "est",
        "Selected": true,
        "LastChanged": "2003-06-23T04:22:35.9247166+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "quasi",
        "StyleHint": "ratione",
        "Hidden": false,
        "FullName": "Mrs. Bertrand Spencer IV"
      }
    ],
    "ExtraInfo": "soluta",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Dr. Claudie Marcelina Zulauf III"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 463,
    "Name": "Wolf, Fritsch and Goldner",
    "ToolTip": "Quos aut optio qui molestiae delectus possimus maiores.",
    "Deleted": true,
    "Rank": 810,
    "Type": "cupiditate",
    "ColorBlock": 111,
    "IconHint": "et",
    "Selected": false,
    "LastChanged": "1998-05-02T04:22:35.9247166+02:00",
    "ChildItems": [
      {
        "Id": 923,
        "Name": "Zulauf Inc and Sons",
        "ToolTip": "Dignissimos in quibusdam totam minima.",
        "Deleted": false,
        "Rank": 370,
        "Type": "sed",
        "ColorBlock": 727,
        "IconHint": "explicabo",
        "Selected": false,
        "LastChanged": "2003-06-30T04:22:35.9247166+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "earum",
        "StyleHint": "earum",
        "Hidden": true,
        "FullName": "Prof. Ubaldo Orin Reinger",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 697
          }
        }
      }
    ],
    "ExtraInfo": "tempora",
    "StyleHint": "est",
    "Hidden": true,
    "FullName": "Mr. Ara Caleb Jewess Jr.",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 546
      }
    }
  }
]
```