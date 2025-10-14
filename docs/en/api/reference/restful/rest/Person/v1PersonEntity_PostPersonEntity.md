---
title: POST Person
uid: v1PersonEntity_PostPersonEntity
generated: true
content_type: reference
---

# POST Person

```http
POST /api/v1/Person
```

Creates a new PersonEntity


Calls the Person agent service SavePersonEntity.
NsApiSlow threshold: 2000 ms.






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
| UtmParameters | SavedUtmParameters | Utm parameters when creating this person, readonly fields |
| LeadstatusId | int32 | Refinement of categories of lead type. Empty if the category is not a lead type. |
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
Accept-Language: fr,de,ru,zh
Content-Type: application/json; charset=utf-8

{
  "PersonId": 899,
  "Firstname": "Alena",
  "MiddleName": "Frami Inc and Sons",
  "Lastname": "Mohr",
  "Mrmrs": "non",
  "Title": "ipsum",
  "UpdatedDate": "2007-07-19T03:40:55.8198992+02:00",
  "CreatedDate": "2004-12-23T03:40:55.8198992+01:00",
  "BirthDate": "2006-12-05T03:40:55.8198992+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "ab",
      "StrippedValue": "laborum",
      "Description": "Optional zero administration function"
    },
    {
      "Value": "ab",
      "StrippedValue": "laborum",
      "Description": "Optional zero administration function"
    }
  ],
  "Description": "Switchable logistical knowledge user",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "error",
      "StrippedValue": "et",
      "Description": "Universal web-enabled forecast"
    },
    {
      "Value": "error",
      "StrippedValue": "et",
      "Description": "Universal web-enabled forecast"
    }
  ],
  "Faxes": [
    {
      "Value": "vel",
      "StrippedValue": "reprehenderit",
      "Description": "Monitored fresh-thinking definition"
    },
    {
      "Value": "vel",
      "StrippedValue": "reprehenderit",
      "Description": "Monitored fresh-thinking definition"
    }
  ],
  "MobilePhones": [
    {
      "Value": "nulla",
      "StrippedValue": "illum",
      "Description": "Universal asynchronous moderator"
    },
    {
      "Value": "nulla",
      "StrippedValue": "illum",
      "Description": "Universal asynchronous moderator"
    }
  ],
  "OfficePhones": [
    {
      "Value": "iusto",
      "StrippedValue": "odit",
      "Description": "Persevering content-based toolset"
    },
    {
      "Value": "iusto",
      "StrippedValue": "odit",
      "Description": "Persevering content-based toolset"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ea",
      "StrippedValue": "dolorem",
      "Description": "De-engineered eco-centric emulation"
    },
    {
      "Value": "ea",
      "StrippedValue": "dolorem",
      "Description": "De-engineered eco-centric emulation"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 886,
      "Name": "Stroman Group",
      "ToolTip": "Est vero perspiciatis ab sapiente ipsam.",
      "Deleted": false,
      "Rank": 575,
      "Type": "inventore",
      "ColorBlock": 801,
      "IconHint": "nam",
      "Selected": false,
      "LastChanged": "2012-03-03T03:40:55.8198992+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "eligendi",
      "StyleHint": "qui",
      "Hidden": false,
      "FullName": "Emily Balistreri"
    }
  ],
  "PersonNumber": "533951",
  "FullName": "Retta Rosenbaum",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": false,
  "Urls": [
    {
      "Value": "aut",
      "StrippedValue": "quos",
      "Description": "Realigned empowering contingency"
    },
    {
      "Value": "aut",
      "StrippedValue": "quos",
      "Description": "Realigned empowering contingency"
    }
  ],
  "FormalName": "O'Conner, Gusikowski and Nienow",
  "Address": null,
  "Post3": "quas",
  "Post2": "autem",
  "Post1": "natus",
  "Kanalname": "repellat",
  "Kanafname": "tempore",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "dolor",
  "ActiveInterests": 925,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 238,
  "DbiKey": "inventore",
  "DbiLastModified": "2008-10-12T03:40:55.8198992+02:00",
  "DbiLastSyncronized": "2007-12-03T03:40:55.8198992+01:00",
  "SentInfo": 877,
  "ShowContactTickets": 4,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "modi",
      "StrippedValue": "necessitatibus",
      "Description": "Virtual impactful core"
    },
    {
      "Value": "modi",
      "StrippedValue": "necessitatibus",
      "Description": "Virtual impactful core"
    }
  ],
  "InternetPhones": [
    {
      "Value": "rem",
      "StrippedValue": "nesciunt",
      "Description": "Programmable 24 hour protocol"
    },
    {
      "Value": "rem",
      "StrippedValue": "nesciunt",
      "Description": "Programmable 24 hour protocol"
    }
  ],
  "Source": 507,
  "ActiveErpLinks": 166,
  "ShipmentTypes": [
    {
      "Id": 517,
      "Name": "Will, Tromp and Cremin",
      "ToolTip": "A laboriosam sit.",
      "Deleted": false,
      "Rank": 327,
      "Type": "asperiores",
      "ColorBlock": 664,
      "IconHint": "praesentium",
      "Selected": false,
      "LastChanged": "2025-07-14T03:40:55.8198992+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "nam",
      "StyleHint": "et",
      "Hidden": false,
      "FullName": "Ava Kuphal"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 932,
      "Comment": "quia",
      "Registered": "2025-08-05T03:40:55.8198992+02:00",
      "RegisteredAssociateId": 339,
      "Updated": "2025-08-22T03:40:55.8198992+02:00",
      "UpdatedAssociateId": 713,
      "LegalBaseId": 4,
      "LegalBaseKey": "dolorem",
      "LegalBaseName": "Romaguera, Mante and Jerde",
      "ConsentPurposeId": 568,
      "ConsentPurposeKey": "ea",
      "ConsentPurposeName": "Blanda-Hamill",
      "ConsentSourceId": 296,
      "ConsentSourceKey": "consequatur",
      "ConsentSourceName": "Larson, Harber and Hintz"
    }
  ],
  "BounceEmails": [
    "brock.jacobi@reichelcrona.info",
    "matilde@littel.com"
  ],
  "ActiveStatusMonitorId": 306,
  "CreatedByFormId": 82,
  "UtmParameters": null,
  "LeadstatusId": 717,
  "UserDefinedFields": {
    "SuperOffice:1": "Maybelle Lakin",
    "SuperOffice:2": "Coby Arden McCullough IV"
  },
  "ExtraFields": {
    "ExtraFields1": "qui",
    "ExtraFields2": "quas"
  },
  "CustomFields": {
    "CustomFields1": "esse",
    "CustomFields2": "quia"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 81,
  "Firstname": "Syble",
  "MiddleName": "Koch-Kovacek",
  "Lastname": "Gorczany",
  "Mrmrs": "est",
  "Title": "vero",
  "UpdatedDate": "1998-12-20T03:40:55.8355248+01:00",
  "CreatedDate": "2003-06-20T03:40:55.8355248+02:00",
  "BirthDate": "2007-04-24T03:40:55.8355248+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "sint",
      "StrippedValue": "nihil",
      "Description": "Diverse directional methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 839
        }
      }
    },
    {
      "Value": "sint",
      "StrippedValue": "nihil",
      "Description": "Diverse directional methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 839
        }
      }
    }
  ],
  "Description": "Mandatory fault-tolerant pricing structure",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "similique",
      "StrippedValue": "ut",
      "Description": "Operative hybrid strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 266
        }
      }
    },
    {
      "Value": "similique",
      "StrippedValue": "ut",
      "Description": "Operative hybrid strategy",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 266
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "vel",
      "StrippedValue": "commodi",
      "Description": "Decentralized 6th generation parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 44
        }
      }
    },
    {
      "Value": "vel",
      "StrippedValue": "commodi",
      "Description": "Decentralized 6th generation parallelism",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 44
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "eaque",
      "StrippedValue": "et",
      "Description": "Operative coherent archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 94
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "et",
      "Description": "Operative coherent archive",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 94
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "nam",
      "StrippedValue": "aut",
      "Description": "Seamless homogeneous access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 727
        }
      }
    },
    {
      "Value": "nam",
      "StrippedValue": "aut",
      "Description": "Seamless homogeneous access",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 727
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "sed",
      "StrippedValue": "dolor",
      "Description": "Self-enabling reciprocal info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 988
        }
      }
    },
    {
      "Value": "sed",
      "StrippedValue": "dolor",
      "Description": "Self-enabling reciprocal info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 988
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
      "Id": 20,
      "Name": "O'Reilly Inc and Sons",
      "ToolTip": "Minima sit iste doloribus eveniet harum.",
      "Deleted": false,
      "Rank": 546,
      "Type": "aspernatur",
      "ColorBlock": 770,
      "IconHint": "id",
      "Selected": false,
      "LastChanged": "2005-06-16T03:40:55.8355248+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "hic",
      "StyleHint": "commodi",
      "Hidden": false,
      "FullName": "Dock Erdman V",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 561
        }
      }
    }
  ],
  "PersonNumber": "1014707",
  "FullName": "Mr. Lorna Dasia Kuhlman",
  "NoMailing": true,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "alias",
      "StrippedValue": "saepe",
      "Description": "Profit-focused needs-based groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 104
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "saepe",
      "Description": "Profit-focused needs-based groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 104
        }
      }
    }
  ],
  "FormalName": "Kerluke-Crist",
  "Address": null,
  "Post3": "accusantium",
  "Post2": "molestiae",
  "Post1": "velit",
  "Kanalname": "quo",
  "Kanafname": "nobis",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "vitae",
  "ActiveInterests": 991,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 784,
  "DbiKey": "laborum",
  "DbiLastModified": "2013-08-07T03:40:55.8355248+02:00",
  "DbiLastSyncronized": "2012-06-27T03:40:55.8355248+02:00",
  "SentInfo": 877,
  "ShowContactTickets": 361,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Synergized transitional ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "ut",
      "Description": "Synergized transitional ability",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 564
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "eaque",
      "StrippedValue": "tenetur",
      "Description": "Fully-configurable assymetric artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 881
        }
      }
    },
    {
      "Value": "eaque",
      "StrippedValue": "tenetur",
      "Description": "Fully-configurable assymetric artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 881
        }
      }
    }
  ],
  "Source": 574,
  "ActiveErpLinks": 363,
  "ShipmentTypes": [
    {
      "Id": 438,
      "Name": "Becker Inc and Sons",
      "ToolTip": "Expedita saepe sed alias.",
      "Deleted": false,
      "Rank": 299,
      "Type": "beatae",
      "ColorBlock": 392,
      "IconHint": "sit",
      "Selected": true,
      "LastChanged": "2001-04-16T03:40:55.8355248+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "beatae",
      "StyleHint": "ullam",
      "Hidden": true,
      "FullName": "Mrs. Kathleen Baylee Carroll DVM",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 745
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 378,
      "Comment": "itaque",
      "Registered": "2012-12-29T03:40:55.8355248+01:00",
      "RegisteredAssociateId": 436,
      "Updated": "2021-06-07T03:40:55.8355248+02:00",
      "UpdatedAssociateId": 205,
      "LegalBaseId": 59,
      "LegalBaseKey": "omnis",
      "LegalBaseName": "Cassin, Upton and Raynor",
      "ConsentPurposeId": 531,
      "ConsentPurposeKey": "deserunt",
      "ConsentPurposeName": "Russel-Nitzsche",
      "ConsentSourceId": 492,
      "ConsentSourceKey": "molestiae",
      "ConsentSourceName": "Hayes LLC",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 709
        }
      }
    }
  ],
  "BounceEmails": [
    "dianna.goodwin@schoensporer.us",
    "cecile_russel@bode.uk"
  ],
  "ActiveStatusMonitorId": 153,
  "CreatedByFormId": 355,
  "UtmParameters": null,
  "LeadstatusId": 551,
  "UserDefinedFields": {
    "SuperOffice:1": "Justus Keeling",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "culpa",
    "ExtraFields2": "odit"
  },
  "CustomFields": {
    "CustomFields1": "voluptatibus",
    "CustomFields2": "consequatur"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 305
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/contact/321",
    "Archive": "https://www.example.com/api/v1/contact"
  }
}
```