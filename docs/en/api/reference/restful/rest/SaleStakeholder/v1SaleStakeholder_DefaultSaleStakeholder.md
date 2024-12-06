---
title: GET SaleStakeholder/default
uid: v1SaleStakeholder_DefaultSaleStakeholder
generated: true
---

# GET SaleStakeholder/default

```http
GET /api/v1/SaleStakeholder/default
```

Set default values into a new SaleStakeholder.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Sale agent service CreateDefaultSaleStakeholder.







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

### Response body: SaleStakeholder

| Property Name | Type |  Description |
|----------------|------|--------------|
| StakeholderRoleName | string | Stakeholder role name |
| Comment | string | Optional comment text |
| StakeholderRoleId | int32 | Stakeholde role list id - Primary key |
| CountryId | int32 | Country id - primary key |
| PersonId | int32 | Person id - Primary key |
| EmailDescription | string | E-mail description |
| EmailId | int32 | E-mail address id - Primary key |
| EmailAddress | string | E-mail address |
| PhoneId | int32 | Primary key |
| ContactName | string | Contact name |
| ContactId | int32 | Contact ID of person or contact who is the sale stakeholder |
| SaleId | int32 | Parent sale |
| Mrmrs | string | e.g. Mrs, Mr, Ms, Dr. |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| SaleStakeholderId | int32 | Primary key |
| Rank | int32 | Rank in list of stakeholders |
| Phone | string | Phone number |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/SaleStakeholder/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Kiehn-Grimes",
  "Comment": "et",
  "StakeholderRoleId": 61,
  "CountryId": 533,
  "PersonId": 833,
  "EmailDescription": "okey_macejkovic@lakin.info",
  "EmailId": 22,
  "EmailAddress": "era@durganlowe.us",
  "PhoneId": 52,
  "ContactName": "Beer-Hand",
  "ContactId": 324,
  "SaleId": 608,
  "Mrmrs": "laboriosam",
  "Firstname": "Jaqueline",
  "MiddleName": "Kuhlman, Gutkowski and Barrows",
  "Lastname": "Schiller",
  "SaleStakeholderId": 138,
  "Rank": 898,
  "Phone": "330.312.7348 x03733",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 496
    }
  }
}
```