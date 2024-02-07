---
title: PUT List/PaymentTerm/Items/{id}/Headings
uid: v1PaymentTermsList_PutPaymentTermHeadingsForListItem
generated: true
---

# PUT List/PaymentTerm/Items/{id}/Headings

```http
PUT /api/v1/List/PaymentTerm/Items/{itemId}/Headings
```

Saves headings for the PaymentTerm list's item.


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
PUT /api/v1/List/PaymentTerm/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 398,
    "Name": "Olson Group",
    "ToolTip": "Dolore facilis sapiente impedit esse.",
    "Deleted": false,
    "Rank": 897,
    "Type": "sunt",
    "ColorBlock": 468,
    "IconHint": "aut",
    "Selected": false,
    "LastChanged": "2003-10-13T16:55:30.7381718+02:00",
    "ChildItems": [
      {
        "Id": 843,
        "Name": "Bechtelar, Leuschke and Jacobi",
        "ToolTip": "Ut labore qui aut nihil non.",
        "Deleted": true,
        "Rank": 146,
        "Type": "maiores",
        "ColorBlock": 330,
        "IconHint": "officiis",
        "Selected": false,
        "LastChanged": "1998-04-08T16:55:30.7381718+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "distinctio",
        "StyleHint": "sit",
        "Hidden": true,
        "FullName": "Miss Carmen Idella Cremin DDS"
      }
    ],
    "ExtraInfo": "vel",
    "StyleHint": "ut",
    "Hidden": true,
    "FullName": "Cleo Moen"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 316,
    "Name": "McLaughlin-Bins",
    "ToolTip": "Animi officia mollitia eaque.",
    "Deleted": true,
    "Rank": 1000,
    "Type": "id",
    "ColorBlock": 858,
    "IconHint": "dicta",
    "Selected": false,
    "LastChanged": "2023-08-26T16:55:30.7411916+02:00",
    "ChildItems": [
      {
        "Id": 298,
        "Name": "Braun LLC",
        "ToolTip": "Quae commodi.",
        "Deleted": true,
        "Rank": 312,
        "Type": "tenetur",
        "ColorBlock": 888,
        "IconHint": "mollitia",
        "Selected": false,
        "LastChanged": "2017-04-16T16:55:30.7411916+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "iusto",
        "StyleHint": "ad",
        "Hidden": false,
        "FullName": "Eldridge Dickens",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 829
          }
        }
      }
    ],
    "ExtraInfo": "earum",
    "StyleHint": "rerum",
    "Hidden": false,
    "FullName": "Dr. Carmen Feeney",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 897
      }
    }
  }
]
```