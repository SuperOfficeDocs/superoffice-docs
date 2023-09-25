---
title: POST Person
uid: v1PersonEntity_PostPersonEntity
generated: true
---

# POST Person

```http
POST /api/v1/Person
```

Creates a new PersonEntity


Calls the Person agent service SavePersonEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Person?$select=name,department,category/id
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

## Request Body: newEntity 

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
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "PersonId": 265,
  "Firstname": "Ike",
  "MiddleName": "Bernhard-Shanahan",
  "Lastname": "Hoppe",
  "Mrmrs": "quidem",
  "Title": "numquam",
  "UpdatedDate": "2012-02-16T03:24:51.6462285+01:00",
  "CreatedDate": "1996-05-08T03:24:51.6462285+02:00",
  "BirthDate": "2006-01-14T03:24:51.6462285+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "eius",
      "StrippedValue": "est",
      "Description": "Diverse client-driven interface"
    },
    {
      "Value": "eius",
      "StrippedValue": "est",
      "Description": "Diverse client-driven interface"
    }
  ],
  "Description": "Operative object-oriented open system",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "odit",
      "StrippedValue": "dicta",
      "Description": "Diverse real-time interface"
    },
    {
      "Value": "odit",
      "StrippedValue": "dicta",
      "Description": "Diverse real-time interface"
    }
  ],
  "Faxes": [
    {
      "Value": "ad",
      "StrippedValue": "quia",
      "Description": "Mandatory tertiary forecast"
    },
    {
      "Value": "ad",
      "StrippedValue": "quia",
      "Description": "Mandatory tertiary forecast"
    }
  ],
  "MobilePhones": [
    {
      "Value": "in",
      "StrippedValue": "natus",
      "Description": "Automated full-range success"
    },
    {
      "Value": "in",
      "StrippedValue": "natus",
      "Description": "Automated full-range success"
    }
  ],
  "OfficePhones": [
    {
      "Value": "eveniet",
      "StrippedValue": "quod",
      "Description": "Monitored intangible standardization"
    },
    {
      "Value": "eveniet",
      "StrippedValue": "quod",
      "Description": "Monitored intangible standardization"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ipsam",
      "StrippedValue": "recusandae",
      "Description": "Adaptive directional knowledge user"
    },
    {
      "Value": "ipsam",
      "StrippedValue": "recusandae",
      "Description": "Adaptive directional knowledge user"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 922,
      "Name": "Glover Group",
      "ToolTip": "Ipsum cum temporibus fugit suscipit atque.",
      "Deleted": false,
      "Rank": 65,
      "Type": "tempore",
      "ColorBlock": 108,
      "IconHint": "blanditiis",
      "Selected": false,
      "LastChanged": "2008-03-06T03:24:51.6462285+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "amet",
      "Hidden": false,
      "FullName": "Miss Collin Denesik"
    }
  ],
  "PersonNumber": "666896",
  "FullName": "Mr. Forest Harmony Block",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "voluptatum",
      "StrippedValue": "voluptatem",
      "Description": "Quality-focused logistical access"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "voluptatem",
      "Description": "Quality-focused logistical access"
    }
  ],
  "FormalName": "Huels, Cormier and McCullough",
  "Address": null,
  "Post3": "consequatur",
  "Post2": "voluptatibus",
  "Post1": "est",
  "Kanalname": "esse",
  "Kanafname": "aut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "aperiam",
  "ActiveInterests": 477,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 818,
  "DbiKey": "magni",
  "DbiLastModified": "2011-08-05T03:24:51.6462285+02:00",
  "DbiLastSyncronized": "1998-06-01T03:24:51.6462285+02:00",
  "SentInfo": 832,
  "ShowContactTickets": 257,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "provident",
      "StrippedValue": "ex",
      "Description": "Centralized object-oriented instruction set"
    },
    {
      "Value": "provident",
      "StrippedValue": "ex",
      "Description": "Centralized object-oriented instruction set"
    }
  ],
  "InternetPhones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "qui",
      "Description": "Balanced executive challenge"
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "qui",
      "Description": "Balanced executive challenge"
    }
  ],
  "Source": 413,
  "ActiveErpLinks": 432,
  "ShipmentTypes": [
    {
      "Id": 978,
      "Name": "Graham-Bode",
      "ToolTip": "Totam illo illo necessitatibus autem eius.",
      "Deleted": false,
      "Rank": 325,
      "Type": "voluptates",
      "ColorBlock": 824,
      "IconHint": "laboriosam",
      "Selected": true,
      "LastChanged": "1998-08-28T03:24:51.6462285+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "necessitatibus",
      "Hidden": false,
      "FullName": "Miss Brennan Bergstrom DDS"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 804,
      "Comment": "quas",
      "Registered": "2010-11-27T03:24:51.6462285+01:00",
      "RegisteredAssociateId": 317,
      "Updated": "2013-04-14T03:24:51.6462285+02:00",
      "UpdatedAssociateId": 335,
      "LegalBaseId": 140,
      "LegalBaseKey": "error",
      "LegalBaseName": "Jaskolski Inc and Sons",
      "ConsentPurposeId": 372,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "McDermott-Wehner",
      "ConsentSourceId": 677,
      "ConsentSourceKey": "deleniti",
      "ConsentSourceName": "Eichmann LLC"
    }
  ],
  "BounceEmails": [
    "creola@hamill.info",
    "bernita@west.name"
  ],
  "ActiveStatusMonitorId": 978,
  "UserDefinedFields": {
    "SuperOffice:1": "Geovanni Tremblay V",
    "SuperOffice:2": "1325563788"
  },
  "ExtraFields": {
    "ExtraFields1": "accusantium",
    "ExtraFields2": "enim"
  },
  "CustomFields": {
    "CustomFields1": "eos",
    "CustomFields2": "laudantium"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 486,
  "Firstname": "Merlin",
  "MiddleName": "Jacobi-Ryan",
  "Lastname": "Feeney",
  "Mrmrs": "at",
  "Title": "sit",
  "UpdatedDate": "2010-05-17T03:24:51.6462285+02:00",
  "CreatedDate": "2000-02-13T03:24:51.6462285+01:00",
  "BirthDate": "2007-07-27T03:24:51.6462285+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "corporis",
      "StrippedValue": "et",
      "Description": "Streamlined responsive secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 419
        }
      }
    },
    {
      "Value": "corporis",
      "StrippedValue": "et",
      "Description": "Streamlined responsive secured line",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 419
        }
      }
    }
  ],
  "Description": "Multi-channelled incremental service-desk",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "ut",
      "StrippedValue": "consequatur",
      "Description": "Synchronised needs-based interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 117
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "consequatur",
      "Description": "Synchronised needs-based interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 117
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "rerum",
      "StrippedValue": "voluptatem",
      "Description": "Realigned bottom-line frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 231
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "voluptatem",
      "Description": "Realigned bottom-line frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 231
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quam",
      "StrippedValue": "deleniti",
      "Description": "Operative neutral strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "deleniti",
      "Description": "Operative neutral strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 450
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "aut",
      "StrippedValue": "eum",
      "Description": "Persistent bandwidth-monitored array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "eum",
      "Description": "Persistent bandwidth-monitored array",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 170
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quaerat",
      "StrippedValue": "excepturi",
      "Description": "Reactive incremental neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 843
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "excepturi",
      "Description": "Reactive incremental neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 843
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
      "Id": 310,
      "Name": "Welch-Kunde",
      "ToolTip": "Odit adipisci voluptatibus consequatur enim.",
      "Deleted": false,
      "Rank": 824,
      "Type": "occaecati",
      "ColorBlock": 1002,
      "IconHint": "non",
      "Selected": true,
      "LastChanged": "2002-04-11T03:24:51.6462285+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "similique",
      "StyleHint": "ex",
      "Hidden": false,
      "FullName": "David VonRueden",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 665
        }
      }
    }
  ],
  "PersonNumber": "570263",
  "FullName": "Chloe McCullough",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "vel",
      "StrippedValue": "dolorem",
      "Description": "Fundamental 24 hour hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 335
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "dolorem",
      "Description": "Fundamental 24 hour hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 335
        }
      }
    }
  ],
  "FormalName": "Hickle LLC",
  "Address": null,
  "Post3": "distinctio",
  "Post2": "dolor",
  "Post1": "sed",
  "Kanalname": "sint",
  "Kanafname": "tempore",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "enim",
  "ActiveInterests": 488,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 541,
  "DbiKey": "sint",
  "DbiLastModified": "2013-10-02T03:24:51.6462285+02:00",
  "DbiLastSyncronized": "2009-05-06T03:24:51.6462285+02:00",
  "SentInfo": 184,
  "ShowContactTickets": 34,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "expedita",
      "Description": "Up-sized reciprocal open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 114
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "expedita",
      "Description": "Up-sized reciprocal open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 114
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "voluptas",
      "StrippedValue": "ea",
      "Description": "Reduced high-level complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 721
        }
      }
    },
    {
      "Value": "voluptas",
      "StrippedValue": "ea",
      "Description": "Reduced high-level complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 721
        }
      }
    }
  ],
  "Source": 114,
  "ActiveErpLinks": 974,
  "ShipmentTypes": [
    {
      "Id": 336,
      "Name": "Veum, Waters and Metz",
      "ToolTip": "Soluta optio quis velit eum eius.",
      "Deleted": true,
      "Rank": 773,
      "Type": "nesciunt",
      "ColorBlock": 220,
      "IconHint": "voluptate",
      "Selected": true,
      "LastChanged": "2019-09-06T03:24:51.6462285+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sed",
      "StyleHint": "eum",
      "Hidden": false,
      "FullName": "Corbin O'Hara",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 577,
      "Comment": "voluptas",
      "Registered": "2022-08-26T03:24:51.6462285+02:00",
      "RegisteredAssociateId": 727,
      "Updated": "2015-09-16T03:24:51.6462285+02:00",
      "UpdatedAssociateId": 220,
      "LegalBaseId": 633,
      "LegalBaseKey": "nihil",
      "LegalBaseName": "Nikolaus Group",
      "ConsentPurposeId": 534,
      "ConsentPurposeKey": "quo",
      "ConsentPurposeName": "Koch, Terry and Ziemann",
      "ConsentSourceId": 765,
      "ConsentSourceKey": "enim",
      "ConsentSourceName": "Reinger, Kilback and Little",
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
  "BounceEmails": [
    "carmine@faylangworth.com",
    "eric_bartoletti@fahey.info"
  ],
  "ActiveStatusMonitorId": 517,
  "UserDefinedFields": {
    "SuperOffice:1": "Heather Collins",
    "SuperOffice:2": "2142424265"
  },
  "ExtraFields": {
    "ExtraFields1": "ducimus",
    "ExtraFields2": "modi"
  },
  "CustomFields": {
    "CustomFields1": "ratione",
    "CustomFields2": "praesentium"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 987
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```