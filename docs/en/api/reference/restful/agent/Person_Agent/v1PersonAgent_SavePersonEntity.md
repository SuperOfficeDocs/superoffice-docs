---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
generated: true
content_type: reference
---

# POST Agents/Person/SavePersonEntity

```http
POST /api/v1/Agents/Person/SavePersonEntity
```

Updates the existing PersonEntity or creates a new PersonEntity if the id parameter is 0.


NsApiSlow threshold: 2000 ms.







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

The PersonEntity that is saved 

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
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | Integer | Refinement of categories of lead type. Empty if the category is not a lead type. |
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
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
  "PersonId": 629,
  "Firstname": "Richie",
  "MiddleName": "Hackett, Bergnaum and Wyman",
  "Lastname": "Johnston",
  "Mrmrs": "fugit",
  "Title": "omnis",
  "UpdatedDate": "2010-10-30T03:40:47.2967974+02:00",
  "CreatedDate": "2016-04-19T03:40:47.2967974+02:00",
  "BirthDate": "2009-09-01T03:40:47.2967974+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "et",
      "Description": "Managed clear-thinking system engine"
    },
    {
      "Value": "est",
      "StrippedValue": "et",
      "Description": "Managed clear-thinking system engine"
    }
  ],
  "Description": "Fundamental responsive info-mediaries",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "praesentium",
      "Description": "Streamlined 24/7 access"
    },
    {
      "Value": "sunt",
      "StrippedValue": "praesentium",
      "Description": "Streamlined 24/7 access"
    }
  ],
  "Faxes": [
    {
      "Value": "consequuntur",
      "StrippedValue": "sunt",
      "Description": "Expanded human-resource instruction set"
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "sunt",
      "Description": "Expanded human-resource instruction set"
    }
  ],
  "MobilePhones": [
    {
      "Value": "odit",
      "StrippedValue": "sunt",
      "Description": "User-friendly non-volatile application"
    },
    {
      "Value": "odit",
      "StrippedValue": "sunt",
      "Description": "User-friendly non-volatile application"
    }
  ],
  "OfficePhones": [
    {
      "Value": "illum",
      "StrippedValue": "quod",
      "Description": "Organic motivating paradigm"
    },
    {
      "Value": "illum",
      "StrippedValue": "quod",
      "Description": "Organic motivating paradigm"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ea",
      "StrippedValue": "provident",
      "Description": "Right-sized motivating hardware"
    },
    {
      "Value": "ea",
      "StrippedValue": "provident",
      "Description": "Right-sized motivating hardware"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 732,
      "Name": "Block, Bogisich and Macejkovic",
      "ToolTip": "Et illo quos quia facere sit.",
      "Deleted": false,
      "Rank": 752,
      "Type": "odit",
      "ColorBlock": 644,
      "IconHint": "commodi",
      "Selected": false,
      "LastChanged": "2019-03-07T03:40:47.2967974+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ducimus",
      "StyleHint": "velit",
      "Hidden": false,
      "FullName": "Gladys Predovic"
    }
  ],
  "PersonNumber": "1075480",
  "FullName": "Dr. Marie Emery Mayert Sr.",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "assumenda",
      "StrippedValue": "sit",
      "Description": "Right-sized bottom-line approach"
    },
    {
      "Value": "assumenda",
      "StrippedValue": "sit",
      "Description": "Right-sized bottom-line approach"
    }
  ],
  "FormalName": "Blanda Inc and Sons",
  "Address": null,
  "Post3": "aut",
  "Post2": "autem",
  "Post1": "consequuntur",
  "Kanalname": "beatae",
  "Kanafname": "error",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ratione",
  "ActiveInterests": 483,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 198,
  "DbiKey": "voluptatem",
  "DbiLastModified": "2021-07-19T03:40:47.2967974+02:00",
  "DbiLastSyncronized": "2003-05-13T03:40:47.2967974+02:00",
  "SentInfo": 395,
  "ShowContactTickets": 195,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "amet",
      "StrippedValue": "est",
      "Description": "Object-based client-driven infrastructure"
    },
    {
      "Value": "amet",
      "StrippedValue": "est",
      "Description": "Object-based client-driven infrastructure"
    }
  ],
  "InternetPhones": [
    {
      "Value": "illo",
      "StrippedValue": "impedit",
      "Description": "Multi-tiered demand-driven portal"
    },
    {
      "Value": "illo",
      "StrippedValue": "impedit",
      "Description": "Multi-tiered demand-driven portal"
    }
  ],
  "Source": 443,
  "ActiveErpLinks": 920,
  "ShipmentTypes": [
    {
      "Id": 458,
      "Name": "Bauch Group",
      "ToolTip": "Consectetur dignissimos non illo expedita vitae ab.",
      "Deleted": false,
      "Rank": 736,
      "Type": "iure",
      "ColorBlock": 662,
      "IconHint": "rerum",
      "Selected": true,
      "LastChanged": "2019-06-08T03:40:47.2967974+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "similique",
      "StyleHint": "praesentium",
      "Hidden": false,
      "FullName": "Mr. Bradly Darlene Zulauf"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 134,
      "Comment": "at",
      "Registered": "2011-10-16T03:40:47.2967974+02:00",
      "RegisteredAssociateId": 846,
      "Updated": "2016-04-12T03:40:47.2967974+02:00",
      "UpdatedAssociateId": 164,
      "LegalBaseId": 886,
      "LegalBaseKey": "sequi",
      "LegalBaseName": "Trantow-Koss",
      "ConsentPurposeId": 950,
      "ConsentPurposeKey": "expedita",
      "ConsentPurposeName": "Dietrich-Kohler",
      "ConsentSourceId": 752,
      "ConsentSourceKey": "fugit",
      "ConsentSourceName": "Lesch-Aufderhar"
    }
  ],
  "BounceEmails": [
    "ramon@murray.info",
    "jordyn.baumbach@emmerichblock.name"
  ],
  "ActiveStatusMonitorId": 633,
  "CreatedByFormId": 682,
  "UtmParameters": null,
  "LeadstatusId": 585,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1860737574"
  },
  "ExtraFields": {
    "ExtraFields1": "esse",
    "ExtraFields2": "alias"
  },
  "CustomFields": {
    "CustomFields1": "temporibus",
    "CustomFields2": "consequatur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 174,
  "Firstname": "Daija",
  "MiddleName": "Grant Group",
  "Lastname": "Breitenberg",
  "Mrmrs": "sint",
  "Title": "qui",
  "UpdatedDate": "2018-01-01T03:40:47.3135936+01:00",
  "CreatedDate": "2015-09-16T03:40:47.3135936+02:00",
  "BirthDate": "2012-05-28T03:40:47.3135936+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "vel",
      "StrippedValue": "voluptatem",
      "Description": "Exclusive exuding standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 951
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "voluptatem",
      "Description": "Exclusive exuding standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 951
        }
      }
    }
  ],
  "Description": "Digitized explicit definition",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "quidem",
      "StrippedValue": "et",
      "Description": "Innovative content-based hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "et",
      "Description": "Innovative content-based hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 788
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "facere",
      "Description": "Business-focused 24/7 utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 167
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "facere",
      "Description": "Business-focused 24/7 utilisation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 167
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "numquam",
      "StrippedValue": "maiores",
      "Description": "Adaptive upward-trending architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "maiores",
      "Description": "Adaptive upward-trending architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 965
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolores",
      "StrippedValue": "maxime",
      "Description": "Exclusive coherent hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 320
        }
      }
    },
    {
      "Value": "dolores",
      "StrippedValue": "maxime",
      "Description": "Exclusive coherent hub",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 320
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "quasi",
      "Description": "Multi-layered eco-centric hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 69
        }
      }
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "quasi",
      "Description": "Multi-layered eco-centric hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 69
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
      "Id": 836,
      "Name": "Mills-Bode",
      "ToolTip": "Voluptatum velit qui ut quo odit voluptas.",
      "Deleted": true,
      "Rank": 800,
      "Type": "exercitationem",
      "ColorBlock": 124,
      "IconHint": "nisi",
      "Selected": false,
      "LastChanged": "2018-11-10T03:40:47.3135936+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "necessitatibus",
      "StyleHint": "vitae",
      "Hidden": false,
      "FullName": "Luciano Koch MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 63
        }
      }
    }
  ],
  "PersonNumber": "1106753",
  "FullName": "Miss Alexandro Jermaine Kuphal I",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "quis",
      "StrippedValue": "iste",
      "Description": "Optimized responsive middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 24
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "iste",
      "Description": "Optimized responsive middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 24
        }
      }
    }
  ],
  "FormalName": "Batz LLC",
  "Address": null,
  "Post3": "iure",
  "Post2": "dolores",
  "Post1": "fugit",
  "Kanalname": "ut",
  "Kanafname": "qui",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "et",
  "ActiveInterests": 609,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 53,
  "DbiKey": "facere",
  "DbiLastModified": "2000-01-15T03:40:47.3135936+01:00",
  "DbiLastSyncronized": "2008-07-24T03:40:47.3135936+02:00",
  "SentInfo": 434,
  "ShowContactTickets": 787,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sunt",
      "StrippedValue": "praesentium",
      "Description": "Networked stable installation",
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
      "Value": "sunt",
      "StrippedValue": "praesentium",
      "Description": "Networked stable installation",
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
  "InternetPhones": [
    {
      "Value": "quo",
      "StrippedValue": "natus",
      "Description": "Programmable maximized toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 576
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "natus",
      "Description": "Programmable maximized toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 576
        }
      }
    }
  ],
  "Source": 840,
  "ActiveErpLinks": 712,
  "ShipmentTypes": [
    {
      "Id": 75,
      "Name": "Rutherford-Murray",
      "ToolTip": "Commodi blanditiis quisquam provident nobis voluptate laborum similique.",
      "Deleted": false,
      "Rank": 922,
      "Type": "minima",
      "ColorBlock": 846,
      "IconHint": "aliquid",
      "Selected": true,
      "LastChanged": "2017-01-06T03:40:47.3135936+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quia",
      "StyleHint": "sit",
      "Hidden": false,
      "FullName": "Dr. Dillan Nikolaus",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 996
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 637,
      "Comment": "qui",
      "Registered": "2015-05-23T03:40:47.3135936+02:00",
      "RegisteredAssociateId": 486,
      "Updated": "2005-01-15T03:40:47.3135936+01:00",
      "UpdatedAssociateId": 289,
      "LegalBaseId": 700,
      "LegalBaseKey": "fuga",
      "LegalBaseName": "Lakin, Lockman and Little",
      "ConsentPurposeId": 166,
      "ConsentPurposeKey": "velit",
      "ConsentPurposeName": "Marks, Frami and DuBuque",
      "ConsentSourceId": 918,
      "ConsentSourceKey": "asperiores",
      "ConsentSourceName": "Flatley Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 797
        }
      }
    }
  ],
  "BounceEmails": [
    "alexie@lueilwitzdietrich.name",
    "micaela_thompson@watsica.uk"
  ],
  "ActiveStatusMonitorId": 378,
  "CreatedByFormId": 750,
  "UtmParameters": null,
  "LeadstatusId": 457,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Bradley Koepp",
    "SuperOffice:2": "Jake Tremblay"
  },
  "ExtraFields": {
    "ExtraFields1": "corporis",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "est",
    "CustomFields2": "tenetur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 58
    }
  }
}
```