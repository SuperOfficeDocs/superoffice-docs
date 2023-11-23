---
title: POST Person/Validate
uid: v1PersonEntity_ValidatePersonEntity
generated: true
---

# POST Person/Validate

```http
POST /api/v1/Person/Validate
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

## Request Body: personEntity 

Entity to be checked for errors. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | Integer | Primary key |
| Firstname | String | First name |
| MiddleName | String | Middle name or 'van' etc. |
| Lastname | String | Last name |
| Mrmrs | String | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
| Title | String | Title |
| UpdatedDate | String | Last updated date  in UTC. |
| CreatedDate | String | Registered date  in UTC. |
| BirthDate | String | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | Array | A collection of the person's emails |
| Description | String | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | Boolean | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | Array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | Array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | Array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | Array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | Array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | Array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
| PersonNumber | String | Alphanumeric user field |
| FullName | String | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | Boolean | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | Boolean | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | Boolean | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | Array | The urls related to this person. |
| FormalName | String | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | String | Postal address, used in Japanese versions only |
| Post2 | String | Postal address, used in Japanese versions only |
| Post1 | String | Postal address, used in Japanese versions only |
| Kanalname | String | Kana last name, used in Japanese versions only |
| Kanafname | String | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | String | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | Integer | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| DbiLastSyncronized | String | Last external syncronization. |
| SentInfo | Integer | Has information on username/password been sent (ejournal) |
| ShowContactTickets | Integer | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | Array |  |
| InternetPhones | Array |  |
| Source | Integer | How did we get this person? For future integration needs |
| ActiveErpLinks | Integer | How many active ERP links are there for this person? |
| ShipmentTypes | Array | The person's available and selected shipment types. |
| Consents | Array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for person |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:object

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: object


## Sample request

```http!
POST /api/v1/Person/Validate
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 848,
  "Firstname": "Diana",
  "MiddleName": "Graham, Schimmel and Nolan",
  "Lastname": "DuBuque",
  "Mrmrs": "voluptatem",
  "Title": "vel",
  "UpdatedDate": "2018-09-05T13:38:17.5149376+02:00",
  "CreatedDate": "2020-11-18T13:38:17.5149376+01:00",
  "BirthDate": "2017-02-02T13:38:17.5149376+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "non",
      "Description": "Open-source national synergy"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "non",
      "Description": "Open-source national synergy"
    }
  ],
  "Description": "Persistent empowering access",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nisi",
      "StrippedValue": "incidunt",
      "Description": "Reduced leading edge concept"
    },
    {
      "Value": "nisi",
      "StrippedValue": "incidunt",
      "Description": "Reduced leading edge concept"
    }
  ],
  "Faxes": [
    {
      "Value": "temporibus",
      "StrippedValue": "impedit",
      "Description": "Organic stable portal"
    },
    {
      "Value": "temporibus",
      "StrippedValue": "impedit",
      "Description": "Organic stable portal"
    }
  ],
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "quidem",
      "Description": "Down-sized 3rd generation algorithm"
    },
    {
      "Value": "aut",
      "StrippedValue": "quidem",
      "Description": "Down-sized 3rd generation algorithm"
    }
  ],
  "OfficePhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "praesentium",
      "Description": "Balanced grid-enabled collaboration"
    },
    {
      "Value": "perferendis",
      "StrippedValue": "praesentium",
      "Description": "Balanced grid-enabled collaboration"
    }
  ],
  "OtherPhones": [
    {
      "Value": "labore",
      "StrippedValue": "omnis",
      "Description": "Secured regional software"
    },
    {
      "Value": "labore",
      "StrippedValue": "omnis",
      "Description": "Secured regional software"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 576,
      "Name": "Raynor, Runolfsdottir and Weber",
      "ToolTip": "Et nesciunt et labore debitis tempore.",
      "Deleted": false,
      "Rank": 775,
      "Type": "expedita",
      "ColorBlock": 613,
      "IconHint": "odit",
      "Selected": true,
      "LastChanged": "2004-08-27T13:38:17.5149376+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ullam",
      "StyleHint": "non",
      "Hidden": false,
      "FullName": "Dayton Conn"
    }
  ],
  "PersonNumber": "724840",
  "FullName": "Otho Williamson",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "suscipit",
      "Description": "Innovative impactful groupware"
    },
    {
      "Value": "ut",
      "StrippedValue": "suscipit",
      "Description": "Innovative impactful groupware"
    }
  ],
  "FormalName": "Schimmel-Zieme",
  "Address": null,
  "Post3": "odit",
  "Post2": "sunt",
  "Post1": "atque",
  "Kanalname": "qui",
  "Kanafname": "a",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "earum",
  "ActiveInterests": 501,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 808,
  "DbiKey": "aut",
  "DbiLastModified": "2021-04-05T13:38:17.5149376+02:00",
  "DbiLastSyncronized": "2012-10-31T13:38:17.5149376+01:00",
  "SentInfo": 632,
  "ShowContactTickets": 73,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "quam",
      "Description": "Persevering client-driven focus group"
    },
    {
      "Value": "et",
      "StrippedValue": "quam",
      "Description": "Persevering client-driven focus group"
    }
  ],
  "InternetPhones": [
    {
      "Value": "quia",
      "StrippedValue": "sequi",
      "Description": "Business-focused analyzing contingency"
    },
    {
      "Value": "quia",
      "StrippedValue": "sequi",
      "Description": "Business-focused analyzing contingency"
    }
  ],
  "Source": 641,
  "ActiveErpLinks": 423,
  "ShipmentTypes": [
    {
      "Id": 426,
      "Name": "Kertzmann-Walter",
      "ToolTip": "Et architecto consequatur minus officia.",
      "Deleted": true,
      "Rank": 264,
      "Type": "eos",
      "ColorBlock": 808,
      "IconHint": "doloremque",
      "Selected": false,
      "LastChanged": "2003-04-07T13:38:17.5149376+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "cumque",
      "StyleHint": "officia",
      "Hidden": false,
      "FullName": "Alexanne Zachery Corwin V"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 112,
      "Comment": "rem",
      "Registered": "2008-02-14T13:38:17.5149376+01:00",
      "RegisteredAssociateId": 265,
      "Updated": "2006-04-20T13:38:17.5149376+02:00",
      "UpdatedAssociateId": 508,
      "LegalBaseId": 919,
      "LegalBaseKey": "consequatur",
      "LegalBaseName": "Eichmann Inc and Sons",
      "ConsentPurposeId": 20,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "McKenzie-Bergnaum",
      "ConsentSourceId": 391,
      "ConsentSourceKey": "sunt",
      "ConsentSourceName": "Lueilwitz, Bosco and Marvin"
    }
  ],
  "BounceEmails": [
    "erica@ratke.biz",
    "enola@connellybashirian.us"
  ],
  "ActiveStatusMonitorId": 488,
  "UserDefinedFields": {
    "SuperOffice:1": "Miss Malvina Friesen",
    "SuperOffice:2": "Karli Trantow"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "consequatur",
    "CustomFields2": "dolor"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "nam",
  "2": "iste"
}
```