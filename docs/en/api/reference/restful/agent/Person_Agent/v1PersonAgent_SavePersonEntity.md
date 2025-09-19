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
  "PersonId": 12,
  "Firstname": "Trevion",
  "MiddleName": "Klein-Homenick",
  "Lastname": "Hettinger",
  "Mrmrs": "itaque",
  "Title": "fugit",
  "UpdatedDate": "1998-08-19T03:41:53.7775973+02:00",
  "CreatedDate": "2021-08-27T03:41:53.7775973+02:00",
  "BirthDate": "2019-01-10T03:41:53.7775973+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "amet",
      "StrippedValue": "ut",
      "Description": "Pre-emptive high-level capacity"
    },
    {
      "Value": "amet",
      "StrippedValue": "ut",
      "Description": "Pre-emptive high-level capacity"
    }
  ],
  "Description": "De-engineered system-worthy project",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "ut",
      "StrippedValue": "laboriosam",
      "Description": "Team-oriented scalable synergy"
    },
    {
      "Value": "ut",
      "StrippedValue": "laboriosam",
      "Description": "Team-oriented scalable synergy"
    }
  ],
  "Faxes": [
    {
      "Value": "molestiae",
      "StrippedValue": "quas",
      "Description": "Distributed 4th generation benchmark"
    },
    {
      "Value": "molestiae",
      "StrippedValue": "quas",
      "Description": "Distributed 4th generation benchmark"
    }
  ],
  "MobilePhones": [
    {
      "Value": "earum",
      "StrippedValue": "est",
      "Description": "Persevering neutral encryption"
    },
    {
      "Value": "earum",
      "StrippedValue": "est",
      "Description": "Persevering neutral encryption"
    }
  ],
  "OfficePhones": [
    {
      "Value": "inventore",
      "StrippedValue": "nemo",
      "Description": "Mandatory non-volatile methodology"
    },
    {
      "Value": "inventore",
      "StrippedValue": "nemo",
      "Description": "Mandatory non-volatile methodology"
    }
  ],
  "OtherPhones": [
    {
      "Value": "optio",
      "StrippedValue": "et",
      "Description": "De-engineered didactic database"
    },
    {
      "Value": "optio",
      "StrippedValue": "et",
      "Description": "De-engineered didactic database"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 332,
      "Name": "Runolfsson, Watsica and Terry",
      "ToolTip": "Eveniet temporibus eos quos aut hic.",
      "Deleted": false,
      "Rank": 411,
      "Type": "nemo",
      "ColorBlock": 122,
      "IconHint": "eos",
      "Selected": false,
      "LastChanged": "2003-01-01T03:41:53.7775973+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vero",
      "StyleHint": "sit",
      "Hidden": true,
      "FullName": "Enid Gerhold"
    }
  ],
  "PersonNumber": "1478450",
  "FullName": "Ms. Ramiro Shannon McKenzie Sr.",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "ex",
      "Description": "Horizontal high-level emulation"
    },
    {
      "Value": "et",
      "StrippedValue": "ex",
      "Description": "Horizontal high-level emulation"
    }
  ],
  "FormalName": "Hickle Group",
  "Address": null,
  "Post3": "at",
  "Post2": "ex",
  "Post1": "sunt",
  "Kanalname": "rerum",
  "Kanafname": "quod",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "soluta",
  "ActiveInterests": 301,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 808,
  "DbiKey": "ut",
  "DbiLastModified": "2024-02-15T03:41:53.7775973+01:00",
  "DbiLastSyncronized": "2022-02-08T03:41:53.7775973+01:00",
  "SentInfo": 356,
  "ShowContactTickets": 740,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "ea",
      "StrippedValue": "aut",
      "Description": "Assimilated optimal application"
    },
    {
      "Value": "ea",
      "StrippedValue": "aut",
      "Description": "Assimilated optimal application"
    }
  ],
  "InternetPhones": [
    {
      "Value": "et",
      "StrippedValue": "id",
      "Description": "Organic national artificial intelligence"
    },
    {
      "Value": "et",
      "StrippedValue": "id",
      "Description": "Organic national artificial intelligence"
    }
  ],
  "Source": 291,
  "ActiveErpLinks": 13,
  "ShipmentTypes": [
    {
      "Id": 985,
      "Name": "Carroll LLC",
      "ToolTip": "Vel ex mollitia sit molestias labore quia sint.",
      "Deleted": true,
      "Rank": 392,
      "Type": "eum",
      "ColorBlock": 624,
      "IconHint": "rerum",
      "Selected": false,
      "LastChanged": "2015-12-28T03:41:53.7775973+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "excepturi",
      "Hidden": false,
      "FullName": "Terence Braun"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 843,
      "Comment": "voluptatem",
      "Registered": "1999-09-23T03:41:53.7775973+02:00",
      "RegisteredAssociateId": 212,
      "Updated": "2021-06-02T03:41:53.7775973+02:00",
      "UpdatedAssociateId": 891,
      "LegalBaseId": 782,
      "LegalBaseKey": "consequatur",
      "LegalBaseName": "Waters, Schulist and Conn",
      "ConsentPurposeId": 440,
      "ConsentPurposeKey": "temporibus",
      "ConsentPurposeName": "Weimann Group",
      "ConsentSourceId": 110,
      "ConsentSourceKey": "quisquam",
      "ConsentSourceName": "Hermann, Rodriguez and Prohaska"
    }
  ],
  "BounceEmails": [
    "diana_denesik@kulas.ca",
    "daron@cummerata.name"
  ],
  "ActiveStatusMonitorId": 488,
  "CreatedByFormId": 554,
  "UtmParameters": null,
  "LeadstatusId": 838,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Myrna Mosciski"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "voluptatibus"
  },
  "CustomFields": {
    "CustomFields1": "a",
    "CustomFields2": "et"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 772,
  "Firstname": "Shaylee",
  "MiddleName": "Bins-Luettgen",
  "Lastname": "Donnelly",
  "Mrmrs": "cupiditate",
  "Title": "quis",
  "UpdatedDate": "2011-09-25T03:41:53.7932225+02:00",
  "CreatedDate": "2001-07-08T03:41:53.7932225+02:00",
  "BirthDate": "1999-04-22T03:41:53.7932225+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "dolorem",
      "StrippedValue": "consequatur",
      "Description": "Visionary object-oriented website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "consequatur",
      "Description": "Visionary object-oriented website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 999
        }
      }
    }
  ],
  "Description": "Synergized responsive access",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "molestiae",
      "StrippedValue": "qui",
      "Description": "Adaptive bottom-line success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 61
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "qui",
      "Description": "Adaptive bottom-line success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 61
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "doloribus",
      "StrippedValue": "laboriosam",
      "Description": "Fundamental clear-thinking data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 349
        }
      }
    },
    {
      "Value": "doloribus",
      "StrippedValue": "laboriosam",
      "Description": "Fundamental clear-thinking data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 349
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "illo",
      "Description": "Ergonomic background frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 934
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "illo",
      "Description": "Ergonomic background frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 934
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aut",
      "StrippedValue": "in",
      "Description": "User-friendly 3rd generation standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "in",
      "Description": "User-friendly 3rd generation standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 522
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "nisi",
      "StrippedValue": "consectetur",
      "Description": "Reactive responsive website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 719
        }
      }
    },
    {
      "Value": "nisi",
      "StrippedValue": "consectetur",
      "Description": "Reactive responsive website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 719
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
      "Id": 489,
      "Name": "Schinner-Lebsack",
      "ToolTip": "Omnis est alias.",
      "Deleted": false,
      "Rank": 662,
      "Type": "reiciendis",
      "ColorBlock": 10,
      "IconHint": "alias",
      "Selected": true,
      "LastChanged": "2012-01-31T03:41:53.7932225+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quis",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Opal Elmore Torphy Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 414
        }
      }
    }
  ],
  "PersonNumber": "768317",
  "FullName": "Ms. Stephany Laurianne Hickle I",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "culpa",
      "StrippedValue": "quia",
      "Description": "Future-proofed client-server firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    },
    {
      "Value": "culpa",
      "StrippedValue": "quia",
      "Description": "Future-proofed client-server firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 831
        }
      }
    }
  ],
  "FormalName": "Beer Group",
  "Address": null,
  "Post3": "numquam",
  "Post2": "quae",
  "Post1": "doloremque",
  "Kanalname": "non",
  "Kanafname": "qui",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "reiciendis",
  "ActiveInterests": 996,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 123,
  "DbiKey": "aut",
  "DbiLastModified": "2022-10-09T03:41:53.7932225+02:00",
  "DbiLastSyncronized": "2012-06-02T03:41:53.7932225+02:00",
  "SentInfo": 819,
  "ShowContactTickets": 164,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "atque",
      "StrippedValue": "ducimus",
      "Description": "Digitized user-facing open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 154
        }
      }
    },
    {
      "Value": "atque",
      "StrippedValue": "ducimus",
      "Description": "Digitized user-facing open architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 154
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quia",
      "StrippedValue": "qui",
      "Description": "Extended scalable focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 125
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "qui",
      "Description": "Extended scalable focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 125
        }
      }
    }
  ],
  "Source": 329,
  "ActiveErpLinks": 832,
  "ShipmentTypes": [
    {
      "Id": 111,
      "Name": "Hegmann-Jast",
      "ToolTip": "Aliquid veritatis nam accusantium sint.",
      "Deleted": false,
      "Rank": 419,
      "Type": "et",
      "ColorBlock": 985,
      "IconHint": "earum",
      "Selected": false,
      "LastChanged": "2006-05-15T03:41:53.7932225+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "assumenda",
      "StyleHint": "incidunt",
      "Hidden": false,
      "FullName": "Graham Greenholt",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 206
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 398,
      "Comment": "sit",
      "Registered": "2025-09-14T03:41:53.7932225+02:00",
      "RegisteredAssociateId": 918,
      "Updated": "2021-06-30T03:41:53.7932225+02:00",
      "UpdatedAssociateId": 465,
      "LegalBaseId": 435,
      "LegalBaseKey": "et",
      "LegalBaseName": "Wisozk Group",
      "ConsentPurposeId": 171,
      "ConsentPurposeKey": "voluptas",
      "ConsentPurposeName": "Sauer, Hartmann and Hartmann",
      "ConsentSourceId": 925,
      "ConsentSourceKey": "officiis",
      "ConsentSourceName": "Mayer, Erdman and Brekke",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 734
        }
      }
    }
  ],
  "BounceEmails": [
    "marcelino.olson@smitham.uk",
    "emmett_kerluke@hoegerwaters.biz"
  ],
  "ActiveStatusMonitorId": 758,
  "CreatedByFormId": 864,
  "UtmParameters": null,
  "LeadstatusId": 715,
  "UserDefinedFields": {
    "SuperOffice:1": "1641433547",
    "SuperOffice:2": "Ms. Nya Rippin III"
  },
  "ExtraFields": {
    "ExtraFields1": "cum",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "vel",
    "CustomFields2": "facilis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 309
    }
  }
}
```