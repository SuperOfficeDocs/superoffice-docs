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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 407,
  "Firstname": "Mireille",
  "MiddleName": "Windler, Jakubowski and Nienow",
  "Lastname": "Kiehn",
  "Mrmrs": "est",
  "Title": "dolorem",
  "UpdatedDate": "2009-09-30T03:51:27.5528999+02:00",
  "CreatedDate": "2014-10-02T03:51:27.5528999+02:00",
  "BirthDate": "2011-05-10T03:51:27.5528999+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ipsam",
      "StrippedValue": "ut",
      "Description": "Fully-configurable disintermediate hardware"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "ut",
      "Description": "Fully-configurable disintermediate hardware"
    }
  ],
  "Description": "Versatile global knowledge user",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "deserunt",
      "StrippedValue": "dicta",
      "Description": "Reactive human-resource portal"
    },
    {
      "Value": "deserunt",
      "StrippedValue": "dicta",
      "Description": "Reactive human-resource portal"
    }
  ],
  "Faxes": [
    {
      "Value": "at",
      "StrippedValue": "commodi",
      "Description": "Assimilated uniform matrix"
    },
    {
      "Value": "at",
      "StrippedValue": "commodi",
      "Description": "Assimilated uniform matrix"
    }
  ],
  "MobilePhones": [
    {
      "Value": "sapiente",
      "StrippedValue": "aliquid",
      "Description": "Polarised user-facing Graphic Interface"
    },
    {
      "Value": "sapiente",
      "StrippedValue": "aliquid",
      "Description": "Polarised user-facing Graphic Interface"
    }
  ],
  "OfficePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "optio",
      "Description": "Devolved intermediate focus group"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "optio",
      "Description": "Devolved intermediate focus group"
    }
  ],
  "OtherPhones": [
    {
      "Value": "consequatur",
      "StrippedValue": "est",
      "Description": "Re-contextualized intangible internet solution"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "est",
      "Description": "Re-contextualized intangible internet solution"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 419,
      "Name": "Weissnat Inc and Sons",
      "ToolTip": "Natus nulla maiores quos at pariatur.",
      "Deleted": true,
      "Rank": 354,
      "Type": "officia",
      "ColorBlock": 889,
      "IconHint": "quia",
      "Selected": true,
      "LastChanged": "2006-11-14T03:51:27.5528999+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "id",
      "StyleHint": "dolores",
      "Hidden": false,
      "FullName": "Marcia Hessel"
    }
  ],
  "PersonNumber": "705997",
  "FullName": "Dr. Yessenia Taya Gaylord Sr.",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "maxime",
      "StrippedValue": "cupiditate",
      "Description": "Networked high-level benchmark"
    },
    {
      "Value": "maxime",
      "StrippedValue": "cupiditate",
      "Description": "Networked high-level benchmark"
    }
  ],
  "FormalName": "Sauer Inc and Sons",
  "Address": null,
  "Post3": "dolorem",
  "Post2": "voluptate",
  "Post1": "ad",
  "Kanalname": "a",
  "Kanafname": "minus",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "rem",
  "ActiveInterests": 93,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 692,
  "DbiKey": "inventore",
  "DbiLastModified": "2001-12-07T03:51:27.5528999+01:00",
  "DbiLastSyncronized": "2004-01-07T03:51:27.5528999+01:00",
  "SentInfo": 717,
  "ShowContactTickets": 938,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "animi",
      "StrippedValue": "qui",
      "Description": "Grass-roots mission-critical service-desk"
    },
    {
      "Value": "animi",
      "StrippedValue": "qui",
      "Description": "Grass-roots mission-critical service-desk"
    }
  ],
  "InternetPhones": [
    {
      "Value": "ut",
      "StrippedValue": "cum",
      "Description": "Sharable object-oriented standardization"
    },
    {
      "Value": "ut",
      "StrippedValue": "cum",
      "Description": "Sharable object-oriented standardization"
    }
  ],
  "Source": 22,
  "ActiveErpLinks": 368,
  "ShipmentTypes": [
    {
      "Id": 742,
      "Name": "Shields Group",
      "ToolTip": "Officiis iure aut facere eos quae et.",
      "Deleted": false,
      "Rank": 417,
      "Type": "qui",
      "ColorBlock": 412,
      "IconHint": "praesentium",
      "Selected": true,
      "LastChanged": "2016-03-15T03:51:27.5528999+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "numquam",
      "StyleHint": "aliquam",
      "Hidden": true,
      "FullName": "Aiyana Hamill"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 361,
      "Comment": "iusto",
      "Registered": "2004-08-30T03:51:27.5528999+02:00",
      "RegisteredAssociateId": 899,
      "Updated": "2011-06-05T03:51:27.5528999+02:00",
      "UpdatedAssociateId": 488,
      "LegalBaseId": 985,
      "LegalBaseKey": "eos",
      "LegalBaseName": "Bogan-Pfeffer",
      "ConsentPurposeId": 173,
      "ConsentPurposeKey": "omnis",
      "ConsentPurposeName": "Padberg LLC",
      "ConsentSourceId": 616,
      "ConsentSourceKey": "dolorem",
      "ConsentSourceName": "Herzog-Gleichner"
    }
  ],
  "BounceEmails": [
    "duane_smith@flatleykoch.co.uk",
    "nellie.gutmann@fritsch.uk"
  ],
  "ActiveStatusMonitorId": 488,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1818742181"
  },
  "ExtraFields": {
    "ExtraFields1": "vel",
    "ExtraFields2": "incidunt"
  },
  "CustomFields": {
    "CustomFields1": "autem",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 221,
  "Firstname": "Jena",
  "MiddleName": "Ward Group",
  "Lastname": "Upton",
  "Mrmrs": "qui",
  "Title": "vel",
  "UpdatedDate": "1998-10-01T03:51:27.7247358+02:00",
  "CreatedDate": "2012-08-12T03:51:27.7247358+02:00",
  "BirthDate": "2020-11-29T03:51:27.7247358+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "eligendi",
      "StrippedValue": "nemo",
      "Description": "Face to face system-worthy artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 680
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "nemo",
      "Description": "Face to face system-worthy artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 680
        }
      }
    }
  ],
  "Description": "Future-proofed mission-critical interface",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "a",
      "StrippedValue": "consequatur",
      "Description": "Cloned scalable infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 344
        }
      }
    },
    {
      "Value": "a",
      "StrippedValue": "consequatur",
      "Description": "Cloned scalable infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 344
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "harum",
      "StrippedValue": "vel",
      "Description": "Stand-alone zero administration superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 402
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "vel",
      "Description": "Stand-alone zero administration superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 402
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "nulla",
      "StrippedValue": "natus",
      "Description": "User-friendly content-based installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 506
        }
      }
    },
    {
      "Value": "nulla",
      "StrippedValue": "natus",
      "Description": "User-friendly content-based installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 506
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "dolor",
      "StrippedValue": "autem",
      "Description": "Phased transitional approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 199
        }
      }
    },
    {
      "Value": "dolor",
      "StrippedValue": "autem",
      "Description": "Phased transitional approach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 199
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "voluptatem",
      "StrippedValue": "est",
      "Description": "Customer-focused directional collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "est",
      "Description": "Customer-focused directional collaboration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 110
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
      "Id": 302,
      "Name": "Jewess, Pagac and Weissnat",
      "ToolTip": "Quas quasi qui aut beatae autem.",
      "Deleted": true,
      "Rank": 156,
      "Type": "fugit",
      "ColorBlock": 271,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2008-03-09T03:51:27.7247358+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nihil",
      "StyleHint": "iste",
      "Hidden": false,
      "FullName": "D'angelo O'Kon",
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
  "PersonNumber": "974132",
  "FullName": "Dr. Stephania Felicita Little",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "numquam",
      "StrippedValue": "exercitationem",
      "Description": "Diverse solution-oriented array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 360
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "exercitationem",
      "Description": "Diverse solution-oriented array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 360
        }
      }
    }
  ],
  "FormalName": "Hettinger, Turcotte and Kertzmann",
  "Address": null,
  "Post3": "rerum",
  "Post2": "fugiat",
  "Post1": "voluptatem",
  "Kanalname": "pariatur",
  "Kanafname": "autem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quo",
  "ActiveInterests": 400,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 366,
  "DbiKey": "et",
  "DbiLastModified": "2011-10-24T03:51:27.7247358+02:00",
  "DbiLastSyncronized": "2014-05-29T03:51:27.7247358+02:00",
  "SentInfo": 667,
  "ShowContactTickets": 45,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "libero",
      "StrippedValue": "sit",
      "Description": "Multi-layered value-added moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 106
        }
      }
    },
    {
      "Value": "libero",
      "StrippedValue": "sit",
      "Description": "Multi-layered value-added moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 106
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "ipsum",
      "Description": "Decentralized multi-tasking solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 352
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "ipsum",
      "Description": "Decentralized multi-tasking solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 352
        }
      }
    }
  ],
  "Source": 914,
  "ActiveErpLinks": 3,
  "ShipmentTypes": [
    {
      "Id": 765,
      "Name": "Herman-Muller",
      "ToolTip": "Nihil suscipit ut libero vero.",
      "Deleted": true,
      "Rank": 239,
      "Type": "delectus",
      "ColorBlock": 525,
      "IconHint": "sunt",
      "Selected": false,
      "LastChanged": "2022-05-10T03:51:27.7247358+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "fuga",
      "Hidden": false,
      "FullName": "Sandra Kulas",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 76
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 110,
      "Comment": "sed",
      "Registered": "2014-09-10T03:51:27.7403562+02:00",
      "RegisteredAssociateId": 35,
      "Updated": "2012-08-18T03:51:27.7403562+02:00",
      "UpdatedAssociateId": 204,
      "LegalBaseId": 454,
      "LegalBaseKey": "laboriosam",
      "LegalBaseName": "Larkin-Ryan",
      "ConsentPurposeId": 260,
      "ConsentPurposeKey": "autem",
      "ConsentPurposeName": "Carter Inc and Sons",
      "ConsentSourceId": 115,
      "ConsentSourceKey": "consequatur",
      "ConsentSourceName": "Davis, Osinski and Leannon",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 165
        }
      }
    }
  ],
  "BounceEmails": [
    "gunnar@gottliebveum.ca",
    "forest@nienowritchie.biz"
  ],
  "ActiveStatusMonitorId": 18,
  "UserDefinedFields": {
    "SuperOffice:1": "Jackeline Gleason",
    "SuperOffice:2": "368824704"
  },
  "ExtraFields": {
    "ExtraFields1": "et",
    "ExtraFields2": "odio"
  },
  "CustomFields": {
    "CustomFields1": "corporis",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 502
    }
  }
}
```