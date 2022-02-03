---
title: POST Sale/Validate
id: v1SaleEntity_ValidateSaleEntity
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



| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object


## Sample Request

```http!
POST /api/v1/Sale/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 109,
    "StartDate": "2017-10-03T18:25:51.049945+02:00",
    "EndDate": "2005-05-08T18:25:51.049945+02:00",
    "Type": "BookingForChecklist",
    "Task": "a",
    "AssociateFullName": "Julia Lakin DVM",
    "ContactName": "Bernier Group",
    "Description": "Fully-configurable background installation",
    "PersonFullName": "Dr. Lonny Halvorson",
    "PersonId": 455,
    "ContactId": 850,
    "ProjectId": 136,
    "ProjectName": "Reinger, Terry and Purdy",
    "IsPublished": false,
    "AssociateId": 979,
    "ColorIndex": 921,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 88,
    "PriorityName": "Legros-Reilly",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": true,
    "ActiveDate": "2004-08-20T18:25:51.0509454+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2021-02-22T18:25:51.0509454+01:00",
    "RecurringEndDate": "2014-07-15T18:25:51.0509454+02:00",
    "MotherId": 903,
    "AssignedBy": 404,
    "AssignedByFullName": "Kyla Kuhlman",
    "RejectReason": "",
    "Location": "eos",
    "AlarmLeadTime": "necessitatibus",
    "SaleId": 255,
    "SaleName": "Little-McKenzie",
    "AssociateName": "Stokes-Gerhold",
    "CreatedDate": "1997-05-30T18:25:51.0509454+02:00",
    "CreatedBy": "rem",
    "CreatedByFullName": "Godfrey Bernier",
    "CreatedByAssociateId": 632,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 970,
    "Name": "Greenholt LLC",
    "PersonId": 574,
    "Rank": 305,
    "Tooltip": "sint",
    "Type": "AnonymousAssociate",
    "GroupIdx": 20,
    "FullName": "Dr. Daniella Maggio",
    "FormalName": "Mosciski, Orn and Runolfsdottir",
    "Deleted": false,
    "EjUserId": 750,
    "UserName": "Wehner, Bauch and Hansen"
  },
  "UpdatedBy": {
    "AssociateId": 400,
    "Name": "Pagac, Price and Lubowitz",
    "PersonId": 299,
    "Rank": 508,
    "Tooltip": "et",
    "Type": "AnonymousAssociate",
    "GroupIdx": 525,
    "FullName": "Miss Georgette Howe",
    "FormalName": "Krajcik-Bogisich",
    "Deleted": false,
    "EjUserId": 572,
    "UserName": "Ullrich-Bartoletti"
  },
  "CreatedBy": {
    "AssociateId": 331,
    "Name": "Stehr-Gutmann",
    "PersonId": 632,
    "Rank": 135,
    "Tooltip": "temporibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 178,
    "FullName": "Arnoldo Pagac",
    "FormalName": "Blanda-Willms",
    "Deleted": true,
    "EjUserId": 514,
    "UserName": "Borer, Hudson and Bauch"
  },
  "Contact": {
    "ContactId": 788,
    "Name": "Graham, Hodkiewicz and Heidenreich",
    "OrgNr": "1142766",
    "Department": "grow cutting-edge supply-chains",
    "URL": "http://www.example.com/",
    "City": "aliquid",
    "DirectPhone": "(687)180-4762",
    "AssociateId": 711,
    "CountryId": 965,
    "EmailAddress": "brandt@beerroob.info",
    "Kananame": "quis",
    "EmailAddressName": "vernie.fritsch@moore.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ms. Raul Goldner",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quaerat",
    "FullName": "Lou Lang",
    "IsOwnerContact": true,
    "ActiveErpLinks": 346
  },
  "Project": {
    "ProjectId": 550,
    "Name": "Conn, Yost and Orn",
    "Description": "Innovative systemic portal",
    "URL": "http://www.example.com/",
    "Type": "velit",
    "AssociateId": 106,
    "AssociateFullName": "Dallin Berge",
    "TypeId": 683,
    "Updated": "2001-07-19T18:25:51.0549448+02:00",
    "StatusId": 974,
    "Status": "esse",
    "TextId": 372,
    "PublishTo": "2018-04-18T18:25:51.0549448+02:00",
    "PublishFrom": "2006-07-11T18:25:51.0549448+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1360734",
    "ActiveErpLinks": 896
  },
  "SaleText": "et",
  "Person": {
    "Position": "consequatur",
    "PersonId": 423,
    "Mrmrs": "impedit",
    "Firstname": "Elenor",
    "Lastname": "Ritchie",
    "MiddleName": "Schuppe, Bartoletti and McCullough",
    "Title": "placeat",
    "Description": "De-engineered demand-driven encoding",
    "Email": "taryn@effertzboyer.ca",
    "FullName": "Adolph Boyle",
    "DirectPhone": "1-186-426-6275 x8788",
    "FormalName": "Yundt Group",
    "CountryId": 941,
    "ContactId": 42,
    "ContactName": "Mueller Group",
    "Retired": 304,
    "Rank": 866,
    "ActiveInterests": 653,
    "ContactDepartment": "",
    "ContactCountryId": 302,
    "ContactOrgNr": "1009774",
    "FaxPhone": "1-531-806-8267",
    "MobilePhone": "1-425-218-6705 x4801",
    "ContactPhone": "(687)441-6405",
    "AssociateName": "Ziemann, Spinka and Marquardt",
    "AssociateId": 58,
    "UsePersonAddress": false,
    "ContactFax": "incidunt",
    "Kanafname": "fugit",
    "Kanalname": "impedit",
    "Post1": "excepturi",
    "Post2": "harum",
    "Post3": "nihil",
    "EmailName": "amelia.bergnaum@sipes.uk",
    "ContactFullName": "Ethel Kshlerin",
    "ActiveErpLinks": 804,
    "TicketPriorityId": 759,
    "SupportLanguageId": 490,
    "SupportAssociateId": 724,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 427,
    "Value": "dolorem",
    "Tooltip": "ab"
  },
  "Competitor": {
    "Id": 4,
    "Value": "quod",
    "Tooltip": "repellat"
  },
  "Credited": {
    "Id": 577,
    "Value": "suscipit",
    "Tooltip": "harum"
  },
  "Rating": {
    "Id": 843,
    "Value": "veniam",
    "Tooltip": "illo"
  },
  "Reason": {
    "Id": 146,
    "Value": "dolores",
    "Tooltip": "quas"
  },
  "Source": {
    "Id": 26,
    "Value": "repudiandae",
    "Tooltip": "eum"
  },
  "Status": "Lost",
  "Saledate": "1996-10-18T18:25:51.0559456+02:00",
  "Amount": 6869.728,
  "SaleId": 841,
  "Earning": 2692.1059999999998,
  "EarningPercent": 28133.917999999998,
  "Heading": "ad",
  "Number": "1126522",
  "Probability": 729,
  "CreatedDate": "2002-11-15T18:25:51.0559456+01:00",
  "UpdatedDate": "2013-10-19T18:25:51.0559456+02:00",
  "Completed": "Completed",
  "ActiveLinks": 259,
  "Links": [
    {
      "EntityName": "Powlowski Inc and Sons",
      "Id": 638,
      "Description": "Networked systematic interface",
      "ExtraInfo": "iusto",
      "LinkId": 579
    },
    {
      "EntityName": "Powlowski Inc and Sons",
      "Id": 638,
      "Description": "Networked systematic interface",
      "ExtraInfo": "iusto",
      "LinkId": 579
    }
  ],
  "NextDueDate": "2000-09-05T18:25:51.0559456+02:00",
  "Postit": "illum",
  "SaleType": {
    "Id": 811,
    "Value": "voluptates",
    "Tooltip": "nulla"
  },
  "ReasonSold": {
    "Id": 941,
    "Value": "distinctio",
    "Tooltip": "dolores"
  },
  "ReasonStalled": {
    "Id": 238,
    "Value": "eaque",
    "Tooltip": "voluptates"
  },
  "ReopenDate": "2021-04-25T18:25:51.0559456+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Kilback LLC",
      "Comment": "facere",
      "StakeholderRoleId": 418,
      "CountryId": 331,
      "PersonId": 918,
      "EmailDescription": "gregoria@schiller.us",
      "EmailId": 312,
      "EmailAddress": "yasmeen@hegmannspinka.us",
      "PhoneId": 849,
      "ContactName": "Dare-Metz",
      "ContactId": 333,
      "SaleId": 200,
      "Mrmrs": "ut",
      "Firstname": "Jacynthe",
      "MiddleName": "Mohr-Willms",
      "Lastname": "Breitenberg",
      "SaleStakeholderId": 130,
      "Rank": 422,
      "Phone": "1-036-814-8868 x285"
    }
  ],
  "ActiveErpLinks": 49,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "sequi",
    "ExtraFields2": "magni"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "totam"
  },
  "PublishEventDate": "2016-11-16T18:25:51.0569408+01:00",
  "PublishTo": "1995-04-05T18:25:51.0569408+02:00",
  "PublishFrom": "2003-05-01T18:25:51.0569408+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 892,
      "Visibility": "All",
      "DisplayValue": "quasi"
    },
    {
      "VisibleId": 892,
      "Visibility": "All",
      "DisplayValue": "quasi"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "veniam",
  "2": "ea"
}
```