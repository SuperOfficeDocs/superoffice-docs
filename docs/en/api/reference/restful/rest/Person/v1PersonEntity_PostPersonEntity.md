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
| CreatedByFormId | Integer | The form id of the form that created the person |
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
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.PersonEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.PersonEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Person
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 182,
  "Firstname": "Kellen",
  "MiddleName": "Hudson LLC",
  "Lastname": "Balistreri",
  "Mrmrs": "sequi",
  "Title": "voluptatem",
  "UpdatedDate": "2022-06-03T03:45:28.3734363+02:00",
  "CreatedDate": "2007-01-28T03:45:28.3734363+01:00",
  "BirthDate": "1999-03-31T03:45:28.3734363+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "aut",
      "StrippedValue": "iure",
      "Description": "User-friendly full-range projection"
    },
    {
      "Value": "aut",
      "StrippedValue": "iure",
      "Description": "User-friendly full-range projection"
    }
  ],
  "Description": "Organized demand-driven focus group",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "qui",
      "StrippedValue": "quas",
      "Description": "Streamlined systemic productivity"
    },
    {
      "Value": "qui",
      "StrippedValue": "quas",
      "Description": "Streamlined systemic productivity"
    }
  ],
  "Faxes": [
    {
      "Value": "ut",
      "StrippedValue": "doloremque",
      "Description": "Implemented system-worthy utilisation"
    },
    {
      "Value": "ut",
      "StrippedValue": "doloremque",
      "Description": "Implemented system-worthy utilisation"
    }
  ],
  "MobilePhones": [
    {
      "Value": "nemo",
      "StrippedValue": "est",
      "Description": "Multi-lateral 5th generation alliance"
    },
    {
      "Value": "nemo",
      "StrippedValue": "est",
      "Description": "Multi-lateral 5th generation alliance"
    }
  ],
  "OfficePhones": [
    {
      "Value": "velit",
      "StrippedValue": "autem",
      "Description": "Profound static middleware"
    },
    {
      "Value": "velit",
      "StrippedValue": "autem",
      "Description": "Profound static middleware"
    }
  ],
  "OtherPhones": [
    {
      "Value": "amet",
      "StrippedValue": "excepturi",
      "Description": "Assimilated holistic structure"
    },
    {
      "Value": "amet",
      "StrippedValue": "excepturi",
      "Description": "Assimilated holistic structure"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 77,
      "Name": "Smitham Inc and Sons",
      "ToolTip": "Voluptatibus assumenda quibusdam recusandae ducimus.",
      "Deleted": false,
      "Rank": 304,
      "Type": "est",
      "ColorBlock": 880,
      "IconHint": "ducimus",
      "Selected": false,
      "LastChanged": "2002-08-21T03:45:28.3734363+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eius",
      "StyleHint": "necessitatibus",
      "Hidden": false,
      "FullName": "Albin Ward I"
    }
  ],
  "PersonNumber": "837966",
  "FullName": "Brant Rutherford Jr.",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "ut",
      "StrippedValue": "suscipit",
      "Description": "Universal fault-tolerant Graphical User Interface"
    },
    {
      "Value": "ut",
      "StrippedValue": "suscipit",
      "Description": "Universal fault-tolerant Graphical User Interface"
    }
  ],
  "FormalName": "Ledner, Hauck and Smith",
  "Address": null,
  "Post3": "labore",
  "Post2": "quia",
  "Post1": "reprehenderit",
  "Kanalname": "optio",
  "Kanafname": "nobis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "ut",
  "ActiveInterests": 164,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 572,
  "DbiKey": "nihil",
  "DbiLastModified": "2019-07-16T03:45:28.3734363+02:00",
  "DbiLastSyncronized": "2022-04-29T03:45:28.3734363+02:00",
  "SentInfo": 641,
  "ShowContactTickets": 138,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "cum",
      "StrippedValue": "dignissimos",
      "Description": "Ameliorated well-modulated project"
    },
    {
      "Value": "cum",
      "StrippedValue": "dignissimos",
      "Description": "Ameliorated well-modulated project"
    }
  ],
  "InternetPhones": [
    {
      "Value": "quo",
      "StrippedValue": "quas",
      "Description": "Reverse-engineered radical superstructure"
    },
    {
      "Value": "quo",
      "StrippedValue": "quas",
      "Description": "Reverse-engineered radical superstructure"
    }
  ],
  "Source": 908,
  "ActiveErpLinks": 694,
  "ShipmentTypes": [
    {
      "Id": 710,
      "Name": "Howe-Leuschke",
      "ToolTip": "Officiis ullam pariatur laborum.",
      "Deleted": false,
      "Rank": 211,
      "Type": "vel",
      "ColorBlock": 323,
      "IconHint": "culpa",
      "Selected": false,
      "LastChanged": "2001-06-13T03:45:28.3734363+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "alias",
      "Hidden": false,
      "FullName": "Vaughn Wilkinson"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 418,
      "Comment": "occaecati",
      "Registered": "2008-10-07T03:45:28.3734363+02:00",
      "RegisteredAssociateId": 120,
      "Updated": "2017-07-25T03:45:28.3734363+02:00",
      "UpdatedAssociateId": 605,
      "LegalBaseId": 406,
      "LegalBaseKey": "neque",
      "LegalBaseName": "King-Miller",
      "ConsentPurposeId": 480,
      "ConsentPurposeKey": "incidunt",
      "ConsentPurposeName": "Frami LLC",
      "ConsentSourceId": 522,
      "ConsentSourceKey": "minima",
      "ConsentSourceName": "Langosh LLC"
    }
  ],
  "BounceEmails": [
    "dana_quigley@carrollsenger.com",
    "casper@fritsch.uk"
  ],
  "ActiveStatusMonitorId": 498,
  "CreatedByFormId": 773,
  "UserDefinedFields": {
    "SuperOffice:1": "Colten Marquardt III",
    "SuperOffice:2": "299361414"
  },
  "ExtraFields": {
    "ExtraFields1": "asperiores",
    "ExtraFields2": "reprehenderit"
  },
  "CustomFields": {
    "CustomFields1": "dolorum",
    "CustomFields2": "magnam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 430,
  "Firstname": "Adolf",
  "MiddleName": "Dibbert Group",
  "Lastname": "Swaniawski",
  "Mrmrs": "velit",
  "Title": "labore",
  "UpdatedDate": "2002-06-01T03:45:28.3890536+02:00",
  "CreatedDate": "1999-03-17T03:45:28.3890536+01:00",
  "BirthDate": "2003-10-07T03:45:28.3890536+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "maiores",
      "StrippedValue": "rerum",
      "Description": "Virtual mobile hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 671
        }
      }
    },
    {
      "Value": "maiores",
      "StrippedValue": "rerum",
      "Description": "Virtual mobile hardware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 671
        }
      }
    }
  ],
  "Description": "Total systematic customer loyalty",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "consequuntur",
      "StrippedValue": "laborum",
      "Description": "Switchable non-volatile process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 336
        }
      }
    },
    {
      "Value": "consequuntur",
      "StrippedValue": "laborum",
      "Description": "Switchable non-volatile process improvement",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 336
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "aliquam",
      "StrippedValue": "ipsam",
      "Description": "Optional disintermediate conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 752
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "ipsam",
      "Description": "Optional disintermediate conglomeration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 752
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "perferendis",
      "StrippedValue": "molestias",
      "Description": "Reduced analyzing capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 357
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "molestias",
      "Description": "Reduced analyzing capability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 357
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "similique",
      "StrippedValue": "nemo",
      "Description": "Synergized 4th generation solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 258
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "nemo",
      "Description": "Synergized 4th generation solution",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 258
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "quo",
      "StrippedValue": "atque",
      "Description": "Re-contextualized background algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 47
        }
      }
    },
    {
      "Value": "quo",
      "StrippedValue": "atque",
      "Description": "Re-contextualized background algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 47
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
      "Id": 859,
      "Name": "Monahan, Smith and Schroeder",
      "ToolTip": "In dolore.",
      "Deleted": false,
      "Rank": 709,
      "Type": "architecto",
      "ColorBlock": 518,
      "IconHint": "minus",
      "Selected": false,
      "LastChanged": "2011-07-20T03:45:28.3890536+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "officia",
      "Hidden": true,
      "FullName": "Mr. Asa Hermann",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 330
        }
      }
    }
  ],
  "PersonNumber": "349823",
  "FullName": "Prof. Bailey Forrest Dach",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "adipisci",
      "StrippedValue": "voluptatum",
      "Description": "Automated object-oriented function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 924
        }
      }
    },
    {
      "Value": "adipisci",
      "StrippedValue": "voluptatum",
      "Description": "Automated object-oriented function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 924
        }
      }
    }
  ],
  "FormalName": "Paucek Group",
  "Address": null,
  "Post3": "et",
  "Post2": "et",
  "Post1": "voluptate",
  "Kanalname": "doloribus",
  "Kanafname": "reprehenderit",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "necessitatibus",
  "ActiveInterests": 621,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 618,
  "DbiKey": "qui",
  "DbiLastModified": "2024-09-27T03:45:28.3890536+02:00",
  "DbiLastSyncronized": "2020-06-21T03:45:28.3890536+02:00",
  "SentInfo": 868,
  "ShowContactTickets": 514,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "quisquam",
      "StrippedValue": "qui",
      "Description": "Fully-configurable content-based flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 716
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "qui",
      "Description": "Fully-configurable content-based flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 716
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "sit",
      "StrippedValue": "dolorem",
      "Description": "Optimized holistic strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "dolorem",
      "Description": "Optimized holistic strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 264
        }
      }
    }
  ],
  "Source": 961,
  "ActiveErpLinks": 219,
  "ShipmentTypes": [
    {
      "Id": 925,
      "Name": "Conn, Okuneva and Kuhn",
      "ToolTip": "Sit et.",
      "Deleted": false,
      "Rank": 217,
      "Type": "iusto",
      "ColorBlock": 342,
      "IconHint": "sed",
      "Selected": false,
      "LastChanged": "2012-09-12T03:45:28.4046874+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eos",
      "StyleHint": "dolor",
      "Hidden": false,
      "FullName": "Vernie Strosin II",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 432
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 467,
      "Comment": "numquam",
      "Registered": "2021-03-21T03:45:28.4046874+01:00",
      "RegisteredAssociateId": 984,
      "Updated": "2003-02-16T03:45:28.4046874+01:00",
      "UpdatedAssociateId": 892,
      "LegalBaseId": 937,
      "LegalBaseKey": "repellat",
      "LegalBaseName": "Schumm-Franecki",
      "ConsentPurposeId": 413,
      "ConsentPurposeKey": "nisi",
      "ConsentPurposeName": "Metz LLC",
      "ConsentSourceId": 545,
      "ConsentSourceKey": "et",
      "ConsentSourceName": "Hilpert-Lynch",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 188
        }
      }
    }
  ],
  "BounceEmails": [
    "eden@jenkinsdoyle.biz",
    "geovany_stokes@satterfieldmetz.name"
  ],
  "ActiveStatusMonitorId": 386,
  "CreatedByFormId": 122,
  "UserDefinedFields": {
    "SuperOffice:1": "Mr. Kayla Cayla Bayer",
    "SuperOffice:2": "1842234998"
  },
  "ExtraFields": {
    "ExtraFields1": "ipsam",
    "ExtraFields2": "aliquid"
  },
  "CustomFields": {
    "CustomFields1": "earum",
    "CustomFields2": "soluta"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 307
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```