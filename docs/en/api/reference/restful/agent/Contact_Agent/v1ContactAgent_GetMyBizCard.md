---
title: POST Agents/Contact/GetMyBizCard
uid: v1ContactAgent_GetMyBizCard
generated: true
---

# POST Agents/Contact/GetMyBizCard

```http
POST /api/v1/Agents/Contact/GetMyBizCard
```

Returns all data needed to display the logged on person's business card.


That is company, person, and company interest data.






## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetMyBizCard?$select=name,department,category/id
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
| Interests | array | The contact's available and selected interests.  <para>Use MDO List name "contint" to get list items.</para> |
| Urls | array | The contact's internet adresses |
| Phones | array | The contact's phone numbers |
| Faxes | array | The contact's fax numbers |
| Description | string | Description of the contact. Usually shown as a postit note. |
| UpdatedBy | Associate | The user that last updated the contact |
| CreatedBy | Associate | The user that created the contact |
| Associate | Associate | The user that owns this contact.  <para>Use MDO List name "associate" to get list items.</para> |
| Business | Business | The business that the contact is associated with. The GUI forces the user to enter a business type.  <para>Use MDO List name "business" to get list items.</para> |
| Category | Category | The category that is set on the company. The GUI forces the user to enter a category type  <para>Use MDO List name "category" to get list items.</para> |
| Country | Country | The country this contact is located in. The country a contact is saved with, affects the phone number format, and the address layout.  <para>Use MDO List name "country" to get list items.</para> |
| Persons | array | The persons belonging to the contact. |
| NoMailing | bool | Spam filter. Indicates if this contact should retrieve advertising. |
| Kananame | string | Contact kana name, used in Japanese versions only |
| Xstop | bool | STOP flag |
| ActiveInterests | int32 | The number of active interests. |
| GroupId | int32 | Group id of original owning associate, semantics like appnt.grp_id |
| ActiveStatusMonitorId | int32 | Active status monitor identity with the lowest rank for contact |
| SupportAssociate | Associate | <para>Use MDO List name "associate" to get list items.</para> |
| TicketPriority | TicketPriority | <para>Use MDO List name "ticketpriority" to get list items.</para> |
| CustomerLanguage | CustomerLanguage | customerlanguage |
| Deleted | int32 | If nonzero, then this contact is 'deleted' and should generally not be shown |
| DbiAgentId | int32 | Integration agent (eJournal) |
| DbiLastSyncronized | date-time | Last external syncronization. |
| DbiKey | string | The primary key for the integrated entry in the external datasource. |
| DbiLastModified | date-time | When the entry was last modified. |
| SupportPerson | Person | Carrier object for Person. Services for the Person Carrier is available from the <see cref="T:SuperOffice.CRM.Services.IPersonAgent">Person Agent</see>. |
| Address | Address | Street and/or Postal address, in both formatted and structured forms. You only need to modify one of the two for the change to be registered. <para /> Carrier object for Address. |
| Source | int32 | How did we get this contact? For future integration needs |
| ActiveErpLinks | int32 | The number of active erp links |
| BounceEmails | array | Email addresses with a positive bounce counter. |
| Domains | array | Web domains for this contact, ordered in array by rank |
| UserDefinedFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Dictionary of user defined field data. The key string is the ProgId of the UdefField, or if the ProgId is empty it is a string of the format "SuperOffice:[UdefFieldIdentity]", e.g. "SuperOffice:1234" |
| ExtraFields | object | Deprecated: Use {SuperOffice.CRM.Services.ContactEntity.CustomFields} instead. Extra fields added to the carrier. This could be data from Plug-ins, the foreign key system, external applications, etc. |
| CustomFields | object | Udef + Extra fields added to the carrier. Extra fields as defined by changes to database schema + user-defined fields as defined by admin. Custom fields combines user defined fields and extra fields into one bucket.  The individual {SuperOffice.CRM.Services.ContactEntity.ExtraFields} and <see cref="P:SuperOffice.CRM.Services.ContactEntity.UserDefinedFields">UserDefinedFields</see> properties are deprecated in favor of this combined collection. |
| TableRight | TableRight | The carrier's table right |
| FieldProperties | object | Field property dictionary mapping field names to field access rights. |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetMyBizCard
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 117,
  "Name": "Bahringer Group",
  "Department": "",
  "OrgNr": "1106679",
  "Number1": "1035530",
  "Number2": "1103229",
  "UpdatedDate": "2002-09-28T23:03:55.3686379+02:00",
  "CreatedDate": "2003-11-11T23:03:55.3686379+01:00",
  "Emails": [
    {
      "Value": "nihil",
      "StrippedValue": "nesciunt",
      "Description": "Mandatory 4th generation flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 713
        }
      }
    },
    {
      "Value": "nihil",
      "StrippedValue": "nesciunt",
      "Description": "Mandatory 4th generation flexibility",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 713
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 549,
      "Name": "Paucek, Cormier and Bahringer",
      "ToolTip": "Et sequi ut vero.",
      "Deleted": true,
      "Rank": 917,
      "Type": "aut",
      "ColorBlock": 238,
      "IconHint": "ut",
      "Selected": false,
      "LastChanged": "2020-05-16T23:03:55.3686379+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "veritatis",
      "StyleHint": "quis",
      "Hidden": false,
      "FullName": "Raphael Fahey",
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
  "Urls": [
    {
      "Value": "quaerat",
      "StrippedValue": "praesentium",
      "Description": "Fundamental cohesive groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 809
        }
      }
    },
    {
      "Value": "quaerat",
      "StrippedValue": "praesentium",
      "Description": "Fundamental cohesive groupware",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 809
        }
      }
    }
  ],
  "Phones": [
    {
      "Value": "repellat",
      "StrippedValue": "dolor",
      "Description": "Networked uniform projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 642
        }
      }
    },
    {
      "Value": "repellat",
      "StrippedValue": "dolor",
      "Description": "Networked uniform projection",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 642
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "laborum",
      "StrippedValue": "dolor",
      "Description": "Secured reciprocal system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "dolor",
      "Description": "Secured reciprocal system engine",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 791
        }
      }
    }
  ],
  "Description": "Visionary radical success",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "quia",
      "PersonId": 216,
      "Mrmrs": "vero",
      "Firstname": "Furman",
      "Lastname": "Kemmer",
      "MiddleName": "O'Kon, Nolan and Crooks",
      "Title": "placeat",
      "Description": "Synergistic stable firmware",
      "Email": "jaylen_kessler@leannonlueilwitz.name",
      "FullName": "Dr. Keegan Kirstin Champlin IV",
      "DirectPhone": "492.977.5350",
      "FormalName": "Ondricka, Hermiston and Prosacco",
      "CountryId": 128,
      "ContactId": 600,
      "ContactName": "Satterfield LLC",
      "Retired": 250,
      "Rank": 569,
      "ActiveInterests": 120,
      "ContactDepartment": "",
      "ContactCountryId": 694,
      "ContactOrgNr": "1301703",
      "FaxPhone": "(908)329-9350",
      "MobilePhone": "(018)777-6235 x612",
      "ContactPhone": "266.233.6375",
      "AssociateName": "Bogan-Jakubowski",
      "AssociateId": 245,
      "UsePersonAddress": true,
      "ContactFax": "debitis",
      "Kanafname": "dolorum",
      "Kanalname": "sit",
      "Post1": "occaecati",
      "Post2": "eos",
      "Post3": "expedita",
      "EmailName": "kiana@ebert.co.uk",
      "ContactFullName": "Jimmy Trantow",
      "ActiveErpLinks": 410,
      "TicketPriorityId": 815,
      "SupportLanguageId": 186,
      "SupportAssociateId": 68,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 88
        }
      }
    }
  ],
  "NoMailing": false,
  "Kananame": "qui",
  "Xstop": true,
  "ActiveInterests": 898,
  "GroupId": 202,
  "ActiveStatusMonitorId": 723,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 585,
  "DbiAgentId": 257,
  "DbiLastSyncronized": "2012-04-25T23:03:55.3726377+02:00",
  "DbiKey": "atque",
  "DbiLastModified": "2005-01-18T23:03:55.3726377+01:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 451,
  "ActiveErpLinks": 385,
  "BounceEmails": [
    "fay.simonis@schmidtkovacek.com",
    "justina@rolfson.co.uk"
  ],
  "Domains": [
    "dolores",
    "vel"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "True",
    "SuperOffice:2": "1405929955"
  },
  "ExtraFields": {
    "ExtraFields1": "at",
    "ExtraFields2": "aperiam"
  },
  "CustomFields": {
    "CustomFields1": "nam",
    "CustomFields2": "laborum"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.String",
      "FieldLength": 834
    }
  }
}
```