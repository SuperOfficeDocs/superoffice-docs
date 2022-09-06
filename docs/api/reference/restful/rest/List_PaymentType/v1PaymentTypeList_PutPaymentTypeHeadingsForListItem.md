---
title: PUT List/PaymentType/Items/{id}/Headings
uid: v1PaymentTypeList_PutPaymentTypeHeadingsForListItem
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

## Response: array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: array

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
PUT /api/v1/List/PaymentType/Items/{itemId}/Headings
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 245,
    "Name": "McGlynn LLC",
    "ToolTip": "Placeat sapiente voluptatem.",
    "Deleted": false,
    "Rank": 283,
    "Type": "commodi",
    "ColorBlock": 587,
    "IconHint": "quia",
    "Selected": false,
    "LastChanged": "2006-12-02T11:10:54.3618993+01:00",
    "ChildItems": [
      {
        "Id": 882,
        "Name": "Thompson Group",
        "ToolTip": "Eum officia.",
        "Deleted": true,
        "Rank": 319,
        "Type": "dicta",
        "ColorBlock": 863,
        "IconHint": "est",
        "Selected": false,
        "LastChanged": "2021-03-20T11:10:54.3618993+01:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "sit",
        "StyleHint": "tempore",
        "Hidden": true,
        "FullName": "Reanna Schuppe"
      }
    ],
    "ExtraInfo": "sapiente",
    "StyleHint": "ut",
    "Hidden": false,
    "FullName": "Mckenna Flatley"
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Id": 76,
    "Name": "Stracke Group",
    "ToolTip": "Adipisci perferendis ut aut quaerat.",
    "Deleted": false,
    "Rank": 270,
    "Type": "nihil",
    "ColorBlock": 238,
    "IconHint": "sequi",
    "Selected": true,
    "LastChanged": "2011-12-06T11:10:54.3628992+01:00",
    "ChildItems": [
      {
        "Id": 756,
        "Name": "Lemke, Shields and Rowe",
        "ToolTip": "Nostrum cumque quia dolor excepturi omnis aliquid.",
        "Deleted": false,
        "Rank": 23,
        "Type": "et",
        "ColorBlock": 587,
        "IconHint": "similique",
        "Selected": false,
        "LastChanged": "1998-09-24T11:10:54.3638989+02:00",
        "ChildItems": [
          {},
          {}
        ],
        "ExtraInfo": "dolor",
        "StyleHint": "sed",
        "Hidden": false,
        "FullName": "Mariam Strosin",
        "TableRight": null,
        "FieldProperties": {
          "fieldName": {
            "FieldRight": null,
            "FieldType": "System.String",
            "FieldLength": 719
          }
        }
      }
    ],
    "ExtraInfo": "maiores",
    "StyleHint": "earum",
    "Hidden": false,
    "FullName": "Mr. Marlen Schiller",
    "TableRight": null,
    "FieldProperties": {
      "fieldName": {
        "FieldRight": null,
        "FieldType": "System.Int32",
        "FieldLength": 525
      }
    }
  }
]
```
