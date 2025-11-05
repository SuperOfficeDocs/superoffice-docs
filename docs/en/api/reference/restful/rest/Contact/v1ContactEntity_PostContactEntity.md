---
title: POST Contact
uid: v1ContactEntity_PostContactEntity
generated: true
content_type: reference
---

# POST Contact

```http
POST /api/v1/Contact
```

Creates a new ContactEntity


Calls the Contact agent service SaveContactEntity.
NsApiSlow threshold: 2000 ms.






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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
| UtmParameters | SavedUtmParameters | Utm parameters when creating first person and contact, readonly field |
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
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 156,
  "Name": "Blick, Sanford and Rice",
  "Department": "",
  "OrgNr": "1024374",
  "Number1": "1218979",
  "Number2": "1119202",
  "UpdatedDate": "2015-06-02T02:30:52.4442929+02:00",
  "CreatedDate": "2005-09-05T02:30:52.4442929+02:00",
  "Emails": [
    {
      "Value": "quae",
      "StrippedValue": "nihil",
      "Description": "Realigned client-server infrastructure"
    },
    {
      "Value": "quae",
      "StrippedValue": "nihil",
      "Description": "Realigned client-server infrastructure"
    }
  ],
  "Interests": [
    {
      "Id": 173,
      "Name": "Rutherford Inc and Sons",
      "ToolTip": "Magni aut tempore expedita.",
      "Deleted": true,
      "Rank": 150,
      "Type": "aut",
      "ColorBlock": 692,
      "IconHint": "voluptatem",
      "Selected": false,
      "LastChanged": "1998-10-05T02:30:52.4442929+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "qui",
      "StyleHint": "dolore",
      "Hidden": false,
      "FullName": "Ms. Pearlie Gideon Buckridge IV"
    }
  ],
  "Urls": [
    {
      "Value": "maxime",
      "StrippedValue": "tempora",
      "Description": "Reactive context-sensitive process improvement"
    },
    {
      "Value": "maxime",
      "StrippedValue": "tempora",
      "Description": "Reactive context-sensitive process improvement"
    }
  ],
  "Phones": [
    {
      "Value": "in",
      "StrippedValue": "iste",
      "Description": "Triple-buffered disintermediate middleware"
    },
    {
      "Value": "in",
      "StrippedValue": "iste",
      "Description": "Triple-buffered disintermediate middleware"
    }
  ],
  "Faxes": [
    {
      "Value": "aperiam",
      "StrippedValue": "nisi",
      "Description": "Extended motivating capability"
    },
    {
      "Value": "aperiam",
      "StrippedValue": "nisi",
      "Description": "Extended motivating capability"
    }
  ],
  "Description": "Up-sized impactful matrix",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quisquam",
      "PersonId": 222,
      "Mrmrs": "ex",
      "Firstname": "Rudy",
      "Lastname": "Herman",
      "MiddleName": "Kuhn-Okuneva",
      "Title": "saepe",
      "Description": "Diverse grid-enabled function",
      "Email": "cordie.ohara@kuvalis.co.uk",
      "FullName": "Kory Zboncak",
      "DirectPhone": "438.339.9354",
      "FormalName": "Buckridge Group",
      "CountryId": 583,
      "ContactId": 450,
      "ContactName": "Renner, Block and Wiegand",
      "Retired": 323,
      "Rank": 91,
      "ActiveInterests": 939,
      "ContactDepartment": "",
      "ContactCountryId": 413,
      "ContactOrgNr": "987056",
      "FaxPhone": "335.872.0807 x2107",
      "MobilePhone": "024-627-8354 x7467",
      "ContactPhone": "1-886-462-2046 x65595",
      "AssociateName": "Daugherty, Beer and Gottlieb",
      "AssociateId": 633,
      "UsePersonAddress": true,
      "ContactFax": "impedit",
      "Kanafname": "quia",
      "Kanalname": "voluptas",
      "Post1": "at",
      "Post2": "nulla",
      "Post3": "et",
      "EmailName": "rosetta@lueilwitz.ca",
      "ContactFullName": "Magnus Brakus",
      "ActiveErpLinks": 515,
      "TicketPriorityId": 976,
      "SupportLanguageId": 960,
      "SupportAssociateId": 377,
      "CategoryName": "VIP Customer",
      "PersonNumber": "296914"
    }
  ],
  "NoMailing": false,
  "Kananame": "nihil",
  "Xstop": true,
  "ActiveInterests": 29,
  "GroupId": 664,
  "ActiveStatusMonitorId": 354,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 929,
  "DbiAgentId": 242,
  "DbiLastSyncronized": "2002-12-31T02:30:52.4599175+01:00",
  "DbiKey": "dolorem",
  "DbiLastModified": "2003-10-29T02:30:52.4599175+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 191,
  "ActiveErpLinks": 978,
  "BounceEmails": [
    "sydnie@stroman.name",
    "lori_dare@daugherty.biz"
  ],
  "Domains": [
    "et",
    "debitis"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Hector Doyle III",
    "SuperOffice:2": "1900764650"
  },
  "ExtraFields": {
    "ExtraFields1": "temporibus",
    "ExtraFields2": "id"
  },
  "CustomFields": {
    "CustomFields1": "nulla",
    "CustomFields2": "non"
  }
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 13,
  "Name": "Brown, Steuber and Aufderhar",
  "Department": "",
  "OrgNr": "641952",
  "Number1": "1651066",
  "Number2": "380610",
  "UpdatedDate": "1999-09-05T02:30:52.4599175+02:00",
  "CreatedDate": "2007-05-05T02:30:52.4599175+02:00",
  "Emails": [
    {
      "Value": "rerum",
      "StrippedValue": "accusamus",
      "Description": "Automated discrete focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 476
        }
      }
    },
    {
      "Value": "rerum",
      "StrippedValue": "accusamus",
      "Description": "Automated discrete focus group",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 476
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 613,
      "Name": "Emard Inc and Sons",
      "ToolTip": "Perferendis sed fuga et facere dolores minus nesciunt.",
      "Deleted": false,
      "Rank": 49,
      "Type": "nulla",
      "ColorBlock": 941,
      "IconHint": "consequatur",
      "Selected": true,
      "LastChanged": "2018-01-09T02:30:52.4599175+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "officia",
      "StyleHint": "quia",
      "Hidden": true,
      "FullName": "Lavinia Barton",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 796
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "numquam",
      "StrippedValue": "nam",
      "Description": "Inverse incremental orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    },
    {
      "Value": "numquam",
      "StrippedValue": "nam",
      "Description": "Inverse incremental orchestration",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 847
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "vitae",
      "StrippedValue": "earum",
      "Description": "Reverse-engineered global methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    },
    {
      "Value": "vitae",
      "StrippedValue": "earum",
      "Description": "Reverse-engineered global methodology",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 262
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "occaecati",
      "StrippedValue": "distinctio",
      "Description": "Customizable responsive benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 739
        }
      }
    },
    {
      "Value": "occaecati",
      "StrippedValue": "distinctio",
      "Description": "Customizable responsive benchmark",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 739
        }
      }
    }
  ],
  "Description": "Sharable intermediate migration",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "eaque",
      "PersonId": 907,
      "Mrmrs": "et",
      "Firstname": "Winston",
      "Lastname": "Lakin",
      "MiddleName": "Dach, Johnson and Hayes",
      "Title": "saepe",
      "Description": "Future-proofed tangible instruction set",
      "Email": "kim_daniel@macejkovicschowalter.com",
      "FullName": "Elza D'Amore",
      "DirectPhone": "690.090.0952",
      "FormalName": "Emmerich, Jakubowski and Rosenbaum",
      "CountryId": 651,
      "ContactId": 718,
      "ContactName": "Monahan, Marks and Senger",
      "Retired": 741,
      "Rank": 267,
      "ActiveInterests": 508,
      "ContactDepartment": "",
      "ContactCountryId": 873,
      "ContactOrgNr": "706817",
      "FaxPhone": "054.561.6947",
      "MobilePhone": "326-223-1073",
      "ContactPhone": "207.848.1045 x45704",
      "AssociateName": "Borer, Bednar and Donnelly",
      "AssociateId": 341,
      "UsePersonAddress": true,
      "ContactFax": "quidem",
      "Kanafname": "amet",
      "Kanalname": "alias",
      "Post1": "sequi",
      "Post2": "commodi",
      "Post3": "minus",
      "EmailName": "courtney@swift.com",
      "ContactFullName": "Dr. Vicenta Nader DDS",
      "ActiveErpLinks": 994,
      "TicketPriorityId": 143,
      "SupportLanguageId": 543,
      "SupportAssociateId": 451,
      "CategoryName": "VIP Customer",
      "PersonNumber": "1481528",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 430
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "deleniti",
  "Xstop": true,
  "ActiveInterests": 703,
  "GroupId": 823,
  "ActiveStatusMonitorId": 430,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 309,
  "DbiAgentId": 111,
  "DbiLastSyncronized": "2006-10-27T02:30:52.4599175+02:00",
  "DbiKey": "ut",
  "DbiLastModified": "2018-05-11T02:30:52.4599175+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 866,
  "ActiveErpLinks": 137,
  "BounceEmails": [
    "erin@mitchell.uk",
    "gregg@ferry.us"
  ],
  "Domains": [
    "perspiciatis",
    "minus"
  ],
  "UtmParameters": null,
  "UserDefinedFields": {
    "SuperOffice:1": "2094780446",
    "SuperOffice:2": "1608183013"
  },
  "ExtraFields": {
    "ExtraFields1": "est",
    "ExtraFields2": "temporibus"
  },
  "CustomFields": {
    "CustomFields1": "impedit",
    "CustomFields2": "sit"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 781
    }
  },
  "_Links": {
    "Self": "https://www.example.com/api/v1/project/321",
    "Archive": "https://www.example.com/api/v1/project"
  }
}
```