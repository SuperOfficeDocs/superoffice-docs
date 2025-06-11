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
| CreatedByFormId | Integer | The form id of the form that created the person |
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

## Sample request

```http!
POST /api/v1/Agents/Person/SavePersonEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "PersonId": 631,
  "Firstname": "Jacquelyn",
  "MiddleName": "Jones, Schoen and McDermott",
  "Lastname": "Kunze",
  "Mrmrs": "impedit",
  "Title": "et",
  "UpdatedDate": "2005-08-08T17:54:03.3514453+02:00",
  "CreatedDate": "2003-05-15T17:54:03.3514453+02:00",
  "BirthDate": "2011-09-01T17:54:03.3514453+02:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "nihil",
      "StrippedValue": "dolorum",
      "Description": "Inverse optimizing analyzer"
    },
    {
      "Value": "nihil",
      "StrippedValue": "dolorum",
      "Description": "Inverse optimizing analyzer"
    }
  ],
  "Description": "Stand-alone fault-tolerant local area network",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "eum",
      "StrippedValue": "aspernatur",
      "Description": "Stand-alone real-time success"
    },
    {
      "Value": "eum",
      "StrippedValue": "aspernatur",
      "Description": "Stand-alone real-time success"
    }
  ],
  "Faxes": [
    {
      "Value": "vel",
      "StrippedValue": "repudiandae",
      "Description": "Realigned radical moratorium"
    },
    {
      "Value": "vel",
      "StrippedValue": "repudiandae",
      "Description": "Realigned radical moratorium"
    }
  ],
  "MobilePhones": [
    {
      "Value": "quasi",
      "StrippedValue": "consequatur",
      "Description": "Total system-worthy secured line"
    },
    {
      "Value": "quasi",
      "StrippedValue": "consequatur",
      "Description": "Total system-worthy secured line"
    }
  ],
  "OfficePhones": [
    {
      "Value": "error",
      "StrippedValue": "ullam",
      "Description": "Team-oriented high-level matrix"
    },
    {
      "Value": "error",
      "StrippedValue": "ullam",
      "Description": "Team-oriented high-level matrix"
    }
  ],
  "OtherPhones": [
    {
      "Value": "ex",
      "StrippedValue": "est",
      "Description": "Robust explicit process improvement"
    },
    {
      "Value": "ex",
      "StrippedValue": "est",
      "Description": "Robust explicit process improvement"
    }
  ],
  "Position": null,
  "UpdatedBy": null,
  "Contact": null,
  "Country": null,
  "Interests": [
    {
      "Id": 864,
      "Name": "Borer LLC",
      "ToolTip": "Excepturi est.",
      "Deleted": true,
      "Rank": 632,
      "Type": "modi",
      "ColorBlock": 462,
      "IconHint": "quidem",
      "Selected": false,
      "LastChanged": "2014-04-07T17:54:03.3514453+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "enim",
      "StyleHint": "repudiandae",
      "Hidden": false,
      "FullName": "Eloy Langworth"
    }
  ],
  "PersonNumber": "708189",
  "FullName": "Mr. Dion Rhea Ondricka",
  "NoMailing": false,
  "UsePersonAddress": true,
  "Retired": true,
  "Urls": [
    {
      "Value": "iure",
      "StrippedValue": "et",
      "Description": "Balanced reciprocal capability"
    },
    {
      "Value": "iure",
      "StrippedValue": "et",
      "Description": "Balanced reciprocal capability"
    }
  ],
  "FormalName": "Beer-Okuneva",
  "Address": null,
  "Post3": "similique",
  "Post2": "quia",
  "Post1": "dolores",
  "Kanalname": "similique",
  "Kanafname": "ea",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "veniam",
  "ActiveInterests": 238,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 674,
  "DbiKey": "nemo",
  "DbiLastModified": "2009-11-08T17:54:03.3514453+01:00",
  "DbiLastSyncronized": "2012-06-29T17:54:03.3514453+02:00",
  "SentInfo": 328,
  "ShowContactTickets": 535,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "tempora",
      "StrippedValue": "quam",
      "Description": "Reverse-engineered exuding toolset"
    },
    {
      "Value": "tempora",
      "StrippedValue": "quam",
      "Description": "Reverse-engineered exuding toolset"
    }
  ],
  "InternetPhones": [
    {
      "Value": "sed",
      "StrippedValue": "deleniti",
      "Description": "Customizable system-worthy intranet"
    },
    {
      "Value": "sed",
      "StrippedValue": "deleniti",
      "Description": "Customizable system-worthy intranet"
    }
  ],
  "Source": 979,
  "ActiveErpLinks": 642,
  "ShipmentTypes": [
    {
      "Id": 32,
      "Name": "Stracke, Miller and Schuster",
      "ToolTip": "Facere dolorem impedit qui quasi quidem error sapiente.",
      "Deleted": false,
      "Rank": 42,
      "Type": "aut",
      "ColorBlock": 571,
      "IconHint": "soluta",
      "Selected": false,
      "LastChanged": "2014-02-17T17:54:03.3514453+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "non",
      "StyleHint": "odit",
      "Hidden": true,
      "FullName": "Miss Tad Trace Roberts DDS"
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 77,
      "Comment": "rem",
      "Registered": "2002-03-20T17:54:03.3514453+01:00",
      "RegisteredAssociateId": 356,
      "Updated": "2012-08-29T17:54:03.3514453+02:00",
      "UpdatedAssociateId": 823,
      "LegalBaseId": 718,
      "LegalBaseKey": "sed",
      "LegalBaseName": "Raynor Group",
      "ConsentPurposeId": 366,
      "ConsentPurposeKey": "quia",
      "ConsentPurposeName": "Murray LLC",
      "ConsentSourceId": 306,
      "ConsentSourceKey": "reiciendis",
      "ConsentSourceName": "Kris-Nitzsche"
    }
  ],
  "BounceEmails": [
    "ervin@roob.com",
    "cristian_abernathy@conn.uk"
  ],
  "ActiveStatusMonitorId": 676,
  "CreatedByFormId": 857,
  "UserDefinedFields": {
    "SuperOffice:1": "1774754200",
    "SuperOffice:2": "Sofia Kling"
  },
  "ExtraFields": {
    "ExtraFields1": "aut",
    "ExtraFields2": "expedita"
  },
  "CustomFields": {
    "CustomFields1": "doloribus",
    "CustomFields2": "tenetur"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "PersonId": 942,
  "Firstname": "Brigitte",
  "MiddleName": "Trantow Inc and Sons",
  "Lastname": "Brekke",
  "Mrmrs": "harum",
  "Title": "dolorem",
  "UpdatedDate": "2008-07-29T17:54:03.3514453+02:00",
  "CreatedDate": "2022-07-08T17:54:03.3514453+02:00",
  "BirthDate": "2000-02-10T17:54:03.3514453+01:00",
  "CreatedBy": null,
  "Emails": [
    {
      "Value": "quia",
      "StrippedValue": "quas",
      "Description": "Universal 4th generation moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 87
        }
      }
    },
    {
      "Value": "quia",
      "StrippedValue": "quas",
      "Description": "Universal 4th generation moratorium",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 87
        }
      }
    }
  ],
  "Description": "Pre-emptive methodical application",
  "IsAssociate": false,
  "PrivatePhones": [
    {
      "Value": "omnis",
      "StrippedValue": "ea",
      "Description": "Inverse fault-tolerant projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 650
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "ea",
      "Description": "Inverse fault-tolerant projection",
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
  "Faxes": [
    {
      "Value": "accusamus",
      "StrippedValue": "porro",
      "Description": "Proactive fresh-thinking time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 635
        }
      }
    },
    {
      "Value": "accusamus",
      "StrippedValue": "porro",
      "Description": "Proactive fresh-thinking time-frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 635
        }
      }
    }
  ],
  "MobilePhones": [
    {
      "Value": "quisquam",
      "StrippedValue": "doloremque",
      "Description": "Proactive coherent website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    },
    {
      "Value": "quisquam",
      "StrippedValue": "doloremque",
      "Description": "Proactive coherent website",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 332
        }
      }
    }
  ],
  "OfficePhones": [
    {
      "Value": "sit",
      "StrippedValue": "dolorum",
      "Description": "Re-contextualized impactful portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 812
        }
      }
    },
    {
      "Value": "sit",
      "StrippedValue": "dolorum",
      "Description": "Re-contextualized impactful portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 812
        }
      }
    }
  ],
  "OtherPhones": [
    {
      "Value": "et",
      "StrippedValue": "voluptate",
      "Description": "Reactive dynamic algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "voluptate",
      "Description": "Reactive dynamic algorithm",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 489
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
      "Id": 56,
      "Name": "Quitzon, Hane and Bogisich",
      "ToolTip": "Minima sed a et at.",
      "Deleted": true,
      "Rank": 649,
      "Type": "quia",
      "ColorBlock": 279,
      "IconHint": "iste",
      "Selected": true,
      "LastChanged": "2002-03-20T17:54:03.3514453+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "sint",
      "StyleHint": "repellendus",
      "Hidden": false,
      "FullName": "Mallie Bosco DDS",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 315
        }
      }
    }
  ],
  "PersonNumber": "1076811",
  "FullName": "Prof. Precious Lebsack",
  "NoMailing": true,
  "UsePersonAddress": false,
  "Retired": true,
  "Urls": [
    {
      "Value": "officiis",
      "StrippedValue": "assumenda",
      "Description": "Ergonomic maximized intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 760
        }
      }
    },
    {
      "Value": "officiis",
      "StrippedValue": "assumenda",
      "Description": "Ergonomic maximized intranet",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 760
        }
      }
    }
  ],
  "FormalName": "Boyle, Prosacco and Gorczany",
  "Address": null,
  "Post3": "odit",
  "Post2": "fugit",
  "Post1": "nobis",
  "Kanalname": "pariatur",
  "Kanafname": "sed",
  "CorrespondingAssociate": null,
  "Category": null,
  "Business": null,
  "Associate": null,
  "Salutation": "libero",
  "ActiveInterests": 967,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "DbiAgentId": 714,
  "DbiKey": "sit",
  "DbiLastModified": "2019-10-27T17:54:03.3514453+01:00",
  "DbiLastSyncronized": "2013-02-19T17:54:03.3514453+01:00",
  "SentInfo": 603,
  "ShowContactTickets": 971,
  "UserInfo": null,
  "ChatEmails": [
    {
      "Value": "iste",
      "StrippedValue": "fuga",
      "Description": "Adaptive web-enabled functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    },
    {
      "Value": "iste",
      "StrippedValue": "fuga",
      "Description": "Adaptive web-enabled functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 911
        }
      }
    }
  ],
  "InternetPhones": [
    {
      "Value": "reprehenderit",
      "StrippedValue": "in",
      "Description": "Object-based value-added infrastructure",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 702
        }
      }
    },
    {
      "Value": "reprehenderit",
      "StrippedValue": "in",
      "Description": "Object-based value-added infrastructure",
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
  "Source": 565,
  "ActiveErpLinks": 901,
  "ShipmentTypes": [
    {
      "Id": 852,
      "Name": "Orn LLC",
      "ToolTip": "Et voluptatem atque odio eius.",
      "Deleted": false,
      "Rank": 516,
      "Type": "impedit",
      "ColorBlock": 174,
      "IconHint": "sapiente",
      "Selected": false,
      "LastChanged": "2013-12-01T17:54:03.3514453+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "vel",
      "StyleHint": "eligendi",
      "Hidden": false,
      "FullName": "Tania Morar",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 983
        }
      }
    }
  ],
  "Consents": [
    {
      "ConsentPersonId": 519,
      "Comment": "voluptas",
      "Registered": "2012-02-21T17:54:03.3514453+01:00",
      "RegisteredAssociateId": 682,
      "Updated": "2011-08-28T17:54:03.3514453+02:00",
      "UpdatedAssociateId": 320,
      "LegalBaseId": 127,
      "LegalBaseKey": "doloremque",
      "LegalBaseName": "Toy, Borer and Botsford",
      "ConsentPurposeId": 728,
      "ConsentPurposeKey": "repudiandae",
      "ConsentPurposeName": "Adams-Hickle",
      "ConsentSourceId": 457,
      "ConsentSourceKey": "molestiae",
      "ConsentSourceName": "Runte-Rolfson",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 76
        }
      }
    }
  ],
  "BounceEmails": [
    "deontae@kuvalis.ca",
    "burdette@maggio.name"
  ],
  "ActiveStatusMonitorId": 602,
  "CreatedByFormId": 824,
  "UserDefinedFields": {
    "SuperOffice:1": "Dessie Hessel",
    "SuperOffice:2": "Zack Weimann"
  },
  "ExtraFields": {
    "ExtraFields1": "quis",
    "ExtraFields2": "qui"
  },
  "CustomFields": {
    "CustomFields1": "vitae",
    "CustomFields2": "non"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 105
    }
  }
}
```