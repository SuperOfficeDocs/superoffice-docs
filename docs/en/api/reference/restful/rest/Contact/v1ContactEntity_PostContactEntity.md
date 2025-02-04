---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category" Default = show all fields. |

```http
POST /api/v1/Contact?$select=name,department,category/id
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

The ContactEntity to be saved. 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer | Primary key |
| Name | String | Contact name |
| Department | String | Department |
| OrgNr | String | VAT number or similar |
| Number1 | String | Alphanumeric user field |
| Number2 | String | Alphanumeric user field |
| UpdatedDate | String | Date last updated  in UTC. |
| CreatedDate | String | Date registered  in UTC. |
| Emails | Array | The contact's email |
| Interests | Array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | Array | The contact's internet adresses |
| Phones | Array | The contact's phone numbers |
| Faxes | Array | The contact's fax numbers |
| Description | String | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | Array | The persons belonging to the contact. |
| NoMailing | Boolean | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | String | Contact kana name, used in Japanese versions only |
| Xstop | Boolean | STOP flag |
| ActiveInterests | Integer | The number of active interests. |
| GroupId | Integer | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | Integer | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | Integer | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | Integer | Integration agent (eJournal) |
| DbiLastSyncronized | String | Last external syncronization. |
| DbiKey | String | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | String | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | Integer | How did we get this contact? For future integration needs |
| ActiveErpLinks | Integer | The number of active erp links |
| BounceEmails | Array | Email addresses with a positive bounce counter. |
| Domains | Array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | Object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | Object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |

## Response:

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

### Response body: ContactEntityWithLinks

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | int32 | Primary key |
| Name | string | Contact name |
| Department | string | Department |
| OrgNr | string | VAT number or similar |
| Number1 | string | Alphanumeric user field |
| Number2 | string | Alphanumeric user field |
| UpdatedDate | date-time | Date last updated  in UTC. |
| CreatedDate | date-time | Date registered  in UTC. |
| Emails | array | The contact's email |
| Interests | array | The contact's available and selected interests.  Use MDO List name "contint" to get list items. |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  Use MDO List name "associate" to get list items. |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  Use MDO List name "business" to get list items. |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  Use MDO List name "category" to get list items. |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  Use MDO List name "country" to get list items. |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | Use MDO List name "associate" to get list items. |
| TicketPriority | TicketPriority | Use MDO List name "ticketpriority" to get list items. |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the Person Agent. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered.  Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and UserDefinedFields properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |
| _Links | object |  |

## Sample request

```http!
POST /api/v1/Contact
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 363,
  "Name": "Macejkovic Inc and Sons",
  "Department": "",
  "OrgNr": "815056",
  "Number1": "1042103",
  "Number2": "522558",
  "UpdatedDate": "2003-07-10T13:13:31.4801667+02:00",
  "CreatedDate": "2000-09-19T13:13:31.4801667+02:00",
  "Emails": [
    {
      "Value": "ea",
      "StrippedValue": "et",
      "Description": "Managed 5th generation solution"
    },
    {
      "Value": "ea",
      "StrippedValue": "et",
      "Description": "Managed 5th generation solution"
    }
  ],
  "Interests": [
    {
      "Id": 143,
      "Name": "Hirthe Group",
      "ToolTip": "Iste cum.",
      "Deleted": true,
      "Rank": 860,
      "Type": "et",
      "ColorBlock": 93,
      "IconHint": "deleniti",
      "Selected": false,
      "LastChanged": "2005-02-16T13:13:31.4801667+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "harum",
      "StyleHint": "expedita",
      "Hidden": false,
      "FullName": "Giovanna Borer"
    }
  ],
  "Urls": [
    {
      "Value": "fuga",
      "StrippedValue": "eius",
      "Description": "Cloned directional migration"
    },
    {
      "Value": "fuga",
      "StrippedValue": "eius",
      "Description": "Cloned directional migration"
    }
  ],
  "Phones": [
    {
      "Value": "voluptatum",
      "StrippedValue": "quia",
      "Description": "Object-based even-keeled workforce"
    },
    {
      "Value": "voluptatum",
      "StrippedValue": "quia",
      "Description": "Object-based even-keeled workforce"
    }
  ],
  "Faxes": [
    {
      "Value": "similique",
      "StrippedValue": "incidunt",
      "Description": "Adaptive global focus group"
    },
    {
      "Value": "similique",
      "StrippedValue": "incidunt",
      "Description": "Adaptive global focus group"
    }
  ],
  "Description": "Distributed uniform standardization",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "laudantium",
      "PersonId": 87,
      "Mrmrs": "veritatis",
      "Firstname": "Velda",
      "Lastname": "Cole",
      "MiddleName": "Russel Group",
      "Title": "at",
      "Description": "Self-enabling context-sensitive groupware",
      "Email": "rosemarie@lynch.com",
      "FullName": "Marjorie Gutkowski",
      "DirectPhone": "1-165-272-9564",
      "FormalName": "Gibson, Farrell and Hayes",
      "CountryId": 668,
      "ContactId": 873,
      "ContactName": "Ratke Group",
      "Retired": 922,
      "Rank": 215,
      "ActiveInterests": 96,
      "ContactDepartment": "",
      "ContactCountryId": 803,
      "ContactOrgNr": "246146",
      "FaxPhone": "(900)051-3794 x531",
      "MobilePhone": "(133)730-5339 x7100",
      "ContactPhone": "1-915-786-8540",
      "AssociateName": "Mitchell, Roberts and Gleichner",
      "AssociateId": 381,
      "UsePersonAddress": true,
      "ContactFax": "tenetur",
      "Kanafname": "accusamus",
      "Kanalname": "et",
      "Post1": "soluta",
      "Post2": "reiciendis",
      "Post3": "adipisci",
      "EmailName": "raegan.pacocha@damoreschuppe.com",
      "ContactFullName": "Earnestine Haag",
      "ActiveErpLinks": 899,
      "TicketPriorityId": 479,
      "SupportLanguageId": 551,
      "SupportAssociateId": 87,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "voluptatibus",
  "Xstop": true,
  "ActiveInterests": 691,
  "GroupId": 451,
  "ActiveStatusMonitorId": 33,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 927,
  "DbiAgentId": 769,
  "DbiLastSyncronized": "2015-08-12T13:13:31.4957903+02:00",
  "DbiKey": "exercitationem",
  "DbiLastModified": "2005-06-11T13:13:31.4957903+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 540,
  "ActiveErpLinks": 249,
  "BounceEmails": [
    "austyn_monahan@schadenbarrows.com",
    "dewayne@dickens.info"
  ],
  "Domains": [
    "illum",
    "occaecati"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Tess Herman",
    "SuperOffice:2": "Jo Ayana Beatty PhD"
  },
  "ExtraFields": {
    "ExtraFields1": "dolor",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "cum",
    "CustomFields2": "illo"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 252,
  "Name": "Grady-Wisozk",
  "Department": "",
  "OrgNr": "1793385",
  "Number1": "1417918",
  "Number2": "1512242",
  "UpdatedDate": "2015-01-08T13:13:31.4957903+01:00",
  "CreatedDate": "2014-06-17T13:13:31.4957903+02:00",
  "Emails": [
    {
      "Value": "harum",
      "StrippedValue": "blanditiis",
      "Description": "Self-enabling 5th generation function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 123
        }
      }
    },
    {
      "Value": "harum",
      "StrippedValue": "blanditiis",
      "Description": "Self-enabling 5th generation function",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 123
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 256,
      "Name": "Abbott, O'Kon and Walker",
      "ToolTip": "Voluptatibus exercitationem quidem.",
      "Deleted": false,
      "Rank": 69,
      "Type": "temporibus",
      "ColorBlock": 796,
      "IconHint": "error",
      "Selected": true,
      "LastChanged": "2003-02-06T13:13:31.4957903+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "dolor",
      "StyleHint": "accusamus",
      "Hidden": false,
      "FullName": "Breanne Lue Hayes IV",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 277
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "omnis",
      "StrippedValue": "ipsum",
      "Description": "Persistent zero tolerance frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 118
        }
      }
    },
    {
      "Value": "omnis",
      "StrippedValue": "ipsum",
      "Description": "Persistent zero tolerance frame",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 118
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "tempore",
      "StrippedValue": "alias",
      "Description": "Progressive object-oriented migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 347
        }
      }
    },
    {
      "Value": "tempore",
      "StrippedValue": "alias",
      "Description": "Progressive object-oriented migration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 347
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "alias",
      "StrippedValue": "ut",
      "Description": "Fundamental responsive circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 655
        }
      }
    },
    {
      "Value": "alias",
      "StrippedValue": "ut",
      "Description": "Fundamental responsive circuit",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 655
        }
      }
    }
  ],
  "Description": "Progressive optimal superstructure",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "nihil",
      "PersonId": 731,
      "Mrmrs": "maxime",
      "Firstname": "Halie",
      "Lastname": "McGlynn",
      "MiddleName": "Luettgen-Lakin",
      "Title": "aut",
      "Description": "Decentralized holistic moratorium",
      "Email": "enoch_strosin@damore.name",
      "FullName": "Mr. Magnolia Carolyne O'Connell",
      "DirectPhone": "722-036-6379",
      "FormalName": "Gleason, O'Kon and Grant",
      "CountryId": 504,
      "ContactId": 743,
      "ContactName": "Emmerich Inc and Sons",
      "Retired": 497,
      "Rank": 839,
      "ActiveInterests": 576,
      "ContactDepartment": "",
      "ContactCountryId": 966,
      "ContactOrgNr": "906481",
      "FaxPhone": "549.759.8484",
      "MobilePhone": "1-155-682-1809",
      "ContactPhone": "1-401-292-9329",
      "AssociateName": "Murray, Mayert and Hickle",
      "AssociateId": 735,
      "UsePersonAddress": true,
      "ContactFax": "adipisci",
      "Kanafname": "ut",
      "Kanalname": "laudantium",
      "Post1": "est",
      "Post2": "aspernatur",
      "Post3": "facere",
      "EmailName": "cheyanne@shanahan.info",
      "ContactFullName": "Lyric Maximilian Gibson I",
      "ActiveErpLinks": 973,
      "TicketPriorityId": 741,
      "SupportLanguageId": 503,
      "SupportAssociateId": 387,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 469
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "sed",
  "Xstop": true,
  "ActiveInterests": 804,
  "GroupId": 287,
  "ActiveStatusMonitorId": 308,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 432,
  "DbiAgentId": 346,
  "DbiLastSyncronized": "2002-11-17T13:13:31.5114093+01:00",
  "DbiKey": "at",
  "DbiLastModified": "2015-07-11T13:13:31.5114093+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 737,
  "ActiveErpLinks": 622,
  "BounceEmails": [
    "eulah@herzog.co.uk",
    "grace@considine.uk"
  ],
  "Domains": [
    "facilis",
    "quasi"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Axel Emard",
    "SuperOffice:2": "2049878621"
  },
  "ExtraFields": {
    "ExtraFields1": "consequuntur",
    "ExtraFields2": "numquam"
  },
  "CustomFields": {
    "CustomFields1": "asperiores",
    "CustomFields2": "odit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 317
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```