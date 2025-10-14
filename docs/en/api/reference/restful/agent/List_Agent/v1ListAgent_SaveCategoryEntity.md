---
title: POST Agents/List/SaveCategoryEntity
uid: v1ListAgent_SaveCategoryEntity
generated: true
content_type: reference
---

# POST Agents/List/SaveCategoryEntity

```http
POST /api/v1/Agents/List/SaveCategoryEntity
```

Updates the existing CategoryEntity or creates a new CategoryEntity if the id parameter is 0.


NsApiSlow threshold: 5000 ms.







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

## Request Body: categoryEntity 

The CategoryEntity that is saved 

| Property Name | Type |  Description |
|----------------|------|--------------|
| CategoryId | Integer | Primary key |
| Name | String | Name of the category |
| CategoryGroup | String | Enum of the group this category belongs to, static list of 5 groups |
| Tooltip | String | Tooltip of the category |
| Rank | Integer | Rank of the category |
| EnableLeadStatus | Boolean | True if the category should enable lead stage |
| CategoryFamilyId | Integer | Optional link to family, for grouping things like multiple kinds of customer category under family 'customer' |
| Deleted | Boolean | true if the country is deleted |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: CategoryEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| CategoryId | int32 | Primary key |
| Name | string | Name of the category |
| CategoryGroup | string | Enum of the group this category belongs to, static list of 5 groups |
| Tooltip | string | Tooltip of the category |
| Rank | int32 | Rank of the category |
| EnableLeadStatus | bool | True if the category should enable lead stage |
| CategoryFamilyId | int32 | Optional link to family, for grouping things like multiple kinds of customer category under family 'customer' |
| Deleted | bool | true if the country is deleted |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/List/SaveCategoryEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "CategoryId": 985,
  "Name": "Jones, Sanford and Flatley",
  "CategoryGroup": "Customer",
  "Tooltip": "qui",
  "Rank": 651,
  "EnableLeadStatus": false,
  "CategoryFamilyId": 88,
  "Deleted": false
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CategoryId": 379,
  "Name": "Donnelly Group",
  "CategoryGroup": "Customer",
  "Tooltip": "rem",
  "Rank": 310,
  "EnableLeadStatus": false,
  "CategoryFamilyId": 838,
  "Deleted": true,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 381
    }
  }
}
```