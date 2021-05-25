---
title: Person Table
uid: bulkupdate_person_table
description: Bulk update Person table
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: reference
so.envir: cloud
so.client: online
---

# Person Table

Person fields. Key constants are in ``BulkUpdateSystem.PersonFieldValueKeys`.

<table>
    <title>Person</title>
    <thead>
        <tr>
            <th>
                <p>FieldValueKeys</p>
            </th>
            <th>
                <p>OperationTypes</p>
            </th>
            <th>
                <p>Expected Field Values</p>
            </th>
            <th>
                <p>Affected Properties</p>
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <p>Position</p>
            </td>
            <td>
                <p>SelectOne, Clear</p>
            </td>
            <td>
                <p>Values Count = 0 or 1</p>
                <p>Values[0] = (int) PositionIdx</p>
            </td>
            <td>
                <p>Position</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Number</p>
            </td>
            <td rowspan="12">
                <p>Set, Clear, SearchAndReplace, RegEx</p>
            </td>
            <td rowspan="12">
                <p>Values Count = 0 to 7</p>
                <p>Set: Values[0] = (string)</p>
                <p>Clear: Clears value</p>
                <p>SearchAndReplace:<br>Values[1] = searchString<br>Values[2] = replaceString<br>Values[3] = options</p>
                <p>RegEx:<br>Values[4] = expression<br>Values[5] = replace with<br>Values[6] = options</p>
            </td>
            <td>
                <p>Number</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Title</p>
            </td>
            <td>
                <p>Title</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>MrMrs</p>
            </td>
            <td>
                <p>MrMrs</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Salutation</p>
            </td>
            <td>
                <p>Salutation</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>FirstName</p>
            </td>
            <td>
                <p>Firstname</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>MiddleName</p>
            </td>
            <td>
                <p>MiddleName</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>LastName</p>
            </td>
            <td>
                <p>Lastname</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>AddressAddress1</p>
            </td>
            <td>
                <p>Address.Address1</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>AddressAddress2</p>
            </td>
            <td>
                <p>Address.Address2</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>AddressAddress3</p>
            </td>
            <td>
                <p>Address.Address3</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>AddressZipCode</p>
            </td>
            <td>
                <p>Address.Zipcode</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>AddressZipCity</p>
            </td>
            <td>
                <p>Address.City</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>AddressCounty</p>
            </td>
            <td>
                <p>Address.County</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>AddressState</p>
            </td>
            <td>
                <p>Address.State</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>PersonNoMail</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) 0 or 1<br>0 = unChecked<br>1 = Checked</p>
            </td>
            <td>
                <p>Nomailing</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>AddInterests</p>
            </td>
            <td>
                <p>addItems</p>
            </td>
            <td>
                <p>Values Count = 1&hellip;n</p>
                <p>Values[n] = (int) InteresItemtId</p>
                <p>Selects each interest.</p>
            </td>
            <td>
                <p>InterestHelper</p>
                <p>ActiveInterests</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>RemoveInterest</p>
            </td>
            <td>
                <p>removeItems</p>
            </td>
            <td>
                <p>Values Count = 1&hellip;n</p>
                <p>Values[n] = (int) InteresItemtId</p>
                <p>Deselects each interest.</p>
            </td>
            <td>
                <p>InterestHelper</p>
                <p>ActiveInterests</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>AddSubscriptions</p>
            </td>
            <td>
                <p>addItems</p>
            </td>
            <td>
                <p>Values Count = 1&hellip;n</p>
                <p>Values[0] = (int) MailingTypeId</p>
                <p>Deletes a record in the MailingTypeReservation table.</p>
            </td>
            <td>
                <p>MailingTypeReservations</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>RemoveSubscriptions</p>
            </td>
            <td>removeItems</td>
            <td>
                <p>Values Count = 1...n</p>
                <p>Values[0] = (int) MailingTypeId</p>
                <p>Adds a record to the MailingTypeReservation table.</p>
            </td>
            <td>MailingTypeReservations</td>
        </tr>
        <tr>
            <td>
                <p>LegalBasis</p>
            </td>
            <td>Add, Remove</td>
            <td>
                <p>Values Count = 0 to 5</p>
                <p>Add: <br>if value doesn&rsquo;t already exist<br>Values[0] = (int)
                    consentPurposeId<br>Values[1] = (int) legalBaseId</p>
                <p>Optional:</p>
                <p>Values[2] = (int) consentSourceId<br>Values[3] = (string) comment</p>
                <p>Remove:</p>
                <p>Clears all existing rows</p>
                <p>Values[0] = *not used<br>Values[1] = *not used<br>Values[2] = *not used<br>Values[3] = *not
                    used<br>Values[4] = (int) consentPurposeId</p>
            </td>
            <td>ConsentPersons</td>
        </tr>
        <tr>
            <td>
                <p>UseAsMailingAddress</p>
            </td>
            <td>
                <p>Check, Toggle</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Check:<br>Values[0] = (int)<br>0 = Use company address<br>1 = Use person address</p>
                <p>Toggle: invert current</p>
            </td>
            <td>
                <p>Usepersonaddress</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Retired</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int)<br>0 = not retired<br>1 = retired</p>
            </td>
            <td>
                <p>Retired</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>BirthDate</p>
            </td>
            <td>
                <p>Set, Clear</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Set:<br>Values[0] = (Date) <br>Format: InvariantInfo</p>
                <p>Clear: <br>Day = 0, Month = 0, &nbsp;Year = 0</p>
            </td>
            <td>
                <p>DayOfBirth</p>
                <p>MonthOfBirth</p>
                <p>YearOfBirth</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>PersonCountry</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) CountryId</p>
            </td>
            <td>
                <p>Country</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Url</p>
            </td>
            <td rowspan="7">
                <p>Add, Remove, ReplaceWith, Clear, SearchAndReplace, RegEx</p>
            </td>
            <td rowspan="7">
                <p>Values Count = 0 to 8</p>
                <p>Add: <br>if value doesn&rsquo;t already exist<br>Values[0] = (string) value<br>Values[1] = (string)
                    description</p>
                <p>Remove: <br>only one needs to match<br>Values[0] = (string) value, <br>or...<br>Values[1] = (string)
                    description</p>
                <p>ReplaceWith:<br>locates row with Rank =1 and updates it, removes all others. Updates
                    using:<br>Values[0] = (string) value<br>Values[1] = (string) description</p>
                <p>Clear: <br>Clears all existing rows</p>
                <p>SearchAndReplace:<br>works on value only, not description.<br>Values[2] = searchString<br>Values[3] =
                    replaceString<br>Values[4] = Search Options</p>
                <p>RegEx:<br>works on value only, not description.<br>Values[5] = expression<br>Values[6] = replace
                    with<br>Values[7] = Search Options</p>
            </td>
            <td>
                <p>Urls</p>
                <p>value = UrlAddress</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Email</p>
            </td>
            <td>
                <p>Emails<br>value = EmailAddress</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>MobilePhone</p>
            </td>
            <td>
                <p>MobilePhones</p>
                <p>value = Phone</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>DirectPhone</p>
            </td>
            <td>
                <p>OfficePhones</p>
                <p>value = Phone</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>PrivatePhone</p>
            </td>
            <td>
                <p>PrivatePhones</p>
                <p>value = Phone</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>OtherPhone</p>
            </td>
            <td>
                <p>Pagers</p>
                <p>value = Phone</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>DirectFax</p>
            </td>
            <td>
                <p>Faxes</p>
                <p>value = Phone</p>
            </td>
        </tr>
    </tbody>
</table>

See [User-Defined Fields][1].

<!-- Referenced links -->
[1]: user-defined-fields.md
