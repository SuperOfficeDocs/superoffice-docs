---
title: PUT List/PaymentType/Items/{id}/Headings
uid: v1PaymentTypeList_PutPaymentTypeHeadingsForListItem
generated: true
---

# PUT List/PaymentType/Items/{id}/Headings

```http
PUT /api/v1/List/PaymentType/Items/{itemId}/Headings
```

Saves headings for the PaymentType list's item.


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
PUT /api/v1/List/PaymentType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 63,
    "Name": "Morissette-Armstrong",
    "ToolTip": "Itaque nihil rerum repellat qui natus.",
    "Deleted": false,
    "Rank": 399,
    "Type": "odit",
    "ColorBlock": 179,
    "IconHint": "repellat",
    "Selected": false,
    "LastChanged": "2007-01-15T14:13:50.0406714+01:00",
    "ChildItems": [
      {
        "Id": 337,
        "Name": "Walker LLC",
        "ToolTip": "Reprehenderit velit in voluptatum ea optio ipsum ut.",
        "Deleted": false,
        "Rank": 283,
        "Type": "blanditiis",
        "ColorBlock": 839,
        "IconHint": "maxime",
        "Selected": false,
        "LastChanged": "2016-09-15T14:13:50.0406714+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "accusamus",
        "StyleHint": "inventore",
        "Hidden": false,
        "FullName": "Elza Leuschke"
      }
    ],
    "ExtraInfo": "eos",
    "StyleHint": "enim",
    "Hidden": false,
    "FullName": "Ms. Bianka Bergstrom"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 613,
    "Name": "Beer Group",
    "ToolTip": "Sed accusamus quo.",
    "Deleted": true,
    "Rank": 513,
    "Type": "modi",
    "ColorBlock": 568,
    "IconHint": "harum",
    "Selected": false,
    "LastChanged": "2020-04-24T14:13:50.0406714+02:00",
    "ChildItems": [
      {
        "Id": 172,
        "Name": "Stamm Group",
        "ToolTip": "Deserunt ipsa similique.",
        "Deleted": false,
        "Rank": 277,
        "Type": "est",
        "ColorBlock": 23,
        "IconHint": "porro",
        "Selected": false,
        "LastChanged": "2002-08-31T14:13:50.0406714+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "maxime",
        "StyleHint": "voluptatem",
        "Hidden": false,
        "FullName": "Adell Towne",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 402
          }
        }
      }
    ],
    "ExtraInfo": "doloremque",
    "StyleHint": "earum",
    "Hidden": false,
    "FullName": "Levi Wilkinson",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 12
      }
    }
  }
]
```