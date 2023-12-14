---
title: POST Sale/Validate
uid: v1SaleEntity_ValidateSaleEntity
generated: true
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
| Appointment | Appointment | Simple read-only appointment data. <para /> Carrier object for Appointment. Services for the Appointment Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IAppointmentAgent">Appointment Agent</see>. |
| Associate | Associate | The sale owner  <para>Use MDO List name "associate" to get list items.</para> |
| UpdatedBy | Associate | Who updated the sale |
| CreatedBy | Associate | Who created to sale |
| Contact | Contact | The contact associated with the sale. It may also be 0 if no contact is associated with the sale.  <para>Use MDO List name "contact" to get list items.</para> |
| Project | Project | A sale may also be connected to a project, so you see the sale both on the company card, and on the project card. This does not mean that a project is required.  <para>Use MDO List name "project" to get list items.</para> |
| SaleText | String | Text describing the sale |
| Person | Person | A sale may also be connected to a person - this must be a contact person registered on the current contact. This does not mean that a person is required.  <para>Use MDO List name "person" to get list items.</para> |
| Currency | Currency | The currency the sale object was sold in  <para>Use MDO List name "currency" to get list items.</para> |
| Competitor | Competitor | List of all possible competitors.   <para>Use MDO List name "comptr" to get list items.</para> |
| Credited | Credited | List of who is to be credited for the sale.  <para>Use MDO List name "credited" to get list items.</para> |
| Rating | Rating | The sale rating  <para>Use MDO List name "prob" to get list items.</para> |
| Reason | Reason | The sale reason  <para>Use MDO List name "reason" to get list items.</para> |
| Source | Source | The sale source  <para>Use MDO List name "source" to get list items.</para> |
| Status | String | The state of the Sale: Open / Sold / Lost / Stalled |
| Saledate | String | (expected / lost / won) sales date |
| Amount | Number | Total sale amount |
| SaleId | Integer | Primary key |
| Earning | Number | Earning on sale |
| EarningPercent | Number | Earning as percent of total |
| Heading | String | Sale heading (short description?) |
| Number | String | Alphanumeric user field |
| Probability | Integer | Actual probability, may differ from the one in the list |
| CreatedDate | String | Registered date  in UTC. |
| UpdatedDate | String | Last updated  in UTC. |
| Completed | String | The Sale completed state. The completed state is either Started or Completed. NotStarted is treated as Started. The value maps to the Done database field. |
| ActiveLinks | Integer | Number of active links to sale, document, appointment. |
| Links | Array | List of all elements linked to the sale. |
| NextDueDate | String | Next due date, this is a denormalization of 'closest future activity date, or most recent if no future activities'. Maintained by the system, but very convenient for searching. |
| Postit | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| SaleType | SaleType | <para>Use MDO List name "saletype" to get list items.</para> |
| ReasonSold | ReasonSold | <para>Use MDO List name "reasonsold" to get list items.</para> |
| ReasonStalled | ReasonStalled | <para>Use MDO List name "reasonstalled" to get list items.</para> |
| ReopenDate | String | Date the sale is to be reopened; valid only for status=stalled. Not necessarily the same as the nextDueDate. |
| SaleStakeholders | Array |  |
| ActiveErpLinks | Integer | The number of active erp links |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.SaleEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.SaleEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.SaleEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| PublishEventDate | String | Publish event date |
| PublishTo | String | Publication valid to (inclusive) |
| PublishFrom | String | Publication valid from (inclusive) |
| IsPublished | Boolean | Publication is published |
| VisibleFor | Array | The set of users or groups the record is visible for |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Sale/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "quia",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2010-12-21T13:57:19.2346514+01:00",
  "Amount": 15864.307999999999,
  "SaleId": 259,
  "Earning": 12905.812,
  "EarningPercent": 419.95599999999996,
  "Heading": "aperiam",
  "Number": "1473598",
  "Probability": 943,
  "CreatedDate": "2020-04-10T13:57:19.2346514+02:00",
  "UpdatedDate": "2014-06-19T13:57:19.2346514+02:00",
  "Completed": "Completed",
  "ActiveLinks": 517,
  "Links": [
    {
      "EntityName": "Cronin-Jast",
      "Id": 682,
      "Description": "Programmable full-range function",
      "ExtraInfo": "ipsa",
      "LinkId": 905
    },
    {
      "EntityName": "Cronin-Jast",
      "Id": 682,
      "Description": "Programmable full-range function",
      "ExtraInfo": "ipsa",
      "LinkId": 905
    }
  ],
  "NextDueDate": "2007-09-13T13:57:19.2346514+02:00",
  "Postit": "esse",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2014-01-13T13:57:19.2346514+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Balistreri-Roob",
      "Comment": "tenetur",
      "StakeholderRoleId": 497,
      "CountryId": 103,
      "PersonId": 321,
      "EmailDescription": "sasha_pouros@heidenreich.co.uk",
      "EmailId": 389,
      "EmailAddress": "jeanie_bahringer@kulas.ca",
      "PhoneId": 993,
      "ContactName": "McCullough, Wiza and Rau",
      "ContactId": 400,
      "SaleId": 381,
      "Mrmrs": "iure",
      "Firstname": "Alexandrea",
      "MiddleName": "Douglas Group",
      "Lastname": "Harvey",
      "SaleStakeholderId": 102,
      "Rank": 517,
      "Phone": "200.790.5570 x11465"
    }
  ],
  "ActiveErpLinks": 79,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Grady Lemke",
    "SuperOffice:2": "573193435"
  },
  "ExtraFields": {
    "ExtraFields1": "totam",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "esse",
    "CustomFields2": "vel"
  },
  "PublishEventDate": "2004-11-05T13:57:19.2346514+01:00",
  "PublishTo": "2014-08-21T13:57:19.2346514+02:00",
  "PublishFrom": "2022-04-04T13:57:19.2346514+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 442,
      "Visibility": "All",
      "DisplayValue": "ducimus"
    },
    {
      "VisibleId": 442,
      "Visibility": "All",
      "DisplayValue": "ducimus"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "cupiditate",
  "2": "facilis"
}
```