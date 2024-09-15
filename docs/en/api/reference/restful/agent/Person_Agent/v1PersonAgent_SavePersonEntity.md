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
  "PersonId": 397,
  "Firstname": "Virginia",
  "MiddleName": "Streich, Hammes and McDermott",
  "Lastname": "Stiedemann",
  "Mrmrs": "ut",
  "Title": "iste",
  "UpdatedDate": "1999-04-09T04:02:01.9253512+02:00",
  "CreatedDate": "1999-07-30T04:02:01.9253512+02:00",
  "BirthDate": "2016-08-21T04:02:01.9253512+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "est",
      "StrippedValue": "facere",
      "Description": "Reverse-engineered user-facing flexibility"
    },
    {
      "Value": "est",
      "StrippedValue": "facere",
      "Description": "Reverse-engineered user-facing flexibility"
    }
  ],
  "Description": "Configurable 5th generation hardware",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "velit",
      "StrippedValue": "voluptatem",
      "Description": "Profit-focused regional application"
    },
    {
      "Value": "velit",
      "StrippedValue": "voluptatem",
      "Description": "Profit-focused regional application"
    }
  ],
  "Faxes": [
    {
      "Value": "necessitatibus",
      "StrippedValue": "qui",
      "Description": "Persistent systemic capability"
    },
    {
      "Value": "necessitatibus",
      "StrippedValue": "qui",
      "Description": "Persistent systemic capability"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "ea",
      "Description": "Self-enabling dynamic internet solution"
    },
    {
      "Value": "quisquam",
      "StrippedValue": "ea",
      "Description": "Self-enabling dynamic internet solution"
    }
  ],
  "OfficePhones": [
    {
      "Value": "earum",
      "StrippedValue": "natus",
      "Description": "Distributed foreground definition"
    },
    {
      "Value": "earum",
      "StrippedValue": "natus",
      "Description": "Distributed foreground definition"
    }
  ],
  "OtherPhones": [
    {
      "Value": "sit",
      "StrippedValue": "quos",
      "Description": "Optional modular collaboration"
    },
    {
      "Value": "sit",
      "StrippedValue": "quos",
      "Description": "Optional modular collaboration"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 294,
      "Name": "Blick, O'Keefe and Purdy",
      "ToolTip": "Possimus adipisci rerum possimus expedita.",
      "Deleted": true,
      "Rank": 480,
      "Type": "est",
      "ColorBlock": 514,
      "IconHint": "dolores",
      "Selected": true,
      "LastChanged": "2003-01-26T04:02:01.9253512+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "odio",
      "Hidden": false,
      "FullName": "Adrien Oliver Hermiston V"
    }
  ],
  "PersonNumber": "30313",
  "FullName": "Lonnie Filomena Kuhn I",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "laboriosam",
      "StrippedValue": "magnam",
      "Description": "Centralized national emulation"
    },
    {
      "Value": "laboriosam",
      "StrippedValue": "magnam",
      "Description": "Centralized national emulation"
    }
  ],
  "FormalName": "Crooks-Greenholt",
  "Address": null,
  "Post3": "nihil",
  "Post2": "unde",
  "Post1": "nemo",
  "Kanalname": "est",
  "Kanafname": "labore",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "rerum",
  "ActiveInterests": 163,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 207,
  "DbiKey": "ratione",
  "DbiLastModified": "2019-05-25T04:02:01.9253512+02:00",
  "DbiLastSyncronized": "2005-10-29T04:02:01.9253512+02:00",
  "SentInfo": 43,
  "ShowContactTickets": 715,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eum",
      "StrippedValue": "et",
      "Description": "Function-based bandwidth-monitored encryption"
    },
    {
      "Value": "eum",
      "StrippedValue": "et",
      "Description": "Function-based bandwidth-monitored encryption"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Ergonomic multi-state strategy"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Ergonomic multi-state strategy"
    }
  ],
  "Source": 266,
  "ActiveErpLinks": 101,
  "ShipmentTypes": [
    {
      "Id": 683,
      "Name": "Balistreri Group",
      "ToolTip": "Fugit saepe laudantium beatae.",
      "Deleted": false,
      "Rank": 195,
      "Type": "ex",
      "ColorBlock": 733,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "2020-02-07T04:02:01.9253512+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ratione",
      "StyleHint": "ea",
      "Hidden": false,
      "FullName": "Julian Rogahn II"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 967,
      "Comment": "quia",
      "Registered": "2009-02-16T04:02:01.9253512+01:00",
      "RegisteredAssociateId": 952,
      "Updated": "2004-10-31T04:02:01.9253512+01:00",
      "UpdatedAssociateId": 95,
      "LegalBaseId": 150,
      "LegalBaseKey": "esse",
      "LegalBaseName": "Vandervort LLC",
      "ConsentPurposeId": 532,
      "ConsentPurposeKey": "nobis",
      "ConsentPurposeName": "Schuster-Moore",
      "ConsentSourceId": 337,
      "ConsentSourceKey": "necessitatibus",
      "ConsentSourceName": "Botsford-Sanford"
    }
  ],
  "BounceEmails": [
    "lillian@thiel.name",
    "giovani@stantonruecker.uk"
  ],
  "ActiveStatusMonitorId": 907,
  "CreatedByFormId": 609,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Margarette Eleanore Pfeffer Jr.",
    "SuperOffice:2": "Shanel Hayes"
  },
  "ExtraFields": {
    "ExtraFields1": "sit",
    "ExtraFields2": "dignissimos"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "possimus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 794,
  "Firstname": "Jaylon",
  "MiddleName": "Bednar-Jerde",
  "Lastname": "Swaniawski",
  "Mrmrs": "vitae",
  "Title": "earum",
  "UpdatedDate": "2021-09-20T04:02:01.9253512+02:00",
  "CreatedDate": "2015-05-30T04:02:01.9253512+02:00",
  "BirthDate": "2020-04-25T04:02:01.9253512+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "enim",
      "StrippedValue": "et",
      "Description": "Re-contextualized tertiary local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    },
    {
      "Value": "enim",
      "StrippedValue": "et",
      "Description": "Re-contextualized tertiary local area network",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 348
        }
      }
    }
  ],
  "Description": "Versatile neutral migration",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "error",
      "StrippedValue": "atque",
      "Description": "Distributed high-level Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    },
    {
      "Value": "error",
      "StrippedValue": "atque",
      "Description": "Distributed high-level Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 981
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "adipisci",
      "StrippedValue": "quibusdam",
      "Description": "Customer-focused optimal structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 161
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "quibusdam",
      "Description": "Customer-focused optimal structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 161
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "blanditiis",
      "StrippedValue": "dolorum",
      "Description": "Sharable zero administration access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 322
        }
      }
    },
    {
      "Value": "blanditiis",
      "StrippedValue": "dolorum",
      "Description": "Sharable zero administration access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 322
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "fuga",
      "StrippedValue": "qui",
      "Description": "Profound methodical framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 704
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "qui",
      "Description": "Profound methodical framework",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 704
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quo",
      "StrippedValue": "quo",
      "Description": "Face to face motivating model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 416
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "quo",
      "Description": "Face to face motivating model",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 416
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
      "Id": 80,
      "Name": "Kuhic LLC",
      "ToolTip": "Nam tenetur qui cum.",
      "Deleted": true,
      "Rank": 712,
      "Type": "accusamus",
      "ColorBlock": 125,
      "IconHint": "et",
      "Selected": true,
      "LastChanged": "2002-10-03T04:02:01.9253512+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "impedit",
      "StyleHint": "dolorem",
      "Hidden": true,
      "FullName": "Verda Shields",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 83
        }
      }
    }
  ],
  "PersonNumber": "1314974",
  "FullName": "Jaleel Amelie Tillman Sr.",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "culpa",
      "Description": "Universal contextually-based leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 65
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "culpa",
      "Description": "Universal contextually-based leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 65
        }
      }
    }
  ],
  "FormalName": "Green, Stokes and Olson",
  "Address": null,
  "Post3": "ducimus",
  "Post2": "quaerat",
  "Post1": "est",
  "Kanalname": "vitae",
  "Kanafname": "quia",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eveniet",
  "ActiveInterests": 761,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 810,
  "DbiKey": "qui",
  "DbiLastModified": "2005-01-18T04:02:01.9253512+01:00",
  "DbiLastSyncronized": "2006-08-16T04:02:01.9253512+02:00",
  "SentInfo": 656,
  "ShowContactTickets": 203,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nisi",
      "StrippedValue": "dolorem",
      "Description": "Exclusive coherent extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "dolorem",
      "Description": "Exclusive coherent extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 589
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "officiis",
      "StrippedValue": "minus",
      "Description": "Customer-focused empowering core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 332
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "minus",
      "Description": "Customer-focused empowering core",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 332
        }
      }
    }
  ],
  "Source": 508,
  "ActiveErpLinks": 299,
  "ShipmentTypes": [
    {
      "Id": 993,
      "Name": "Bosco, Monahan and Hamill",
      "ToolTip": "Rerum nihil enim quia nam excepturi.",
      "Deleted": false,
      "Rank": 170,
      "Type": "voluptatem",
      "ColorBlock": 793,
      "IconHint": "ea",
      "Selected": true,
      "LastChanged": "2001-01-06T04:02:01.9253512+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "consequatur",
      "StyleHint": "unde",
      "Hidden": false,
      "FullName": "Tyreek Douglas MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 740
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 275,
      "Comment": "et",
      "Registered": "2000-09-22T04:02:01.9253512+02:00",
      "RegisteredAssociateId": 46,
      "Updated": "2000-10-12T04:02:01.9253512+02:00",
      "UpdatedAssociateId": 508,
      "LegalBaseId": 352,
      "LegalBaseKey": "aspernatur",
      "LegalBaseName": "Bergnaum, Reinger and Pollich",
      "ConsentPurposeId": 378,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "White LLC",
      "ConsentSourceId": 627,
      "ConsentSourceKey": "fugiat",
      "ConsentSourceName": "Bogisich-Fritsch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 973
        }
      }
    }
  ],
  "BounceEmails": [
    "derek@keeling.co.uk",
    "shanon@prosacco.uk"
  ],
  "ActiveStatusMonitorId": 716,
  "CreatedByFormId": 455,
  "UserDefinedFields": {
    "SuperOffice:1": "1752696926",
    "SuperOffice:2": "1091427212"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "at"
  },
  "CustomFields": {
    "CustomFields1": "fuga",
    "CustomFields2": "provident"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 555
    }
  }
}
```