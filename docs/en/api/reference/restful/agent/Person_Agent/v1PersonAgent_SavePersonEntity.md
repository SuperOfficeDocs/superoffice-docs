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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 892,
  "Firstname": "Nina",
  "MiddleName": "Harris, Kerluke and Ankunding",
  "Lastname": "Schimmel",
  "Mrmrs": "quam",
  "Title": "enim",
  "UpdatedDate": "2019-09-23T03:31:26.7925262+02:00",
  "CreatedDate": "2002-07-28T03:31:26.7925262+02:00",
  "BirthDate": "2013-08-04T03:31:26.7925262+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "animi",
      "StrippedValue": "minima",
      "Description": "Total bottom-line circuit"
    },
    {
      "Value": "animi",
      "StrippedValue": "minima",
      "Description": "Total bottom-line circuit"
    }
  ],
  "Description": "Proactive mobile moderator",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dolor",
      "StrippedValue": "aut",
      "Description": "Front-line reciprocal hierarchy"
    },
    {
      "Value": "dolor",
      "StrippedValue": "aut",
      "Description": "Front-line reciprocal hierarchy"
    }
  ],
  "Faxes": [
    {
      "Value": "debitis",
      "StrippedValue": "perferendis",
      "Description": "Diverse needs-based collaboration"
    },
    {
      "Value": "debitis",
      "StrippedValue": "perferendis",
      "Description": "Diverse needs-based collaboration"
    }
  ],
  "MobilePhones": [
    {
      "Value": "et",
      "StrippedValue": "sed",
      "Description": "Customer-focused value-added architecture"
    },
    {
      "Value": "et",
      "StrippedValue": "sed",
      "Description": "Customer-focused value-added architecture"
    }
  ],
  "OfficePhones": [
    {
      "Value": "quis",
      "StrippedValue": "consequatur",
      "Description": "Streamlined web-enabled infrastructure"
    },
    {
      "Value": "quis",
      "StrippedValue": "consequatur",
      "Description": "Streamlined web-enabled infrastructure"
    }
  ],
  "OtherPhones": [
    {
      "Value": "non",
      "StrippedValue": "voluptatem",
      "Description": "Proactive bifurcated complexity"
    },
    {
      "Value": "non",
      "StrippedValue": "voluptatem",
      "Description": "Proactive bifurcated complexity"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 460,
      "Name": "Quitzon Group",
      "ToolTip": "Velit consequatur quia et et tempore.",
      "Deleted": false,
      "Rank": 661,
      "Type": "ut",
      "ColorBlock": 9,
      "IconHint": "cumque",
      "Selected": false,
      "LastChanged": "2023-03-28T03:31:26.8081453+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quos",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Elody Kirlin"
    }
  ],
  "PersonNumber": "927868",
  "FullName": "Miss Arden Grayson Trantow I",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "fugit",
      "StrippedValue": "itaque",
      "Description": "Open-source optimizing standardization"
    },
    {
      "Value": "fugit",
      "StrippedValue": "itaque",
      "Description": "Open-source optimizing standardization"
    }
  ],
  "FormalName": "Connelly-Lueilwitz",
  "Address": null,
  "Post3": "harum",
  "Post2": "suscipit",
  "Post1": "dolorem",
  "Kanalname": "optio",
  "Kanafname": "repellat",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "expedita",
  "ActiveInterests": 10,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 53,
  "DbiKey": "totam",
  "DbiLastModified": "2014-11-27T03:31:26.8081453+01:00",
  "DbiLastSyncronized": "2000-05-29T03:31:26.8081453+02:00",
  "SentInfo": 413,
  "ShowContactTickets": 524,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "iure",
      "StrippedValue": "accusamus",
      "Description": "Streamlined local software"
    },
    {
      "Value": "iure",
      "StrippedValue": "accusamus",
      "Description": "Streamlined local software"
    }
  ],
  "InternetPhones": [
    {
      "Value": "doloremque",
      "StrippedValue": "error",
      "Description": "Focused tangible hub"
    },
    {
      "Value": "doloremque",
      "StrippedValue": "error",
      "Description": "Focused tangible hub"
    }
  ],
  "Source": 637,
  "ActiveErpLinks": 590,
  "ShipmentTypes": [
    {
      "Id": 769,
      "Name": "Little-Dickens",
      "ToolTip": "Facere repellendus molestiae.",
      "Deleted": false,
      "Rank": 109,
      "Type": "fugit",
      "ColorBlock": 12,
      "IconHint": "non",
      "Selected": false,
      "LastChanged": "2017-12-25T03:31:26.8081453+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "delectus",
      "StyleHint": "in",
      "Hidden": false,
      "FullName": "Ms. Mario Harvey"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 583,
      "Comment": "nesciunt",
      "Registered": "2007-07-04T03:31:26.8081453+02:00",
      "RegisteredAssociateId": 631,
      "Updated": "2010-03-14T03:31:26.8081453+01:00",
      "UpdatedAssociateId": 631,
      "LegalBaseId": 583,
      "LegalBaseKey": "hic",
      "LegalBaseName": "Thompson-Kirlin",
      "ConsentPurposeId": 647,
      "ConsentPurposeKey": "eos",
      "ConsentPurposeName": "Ebert-Koepp",
      "ConsentSourceId": 545,
      "ConsentSourceKey": "cumque",
      "ConsentSourceName": "Towne Inc and Sons"
    }
  ],
  "BounceEmails": [
    "tremaine_hand@blick.uk",
    "darryl@gottliebabernathy.info"
  ],
  "ActiveStatusMonitorId": 285,
  "UserDefinedFields": {
    "SuperOffice:1": "Dr. Pasquale Deon Jacobi V",
    "SuperOffice:2": "Miss Adah Rubye Swaniawski PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "asperiores"
  },
  "CustomFields": {
    "CustomFields1": "et",
    "CustomFields2": "molestias"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 227,
  "Firstname": "Darby",
  "MiddleName": "Weber, Kunze and Wilkinson",
  "Lastname": "Wehner",
  "Mrmrs": "laudantium",
  "Title": "nemo",
  "UpdatedDate": "1996-09-12T03:31:26.8081453+02:00",
  "CreatedDate": "2013-08-30T03:31:26.8081453+02:00",
  "BirthDate": "2015-03-18T03:31:26.8081453+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "tempore",
      "StrippedValue": "quam",
      "Description": "Intuitive stable intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 746
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "quam",
      "Description": "Intuitive stable intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 746
        }
      }
    }
  ],
  "Description": "Team-oriented real-time utilisation",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "tenetur",
      "Description": "Multi-tiered global interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "tenetur",
      "Description": "Multi-tiered global interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 808
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "est",
      "StrippedValue": "voluptas",
      "Description": "Universal bottom-line contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 163
        }
      }
    },
    {
      "Value": "est",
      "StrippedValue": "voluptas",
      "Description": "Universal bottom-line contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 163
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "aut",
      "StrippedValue": "sit",
      "Description": "Reduced bi-directional superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 288
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "sit",
      "Description": "Reduced bi-directional superstructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 288
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "quia",
      "StrippedValue": "rerum",
      "Description": "Automated content-based policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "rerum",
      "Description": "Automated content-based policy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 50
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quia",
      "StrippedValue": "rerum",
      "Description": "Centralized bandwidth-monitored alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 153
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "rerum",
      "Description": "Centralized bandwidth-monitored alliance",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 153
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
      "Id": 327,
      "Name": "Aufderhar Inc and Sons",
      "ToolTip": "Impedit nihil dolor.",
      "Deleted": false,
      "Rank": 506,
      "Type": "illo",
      "ColorBlock": 273,
      "IconHint": "ut",
      "Selected": true,
      "LastChanged": "2008-02-09T03:31:26.8081453+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "error",
      "StyleHint": "totam",
      "Hidden": false,
      "FullName": "Bradford Altenwerth",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 650
        }
      }
    }
  ],
  "PersonNumber": "958140",
  "FullName": "Ashlynn Kuhn",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "mollitia",
      "StrippedValue": "molestiae",
      "Description": "Centralized heuristic system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 385
        }
      }
    },
    {
      "Value": "mollitia",
      "StrippedValue": "molestiae",
      "Description": "Centralized heuristic system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 385
        }
      }
    }
  ],
  "FormalName": "Nikolaus Inc and Sons",
  "Address": null,
  "Post3": "rerum",
  "Post2": "sit",
  "Post1": "adipisci",
  "Kanalname": "maiores",
  "Kanafname": "at",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "suscipit",
  "ActiveInterests": 684,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 791,
  "DbiKey": "dolorem",
  "DbiLastModified": "2011-05-30T03:31:26.8081453+02:00",
  "DbiLastSyncronized": "2004-09-17T03:31:26.8081453+02:00",
  "SentInfo": 504,
  "ShowContactTickets": 926,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quis",
      "StrippedValue": "qui",
      "Description": "Innovative zero tolerance complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 712
        }
      }
    },
    {
      "Value": "quis",
      "StrippedValue": "qui",
      "Description": "Innovative zero tolerance complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 712
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Versatile analyzing forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 662
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "et",
      "Description": "Versatile analyzing forecast",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 662
        }
      }
    }
  ],
  "Source": 900,
  "ActiveErpLinks": 800,
  "ShipmentTypes": [
    {
      "Id": 45,
      "Name": "O'Reilly, Grady and Hauck",
      "ToolTip": "Soluta expedita.",
      "Deleted": false,
      "Rank": 829,
      "Type": "asperiores",
      "ColorBlock": 843,
      "IconHint": "illum",
      "Selected": false,
      "LastChanged": "2014-12-05T03:31:26.8081453+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "vel",
      "Hidden": false,
      "FullName": "Mr. Dariana Fadel",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 393
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 690,
      "Comment": "nemo",
      "Registered": "2005-11-18T03:31:26.8237669+01:00",
      "RegisteredAssociateId": 277,
      "Updated": "2020-09-10T03:31:26.8237669+02:00",
      "UpdatedAssociateId": 116,
      "LegalBaseId": 880,
      "LegalBaseKey": "ipsum",
      "LegalBaseName": "Wisoky, Reichel and Gerlach",
      "ConsentPurposeId": 33,
      "ConsentPurposeKey": "cumque",
      "ConsentPurposeName": "Carroll-Schaefer",
      "ConsentSourceId": 75,
      "ConsentSourceKey": "voluptate",
      "ConsentSourceName": "Mann-Von",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 102
        }
      }
    }
  ],
  "BounceEmails": [
    "clifton@muellernolan.com",
    "madelynn@stehrbuckridge.co.uk"
  ],
  "ActiveStatusMonitorId": 797,
  "UserDefinedFields": {
    "SuperOffice:1": "Andy Mose Mraz V",
    "SuperOffice:2": "821390437"
  },
  "ExtraFields": {
    "ExtraFields1": "consequatur",
    "ExtraFields2": "sint"
  },
  "CustomFields": {
    "CustomFields1": "quis",
    "CustomFields2": "fugiat"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 490
    }
  }
}
```