---
title: GET Selection/{id}/Criteria
uid: v1SelectionEntity_GetDynamicSelectionCriteria
generated: true
---

# GET Selection/{id}/Criteria

```http
GET /api/v1/Selection/{selectionId}/Criteria
```

Get the criteria for this dynamic selection.






| Path Part | Type | Description |
|-----------|------|-------------|
| selectionId | int32 | The id of the selection to add members **Required** |



## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


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
GET /api/v1/Selection/{selectionId}/Criteria
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

[
  {
    "Name": "Brakus Group",
    "Operator": "debitis",
    "Values": [
      "asperiores",
      "sint"
    ],
    "DisplayValues": [
      "dolore",
      "dolore"
    ],
    "ColumnInfo": null,
    "IsActive": false,
    "SubRestrictions": [
      {
        "Name": "Nikolaus, Ward and Carroll",
        "Operator": "quo",
        "Values": [
          "autem",
          "quibusdam"
        ],
        "DisplayValues": [
          "et",
          "voluptate"
        ],
        "ColumnInfo": null,
        "IsActive": false,
        "SubRestrictions": [
          {},
          {}
        ],
        "InterParenthesis": 782,
        "InterOperator": "And",
        "UniqueHash": 275
      }
    ],
    "InterParenthesis": 426,
    "InterOperator": "And",
    "UniqueHash": 384
  }
]
```