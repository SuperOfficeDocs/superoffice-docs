---
title: PUT Person/{id}
uid: v1PersonEntity_PutPersonEntity
generated: true
---

# PUT Person/{id}

```http
PUT /api/v1/Person/{id}
```

Updates the existing PersonEntity






| Path Part | Type | Description |
|-----------|------|-------------|
| id | int32 | The PersonEntity id to update. **Required** |


## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
PUT /api/v1/Person/{id}?$select=name,department,category/id
```


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

PersonEntity updated.

| Response | Description |
|----------------|-------------|
| 200 | PersonEntity updated. |
| 412 | Update stopped because PersonEntity has changed since the requested If-Unmodified-Since timestamp. |
| 400 | Bad request. Entity to save is not in request body. |

### Response body: PersonEntityWithLinks

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
| _Links | object |  |

## Sample request

```http!
PUT /api/v1/Person/{id}
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 136,
  "Firstname": "Edwin",
  "MiddleName": "Spinka-McCullough",
  "Lastname": "Cummings",
  "Mrmrs": "cum",
  "Title": "fuga",
  "UpdatedDate": "2018-08-24T03:24:51.6618476+02:00",
  "CreatedDate": "2017-10-09T03:24:51.6618476+02:00",
  "BirthDate": "2006-01-24T03:24:51.6618476+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quae",
      "StrippedValue": "doloribus",
      "Description": "Distributed neutral info-mediaries"
    },
    {
      "Value": "quae",
      "StrippedValue": "doloribus",
      "Description": "Distributed neutral info-mediaries"
    }
  ],
  "Description": "Re-contextualized national pricing structure",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "repellat",
      "StrippedValue": "commodi",
      "Description": "Enhanced multi-tasking function"
    },
    {
      "Value": "repellat",
      "StrippedValue": "commodi",
      "Description": "Enhanced multi-tasking function"
    }
  ],
  "Faxes": [
    {
      "Value": "deserunt",
      "StrippedValue": "reiciendis",
      "Description": "Profound multimedia product"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "reiciendis",
      "Description": "Profound multimedia product"
    }
  ],
  "MobilePhones": [
    {
      "Value": "esse",
      "StrippedValue": "non",
      "Description": "Proactive local adapter"
    },
    {
      "Value": "esse",
      "StrippedValue": "non",
      "Description": "Proactive local adapter"
    }
  ],
  "OfficePhones": [
    {
      "Value": "commodi",
      "StrippedValue": "ut",
      "Description": "Self-enabling regional workforce"
    },
    {
      "Value": "commodi",
      "StrippedValue": "ut",
      "Description": "Self-enabling regional workforce"
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "ex",
      "Description": "Customizable modular software"
    },
    {
      "Value": "et",
      "StrippedValue": "ex",
      "Description": "Customizable modular software"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 416,
      "Name": "Moore, Skiles and Kautzer",
      "ToolTip": "Earum reprehenderit alias.",
      "Deleted": false,
      "Rank": 727,
      "Type": "fugit",
      "ColorBlock": 852,
      "IconHint": "et",
      "Selected": false,
      "LastChanged": "1997-07-21T03:24:51.6618476+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "repudiandae",
      "StyleHint": "modi",
      "Hidden": false,
      "FullName": "Ned Stanton"
    }
  ],
  "PersonNumber": "368851",
  "FullName": "Evert Goyette",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "porro",
      "StrippedValue": "debitis",
      "Description": "Multi-channelled tertiary support"
    },
    {
      "Value": "porro",
      "StrippedValue": "debitis",
      "Description": "Multi-channelled tertiary support"
    }
  ],
  "FormalName": "Gottlieb, Turcotte and Kshlerin",
  "Address": null,
  "Post3": "quod",
  "Post2": "dolorem",
  "Post1": "similique",
  "Kanalname": "quasi",
  "Kanafname": "facere",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "numquam",
  "ActiveInterests": 725,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 600,
  "DbiKey": "quae",
  "DbiLastModified": "1996-09-09T03:24:51.6618476+02:00",
  "DbiLastSyncronized": "2008-07-21T03:24:51.6618476+02:00",
  "SentInfo": 26,
  "ShowContactTickets": 770,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "nemo",
      "StrippedValue": "distinctio",
      "Description": "Vision-oriented mission-critical service-desk"
    },
    {
      "Value": "nemo",
      "StrippedValue": "distinctio",
      "Description": "Vision-oriented mission-critical service-desk"
    }
  ],
  "InternetPhones": [
    {
      "Value": "est",
      "StrippedValue": "quia",
      "Description": "Pre-emptive directional functionalities"
    },
    {
      "Value": "est",
      "StrippedValue": "quia",
      "Description": "Pre-emptive directional functionalities"
    }
  ],
  "Source": 68,
  "ActiveErpLinks": 12,
  "ShipmentTypes": [
    {
      "Id": 701,
      "Name": "Waelchi Inc and Sons",
      "ToolTip": "Aut accusamus iste recusandae.",
      "Deleted": false,
      "Rank": 135,
      "Type": "qui",
      "ColorBlock": 154,
      "IconHint": "ipsam",
      "Selected": false,
      "LastChanged": "1998-02-01T03:24:51.6618476+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptas",
      "StyleHint": "tempora",
      "Hidden": false,
      "FullName": "Garland Ledner"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 988,
      "Comment": "eos",
      "Registered": "2014-04-22T03:24:51.6618476+02:00",
      "RegisteredAssociateId": 601,
      "Updated": "2012-03-06T03:24:51.6618476+01:00",
      "UpdatedAssociateId": 73,
      "LegalBaseId": 58,
      "LegalBaseKey": "sed",
      "LegalBaseName": "Abshire Group",
      "ConsentPurposeId": 68,
      "ConsentPurposeKey": "inventore",
      "ConsentPurposeName": "Hilll Group",
      "ConsentSourceId": 419,
      "ConsentSourceKey": "perspiciatis",
      "ConsentSourceName": "VonRueden-Lehner"
    }
  ],
  "BounceEmails": [
    "elda.maggio@witting.uk",
    "maximilian.bernhard@gerlachking.co.uk"
  ],
  "ActiveStatusMonitorId": 955,
  "UserDefinedFields": {
    "SuperOffice:1": "Dina Bergnaum",
    "SuperOffice:2": "Mr. Celia Bradtke IV"
  },
  "ExtraFields": {
    "ExtraFields1": "sunt",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "aspernatur",
    "CustomFields2": "omnis"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 PersonEntity updated.
Content-Type: application/json; charset=utf-8

{
  "PersonId": 445,
  "Firstname": "Jeromy",
  "MiddleName": "Nolan LLC",
  "Lastname": "Hartmann",
  "Mrmrs": "placeat",
  "Title": "beatae",
  "UpdatedDate": "2021-08-24T03:24:51.6618476+02:00",
  "CreatedDate": "2013-03-15T03:24:51.6618476+01:00",
  "BirthDate": "2018-01-04T03:24:51.6618476+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quisquam",
      "StrippedValue": "amet",
      "Description": "Multi-layered static matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 916
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "amet",
      "Description": "Multi-layered static matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 916
        }
      }
    }
  ],
  "Description": "Devolved empowering artificial intelligence",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "distinctio",
      "StrippedValue": "totam",
      "Description": "Ameliorated holistic synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 717
        }
      }
    },
    {
      "Value": "distinctio",
      "StrippedValue": "totam",
      "Description": "Ameliorated holistic synergy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 717
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quia",
      "StrippedValue": "veritatis",
      "Description": "Monitored reciprocal process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "veritatis",
      "Description": "Monitored reciprocal process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 497
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "non",
      "Description": "Multi-channelled local middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 633
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "non",
      "Description": "Multi-channelled local middleware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 633
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quam",
      "StrippedValue": "et",
      "Description": "Ergonomic client-driven moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "et",
      "Description": "Ergonomic client-driven moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 683
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "labore",
      "Description": "User-friendly uniform open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 93
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "labore",
      "Description": "User-friendly uniform open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 93
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
      "Id": 189,
      "Name": "Conroy LLC",
      "ToolTip": "Eos ipsa accusantium laborum fugit aut et.",
      "Deleted": true,
      "Rank": 515,
      "Type": "magnam",
      "ColorBlock": 305,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2015-08-30T03:24:51.6618476+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "dolorem",
      "Hidden": false,
      "FullName": "Brooke Schneider",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 530
        }
      }
    }
  ],
  "PersonNumber": "1346052",
  "FullName": "Dr. Lucie Little V",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "tempore",
      "StrippedValue": "illum",
      "Description": "Face to face client-driven service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 878
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "illum",
      "Description": "Face to face client-driven service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 878
        }
      }
    }
  ],
  "FormalName": "Spencer Group",
  "Address": null,
  "Post3": "expedita",
  "Post2": "totam",
  "Post1": "iusto",
  "Kanalname": "velit",
  "Kanafname": "quasi",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "modi",
  "ActiveInterests": 528,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 852,
  "DbiKey": "nostrum",
  "DbiLastModified": "2023-03-05T03:24:51.6774721+01:00",
  "DbiLastSyncronized": "2002-08-13T03:24:51.6774721+02:00",
  "SentInfo": 832,
  "ShowContactTickets": 948,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "excepturi",
      "StrippedValue": "sed",
      "Description": "Versatile background groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
        }
      }
    },
    {
      "Value": "excepturi",
      "StrippedValue": "sed",
      "Description": "Versatile background groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 901
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "impedit",
      "StrippedValue": "in",
      "Description": "Mandatory user-facing neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    },
    {
      "Value": "impedit",
      "StrippedValue": "in",
      "Description": "Mandatory user-facing neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 116
        }
      }
    }
  ],
  "Source": 771,
  "ActiveErpLinks": 248,
  "ShipmentTypes": [
    {
      "Id": 820,
      "Name": "Kertzmann-Auer",
      "ToolTip": "Sit rerum ut exercitationem dolorem harum expedita.",
      "Deleted": true,
      "Rank": 516,
      "Type": "est",
      "ColorBlock": 597,
      "IconHint": "placeat",
      "Selected": false,
      "LastChanged": "2003-09-10T03:24:51.6774721+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "inventore",
      "StyleHint": "in",
      "Hidden": false,
      "FullName": "Beryl Homenick Jr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 864
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 239,
      "Comment": "laudantium",
      "Registered": "2020-07-31T03:24:51.6774721+02:00",
      "RegisteredAssociateId": 830,
      "Updated": "2019-10-09T03:24:51.6774721+02:00",
      "UpdatedAssociateId": 681,
      "LegalBaseId": 406,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Hilpert Group",
      "ConsentPurposeId": 204,
      "ConsentPurposeKey": "nostrum",
      "ConsentPurposeName": "Bernier, Leuschke and Wilkinson",
      "ConsentSourceId": 635,
      "ConsentSourceKey": "eos",
      "ConsentSourceName": "Harber Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 937
        }
      }
    }
  ],
  "BounceEmails": [
    "clifford@konopelskiframi.info",
    "kiley_kunde@brownbogisich.co.uk"
  ],
  "ActiveStatusMonitorId": 650,
  "UserDefinedFields": {
    "SuperOffice:1": "Ray Herzog",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "deserunt",
    "ExtraFields2": "velit"
  },
  "CustomFields": {
    "CustomFields1": "dolorem",
    "CustomFields2": "qui"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 669
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```