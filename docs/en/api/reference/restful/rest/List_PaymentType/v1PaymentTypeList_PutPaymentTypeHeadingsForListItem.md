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
    "Id": 594,
    "Name": "Ernser, Quitzon and Mueller",
    "ToolTip": "Consequatur dolore incidunt ut consectetur.",
    "Deleted": false,
    "Rank": 826,
    "Type": "dolores",
    "ColorBlock": 573,
    "IconHint": "facere",
    "Selected": false,
    "LastChanged": "2015-10-12T12:57:43.5426609+02:00",
    "ChildItems": [
      {
        "Id": 530,
        "Name": "Lehner, Bayer and Leannon",
        "ToolTip": "Explicabo cumque eos quod distinctio atque voluptas.",
        "Deleted": false,
        "Rank": 772,
        "Type": "tempore",
        "ColorBlock": 357,
        "IconHint": "tenetur",
        "Selected": false,
        "LastChanged": "2012-03-30T12:57:43.5426609+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "delectus",
        "StyleHint": "dolore",
        "Hidden": false,
        "FullName": "Ms. Dixie Simone Nitzsche"
      }
    ],
    "ExtraInfo": "odio",
    "StyleHint": "sunt",
    "Hidden": false,
    "FullName": "Matilda Dach"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 112,
    "Name": "Schoen, Corwin and West",
    "ToolTip": "Provident beatae praesentium.",
    "Deleted": false,
    "Rank": 227,
    "Type": "enim",
    "ColorBlock": 526,
    "IconHint": "fuga",
    "Selected": true,
    "LastChanged": "2012-05-13T12:57:43.5426609+02:00",
    "ChildItems": [
      {
        "Id": 576,
        "Name": "Rohan-Ondricka",
        "ToolTip": "Commodi repellendus voluptas distinctio est.",
        "Deleted": true,
        "Rank": 773,
        "Type": "quidem",
        "ColorBlock": 516,
        "IconHint": "natus",
        "Selected": true,
        "LastChanged": "2010-10-24T12:57:43.5426609+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "modi",
        "StyleHint": "aut",
        "Hidden": true,
        "FullName": "Natalie Schiller",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.Int32",
            "FieldLength": 589
          }
        }
      }
    ],
    "ExtraInfo": "qui",
    "StyleHint": "illum",
    "Hidden": false,
    "FullName": "Mr. Jany Dereck Kohler",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 235
      }
    }
  }
]
```