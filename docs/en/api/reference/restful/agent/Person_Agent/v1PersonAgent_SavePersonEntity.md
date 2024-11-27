---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is empty








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

## Request Body: entity 

The PersonEntity to be saved. 

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
| CreatedByFormId | Integer | The form id of the form that created the person |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: PersonEntity

| Property Name | Type |  Description |
|----------------|------|--------------|
| PersonId | int32 | Primary key |
| Firstname | string | First name |
| MiddleName | string | Middle name or 'van' etc. |
| Lastname | string | Last name |
| Mrmrs | string | e.g. Mrs   sex_title  Use MDO List name "mrmrs" to get list items. |
| Title | string | Title |
| UpdatedDate | date-time | Last updated date  in UTC. |
| CreatedDate | date-time | Registered date  in UTC. |
| BirthDate | date-time | The Person birth date as UTC Date. Year 1 = Null. Year 2 = unknown year. |
| CreatedBy | Associate | The user that created the person object |
| Emails | array | A collection of the person's emails |
| Description | string | The actual text, max 2047 significant characters even though it is stored as a larger data type on some databases |
| IsAssociate | bool | Checks if the person object is an associate. The property is read-only. |
| PrivatePhones | array | Returns a collection of phone numbers that belong to the contact person. |
| Faxes | array | Returns a collection of fax numbers that belong to the contact person. |
| MobilePhones | array | Returns a collection of mobile phone numbers that belong to the contact person. |
| OfficePhones | array | Returns a collection of office phone numbers that belong to the contact person. |
| OtherPhones | array | Returns a collection of pagers that belong to the contact person. |
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  Use MDO List name "perspos" to get list items. |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  Use MDO List name "contact_new" to get list items. |
| Country | Country | The country this contact person is located in.  Use MDO List name "country" to get list items. |
| Interests | array | The person's available and selected interests.  Use MDO List name "persint" to get list items. |
| PersonNumber | string | Alphanumeric user field |
| FullName | string | The person's full name localized to the current culture/country.  (internal name used in clients for employees) |
| NoMailing | bool | Spam filter. Indicates if this person should retrieve advertising. |
| UsePersonAddress | bool | True if the person's address should be used as mailing address, instead of the contact's address. |
| Retired | bool | True if the user is retired and should have no rights, not appear in lists, etc. |
| Urls | array | The urls related to this person. |
| FormalName | string | Get formal name for a person, as used in labels. (Full name + person title + academic title) |
| Address | Address | Structure holding formatted address data. The layout of the array structure indicates the layout of the localized address. |
| Post3 | string | Postal address, used in Japanese versions only |
| Post2 | string | Postal address, used in Japanese versions only |
| Post1 | string | Postal address, used in Japanese versions only |
| Kanalname | string | Kana last name, used in Japanese versions only |
| Kanafname | string | Kana first name, used in Japanese versions only |
| CorrespondingAssociate | Associate | The associate corresponding to this person. Will be empty if the person is not a user (internal associate user, external user). |
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "category" to get list items. |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  Use MDO List name "business" to get list items. |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  Use MDO List name "associate" to get list items. |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  Use MDO List name "salutation" to get list items. |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | Use MDO List name "customerlanguage" to get list items. |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| DbiLastSyncronized | date-time | Last external syncronization. |
| SentInfo | int32 | Has information on username/password been sent (ejournal) |
| ShowContactTickets | int32 | Should tickets related to the company be shown to this person |
| UserInfo | UserInfo | Information about the user if this person is a user.  If IsAssociate (e.g. is user is true) the UserInfo will be provided. |
| ChatEmails | array |  |
| InternetPhones | array |  |
| Source | int32 | How did we get this person? For future integration needs |
| ActiveErpLinks | int32 | How many active ERP links are there for this person? |
| ShipmentTypes | array | The person's available and selected shipment types. |
| Consents | array | The person's available consent information. Missing consents are not deleted. To remove a consent, mark its legalbase as 'WITHDRAWN' |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for person |
| CreatedByFormId | int32 | The form id of the form that created the person |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 494,
  "Firstname": "Stanton",
  "MiddleName": "Barrows Inc and Sons",
  "Lastname": "Friesen",
  "Mrmrs": "perferendis",
  "Title": "sed",
  "UpdatedDate": "2010-02-02T14:45:05.8188143+01:00",
  "CreatedDate": "2000-09-06T14:45:05.8188143+02:00",
  "BirthDate": "2016-04-27T14:45:05.8188143+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quo",
      "StrippedValue": "ex",
      "Description": "Proactive dynamic neural-net"
    },
    {
      "Value": "quo",
      "StrippedValue": "ex",
      "Description": "Proactive dynamic neural-net"
    }
  ],
  "Description": "Automated grid-enabled encryption",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "non",
      "Description": "Function-based 24/7 Graphic Interface"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "non",
      "Description": "Function-based 24/7 Graphic Interface"
    }
  ],
  "Faxes": [
    {
      "Value": "quis",
      "StrippedValue": "nam",
      "Description": "Innovative zero administration paradigm"
    },
    {
      "Value": "quis",
      "StrippedValue": "nam",
      "Description": "Innovative zero administration paradigm"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quis",
      "StrippedValue": "nihil",
      "Description": "Reduced context-sensitive hub"
    },
    {
      "Value": "quis",
      "StrippedValue": "nihil",
      "Description": "Reduced context-sensitive hub"
    }
  ],
  "OfficePhones": [
    {
      "Value": "ad",
      "StrippedValue": "dignissimos",
      "Description": "Advanced stable strategy"
    },
    {
      "Value": "ad",
      "StrippedValue": "dignissimos",
      "Description": "Advanced stable strategy"
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "voluptatem",
      "Description": "Optimized intangible artificial intelligence"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "voluptatem",
      "Description": "Optimized intangible artificial intelligence"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 438,
      "Name": "Hyatt-Kuhic",
      "ToolTip": "Enim asperiores veritatis eius odit.",
      "Deleted": true,
      "Rank": 945,
      "Type": "illo",
      "ColorBlock": 491,
      "IconHint": "placeat",
      "Selected": false,
      "LastChanged": "1999-09-03T14:45:05.8188143+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "esse",
      "StyleHint": "excepturi",
      "Hidden": true,
      "FullName": "Carlee Champlin"
    }
  ],
  "PersonNumber": "732078",
  "FullName": "Dr. Claudie Ziemann",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "voluptas",
      "StrippedValue": "a",
      "Description": "Cross-group didactic knowledge user"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "a",
      "Description": "Cross-group didactic knowledge user"
    }
  ],
  "FormalName": "Kovacek-Hand",
  "Address": null,
  "Post3": "doloremque",
  "Post2": "sit",
  "Post1": "amet",
  "Kanalname": "odit",
  "Kanafname": "quas",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 505,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 959,
  "DbiKey": "non",
  "DbiLastModified": "2022-12-23T14:45:05.8344339+01:00",
  "DbiLastSyncronized": "2004-04-01T14:45:05.8344339+02:00",
  "SentInfo": 479,
  "ShowContactTickets": 613,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "nostrum",
      "Description": "Digitized explicit infrastructure"
    },
    {
      "Value": "et",
      "StrippedValue": "nostrum",
      "Description": "Digitized explicit infrastructure"
    }
  ],
  "InternetPhones": [
    {
      "Value": "qui",
      "StrippedValue": "sit",
      "Description": "Cross-platform scalable core"
    },
    {
      "Value": "qui",
      "StrippedValue": "sit",
      "Description": "Cross-platform scalable core"
    }
  ],
  "Source": 867,
  "ActiveErpLinks": 134,
  "ShipmentTypes": [
    {
      "Id": 151,
      "Name": "Parisian-Schuster",
      "ToolTip": "Dignissimos et accusamus quaerat.",
      "Deleted": false,
      "Rank": 188,
      "Type": "autem",
      "ColorBlock": 232,
      "IconHint": "nulla",
      "Selected": false,
      "LastChanged": "2009-12-09T14:45:05.8344339+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "unde",
      "StyleHint": "eaque",
      "Hidden": false,
      "FullName": "Opal Fahey"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 281,
      "Comment": "qui",
      "Registered": "2007-04-16T14:45:05.8344339+02:00",
      "RegisteredAssociateId": 607,
      "Updated": "2003-11-21T14:45:05.8344339+01:00",
      "UpdatedAssociateId": 1000,
      "LegalBaseId": 272,
      "LegalBaseKey": "est",
      "LegalBaseName": "Purdy, Lueilwitz and Grady",
      "ConsentPurposeId": 748,
      "ConsentPurposeKey": "necessitatibus",
      "ConsentPurposeName": "Beahan, Volkman and Rath",
      "ConsentSourceId": 214,
      "ConsentSourceKey": "alias",
      "ConsentSourceName": "Collier-Cronin"
    }
  ],
  "BounceEmails": [
    "darrel.leffler@gutmannbrekke.biz",
    "zelma@ullrichsimonis.info"
  ],
  "ActiveStatusMonitorId": 651,
  "CreatedByFormId": 502,
  "UserDefinedFields": {
    "SuperOffice:1": "Prof. Ernest Rashad Leffler",
    "SuperOffice:2": "465157237"
  },
  "ExtraFields": {
    "ExtraFields1": "aliquid",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "quia",
    "CustomFields2": "corrupti"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 687,
  "Firstname": "Felix",
  "MiddleName": "Hermann LLC",
  "Lastname": "Bahringer",
  "Mrmrs": "sunt",
  "Title": "cupiditate",
  "UpdatedDate": "2018-03-01T14:45:05.8344339+01:00",
  "CreatedDate": "2005-08-09T14:45:05.8344339+02:00",
  "BirthDate": "1999-10-24T14:45:05.8344339+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "amet",
      "StrippedValue": "autem",
      "Description": "Programmable methodical hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    },
    {
      "Value": "amet",
      "StrippedValue": "autem",
      "Description": "Programmable methodical hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 353
        }
      }
    }
  ],
  "Description": "Streamlined client-driven policy",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "praesentium",
      "StrippedValue": "fugit",
      "Description": "Re-engineered system-worthy superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 831
        }
      }
    },
    {
      "Value": "praesentium",
      "StrippedValue": "fugit",
      "Description": "Re-engineered system-worthy superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 831
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "qui",
      "StrippedValue": "nesciunt",
      "Description": "Focused object-oriented ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 813
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "nesciunt",
      "Description": "Focused object-oriented ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 813
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sint",
      "StrippedValue": "deserunt",
      "Description": "Secured intangible secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "deserunt",
      "Description": "Secured intangible secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 706
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "at",
      "StrippedValue": "dolores",
      "Description": "Extended human-resource model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    },
    {
      "Value": "at",
      "StrippedValue": "dolores",
      "Description": "Extended human-resource model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 749
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "soluta",
      "Description": "Enterprise-wide user-facing info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 883
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "soluta",
      "Description": "Enterprise-wide user-facing info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 883
        }
      }
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 250,
      "Name": "Haag-Mills",
      "ToolTip": "Asperiores voluptatum tenetur nihil.",
      "Deleted": false,
      "Rank": 341,
      "Type": "soluta",
      "ColorBlock": 753,
      "IconHint": "qui",
      "Selected": true,
      "LastChanged": "2016-03-30T14:45:05.8344339+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "eos",
      "Hidden": false,
      "FullName": "Felicity VonRueden",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 917
        }
      }
    }
  ],
  "PersonNumber": "1576036",
  "FullName": "Ms. Vida Allie Rodriguez",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "deleniti",
      "StrippedValue": "distinctio",
      "Description": "Multi-channelled upward-trending concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 800
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "distinctio",
      "Description": "Multi-channelled upward-trending concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 800
        }
      }
    }
  ],
  "FormalName": "Altenwerth Inc and Sons",
  "Address": null,
  "Post3": "dignissimos",
  "Post2": "sequi",
  "Post1": "dolorem",
  "Kanalname": "ad",
  "Kanafname": "rem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dolorum",
  "ActiveInterests": 766,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 181,
  "DbiKey": "aperiam",
  "DbiLastModified": "2004-07-24T14:45:05.8344339+02:00",
  "DbiLastSyncronized": "2015-03-14T14:45:05.8344339+01:00",
  "SentInfo": 143,
  "ShowContactTickets": 457,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eveniet",
      "StrippedValue": "in",
      "Description": "Persistent 3rd generation product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "in",
      "Description": "Persistent 3rd generation product",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 914
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "dolores",
      "Description": "Reduced modular synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 723
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "dolores",
      "Description": "Reduced modular synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 723
        }
      }
    }
  ],
  "Source": 31,
  "ActiveErpLinks": 535,
  "ShipmentTypes": [
    {
      "Id": 27,
      "Name": "Reichel, Murphy and Cartwright",
      "ToolTip": "Error natus quasi provident rerum nobis.",
      "Deleted": false,
      "Rank": 118,
      "Type": "sed",
      "ColorBlock": 931,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2000-07-08T14:45:05.8344339+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eveniet",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Leanna Lockman DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 783
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 229,
      "Comment": "inventore",
      "Registered": "2005-10-21T14:45:05.8344339+02:00",
      "RegisteredAssociateId": 725,
      "Updated": "2018-06-01T14:45:05.8344339+02:00",
      "UpdatedAssociateId": 996,
      "LegalBaseId": 28,
      "LegalBaseKey": "repellendus",
      "LegalBaseName": "Swaniawski Group",
      "ConsentPurposeId": 823,
      "ConsentPurposeKey": "consequatur",
      "ConsentPurposeName": "Mitchell-Smith",
      "ConsentSourceId": 767,
      "ConsentSourceKey": "odit",
      "ConsentSourceName": "Hermann-Hayes",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 628
        }
      }
    }
  ],
  "BounceEmails": [
    "lea_bogan@schaefer.name",
    "hilda_treutel@windler.com"
  ],
  "ActiveStatusMonitorId": 141,
  "CreatedByFormId": 624,
  "UserDefinedFields": {
    "SuperOffice:1": "Rubye Corkery",
    "SuperOffice:2": "True"
  },
  "ExtraFields": {
    "ExtraFields1": "itaque",
    "ExtraFields2": "nihil"
  },
  "CustomFields": {
    "CustomFields1": "repellendus",
    "CustomFields2": "quod"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 68
    }
  }
}
```