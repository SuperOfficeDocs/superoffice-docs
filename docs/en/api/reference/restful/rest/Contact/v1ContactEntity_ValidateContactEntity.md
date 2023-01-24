---
title: POST Contact/Validate
uid: v1ContactEntity_ValidateContactEntity
---

# POST Contact/Validate

```http
POST /api/v1/Contact/Validate
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

## Request Body: contactEntity 

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Contact/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 932,
  "Name": "Gorczany-Feest",
  "Department": "",
  "OrgNr": "973546",
  "Number1": "1395415",
  "Number2": "597791",
  "UpdatedDate": "2021-12-20T11:22:44.5382515+01:00",
  "CreatedDate": "2004-06-29T11:22:44.5382515+02:00",
  "Emails": [
    {
      "Value": "amet",
      "StrippedValue": "inventore",
      "Description": "Right-sized grid-enabled policy"
    },
    {
      "Value": "amet",
      "StrippedValue": "inventore",
      "Description": "Right-sized grid-enabled policy"
    }
  ],
  "Interests": [
    {
      "Id": 883,
      "Name": "Kreiger Group",
      "ToolTip": "Quia adipisci animi autem consequatur quis autem.",
      "Deleted": true,
      "Rank": 195,
      "Type": "ut",
      "ColorBlock": 503,
      "IconHint": "occaecati",
      "Selected": false,
      "LastChanged": "2009-10-13T11:22:44.5382515+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "eum",
      "Hidden": true,
      "FullName": "Talia Fahey"
    }
  ],
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "quia",
      "Description": "Compatible contextually-based matrix"
    },
    {
      "Value": "qui",
      "StrippedValue": "quia",
      "Description": "Compatible contextually-based matrix"
    }
  ],
  "Phones": [
    {
      "Value": "velit",
      "StrippedValue": "doloribus",
      "Description": "Self-enabling upward-trending software"
    },
    {
      "Value": "velit",
      "StrippedValue": "doloribus",
      "Description": "Self-enabling upward-trending software"
    }
  ],
  "Faxes": [
    {
      "Value": "expedita",
      "StrippedValue": "quaerat",
      "Description": "Horizontal fault-tolerant matrix"
    },
    {
      "Value": "expedita",
      "StrippedValue": "quaerat",
      "Description": "Horizontal fault-tolerant matrix"
    }
  ],
  "Description": "Business-focused 24/7 interface",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "laudantium",
      "PersonId": 44,
      "Mrmrs": "id",
      "Firstname": "Orrin",
      "Lastname": "King",
      "MiddleName": "Tillman-Moen",
      "Title": "iure",
      "Description": "Team-oriented homogeneous pricing structure",
      "Email": "monte@gerlachcole.com",
      "FullName": "Miss Steve Dare DDS",
      "DirectPhone": "403-310-1849 x55792",
      "FormalName": "Schmidt-Gislason",
      "CountryId": 405,
      "ContactId": 457,
      "ContactName": "Waelchi-Hettinger",
      "Retired": 10,
      "Rank": 726,
      "ActiveInterests": 374,
      "ContactDepartment": "",
      "ContactCountryId": 700,
      "ContactOrgNr": "817832",
      "FaxPhone": "1-392-929-4245 x0067",
      "MobilePhone": "442-000-7542 x35118",
      "ContactPhone": "237-488-6439 x6927",
      "AssociateName": "Rutherford LLC",
      "AssociateId": 210,
      "UsePersonAddress": false,
      "ContactFax": "iure",
      "Kanafname": "voluptatibus",
      "Kanalname": "fugiat",
      "Post1": "dolores",
      "Post2": "voluptas",
      "Post3": "eum",
      "EmailName": "frederic@hodkiewiczchristiansen.ca",
      "ContactFullName": "Kiera Ebert IV",
      "ActiveErpLinks": 503,
      "TicketPriorityId": 372,
      "SupportLanguageId": 698,
      "SupportAssociateId": 886,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "corrupti",
  "Xstop": true,
  "ActiveInterests": 18,
  "GroupId": 956,
  "ActiveStatusMonitorId": 726,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 42,
  "DbiAgentId": 73,
  "DbiLastSyncronized": "2019-03-25T11:22:44.5382515+01:00",
  "DbiKey": "esse",
  "DbiLastModified": "1999-11-25T11:22:44.5382515+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 252,
  "ActiveErpLinks": 900,
  "BounceEmails": [
    "alan_schaden@hettinger.name",
    "gracie@jacobs.co.uk"
  ],
  "Domains": [
    "velit",
    "sunt"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Kory Ralph Ortiz PhD",
    "SuperOffice:2": "Johan Stamm"
  },
  "ExtraFields": {
    "ExtraFields1": "possimus",
    "ExtraFields2": "vel"
  },
  "CustomFields": {
    "CustomFields1": "odio",
    "CustomFields2": "natus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ducimus",
  "2": "sit"
}
```