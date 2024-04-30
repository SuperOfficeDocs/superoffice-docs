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
  "ContactId": 195,
  "Name": "Deckow, Schmeler and Kulas",
  "Department": "",
  "OrgNr": "1384247",
  "Number1": "920333",
  "Number2": "1499323",
  "UpdatedDate": "2005-12-13T11:16:13.82385+01:00",
  "CreatedDate": "2010-02-15T11:16:13.82385+01:00",
  "Emails": [
    {
      "Value": "corrupti",
      "StrippedValue": "aut",
      "Description": "Open-architected upward-trending complexity"
    },
    {
      "Value": "corrupti",
      "StrippedValue": "aut",
      "Description": "Open-architected upward-trending complexity"
    }
  ],
  "Interests": [
    {
      "Id": 909,
      "Name": "Kirlin Inc and Sons",
      "ToolTip": "Sed ut dolores eaque maiores atque aut.",
      "Deleted": true,
      "Rank": 825,
      "Type": "accusantium",
      "ColorBlock": 589,
      "IconHint": "deleniti",
      "Selected": false,
      "LastChanged": "2004-07-28T11:16:13.82385+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "perspiciatis",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Miss Forrest Estel Runolfsson"
    }
  ],
  "Urls": [
    {
      "Value": "explicabo",
      "StrippedValue": "quia",
      "Description": "De-engineered eco-centric software"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "quia",
      "Description": "De-engineered eco-centric software"
    }
  ],
  "Phones": [
    {
      "Value": "quos",
      "StrippedValue": "natus",
      "Description": "Enterprise-wide coherent productivity"
    },
    {
      "Value": "quos",
      "StrippedValue": "natus",
      "Description": "Enterprise-wide coherent productivity"
    }
  ],
  "Faxes": [
    {
      "Value": "voluptatum",
      "StrippedValue": "similique",
      "Description": "Grass-roots zero administration protocol"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "similique",
      "Description": "Grass-roots zero administration protocol"
    }
  ],
  "Description": "Networked methodical knowledge user",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "aut",
      "PersonId": 28,
      "Mrmrs": "nisi",
      "Firstname": "Nola",
      "Lastname": "Herman",
      "MiddleName": "Grimes, Grant and Ziemann",
      "Title": "voluptatem",
      "Description": "Stand-alone needs-based structure",
      "Email": "santino@baumbachstanton.uk",
      "FullName": "Brycen Walter",
      "DirectPhone": "1-445-048-5009 x3744",
      "FormalName": "Reichert, Bailey and Beer",
      "CountryId": 298,
      "ContactId": 518,
      "ContactName": "Bradtke, Corwin and Beahan",
      "Retired": 993,
      "Rank": 891,
      "ActiveInterests": 812,
      "ContactDepartment": "",
      "ContactCountryId": 375,
      "ContactOrgNr": "1233093",
      "FaxPhone": "869.901.3214 x88963",
      "MobilePhone": "1-640-065-6959 x71277",
      "ContactPhone": "599-354-7692",
      "AssociateName": "Reilly Inc and Sons",
      "AssociateId": 590,
      "UsePersonAddress": false,
      "ContactFax": "modi",
      "Kanafname": "eveniet",
      "Kanalname": "unde",
      "Post1": "necessitatibus",
      "Post2": "reiciendis",
      "Post3": "quis",
      "EmailName": "joseph_simonis@beiergreenfelder.info",
      "ContactFullName": "Benton Jacobi",
      "ActiveErpLinks": 644,
      "TicketPriorityId": 632,
      "SupportLanguageId": 915,
      "SupportAssociateId": 856,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "ducimus",
  "Xstop": true,
  "ActiveInterests": 342,
  "GroupId": 495,
  "ActiveStatusMonitorId": 967,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 69,
  "DbiAgentId": 613,
  "DbiLastSyncronized": "2014-12-17T11:16:13.82385+01:00",
  "DbiKey": "libero",
  "DbiLastModified": "2023-08-01T11:16:13.82385+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 715,
  "ActiveErpLinks": 735,
  "BounceEmails": [
    "elenora_huel@wehner.name",
    "retta@gorczanyjohnson.info"
  ],
  "Domains": [
    "voluptatem",
    "atque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Oma Lind",
    "SuperOffice:2": "Meagan Huels"
  },
  "ExtraFields": {
    "ExtraFields1": "eius",
    "ExtraFields2": "reiciendis"
  },
  "CustomFields": {
    "CustomFields1": "dolores",
    "CustomFields2": "sunt"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "maxime",
  "2": "corporis"
}
```