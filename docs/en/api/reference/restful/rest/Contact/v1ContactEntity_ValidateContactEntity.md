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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 787,
  "Name": "Bartoletti-Hodkiewicz",
  "Department": "",
  "OrgNr": "1819262",
  "Number1": "687138",
  "Number2": "827282",
  "UpdatedDate": "2021-06-03T13:38:17.2649715+02:00",
  "CreatedDate": "2009-08-22T13:38:17.2649715+02:00",
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "exercitationem",
      "Description": "Cloned stable focus group"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "exercitationem",
      "Description": "Cloned stable focus group"
    }
  ],
  "Interests": [
    {
      "Id": 649,
      "Name": "Barrows Group",
      "ToolTip": "Qui culpa voluptas officia nihil.",
      "Deleted": true,
      "Rank": 72,
      "Type": "odio",
      "ColorBlock": 374,
      "IconHint": "occaecati",
      "Selected": false,
      "LastChanged": "2017-02-06T13:38:17.2649715+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolor",
      "StyleHint": "placeat",
      "Hidden": false,
      "FullName": "Paris Ashlynn Schiller DVM"
    }
  ],
  "Urls": [
    {
      "Value": "dolor",
      "StrippedValue": "officia",
      "Description": "Implemented secondary ability"
    },
    {
      "Value": "dolor",
      "StrippedValue": "officia",
      "Description": "Implemented secondary ability"
    }
  ],
  "Phones": [
    {
      "Value": "ipsa",
      "StrippedValue": "et",
      "Description": "Digitized client-driven budgetary management"
    },
    {
      "Value": "ipsa",
      "StrippedValue": "et",
      "Description": "Digitized client-driven budgetary management"
    }
  ],
  "Faxes": [
    {
      "Value": "tempore",
      "StrippedValue": "alias",
      "Description": "Realigned client-driven process improvement"
    },
    {
      "Value": "tempore",
      "StrippedValue": "alias",
      "Description": "Realigned client-driven process improvement"
    }
  ],
  "Description": "Public-key holistic knowledge user",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "ut",
      "PersonId": 504,
      "Mrmrs": "est",
      "Firstname": "Bethany",
      "Lastname": "Schultz",
      "MiddleName": "Waters, Hammes and Kris",
      "Title": "ea",
      "Description": "Persistent mission-critical hardware",
      "Email": "rebecca@ferry.uk",
      "FullName": "Dr. Laverne Lisette Mitchell PhD",
      "DirectPhone": "(734)301-6127 x905",
      "FormalName": "Armstrong, Rosenbaum and Kling",
      "CountryId": 286,
      "ContactId": 785,
      "ContactName": "Lynch, O'Conner and Ferry",
      "Retired": 378,
      "Rank": 607,
      "ActiveInterests": 507,
      "ContactDepartment": "",
      "ContactCountryId": 492,
      "ContactOrgNr": "1622048",
      "FaxPhone": "1-756-330-8579 x820",
      "MobilePhone": "017.685.3532 x82658",
      "ContactPhone": "(170)964-1922 x35353",
      "AssociateName": "Spencer-Brekke",
      "AssociateId": 26,
      "UsePersonAddress": true,
      "ContactFax": "aut",
      "Kanafname": "nostrum",
      "Kanalname": "ab",
      "Post1": "est",
      "Post2": "adipisci",
      "Post3": "sed",
      "EmailName": "haley@king.com",
      "ContactFullName": "Ezra Marvin",
      "ActiveErpLinks": 399,
      "TicketPriorityId": 447,
      "SupportLanguageId": 420,
      "SupportAssociateId": 966,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": true,
  "Kananame": "tempore",
  "Xstop": false,
  "ActiveInterests": 667,
  "GroupId": 297,
  "ActiveStatusMonitorId": 956,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 136,
  "DbiAgentId": 305,
  "DbiLastSyncronized": "2009-02-10T13:38:17.2649715+01:00",
  "DbiKey": "architecto",
  "DbiLastModified": "2012-06-11T13:38:17.2649715+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 42,
  "ActiveErpLinks": 352,
  "BounceEmails": [
    "oswald.kozey@okunevaprohaska.info",
    "lenna_treutel@volkman.co.uk"
  ],
  "Domains": [
    "voluptatum",
    "optio"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "perferendis",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "quo",
    "CustomFields2": "doloribus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "dolores",
  "2": "earum"
}
```