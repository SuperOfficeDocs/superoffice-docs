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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 228,
  "Firstname": "Blanca",
  "MiddleName": "Hand, Schmitt and Kihn",
  "Lastname": "Kilback",
  "Mrmrs": "ipsam",
  "Title": "et",
  "UpdatedDate": "2011-05-24T11:06:34.8333106+02:00",
  "CreatedDate": "2004-04-29T11:06:34.8333106+02:00",
  "BirthDate": "2000-04-10T11:06:34.8333106+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "libero",
      "StrippedValue": "saepe",
      "Description": "Visionary optimal workforce"
    },
    {
      "Value": "libero",
      "StrippedValue": "saepe",
      "Description": "Visionary optimal workforce"
    }
  ],
  "Description": "Total 5th generation process improvement",
  "IsAssociate": true,
  "PrivatePhones": [
    {
      "Value": "doloribus",
      "StrippedValue": "possimus",
      "Description": "Open-architected explicit support"
    },
    {
      "Value": "doloribus",
      "StrippedValue": "possimus",
      "Description": "Open-architected explicit support"
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "cum",
      "Description": "Versatile explicit project"
    },
    {
      "Value": "et",
      "StrippedValue": "cum",
      "Description": "Versatile explicit project"
    }
  ],
  "MobilePhones": [
    {
      "Value": "maiores",
      "StrippedValue": "sed",
      "Description": "Automated reciprocal challenge"
    },
    {
      "Value": "maiores",
      "StrippedValue": "sed",
      "Description": "Automated reciprocal challenge"
    }
  ],
  "OfficePhones": [
    {
      "Value": "optio",
      "StrippedValue": "sint",
      "Description": "Programmable 4th generation website"
    },
    {
      "Value": "optio",
      "StrippedValue": "sint",
      "Description": "Programmable 4th generation website"
    }
  ],
  "OtherPhones": [
    {
      "Value": "saepe",
      "StrippedValue": "aut",
      "Description": "Networked tangible frame"
    },
    {
      "Value": "saepe",
      "StrippedValue": "aut",
      "Description": "Networked tangible frame"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 313,
      "Name": "Von, Hilpert and Wehner",
      "ToolTip": "Excepturi harum vero illo.",
      "Deleted": false,
      "Rank": 542,
      "Type": "possimus",
      "ColorBlock": 177,
      "IconHint": "fuga",
      "Selected": true,
      "LastChanged": "2003-02-09T11:06:34.8333106+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "quo",
      "StyleHint": "corporis",
      "Hidden": false,
      "FullName": "Ms. Stanley Michel Parisian II"
    }
  ],
  "PersonNumber": "758599",
  "FullName": "Raoul Morar",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "tempora",
      "Description": "Proactive fault-tolerant frame"
    },
    {
      "Value": "et",
      "StrippedValue": "tempora",
      "Description": "Proactive fault-tolerant frame"
    }
  ],
  "FormalName": "Nikolaus LLC",
  "Address": null,
  "Post3": "et",
  "Post2": "cumque",
  "Post1": "ullam",
  "Kanalname": "aut",
  "Kanafname": "molestiae",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "illo",
  "ActiveInterests": 690,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 607,
  "DbiKey": "explicabo",
  "DbiLastModified": "2013-04-21T11:06:34.8333106+02:00",
  "DbiLastSyncronized": "2015-06-23T11:06:34.8333106+02:00",
  "SentInfo": 465,
  "ShowContactTickets": 376,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "accusantium",
      "StrippedValue": "voluptatem",
      "Description": "Reverse-engineered bi-directional time-frame"
    },
    {
      "Value": "accusantium",
      "StrippedValue": "voluptatem",
      "Description": "Reverse-engineered bi-directional time-frame"
    }
  ],
  "InternetPhones": [
    {
      "Value": "nobis",
      "StrippedValue": "veniam",
      "Description": "Organized zero tolerance product"
    },
    {
      "Value": "nobis",
      "StrippedValue": "veniam",
      "Description": "Organized zero tolerance product"
    }
  ],
  "Source": 165,
  "ActiveErpLinks": 570,
  "ShipmentTypes": [
    {
      "Id": 687,
      "Name": "Parker Group",
      "ToolTip": "Nesciunt atque occaecati iste reprehenderit dolores consequatur ex.",
      "Deleted": false,
      "Rank": 154,
      "Type": "modi",
      "ColorBlock": 281,
      "IconHint": "facilis",
      "Selected": true,
      "LastChanged": "2019-11-20T11:06:34.8333106+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "voluptatem",
      "StyleHint": "earum",
      "Hidden": false,
      "FullName": "Vada Shields"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 574,
      "Comment": "maxime",
      "Registered": "2004-04-29T11:06:34.8333106+02:00",
      "RegisteredAssociateId": 304,
      "Updated": "2010-10-31T11:06:34.8333106+01:00",
      "UpdatedAssociateId": 51,
      "LegalBaseId": 869,
      "LegalBaseKey": "explicabo",
      "LegalBaseName": "Sauer Inc and Sons",
      "ConsentPurposeId": 630,
      "ConsentPurposeKey": "voluptatem",
      "ConsentPurposeName": "Kreiger LLC",
      "ConsentSourceId": 966,
      "ConsentSourceKey": "earum",
      "ConsentSourceName": "Baumbach Group"
    }
  ],
  "BounceEmails": [
    "vito@rathbayer.ca",
    "rory@kling.biz"
  ],
  "ActiveStatusMonitorId": 972,
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "1233774146"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "incidunt"
  },
  "CustomFields": {
    "CustomFields1": "voluptatum",
    "CustomFields2": "qui"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 976,
  "Firstname": "Katharina",
  "MiddleName": "Stehr Group",
  "Lastname": "Borer",
  "Mrmrs": "voluptas",
  "Title": "officiis",
  "UpdatedDate": "2006-05-17T11:06:34.8333106+02:00",
  "CreatedDate": "2004-04-27T11:06:34.8333106+02:00",
  "BirthDate": "2023-04-30T11:06:34.8333106+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "minima",
      "Description": "Monitored system-worthy orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "minima",
      "Description": "Monitored system-worthy orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 973
        }
      }
    }
  ],
  "Description": "Multi-layered intangible solution",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "optio",
      "StrippedValue": "sit",
      "Description": "Multi-channelled encompassing moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 62
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "sit",
      "Description": "Multi-channelled encompassing moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 62
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "et",
      "StrippedValue": "quos",
      "Description": "Implemented zero defect algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 39
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "quos",
      "Description": "Implemented zero defect algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 39
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "id",
      "StrippedValue": "error",
      "Description": "Re-engineered transitional pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 122
        }
      }
    },
    {
      "Value": "id",
      "StrippedValue": "error",
      "Description": "Re-engineered transitional pricing structure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 122
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "nobis",
      "StrippedValue": "sit",
      "Description": "Triple-buffered client-server project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 583
        }
      }
    },
    {
      "Value": "nobis",
      "StrippedValue": "sit",
      "Description": "Triple-buffered client-server project",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 583
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "incidunt",
      "StrippedValue": "aut",
      "Description": "Persevering executive installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 598
        }
      }
    },
    {
      "Value": "incidunt",
      "StrippedValue": "aut",
      "Description": "Persevering executive installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 598
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
      "Id": 224,
      "Name": "Ferry, Waelchi and Towne",
      "ToolTip": "Incidunt et quod.",
      "Deleted": true,
      "Rank": 277,
      "Type": "ratione",
      "ColorBlock": 644,
      "IconHint": "odio",
      "Selected": true,
      "LastChanged": "2004-09-09T11:06:34.848938+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "optio",
      "StyleHint": "ipsa",
      "Hidden": false,
      "FullName": "Miss Ceasar Schaefer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 784
        }
      }
    }
  ],
  "PersonNumber": "1379686",
  "FullName": "Mrs. Jordy Bernice Cummerata DVM",
  "NoMailing": false,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "qui",
      "StrippedValue": "occaecati",
      "Description": "Intuitive asynchronous interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 931
        }
      }
    },
    {
      "Value": "qui",
      "StrippedValue": "occaecati",
      "Description": "Intuitive asynchronous interface",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 931
        }
      }
    }
  ],
  "FormalName": "Shields Group",
  "Address": null,
  "Post3": "enim",
  "Post2": "et",
  "Post1": "nisi",
  "Kanalname": "dolorem",
  "Kanafname": "et",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "consequatur",
  "ActiveInterests": 607,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 344,
  "DbiKey": "est",
  "DbiLastModified": "2006-12-15T11:06:34.848938+01:00",
  "DbiLastSyncronized": "2019-03-29T11:06:34.848938+01:00",
  "SentInfo": 299,
  "ShowContactTickets": 681,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "sed",
      "StrippedValue": "nostrum",
      "Description": "Focused intermediate emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "nostrum",
      "Description": "Focused intermediate emulation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 163
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "deleniti",
      "StrippedValue": "quo",
      "Description": "Exclusive even-keeled matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    },
    {
      "Value": "deleniti",
      "StrippedValue": "quo",
      "Description": "Exclusive even-keeled matrix",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 68
        }
      }
    }
  ],
  "Source": 183,
  "ActiveErpLinks": 178,
  "ShipmentTypes": [
    {
      "Id": 829,
      "Name": "Keeling-Batz",
      "ToolTip": "In placeat tenetur.",
      "Deleted": true,
      "Rank": 687,
      "Type": "numquam",
      "ColorBlock": 816,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "1997-01-06T11:06:34.848938+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolores",
      "StyleHint": "repellendus",
      "Hidden": false,
      "FullName": "Ambrose Steuber",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 21
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 540,
      "Comment": "sit",
      "Registered": "2010-09-14T11:06:34.848938+02:00",
      "RegisteredAssociateId": 656,
      "Updated": "1998-06-07T11:06:34.848938+02:00",
      "UpdatedAssociateId": 298,
      "LegalBaseId": 9,
      "LegalBaseKey": "occaecati",
      "LegalBaseName": "Maggio, Lowe and Marvin",
      "ConsentPurposeId": 1001,
      "ConsentPurposeKey": "possimus",
      "ConsentPurposeName": "Davis-Shields",
      "ConsentSourceId": 356,
      "ConsentSourceKey": "cupiditate",
      "ConsentSourceName": "Schaefer-Rohan",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 4
        }
      }
    }
  ],
  "BounceEmails": [
    "ethel.gleichner@klockoklein.ca",
    "dillan_nitzsche@stracke.info"
  ],
  "ActiveStatusMonitorId": 697,
  "UserDefinedFields": {
    "SuperOffice:1": "Salvador Hettinger",
    "SuperOffice:2": "1457188595"
  },
  "ExtraFields": {
    "ExtraFields1": "iure",
    "ExtraFields2": "ex"
  },
  "CustomFields": {
    "CustomFields1": "sed",
    "CustomFields2": "tempora"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 935
    }
  }
}
```