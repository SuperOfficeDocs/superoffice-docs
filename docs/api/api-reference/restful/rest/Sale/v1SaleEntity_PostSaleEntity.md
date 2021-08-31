---
title: POST Sale
id: v1SaleEntity_PostSaleEntity
---

# POST Sale

```http
POST /api/v1/Sale
```

Creates a new SaleEntity

Calls the Sale agent service SaveSaleEntity.





## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Sale?$select=name,department,category/id
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

## Request Body: newEntity  

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
| 200 | OK |

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
POST /api/v1/Sale
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 499,
    "StartDate": "2018-09-03T15:05:42.5906352+02:00",
    "EndDate": "1999-06-15T15:05:42.5906352+02:00",
    "Type": "BookingForChecklist",
    "Task": "asperiores",
    "AssociateFullName": "Trevion Williamson V",
    "ContactName": "Schroeder LLC",
    "Description": "Operative analyzing function",
    "PersonFullName": "Saige Wehner",
    "PersonId": 391,
    "ContactId": 857,
    "ProjectId": 830,
    "ProjectName": "Steuber, Wiegand and Carroll",
    "IsPublished": true,
    "AssociateId": 205,
    "ColorIndex": 171,
    "IsFree": false,
    "HasAlarm": true,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 544,
    "PriorityName": "Hickle-Wuckert",
    "TaskType": "Appointment",
    "IsBookingMain": false,
    "IsRecurrence": false,
    "IsBooking": false,
    "ActiveDate": "2008-08-07T15:05:42.5916352+02:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2011-03-10T15:05:42.5916352+01:00",
    "RecurringEndDate": "2011-07-06T15:05:42.5916352+02:00",
    "MotherId": 297,
    "AssignedBy": 757,
    "AssignedByFullName": "Vickie Considine Jr.",
    "RejectReason": "",
    "Location": "a",
    "AlarmLeadTime": "quasi",
    "SaleId": 515,
    "SaleName": "Runte Inc and Sons",
    "AssociateName": "Pfannerstill-Collier",
    "CreatedDate": "2020-01-12T15:05:42.5916352+01:00",
    "CreatedBy": "impedit",
    "CreatedByFullName": "Mariane Cormier",
    "CreatedByAssociateId": 312,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/"
  },
  "Associate": {
    "AssociateId": 380,
    "Name": "Conroy LLC",
    "PersonId": 539,
    "Rank": 356,
    "Tooltip": "fugiat",
    "Type": "AnonymousAssociate",
    "GroupIdx": 71,
    "FullName": "Ms. Kaci Leannon",
    "FormalName": "Connelly, Bahringer and Bernhard",
    "Deleted": false,
    "EjUserId": 115,
    "UserName": "Quigley-Kuhlman"
  },
  "UpdatedBy": {
    "AssociateId": 371,
    "Name": "Gottlieb-Prosacco",
    "PersonId": 261,
    "Rank": 663,
    "Tooltip": "beatae",
    "Type": "AnonymousAssociate",
    "GroupIdx": 651,
    "FullName": "Ludwig Kohler",
    "FormalName": "Jast LLC",
    "Deleted": false,
    "EjUserId": 418,
    "UserName": "Tremblay Inc and Sons"
  },
  "CreatedBy": {
    "AssociateId": 360,
    "Name": "Miller LLC",
    "PersonId": 385,
    "Rank": 571,
    "Tooltip": "est",
    "Type": "AnonymousAssociate",
    "GroupIdx": 199,
    "FullName": "Marco Rath DDS",
    "FormalName": "Gerhold, O'Conner and Smitham",
    "Deleted": true,
    "EjUserId": 981,
    "UserName": "Ward, Welch and Cruickshank"
  },
  "Contact": {
    "ContactId": 880,
    "Name": "Beer LLC",
    "OrgNr": "1551472",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "vel",
    "DirectPhone": "046-170-4454 x186",
    "AssociateId": 311,
    "CountryId": 493,
    "EmailAddress": "anna@bartonvon.co.uk",
    "Kananame": "voluptatem",
    "EmailAddressName": "magnolia@lang.name",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Jesus Simonis",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "veniam",
    "FullName": "Gianni McClure",
    "IsOwnerContact": true,
    "ActiveErpLinks": 964
  },
  "Project": {
    "ProjectId": 81,
    "Name": "Larson-Herman",
    "Description": "Networked zero tolerance support",
    "URL": "http://www.example.com/",
    "Type": "placeat",
    "AssociateId": 122,
    "AssociateFullName": "Rylan Carter",
    "TypeId": 334,
    "Updated": "1997-02-12T15:05:42.5946356+01:00",
    "StatusId": 353,
    "Status": "eum",
    "TextId": 242,
    "PublishTo": "2007-11-17T15:05:42.5946356+01:00",
    "PublishFrom": "2000-09-20T15:05:42.5946356+02:00",
    "IsPublished": false,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1237906",
    "ActiveErpLinks": 995
  },
  "SaleText": "nisi",
  "Person": {
    "Position": "rem",
    "PersonId": 549,
    "Mrmrs": "id",
    "Firstname": "Koby",
    "Lastname": "Morissette",
    "MiddleName": "Klein, Lubowitz and Blanda",
    "Title": "ducimus",
    "Description": "Reverse-engineered maximized process improvement",
    "Email": "kaley_hoeger@willmswatsica.com",
    "FullName": "Mrs. Wilson Donnelly",
    "DirectPhone": "1-603-457-0107 x243",
    "FormalName": "Schmeler-Labadie",
    "CountryId": 726,
    "ContactId": 795,
    "ContactName": "D'Amore, Schulist and Braun",
    "Retired": 951,
    "Rank": 272,
    "ActiveInterests": 573,
    "ContactDepartment": "",
    "ContactCountryId": 156,
    "ContactOrgNr": "904285",
    "FaxPhone": "(253)464-6178",
    "MobilePhone": "1-556-371-4162 x420",
    "ContactPhone": "(500)875-4785 x6086",
    "AssociateName": "Schiller LLC",
    "AssociateId": 997,
    "UsePersonAddress": false,
    "ContactFax": "dolore",
    "Kanafname": "magnam",
    "Kanalname": "eligendi",
    "Post1": "quidem",
    "Post2": "eligendi",
    "Post3": "porro",
    "EmailName": "glenna@collier.com",
    "ContactFullName": "Erna Barton",
    "ActiveErpLinks": 737,
    "TicketPriorityId": 714,
    "SupportLanguageId": 121,
    "SupportAssociateId": 757,
    "CategoryName": "VIP Customer"
  },
  "Currency": {
    "Id": 796,
    "Value": "illum",
    "Tooltip": "aut"
  },
  "Competitor": {
    "Id": 676,
    "Value": "qui",
    "Tooltip": "odio"
  },
  "Credited": {
    "Id": 135,
    "Value": "voluptatem",
    "Tooltip": "beatae"
  },
  "Rating": {
    "Id": 2,
    "Value": "eos",
    "Tooltip": "eos"
  },
  "Reason": {
    "Id": 329,
    "Value": "sequi",
    "Tooltip": "voluptas"
  },
  "Source": {
    "Id": 169,
    "Value": "alias",
    "Tooltip": "deserunt"
  },
  "Status": "Lost",
  "Saledate": "2000-10-22T15:05:42.595635+02:00",
  "Amount": 4152.55,
  "SaleId": 75,
  "Earning": 28168.392,
  "EarningPercent": 16578.86,
  "Heading": "ut",
  "Number": "957786",
  "Probability": 166,
  "CreatedDate": "1996-10-27T15:05:42.595635+01:00",
  "UpdatedDate": "1994-05-31T15:05:42.595635+02:00",
  "Completed": "Completed",
  "ActiveLinks": 2,
  "Links": [
    {
      "EntityName": "Hessel-Thompson",
      "Id": 920,
      "Description": "Function-based upward-trending matrix",
      "ExtraInfo": "aliquam",
      "LinkId": 429
    },
    {
      "EntityName": "Hessel-Thompson",
      "Id": 920,
      "Description": "Function-based upward-trending matrix",
      "ExtraInfo": "aliquam",
      "LinkId": 429
    }
  ],
  "NextDueDate": "2018-10-22T15:05:42.595635+02:00",
  "Postit": "dolore",
  "SaleType": {
    "Id": 20,
    "Value": "modi",
    "Tooltip": "repellat"
  },
  "ReasonSold": {
    "Id": 808,
    "Value": "quis",
    "Tooltip": "amet"
  },
  "ReasonStalled": {
    "Id": 376,
    "Value": "dolor",
    "Tooltip": "quia"
  },
  "ReopenDate": "1995-08-04T15:05:42.595635+02:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Johnson, Powlowski and Shanahan",
      "Comment": "labore",
      "StakeholderRoleId": 806,
      "CountryId": 573,
      "PersonId": 84,
      "EmailDescription": "marcelina@corkery.info",
      "EmailId": 488,
      "EmailAddress": "juana.waelchi@vandervortdickens.uk",
      "PhoneId": 631,
      "ContactName": "Daniel, Kuvalis and Hills",
      "ContactId": 149,
      "SaleId": 356,
      "Mrmrs": "nam",
      "Firstname": "Keaton",
      "MiddleName": "Jast Inc and Sons",
      "Lastname": "Parker",
      "SaleStakeholderId": 782,
      "Rank": 910,
      "Phone": "(471)027-4505 x0200"
    }
  ],
  "ActiveErpLinks": 510,
  "UserDefinedFields": {
    "SuperOffice:1": "917530561",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "quo",
    "ExtraFields2": "ipsam"
  },
  "CustomFields": {
    "CustomFields1": "atque",
    "CustomFields2": "rerum"
  },
  "PublishEventDate": "2011-02-21T15:05:42.5976324+01:00",
  "PublishTo": "2014-04-09T15:05:42.5976324+02:00",
  "PublishFrom": "1997-05-02T15:05:42.5976324+02:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 193,
      "Visibility": "All",
      "DisplayValue": "ipsa"
    },
    {
      "VisibleId": 193,
      "Visibility": "All",
      "DisplayValue": "ipsa"
    }
  ]
}
```

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "Appointment": {
    "AppointmentId": 954,
    "StartDate": "2017-05-08T15:05:42.6036324+02:00",
    "EndDate": "1994-12-23T15:05:42.6036324+01:00",
    "Type": "BookingForChecklist",
    "Task": "ducimus",
    "AssociateFullName": "Josianne Emmerich",
    "ContactName": "Strosin, Kulas and Littel",
    "Description": "Automated client-driven policy",
    "PersonFullName": "Joy Hahn",
    "PersonId": 887,
    "ContactId": 869,
    "ProjectId": 498,
    "ProjectName": "Rice, Hermann and Hyatt",
    "IsPublished": false,
    "AssociateId": 756,
    "ColorIndex": 295,
    "IsFree": false,
    "HasAlarm": false,
    "IsAlldayEvent": false,
    "Private": "PrivateGroup",
    "PriorityId": 555,
    "PriorityName": "Rippin Group",
    "TaskType": "Appointment",
    "IsBookingMain": true,
    "IsRecurrence": true,
    "IsBooking": true,
    "ActiveDate": "2009-02-24T15:05:42.6046324+01:00",
    "AssignmentStatus": "Assigning",
    "InvitationStatus": "Accepted",
    "BookingType": "None",
    "Completed": "Completed",
    "RecurringPattern": "Custom",
    "RecurringStartDate": "2017-08-22T15:05:42.6046324+02:00",
    "RecurringEndDate": "1997-06-28T15:05:42.6046324+02:00",
    "MotherId": 55,
    "AssignedBy": 711,
    "AssignedByFullName": "Tate Kreiger",
    "RejectReason": "",
    "Location": "neque",
    "AlarmLeadTime": "non",
    "SaleId": 582,
    "SaleName": "Runolfsdottir, Fahey and Kunze",
    "AssociateName": "Boehm LLC",
    "CreatedDate": "1994-07-14T15:05:42.6046324+02:00",
    "CreatedBy": "iusto",
    "CreatedByFullName": "Sheila Lakin",
    "CreatedByAssociateId": 31,
    "CautionWarning": "ExternalParticipantsDateTimeMismatch",
    "JoinVideomeetUrl": "http://www.example.com/",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 953
      }
    }
  },
  "Associate": {
    "AssociateId": 291,
    "Name": "Hirthe, Swaniawski and Fisher",
    "PersonId": 10,
    "Rank": 358,
    "Tooltip": "consequatur",
    "Type": "AnonymousAssociate",
    "GroupIdx": 664,
    "FullName": "Lois Hills",
    "FormalName": "Hessel-Nolan",
    "Deleted": true,
    "EjUserId": 298,
    "UserName": "Prohaska, Johns and Ratke",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 825
      }
    }
  },
  "UpdatedBy": {
    "AssociateId": 920,
    "Name": "Abshire, Lakin and Roob",
    "PersonId": 46,
    "Rank": 290,
    "Tooltip": "necessitatibus",
    "Type": "AnonymousAssociate",
    "GroupIdx": 896,
    "FullName": "Jennyfer Schroeder",
    "FormalName": "Gottlieb LLC",
    "Deleted": true,
    "EjUserId": 865,
    "UserName": "Langworth Inc and Sons",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 405
      }
    }
  },
  "CreatedBy": {
    "AssociateId": 415,
    "Name": "Strosin Group",
    "PersonId": 156,
    "Rank": 427,
    "Tooltip": "amet",
    "Type": "AnonymousAssociate",
    "GroupIdx": 991,
    "FullName": "Brady Ullrich",
    "FormalName": "Hayes-Cole",
    "Deleted": false,
    "EjUserId": 816,
    "UserName": "Frami, Schneider and Trantow",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "facilitate compelling interfaces"
        },
        "FieldType": "System.String",
        "FieldLength": 309
      }
    }
  },
  "Contact": {
    "ContactId": 845,
    "Name": "Daniel Inc and Sons",
    "OrgNr": "982540",
    "Department": "",
    "URL": "http://www.example.com/",
    "City": "voluptates",
    "DirectPhone": "482.318.2338",
    "AssociateId": 386,
    "CountryId": 532,
    "EmailAddress": "armando_metz@rosenbaumrempel.ca",
    "Kananame": "voluptas",
    "EmailAddressName": "serena@ryandickens.info",
    "URLName": "http://www.example.com/",
    "AssociateFullName": "Stanton Gutkowski",
    "BusinessName": "Information Technology",
    "CategoryName": "VIP Customer",
    "CountryName": "Sokovia",
    "Address": {},
    "FormattedAddress": "quidem",
    "FullName": "Earline Hackett",
    "IsOwnerContact": true,
    "ActiveErpLinks": 521,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 606
      }
    }
  },
  "Project": {
    "ProjectId": 250,
    "Name": "Walker Inc and Sons",
    "Description": "Horizontal asynchronous Graphic Interface",
    "URL": "http://www.example.com/",
    "Type": "aut",
    "AssociateId": 281,
    "AssociateFullName": "Edmond Donnelly",
    "TypeId": 627,
    "Updated": "1998-07-19T15:05:42.6076327+02:00",
    "StatusId": 431,
    "Status": "dignissimos",
    "TextId": 731,
    "PublishTo": "2009-09-18T15:05:42.6076327+02:00",
    "PublishFrom": "1999-09-27T15:05:42.6076327+02:00",
    "IsPublished": true,
    "URLName": "http://www.example.com/",
    "ProjectNumber": "1211847",
    "ActiveErpLinks": 895,
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 101
      }
    }
  },
  "SaleText": "atque",
  "Person": {
    "Position": "et",
    "PersonId": 591,
    "Mrmrs": "accusantium",
    "Firstname": "Velva",
    "Lastname": "Goyette",
    "MiddleName": "Botsford-Jacobi",
    "Title": "temporibus",
    "Description": "Ameliorated bandwidth-monitored forecast",
    "Email": "madilyn@bernhardritchie.info",
    "FullName": "Marta Schmitt",
    "DirectPhone": "423-826-5071 x75074",
    "FormalName": "Bartell-Nader",
    "CountryId": 38,
    "ContactId": 2,
    "ContactName": "Maggio-Kutch",
    "Retired": 545,
    "Rank": 211,
    "ActiveInterests": 145,
    "ContactDepartment": "utilize end-to-end systems",
    "ContactCountryId": 16,
    "ContactOrgNr": "1596637",
    "FaxPhone": "457.475.1628 x5555",
    "MobilePhone": "277.571.8776 x155",
    "ContactPhone": "118-722-7547 x37834",
    "AssociateName": "Medhurst, Larkin and Langosh",
    "AssociateId": 437,
    "UsePersonAddress": true,
    "ContactFax": "sequi",
    "Kanafname": "voluptatibus",
    "Kanalname": "harum",
    "Post1": "maiores",
    "Post2": "et",
    "Post3": "cupiditate",
    "EmailName": "audrey_mccullough@hintz.ca",
    "ContactFullName": "Albina Flatley",
    "ActiveErpLinks": 952,
    "TicketPriorityId": 201,
    "SupportLanguageId": 580,
    "SupportAssociateId": 283,
    "CategoryName": "VIP Customer",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": "benchmark scalable channels"
        },
        "FieldType": "System.String",
        "FieldLength": 279
      }
    }
  },
  "Currency": {
    "Id": 965,
    "Value": "quo",
    "Tooltip": "facilis",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 184
      }
    }
  },
  "Competitor": {
    "Id": 395,
    "Value": "eos",
    "Tooltip": "est",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 145
      }
    }
  },
  "Credited": {
    "Id": 662,
    "Value": "id",
    "Tooltip": "sint",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 579
      }
    }
  },
  "Rating": {
    "Id": 95,
    "Value": "sit",
    "Tooltip": "suscipit",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 766
      }
    }
  },
  "Reason": {
    "Id": 955,
    "Value": "est",
    "Tooltip": "hic",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 621
      }
    }
  },
  "Source": {
    "Id": 60,
    "Value": "quidem",
    "Tooltip": "quia",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 411
      }
    }
  },
  "Status": "Lost",
  "Saledate": "1998-11-12T15:05:42.6096325+01:00",
  "Amount": 28284.35,
  "SaleId": 808,
  "Earning": 7054.634,
  "EarningPercent": 18531.342,
  "Heading": "iste",
  "Number": "289631",
  "Probability": 479,
  "CreatedDate": "1994-05-11T15:05:42.6096325+02:00",
  "UpdatedDate": "2017-10-23T15:05:42.6096325+02:00",
  "Completed": "Completed",
  "ActiveLinks": 743,
  "Links": [
    {
      "EntityName": "Stamm-Jast",
      "Id": 419,
      "Description": "Switchable holistic attitude",
      "ExtraInfo": "et",
      "LinkId": 415,
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.String",
          "FieldLength": 600
        }
      }
    }
  ],
  "NextDueDate": "2012-10-30T15:05:42.6096325+01:00",
  "Postit": "a",
  "SaleType": {
    "Id": 807,
    "Value": "qui",
    "Tooltip": "eos",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.Int32",
        "FieldLength": 431
      }
    }
  },
  "ReasonSold": {
    "Id": 396,
    "Value": "soluta",
    "Tooltip": "dolorum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 863
      }
    }
  },
  "ReasonStalled": {
    "Id": 477,
    "Value": "ut",
    "Tooltip": "earum",
    "TableRight": {},
    "FieldProperties": {
      "fieldName": {
        "FieldRight": {
          "Mask": "FULL",
          "Reason": ""
        },
        "FieldType": "System.String",
        "FieldLength": 394
      }
    }
  },
  "ReopenDate": "1997-11-05T15:05:42.6096325+01:00",
  "SaleStakeholders": [
    {
      "StakeholderRoleName": "Kessler, Williamson and Schneider",
      "Comment": "occaecati",
      "StakeholderRoleId": 193,
      "CountryId": 553,
      "PersonId": 288,
      "EmailDescription": "ole_turcotte@johns.info",
      "EmailId": 609,
      "EmailAddress": "payton.schulist@rippin.uk",
      "PhoneId": 423,
      "ContactName": "Oberbrunner LLC",
      "ContactId": 529,
      "SaleId": 28,
      "Mrmrs": "rerum",
      "Firstname": "Devon",
      "MiddleName": "Kemmer, Lowe and Bechtelar",
      "Lastname": "Stehr",
      "SaleStakeholderId": 431,
      "Rank": 368,
      "Phone": "206-122-7781 x5303",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 99
        }
      }
    }
  ],
  "ActiveErpLinks": 68,
  "UserDefinedFields": {
    "SuperOffice:1": "Nathan Welch I",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "iste",
    "ExtraFields2": "commodi"
  },
  "CustomFields": {
    "CustomFields1": "consectetur",
    "CustomFields2": "facilis"
  },
  "PublishEventDate": "2019-09-30T15:05:42.6106325+02:00",
  "PublishTo": "2013-11-20T15:05:42.6106325+01:00",
  "PublishFrom": "2017-02-12T15:05:42.6106325+01:00",
  "IsPublished": false,
  "VisibleFor": [
    {
      "VisibleId": 779,
      "Visibility": "All",
      "DisplayValue": "rerum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 598
        }
      }
    },
    {
      "VisibleId": 779,
      "Visibility": "All",
      "DisplayValue": "rerum",
      "TableRight": {},
      "FieldProperties": {
        "fieldName": {
          "FieldRight": {
            "Mask": "FULL",
            "Reason": ""
          },
          "FieldType": "System.Int32",
          "FieldLength": 598
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
      "FieldLength": 464
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```