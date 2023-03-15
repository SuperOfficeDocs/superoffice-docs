---
title: POST Person/Validate
uid: v1PersonEntity_ValidatePersonEntity
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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 599,
  "Firstname": "Casimir",
  "MiddleName": "Stroman Group",
  "Lastname": "Casper",
  "Mrmrs": "natus",
  "Title": "laudantium",
  "UpdatedDate": "2003-06-19T12:15:27.0976335+02:00",
  "CreatedDate": "2010-02-14T12:15:27.0976335+01:00",
  "BirthDate": "1998-07-27T12:15:27.0976335+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "nemo",
      "Description": "Visionary encompassing migration"
    },
    {
      "Value": "qui",
      "StrippedValue": "nemo",
      "Description": "Visionary encompassing migration"
    }
  ],
  "Description": "Reduced cohesive knowledge user",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ea",
      "StrippedValue": "soluta",
      "Description": "De-engineered mobile frame"
    },
    {
      "Value": "ea",
      "StrippedValue": "soluta",
      "Description": "De-engineered mobile frame"
    }
  ],
  "Faxes": [
    {
      "Value": "non",
      "StrippedValue": "quis",
      "Description": "Reduced discrete local area network"
    },
    {
      "Value": "non",
      "StrippedValue": "quis",
      "Description": "Reduced discrete local area network"
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "laboriosam",
      "Description": "Realigned reciprocal collaboration"
    },
    {
      "Value": "et",
      "StrippedValue": "laboriosam",
      "Description": "Realigned reciprocal collaboration"
    }
  ],
  "OfficePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "eaque",
      "Description": "Fully-configurable value-added leverage"
    },
    {
      "Value": "omnis",
      "StrippedValue": "eaque",
      "Description": "Fully-configurable value-added leverage"
    }
  ],
  "OtherPhones": [
    {
      "Value": "modi",
      "StrippedValue": "possimus",
      "Description": "Open-source optimizing utilisation"
    },
    {
      "Value": "modi",
      "StrippedValue": "possimus",
      "Description": "Open-source optimizing utilisation"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 264,
      "Name": "Feest-Hickle",
      "ToolTip": "Explicabo enim consequatur.",
      "Deleted": false,
      "Rank": 393,
      "Type": "modi",
      "ColorBlock": 9,
      "IconHint": "dolorum",
      "Selected": true,
      "LastChanged": "2019-05-01T12:15:27.1016361+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quo",
      "StyleHint": "sit",
      "Hidden": true,
      "FullName": "Oceane Wisozk Jr."
    }
  ],
  "PersonNumber": "944306",
  "FullName": "Leonora Fadel",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "delectus",
      "StrippedValue": "et",
      "Description": "Diverse discrete infrastructure"
    },
    {
      "Value": "delectus",
      "StrippedValue": "et",
      "Description": "Diverse discrete infrastructure"
    }
  ],
  "FormalName": "Kuhlman-Pouros",
  "Address": null,
  "Post3": "ab",
  "Post2": "et",
  "Post1": "sed",
  "Kanalname": "optio",
  "Kanafname": "sunt",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quis",
  "ActiveInterests": 32,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 209,
  "DbiKey": "non",
  "DbiLastModified": "2010-12-05T12:15:27.1036333+01:00",
  "DbiLastSyncronized": "2017-02-27T12:15:27.1036333+01:00",
  "SentInfo": 487,
  "ShowContactTickets": 913,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "temporibus",
      "StrippedValue": "quo",
      "Description": "Configurable multimedia Graphical User Interface"
    },
    {
      "Value": "temporibus",
      "StrippedValue": "quo",
      "Description": "Configurable multimedia Graphical User Interface"
    }
  ],
  "InternetPhones": [
    {
      "Value": "hic",
      "StrippedValue": "atque",
      "Description": "Versatile bandwidth-monitored capacity"
    },
    {
      "Value": "hic",
      "StrippedValue": "atque",
      "Description": "Versatile bandwidth-monitored capacity"
    }
  ],
  "Source": 295,
  "ActiveErpLinks": 89,
  "ShipmentTypes": [
    {
      "Id": 441,
      "Name": "Welch, Lemke and Rohan",
      "ToolTip": "Magnam consectetur corporis recusandae repudiandae nihil voluptatem.",
      "Deleted": false,
      "Rank": 836,
      "Type": "alias",
      "ColorBlock": 188,
      "IconHint": "fuga",
      "Selected": false,
      "LastChanged": "2006-11-12T12:15:27.1036333+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aperiam",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Miss Allie Modesto Cremin III"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 366,
      "Comment": "exercitationem",
      "Registered": "2014-12-03T12:15:27.1046332+01:00",
      "RegisteredAssociateId": 210,
      "Updated": "2009-07-24T12:15:27.1046332+02:00",
      "UpdatedAssociateId": 396,
      "LegalBaseId": 432,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Strosin-Fay",
      "ConsentPurposeId": 126,
      "ConsentPurposeKey": "vitae",
      "ConsentPurposeName": "Upton-Braun",
      "ConsentSourceId": 360,
      "ConsentSourceKey": "architecto",
      "ConsentSourceName": "Hagenes Group"
    }
  ],
  "BounceEmails": [
    "marques.larkin@brueneichmann.biz",
    "katheryn_champlin@brown.ca"
  ],
  "ActiveStatusMonitorId": 567,
  "UserDefinedFields": {
    "SuperOffice:1": "Destin Will",
    "SuperOffice:2": "Mrs. Lester Marvin"
  },
  "ExtraFields": {
    "ExtraFields1": "corrupti",
    "ExtraFields2": "sit"
  },
  "CustomFields": {
    "CustomFields1": "atque",
    "CustomFields2": "perferendis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "1": "et",
  "2": "numquam"
}
```