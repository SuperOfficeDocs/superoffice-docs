---
title: POST Agents/Person/SavePersonEntity
uid: v1PersonAgent_SavePersonEntity
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
| Mrmrs | string | e.g. Mrs   sex_title  <para>Use MDO List name "mrmrs" to get list items.</para> |
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
| Position | Position | The position. This is a predefined SuperOffice value, different from Title  <para>Use MDO List name "perspos" to get list items.</para> |
| UpdatedBy | Associate | The person that last updated the person object |
| Contact | Contact | The contact the contact person is registered on. This is required unless the 'MandatoryContactOnPerson' preference is set.  <para>Use MDO List name "contact_new" to get list items.</para> |
| Country | Country | The country this contact person is located in.  <para>Use MDO List name "country" to get list items.</para> |
| Interests | array | The person's available and selected interests.  <para>Use MDO List name "persint" to get list items.</para> |
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
| Category | Category | Person's category. Usually null. Refer to the Contact.Category instead.  Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "category" to get list items.</para> |
| Business | Business | Person's business - usually blank. Use Contact.Business instead. Intended for use when individual persons are created. (i.e. when Person.Contact is blank)  <para>Use MDO List name "business" to get list items.</para> |
| Associate | Associate | The associate owning this person (similar to contact.Associate) - usually blank. Use the Person.Contact.Associate instead.  Intended for use when individual persons are created (i.e. when Person.Contact is blank)  <para>Use MDO List name "associate" to get list items.</para> |
| Salutation | string | Academic title, populated from Salutation list but can be overwritten with anything at all  <para>Use MDO List name "salutation" to get list items.</para> |
| ActiveInterests | int32 | The number of active interests. |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | <para>Use MDO List name "customerlanguage" to get list items.</para> |
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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.PersonEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 478,
  "Firstname": "Rodger",
  "MiddleName": "O'Reilly, Baumbach and Powlowski",
  "Lastname": "Koelpin",
  "Mrmrs": "itaque",
  "Title": "et",
  "UpdatedDate": "2015-06-24T11:22:38.6177546+02:00",
  "CreatedDate": "2014-01-01T11:22:38.6177546+01:00",
  "BirthDate": "2014-07-14T11:22:38.6177546+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "minima",
      "Description": "Multi-layered non-volatile middleware"
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "minima",
      "Description": "Multi-layered non-volatile middleware"
    }
  ],
  "Description": "Centralized intermediate capacity",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "explicabo",
      "StrippedValue": "libero",
      "Description": "Innovative neutral migration"
    },
    {
      "Value": "explicabo",
      "StrippedValue": "libero",
      "Description": "Innovative neutral migration"
    }
  ],
  "Faxes": [
    {
      "Value": "sint",
      "StrippedValue": "veritatis",
      "Description": "Face to face system-worthy database"
    },
    {
      "Value": "sint",
      "StrippedValue": "veritatis",
      "Description": "Face to face system-worthy database"
    }
  ],
  "MobilePhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "sit",
      "Description": "Streamlined contextually-based open architecture"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "sit",
      "Description": "Streamlined contextually-based open architecture"
    }
  ],
  "OfficePhones": [
    {
      "Value": "sit",
      "StrippedValue": "facilis",
      "Description": "Triple-buffered encompassing capability"
    },
    {
      "Value": "sit",
      "StrippedValue": "facilis",
      "Description": "Triple-buffered encompassing capability"
    }
  ],
  "OtherPhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "fugit",
      "Description": "Pre-emptive zero administration data-warehouse"
    },
    {
      "Value": "asperiores",
      "StrippedValue": "fugit",
      "Description": "Pre-emptive zero administration data-warehouse"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 902,
      "Name": "Wolff, Huels and Yost",
      "ToolTip": "Veritatis autem non voluptatem ipsam.",
      "Deleted": false,
      "Rank": 675,
      "Type": "ratione",
      "ColorBlock": 547,
      "IconHint": "sequi",
      "Selected": true,
      "LastChanged": "2002-09-18T11:22:38.6177546+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "tempora",
      "StyleHint": "vel",
      "Hidden": false,
      "FullName": "Dr. Imani Cooper Hartmann"
    }
  ],
  "PersonNumber": "228282",
  "FullName": "Maggie Harris",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "quis",
      "Description": "Intuitive background solution"
    },
    {
      "Value": "ut",
      "StrippedValue": "quis",
      "Description": "Intuitive background solution"
    }
  ],
  "FormalName": "Hegmann, Sporer and Lowe",
  "Address": null,
  "Post3": "qui",
  "Post2": "cum",
  "Post1": "magni",
  "Kanalname": "ducimus",
  "Kanafname": "doloremque",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "omnis",
  "ActiveInterests": 451,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 408,
  "DbiKey": "dolor",
  "DbiLastModified": "2011-12-16T11:22:38.6177546+01:00",
  "DbiLastSyncronized": "2013-02-20T11:22:38.6177546+01:00",
  "SentInfo": 760,
  "ShowContactTickets": 330,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "quo",
      "Description": "Exclusive human-resource success"
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "quo",
      "Description": "Exclusive human-resource success"
    }
  ],
  "InternetPhones": [
    {
      "Value": "veniam",
      "StrippedValue": "amet",
      "Description": "Reverse-engineered leading edge model"
    },
    {
      "Value": "veniam",
      "StrippedValue": "amet",
      "Description": "Reverse-engineered leading edge model"
    }
  ],
  "Source": 617,
  "ActiveErpLinks": 61,
  "ShipmentTypes": [
    {
      "Id": 422,
      "Name": "O'Conner, McLaughlin and Bailey",
      "ToolTip": "Accusantium ea voluptatibus eaque voluptatem aperiam reiciendis reprehenderit.",
      "Deleted": false,
      "Rank": 687,
      "Type": "aliquid",
      "ColorBlock": 722,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2006-05-06T11:22:38.6177546+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "beatae",
      "Hidden": false,
      "FullName": "Tate Hauck V"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 82,
      "Comment": "rerum",
      "Registered": "2007-06-22T11:22:38.6177546+02:00",
      "RegisteredAssociateId": 6,
      "Updated": "2022-01-30T11:22:38.6177546+01:00",
      "UpdatedAssociateId": 657,
      "LegalBaseId": 547,
      "LegalBaseKey": "provident",
      "LegalBaseName": "Kuvalis Inc and Sons",
      "ConsentPurposeId": 215,
      "ConsentPurposeKey": "tempore",
      "ConsentPurposeName": "Effertz-Ferry",
      "ConsentSourceId": 717,
      "ConsentSourceKey": "aut",
      "ConsentSourceName": "Watsica, Swaniawski and Deckow"
    }
  ],
  "BounceEmails": [
    "irma_russel@zemlak.co.uk",
    "lucinda_tillman@oreillydouglas.ca"
  ],
  "ActiveStatusMonitorId": 503,
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "Price Russel"
  },
  "ExtraFields": {
    "ExtraFields1": "excepturi",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "facere"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 771,
  "Firstname": "Carol",
  "MiddleName": "Lemke, Hessel and Feeney",
  "Lastname": "Wilkinson",
  "Mrmrs": "autem",
  "Title": "autem",
  "UpdatedDate": "1999-06-28T11:22:38.6177546+02:00",
  "CreatedDate": "2002-08-29T11:22:38.6177546+02:00",
  "BirthDate": "2003-04-18T11:22:38.6177546+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "distinctio",
      "StrippedValue": "est",
      "Description": "Function-based systemic info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "est",
      "Description": "Function-based systemic info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 461
        }
      }
    }
  ],
  "Description": "Balanced human-resource productivity",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "sint",
      "Description": "Team-oriented global moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 324
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "sint",
      "Description": "Team-oriented global moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 324
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "alias",
      "StrippedValue": "officiis",
      "Description": "Polarised 24 hour adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "officiis",
      "Description": "Polarised 24 hour adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 686
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "eveniet",
      "StrippedValue": "itaque",
      "Description": "Innovative dynamic complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 628
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "itaque",
      "Description": "Innovative dynamic complexity",
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
  "OfficePhones": [
    {
      "Value": "quasi",
      "StrippedValue": "temporibus",
      "Description": "Cross-group cohesive time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    },
    {
      "Value": "quasi",
      "StrippedValue": "temporibus",
      "Description": "Cross-group cohesive time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 474
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "minima",
      "Description": "Secured empowering approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 743
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "minima",
      "Description": "Secured empowering approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 743
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
      "Id": 633,
      "Name": "Kassulke-Bartoletti",
      "ToolTip": "Accusamus aut non et est.",
      "Deleted": true,
      "Rank": 708,
      "Type": "porro",
      "ColorBlock": 651,
      "IconHint": "accusamus",
      "Selected": true,
      "LastChanged": "2018-06-03T11:22:38.6333742+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "rerum",
      "Hidden": true,
      "FullName": "Mr. Santos Hailie Bruen I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 128
        }
      }
    }
  ],
  "PersonNumber": "1400753",
  "FullName": "Mrs. Elsie Vita O'Reilly Sr.",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "magnam",
      "StrippedValue": "aut",
      "Description": "Polarised local open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 638
        }
      }
    },
    {
      "Value": "magnam",
      "StrippedValue": "aut",
      "Description": "Polarised local open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 638
        }
      }
    }
  ],
  "FormalName": "Gaylord, Fahey and Thiel",
  "Address": null,
  "Post3": "quidem",
  "Post2": "deserunt",
  "Post1": "eos",
  "Kanalname": "aliquid",
  "Kanafname": "ipsum",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "aliquid",
  "ActiveInterests": 4,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 121,
  "DbiKey": "iste",
  "DbiLastModified": "2019-08-21T11:22:38.6333742+02:00",
  "DbiLastSyncronized": "2012-12-23T11:22:38.6333742+01:00",
  "SentInfo": 518,
  "ShowContactTickets": 803,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eligendi",
      "StrippedValue": "dignissimos",
      "Description": "Synchronised systemic infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 448
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "dignissimos",
      "Description": "Synchronised systemic infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 448
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "ullam",
      "StrippedValue": "suscipit",
      "Description": "Devolved background forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 514
        }
      }
    },
    {
      "Value": "ullam",
      "StrippedValue": "suscipit",
      "Description": "Devolved background forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 514
        }
      }
    }
  ],
  "Source": 429,
  "ActiveErpLinks": 269,
  "ShipmentTypes": [
    {
      "Id": 948,
      "Name": "Jacobi, Okuneva and Hudson",
      "ToolTip": "Sed sed at sed.",
      "Deleted": false,
      "Rank": 793,
      "Type": "maxime",
      "ColorBlock": 529,
      "IconHint": "maxime",
      "Selected": false,
      "LastChanged": "1996-05-23T11:22:38.6333742+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "error",
      "StyleHint": "veniam",
      "Hidden": true,
      "FullName": "Mrs. Dina Schuppe MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 701
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 382,
      "Comment": "repellendus",
      "Registered": "2018-05-24T11:22:38.6333742+02:00",
      "RegisteredAssociateId": 490,
      "Updated": "2010-02-20T11:22:38.6333742+01:00",
      "UpdatedAssociateId": 574,
      "LegalBaseId": 335,
      "LegalBaseKey": "et",
      "LegalBaseName": "Murphy, Kuhn and Littel",
      "ConsentPurposeId": 147,
      "ConsentPurposeKey": "soluta",
      "ConsentPurposeName": "Kunde-Wolff",
      "ConsentSourceId": 912,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Conroy-Tromp",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 43
        }
      }
    }
  ],
  "BounceEmails": [
    "elta_schulist@feest.co.uk",
    "orrin_romaguera@jacobibayer.us"
  ],
  "ActiveStatusMonitorId": 531,
  "UserDefinedFields": {
    "SuperOffice:1": "Mozelle Green",
    "SuperOffice:2": "Sid Schmidt"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "sunt"
  },
  "CustomFields": {
    "CustomFields1": "deleniti",
    "CustomFields2": "et"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 830
    }
  }
}
```