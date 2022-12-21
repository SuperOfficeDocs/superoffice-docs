---
title: POST Sale/Validate
uid: v1SaleEntity_ValidateSaleEntity
---

# POST Sale/Validate

```http
POST /api/v1/Sale/Validate
```

Check that entity is ready for saving, return error messages by field.








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

## Request Body: saleEntity  

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| Appointment |  | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate |  | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy |  | Who updated the sale |
| CreatedBy |  | Who created to sale |
| Contact |  | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project |  | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | string | Text describing the sale |
| Person |  | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency |  | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor |  | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited |  | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating |  | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason |  | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source |  | The sale source  <para>Use MDO List name "source" to get list items.</para> |
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
| SaleType |  | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold |  | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled |  | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | date-time | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | array |  |
| ActiveErpLinks | int32 | The number of active erp links |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | date-time | Publish event date |
| PublishTo | date-time | Publication valid to (inclusive) |
| PublishFrom | date-time | Publication valid from (inclusive) |
| IsPublished | bool | Publication is published |
| VisibleFor | array | The set of users or groups the record is visible for |


## Response: object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample request

```http!
POST /api/v1/Sale/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "possimus",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2013-05-19T02:49:51.4894333+02:00",
  "Amount": 1557.598,
  "SaleId": 265,
  "Earning": 31139.424,
  "EarningPercent": 17468.916,
  "Heading": "nulla",
  "Number": "1819715",
  "Probability": 615,
  "CreatedDate": "2019-05-13T02:49:51.4894333+02:00",
  "UpdatedDate": "2014-02-03T02:49:51.4894333+01:00",
  "Completed": "Completed",
  "ActiveLinks": 871,
  "Links": [
    {
      "EntityName": "Casper-Leuschke",
      "Id": 595,
      "Description": "Progressive local time-frame",
      "ExtraInfo": "eos",
      "LinkId": 766
    },
    {
      "EntityName": "Casper-Leuschke",
      "Id": 595,
      "Description": "Progressive local time-frame",
      "ExtraInfo": "eos",
      "LinkId": 766
    }
  ],
  "NextDueDate": "2001-10-12T02:49:51.4894333+02:00",
  "Postit": "blanditiis",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2004-03-12T02:49:51.4894333+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Lindgren, Kozey and Dooley",
      "Comment": "quisquam",
      "StakeholderRoleId": 194,
      "CountryId": 523,
      "PersonId": 219,
      "EmailDescription": "cornell@carterjewess.name",
      "EmailId": 544,
      "EmailAddress": "creola@satterfieldrau.name",
      "PhoneId": 5,
      "ContactName": "Rogahn, Graham and Emmerich",
      "ContactId": 934,
      "SaleId": 746,
      "Mrmrs": "asperiores",
      "Firstname": "Reymundo",
      "MiddleName": "Stark Group",
      "Lastname": "Haag",
      "SaleStakeholderId": 855,
      "Rank": 899,
      "Phone": "019-343-8937 x278"
    }
  ],
  "ActiveErpLinks": 56,
  "UserDefinedFields": {
    "SuperOffice:1": "227955717",
    "SuperOffice:2": "Dr. Jazmyn Marks I"
  },
  "ExtraFields": {
    "ExtraFields1": "officiis",
    "ExtraFields2": "dolor"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "distinctio"
  },
  "PublishEventDate": "2007-11-13T02:49:51.4894333+01:00",
  "PublishTo": "1999-08-22T02:49:51.4894333+02:00",
  "PublishFrom": "2018-12-29T02:49:51.4894333+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 25,
      "Visibility": "All",
      "DisplayValue": "numquam"
    },
    {
      "VisibleId": 25,
      "Visibility": "All",
      "DisplayValue": "numquam"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "quos",
  "2": "et"
}
```