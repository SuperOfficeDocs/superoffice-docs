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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 280,
  "Name": "Feeney Group",
  "Department": "",
  "OrgNr": "1136132",
  "Number1": "1308059",
  "Number2": "356456",
  "UpdatedDate": "2010-10-01T04:02:06.4316632+02:00",
  "CreatedDate": "1997-08-10T04:02:06.4316632+02:00",
  "Emails": [
    {
      "Value": "quo",
      "StrippedValue": "suscipit",
      "Description": "Streamlined client-driven secured line"
    },
    {
      "Value": "quo",
      "StrippedValue": "suscipit",
      "Description": "Streamlined client-driven secured line"
    }
  ],
  "Interests": [
    {
      "Id": 336,
      "Name": "Prohaska, Huels and Pacocha",
      "ToolTip": "Necessitatibus ducimus eum aliquam.",
      "Deleted": false,
      "Rank": 455,
      "Type": "aspernatur",
      "ColorBlock": 950,
      "IconHint": "ducimus",
      "Selected": false,
      "LastChanged": "2000-04-06T04:02:06.4316632+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatum",
      "StyleHint": "fugit",
      "Hidden": true,
      "FullName": "Earnestine McClure"
    }
  ],
  "Urls": [
    {
      "Value": "inventore",
      "StrippedValue": "fuga",
      "Description": "Team-oriented heuristic concept"
    },
    {
      "Value": "inventore",
      "StrippedValue": "fuga",
      "Description": "Team-oriented heuristic concept"
    }
  ],
  "Phones": [
    {
      "Value": "rem",
      "StrippedValue": "id",
      "Description": "Visionary coherent encoding"
    },
    {
      "Value": "rem",
      "StrippedValue": "id",
      "Description": "Visionary coherent encoding"
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "qui",
      "Description": "Organized context-sensitive structure"
    },
    {
      "Value": "non",
      "StrippedValue": "qui",
      "Description": "Organized context-sensitive structure"
    }
  ],
  "Description": "Decentralized interactive customer loyalty",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 183,
      "Mrmrs": "et",
      "Firstname": "Cordelia",
      "Lastname": "Bogisich",
      "MiddleName": "Effertz, Mante and Johns",
      "Title": "magnam",
      "Description": "Vision-oriented modular solution",
      "Email": "jovan_jaskolski@crona.name",
      "FullName": "Kiara Schaefer",
      "DirectPhone": "(566)584-1152",
      "FormalName": "Hayes, Hermiston and Conroy",
      "CountryId": 555,
      "ContactId": 652,
      "ContactName": "Abshire Inc and Sons",
      "Retired": 453,
      "Rank": 644,
      "ActiveInterests": 614,
      "ContactDepartment": "",
      "ContactCountryId": 38,
      "ContactOrgNr": "1627788",
      "FaxPhone": "(286)565-1803 x693",
      "MobilePhone": "(444)918-8600",
      "ContactPhone": "1-190-496-3861 x744",
      "AssociateName": "Huels, Ryan and Zboncak",
      "AssociateId": 741,
      "UsePersonAddress": true,
      "ContactFax": "molestiae",
      "Kanafname": "quos",
      "Kanalname": "quod",
      "Post1": "quia",
      "Post2": "fuga",
      "Post3": "sed",
      "EmailName": "josephine.brekke@monahanmorar.co.uk",
      "ContactFullName": "Rene Ericka Gibson III",
      "ActiveErpLinks": 590,
      "TicketPriorityId": 950,
      "SupportLanguageId": 375,
      "SupportAssociateId": 246,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "corrupti",
  "Xstop": true,
  "ActiveInterests": 423,
  "GroupId": 232,
  "ActiveStatusMonitorId": 306,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 622,
  "DbiAgentId": 614,
  "DbiLastSyncronized": "2000-10-12T04:02:06.4316632+02:00",
  "DbiKey": "quidem",
  "DbiLastModified": "2021-11-27T04:02:06.4316632+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 399,
  "ActiveErpLinks": 703,
  "BounceEmails": [
    "veronica.kessler@hellerhalvorson.uk",
    "kyra@collierjacobi.name"
  ],
  "Domains": [
    "fuga",
    "veritatis"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Veda Dicki",
    "SuperOffice:2": "Milton Cartwright V"
  },
  "ExtraFields": {
    "ExtraFields1": "eaque",
    "ExtraFields2": "minima"
  },
  "CustomFields": {
    "CustomFields1": "libero",
    "CustomFields2": "molestias"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "et",
  "2": "atque"
}
```