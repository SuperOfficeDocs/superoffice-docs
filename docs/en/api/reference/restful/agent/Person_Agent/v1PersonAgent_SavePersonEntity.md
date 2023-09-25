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
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 513,
  "Firstname": "Patrick",
  "MiddleName": "Hansen, Turcotte and Lubowitz",
  "Lastname": "Graham",
  "Mrmrs": "autem",
  "Title": "ea",
  "UpdatedDate": "2004-01-13T03:24:47.9551276+01:00",
  "CreatedDate": "2013-07-28T03:24:47.9551276+02:00",
  "BirthDate": "2003-10-06T03:24:47.9551276+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "commodi",
      "StrippedValue": "doloremque",
      "Description": "Multi-layered logistical paradigm"
    },
    {
      "Value": "commodi",
      "StrippedValue": "doloremque",
      "Description": "Multi-layered logistical paradigm"
    }
  ],
  "Description": "Team-oriented value-added secured line",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "velit",
      "Description": "Operative regional infrastructure"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "velit",
      "Description": "Operative regional infrastructure"
    }
  ],
  "Faxes": [
    {
      "Value": "veritatis",
      "StrippedValue": "repudiandae",
      "Description": "Proactive explicit application"
    },
    {
      "Value": "veritatis",
      "StrippedValue": "repudiandae",
      "Description": "Proactive explicit application"
    }
  ],
  "MobilePhones": [
    {
      "Value": "numquam",
      "StrippedValue": "expedita",
      "Description": "Self-enabling tangible portal"
    },
    {
      "Value": "numquam",
      "StrippedValue": "expedita",
      "Description": "Self-enabling tangible portal"
    }
  ],
  "OfficePhones": [
    {
      "Value": "libero",
      "StrippedValue": "necessitatibus",
      "Description": "Digitized optimizing extranet"
    },
    {
      "Value": "libero",
      "StrippedValue": "necessitatibus",
      "Description": "Digitized optimizing extranet"
    }
  ],
  "OtherPhones": [
    {
      "Value": "nemo",
      "StrippedValue": "quia",
      "Description": "Grass-roots content-based open system"
    },
    {
      "Value": "nemo",
      "StrippedValue": "quia",
      "Description": "Grass-roots content-based open system"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 75,
      "Name": "Murray, Gibson and Jast",
      "ToolTip": "Deserunt animi aperiam sit ab nemo.",
      "Deleted": false,
      "Rank": 414,
      "Type": "veritatis",
      "ColorBlock": 454,
      "IconHint": "unde",
      "Selected": false,
      "LastChanged": "2008-04-16T03:24:47.9551276+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "accusamus",
      "StyleHint": "voluptatibus",
      "Hidden": false,
      "FullName": "Samantha Emerson Osinski PhD"
    }
  ],
  "PersonNumber": "1598939",
  "FullName": "Miss Michael Jacobi DDS",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "suscipit",
      "StrippedValue": "omnis",
      "Description": "Multi-channelled context-sensitive core"
    },
    {
      "Value": "suscipit",
      "StrippedValue": "omnis",
      "Description": "Multi-channelled context-sensitive core"
    }
  ],
  "FormalName": "Kertzmann, Wyman and Dare",
  "Address": null,
  "Post3": "aliquid",
  "Post2": "tempora",
  "Post1": "consequatur",
  "Kanalname": "excepturi",
  "Kanafname": "est",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "explicabo",
  "ActiveInterests": 39,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 910,
  "DbiKey": "et",
  "DbiLastModified": "2010-04-11T03:24:47.9551276+02:00",
  "DbiLastSyncronized": "2017-03-18T03:24:47.9551276+01:00",
  "SentInfo": 617,
  "ShowContactTickets": 134,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "temporibus",
      "StrippedValue": "laboriosam",
      "Description": "Managed bifurcated help-desk"
    },
    {
      "Value": "temporibus",
      "StrippedValue": "laboriosam",
      "Description": "Managed bifurcated help-desk"
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "ut",
      "Description": "Object-based transitional hub"
    },
    {
      "Value": "voluptas",
      "StrippedValue": "ut",
      "Description": "Object-based transitional hub"
    }
  ],
  "Source": 627,
  "ActiveErpLinks": 135,
  "ShipmentTypes": [
    {
      "Id": 10,
      "Name": "Blick Group",
      "ToolTip": "Vel ullam dolorem dolor.",
      "Deleted": false,
      "Rank": 891,
      "Type": "odit",
      "ColorBlock": 179,
      "IconHint": "sunt",
      "Selected": true,
      "LastChanged": "1998-01-10T03:24:47.9551276+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ea",
      "StyleHint": "dignissimos",
      "Hidden": false,
      "FullName": "Therese Mayert I"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 376,
      "Comment": "animi",
      "Registered": "1998-11-28T03:24:47.9551276+01:00",
      "RegisteredAssociateId": 55,
      "Updated": "2005-03-11T03:24:47.9551276+01:00",
      "UpdatedAssociateId": 347,
      "LegalBaseId": 463,
      "LegalBaseKey": "molestiae",
      "LegalBaseName": "Senger-Botsford",
      "ConsentPurposeId": 691,
      "ConsentPurposeKey": "totam",
      "ConsentPurposeName": "Thompson Inc and Sons",
      "ConsentSourceId": 163,
      "ConsentSourceKey": "dolorem",
      "ConsentSourceName": "Boyle LLC"
    }
  ],
  "BounceEmails": [
    "alva.brakus@torphy.info",
    "torrance@hartmann.com"
  ],
  "ActiveStatusMonitorId": 950,
  "UserDefinedFields": {
    "SuperOffice:1": "Boyd Hettinger",
    "SuperOffice:2": "Miss Vincent Wintheiser"
  },
  "ExtraFields": {
    "ExtraFields1": "eos",
    "ExtraFields2": "explicabo"
  },
  "CustomFields": {
    "CustomFields1": "quam",
    "CustomFields2": "ut"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 512,
  "Firstname": "Jordi",
  "MiddleName": "Torp-Bosco",
  "Lastname": "Lowe",
  "Mrmrs": "qui",
  "Title": "occaecati",
  "UpdatedDate": "2011-12-28T03:24:47.9551276+01:00",
  "CreatedDate": "2007-05-31T03:24:47.9551276+02:00",
  "BirthDate": "1997-07-20T03:24:47.9551276+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "laudantium",
      "StrippedValue": "optio",
      "Description": "Profound fresh-thinking emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 351
        }
      }
    },
    {
      "Value": "laudantium",
      "StrippedValue": "optio",
      "Description": "Profound fresh-thinking emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 351
        }
      }
    }
  ],
  "Description": "Horizontal contextually-based framework",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "eaque",
      "StrippedValue": "id",
      "Description": "Re-contextualized tangible secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 680
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "id",
      "Description": "Re-contextualized tangible secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 680
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "voluptas",
      "StrippedValue": "eum",
      "Description": "Multi-channelled local budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 404
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "eum",
      "Description": "Multi-channelled local budgetary management",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 404
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "reiciendis",
      "StrippedValue": "error",
      "Description": "Innovative secondary matrices",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 624
        }
      }
    },
    {
      "Value": "reiciendis",
      "StrippedValue": "error",
      "Description": "Innovative secondary matrices",
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
  "OfficePhones": [
    {
      "Value": "fugiat",
      "StrippedValue": "ex",
      "Description": "Realigned well-modulated parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    },
    {
      "Value": "fugiat",
      "StrippedValue": "ex",
      "Description": "Realigned well-modulated parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 774
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "eius",
      "StrippedValue": "et",
      "Description": "Synchronised systematic monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 711
        }
      }
    },
    {
      "Value": "eius",
      "StrippedValue": "et",
      "Description": "Synchronised systematic monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 711
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
      "Id": 120,
      "Name": "Frami-Olson",
      "ToolTip": "Minus aspernatur quia.",
      "Deleted": false,
      "Rank": 56,
      "Type": "maxime",
      "ColorBlock": 249,
      "IconHint": "pariatur",
      "Selected": false,
      "LastChanged": "2001-02-01T03:24:47.9551276+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "exercitationem",
      "StyleHint": "mollitia",
      "Hidden": true,
      "FullName": "Ashton Hane DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 914
        }
      }
    }
  ],
  "PersonNumber": "698087",
  "FullName": "Lorenzo Evelyn Miller V",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "corrupti",
      "StrippedValue": "occaecati",
      "Description": "Horizontal clear-thinking benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    },
    {
      "Value": "corrupti",
      "StrippedValue": "occaecati",
      "Description": "Horizontal clear-thinking benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 133
        }
      }
    }
  ],
  "FormalName": "Crist, Green and Bartell",
  "Address": null,
  "Post3": "culpa",
  "Post2": "incidunt",
  "Post1": "tenetur",
  "Kanalname": "reprehenderit",
  "Kanafname": "quisquam",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ratione",
  "ActiveInterests": 277,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 331,
  "DbiKey": "quidem",
  "DbiLastModified": "2022-09-04T03:24:47.9551276+02:00",
  "DbiLastSyncronized": "2008-06-15T03:24:47.9551276+02:00",
  "SentInfo": 420,
  "ShowContactTickets": 432,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Sharable well-modulated hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 764
        }
      }
    },
    {
      "Value": "voluptatem",
      "StrippedValue": "et",
      "Description": "Sharable well-modulated hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 764
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "quidem",
      "StrippedValue": "placeat",
      "Description": "Balanced optimal standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 915
        }
      }
    },
    {
      "Value": "quidem",
      "StrippedValue": "placeat",
      "Description": "Balanced optimal standardization",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 915
        }
      }
    }
  ],
  "Source": 564,
  "ActiveErpLinks": 447,
  "ShipmentTypes": [
    {
      "Id": 70,
      "Name": "Keebler Group",
      "ToolTip": "Ipsa nesciunt officiis sit voluptas in nam.",
      "Deleted": true,
      "Rank": 479,
      "Type": "minima",
      "ColorBlock": 645,
      "IconHint": "eum",
      "Selected": false,
      "LastChanged": "2022-04-30T03:24:47.9551276+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "iusto",
      "Hidden": true,
      "FullName": "Naomie Baumbach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 702
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 767,
      "Comment": "maxime",
      "Registered": "2007-11-08T03:24:47.9551276+01:00",
      "RegisteredAssociateId": 201,
      "Updated": "2002-11-30T03:24:47.9551276+01:00",
      "UpdatedAssociateId": 382,
      "LegalBaseId": 782,
      "LegalBaseKey": "sed",
      "LegalBaseName": "Schaefer Group",
      "ConsentPurposeId": 58,
      "ConsentPurposeKey": "et",
      "ConsentPurposeName": "O'Hara LLC",
      "ConsentSourceId": 716,
      "ConsentSourceKey": "dolores",
      "ConsentSourceName": "McDermott-Wolff",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 98
        }
      }
    }
  ],
  "BounceEmails": [
    "collin@gottlieb.com",
    "abdul@russel.uk"
  ],
  "ActiveStatusMonitorId": 550,
  "UserDefinedFields": {
    "SuperOffice:1": "Meagan Grant",
    "SuperOffice:2": "Martin Hudson Gerlach MD"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "laboriosam",
    "CustomFields2": "illum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 383
    }
  }
}
```