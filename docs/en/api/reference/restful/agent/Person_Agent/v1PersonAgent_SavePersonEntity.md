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
  "PersonId": 32,
  "Firstname": "Ari",
  "MiddleName": "Stanton-Volkman",
  "Lastname": "Cormier",
  "Mrmrs": "consequatur",
  "Title": "rem",
  "UpdatedDate": "2004-03-08T14:19:03.7488746+01:00",
  "CreatedDate": "2013-07-20T14:19:03.7488746+02:00",
  "BirthDate": "2010-12-27T14:19:03.7488746+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "in",
      "StrippedValue": "et",
      "Description": "Extended responsive parallelism"
    },
    {
      "Value": "in",
      "StrippedValue": "et",
      "Description": "Extended responsive parallelism"
    }
  ],
  "Description": "Re-contextualized didactic help-desk",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "saepe",
      "StrippedValue": "possimus",
      "Description": "Universal multi-tasking approach"
    },
    {
      "Value": "saepe",
      "StrippedValue": "possimus",
      "Description": "Universal multi-tasking approach"
    }
  ],
  "Faxes": [
    {
      "Value": "dolores",
      "StrippedValue": "possimus",
      "Description": "Synergistic optimal Graphical User Interface"
    },
    {
      "Value": "dolores",
      "StrippedValue": "possimus",
      "Description": "Synergistic optimal Graphical User Interface"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quaerat",
      "StrippedValue": "voluptate",
      "Description": "Re-contextualized radical concept"
    },
    {
      "Value": "quaerat",
      "StrippedValue": "voluptate",
      "Description": "Re-contextualized radical concept"
    }
  ],
  "OfficePhones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "ea",
      "Description": "Cross-platform composite superstructure"
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "ea",
      "Description": "Cross-platform composite superstructure"
    }
  ],
  "OtherPhones": [
    {
      "Value": "qui",
      "StrippedValue": "autem",
      "Description": "Team-oriented tangible superstructure"
    },
    {
      "Value": "qui",
      "StrippedValue": "autem",
      "Description": "Team-oriented tangible superstructure"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 396,
      "Name": "Dicki LLC",
      "ToolTip": "Quis eos aut omnis minus et beatae sint.",
      "Deleted": true,
      "Rank": 185,
      "Type": "a",
      "ColorBlock": 696,
      "IconHint": "iure",
      "Selected": false,
      "LastChanged": "2016-05-26T14:19:03.7488746+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "dolores",
      "Hidden": false,
      "FullName": "Lou VonRueden"
    }
  ],
  "PersonNumber": "1798440",
  "FullName": "Mrs. Mozelle Jayson Rempel DVM",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "est",
      "StrippedValue": "ut",
      "Description": "Multi-tiered 6th generation capacity"
    },
    {
      "Value": "est",
      "StrippedValue": "ut",
      "Description": "Multi-tiered 6th generation capacity"
    }
  ],
  "FormalName": "Hayes LLC",
  "Address": null,
  "Post3": "impedit",
  "Post2": "velit",
  "Post1": "quis",
  "Kanalname": "voluptatem",
  "Kanafname": "officia",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "fugit",
  "ActiveInterests": 619,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 424,
  "DbiKey": "voluptatem",
  "DbiLastModified": "2001-05-07T14:19:03.7488746+02:00",
  "DbiLastSyncronized": "2008-04-25T14:19:03.7488746+02:00",
  "SentInfo": 460,
  "ShowContactTickets": 816,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "veritatis",
      "StrippedValue": "repellendus",
      "Description": "Customer-focused client-driven policy"
    },
    {
      "Value": "veritatis",
      "StrippedValue": "repellendus",
      "Description": "Customer-focused client-driven policy"
    }
  ],
  "InternetPhones": [
    {
      "Value": "quasi",
      "StrippedValue": "unde",
      "Description": "User-centric optimal protocol"
    },
    {
      "Value": "quasi",
      "StrippedValue": "unde",
      "Description": "User-centric optimal protocol"
    }
  ],
  "Source": 433,
  "ActiveErpLinks": 208,
  "ShipmentTypes": [
    {
      "Id": 210,
      "Name": "Boehm, Hoppe and Kessler",
      "ToolTip": "Ea consectetur quia soluta perspiciatis voluptas neque expedita.",
      "Deleted": true,
      "Rank": 41,
      "Type": "cupiditate",
      "ColorBlock": 67,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2013-05-29T14:19:03.7488746+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "natus",
      "Hidden": false,
      "FullName": "Miss Douglas Breitenberg"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 202,
      "Comment": "error",
      "Registered": "2008-04-15T14:19:03.7488746+02:00",
      "RegisteredAssociateId": 531,
      "Updated": "2019-01-23T14:19:03.7488746+01:00",
      "UpdatedAssociateId": 511,
      "LegalBaseId": 942,
      "LegalBaseKey": "hic",
      "LegalBaseName": "Lubowitz Inc and Sons",
      "ConsentPurposeId": 894,
      "ConsentPurposeKey": "omnis",
      "ConsentPurposeName": "Waters-Pfeffer",
      "ConsentSourceId": 91,
      "ConsentSourceKey": "harum",
      "ConsentSourceName": "Vandervort Group"
    }
  ],
  "BounceEmails": [
    "timmy@king.info",
    "laisha_schowalter@barton.com"
  ],
  "ActiveStatusMonitorId": 660,
  "UserDefinedFields": {
    "SuperOffice:1": "Rosendo Zechariah Jacobs IV",
    "SuperOffice:2": "Kayleigh Jarod Halvorson I"
  },
  "ExtraFields": {
    "ExtraFields1": "consequuntur",
    "ExtraFields2": "officiis"
  },
  "CustomFields": {
    "CustomFields1": "aut",
    "CustomFields2": "rerum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 112,
  "Firstname": "Kenyatta",
  "MiddleName": "Feest Inc and Sons",
  "Lastname": "Rogahn",
  "Mrmrs": "consequatur",
  "Title": "voluptas",
  "UpdatedDate": "1998-02-04T14:19:03.7644995+01:00",
  "CreatedDate": "2003-07-19T14:19:03.7644995+02:00",
  "BirthDate": "2007-01-01T14:19:03.7644995+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ut",
      "StrippedValue": "provident",
      "Description": "Business-focused client-server complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 687
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "provident",
      "Description": "Business-focused client-server complexity",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 687
        }
      }
    }
  ],
  "Description": "Seamless content-based moratorium",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "et",
      "Description": "Public-key contextually-based moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 572
        }
      }
    },
    {
      "Value": "dolorum",
      "StrippedValue": "et",
      "Description": "Public-key contextually-based moderator",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 572
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "illum",
      "Description": "Multi-layered systematic infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 491
        }
      }
    },
    {
      "Value": "ut",
      "StrippedValue": "illum",
      "Description": "Multi-layered systematic infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 491
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "voluptates",
      "Description": "Cross-platform hybrid superstructure",
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
      "Value": "omnis",
      "StrippedValue": "voluptates",
      "Description": "Cross-platform hybrid superstructure",
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
  "OfficePhones": [
    {
      "Value": "quo",
      "StrippedValue": "quas",
      "Description": "Synergized bifurcated Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "quas",
      "Description": "Synergized bifurcated Graphic Interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 593
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "suscipit",
      "StrippedValue": "enim",
      "Description": "Grass-roots radical challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 470
        }
      }
    },
    {
      "Value": "suscipit",
      "StrippedValue": "enim",
      "Description": "Grass-roots radical challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 470
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
      "Id": 907,
      "Name": "Wilderman LLC",
      "ToolTip": "Quisquam occaecati veniam facere qui.",
      "Deleted": false,
      "Rank": 713,
      "Type": "ipsam",
      "ColorBlock": 95,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2012-04-03T14:19:03.7644995+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "placeat",
      "StyleHint": "dicta",
      "Hidden": true,
      "FullName": "Aaron McGlynn Sr.",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 273
        }
      }
    }
  ],
  "PersonNumber": "722720",
  "FullName": "Etha Connelly",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": false,
  "Urls": [
    {
      "Value": "dolorem",
      "StrippedValue": "ut",
      "Description": "Diverse multi-state open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 677
        }
      }
    },
    {
      "Value": "dolorem",
      "StrippedValue": "ut",
      "Description": "Diverse multi-state open system",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 677
        }
      }
    }
  ],
  "FormalName": "Green-Hintz",
  "Address": null,
  "Post3": "qui",
  "Post2": "molestiae",
  "Post1": "excepturi",
  "Kanalname": "fugiat",
  "Kanafname": "eos",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ut",
  "ActiveInterests": 102,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 198,
  "DbiKey": "qui",
  "DbiLastModified": "2010-07-02T14:19:03.7644995+02:00",
  "DbiLastSyncronized": "2022-05-14T14:19:03.7644995+02:00",
  "SentInfo": 798,
  "ShowContactTickets": 197,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "repudiandae",
      "StrippedValue": "quia",
      "Description": "Devolved multi-state contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    },
    {
      "Value": "repudiandae",
      "StrippedValue": "quia",
      "Description": "Devolved multi-state contingency",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 566
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "eum",
      "StrippedValue": "vel",
      "Description": "Quality-focused 6th generation application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 724
        }
      }
    },
    {
      "Value": "eum",
      "StrippedValue": "vel",
      "Description": "Quality-focused 6th generation application",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 724
        }
      }
    }
  ],
  "Source": 688,
  "ActiveErpLinks": 97,
  "ShipmentTypes": [
    {
      "Id": 968,
      "Name": "VonRueden, Larson and Pacocha",
      "ToolTip": "Qui tenetur quia debitis minus explicabo.",
      "Deleted": false,
      "Rank": 296,
      "Type": "deleniti",
      "ColorBlock": 675,
      "IconHint": "omnis",
      "Selected": false,
      "LastChanged": "2015-09-08T14:19:03.7644995+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "at",
      "Hidden": false,
      "FullName": "Prof. Alvis Stiedemann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 333
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 694,
      "Comment": "ad",
      "Registered": "2006-06-18T14:19:03.7644995+02:00",
      "RegisteredAssociateId": 531,
      "Updated": "2019-10-20T14:19:03.7644995+02:00",
      "UpdatedAssociateId": 338,
      "LegalBaseId": 465,
      "LegalBaseKey": "neque",
      "LegalBaseName": "Jewess, Kirlin and Gusikowski",
      "ConsentPurposeId": 424,
      "ConsentPurposeKey": "neque",
      "ConsentPurposeName": "Fisher Inc and Sons",
      "ConsentSourceId": 393,
      "ConsentSourceKey": "quo",
      "ConsentSourceName": "Hagenes-McDermott",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 617
        }
      }
    }
  ],
  "BounceEmails": [
    "lexus@walsh.com",
    "colton@kuphallesch.info"
  ],
  "ActiveStatusMonitorId": 474,
  "UserDefinedFields": {
    "SuperOffice:1": "Desiree Wunsch II",
    "SuperOffice:2": "850523481"
  },
  "ExtraFields": {
    "ExtraFields1": "unde",
    "ExtraFields2": "omnis"
  },
  "CustomFields": {
    "CustomFields1": "occaecati",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 157
    }
  }
}
```