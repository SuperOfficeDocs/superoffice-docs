---
title: PUT Sale/{id}
id: v1SaleEntity_PutSaleEntity
---

# PUT Sale/{id}

```http
PUT /api/v1/Sale/{id}
```

Updates the existing SaleEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The SaleEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Sale/{id}?$select=name,department,category/id
```


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

The SaleEntity to be saved. 

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

The Sale Entity contains the sale amount, currency, and sale members. Sales are linked to contacts, persons, and/or projects.



SaleEntity entity with API _Links added.

| Response | Description |
|----------------|-------------|
| 200 | SaleEntity updated. |
| 412 | Update stopped because SaleEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

Response body: object

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
| TableRight |  |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample Request

```http!
PUT /api/v1/Sale/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 870,
    "StartDate": "2017-04-14T18:25:50.9762554+02:00",
    "EndDate": "2008-07-14T18:25:50.9762554+02:00",
    "Type": "BookingForChecklist",
    "Task": "voluptate",
    "AssociateFullName": "Randall Lowe Jr.",
    "ContactName": "Friesen Group",
    "Description": "Ergonomic discrete productivity",
    "PersonFullName": "Candelario Collins",
    "PersonId": 406,
    "ContactId": 376,
    "ProjectId": 400,
    "ProjectName": "Graham, Emmerich and Macejkovic",
    "IsPublished": false,
    "AssociateId": 664,
    "ColorIndex": 487,
    "IsFree": false,
    "HasAlarm": false,
    "IsAlldayEvent": true,
    "Private": "PrivateGroup",
    "PriorityId": 968,
    "PriorityName": "Mohr LLC",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "1995-06-28T18:25:50.9762554+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "1998-12-28T18:25:50.9762554+01:00",
    "RecurringEndDate": "1996-08-02T18:25:50.9762554+02:00",
    "MotherId": 747,
    "AssignedBy": 39,
    "AssignedByFullName": "Emerald Satterfield",
    "RejectReason": "",
    "Location": "ea",
    "AlarmLeadTime": "officia",
    "SaleId": 921,
    "SaleName": "Larkin-Hane",
    "AssociateName": "Kemmer, Swift and Kiehn",
    "CreatedDate": "1997-09-07T18:25:50.9762554+02:00",
    "CreatedBy": "est",
    "CreatedByFullName": "Maryse Bartoletti",
    "CreatedByAssociateId": 488,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 411,
    "Name": "Breitenberg Group",
    "PersonId": 49,
    "Rank": 63,
    "Tooltip": "id",
    "Type": "AnonymousAssociate",
    "GroupIdx": 669,
    "FullName": "Tamia Bailey",
    "FormalName": "Rath Inc and Sons",
    "Deleted": true,
    "EjUserId": 430,
    "UserName": "Dach Inc and Sons"
  },
  "UpdatedBy": {
    "AssociateId": 640,
    "Name": "Gleason LLC",
    "PersonId": 727,
    "Rank": 618,
    "Tooltip": "ut",
    "Type": "AnonymousAssociate",
    "GroupIdx": 348,
    "FullName": "Rhianna Von",
    "FormalName": "Crooks Inc and Sons",
    "Deleted": true,
    "EjUserId": 542,
    "UserName": "Howe, Sauer and McDermott"
  },
  "CreatedBy": {
    "AssociateId": 181,
    "Name": "Windler, Johnson and Nolan",
    "PersonId": 355,
    "Rank": 439,
    "Tooltip": "voluptatem",
    "Type": "AnonymousAssociate",
    "GroupIdx": 318,
    "FullName": "Olen Bergstrom",
    "FormalName": "Lakin, Hammes and Kiehn",
    "Deleted": true,
    "EjUserId": 502,
    "UserName": "Hamill-Vandervort"
  },
  "Contact": {
    "ContactId": 85,
    "Name": "Walsh LLC",
    "OrgNr": "1938034",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "dolor",
    "DirectPhone": "005-428-3710",
    "AssociateId": 18,
    "CountryId": 513,
    "EmailAddress": "karlee@jerde.com",
    "Kananame": "quasi",
    "EmailAddressName": "clement@runolfsson.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Ila Goldner",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quos",
    "FullName": "Leatha Raynor",
    "IsOwnerContact": true,
    "ActiveErpLinks": 250
  },
  "Project": {
    "ProjectId": 23,
    "Name": "Koss Group",
    "Description": "Reactive demand-driven core",
    "URL": "http://www.example.com/",
    "Type": "sunt",
    "AssociateId": 37,
    "AssociateFullName": "Jackson McClure",
    "TypeId": 213,
    "Updated": "2003-07-23T18:25:50.97926+02:00",
    "StatusId": 931,
    "Status": "a",
    "TextId": 861,
    "PublishTo": "2016-04-13T18:25:50.97926+02:00",
    "PublishFrom": "1999-05-11T18:25:50.97926+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1247166",
    "ActiveErpLinks": 617
  },
  "SaleText": "eos",
  "Person": {
    "Position": "cupiditate",
    "PersonId": 978,
    "Mrmrs": "dolorem",
    "Firstname": "August",
    "Lastname": "Cummerata",
    "MiddleName": "Douglas, Weissnat and Cummings",
    "Title": "recusandae",
    "Description": "Pre-emptive system-worthy encryption",
    "Email": "evalyn@stokesberge.biz",
    "FullName": "Reina Nitzsche",
    "DirectPhone": "(733)012-3343 x55433",
    "FormalName": "Kohler-Yundt",
    "CountryId": 548,
    "ContactId": 382,
    "ContactName": "McCullough, Wiegand and Gutkowski",
    "Retired": 721,
    "Rank": 913,
    "ActiveInterests": 270,
    "ContactDepartment": "",
    "ContactCountryId": 801,
    "ContactOrgNr": "970932",
    "FaxPhone": "782.621.6724",
    "MobilePhone": "(466)784-5252",
    "ContactPhone": "(814)022-0754",
    "AssociateName": "Kertzmann-Rippin",
    "AssociateId": 585,
    "UsePersonAddress": true,
    "ContactFax": "quia",
    "Kanafname": "ut",
    "Kanalname": "ratione",
    "Post1": "atque",
    "Post2": "deserunt",
    "Post3": "quia",
    "EmailName": "americo@russel.name",
    "ContactFullName": "Alfonzo Bode",
    "ActiveErpLinks": 268,
    "TicketPriorityId": 189,
    "SupportLanguageId": 879,
    "SupportAssociateId": 415,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 865,
    "Value": "itaque",
    "Tooltip": "aspernatur"
  },
  "Competitor": {
    "Id": 272,
    "Value": "quia",
    "Tooltip": "assumenda"
  },
  "Credited": {
    "Id": 352,
    "Value": "nemo",
    "Tooltip": "fugit"
  },
  "Rating": {
    "Id": 547,
    "Value": "accusantium",
    "Tooltip": "nostrum"
  },
  "Reason": {
    "Id": 186,
    "Value": "autem",
    "Tooltip": "maxime"
  },
  "Source": {
    "Id": 16,
    "Value": "quia",
    "Tooltip": "maiores"
  },
  "Status": "Lost",
  "Saledate": "2021-05-12T18:25:50.9802598+02:00",
  "Amount": 12880.74,
  "SaleId": 854,
  "Earning": 25122.144,
  "EarningPercent": 23787.059999999998,
  "Heading": "et",
  "Number": "669959",
  "Probability": 41,
  "CreatedDate": "1996-10-08T18:25:50.9802598+02:00",
  "UpdatedDate": "2011-09-24T18:25:50.9802598+02:00",
  "Completed": "Completed",
  "ActiveLinks": 892,
  "Links": [
    {
      "EntityName": "Boehm, Gleichner and Kilback",
      "Id": 491,
      "Description": "Grass-roots content-based moratorium",
      "ExtraInfo": "incidunt",
      "LinkId": 134
    },
    {
      "EntityName": "Boehm, Gleichner and Kilback",
      "Id": 491,
      "Description": "Grass-roots content-based moratorium",
      "ExtraInfo": "incidunt",
      "LinkId": 134
    }
  ],
  "NextDueDate": "2005-08-31T18:25:50.9802598+02:00",
  "Postit": "fugiat",
  "SaleType": {
    "Id": 85,
    "Value": "quibusdam",
    "Tooltip": "molestiae"
  },
  "ReasonSold": {
    "Id": 365,
    "Value": "sed",
    "Tooltip": "consequatur"
  },
  "ReasonStalled": {
    "Id": 358,
    "Value": "qui",
    "Tooltip": "velit"
  },
  "ReopenDate": "2014-12-22T18:25:50.9812577+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Herzog LLC",
      "Comment": "et",
      "StakeholderRoleId": 932,
      "CountryId": 295,
      "PersonId": 725,
      "EmailDescription": "louie@heller.ca",
      "EmailId": 671,
      "EmailAddress": "santos@gislason.com",
      "PhoneId": 262,
      "ContactName": "VonRueden-Luettgen",
      "ContactId": 289,
      "SaleId": 632,
      "Mrmrs": "explicabo",
      "Firstname": "Glennie",
      "MiddleName": "Macejkovic-Koss",
      "Lastname": "Harris",
      "SaleStakeholderId": 964,
      "Rank": 774,
      "Phone": "(181)305-2186"
    }
  ],
  "ActiveErpLinks": 832,
  "UserDefinedFields": {
    "SuperOffice:1": "Nelle Jenkins V",
    "SuperOffice:2": "Lauren Upton"
  },
  "ExtraFields": {
    "ExtraFields1": "ullam",
    "ExtraFields2": "harum"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "debitis"
  },
  "PublishEventDate": "2008-05-24T18:25:50.9812577+02:00",
  "PublishTo": "2003-10-24T18:25:50.9812577+02:00",
  "PublishFrom": "1997-04-30T18:25:50.9812577+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 759,
      "Visibility": "All",
      "DisplayValue": "velit"
    },
    {
      "VisibleId": 759,
      "Visibility": "All",
      "DisplayValue": "velit"
    }
  ]
}
```

```http_
HTTP/1.1 200 SaleEntity updated.
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 577,
    "StartDate": "2007-09-03T18:25:50.9882599+02:00",
    "EndDate": "2019-01-03T18:25:50.9882599+01:00",
    "Type": "BookingForChecklist",
    "Task": "eligendi",
    "AssociateFullName": "Berniece Oberbrunner I",
    "ContactName": "Mills, Schulist and Boyle",
    "Description": "Automated neutral protocol",
    "PersonFullName": "Friedrich Durgan",
    "PersonId": 529,
    "ContactId": 510,
    "ProjectId": 108,
    "ProjectName": "Wunsch, Greenholt and Kris",
    "IsPublished": false,
    "AssociateId": 650,
    "ColorIndex": 671,
    "IsFree": true,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 430,
    "PriorityName": "Jast LLC",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": true,
    "IsBooking": false,
    "ActiveDate": "1996-05-28T18:25:50.9882599+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2012-03-04T18:25:50.9882599+01:00",
    "RecurringEndDate": "2011-08-03T18:25:50.9882599+02:00",
    "MotherId": 480,
    "AssignedBy": 523,
    "AssignedByFullName": "Carlos O'Kon Jr.",
    "RejectReason": "",
    "Location": "et",
    "AlarmLeadTime": "non",
    "SaleId": 454,
    "SaleName": "Wolf-Franecki",
    "AssociateName": "Witting, Renner and Ortiz",
    "CreatedDate": "2001-12-17T18:25:50.9892246+01:00",
    "CreatedBy": "velit",
    "CreatedByFullName": "Leone Walsh",
    "CreatedByAssociateId": 790,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "incubate transparent e-services"
        },
        "FieldType": "System.Int32",
        "FieldLength": 273
      }
    }
  },
  "Associate": {
    "AssociateId": 192,
    "Name": "Streich-Kovacek",
    "PersonId": 427,
    "Rank": 364,
    "Tooltip": "consequuntur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 680,
    "FullName": "Richard Goodwin",
    "FormalName": "Schulist, Runolfsdottir and Kautzer",
    "Deleted": false,
    "EjUserId": 491,
    "UserName": "Borer-Goyette",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 870
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 490,
    "Name": "Christiansen-Stehr",
    "PersonId": 720,
    "Rank": 888,
    "Tooltip": "consectetur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 758,
    "FullName": "Ms. Ellsworth Haag",
    "FormalName": "Cruickshank, Armstrong and McCullough",
    "Deleted": true,
    "EjUserId": 97,
    "UserName": "Mueller-Feeney",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "evolve next-generation mindshare"
        },
        "FieldType": "System.Int32",
        "FieldLength": 911
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 233,
    "Name": "Fisher LLC",
    "PersonId": 876,
    "Rank": 534,
    "Tooltip": "voluptas",
    "Type": "AnonymousAssociate",
    "GroupIdx": 664,
    "FullName": "Aryanna Cummings",
    "FormalName": "Rempel Group",
    "Deleted": true,
    "EjUserId": 183,
    "UserName": "Walter, Gislason and Padberg",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate user-centric infrastructures"
        },
        "FieldType": "System.String",
        "FieldLength": 704
      }
    }
  },
  "Contact": {
    "ContactId": 628,
    "Name": "Hansen Inc and Sons",
    "OrgNr": "1402718",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "placeat",
    "DirectPhone": "216-533-3415 x155",
    "AssociateId": 952,
    "CountryId": 258,
    "EmailAddress": "kaylee_braun@altenwerth.us",
    "Kananame": "sit",
    "EmailAddressName": "herbert.green@windlerortiz.biz",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jimmy Rosenbaum",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "ab",
    "FullName": "Payton Ward III",
    "IsOwnerContact": false,
    "ActiveErpLinks": 79,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 380
      }
    }
  },
  "Project": {
    "ProjectId": 753,
    "Name": "Wisozk Inc and Sons",
    "Description": "Decentralized intermediate hardware",
    "URL": "http://www.example.com/",
    "Type": "voluptates",
    "AssociateId": 65,
    "AssociateFullName": "Parker VonRueden",
    "TypeId": 350,
    "Updated": "2017-05-27T18:25:50.9912586+02:00",
    "StatusId": 647,
    "Status": "omnis",
    "TextId": 978,
    "PublishTo": "1997-02-21T18:25:50.9912586+01:00",
    "PublishFrom": "2009-08-25T18:25:50.9912586+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "572871",
    "ActiveErpLinks": 600,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 443
      }
    }
  },
  "SaleText": "ratione",
  "Person": {
    "Position": "non",
    "PersonId": 48,
    "Mrmrs": "inventore",
    "Firstname": "Kellen",
    "Lastname": "Waters",
    "MiddleName": "Conn-Hand",
    "Title": "pariatur",
    "Description": "Open-architected radical forecast",
    "Email": "kris.hagenes@wardyundt.uk",
    "FullName": "Deontae Cruickshank",
    "DirectPhone": "(372)746-8857 x000",
    "FormalName": "Barton, Smitham and McClure",
    "CountryId": 844,
    "ContactId": 651,
    "ContactName": "Roberts-Friesen",
    "Retired": 441,
    "Rank": 693,
    "ActiveInterests": 355,
    "ContactDepartment": "engineer one-to-one portals",
    "ContactCountryId": 715,
    "ContactOrgNr": "188358",
    "FaxPhone": "(046)741-1576 x05125",
    "MobilePhone": "(180)556-1354 x28647",
    "ContactPhone": "818.238.0648 x8431",
    "AssociateName": "Turner Inc and Sons",
    "AssociateId": 321,
    "UsePersonAddress": true,
    "ContactFax": "accusantium",
    "Kanafname": "quis",
    "Kanalname": "ipsam",
    "Post1": "minima",
    "Post2": "qui",
    "Post3": "necessitatibus",
    "EmailName": "susana@monahan.com",
    "ContactFullName": "Kaley Daniel",
    "ActiveErpLinks": 835,
    "TicketPriorityId": 397,
    "SupportLanguageId": 72,
    "SupportAssociateId": 648,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 453
      }
    }
  },
  "Currency": {
    "Id": 258,
    "Value": "quod",
    "Tooltip": "voluptatem",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 929
      }
    }
  },
  "Competitor": {
    "Id": 617,
    "Value": "vitae",
    "Tooltip": "illo",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 619
      }
    }
  },
  "Credited": {
    "Id": 575,
    "Value": "occaecati",
    "Tooltip": "nam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 966
      }
    }
  },
  "Rating": {
    "Id": 632,
    "Value": "quidem",
    "Tooltip": "laborum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 400
      }
    }
  },
  "Reason": {
    "Id": 447,
    "Value": "aut",
    "Tooltip": "excepturi",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 389
      }
    }
  },
  "Source": {
    "Id": 459,
    "Value": "dolor",
    "Tooltip": "quisquam",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 769
      }
    }
  },
  "Status": "Lost",
  "Saledate": "1995-05-11T18:25:50.99326+02:00",
  "Amount": 23730.647999999997,
  "SaleId": 888,
  "Earning": 18860.412,
  "EarningPercent": 8236.152,
  "Heading": "aspernatur",
  "Number": "370299",
  "Probability": 55,
  "CreatedDate": "2012-07-30T18:25:50.99326+02:00",
  "UpdatedDate": "2000-11-16T18:25:50.99326+01:00",
  "Completed": "Completed",
  "ActiveLinks": 286,
  "Links": [
    {
      "EntityName": "Turner-Macejkovic",
      "Id": 647,
      "Description": "Re-engineered national functionalities",
      "ExtraInfo": "quae",
      "LinkId": 466,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 108
        }
      }
    }
  ],
  "NextDueDate": "2003-05-10T18:25:50.99326+02:00",
  "Postit": "consequatur",
  "SaleType": {
    "Id": 483,
    "Value": "eveniet",
    "Tooltip": "rerum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 737
      }
    }
  },
  "ReasonSold": {
    "Id": 413,
    "Value": "quo",
    "Tooltip": "quae",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 54
      }
    }
  },
  "ReasonStalled": {
    "Id": 818,
    "Value": "unde",
    "Tooltip": "dicta",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 424
      }
    }
  },
  "ReopenDate": "2014-04-12T18:25:50.99326+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "VonRueden, Ziemann and Jacobson",
      "Comment": "nobis",
      "StakeholderRoleId": 860,
      "CountryId": 224,
      "PersonId": 975,
      "EmailDescription": "rick@okonweber.name",
      "EmailId": 273,
      "EmailAddress": "kirk@johnsnader.name",
      "PhoneId": 691,
      "ContactName": "Stoltenberg Inc and Sons",
      "ContactId": 819,
      "SaleId": 88,
      "Mrmrs": "ex",
      "Firstname": "Blaise",
      "MiddleName": "Collins, Murazik and Balistreri",
      "Lastname": "Schumm",
      "SaleStakeholderId": 419,
      "Rank": 647,
      "Phone": "(714)501-4353 x710",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 713
        }
      }
    }
  ],
  "ActiveErpLinks": 230,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Liam Hettinger"
  },
  "ExtraFields": {
    "ExtraFields1": "non",
    "ExtraFields2": "voluptates"
  },
  "CustomFields": {
    "CustomFields1": "at",
    "CustomFields2": "sunt"
  },
  "PublishEventDate": "2005-08-11T18:25:50.9952607+02:00",
  "PublishTo": "2015-08-09T18:25:50.9952607+02:00",
  "PublishFrom": "2017-05-09T18:25:50.9952607+02:00",
  "IsPublished": true,
  "VisibleFor": [
    {
      "VisibleId": 679,
      "Visibility": "All",
      "DisplayValue": "eligendi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 157
        }
      }
    },
    {
      "VisibleId": 679,
      "Visibility": "All",
      "DisplayValue": "eligendi",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 157
        }
      }
    }
  ],
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
      "FieldType": "System.Int32",
      "FieldLength": 590
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```