---
title: POST Agents/Contact/SaveContactEntity
uid: v1ContactAgent_SaveContactEntity
generated: true
---

# POST Agents/Contact/SaveContactEntity

```http
POST /api/v1/Agents/Contact/SaveContactEntity
```

Updates the existing ContactEntity or creates a new ContactEntity if the id parameter is empty








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

### Response body: ContactEntity

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

## Sample request

```http!
POST /api/v1/Agents/Contact/SaveContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv
Content-Type: application/json; charset=utf-8

{
  "ContactId": 784,
  "Name": "Weber-Nicolas",
  "Department": "",
  "OrgNr": "996197",
  "Number1": "877587",
  "Number2": "925749",
  "UpdatedDate": "2010-08-01T04:02:01.4248943+02:00",
  "CreatedDate": "2002-07-09T04:02:01.4248943+02:00",
  "Emails": [
    {
      "Value": "aliquam",
      "StrippedValue": "optio",
      "Description": "Profit-focused fault-tolerant implementation"
    },
    {
      "Value": "aliquam",
      "StrippedValue": "optio",
      "Description": "Profit-focused fault-tolerant implementation"
    }
  ],
  "Interests": [
    {
      "Id": 538,
      "Name": "Sauer-Gleason",
      "ToolTip": "A blanditiis blanditiis veniam laudantium.",
      "Deleted": true,
      "Rank": 222,
      "Type": "aut",
      "ColorBlock": 31,
      "IconHint": "vero",
      "Selected": true,
      "LastChanged": "2005-12-30T04:02:01.4248943+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "et",
      "StyleHint": "labore",
      "Hidden": false,
      "FullName": "Jammie Jabari Reichert MD"
    }
  ],
  "Urls": [
    {
      "Value": "quia",
      "StrippedValue": "itaque",
      "Description": "Reduced disintermediate projection"
    },
    {
      "Value": "quia",
      "StrippedValue": "itaque",
      "Description": "Reduced disintermediate projection"
    }
  ],
  "Phones": [
    {
      "Value": "vel",
      "StrippedValue": "non",
      "Description": "Integrated leading edge infrastructure"
    },
    {
      "Value": "vel",
      "StrippedValue": "non",
      "Description": "Integrated leading edge infrastructure"
    }
  ],
  "Faxes": [
    {
      "Value": "dicta",
      "StrippedValue": "distinctio",
      "Description": "Stand-alone 6th generation focus group"
    },
    {
      "Value": "dicta",
      "StrippedValue": "distinctio",
      "Description": "Stand-alone 6th generation focus group"
    }
  ],
  "Description": "Persistent executive algorithm",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "similique",
      "PersonId": 299,
      "Mrmrs": "est",
      "Firstname": "Chaz",
      "Lastname": "Feil",
      "MiddleName": "Gislason-Mosciski",
      "Title": "nihil",
      "Description": "Robust discrete hierarchy",
      "Email": "teagan_grant@flatleynikolaus.info",
      "FullName": "Molly Gottlieb",
      "DirectPhone": "(585)365-3794 x03189",
      "FormalName": "Jenkins LLC",
      "CountryId": 101,
      "ContactId": 398,
      "ContactName": "Hoeger Group",
      "Retired": 983,
      "Rank": 637,
      "ActiveInterests": 863,
      "ContactDepartment": "",
      "ContactCountryId": 375,
      "ContactOrgNr": "1297725",
      "FaxPhone": "042-982-9150 x14729",
      "MobilePhone": "006-024-3622 x56107",
      "ContactPhone": "219-518-6711",
      "AssociateName": "Wyman Inc and Sons",
      "AssociateId": 549,
      "UsePersonAddress": false,
      "ContactFax": "minima",
      "Kanafname": "et",
      "Kanalname": "facere",
      "Post1": "quod",
      "Post2": "sequi",
      "Post3": "eaque",
      "EmailName": "isabella.kertzmann@stantonrunolfsson.ca",
      "ContactFullName": "Gianni Haag",
      "ActiveErpLinks": 623,
      "TicketPriorityId": 600,
      "SupportLanguageId": 77,
      "SupportAssociateId": 545,
      "CategoryName": "VIP Customer"
    }
  ],
  "NoMailing": false,
  "Kananame": "rerum",
  "Xstop": false,
  "ActiveInterests": 821,
  "GroupId": 391,
  "ActiveStatusMonitorId": 812,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 423,
  "DbiAgentId": 337,
  "DbiLastSyncronized": "2021-03-13T04:02:01.4405177+01:00",
  "DbiKey": "quae",
  "DbiLastModified": "2002-01-26T04:02:01.4405177+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 729,
  "ActiveErpLinks": 511,
  "BounceEmails": [
    "mariano@tillman.info",
    "petra_legros@runolfsson.com"
  ],
  "Domains": [
    "rerum",
    "amet"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Mrs. Narciso Grace McGlynn",
    "SuperOffice:2": "887970679"
  },
  "ExtraFields": {
    "ExtraFields1": "mollitia",
    "ExtraFields2": "et"
  },
  "CustomFields": {
    "CustomFields1": "at",
    "CustomFields2": "laboriosam"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 465,
  "Name": "Corwin, Kautzer and Tromp",
  "Department": "",
  "OrgNr": "1401972",
  "Number1": "804179",
  "Number2": "1201275",
  "UpdatedDate": "1999-11-20T04:02:01.4405177+01:00",
  "CreatedDate": "2019-02-11T04:02:01.4405177+01:00",
  "Emails": [
    {
      "Value": "et",
      "StrippedValue": "omnis",
      "Description": "Upgradable background monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 233
        }
      }
    },
    {
      "Value": "et",
      "StrippedValue": "omnis",
      "Description": "Upgradable background monitoring",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 233
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 316,
      "Name": "Watsica-Herzog",
      "ToolTip": "Et suscipit ab perspiciatis quos corporis eum.",
      "Deleted": false,
      "Rank": 936,
      "Type": "perferendis",
      "ColorBlock": 455,
      "IconHint": "recusandae",
      "Selected": true,
      "LastChanged": "1999-12-08T04:02:01.4405177+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "minus",
      "StyleHint": "occaecati",
      "Hidden": false,
      "FullName": "Katlyn Dach PhD",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 795
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "quas",
      "StrippedValue": "omnis",
      "Description": "Virtual non-volatile portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 712
        }
      }
    },
    {
      "Value": "quas",
      "StrippedValue": "omnis",
      "Description": "Virtual non-volatile portal",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 712
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "veritatis",
      "StrippedValue": "pariatur",
      "Description": "Cloned optimizing support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 374
        }
      }
    },
    {
      "Value": "veritatis",
      "StrippedValue": "pariatur",
      "Description": "Cloned optimizing support",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 374
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "quam",
      "StrippedValue": "sed",
      "Description": "Multi-lateral intangible info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    },
    {
      "Value": "quam",
      "StrippedValue": "sed",
      "Description": "Multi-lateral intangible info-mediaries",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 407
        }
      }
    }
  ],
  "Description": "Distributed zero defect function",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "odit",
      "PersonId": 65,
      "Mrmrs": "omnis",
      "Firstname": "Hiram",
      "Lastname": "Graham",
      "MiddleName": "Beier, Greenfelder and Considine",
      "Title": "animi",
      "Description": "Multi-channelled global analyzer",
      "Email": "gregory_bradtke@schmeler.us",
      "FullName": "Krystina Yost",
      "DirectPhone": "542.089.2204",
      "FormalName": "Spinka-Witting",
      "CountryId": 302,
      "ContactId": 738,
      "ContactName": "Boyer-Sanford",
      "Retired": 503,
      "Rank": 166,
      "ActiveInterests": 209,
      "ContactDepartment": "recontextualize transparent interfaces",
      "ContactCountryId": 241,
      "ContactOrgNr": "195645",
      "FaxPhone": "1-694-912-3324",
      "MobilePhone": "964-857-4953",
      "ContactPhone": "(729)564-0454",
      "AssociateName": "Gottlieb-Schmidt",
      "AssociateId": 761,
      "UsePersonAddress": false,
      "ContactFax": "dolorem",
      "Kanafname": "eius",
      "Kanalname": "qui",
      "Post1": "ullam",
      "Post2": "magni",
      "Post3": "delectus",
      "EmailName": "jakob@stantonkuphal.name",
      "ContactFullName": "Chanel DuBuque",
      "ActiveErpLinks": 441,
      "TicketPriorityId": 720,
      "SupportLanguageId": 410,
      "SupportAssociateId": 899,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 968
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "deserunt",
  "Xstop": false,
  "ActiveInterests": 611,
  "GroupId": 620,
  "ActiveStatusMonitorId": 764,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 817,
  "DbiAgentId": 200,
  "DbiLastSyncronized": "2014-03-27T04:02:01.4405177+01:00",
  "DbiKey": "iste",
  "DbiLastModified": "1999-08-01T04:02:01.4405177+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 752,
  "ActiveErpLinks": 500,
  "BounceEmails": [
    "carmella.zboncak@orn.com",
    "diana_hermiston@anderson.com"
  ],
  "Domains": [
    "harum",
    "est"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "False",
    "SuperOffice:2": "Macey Welch"
  },
  "ExtraFields": {
    "ExtraFields1": "dolores",
    "ExtraFields2": "repellat"
  },
  "CustomFields": {
    "CustomFields1": "rerum",
    "CustomFields2": "asperiores"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 667
    }
  }
}
```