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
  "ContactId": 496,
  "Name": "Dare-Cassin",
  "Department": "",
  "OrgNr": "1176091",
  "Number1": "1033724",
  "Number2": "469529",
  "UpdatedDate": "2001-07-28T11:06:41.7540989+02:00",
  "CreatedDate": "2017-06-24T11:06:41.7540989+02:00",
  "Emails": [
    {
      "Value": "modi",
      "StrippedValue": "nihil",
      "Description": "Streamlined human-resource open system"
    },
    {
      "Value": "modi",
      "StrippedValue": "nihil",
      "Description": "Streamlined human-resource open system"
    }
  ],
  "Interests": [
    {
      "Id": 21,
      "Name": "Jacobi-Lang",
      "ToolTip": "Numquam rerum aut modi blanditiis.",
      "Deleted": true,
      "Rank": 805,
      "Type": "occaecati",
      "ColorBlock": 167,
      "IconHint": "expedita",
      "Selected": true,
      "LastChanged": "2010-02-07T11:06:41.7540989+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "nihil",
      "Hidden": false,
      "FullName": "Sigmund Waelchi"
    }
  ],
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "ea",
      "Description": "Quality-focused optimizing challenge"
    },
    {
      "Value": "est",
      "StrippedValue": "ea",
      "Description": "Quality-focused optimizing challenge"
    }
  ],
  "Phones": [
    {
      "Value": "vel",
      "StrippedValue": "et",
      "Description": "Configurable eco-centric array"
    },
    {
      "Value": "vel",
      "StrippedValue": "et",
      "Description": "Configurable eco-centric array"
    }
  ],
  "Faxes": [
    {
      "Value": "sed",
      "StrippedValue": "accusantium",
      "Description": "Devolved context-sensitive groupware"
    },
    {
      "Value": "sed",
      "StrippedValue": "accusantium",
      "Description": "Devolved context-sensitive groupware"
    }
  ],
  "Description": "Cross-group methodical collaboration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "officiis",
      "PersonId": 642,
      "Mrmrs": "laboriosam",
      "Firstname": "Kaia",
      "Lastname": "Runte",
      "MiddleName": "Cremin, Simonis and Flatley",
      "Title": "laudantium",
      "Description": "Total fresh-thinking superstructure",
      "Email": "rubie@shanahanparisian.biz",
      "FullName": "Jeffery Russel",
      "DirectPhone": "923-206-6690 x20819",
      "FormalName": "Rodriguez-Sporer",
      "CountryId": 87,
      "ContactId": 664,
      "ContactName": "Smith Group",
      "Retired": 699,
      "Rank": 265,
      "ActiveInterests": 714,
      "ContactDepartment": "",
      "ContactCountryId": 830,
      "ContactOrgNr": "937719",
      "FaxPhone": "091-229-1973 x48280",
      "MobilePhone": "(227)046-3701 x551",
      "ContactPhone": "1-517-876-5513",
      "AssociateName": "Kreiger, Bruen and Abernathy",
      "AssociateId": 452,
      "UsePersonAddress": false,
      "ContactFax": "in",
      "Kanafname": "perspiciatis",
      "Kanalname": "consectetur",
      "Post1": "quae",
      "Post2": "error",
      "Post3": "illo",
      "EmailName": "rasheed@mcglynn.uk",
      "ContactFullName": "Cristobal Hammes",
      "ActiveErpLinks": 355,
      "TicketPriorityId": 663,
      "SupportLanguageId": 32,
      "SupportAssociateId": 276,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "id",
  "Xstop": false,
  "ActiveInterests": 606,
  "GroupId": 287,
  "ActiveStatusMonitorId": 113,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 433,
  "DbiAgentId": 93,
  "DbiLastSyncronized": "2020-09-28T11:06:41.7540989+02:00",
  "DbiKey": "nam",
  "DbiLastModified": "2000-01-29T11:06:41.7540989+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 876,
  "ActiveErpLinks": 629,
  "BounceEmails": [
    "alfredo.torphy@dibbert.info",
    "jermey_ankunding@bradtke.com"
  ],
  "Domains": [
    "doloribus",
    "ut"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dr. Ephraim Wolff II"
  },
  "ExtraFields": {
    "ExtraFields1": "quaerat",
    "ExtraFields2": "exercitationem"
  },
  "CustomFields": {
    "CustomFields1": "voluptatem",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "ex",
  "2": "quo"
}
```