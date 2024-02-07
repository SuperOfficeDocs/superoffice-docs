---
title: PUT List/ConsentPurpose/Items/{id}/Headings
uid: v1ConsentPurposeList_PutConsentPurposeHeadingsForListItem
generated: true
---

# PUT List/ConsentPurpose/Items/{id}/Headings

```http
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/Headings
```

Saves headings for the ConsentPurpose list's item.


Calls the List agent service SaveHeadingsForListItemFromListDefinition.





| Path Part | Type | Description |
|-----------|------|-------------|
| itemId | int32 | The ID of the headings to be saved. **Required** |



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
PUT /api/v1/List/ConsentPurpose/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 782,
    "Name": "Senger LLC",
    "ToolTip": "Et numquam molestias consequatur sunt.",
    "Deleted": true,
    "Rank": 653,
    "Type": "temporibus",
    "ColorBlock": 250,
    "IconHint": "ullam",
    "Selected": false,
    "LastChanged": "1997-03-07T16:55:30.5797906+01:00",
    "ChildItems": [
      {
        "Id": 655,
        "Name": "Bergnaum Group",
        "ToolTip": "Ea adipisci est ab et odit deserunt sed.",
        "Deleted": false,
        "Rank": 801,
        "Type": "assumenda",
        "ColorBlock": 525,
        "IconHint": "necessitatibus",
        "Selected": false,
        "LastChanged": "2023-08-18T16:55:30.5797906+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "ipsam",
        "StyleHint": "est",
        "Hidden": false,
        "FullName": "Mrs. Mariano Runte"
      }
    ],
    "ExtraInfo": "doloremque",
    "StyleHint": "consequatur",
    "Hidden": false,
    "FullName": "Wilhelm Howe MD"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 433,
    "Name": "Parker, Frami and O'Kon",
    "ToolTip": "Eveniet hic quia iure eos rerum totam officia.",
    "Deleted": false,
    "Rank": 459,
    "Type": "enim",
    "ColorBlock": 414,
    "IconHint": "voluptates",
    "Selected": false,
    "LastChanged": "2014-12-15T16:55:30.5808026+01:00",
    "ChildItems": [
      {
        "Id": 898,
        "Name": "Schoen Inc and Sons",
        "ToolTip": "Aperiam animi debitis est minus totam itaque aut.",
        "Deleted": true,
        "Rank": 444,
        "Type": "et",
        "ColorBlock": 338,
        "IconHint": "et",
        "Selected": false,
        "LastChanged": "2023-03-31T16:55:30.5817941+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "molestiae",
        "StyleHint": "provident",
        "Hidden": true,
        "FullName": "Prof. Gwen Cartwright MD",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 723
          }
        }
      }
    ],
    "ExtraInfo": "et",
    "StyleHint": "qui",
    "Hidden": false,
    "FullName": "Shannon Della Hoppe III",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.String",
        "FieldLength": 900
      }
    }
  }
]
```