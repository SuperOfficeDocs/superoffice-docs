---
title: POST Agents/Contact/GetContactWithPersons
uid: v1ContactAgent_GetContactWithPersons
---

# POST Agents/Contact/GetContactWithPersons

```http
POST /api/v1/Agents/Contact/GetContactWithPersons
```

Returns the contact with all the contact persons belonging to the contact







## Query String Parameters

| Parameter Name | Type |  Description |
|----------------|------|--------------|
| $select | string |  Optional comma separated list of properties to include in the result. Other fields are then nulled out to reduce payload size: "Name,department,category". Default = show all fields. |

```http
POST /api/v1/Agents/Contact/GetContactWithPersons?$select=name,department,category/id
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

## Request Body: request 

ContactId 

| Property Name | Type |  Description |
|----------------|------|--------------|
| ContactId | Integer |  |

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
| TableRight | TableRight |  |
| FieldProperties | object |  |

## Sample request

```http!
POST /api/v1/Agents/Contact/GetContactWithPersons
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: en
Content-Type: application/json; charset=utf-8

{
  "ContactId": 517
}
```

## Sample response

```http_
HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8

{
  "ContactId": 465,
  "Name": "Schamberger, Treutel and Klocko",
  "Department": "",
  "OrgNr": "768799",
  "Number1": "1241654",
  "Number2": "1409893",
  "UpdatedDate": "2003-04-15T17:37:17.2172408+02:00",
  "CreatedDate": "2018-11-26T17:37:17.2172408+01:00",
  "Emails": [
    {
      "Value": "molestiae",
      "StrippedValue": "assumenda",
      "Description": "Multi-channelled 6th generation installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 405
        }
      }
    },
    {
      "Value": "molestiae",
      "StrippedValue": "assumenda",
      "Description": "Multi-channelled 6th generation installation",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 405
        }
      }
    }
  ],
  "Interests": [
    {
      "Id": 848,
      "Name": "Mante-Wunsch",
      "ToolTip": "Animi mollitia temporibus commodi sunt tempore beatae iure.",
      "Deleted": false,
      "Rank": 245,
      "Type": "temporibus",
      "ColorBlock": 424,
      "IconHint": "ullam",
      "Selected": false,
      "LastChanged": "2013-09-03T17:37:17.2172408+02:00",
      "ChildItems": [
        {},
        {}
      ],
      "ExtraInfo": "ut",
      "StyleHint": "tempora",
      "Hidden": true,
      "FullName": "Rey Dach",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 81
        }
      }
    }
  ],
  "Urls": [
    {
      "Value": "et",
      "StrippedValue": "libero",
      "Description": "Fundamental content-based hub",
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
      "Value": "et",
      "StrippedValue": "libero",
      "Description": "Fundamental content-based hub",
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
  "Phones": [
    {
      "Value": "non",
      "StrippedValue": "architecto",
      "Description": "Seamless attitude-oriented service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 654
        }
      }
    },
    {
      "Value": "non",
      "StrippedValue": "architecto",
      "Description": "Seamless attitude-oriented service-desk",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.String",
          "FieldLength": 654
        }
      }
    }
  ],
  "Faxes": [
    {
      "Value": "laborum",
      "StrippedValue": "nobis",
      "Description": "Total zero administration architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 91
        }
      }
    },
    {
      "Value": "laborum",
      "StrippedValue": "nobis",
      "Description": "Total zero administration architecture",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 91
        }
      }
    }
  ],
  "Description": "Secured optimal contingency",
  "UpdatedBy": null,
  "CreatedBy": null,
  "Associate": null,
  "Business": null,
  "Category": null,
  "Country": null,
  "Persons": [
    {
      "Position": "qui",
      "PersonId": 250,
      "Mrmrs": "qui",
      "Firstname": "Anissa",
      "Lastname": "Little",
      "MiddleName": "Jenkins Inc and Sons",
      "Title": "aperiam",
      "Description": "Business-focused actuating flexibility",
      "Email": "noe@considine.biz",
      "FullName": "Gonzalo McLaughlin",
      "DirectPhone": "1-376-878-2180 x8967",
      "FormalName": "Grant Inc and Sons",
      "CountryId": 671,
      "ContactId": 818,
      "ContactName": "Upton-Morissette",
      "Retired": 190,
      "Rank": 57,
      "ActiveInterests": 71,
      "ContactDepartment": "",
      "ContactCountryId": 797,
      "ContactOrgNr": "1419571",
      "FaxPhone": "205-224-1994 x4167",
      "MobilePhone": "042.743.4085",
      "ContactPhone": "633-829-1591 x6393",
      "AssociateName": "Smitham, Berge and Oberbrunner",
      "AssociateId": 849,
      "UsePersonAddress": false,
      "ContactFax": "fugiat",
      "Kanafname": "doloremque",
      "Kanalname": "aut",
      "Post1": "exercitationem",
      "Post2": "deserunt",
      "Post3": "iste",
      "EmailName": "brielle.white@purdy.biz",
      "ContactFullName": "Miss Maximilian Jennyfer Halvorson",
      "ActiveErpLinks": 905,
      "TicketPriorityId": 39,
      "SupportLanguageId": 507,
      "SupportAssociateId": 525,
      "CategoryName": "VIP Customer",
      "TableRight": null,
      "FieldProperties": {
        "fieldName": {
          "FieldRight": null,
          "FieldType": "System.Int32",
          "FieldLength": 298
        }
      }
    }
  ],
  "NoMailing": true,
  "Kananame": "dolore",
  "Xstop": false,
  "ActiveInterests": 244,
  "GroupId": 673,
  "ActiveStatusMonitorId": 857,
  "SupportAssociate": null,
  "TicketPriority": null,
  "CustomerLanguage": null,
  "Deleted": 250,
  "DbiAgentId": 72,
  "DbiLastSyncronized": "2002-05-10T17:37:17.2212416+02:00",
  "DbiKey": "voluptatem",
  "DbiLastModified": "2000-08-27T17:37:17.2212416+02:00",
  "SupportPerson": null,
  "Address": null,
  "Source": 230,
  "ActiveErpLinks": 531,
  "BounceEmails": [
    "leopold@bernhard.info",
    "kennedi_carroll@rohancummings.co.uk"
  ],
  "Domains": [
    "commodi",
    "itaque"
  ],
  "UserDefinedFields": {
    "SuperOffice:1": "405426248",
    "SuperOffice:2": "2039185446"
  },
  "ExtraFields": {
    "ExtraFields1": "itaque",
    "ExtraFields2": "ut"
  },
  "CustomFields": {
    "CustomFields1": "qui",
    "CustomFields2": "sint"
  },
  "TableRight": null,
  "FieldProperties": {
    "fieldName": {
      "FieldRight": null,
      "FieldType": "System.Int32",
      "FieldLength": 867
    }
  }
}
```