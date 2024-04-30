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
Accept-Language: sv
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Last-Modified: Sun, 13 Oct 2019 11:44:42 G10T

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "nemo",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2002-01-07T11:44:42.2420975+01:00",
  "Amount": 12498.392,
  "SaleId": 361,
  "Earning": 1385.228,
  "EarningPercent": 10498.9,
  "Heading": "aliquam",
  "Number": "1114690",
  "Probability": 469,
  "CreatedDate": "2020-01-27T11:44:42.2420975+01:00",
  "UpdatedDate": "2019-10-13T11:44:42.2420975+02:00",
  "Completed": "Completed",
  "ActiveLinks": 67,
  "Links": [
    {
      "EntityName": "Lockman Inc and Sons",
      "Id": 376,
      "Description": "Mandatory systemic hub",
      "ExtraInfo": "nihil",
      "LinkId": 699,
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 183
        }
      }
    }
  ],
  "NextDueDate": "2012-12-13T11:44:42.2420975+01:00",
  "Postit": "recusandae",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2017-08-06T11:44:42.2420975+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Lockman-Lindgren",
      "Comment": "ut",
      "StakeholderRoleId": 680,
      "CountryId": 168,
      "PersonId": 290,
      "EmailDescription": "jeramy@kutchmitchell.us",
      "EmailId": 3,
      "EmailAddress": "reba@torp.uk",
      "PhoneId": 77,
      "ContactName": "Hoppe-Cummerata",
      "ContactId": 368,
      "SaleId": 778,
      "Mrmrs": "qui",
      "Firstname": "Benny",
      "MiddleName": "Bailey, Wehner and Anderson",
      "Lastname": "Lakin",
      "SaleStakeholderId": 651,
      "Rank": 262,
      "Phone": "(912)269-2029",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 301
        }
      }
    }
  ],
  "ActiveErpLinks": 583,
  "UserDefinedFields": {
    "SuperOffice:1": "Tristin Schaden",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "illum",
    "ExtraFields2": "vero"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "aut"
  },
  "PublishEventDate": "2000-03-19T11:44:42.2420975+01:00",
  "PublishTo": "1998-06-10T11:44:42.2420975+02:00",
  "PublishFrom": "2016-11-11T11:44:42.2420975+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 529,
      "Visibility": "All",
      "DisplayValue": "molestiae",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 686
        }
      }
    },
    {
      "VisibleId": 529,
      "Visibility": "All",
      "DisplayValue": "molestiae",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 686
        }
      }
    }
  ],
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 733
    }
  }
}
```