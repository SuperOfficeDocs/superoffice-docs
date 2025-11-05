---
title: POST Contact/Validate
uid: v1ContactEntity_ValidateContactEntity
generated: true
content_type: reference
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
  "ContactId": 977,
  "Name": "Kuhlman, Trantow and Price",
  "Department": "generate visionary architectures",
  "OrgNr": "544137",
  "Number1": "905973",
  "Number2": "775871",
  "UpdatedDate": "2007-08-24T02:30:52.4911666+02:00",
  "CreatedDate": "2014-01-19T02:30:52.4911666+01:00",
  "Emails": [
    {
      "Value": "sit",
      "StrippedValue": "dolorem",
      "Description": "Operative discrete system engine"
    },
    {
      "Value": "sit",
      "StrippedValue": "dolorem",
      "Description": "Operative discrete system engine"
    }
  ],
  "Interests": [
    {
      "Id": 158,
      "Name": "Wuckert Group",
      "ToolTip": "Commodi est atque qui tenetur.",
      "Deleted": false,
      "Rank": 462,
      "Type": "temporibus",
      "ColorBlock": 728,
      "IconHint": "vero",
      "Selected": false,
      "LastChanged": "2001-09-15T02:30:52.4911666+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "impedit",
      "StyleHint": "libero",
      "Hidden": false,
      "FullName": "Olga Hermiston"
    }
  ],
  "Urls": [
    {
      "Value": "fugiat",
      "StrippedValue": "sit",
      "Description": "Stand-alone directional workforce"
    },
    {
      "Value": "fugiat",
      "StrippedValue": "sit",
      "Description": "Stand-alone directional workforce"
    }
  ],
  "Phones": [
    {
      "Value": "maxime",
      "StrippedValue": "quidem",
      "Description": "Optimized content-based software"
    },
    {
      "Value": "maxime",
      "StrippedValue": "quidem",
      "Description": "Optimized content-based software"
    }
  ],
  "Faxes": [
    {
      "Value": "fugiat",
      "StrippedValue": "iure",
      "Description": "Re-engineered client-driven function"
    },
    {
      "Value": "fugiat",
      "StrippedValue": "iure",
      "Description": "Re-engineered client-driven function"
    }
  ],
  "Description": "Streamlined object-oriented array",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "consequuntur",
      "PersonId": 534,
      "Mrmrs": "perspiciatis",
      "Firstname": "Destany",
      "Lastname": "Becker",
      "MiddleName": "Schuster, Walker and Fahey",
      "Title": "sed",
      "Description": "Compatible radical emulation",
      "Email": "flo@torp.name",
      "FullName": "Stephen Johnpaul Terry III",
      "DirectPhone": "1-205-900-7778 x60962",
      "FormalName": "Mosciski, Lueilwitz and Stanton",
      "CountryId": 939,
      "ContactId": 921,
      "ContactName": "Hilpert LLC",
      "Retired": 628,
      "Rank": 627,
      "ActiveInterests": 945,
      "ContactDepartment": "",
      "ContactCountryId": 952,
      "ContactOrgNr": "1141293",
      "FaxPhone": "005-989-5201 x3741",
      "MobilePhone": "563.270.1563",
      "ContactPhone": "194.068.1706 x451",
      "AssociateName": "Kassulke, White and Botsford",
      "AssociateId": 767,
      "UsePersonAddress": true,
      "ContactFax": "porro",
      "Kanafname": "architecto",
      "Kanalname": "consequatur",
      "Post1": "eius",
      "Post2": "ea",
      "Post3": "rerum",
      "EmailName": "juvenal@abernathy.biz",
      "ContactFullName": "Electa Williamson",
      "ActiveErpLinks": 673,
      "TicketPriorityId": 87,
      "SupportLanguageId": 687,
      "SupportAssociateId": 897,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1604135"
    }
  ],
  "NoMailing": false,
  "Kananame": "accusantium",
  "Xstop": true,
  "ActiveInterests": 971,
  "GroupId": 844,
  "ActiveStatusMonitorId": 329,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 996,
  "DbiAgentId": 59,
  "DbiLastSyncronized": "2012-05-09T02:30:52.4911666+02:00",
  "DbiKey": "fugiat",
  "DbiLastModified": "2025-05-21T02:30:52.4911666+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 791,
  "ActiveErpLinks": 240,
  "BounceEmails": [
    "grover@bashirian.uk",
    "matt.sporer@rau.com"
  ],
  "Domains": [
    "consectetur",
    "occaecati"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Esperanza Stan Barton Jr.",
    "SuperOffice:2": "Kole Okuneva"
  },
  "ExtraFields": {
    "ExtraFields1": "quod",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "repudiandae"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "laudantium",
  "2": "consequatur"
}
```