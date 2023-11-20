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
  "PersonId": 988,
  "Firstname": "Oda",
  "MiddleName": "Wuckert Inc and Sons",
  "Lastname": "Roob",
  "Mrmrs": "a",
  "Title": "repellendus",
  "UpdatedDate": "2002-05-28T13:38:13.7491627+02:00",
  "CreatedDate": "2015-10-31T13:38:13.7491627+01:00",
  "BirthDate": "2002-03-17T13:38:13.7491627+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptates",
      "StrippedValue": "qui",
      "Description": "Fully-configurable dedicated migration"
    },
    {
      "Value": "voluptates",
      "StrippedValue": "qui",
      "Description": "Fully-configurable dedicated migration"
    }
  ],
  "Description": "Team-oriented directional utilisation",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "rerum",
      "StrippedValue": "sed",
      "Description": "Robust scalable open system"
    },
    {
      "Value": "rerum",
      "StrippedValue": "sed",
      "Description": "Robust scalable open system"
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Universal static project"
    },
    {
      "Value": "ut",
      "StrippedValue": "et",
      "Description": "Universal static project"
    }
  ],
  "MobilePhones": [
    {
      "Value": "ea",
      "StrippedValue": "sapiente",
      "Description": "Enterprise-wide encompassing intranet"
    },
    {
      "Value": "ea",
      "StrippedValue": "sapiente",
      "Description": "Enterprise-wide encompassing intranet"
    }
  ],
  "OfficePhones": [
    {
      "Value": "labore",
      "StrippedValue": "qui",
      "Description": "Grass-roots full-range utilisation"
    },
    {
      "Value": "labore",
      "StrippedValue": "qui",
      "Description": "Grass-roots full-range utilisation"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ut",
      "StrippedValue": "minima",
      "Description": "Vision-oriented well-modulated productivity"
    },
    {
      "Value": "ut",
      "StrippedValue": "minima",
      "Description": "Vision-oriented well-modulated productivity"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 966,
      "Name": "Orn, Parisian and Denesik",
      "ToolTip": "Eos corrupti et quia molestias vero quia.",
      "Deleted": false,
      "Rank": 892,
      "Type": "itaque",
      "ColorBlock": 571,
      "IconHint": "in",
      "Selected": false,
      "LastChanged": "2004-08-21T13:38:13.7646988+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "blanditiis",
      "Hidden": false,
      "FullName": "Devyn Langosh"
    }
  ],
  "PersonNumber": "966613",
  "FullName": "Mohammed Purdy",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "voluptate",
      "StrippedValue": "non",
      "Description": "Front-line human-resource internet solution"
    },
    {
      "Value": "voluptate",
      "StrippedValue": "non",
      "Description": "Front-line human-resource internet solution"
    }
  ],
  "FormalName": "Goyette-Boehm",
  "Address": null,
  "Post3": "et",
  "Post2": "ut",
  "Post1": "omnis",
  "Kanalname": "delectus",
  "Kanafname": "voluptatem",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "qui",
  "ActiveInterests": 348,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 397,
  "DbiKey": "non",
  "DbiLastModified": "2020-03-05T13:38:13.7646988+01:00",
  "DbiLastSyncronized": "2022-11-14T13:38:13.7646988+01:00",
  "SentInfo": 206,
  "ShowContactTickets": 237,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sunt",
      "StrippedValue": "aut",
      "Description": "Intuitive didactic access"
    },
    {
      "Value": "sunt",
      "StrippedValue": "aut",
      "Description": "Intuitive didactic access"
    }
  ],
  "InternetPhones": [
    {
      "Value": "veritatis",
      "StrippedValue": "libero",
      "Description": "Reduced disintermediate application"
    },
    {
      "Value": "veritatis",
      "StrippedValue": "libero",
      "Description": "Reduced disintermediate application"
    }
  ],
  "Source": 252,
  "ActiveErpLinks": 817,
  "ShipmentTypes": [
    {
      "Id": 432,
      "Name": "Schulist Inc and Sons",
      "ToolTip": "Enim inventore officiis iste sunt minima.",
      "Deleted": true,
      "Rank": 560,
      "Type": "sunt",
      "ColorBlock": 227,
      "IconHint": "illum",
      "Selected": false,
      "LastChanged": "2012-03-12T13:38:13.7646988+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "molestiae",
      "StyleHint": "vitae",
      "Hidden": false,
      "FullName": "Wallace Kovacek"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 534,
      "Comment": "sit",
      "Registered": "1997-07-22T13:38:13.7646988+02:00",
      "RegisteredAssociateId": 83,
      "Updated": "2005-01-20T13:38:13.7646988+01:00",
      "UpdatedAssociateId": 205,
      "LegalBaseId": 255,
      "LegalBaseKey": "eligendi",
      "LegalBaseName": "Reichel, Kuhn and Fritsch",
      "ConsentPurposeId": 488,
      "ConsentPurposeKey": "est",
      "ConsentPurposeName": "Johns, Grimes and Bode",
      "ConsentSourceId": 436,
      "ConsentSourceKey": "tempore",
      "ConsentSourceName": "Fadel, Hintz and Tromp"
    }
  ],
  "BounceEmails": [
    "delphia@parker.name",
    "tiffany.wilkinson@jaskolski.biz"
  ],
  "ActiveStatusMonitorId": 265,
  "UserDefinedFields": {
    "SuperOffice:1": "Pamela Nikolaus",
    "SuperOffice:2": "Mrs. Dylan Providenci Weimann IV"
  },
  "ExtraFields": {
    "ExtraFields1": "ratione",
    "ExtraFields2": "impedit"
  },
  "CustomFields": {
    "CustomFields1": "voluptates",
    "CustomFields2": "expedita"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 710,
  "Firstname": "Laurence",
  "MiddleName": "Cronin, Bosco and Schuppe",
  "Lastname": "Abbott",
  "Mrmrs": "dolores",
  "Title": "eos",
  "UpdatedDate": "2002-11-16T13:38:13.7646988+01:00",
  "CreatedDate": "1996-09-14T13:38:13.7646988+02:00",
  "BirthDate": "1999-08-15T13:38:13.7646988+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "officia",
      "StrippedValue": "vitae",
      "Description": "Intuitive bottom-line software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 736
        }
      }
    },
    {
      "Value": "officia",
      "StrippedValue": "vitae",
      "Description": "Intuitive bottom-line software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 736
        }
      }
    }
  ],
  "Description": "Pre-emptive next generation policy",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "eligendi",
      "StrippedValue": "perspiciatis",
      "Description": "Reduced well-modulated implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 818
        }
      }
    },
    {
      "Value": "eligendi",
      "StrippedValue": "perspiciatis",
      "Description": "Reduced well-modulated implementation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 818
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aut",
      "StrippedValue": "ipsam",
      "Description": "Customer-focused zero tolerance installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "ipsam",
      "Description": "Customer-focused zero tolerance installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 143
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "sunt",
      "StrippedValue": "provident",
      "Description": "Seamless zero administration adapter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 840
        }
      }
    },
    {
      "Value": "sunt",
      "StrippedValue": "provident",
      "Description": "Seamless zero administration adapter",
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
  "OfficePhones": [
    {
      "Value": "minima",
      "StrippedValue": "ratione",
      "Description": "Horizontal human-resource algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    },
    {
      "Value": "minima",
      "StrippedValue": "ratione",
      "Description": "Horizontal human-resource algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 268
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "perspiciatis",
      "StrippedValue": "possimus",
      "Description": "Persevering optimal function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 456
        }
      }
    },
    {
      "Value": "perspiciatis",
      "StrippedValue": "possimus",
      "Description": "Persevering optimal function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 456
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
      "Id": 195,
      "Name": "Kunde, Dooley and Hand",
      "ToolTip": "Nulla non hic labore sit.",
      "Deleted": true,
      "Rank": 497,
      "Type": "est",
      "ColorBlock": 398,
      "IconHint": "quae",
      "Selected": false,
      "LastChanged": "2004-04-24T13:38:13.7646988+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "necessitatibus",
      "StyleHint": "at",
      "Hidden": true,
      "FullName": "Mrs. Berniece Clinton Lang",
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
  "PersonNumber": "1399732",
  "FullName": "Mr. Hilario Terrill Grant Sr.",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "fuga",
      "StrippedValue": "eligendi",
      "Description": "Quality-focused grid-enabled emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 492
        }
      }
    },
    {
      "Value": "fuga",
      "StrippedValue": "eligendi",
      "Description": "Quality-focused grid-enabled emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 492
        }
      }
    }
  ],
  "FormalName": "Witting Inc and Sons",
  "Address": null,
  "Post3": "inventore",
  "Post2": "iure",
  "Post1": "perspiciatis",
  "Kanalname": "ducimus",
  "Kanafname": "aut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dignissimos",
  "ActiveInterests": 216,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 781,
  "DbiKey": "cumque",
  "DbiLastModified": "2022-07-14T13:38:13.7646988+02:00",
  "DbiLastSyncronized": "2020-02-16T13:38:13.7646988+01:00",
  "SentInfo": 572,
  "ShowContactTickets": 7,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "accusamus",
      "StrippedValue": "commodi",
      "Description": "Fully-configurable impactful firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "commodi",
      "Description": "Fully-configurable impactful firmware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 423
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "aut",
      "StrippedValue": "sed",
      "Description": "Business-focused holistic frame",
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
      "Value": "aut",
      "StrippedValue": "sed",
      "Description": "Business-focused holistic frame",
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
  "Source": 315,
  "ActiveErpLinks": 238,
  "ShipmentTypes": [
    {
      "Id": 338,
      "Name": "Steuber, Lindgren and Wilderman",
      "ToolTip": "Eos dolorem quos laborum nemo.",
      "Deleted": false,
      "Rank": 532,
      "Type": "tempore",
      "ColorBlock": 701,
      "IconHint": "necessitatibus",
      "Selected": false,
      "LastChanged": "2005-02-28T13:38:13.7646988+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nesciunt",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Carter Walter",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 526
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 882,
      "Comment": "autem",
      "Registered": "2021-09-01T13:38:13.7646988+02:00",
      "RegisteredAssociateId": 211,
      "Updated": "2006-08-09T13:38:13.7646988+02:00",
      "UpdatedAssociateId": 74,
      "LegalBaseId": 703,
      "LegalBaseKey": "sunt",
      "LegalBaseName": "Leuschke-Harber",
      "ConsentPurposeId": 501,
      "ConsentPurposeKey": "mollitia",
      "ConsentPurposeName": "Blanda, Dare and Dickinson",
      "ConsentSourceId": 917,
      "ConsentSourceKey": "laudantium",
      "ConsentSourceName": "Schneider Group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 172
        }
      }
    }
  ],
  "BounceEmails": [
    "amara.cassin@vonrueden.name",
    "brenden@ullrich.info"
  ],
  "ActiveStatusMonitorId": 157,
  "UserDefinedFields": {
    "SuperOffice:1": "Hugh Rowe",
    "SuperOffice:2": "Lukas Huel IV"
  },
  "ExtraFields": {
    "ExtraFields1": "consectetur",
    "ExtraFields2": "aspernatur"
  },
  "CustomFields": {
    "CustomFields1": "doloremque",
    "CustomFields2": "perferendis"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 633
    }
  }
}
```