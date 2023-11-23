---
title: PUT Selection/{id}/Criteria
uid: v1SelectionEntity_SetDynamicSelectionCriteria3
generated: true
---

# PUT Selection/{id}/Criteria

```http
PUT /api/v1/Selection/{selectionId}/Criteria
```

Update the criteria for this dynamic selection.


Use criteria as either restriction objects or OData string format. Criteria are parsed from the OData filter form: ''name startswith 'foo' and category in (1,2,3)''





| Path Part | Type | Description |
|-----------|------|-------------|
| selectionId | int32 | The id of the selection to add members **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $filter | string |  Criteria defining the selection result in OData filter form: `category in (1,2,3) and name = 'foo'`. Pass NULL or empty string '' if using the criteria objects. |

```http
PUT /api/v1/Selection/{selectionId}/Criteria?$filter=name begins 'S'
```


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

## Request Body: criteria 

Criteria defining the selection result. Pass NULL if using the filter string instead. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | String | The programmatic column name, including any required prefixes |
| Operator | String | The operator, such as =, etc |
| Values | Array | Value(s) to test against |
| DisplayValues | Array | Display representation of value(s) - list ID's are decoded to display texts, other values are represented in a format suitable for decoding and display through the {SuperOffice.CRM.Globalization.CultureDataFormatter}. |
| ColumnInfo | ArchiveColumnInfo | Optional complete ArchiveColumnInfo for this restriction; in that case, ColumnInfo.Name == this.Name will always be true |
| IsActive | Boolean | Is this restriction active?  Inactive restrictions will not influence the generated query |
| SubRestrictions | Array | Optional collection of sub criteria, usually null but set for Saint counter fields |
| InterParenthesis | Integer | Get or set the parenthesis (if any) associated with this restriction. Positive values indicate a number of opening parentheses (deepening nesting level), while negative numbers indicate closing parentheses. Zero means no change in nesting level (no parentheses). |
| InterOperator | String | Get or set the inter-restriction operator that describes how this restriction is related to the next one in an array. Default for new ArchiveRestrictionInfo objects is And |
| UniqueHash | Integer |  |

## Response:array

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: array

| Property Name | Type |  Description |
|----------------|------|--------------|
| Name | string | The programmatic column name, including any required prefixes |
| Operator | string | The operator, such as =, etc |
| Values | array | Value(s) to test against |
| DisplayValues | array | Display representation of value(s) - list ID's are decoded to display texts, other values are represented in a format suitable for decoding and display through the {SuperOffice.CRM.Globalization.CultureDataFormatter}. |
| ColumnInfo | ArchiveColumnInfo | Optional complete ArchiveColumnInfo for this restriction; in that case, ColumnInfo.Name == this.Name will always be true |
| IsActive | bool | Is this restriction active?  Inactive restrictions will not influence the generated query |
| SubRestrictions | array | Optional collection of sub criteria, usually null but set for Saint counter fields |
| InterParenthesis | int32 | Get or set the parenthesis (if any) associated with this restriction. Positive values indicate a number of opening parentheses (deepening nesting level), while negative numbers indicate closing parentheses. Zero means no change in nesting level (no parentheses). |
| InterOperator | string | Get or set the inter-restriction operator that describes how this restriction is related to the next one in an array. Default for new ArchiveRestrictionInfo objects is And |
| UniqueHash | int32 |  |

## Sample request

```http!
PUT /api/v1/Selection/{selectionId}/Criteria
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Pouros Inc and Sons",
    "Operator": "ut",
    "Values": [
      "dolorum",
      "nulla"
    ],
    "DisplayValues": [
      "id",
      "consequatur"
    ],
    "ColumnInfo": null,
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Nicolas-Johns",
        "Operator": "perspiciatis",
        "Values": [
          "magni",
          "rerum"
        ],
        "DisplayValues": [
          "ipsum",
          "non"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 742,
        "InterOperator": "And",
        "UniqueHash": 634
      }
    ],
    "InterParenthesis": 419,
    "InterOperator": "And",
    "UniqueHash": 978
  }
]
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Dicki, Kuhn and Bashirian",
    "Operator": "quibusdam",
    "Values": [
      "voluptates",
      "facilis"
    ],
    "DisplayValues": [
      "sit",
      "rem"
    ],
    "ColumnInfo": null,
    "IsActive": true,
    "SubRestrictions": [
      {
        "Name": "Connelly Inc and Sons",
        "Operator": "reiciendis",
        "Values": [
          "rem",
          "ducimus"
        ],
        "DisplayValues": [
          "molestias",
          "eveniet"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 280,
        "InterOperator": "And",
        "UniqueHash": 253
      }
    ],
    "InterParenthesis": 605,
    "InterOperator": "And",
    "UniqueHash": 329
  }
]
```