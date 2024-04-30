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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "ContactId": 933,
  "Name": "Wehner Inc and Sons",
  "Department": "",
  "OrgNr": "1285740",
  "Number1": "1822034",
  "Number2": "726243",
  "UpdatedDate": "2011-06-19T11:44:41.8359334+02:00",
  "CreatedDate": "2011-01-11T11:44:41.8359334+01:00",
  "Emails": [
    {
      "Value": "modi",
      "StrippedValue": "iste",
      "Description": "Switchable scalable concept"
    },
    {
      "Value": "modi",
      "StrippedValue": "iste",
      "Description": "Switchable scalable concept"
    }
  ],
  "Interests": [
    {
      "Id": 112,
      "Name": "Stiedemann, Hermann and Mueller",
      "ToolTip": "Ut amet.",
      "Deleted": false,
      "Rank": 594,
      "Type": "consequatur",
      "ColorBlock": 415,
      "IconHint": "rerum",
      "Selected": true,
      "LastChanged": "2022-01-15T11:44:41.8359334+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nobis",
      "StyleHint": "fugit",
      "Hidden": false,
      "FullName": "Mellie O'Connell"
    }
  ],
  "Urls": [
    {
      "Value": "iste",
      "StrippedValue": "doloremque",
      "Description": "Front-line global architecture"
    },
    {
      "Value": "iste",
      "StrippedValue": "doloremque",
      "Description": "Front-line global architecture"
    }
  ],
  "Phones": [
    {
      "Value": "sed",
      "StrippedValue": "provident",
      "Description": "Organized directional groupware"
    },
    {
      "Value": "sed",
      "StrippedValue": "provident",
      "Description": "Organized directional groupware"
    }
  ],
  "Faxes": [
    {
      "Value": "asperiores",
      "StrippedValue": "molestias",
      "Description": "Programmable hybrid matrices"
    },
    {
      "Value": "asperiores",
      "StrippedValue": "molestias",
      "Description": "Programmable hybrid matrices"
    }
  ],
  "Description": "Stand-alone analyzing functionalities",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "debitis",
      "PersonId": 92,
      "Mrmrs": "ipsum",
      "Firstname": "Diego",
      "Lastname": "Robel",
      "MiddleName": "Erdman, Kshlerin and Mayert",
      "Title": "eum",
      "Description": "Synchronised modular archive",
      "Email": "aurelie@donnelly.us",
      "FullName": "Mrs. Billy Bashirian",
      "DirectPhone": "1-690-477-6481",
      "FormalName": "Bauch, Kertzmann and Walter",
      "CountryId": 925,
      "ContactId": 245,
      "ContactName": "Mertz, Greenholt and Harris",
      "Retired": 435,
      "Rank": 868,
      "ActiveInterests": 502,
      "ContactDepartment": "",
      "ContactCountryId": 190,
      "ContactOrgNr": "1773966",
      "FaxPhone": "1-096-086-8615 x609",
      "MobilePhone": "(696)895-9611 x1657",
      "ContactPhone": "1-511-925-0753",
      "AssociateName": "Rutherford-Goodwin",
      "AssociateId": 662,
      "UsePersonAddress": true,
      "ContactFax": "quis",
      "Kanafname": "aut",
      "Kanalname": "rerum",
      "Post1": "voluptas",
      "Post2": "aut",
      "Post3": "voluptates",
      "EmailName": "margaretta_kulas@smithsmith.info",
      "ContactFullName": "Ada Huels",
      "ActiveErpLinks": 858,
      "TicketPriorityId": 670,
      "SupportLanguageId": 660,
      "SupportAssociateId": 584,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "quisquam",
  "Xstop": false,
  "ActiveInterests": 323,
  "GroupId": 145,
  "ActiveStatusMonitorId": 501,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 475,
  "DbiAgentId": 486,
  "DbiLastSyncronized": "2007-04-16T11:44:41.8359334+02:00",
  "DbiKey": "enim",
  "DbiLastModified": "2017-09-04T11:44:41.8359334+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 905,
  "ActiveErpLinks": 933,
  "BounceEmails": [
    "lorenzo_mertz@hodkiewicz.ca",
    "reed@huels.biz"
  ],
  "Domains": [
    "soluta",
    "voluptates"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "1132412647",
    "SuperOffice:2": "143828681"
  },
  "ExtraFields": {
    "ExtraFields1": "impedit",
    "ExtraFields2": "quae"
  },
  "CustomFields": {
    "CustomFields1": "sit",
    "CustomFields2": "eos"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "natus",
  "2": "et"
}
```