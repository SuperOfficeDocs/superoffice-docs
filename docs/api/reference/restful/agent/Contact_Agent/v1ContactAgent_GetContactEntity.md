---
title: POST Agents/Contact/GetContactEntity
uid: v1ContactAgent_GetContactEntity
---

# POST Agents/Contact/GetContactEntity

```http
POST /api/v1/Agents/Contact/GetContactEntity
```

Gets a ContactEntity object.







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| contactEntityId | int32 | **Required** The primary key. |
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactEntity?contactEntityId=929
POST /api/v1/Agents/Contact/GetContactEntity?$select=name,department,category/id
```


## Request Headers

| Parameter Name | Description |
|----------------|-------------|
| Authorization  | Supports 'Basic', 'SoTicket' and 'Bearer' schemes, depending on installation type. |
| X-XSRF-TOKEN   | If not using Authorization header, you must provide XSRF value from cookie or hidden input field |
| Accept         | Content-type(s) you would like the response in: `application/json`, `text/json`, `application/xml`, `text/xml`, `application/json-patch+json`, `application/merge-patch+json` |
| Accept-Language | Convert string references and multi-language values into a specified language (iso2) code. |
| SO-Language | Convert string references and multi-language values into a specified language (iso2) code. Overrides Accept-Language value. |
| SO-Culture | Number, date formatting in a specified culture (iso2 language) code. Partially overrides SO-Language/Accept-Language value. Ignored if no Language set. |
| SO-TimeZone | Specify the timezone code that you would like date/time responses converted to. |
| SO-AppToken | The application token that identifies the partner app. Used when calling Online WebAPI from a server. |


## Response: 

OK

| Response | Description |
|----------------|-------------|
| 200 | OK |

Response body: 

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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy |  | The user that last updated the contact |
| CreatedBy |  | The user that created the contact |
| Associate |  | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business |  | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category |  | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country |  | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate |  | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority |  | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage |  | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson |  | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address |  | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight |  |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactEntity
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 845,
  "Name": "Roberts Group",
  "Department": "integrate 24/7 schemas",
  "OrgNr": "483068",
  "Number1": "898267",
  "Number2": "237945",
  "UpdatedDate": "1999-11-21T11:10:26.2635526+01:00",
  "CreatedDate": "2005-05-14T11:10:26.2635526+02:00",
  "Emails": [
    {
      "Value": "optio",
      "StrippedValue": "veritatis",
      "Description": "Stand-alone zero defect encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 633
        }
      }
    },
    {
      "Value": "optio",
      "StrippedValue": "veritatis",
      "Description": "Stand-alone zero defect encoding",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 633
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 850,
      "Name": "Heathcote, Green and Wuckert",
      "ToolTip": "Incidunt recusandae ducimus voluptate tempora sit dolores et.",
      "Deleted": true,
      "Rank": 183,
      "Type": "repudiandae",
      "ColorBlock": 644,
      "IconHint": "harum",
      "Selected": false,
      "LastChanged": "2017-11-27T11:10:26.2635526+01:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "incidunt",
      "StyleHint": "vitae",
      "Hidden": false,
      "FullName": "Bonnie Nitzsche",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 335
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "aliquam",
      "StrippedValue": "vero",
      "Description": "Implemented cohesive functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 342
        }
      }
    },
    {
      "Value": "aliquam",
      "StrippedValue": "vero",
      "Description": "Implemented cohesive functionalities",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 342
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "molestias",
      "StrippedValue": "accusantium",
      "Description": "Proactive attitude-oriented neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 673
        }
      }
    },
    {
      "Value": "molestias",
      "StrippedValue": "accusantium",
      "Description": "Proactive attitude-oriented neural-net",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 673
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "perferendis",
      "StrippedValue": "dolores",
      "Description": "Expanded fresh-thinking artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    },
    {
      "Value": "perferendis",
      "StrippedValue": "dolores",
      "Description": "Expanded fresh-thinking artificial intelligence",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 79
        }
      }
    }
  ],
  "Description": "Extended high-level attitude",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "sunt",
      "PersonId": 255,
      "Mrmrs": "nihil",
      "Firstname": "Peggie",
      "Lastname": "Kuvalis",
      "MiddleName": "Kutch Inc and Sons",
      "Title": "ipsa",
      "Description": "Grass-roots leading edge initiative",
      "Email": "laurence.kirlin@ankunding.name",
      "FullName": "Keenan Dickens",
      "DirectPhone": "733.714.6526 x811",
      "FormalName": "Quigley, Weissnat and Kuhic",
      "CountryId": 496,
      "ContactId": 324,
      "ContactName": "Smitham-Berge",
      "Retired": 167,
      "Rank": 698,
      "ActiveInterests": 869,
      "ContactDepartment": "",
      "ContactCountryId": 865,
      "ContactOrgNr": "957222",
      "FaxPhone": "458-431-1209 x609",
      "MobilePhone": "1-042-733-7768 x790",
      "ContactPhone": "1-476-950-9504 x85843",
      "AssociateName": "Murphy LLC",
      "AssociateId": 466,
      "UsePersonAddress": false,
      "ContactFax": "similique",
      "Kanafname": "sit",
      "Kanalname": "quibusdam",
      "Post1": "voluptate",
      "Post2": "sed",
      "Post3": "ut",
      "EmailName": "vickie@nikolaus.uk",
      "ContactFullName": "Madge Bobby Ullrich III",
      "ActiveErpLinks": 556,
      "TicketPriorityId": 812,
      "SupportLanguageId": 160,
      "SupportAssociateId": 924,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 412
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "deleniti",
  "Xstop": true,
  "ActiveInterests": 211,
  "GroupId": 622,
  "ActiveStatusMonitorId": 595,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 188,
  "DbiAgentId": 912,
  "DbiLastSyncronized": "2017-03-20T11:10:26.2675528+01:00",
  "DbiKey": "similique",
  "DbiLastModified": "2009-05-22T11:10:26.2675528+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 263,
  "ActiveErpLinks": 325,
  "BounceEmails": [
    "waylon@prosacco.name",
    "grayson@schadenrice.biz"
  ],
  "Domains": [
    "rerum",
    "possimus"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "Ms. Lawrence Stevie Sauer",
    "SuperOffice:2": "False"
  },
  "ExtraFields": {
    "ExtraFields1": "perspiciatis",
    "ExtraFields2": "rerum"
  },
  "CustomFields": {
    "CustomFields1": "distinctio",
    "CustomFields2": "quas"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 250
    }
  }
}
```