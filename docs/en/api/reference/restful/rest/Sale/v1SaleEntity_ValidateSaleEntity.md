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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Appointment": null,
  "Associate": null,
  "UpdatedBy": null,
  "CreatedBy": null,
  "Contact": null,
  "Project": null,
  "SaleText": "veritatis",
  "Person": null,
  "Currency": null,
  "Competitor": null,
  "Credited": null,
  "Rating": null,
  "Reason": null,
  "Source": null,
  "Status": "Lost",
  "Saledate": "2006-04-25T10:18:00.6918462+02:00",
  "Amount": 26356.94,
  "SaleId": 590,
  "Earning": 30525.16,
  "EarningPercent": 4782.4839999999995,
  "Heading": "hic",
  "Number": "1225234",
  "Probability": 335,
  "CreatedDate": "2001-01-06T10:18:00.6918462+01:00",
  "UpdatedDate": "2004-06-24T10:18:00.6918462+02:00",
  "Completed": "Completed",
  "ActiveLinks": 562,
  "Links": [
    {
      "EntityName": "Cole-Orn",
      "Id": 703,
      "Description": "Multi-layered methodical toolset",
      "ExtraInfo": "sed",
      "LinkId": 980
    },
    {
      "EntityName": "Cole-Orn",
      "Id": 703,
      "Description": "Multi-layered methodical toolset",
      "ExtraInfo": "sed",
      "LinkId": 980
    }
  ],
  "NextDueDate": "2006-06-27T10:18:00.6918462+02:00",
  "Postit": "et",
  "SaleType": null,
  "ReasonSold": null,
  "ReasonStalled": null,
  "ReopenDate": "2017-05-04T10:18:00.6918462+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Homenick, Metz and Gulgowski",
      "Comment": "voluptatem",
      "StakeholderRoleId": 983,
      "CountryId": 506,
      "PersonId": 134,
      "EmailDescription": "herta@conroyvonrueden.us",
      "EmailId": 863,
      "EmailAddress": "darrell@borer.co.uk",
      "PhoneId": 69,
      "ContactName": "Lesch-Gutkowski",
      "ContactId": 509,
      "SaleId": 440,
      "Mrmrs": "laudantium",
      "Firstname": "Murphy",
      "MiddleName": "Jenkins-Morissette",
      "Lastname": "O'Kon",
      "SaleStakeholderId": 770,
      "Rank": 429,
      "Phone": "1-874-909-8690 x2542"
    }
  ],
  "ActiveErpLinks": 129,
  "UserDefinedFields": {
    "SuperOffice:1": "1909499011",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "officia",
    "ExtraFields2": "voluptas"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "quo"
  },
  "PublishEventDate": "2022-06-18T10:18:00.6918462+02:00",
  "PublishTo": "1999-04-13T10:18:00.6918462+02:00",
  "PublishFrom": "2022-12-27T10:18:00.6918462+01:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 145,
      "Visibility": "All",
      "DisplayValue": "aliquid"
    },
    {
      "VisibleId": 145,
      "Visibility": "All",
      "DisplayValue": "aliquid"
    }
  ]
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ut",
  "2": "atque"
}
```