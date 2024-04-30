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
Accept-Language: *
Content-Type: application/json; charset=utf-8

{
  "PersonId": 330,
  "Firstname": "Conner",
  "MiddleName": "Haley, Wolf and Bayer",
  "Lastname": "Gibson",
  "Mrmrs": "esse",
  "Title": "quam",
  "UpdatedDate": "1997-09-28T11:44:42.0233848+02:00",
  "CreatedDate": "2017-04-19T11:44:42.0233848+02:00",
  "BirthDate": "2021-02-13T11:44:42.0233848+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ullam",
      "StrippedValue": "ut",
      "Description": "Reactive multi-state collaboration"
    },
    {
      "Value": "ullam",
      "StrippedValue": "ut",
      "Description": "Reactive multi-state collaboration"
    }
  ],
  "Description": "Stand-alone didactic encoding",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "inventore",
      "StrippedValue": "ducimus",
      "Description": "Total grid-enabled website"
    },
    {
      "Value": "inventore",
      "StrippedValue": "ducimus",
      "Description": "Total grid-enabled website"
    }
  ],
  "Faxes": [
    {
      "Value": "odio",
      "StrippedValue": "in",
      "Description": "Multi-channelled intangible methodology"
    },
    {
      "Value": "odio",
      "StrippedValue": "in",
      "Description": "Multi-channelled intangible methodology"
    }
  ],
  "MobilePhones": [
    {
      "Value": "odio",
      "StrippedValue": "rem",
      "Description": "Pre-emptive tangible circuit"
    },
    {
      "Value": "odio",
      "StrippedValue": "rem",
      "Description": "Pre-emptive tangible circuit"
    }
  ],
  "OfficePhones": [
    {
      "Value": "eveniet",
      "StrippedValue": "ipsa",
      "Description": "De-engineered multi-state success"
    },
    {
      "Value": "eveniet",
      "StrippedValue": "ipsa",
      "Description": "De-engineered multi-state success"
    }
  ],
  "OtherPhones": [
    {
      "Value": "rerum",
      "StrippedValue": "id",
      "Description": "Extended tertiary structure"
    },
    {
      "Value": "rerum",
      "StrippedValue": "id",
      "Description": "Extended tertiary structure"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 397,
      "Name": "Gusikowski, Wisoky and Christiansen",
      "ToolTip": "Ratione facilis repudiandae.",
      "Deleted": false,
      "Rank": 763,
      "Type": "quaerat",
      "ColorBlock": 626,
      "IconHint": "illo",
      "Selected": true,
      "LastChanged": "2013-05-09T11:44:42.0390147+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "aut",
      "StyleHint": "ipsa",
      "Hidden": true,
      "FullName": "Mr. Reyna Camren Corkery"
    }
  ],
  "PersonNumber": "1430447",
  "FullName": "Jan Bauch Sr.",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "debitis",
      "StrippedValue": "aliquid",
      "Description": "Innovative stable benchmark"
    },
    {
      "Value": "debitis",
      "StrippedValue": "aliquid",
      "Description": "Innovative stable benchmark"
    }
  ],
  "FormalName": "Jacobs-Collier",
  "Address": null,
  "Post3": "debitis",
  "Post2": "molestiae",
  "Post1": "dignissimos",
  "Kanalname": "ut",
  "Kanafname": "placeat",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "fugiat",
  "ActiveInterests": 573,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 940,
  "DbiKey": "hic",
  "DbiLastModified": "2006-12-30T11:44:42.0390147+01:00",
  "DbiLastSyncronized": "2009-04-28T11:44:42.0390147+02:00",
  "SentInfo": 618,
  "ShowContactTickets": 918,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "consequatur",
      "StrippedValue": "accusamus",
      "Description": "Decentralized fault-tolerant groupware"
    },
    {
      "Value": "consequatur",
      "StrippedValue": "accusamus",
      "Description": "Decentralized fault-tolerant groupware"
    }
  ],
  "InternetPhones": [
    {
      "Value": "asperiores",
      "StrippedValue": "placeat",
      "Description": "Fully-configurable high-level model"
    },
    {
      "Value": "asperiores",
      "StrippedValue": "placeat",
      "Description": "Fully-configurable high-level model"
    }
  ],
  "Source": 975,
  "ActiveErpLinks": 850,
  "ShipmentTypes": [
    {
      "Id": 141,
      "Name": "Jerde Group",
      "ToolTip": "Molestiae eum non deserunt.",
      "Deleted": false,
      "Rank": 91,
      "Type": "quisquam",
      "ColorBlock": 171,
      "IconHint": "earum",
      "Selected": false,
      "LastChanged": "2019-12-20T11:44:42.0390147+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "alias",
      "StyleHint": "consequuntur",
      "Hidden": false,
      "FullName": "Rubye Hoeger II"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 591,
      "Comment": "dolore",
      "Registered": "2016-03-07T11:44:42.0390147+01:00",
      "RegisteredAssociateId": 205,
      "Updated": "2014-07-30T11:44:42.0390147+02:00",
      "UpdatedAssociateId": 960,
      "LegalBaseId": 21,
      "LegalBaseKey": "culpa",
      "LegalBaseName": "Bins, Russel and Leannon",
      "ConsentPurposeId": 564,
      "ConsentPurposeKey": "ut",
      "ConsentPurposeName": "Volkman, Zemlak and Bogisich",
      "ConsentSourceId": 166,
      "ConsentSourceKey": "expedita",
      "ConsentSourceName": "Bogisich-Pfannerstill"
    }
  ],
  "BounceEmails": [
    "theo@ullrich.name",
    "sister@wintheiserherzog.biz"
  ],
  "ActiveStatusMonitorId": 1001,
  "UserDefinedFields": {
    "SuperOffice:1": "238336582",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "totam",
    "ExtraFields2": "consequuntur"
  },
  "CustomFields": {
    "CustomFields1": "molestiae",
    "CustomFields2": "minus"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 436,
  "Firstname": "Melyna",
  "MiddleName": "Boyer Group",
  "Lastname": "Waelchi",
  "Mrmrs": "fugit",
  "Title": "et",
  "UpdatedDate": "2009-01-27T11:44:42.0390147+01:00",
  "CreatedDate": "2007-10-07T11:44:42.0390147+02:00",
  "BirthDate": "2010-08-12T11:44:42.0390147+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "dolorem",
      "Description": "Inverse zero tolerance methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 172
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "dolorem",
      "Description": "Inverse zero tolerance methodology",
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
  "Description": "Streamlined upward-trending task-force",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "aut",
      "StrippedValue": "repellendus",
      "Description": "Distributed local flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 320
        }
      }
    },
    {
      "Value": "aut",
      "StrippedValue": "repellendus",
      "Description": "Distributed local flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 320
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "nam",
      "StrippedValue": "et",
      "Description": "Down-sized needs-based throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 730
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "et",
      "Description": "Down-sized needs-based throughput",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 730
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "qui",
      "StrippedValue": "alias",
      "Description": "Down-sized encompassing installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 549
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "alias",
      "Description": "Down-sized encompassing installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 549
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "ab",
      "StrippedValue": "unde",
      "Description": "Digitized cohesive hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    },
    {
      "Value": "ab",
      "StrippedValue": "unde",
      "Description": "Digitized cohesive hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 980
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "esse",
      "StrippedValue": "velit",
      "Description": "Balanced maximized workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 69
        }
      }
    },
    {
      "Value": "esse",
      "StrippedValue": "velit",
      "Description": "Balanced maximized workforce",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 69
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
      "Id": 520,
      "Name": "Hegmann-Cummings",
      "ToolTip": "Non voluptatem neque eligendi.",
      "Deleted": false,
      "Rank": 683,
      "Type": "officia",
      "ColorBlock": 279,
      "IconHint": "assumenda",
      "Selected": false,
      "LastChanged": "2009-12-13T11:44:42.0390147+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolorum",
      "StyleHint": "provident",
      "Hidden": true,
      "FullName": "Andy Ortiz",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 313
        }
      }
    }
  ],
  "PersonNumber": "896479",
  "FullName": "Joyce Reggie Padberg I",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "explicabo",
      "StrippedValue": "dignissimos",
      "Description": "Progressive zero administration data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    },
    {
      "Value": "explicabo",
      "StrippedValue": "dignissimos",
      "Description": "Progressive zero administration data-warehouse",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 638
        }
      }
    }
  ],
  "FormalName": "Konopelski, Orn and Huel",
  "Address": null,
  "Post3": "nihil",
  "Post2": "sequi",
  "Post1": "molestias",
  "Kanalname": "placeat",
  "Kanafname": "ut",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "eaque",
  "ActiveInterests": 744,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 263,
  "DbiKey": "veniam",
  "DbiLastModified": "2000-02-19T11:44:42.0546526+01:00",
  "DbiLastSyncronized": "2000-02-25T11:44:42.0546526+01:00",
  "SentInfo": 463,
  "ShowContactTickets": 357,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "magni",
      "StrippedValue": "officia",
      "Description": "Horizontal 24/7 hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 533
        }
      }
    },
    {
      "Value": "magni",
      "StrippedValue": "officia",
      "Description": "Horizontal 24/7 hierarchy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 533
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "nobis",
      "StrippedValue": "aliquam",
      "Description": "Object-based logistical task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 438
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "aliquam",
      "Description": "Object-based logistical task-force",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 438
        }
      }
    }
  ],
  "Source": 104,
  "ActiveErpLinks": 329,
  "ShipmentTypes": [
    {
      "Id": 3,
      "Name": "Muller, Wolff and Prohaska",
      "ToolTip": "Est enim ut ea quia sequi earum.",
      "Deleted": false,
      "Rank": 306,
      "Type": "aut",
      "ColorBlock": 973,
      "IconHint": "facilis",
      "Selected": true,
      "LastChanged": "1999-12-04T11:44:42.0546526+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ullam",
      "StyleHint": "rerum",
      "Hidden": false,
      "FullName": "Darron Morissette",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 8
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 888,
      "Comment": "magnam",
      "Registered": "2007-03-02T11:44:42.0546526+01:00",
      "RegisteredAssociateId": 394,
      "Updated": "2023-12-21T11:44:42.0546526+01:00",
      "UpdatedAssociateId": 592,
      "LegalBaseId": 939,
      "LegalBaseKey": "ut",
      "LegalBaseName": "Hartmann LLC",
      "ConsentPurposeId": 109,
      "ConsentPurposeKey": "quia",
      "ConsentPurposeName": "Hyatt LLC",
      "ConsentSourceId": 985,
      "ConsentSourceKey": "totam",
      "ConsentSourceName": "Schmitt LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 101
        }
      }
    }
  ],
  "BounceEmails": [
    "clovis@connelly.info",
    "carlos@rohan.us"
  ],
  "ActiveStatusMonitorId": 1001,
  "UserDefinedFields": {
    "SuperOffice:1": "1160046976",
    "SuperOffice:2": "Rollin Green"
  },
  "ExtraFields": {
    "ExtraFields1": "ut",
    "ExtraFields2": "quia"
  },
  "CustomFields": {
    "CustomFields1": "dolor",
    "CustomFields2": "illo"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 787
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```