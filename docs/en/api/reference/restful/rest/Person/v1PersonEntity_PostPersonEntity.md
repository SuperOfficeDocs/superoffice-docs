---
title: POST Person
uid: v1PersonEntity_PostPersonEntity
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
| TableRight | RecurrenceInfo |  |
| FieldProperties | object |  |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 215,
  "Firstname": "Laney",
  "MiddleName": "Jast Group",
  "Lastname": "Conn",
  "Mrmrs": "modi",
  "Title": "magnam",
  "UpdatedDate": "2014-12-13T14:19:10.3810978+01:00",
  "CreatedDate": "2018-01-04T14:19:10.3810978+01:00",
  "BirthDate": "1997-03-29T14:19:10.3810978+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "voluptatum",
      "StrippedValue": "consequatur",
      "Description": "Managed tertiary attitude"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "consequatur",
      "Description": "Managed tertiary attitude"
    }
  ],
  "Description": "Diverse user-facing forecast",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "eum",
      "StrippedValue": "nostrum",
      "Description": "Ameliorated solution-oriented neural-net"
    },
    {
      "Value": "eum",
      "StrippedValue": "nostrum",
      "Description": "Ameliorated solution-oriented neural-net"
    }
  ],
  "Faxes": [
    {
      "Value": "eveniet",
      "StrippedValue": "temporibus",
      "Description": "Vision-oriented reciprocal structure"
    },
    {
      "Value": "eveniet",
      "StrippedValue": "temporibus",
      "Description": "Vision-oriented reciprocal structure"
    }
  ],
  "MobilePhones": [
    {
      "Value": "dolorum",
      "StrippedValue": "minus",
      "Description": "Organic responsive approach"
    },
    {
      "Value": "dolorum",
      "StrippedValue": "minus",
      "Description": "Organic responsive approach"
    }
  ],
  "OfficePhones": [
    {
      "Value": "culpa",
      "StrippedValue": "et",
      "Description": "Operative systemic application"
    },
    {
      "Value": "culpa",
      "StrippedValue": "et",
      "Description": "Operative systemic application"
    }
  ],
  "OtherPhones": [
    {
      "Value": "unde",
      "StrippedValue": "blanditiis",
      "Description": "Pre-emptive cohesive hardware"
    },
    {
      "Value": "unde",
      "StrippedValue": "blanditiis",
      "Description": "Pre-emptive cohesive hardware"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 296,
      "Name": "Parisian, Franecki and Tremblay",
      "ToolTip": "Et sequi nulla minima laboriosam.",
      "Deleted": true,
      "Rank": 875,
      "Type": "eaque",
      "ColorBlock": 361,
      "IconHint": "aut",
      "Selected": true,
      "LastChanged": "1997-06-21T14:19:10.3810978+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "totam",
      "StyleHint": "numquam",
      "Hidden": false,
      "FullName": "Everette Parisian"
    }
  ],
  "PersonNumber": "1808098",
  "FullName": "Miss Maudie Abbott Jr.",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "autem",
      "StrippedValue": "sed",
      "Description": "Re-contextualized systemic solution"
    },
    {
      "Value": "autem",
      "StrippedValue": "sed",
      "Description": "Re-contextualized systemic solution"
    }
  ],
  "FormalName": "Hamill Inc and Sons",
  "Address": null,
  "Post3": "hic",
  "Post2": "ut",
  "Post1": "voluptate",
  "Kanalname": "neque",
  "Kanafname": "veritatis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "perspiciatis",
  "ActiveInterests": 144,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 585,
  "DbiKey": "inventore",
  "DbiLastModified": "2012-06-19T14:19:10.3810978+02:00",
  "DbiLastSyncronized": "2003-11-04T14:19:10.3810978+01:00",
  "SentInfo": 65,
  "ShowContactTickets": 875,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "fuga",
      "StrippedValue": "quam",
      "Description": "Compatible user-facing methodology"
    },
    {
      "Value": "fuga",
      "StrippedValue": "quam",
      "Description": "Compatible user-facing methodology"
    }
  ],
  "InternetPhones": [
    {
      "Value": "accusantium",
      "StrippedValue": "error",
      "Description": "Focused multi-state local area network"
    },
    {
      "Value": "accusantium",
      "StrippedValue": "error",
      "Description": "Focused multi-state local area network"
    }
  ],
  "Source": 566,
  "ActiveErpLinks": 75,
  "ShipmentTypes": [
    {
      "Id": 104,
      "Name": "Nolan, Ziemann and Terry",
      "ToolTip": "Rerum quia delectus deleniti qui rerum.",
      "Deleted": true,
      "Rank": 918,
      "Type": "aut",
      "ColorBlock": 295,
      "IconHint": "voluptas",
      "Selected": false,
      "LastChanged": "2020-04-29T14:19:10.3810978+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "deserunt",
      "StyleHint": "quidem",
      "Hidden": false,
      "FullName": "Mr. Ronaldo Neha Ryan"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 487,
      "Comment": "quam",
      "Registered": "1999-01-23T14:19:10.396724+01:00",
      "RegisteredAssociateId": 112,
      "Updated": "2009-05-30T14:19:10.396724+02:00",
      "UpdatedAssociateId": 102,
      "LegalBaseId": 190,
      "LegalBaseKey": "dolorem",
      "LegalBaseName": "Zulauf-Lind",
      "ConsentPurposeId": 687,
      "ConsentPurposeKey": "eum",
      "ConsentPurposeName": "Marquardt-Waters",
      "ConsentSourceId": 520,
      "ConsentSourceKey": "molestiae",
      "ConsentSourceName": "Hahn, Mante and Wiza"
    }
  ],
  "BounceEmails": [
    "mathias@kirlin.ca",
    "eloy.tillman@grady.co.uk"
  ],
  "ActiveStatusMonitorId": 441,
  "UserDefinedFields": {
    "SuperOffice:1": "680868506",
    "SuperOffice:2": "Bell Schaefer"
  },
  "ExtraFields": {
    "ExtraFields1": "ea",
    "ExtraFields2": "voluptatibus"
  },
  "CustomFields": {
    "CustomFields1": "quas",
    "CustomFields2": "laborum"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 174,
  "Firstname": "Leta",
  "MiddleName": "Okuneva Inc and Sons",
  "Lastname": "Swift",
  "Mrmrs": "quam",
  "Title": "accusamus",
  "UpdatedDate": "1996-09-15T14:19:10.396724+02:00",
  "CreatedDate": "2011-11-18T14:19:10.396724+01:00",
  "BirthDate": "2014-06-10T14:19:10.396724+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "animi",
      "StrippedValue": "dolor",
      "Description": "Multi-channelled high-level parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    },
    {
      "Value": "animi",
      "StrippedValue": "dolor",
      "Description": "Multi-channelled high-level parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 2
        }
      }
    }
  ],
  "Description": "Horizontal demand-driven encryption",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "quia",
      "Description": "Universal non-volatile software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 210
        }
      }
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "quia",
      "Description": "Universal non-volatile software",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 210
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "ea",
      "StrippedValue": "debitis",
      "Description": "Face to face bifurcated artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    },
    {
      "Value": "ea",
      "StrippedValue": "debitis",
      "Description": "Face to face bifurcated artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 571
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quia",
      "StrippedValue": "ab",
      "Description": "Multi-layered directional interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 607
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "ab",
      "Description": "Multi-layered directional interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 607
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "cupiditate",
      "StrippedValue": "illum",
      "Description": "User-friendly 24 hour challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 100
        }
      }
    },
    {
      "Value": "cupiditate",
      "StrippedValue": "illum",
      "Description": "User-friendly 24 hour challenge",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 100
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "sit",
      "StrippedValue": "repellat",
      "Description": "Quality-focused demand-driven system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 71
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "repellat",
      "Description": "Quality-focused demand-driven system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 71
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
      "Id": 421,
      "Name": "Fahey LLC",
      "ToolTip": "Quas velit dolor quo enim qui ut.",
      "Deleted": false,
      "Rank": 945,
      "Type": "culpa",
      "ColorBlock": 845,
      "IconHint": "quia",
      "Selected": false,
      "LastChanged": "2012-05-04T14:19:10.396724+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "magni",
      "StyleHint": "distinctio",
      "Hidden": false,
      "FullName": "Flossie Klocko",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 852
        }
      }
    }
  ],
  "PersonNumber": "1100703",
  "FullName": "Justyn Muller",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "quam",
      "StrippedValue": "ut",
      "Description": "Vision-oriented solution-oriented budgetary management",
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
      "Value": "quam",
      "StrippedValue": "ut",
      "Description": "Vision-oriented solution-oriented budgetary management",
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
  "FormalName": "Fay-Krajcik",
  "Address": null,
  "Post3": "consequatur",
  "Post2": "aut",
  "Post1": "est",
  "Kanalname": "eveniet",
  "Kanafname": "eveniet",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "tempore",
  "ActiveInterests": 475,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 107,
  "DbiKey": "veniam",
  "DbiLastModified": "2000-08-25T14:19:10.396724+02:00",
  "DbiLastSyncronized": "1999-11-17T14:19:10.396724+01:00",
  "SentInfo": 858,
  "ShowContactTickets": 448,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "accusantium",
      "StrippedValue": "doloremque",
      "Description": "Exclusive eco-centric customer loyalty",
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
      "Value": "accusantium",
      "StrippedValue": "doloremque",
      "Description": "Exclusive eco-centric customer loyalty",
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
  "InternetPhones": [
    {
      "Value": "ex",
      "StrippedValue": "praesentium",
      "Description": "Persevering maximized intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 73
        }
      }
    },
    {
      "Value": "ex",
      "StrippedValue": "praesentium",
      "Description": "Persevering maximized intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 73
        }
      }
    }
  ],
  "Source": 831,
  "ActiveErpLinks": 770,
  "ShipmentTypes": [
    {
      "Id": 761,
      "Name": "O'Keefe LLC",
      "ToolTip": "Aut eum.",
      "Deleted": true,
      "Rank": 985,
      "Type": "atque",
      "ColorBlock": 425,
      "IconHint": "accusantium",
      "Selected": false,
      "LastChanged": "2020-06-24T14:19:10.396724+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "omnis",
      "StyleHint": "eum",
      "Hidden": false,
      "FullName": "Piper Macejkovic",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 464
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 398,
      "Comment": "dicta",
      "Registered": "1997-05-06T14:19:10.396724+02:00",
      "RegisteredAssociateId": 898,
      "Updated": "2015-03-14T14:19:10.396724+01:00",
      "UpdatedAssociateId": 142,
      "LegalBaseId": 684,
      "LegalBaseKey": "quasi",
      "LegalBaseName": "Kshlerin LLC",
      "ConsentPurposeId": 607,
      "ConsentPurposeKey": "quia",
      "ConsentPurposeName": "Sipes Inc and Sons",
      "ConsentSourceId": 64,
      "ConsentSourceKey": "consequatur",
      "ConsentSourceName": "Flatley Inc and Sons",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 314
        }
      }
    }
  ],
  "BounceEmails": [
    "bonita.bayer@marquardt.biz",
    "hazel@cummings.biz"
  ],
  "ActiveStatusMonitorId": 715,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Ross Amparo Mraz",
    "SuperOffice:2": "Jed Frami"
  },
  "ExtraFields": {
    "ExtraFields1": "pariatur",
    "ExtraFields2": "maiores"
  },
  "CustomFields": {
    "CustomFields1": "aperiam",
    "CustomFields2": "tempore"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 336
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```