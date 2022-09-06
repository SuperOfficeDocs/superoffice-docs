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
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response: object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: object

## Sample request

```http!
POST /api/v1/Contact/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 516,
  "Name": "Hickle, Ankunding and Johnson",
  "Department": "",
  "OrgNr": "938332",
  "Number1": "431073",
  "Number2": "920559",
  "UpdatedDate": "2003-05-17T11:10:52.717146+02:00",
  "CreatedDate": "2005-06-24T11:10:52.717146+02:00",
  "Emails": [
    {
      "Value": "illum",
      "StrippedValue": "dolor",
      "Description": "Integrated tangible access"
    },
    {
      "Value": "illum",
      "StrippedValue": "dolor",
      "Description": "Integrated tangible access"
    }
  ],
  "Interests": [
    {
      "Id": 408,
      "Name": "Braun, DuBuque and Kulas",
      "ToolTip": "Qui ratione voluptatem quod velit esse.",
      "Deleted": false,
      "Rank": 153,
      "Type": "itaque",
      "ColorBlock": 685,
      "IconHint": "est",
      "Selected": false,
      "LastChanged": "2006-03-31T11:10:52.717146+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatibus",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Abdiel Wuckert"
    }
  ],
  "Urls": [
    {
      "Value": "vero",
      "StrippedValue": "quo",
      "Description": "Customizable methodical matrices"
    },
    {
      "Value": "vero",
      "StrippedValue": "quo",
      "Description": "Customizable methodical matrices"
    }
  ],
  "Phones": [
    {
      "Value": "et",
      "StrippedValue": "qui",
      "Description": "Streamlined system-worthy application"
    },
    {
      "Value": "et",
      "StrippedValue": "qui",
      "Description": "Streamlined system-worthy application"
    }
  ],
  "Faxes": [
    {
      "Value": "eum",
      "StrippedValue": "odio",
      "Description": "Universal cohesive strategy"
    },
    {
      "Value": "eum",
      "StrippedValue": "odio",
      "Description": "Universal cohesive strategy"
    }
  ],
  "Description": "Optional human-resource approach",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "tenetur",
      "PersonId": 787,
      "Mrmrs": "quo",
      "Firstname": "Wilbert",
      "Lastname": "Becker",
      "MiddleName": "Simonis-Runolfsdottir",
      "Title": "quia",
      "Description": "Balanced interactive throughput",
      "Email": "ted@windlerkessler.info",
      "FullName": "Alphonso Morar",
      "DirectPhone": "(668)706-5445 x857",
      "FormalName": "Schamberger Group",
      "CountryId": 672,
      "ContactId": 967,
      "ContactName": "Feil-Kuhlman",
      "Retired": 96,
      "Rank": 392,
      "ActiveInterests": 815,
      "ContactDepartment": "",
      "ContactCountryId": 981,
      "ContactOrgNr": "1074172",
      "FaxPhone": "467.118.1515",
      "MobilePhone": "(276)668-9096 x29054",
      "ContactPhone": "1-843-161-4316",
      "AssociateName": "Medhurst Inc and Sons",
      "AssociateId": 263,
      "UsePersonAddress": false,
      "ContactFax": "sunt",
      "Kanafname": "aut",
      "Kanalname": "rem",
      "Post1": "itaque",
      "Post2": "explicabo",
      "Post3": "laudantium",
      "EmailName": "katelynn@conroymoen.us",
      "ContactFullName": "Reilly Adams",
      "ActiveErpLinks": 436,
      "TicketPriorityId": 730,
      "SupportLanguageId": 178,
      "SupportAssociateId": 564,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "optio",
  "Xstop": true,
  "ActiveInterests": 43,
  "GroupId": 482,
  "ActiveStatusMonitorId": 581,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 431,
  "DbiAgentId": 630,
  "DbiLastSyncronized": "1999-10-27T11:10:52.7241452+02:00",
  "DbiKey": "enim",
  "DbiLastModified": "2012-09-17T11:10:52.7241452+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 327,
  "ActiveErpLinks": 816,
  "BounceEmails": [
    "aryanna_rau@gutmannlangworth.info",
    "francisca_bins@stoltenberg.us"
  ],
  "Domains": [
    "quis",
    "dolor"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Aniya Macejkovic",
    "SuperOffice:2": "Albin Olson"
  },
  "ExtraFields": {
    "ExtraFields1": "quam",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "enim"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "maxime",
  "2": "cum"
}
```
