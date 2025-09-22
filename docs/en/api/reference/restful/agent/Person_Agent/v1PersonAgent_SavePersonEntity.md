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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 808,
  "Firstname": "Sallie",
  "MiddleName": "Jaskolski Inc and Sons",
  "Lastname": "Gorczany",
  "Mrmrs": "minima",
  "Title": "repellendus",
  "UpdatedDate": "2001-06-20T11:24:48.2813999+02:00",
  "CreatedDate": "2020-11-20T11:24:48.2813999+01:00",
  "BirthDate": "2014-10-07T11:24:48.2813999+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "similique",
      "StrippedValue": "repudiandae",
      "Description": "Progressive incremental migration"
    },
    {
      "Value": "similique",
      "StrippedValue": "repudiandae",
      "Description": "Progressive incremental migration"
    }
  ],
  "Description": "Down-sized transitional matrices",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "id",
      "StrippedValue": "et",
      "Description": "Ergonomic directional protocol"
    },
    {
      "Value": "id",
      "StrippedValue": "et",
      "Description": "Ergonomic directional protocol"
    }
  ],
  "Faxes": [
    {
      "Value": "minus",
      "StrippedValue": "labore",
      "Description": "Triple-buffered executive implementation"
    },
    {
      "Value": "minus",
      "StrippedValue": "labore",
      "Description": "Triple-buffered executive implementation"
    }
  ],
  "MobilePhones": [
    {
      "Value": "qui",
      "StrippedValue": "sapiente",
      "Description": "Self-enabling disintermediate alliance"
    },
    {
      "Value": "qui",
      "StrippedValue": "sapiente",
      "Description": "Self-enabling disintermediate alliance"
    }
  ],
  "OfficePhones": [
    {
      "Value": "illo",
      "StrippedValue": "voluptas",
      "Description": "Persistent regional emulation"
    },
    {
      "Value": "illo",
      "StrippedValue": "voluptas",
      "Description": "Persistent regional emulation"
    }
  ],
  "OtherPhones": [
    {
      "Value": "animi",
      "StrippedValue": "esse",
      "Description": "Virtual systematic frame"
    },
    {
      "Value": "animi",
      "StrippedValue": "esse",
      "Description": "Virtual systematic frame"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 139,
      "Name": "Gerlach, Reynolds and Waelchi",
      "ToolTip": "Et aut voluptatem et odit nihil aut.",
      "Deleted": false,
      "Rank": 609,
      "Type": "et",
      "ColorBlock": 302,
      "IconHint": "provident",
      "Selected": true,
      "LastChanged": "2011-05-11T11:24:48.2970242+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "fugit",
      "Hidden": false,
      "FullName": "Alicia Boyer"
    }
  ],
  "PersonNumber": "875625",
  "FullName": "Calista Yost",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "sint",
      "StrippedValue": "quo",
      "Description": "Multi-layered secondary complexity"
    },
    {
      "Value": "sint",
      "StrippedValue": "quo",
      "Description": "Multi-layered secondary complexity"
    }
  ],
  "FormalName": "Brekke, Schowalter and Mante",
  "Address": null,
  "Post3": "architecto",
  "Post2": "ut",
  "Post1": "quis",
  "Kanalname": "cumque",
  "Kanafname": "sint",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "quis",
  "ActiveInterests": 880,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 928,
  "DbiKey": "laudantium",
  "DbiLastModified": "2011-08-02T11:24:48.2970242+02:00",
  "DbiLastSyncronized": "2007-05-18T11:24:48.2970242+02:00",
  "SentInfo": 881,
  "ShowContactTickets": 312,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "officiis",
      "StrippedValue": "aut",
      "Description": "Mandatory real-time process improvement"
    },
    {
      "Value": "officiis",
      "StrippedValue": "aut",
      "Description": "Mandatory real-time process improvement"
    }
  ],
  "InternetPhones": [
    {
      "Value": "ad",
      "StrippedValue": "doloribus",
      "Description": "Balanced transitional database"
    },
    {
      "Value": "ad",
      "StrippedValue": "doloribus",
      "Description": "Balanced transitional database"
    }
  ],
  "Source": 152,
  "ActiveErpLinks": 308,
  "ShipmentTypes": [
    {
      "Id": 668,
      "Name": "Schroeder-Nolan",
      "ToolTip": "Non non ut.",
      "Deleted": false,
      "Rank": 815,
      "Type": "aut",
      "ColorBlock": 234,
      "IconHint": "odio",
      "Selected": true,
      "LastChanged": "2014-03-30T11:24:48.2970242+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestias",
      "StyleHint": "velit",
      "Hidden": false,
      "FullName": "Loren Cummerata"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 155,
      "Comment": "voluptatem",
      "Registered": "2001-10-13T11:24:48.2970242+02:00",
      "RegisteredAssociateId": 490,
      "Updated": "2002-07-27T11:24:48.2970242+02:00",
      "UpdatedAssociateId": 854,
      "LegalBaseId": 646,
      "LegalBaseKey": "tenetur",
      "LegalBaseName": "Mosciski-Hoppe",
      "ConsentPurposeId": 96,
      "ConsentPurposeKey": "quas",
      "ConsentPurposeName": "Brakus, Carroll and Cronin",
      "ConsentSourceId": 704,
      "ConsentSourceKey": "minima",
      "ConsentSourceName": "Marvin-Connelly"
    }
  ],
  "BounceEmails": [
    "roscoe@yundt.us",
    "efrain@gutmann.biz"
  ],
  "ActiveStatusMonitorId": 101,
  "CreatedByFormId": 598,
  "UtmParameters": null,
  "LeadstatusId": 984,
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Malcolm Rashad Gerlach",
    "SuperOffice:2": "203325516"
  },
  "ExtraFields": {
    "ExtraFields1": "exercitationem",
    "ExtraFields2": "eos"
  },
  "CustomFields": {
    "CustomFields1": "ipsum",
    "CustomFields2": "voluptas"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 470,
  "Firstname": "June",
  "MiddleName": "Kunze-Sporer",
  "Lastname": "Beer",
  "Mrmrs": "ipsam",
  "Title": "neque",
  "UpdatedDate": "2022-09-27T11:24:48.2970242+02:00",
  "CreatedDate": "1998-12-07T11:24:48.2970242+01:00",
  "BirthDate": "2025-09-19T11:24:48.2970242+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptatum",
      "StrippedValue": "voluptas",
      "Description": "Upgradable tangible service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 596
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "voluptas",
      "Description": "Upgradable tangible service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 596
        }
      }
    }
  ],
  "Description": "Customer-focused intangible workforce",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "nostrum",
      "StrippedValue": "iusto",
      "Description": "Persevering grid-enabled success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 949
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "iusto",
      "Description": "Persevering grid-enabled success",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 949
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "fugiat",
      "StrippedValue": "velit",
      "Description": "Vision-oriented client-server methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 327
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "velit",
      "Description": "Vision-oriented client-server methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 327
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "nostrum",
      "StrippedValue": "iste",
      "Description": "Re-engineered maximized leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    },
    {
      "Value": "nostrum",
      "StrippedValue": "iste",
      "Description": "Re-engineered maximized leverage",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 744
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "corrupti",
      "StrippedValue": "voluptatem",
      "Description": "Pre-emptive background solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "voluptatem",
      "Description": "Pre-emptive background solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 336
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "aut",
      "StrippedValue": "iusto",
      "Description": "Visionary explicit website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 390
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "iusto",
      "Description": "Visionary explicit website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 390
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
      "Id": 614,
      "Name": "Turner, Fahey and Kessler",
      "ToolTip": "Eaque rerum dicta dicta recusandae voluptate.",
      "Deleted": false,
      "Rank": 994,
      "Type": "sed",
      "ColorBlock": 855,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2019-03-25T11:24:48.2970242+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "libero",
      "StyleHint": "neque",
      "Hidden": false,
      "FullName": "Grant Wisoky II",
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
  "PersonNumber": "805179",
  "FullName": "Rosendo Goldner",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "velit",
      "StrippedValue": "illum",
      "Description": "Switchable static paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    },
    {
      "Value": "velit",
      "StrippedValue": "illum",
      "Description": "Switchable static paradigm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 94
        }
      }
    }
  ],
  "FormalName": "Kiehn, Streich and Doyle",
  "Address": null,
  "Post3": "dolore",
  "Post2": "eos",
  "Post1": "sint",
  "Kanalname": "hic",
  "Kanafname": "expedita",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ea",
  "ActiveInterests": 353,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 901,
  "DbiKey": "et",
  "DbiLastModified": "2016-08-31T11:24:48.2970242+02:00",
  "DbiLastSyncronized": "1999-03-28T11:24:48.2970242+02:00",
  "SentInfo": 673,
  "ShowContactTickets": 148,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "odio",
      "StrippedValue": "deserunt",
      "Description": "Organic contextually-based website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 488
        }
      }
    },
    {
      "Value": "odio",
      "StrippedValue": "deserunt",
      "Description": "Organic contextually-based website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 488
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "totam",
      "StrippedValue": "nam",
      "Description": "Visionary optimal concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    },
    {
      "Value": "totam",
      "StrippedValue": "nam",
      "Description": "Visionary optimal concept",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 860
        }
      }
    }
  ],
  "Source": 218,
  "ActiveErpLinks": 45,
  "ShipmentTypes": [
    {
      "Id": 48,
      "Name": "Jones LLC",
      "ToolTip": "Velit qui fugiat ab ipsa ut.",
      "Deleted": true,
      "Rank": 465,
      "Type": "non",
      "ColorBlock": 18,
      "IconHint": "nihil",
      "Selected": false,
      "LastChanged": "2016-02-07T11:24:48.2970242+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "modi",
      "StyleHint": "enim",
      "Hidden": false,
      "FullName": "Miss Fredrick Kerluke I",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 624
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 321,
      "Comment": "id",
      "Registered": "2016-09-30T11:24:48.2970242+02:00",
      "RegisteredAssociateId": 523,
      "Updated": "2022-05-11T11:24:48.2970242+02:00",
      "UpdatedAssociateId": 810,
      "LegalBaseId": 384,
      "LegalBaseKey": "unde",
      "LegalBaseName": "Rath-Beier",
      "ConsentPurposeId": 301,
      "ConsentPurposeKey": "perspiciatis",
      "ConsentPurposeName": "Blick LLC",
      "ConsentSourceId": 400,
      "ConsentSourceKey": "ratione",
      "ConsentSourceName": "Kilback, Conn and Durgan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 782
        }
      }
    }
  ],
  "BounceEmails": [
    "juvenal@bradtketillman.us",
    "loraine@gorczany.biz"
  ],
  "ActiveStatusMonitorId": 845,
  "CreatedByFormId": 555,
  "UtmParameters": null,
  "LeadstatusId": 306,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Dianna Strosin"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "blanditiis"
  },
  "CustomFields": {
    "CustomFields1": "non",
    "CustomFields2": "aut"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 355
    }
  }
}
```