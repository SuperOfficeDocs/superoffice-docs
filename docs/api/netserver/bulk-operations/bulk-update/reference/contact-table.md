---
title: Contact Table
uid: bulkupdate_contact_table
description: Bulk update Contact table
author: Tony Yates
so.date: 06.23.2017
keywords:
so.topic: reference
so.envir: cloud
so.client: online
---

# Contact Table

Contact fields. Key constants are in `BulkUpdateSystem.ContactFieldValueKeys`.

<table>
    <title>Contact</title>
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
                <p>Interests</p>
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
                <p>Interests</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>AssociateId</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) AssociateId</p>
            </td>
            <td>
                <p>Associate</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Business</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) BusinessIdx</p>
            </td>
            <td>
                <p>Business</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Category</p>
            </td>
            <td>
                <p>SelectOne</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (int) CategoryIdx</p>
            </td>
            <td>
                <p>Category</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>OrgNr</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (string) OrgNr</p>
            </td>
            <td>
                <p>OrgNr</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Number1</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Values Count = 1</p>
                <p>Values[0] = (string) Number1</p>
            </td>
            <td>
                <p>Number1</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Number2</p>
            </td>
            <td rowspan="17">
                <p>Set, Clear, SearchAndReplace, RegEx</p>
            </td>
            <td rowspan="17">
                <p>Values Count = 0 to 7</p>
                <p>Set: Values[0] = (string)</p>
                <p>Clear: Clears value</p>
                <p>SearchAndReplace:<br>Values[1] = searchString<br>Values[2] = replaceString<br>Values[3] = options</p>
                <p>RegEx:<br>Values[4] = expression<br>Values[5] = replace with<br>Values[6] = options</p>
            </td>
            <td>
                <p>Number2</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Name</p>
            </td>
            <td>
                <p>Name</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Department</p>
            </td>
            <td>
                <p>Department</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>StreetAddressAddress1</p>
            </td>
            <td>
                <p>StreetAddress.Address1</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>StreetAddressAddress2</p>
            </td>
            <td>
                <p>StreetAddress.Address2</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>StreetAddressAddress3</p>
            </td>
            <td>
                <p>StreetAddress.Address3</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>StreetAddressZipCode</p>
            </td>
            <td>
                <p>StreetAddress.Zipcode</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>StreetAddressZipCity</p>
            </td>
            <td>
                <p>StreetAddress.City</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>StreetAddressCounty</p>
            </td>
            <td>
                <p>StreetAddress.County</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>StreetAddressState</p>
            </td>
            <td>
                <p>StreetAddressState</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>PostalAddressAddress1</p>
            </td>
            <td>
                <p>PostalAddress.Address1</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>PostalAddressAddress2</p>
            </td>
            <td>
                <p>PostalAddress.Address2</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>PostalAddressAddress3</p>
            </td>
            <td>
                <p>PostalAddress.Address3</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>PostalAddressZipCode</p>
            </td>
            <td>
                <p>PostalAddress.Zipcode</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>PostalAddressZipCity</p>
            </td>
            <td>
                <p>PostalAddress.City</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>PostalAddressCounty</p>
            </td>
            <td>
                <p>PostalAddress.County</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>PostalAddressState</p>
            </td>
            <td>
                <p>PostalAddress.State</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Stopped</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td rowspan="2">
                <p>Values Count = 1</p>
                <p>Values[0] = (int) 0 or 1<br>0 = unChecked<br>1 = Checked</p>
                <p></p>
            </td>
            <td>
                <p>Xstop</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>ContactNoMail</p>
            </td>
            <td>
                <p>Set</p>
            </td>
            <td>
                <p>Nomailing</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>ContactCountry</p>
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
            <td rowspan="4">
                <p>Add, Remove, ReplaceWith, Clear, SearchAndReplace, RegEx</p>
                <p></p>
                <p></p>
                <p></p>
            </td>
            <td rowspan="4">
                <p>Values Count = 0 to 8</p>
                <p>Add: if value doesn&rsquo;t already exist</p>
                <p>Values[0] = (string) value<br>Values[1] = (string) descr</p>
                <p>Remove: only one needs to match</p>
                <p>Values[0] = (string) value<br>or...<br>Values[1] = (string) descr</p>
                <p>ReplaceWith:<br>locates row with Rank =1 and updates it, removes all others. Updates using:</p>
                <p>Values[0] = (string) value<br>Values[1] = (string) descr</p>
                <p>Clear: Clears all existing rows</p>
                <p>SearchAndReplace:<br>works on value only, not description.</p>
                <p>Values[2] = searchString<br>Values[3] = replaceString<br>Values[4] = Search Option</p>
                <p>RegEx:<br>works on value only, not description.</p>
                <p>Values[5] = expression<br>Values[6] = replace with<br>Values[7] = search options</p>
            </td>
            <td>
                <p>Urls</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Email</p>
            </td>
            <td>
                <p>Emails</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Phone</p>
            </td>
            <td>
                <p>Phones</p>
            </td>
        </tr>
        <tr>
            <td>
                <p>Fax</p>
            </td>
            <td>
                <p>Faxes</p>
            </td>
        </tr>
    </tbody>
</table>

See [User-Defined Fields][1].

<!-- Referenced links -->
[1]: user-defined-fields.md
