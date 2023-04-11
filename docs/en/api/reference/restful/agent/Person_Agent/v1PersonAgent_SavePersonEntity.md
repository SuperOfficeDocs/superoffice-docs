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
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 753,
  "Firstname": "Lamont",
  "MiddleName": "Conn, Grimes and McGlynn",
  "Lastname": "Walter",
  "Mrmrs": "id",
  "Title": "architecto",
  "UpdatedDate": "2001-12-25T15:29:22.1828045+01:00",
  "CreatedDate": "2018-05-30T15:29:22.1828045+02:00",
  "BirthDate": "2021-12-13T15:29:22.1828045+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "rerum",
      "StrippedValue": "nihil",
      "Description": "Digitized foreground functionalities"
    },
    {
      "Value": "rerum",
      "StrippedValue": "nihil",
      "Description": "Digitized foreground functionalities"
    }
  ],
  "Description": "Sharable homogeneous artificial intelligence",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "non",
      "StrippedValue": "quia",
      "Description": "Up-sized 3rd generation budgetary management"
    },
    {
      "Value": "non",
      "StrippedValue": "quia",
      "Description": "Up-sized 3rd generation budgetary management"
    }
  ],
  "Faxes": [
    {
      "Value": "sit",
      "StrippedValue": "sit",
      "Description": "Upgradable analyzing info-mediaries"
    },
    {
      "Value": "sit",
      "StrippedValue": "sit",
      "Description": "Upgradable analyzing info-mediaries"
    }
  ],
  "MobilePhones": [
    {
      "Value": "officiis",
      "StrippedValue": "commodi",
      "Description": "Team-oriented regional internet solution"
    },
    {
      "Value": "officiis",
      "StrippedValue": "commodi",
      "Description": "Team-oriented regional internet solution"
    }
  ],
  "OfficePhones": [
    {
      "Value": "non",
      "StrippedValue": "saepe",
      "Description": "Function-based zero tolerance productivity"
    },
    {
      "Value": "non",
      "StrippedValue": "saepe",
      "Description": "Function-based zero tolerance productivity"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ad",
      "StrippedValue": "ut",
      "Description": "Exclusive actuating ability"
    },
    {
      "Value": "ad",
      "StrippedValue": "ut",
      "Description": "Exclusive actuating ability"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 849,
      "Name": "Collier Group",
      "ToolTip": "Dolorum atque ex occaecati iusto.",
      "Deleted": false,
      "Rank": 46,
      "Type": "explicabo",
      "ColorBlock": 741,
      "IconHint": "sunt",
      "Selected": false,
      "LastChanged": "2005-08-21T15:29:22.1863032+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "consequatur",
      "Hidden": false,
      "FullName": "Quinten Walker"
    }
  ],
  "PersonNumber": "999217",
  "FullName": "Velva Macejkovic",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "molestiae",
      "StrippedValue": "eos",
      "Description": "Pre-emptive executive function"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "eos",
      "Description": "Pre-emptive executive function"
    }
  ],
  "FormalName": "Funk, Kohler and Mitchell",
  "Address": null,
  "Post3": "sit",
  "Post2": "harum",
  "Post1": "ullam",
  "Kanalname": "aliquid",
  "Kanafname": "eos",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ea",
  "ActiveInterests": 647,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 992,
  "DbiKey": "rem",
  "DbiLastModified": "2021-09-27T15:29:22.1888056+02:00",
  "DbiLastSyncronized": "2009-04-01T15:29:22.1888056+02:00",
  "SentInfo": 610,
  "ShowContactTickets": 870,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quae",
      "StrippedValue": "eveniet",
      "Description": "Front-line global initiative"
    },
    {
      "Value": "quae",
      "StrippedValue": "eveniet",
      "Description": "Front-line global initiative"
    }
  ],
  "InternetPhones": [
    {
      "Value": "neque",
      "StrippedValue": "velit",
      "Description": "Business-focused local emulation"
    },
    {
      "Value": "neque",
      "StrippedValue": "velit",
      "Description": "Business-focused local emulation"
    }
  ],
  "Source": 837,
  "ActiveErpLinks": 306,
  "ShipmentTypes": [
    {
      "Id": 452,
      "Name": "Bosco, Terry and Bednar",
      "ToolTip": "Eos pariatur minus vel aliquid.",
      "Deleted": false,
      "Rank": 283,
      "Type": "dolorem",
      "ColorBlock": 690,
      "IconHint": "tempora",
      "Selected": false,
      "LastChanged": "2017-01-26T15:29:22.1893056+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "ipsa",
      "Hidden": false,
      "FullName": "Miss Elliot Hirthe"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 469,
      "Comment": "autem",
      "Registered": "2015-01-17T15:29:22.1898059+01:00",
      "RegisteredAssociateId": 998,
      "Updated": "2011-12-17T15:29:22.1898059+01:00",
      "UpdatedAssociateId": 167,
      "LegalBaseId": 815,
      "LegalBaseKey": "in",
      "LegalBaseName": "Schmidt LLC",
      "ConsentPurposeId": 582,
      "ConsentPurposeKey": "occaecati",
      "ConsentPurposeName": "Predovic Group",
      "ConsentSourceId": 446,
      "ConsentSourceKey": "voluptatem",
      "ConsentSourceName": "Weber-Little"
    }
  ],
  "BounceEmails": [
    "sidney@hermiston.name",
    "cruz@leffler.info"
  ],
  "ActiveStatusMonitorId": 173,
  "UserDefinedFields": {
    "SuperOffice:1": "Dell Nitzsche",
    "SuperOffice:2": "Ruth Lynch"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "aut"
  },
  "CustomFields": {
    "CustomFields1": "cum",
    "CustomFields2": "non"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 711,
  "Firstname": "Destany",
  "MiddleName": "Kunde, Veum and Doyle",
  "Lastname": "Weber",
  "Mrmrs": "ut",
  "Title": "incidunt",
  "UpdatedDate": "2005-04-27T15:29:22.1993055+02:00",
  "CreatedDate": "2011-12-25T15:29:22.1993055+01:00",
  "BirthDate": "2005-06-29T15:29:22.1993055+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "laboriosam",
      "Description": "User-centric client-server initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 984
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "laboriosam",
      "Description": "User-centric client-server initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 984
        }
      }
    }
  ],
  "Description": "User-friendly secondary paradigm",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "amet",
      "StrippedValue": "earum",
      "Description": "Devolved bandwidth-monitored adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 256
        }
      }
    },
    {
      "Value": "amet",
      "StrippedValue": "earum",
      "Description": "Devolved bandwidth-monitored adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 256
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "occaecati",
      "StrippedValue": "nobis",
      "Description": "Cross-group national extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 752
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "nobis",
      "Description": "Cross-group national extranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 752
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "rerum",
      "Description": "Adaptive tertiary capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 453
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "rerum",
      "Description": "Adaptive tertiary capacity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 453
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "culpa",
      "Description": "Devolved coherent forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 405
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "culpa",
      "Description": "Devolved coherent forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 405
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "tempore",
      "StrippedValue": "quasi",
      "Description": "Operative tangible Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 403
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "quasi",
      "Description": "Operative tangible Graphical User Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 403
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
      "Id": 361,
      "Name": "Treutel LLC",
      "ToolTip": "Excepturi ut aperiam magnam quae.",
      "Deleted": false,
      "Rank": 997,
      "Type": "accusantium",
      "ColorBlock": 845,
      "IconHint": "tempore",
      "Selected": false,
      "LastChanged": "2019-08-09T15:29:22.2028075+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quo",
      "StyleHint": "ut",
      "Hidden": false,
      "FullName": "Lizeth Rogahn",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 333
        }
      }
    }
  ],
  "PersonNumber": "464385",
  "FullName": "Mrs. Kaylie Labadie",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "hic",
      "StrippedValue": "velit",
      "Description": "Open-source 24 hour knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 27
        }
      }
    },
    {
      "Value": "hic",
      "StrippedValue": "velit",
      "Description": "Open-source 24 hour knowledge base",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 27
        }
      }
    }
  ],
  "FormalName": "Barton-Cummerata",
  "Address": null,
  "Post3": "voluptates",
  "Post2": "reprehenderit",
  "Post1": "perspiciatis",
  "Kanalname": "laborum",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eum",
  "ActiveInterests": 699,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 370,
  "DbiKey": "ut",
  "DbiLastModified": "1996-11-26T15:29:22.2053054+01:00",
  "DbiLastSyncronized": "2022-02-28T15:29:22.2053054+01:00",
  "SentInfo": 586,
  "ShowContactTickets": 594,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "eveniet",
      "StrippedValue": "a",
      "Description": "Open-architected maximized service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 651
        }
      }
    },
    {
      "Value": "eveniet",
      "StrippedValue": "a",
      "Description": "Open-architected maximized service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 651
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "expedita",
      "StrippedValue": "id",
      "Description": "Organized multi-state database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 112
        }
      }
    },
    {
      "Value": "expedita",
      "StrippedValue": "id",
      "Description": "Organized multi-state database",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 112
        }
      }
    }
  ],
  "Source": 546,
  "ActiveErpLinks": 154,
  "ShipmentTypes": [
    {
      "Id": 701,
      "Name": "Baumbach-Koss",
      "ToolTip": "Nostrum quia deleniti optio expedita.",
      "Deleted": false,
      "Rank": 482,
      "Type": "eius",
      "ColorBlock": 747,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "1997-07-13T15:29:22.2058059+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "sunt",
      "Hidden": true,
      "FullName": "Magdalen Lou Heaney IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 301
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 279,
      "Comment": "ut",
      "Registered": "2001-05-29T15:29:22.2063056+02:00",
      "RegisteredAssociateId": 934,
      "Updated": "2016-02-13T15:29:22.2063056+01:00",
      "UpdatedAssociateId": 465,
      "LegalBaseId": 320,
      "LegalBaseKey": "dignissimos",
      "LegalBaseName": "Medhurst-Schmeler",
      "ConsentPurposeId": 689,
      "ConsentPurposeKey": "omnis",
      "ConsentPurposeName": "Howe Inc and Sons",
      "ConsentSourceId": 348,
      "ConsentSourceKey": "est",
      "ConsentSourceName": "Hintz-Harvey",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 587
        }
      }
    }
  ],
  "BounceEmails": [
    "orpha@moen.com",
    "royce@altenwerth.info"
  ],
  "ActiveStatusMonitorId": 468,
  "UserDefinedFields": {
    "SuperOffice:1": "Jaida Kemmer",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "nam",
    "ExtraFields2": "hic"
  },
  "CustomFields": {
    "CustomFields1": "ut",
    "CustomFields2": "omnis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 664
    }
  }
}
```