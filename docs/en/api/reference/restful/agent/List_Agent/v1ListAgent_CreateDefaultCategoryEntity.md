---
title: POST Agents/List/CreateDefaultCategoryEntity
uid: v1ListAgent_CreateDefaultCategoryEntity
generated: true
content_type: reference
---

# POST Agents/List/CreateDefaultCategoryEntity

```http
POST /api/v1/Agents/List/CreateDefaultCategoryEntity
```

Loading default values into a new CategoryEntity.








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
POST /api/v1/Agents/List/CreateDefaultCategoryEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "CategoryId": 268,
  "Name": "Bogan Group",
  "CategoryGroup": "Customer",
  "Tooltip": "placeat",
  "Rank": 77,
  "EnableLeadStatus": true,
  "CategoryFamilyId": 228,
  "Deleted": false,
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 540
    }
  }
}
```