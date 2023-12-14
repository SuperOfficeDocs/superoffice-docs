---
title: POST Contact/Validate
uid: v1ContactEntity_ValidateContactEntity
generated: true
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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "ContactId": 44,
  "Name": "Mertz-Hintz",
  "Department": "",
  "OrgNr": "1444658",
  "Number1": "1149551",
  "Number2": "929358",
  "UpdatedDate": "2019-12-31T13:57:18.6534365+01:00",
  "CreatedDate": "2023-02-07T13:57:18.6534365+01:00",
  "Emails": [
    {
      "Value": "sed",
      "StrippedValue": "vel",
      "Description": "Automated real-time task-force"
    },
    {
      "Value": "sed",
      "StrippedValue": "vel",
      "Description": "Automated real-time task-force"
    }
  ],
  "Interests": [
    {
      "Id": 656,
      "Name": "Sanford, Mann and Steuber",
      "ToolTip": "Sit quo perferendis praesentium nulla mollitia.",
      "Deleted": false,
      "Rank": 190,
      "Type": "qui",
      "ColorBlock": 259,
      "IconHint": "fugiat",
      "Selected": false,
      "LastChanged": "2010-11-09T13:57:18.6534365+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "odit",
      "StyleHint": "debitis",
      "Hidden": false,
      "FullName": "Mrs. Rhea Isai Gutmann"
    }
  ],
  "Urls": [
    {
      "Value": "quidem",
      "StrippedValue": "omnis",
      "Description": "Fundamental 24/7 parallelism"
    },
    {
      "Value": "quidem",
      "StrippedValue": "omnis",
      "Description": "Fundamental 24/7 parallelism"
    }
  ],
  "Phones": [
    {
      "Value": "explicabo",
      "StrippedValue": "aut",
      "Description": "Ameliorated foreground function"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "aut",
      "Description": "Ameliorated foreground function"
    }
  ],
  "Faxes": [
    {
      "Value": "atque",
      "StrippedValue": "consequuntur",
      "Description": "Public-key empowering throughput"
    },
    {
      "Value": "atque",
      "StrippedValue": "consequuntur",
      "Description": "Public-key empowering throughput"
    }
  ],
  "Description": "Focused uniform attitude",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "voluptatem",
      "PersonId": 178,
      "Mrmrs": "inventore",
      "Firstname": "Wade",
      "Lastname": "Fritsch",
      "MiddleName": "Wisozk Inc and Sons",
      "Title": "voluptatibus",
      "Description": "Implemented didactic product",
      "Email": "jany.jones@ebert.biz",
      "FullName": "Houston Runolfsson",
      "DirectPhone": "(259)605-3300 x1992",
      "FormalName": "Kilback, Franecki and Block",
      "CountryId": 48,
      "ContactId": 997,
      "ContactName": "Dooley Group",
      "Retired": 779,
      "Rank": 4,
      "ActiveInterests": 158,
      "ContactDepartment": "",
      "ContactCountryId": 48,
      "ContactOrgNr": "925168",
      "FaxPhone": "(813)545-9773 x753",
      "MobilePhone": "343-573-3930 x34697",
      "ContactPhone": "048-106-9569 x283",
      "AssociateName": "Koepp Inc and Sons",
      "AssociateId": 573,
      "UsePersonAddress": false,
      "ContactFax": "possimus",
      "Kanafname": "eaque",
      "Kanalname": "debitis",
      "Post1": "laboriosam",
      "Post2": "iure",
      "Post3": "autem",
      "EmailName": "myrtis@greenholt.us",
      "ContactFullName": "Jaclyn Ankunding",
      "ActiveErpLinks": 479,
      "TicketPriorityId": 788,
      "SupportLanguageId": 20,
      "SupportAssociateId": 413,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "molestias",
  "Xstop": false,
  "ActiveInterests": 493,
  "GroupId": 648,
  "ActiveStatusMonitorId": 617,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 280,
  "DbiAgentId": 274,
  "DbiLastSyncronized": "2013-01-23T13:57:18.669059+01:00",
  "DbiKey": "quasi",
  "DbiLastModified": "2001-02-19T13:57:18.669059+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 970,
  "ActiveErpLinks": 572,
  "BounceEmails": [
    "madeline_gusikowski@okunevaschneider.biz",
    "rahul_koelpin@hartmann.com"
  ],
  "Domains": [
    "molestias",
    "molestias"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Larissa Gusikowski"
  },
  "ExtraFields": {
    "ExtraFields1": "expedita",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "placeat",
    "CustomFields2": "eveniet"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "alias",
  "2": "doloremque"
}
```