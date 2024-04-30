---
title: GET Sale/default
uid: v1SaleEntity_DefaultSaleEntity
generated: true
---

# GET Sale/default

```http
GET /api/v1/Sale/default
```

Set default values into a new SaleEntity.


NetServer calculates default values on the entity, which is required when creating/storing a new instance Calls the Sale agent service CreateDefaultSaleEntity.







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

### Response body: SaleEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment | Appointment | Simple read-only appointment data.  Carrier object for Appointment. Services for the Appointment Carrier is available from the Appointment Agent. |
| Associate | Associate | The sale owner  Use MDO List name "associate" to get list items. |
| UpdatedBy | Associate | Who updated the sale |
| CreatedBy | Associate | Who created to sale |
| Contact | Contact | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  Use MDO List name "contact" to get list items. |
| Project | Project | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  Use MDO List name "project" to get list items. |
| SaleText | string | Text describing the sale |
| Person | Person | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  Use MDO List name "person" to get list items. |
| Currency | Currency | The currency the sale object was sold in  Use MDO List name "currency" to get list items. |
| Competitor | Competitor | List of all possible competitors.   Use MDO List name "comptr" to get list items. |
| Credited | Credited | List of who is to be credited for the sale.  Use MDO List name "credited" to get list items. |
| Rating | Rating | The sale rating  Use MDO List name "prob" to get list items. |
| Reason | Reason | The sale reason  Use MDO List name "reason" to get list items. |
| Source | Source | The sale source  Use MDO List name "source" to get list items. |
| Status | string | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | date-time | (expected / lost / won) sales date |
| Amount | double | Total sale amount |
| SaleId | int32 | Primary key |
| Earning | double | Earning on sale |
| EarningPercent | double | Earning as percent of total |
| Heading | string | Sale heading (short description?) |
| Number | string | Alphanumeric user field |
| Probability | int32 | Actual probability, may differ from the one in the list |
| CreatedDate | date-time | Registered date  in UTC. |
| UpdatedDate | date-time | Last updated  in UTC. |
| Completed | string | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | int32 | Number of active links to sale, document, appointment. |
| Links | array | List of all elements linked to the sale. |
| NextDueDate | date-time | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType | SaleType | Use MDO List name "saletype" to get list items. |
| ReasonSold | ReasonSold | Use MDO List name "reasonsold" to get list items. |
| ReasonStalled | ReasonStalled | Use MDO List name "reasonstalled" to get list items. |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
GET /api/v1/Sale/default
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Mon, 27 Jun 2022 11:16:14 G6T

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "alias",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2007-06-01T11:16:14.1519474+02:00",
  "Amount": 25410.471999999998,
  "SaleId": 906,
  "Earning": 18619.094,
  "EarningPercent": 4697.866,
  "Heading": "rerum",
  "Number": "750826",
  "Probability": 49,
  "CreatedDate": "2024-02-24T11:16:14.1519474+01:00",
  "UpdatedDate": "2022-06-27T11:16:14.1519474+02:00",
  "Completed": "Completed",
  "ActiveLinks": 617,
  "Links": [
    {
      "EntityName": "Nader, Breitenberg and Wehner",
      "Id": 714,
      "Description": "De-engineered regional benchmark",
      "ExtraInfo": "iusto",
      "LinkId": 897,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "NextDueDate": "2009-02-03T11:16:14.1519474+01:00",
  "Postit": "sint",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2021-04-17T11:16:14.1519474+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Schuster-Ruecker",
      "Comment": "quasi",
      "StakeholderRoleId": 647,
      "CountryId": 784,
      "PersonId": 58,
      "EmailDescription": "gerry_klein@boyer.biz",
      "EmailId": 127,
      "EmailAddress": "jimmy_kshlerin@townestokes.name",
      "PhoneId": 96,
      "ContactName": "Johnson, Hoppe and Mills",
      "ContactId": 920,
      "SaleId": 281,
      "Mrmrs": "est",
      "Firstname": "Elisabeth",
      "MiddleName": "Runte-Shields",
      "Lastname": "Bernhard",
      "SaleStakeholderId": 971,
      "Rank": 752,
      "Phone": "(289)019-4130 x42584",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 654
        }
      }
    }
  ],
  "ActiveErpLinks": 621,
  "UserDefinedFields": {
    "SuperOffice:1": "Stanley Dakota Gutmann Sr.",
    "SuperOffice:2": "Alisha Watsica"
  },
  "ExtraFields": {
    "ExtraFields1": "accusamus",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "minus",
    "CustomFields2": "laboriosam"
  },
  "PublishEventDate": "2010-04-09T11:16:14.1519474+02:00",
  "PublishTo": "2017-02-21T11:16:14.1519474+01:00",
  "PublishFrom": "2009-01-16T11:16:14.1519474+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 356,
      "Visibility": "All",
      "DisplayValue": "veniam",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 528
        }
      }
    },
    {
      "VisibleId": 356,
      "Visibility": "All",
      "DisplayValue": "veniam",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 528
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 53
    }
  }
}
```