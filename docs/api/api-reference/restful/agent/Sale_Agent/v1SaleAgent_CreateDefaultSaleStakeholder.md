---
title: POST Agents/Sale/CreateDefaultSaleStakeholder
id: v1SaleAgent_CreateDefaultSaleStakeholder
---

# POST Agents/Sale/CreateDefaultSaleStakeholder

```http
POST /api/v1/Agents/Sale/CreateDefaultSaleStakeholder
```

Set default values into a new SaleStakeholder.

NetServer calculates default values on the entity, which is required when creating/storing a new instance






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


## Response: object

Carrier object for SaleStakeholder.
Services for the SaleStakeholder Carrier is available from the <see cref="T:SuperOffice.CRM.Services.ISaleAgent">Sale Agent</see>.

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

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

## Sample Request

```http!
POST /api/v1/Agents/Sale/CreateDefaultSaleStakeholder
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "StakeholderRoleName": "Langosh Group",
  "Comment": "architecto",
  "StakeholderRoleId": 4,
  "CountryId": 661,
  "PersonId": 273,
  "EmailDescription": "lorna_kub@brown.com",
  "EmailId": 526,
  "EmailAddress": "jennyfer@stark.biz",
  "PhoneId": 297,
  "ContactName": "Schiller, Heaney and Langosh",
  "ContactId": 559,
  "SaleId": 762,
  "Mrmrs": "fugiat",
  "Firstname": "Aglae",
  "MiddleName": "Wunsch LLC",
  "Lastname": "Johns",
  "SaleStakeholderId": 12,
  "Rank": 738,
  "Phone": "1-744-316-4442",
  "TableRight": {
    "Mask": "Delete",
    "Reason": ""
  },
  "FieldProperties": {
    "fieldName": {
      "FieldRight": {
        "Mask": "FULL",
        "Reason": ""
      },
      "FieldType": "System.String",
      "FieldLength": 112
    }
  }
}
```