---
title: POST Agents/Sale/SaveSaleStakeholder
uid: v1SaleAgent_SaveSaleStakeholder
---

# POST Agents/Sale/SaveSaleStakeholder

```http
POST /api/v1/Agents/Sale/SaveSaleStakeholder
```

Updates the existing SaleStakeholder or creates a new SaleStakeholder if the id parameter is empty

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

## Request Body: entity

The SaleStakeholder to be saved.

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

## Response

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body:

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
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Sale/SaveSaleStakeholder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Thompson-Vandervort",
  "Comment": "iste",
  "StakeholderRoleId": 924,
  "CountryId": 578,
  "PersonId": 778,
  "EmailDescription": "gerda.leannon@wyman.us",
  "EmailId": 228,
  "EmailAddress": "lavonne@hirthe.com",
  "PhoneId": 877,
  "ContactName": "Ritchie, Flatley and Koepp",
  "ContactId": 581,
  "SaleId": 546,
  "Mrmrs": "id",
  "Firstname": "Allan",
  "MiddleName": "Kutch-Heller",
  "Lastname": "Howell",
  "SaleStakeholderId": 556,
  "Rank": 499,
  "Phone": "568.913.5426"
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Purdy-Bartell",
  "Comment": "quibusdam",
  "StakeholderRoleId": 562,
  "CountryId": 379,
  "PersonId": 718,
  "EmailDescription": "malinda_reichert@wintheiser.co.uk",
  "EmailId": 155,
  "EmailAddress": "jairo_walsh@dickinsontillman.biz",
  "PhoneId": 139,
  "ContactName": "Sipes LLC",
  "ContactId": 843,
  "SaleId": 699,
  "Mrmrs": "natus",
  "Firstname": "Mireille",
  "MiddleName": "Rohan-Feil",
  "Lastname": "Weissnat",
  "SaleStakeholderId": 937,
  "Rank": 662,
  "Phone": "1-457-641-6998 x0396",
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 673
    }
  }
}
```
