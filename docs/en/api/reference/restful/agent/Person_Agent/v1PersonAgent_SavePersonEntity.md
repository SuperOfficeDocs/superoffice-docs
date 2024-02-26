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
  "PersonId": 816,
  "Firstname": "Kassandra",
  "MiddleName": "Larkin, Hermiston and Feil",
  "Lastname": "Bayer",
  "Mrmrs": "neque",
  "Title": "placeat",
  "UpdatedDate": "2008-02-08T10:30:24.1350183+01:00",
  "CreatedDate": "2006-09-05T10:30:24.1350183+02:00",
  "BirthDate": "2021-06-15T10:30:24.1350183+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "natus",
      "StrippedValue": "nam",
      "Description": "Exclusive zero tolerance middleware"
    },
    {
      "Value": "natus",
      "StrippedValue": "nam",
      "Description": "Exclusive zero tolerance middleware"
    }
  ],
  "Description": "Balanced bottom-line migration",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "rerum",
      "StrippedValue": "eum",
      "Description": "Future-proofed incremental matrix"
    },
    {
      "Value": "rerum",
      "StrippedValue": "eum",
      "Description": "Future-proofed incremental matrix"
    }
  ],
  "Faxes": [
    {
      "Value": "consequatur",
      "StrippedValue": "aut",
      "Description": "Intuitive holistic productivity"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "aut",
      "Description": "Intuitive holistic productivity"
    }
  ],
  "MobilePhones": [
    {
      "Value": "ipsam",
      "StrippedValue": "mollitia",
      "Description": "Cross-group upward-trending collaboration"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "mollitia",
      "Description": "Cross-group upward-trending collaboration"
    }
  ],
  "OfficePhones": [
    {
      "Value": "veniam",
      "StrippedValue": "vel",
      "Description": "Multi-tiered didactic circuit"
    },
    {
      "Value": "veniam",
      "StrippedValue": "vel",
      "Description": "Multi-tiered didactic circuit"
    }
  ],
  "OtherPhones": [
    {
      "Value": "omnis",
      "StrippedValue": "atque",
      "Description": "Extended scalable time-frame"
    },
    {
      "Value": "omnis",
      "StrippedValue": "atque",
      "Description": "Extended scalable time-frame"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 611,
      "Name": "Renner, Beer and Sanford",
      "ToolTip": "Debitis aspernatur veritatis sit quaerat consequuntur.",
      "Deleted": true,
      "Rank": 821,
      "Type": "numquam",
      "ColorBlock": 780,
      "IconHint": "consequatur",
      "Selected": true,
      "LastChanged": "2005-01-29T10:30:24.1506438+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "quia",
      "Hidden": true,
      "FullName": "Eusebio Hermann Sr."
    }
  ],
  "PersonNumber": "57479",
  "FullName": "Dr. Alysson Jarrod Kiehn DDS",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "totam",
      "StrippedValue": "enim",
      "Description": "User-friendly clear-thinking encryption"
    },
    {
      "Value": "totam",
      "StrippedValue": "enim",
      "Description": "User-friendly clear-thinking encryption"
    }
  ],
  "FormalName": "Crooks Group",
  "Address": null,
  "Post3": "omnis",
  "Post2": "harum",
  "Post1": "reiciendis",
  "Kanalname": "quis",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "voluptas",
  "ActiveInterests": 894,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 514,
  "DbiKey": "animi",
  "DbiLastModified": "2002-04-16T10:30:24.1506438+02:00",
  "DbiLastSyncronized": "2019-02-18T10:30:24.1506438+01:00",
  "SentInfo": 167,
  "ShowContactTickets": 199,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "facilis",
      "StrippedValue": "laboriosam",
      "Description": "Visionary bifurcated knowledge user"
    },
    {
      "Value": "facilis",
      "StrippedValue": "laboriosam",
      "Description": "Visionary bifurcated knowledge user"
    }
  ],
  "InternetPhones": [
    {
      "Value": "aut",
      "StrippedValue": "iusto",
      "Description": "Operative global portal"
    },
    {
      "Value": "aut",
      "StrippedValue": "iusto",
      "Description": "Operative global portal"
    }
  ],
  "Source": 111,
  "ActiveErpLinks": 759,
  "ShipmentTypes": [
    {
      "Id": 737,
      "Name": "Morar-Kuhic",
      "ToolTip": "Nobis exercitationem ut sed natus.",
      "Deleted": false,
      "Rank": 826,
      "Type": "sunt",
      "ColorBlock": 456,
      "IconHint": "repellat",
      "Selected": false,
      "LastChanged": "2012-03-23T10:30:24.1506438+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestias",
      "StyleHint": "autem",
      "Hidden": false,
      "FullName": "Mrs. Joyce Stoltenberg III"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 170,
      "Comment": "quaerat",
      "Registered": "2007-06-06T10:30:24.1506438+02:00",
      "RegisteredAssociateId": 395,
      "Updated": "2021-05-15T10:30:24.1506438+02:00",
      "UpdatedAssociateId": 4,
      "LegalBaseId": 356,
      "LegalBaseKey": "eligendi",
      "LegalBaseName": "Mueller, Parker and Yundt",
      "ConsentPurposeId": 274,
      "ConsentPurposeKey": "nam",
      "ConsentPurposeName": "Durgan, Wolff and Krajcik",
      "ConsentSourceId": 953,
      "ConsentSourceKey": "quam",
      "ConsentSourceName": "Strosin, Wehner and Brekke"
    }
  ],
  "BounceEmails": [
    "isac_rippin@ebertbeatty.biz",
    "shania_johnston@littlelabadie.us"
  ],
  "ActiveStatusMonitorId": 475,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Kassandra Pfeffer",
    "SuperOffice:2": "Prof. Tom Joshua Jenkins"
  },
  "ExtraFields": {
    "ExtraFields1": "doloremque",
    "ExtraFields2": "quisquam"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "iusto"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 777,
  "Firstname": "Ramona",
  "MiddleName": "Will, Lockman and Goodwin",
  "Lastname": "Goodwin",
  "Mrmrs": "qui",
  "Title": "eum",
  "UpdatedDate": "2017-03-05T10:30:24.1506438+01:00",
  "CreatedDate": "1999-05-13T10:30:24.1506438+02:00",
  "BirthDate": "2004-11-26T10:30:24.1506438+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "qui",
      "StrippedValue": "odit",
      "Description": "De-engineered multi-tasking conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 233
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "odit",
      "Description": "De-engineered multi-tasking conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 233
        }
      }
    }
  ],
  "Description": "User-centric 6th generation solution",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "vel",
      "StrippedValue": "earum",
      "Description": "User-centric 6th generation toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 278
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "earum",
      "Description": "User-centric 6th generation toolset",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 278
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vel",
      "StrippedValue": "rerum",
      "Description": "Sharable systemic initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 577
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "rerum",
      "Description": "Sharable systemic initiative",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 577
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "velit",
      "StrippedValue": "deserunt",
      "Description": "Visionary dynamic definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 505
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "deserunt",
      "Description": "Visionary dynamic definition",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 505
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "rem",
      "Description": "Diverse even-keeled migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 374
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "rem",
      "Description": "Diverse even-keeled migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 374
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "vel",
      "StrippedValue": "voluptatum",
      "Description": "Optimized holistic architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 394
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "voluptatum",
      "Description": "Optimized holistic architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 394
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
      "Id": 847,
      "Name": "Reinger Inc and Sons",
      "ToolTip": "Ipsum voluptatem.",
      "Deleted": true,
      "Rank": 932,
      "Type": "hic",
      "ColorBlock": 250,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "2006-03-21T10:30:24.1506438+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vero",
      "StyleHint": "facere",
      "Hidden": true,
      "FullName": "Joy O'Conner III",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 45
        }
      }
    }
  ],
  "PersonNumber": "1664849",
  "FullName": "Mr. Edward Mills MD",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "exercitationem",
      "StrippedValue": "consequatur",
      "Description": "Automated impactful Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    },
    {
      "Value": "exercitationem",
      "StrippedValue": "consequatur",
      "Description": "Automated impactful Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 821
        }
      }
    }
  ],
  "FormalName": "Hermiston Group",
  "Address": null,
  "Post3": "ut",
  "Post2": "maxime",
  "Post1": "quia",
  "Kanalname": "qui",
  "Kanafname": "quos",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "culpa",
  "ActiveInterests": 190,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 435,
  "DbiKey": "et",
  "DbiLastModified": "2015-08-03T10:30:24.1506438+02:00",
  "DbiLastSyncronized": "2013-12-04T10:30:24.1506438+01:00",
  "SentInfo": 988,
  "ShowContactTickets": 11,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptate",
      "StrippedValue": "nam",
      "Description": "Front-line real-time structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    },
    {
      "Value": "voluptate",
      "StrippedValue": "nam",
      "Description": "Front-line real-time structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 526
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nihil",
      "StrippedValue": "nemo",
      "Description": "Implemented local capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "nemo",
      "Description": "Implemented local capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 103
        }
      }
    }
  ],
  "Source": 103,
  "ActiveErpLinks": 137,
  "ShipmentTypes": [
    {
      "Id": 889,
      "Name": "Price Group",
      "ToolTip": "Quo doloremque.",
      "Deleted": true,
      "Rank": 266,
      "Type": "quia",
      "ColorBlock": 702,
      "IconHint": "necessitatibus",
      "Selected": false,
      "LastChanged": "2022-06-02T10:30:24.1506438+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "necessitatibus",
      "StyleHint": "nemo",
      "Hidden": false,
      "FullName": "Mrs. Kobe Altenwerth MD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 36
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 2,
      "Comment": "dolore",
      "Registered": "2009-12-16T10:30:24.1506438+01:00",
      "RegisteredAssociateId": 924,
      "Updated": "2020-02-08T10:30:24.1506438+01:00",
      "UpdatedAssociateId": 435,
      "LegalBaseId": 126,
      "LegalBaseKey": "eligendi",
      "LegalBaseName": "Lind, Schumm and Cremin",
      "ConsentPurposeId": 268,
      "ConsentPurposeKey": "adipisci",
      "ConsentPurposeName": "Hagenes, Pouros and McCullough",
      "ConsentSourceId": 764,
      "ConsentSourceKey": "explicabo",
      "ConsentSourceName": "Muller LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 287
        }
      }
    }
  ],
  "BounceEmails": [
    "dasia.senger@simoniszemlak.com",
    "marilie@leuschkeschmidt.info"
  ],
  "ActiveStatusMonitorId": 831,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Raven Jeanette Jacobs IV",
    "SuperOffice:2": "Kyra Klein"
  },
  "ExtraFields": {
    "ExtraFields1": "expedita",
    "ExtraFields2": "vero"
  },
  "CustomFields": {
    "CustomFields1": "perferendis",
    "CustomFields2": "vel"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 470
    }
  }
}
```