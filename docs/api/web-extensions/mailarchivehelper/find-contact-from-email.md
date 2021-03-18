---
title: mailarchivehelper_find_contact
description: Find contact from email
author: Tony Yates
so.date: 06.24.2016
keywords: vb
so.topic: howto
so.client: web,win
so.envir: onsite
---

# Find contact from email

```vb
Public Function GetMailArchiveHelper() As MailArchiveHelper
  Dim helper As New MailArchiveHelper()
  helper.Initialize("SO5OUTL", "MSG", "SO5OUTL.CHM")
  Return helper
End Function

' This function called from a button handler in the mail client add-in
' e.g.: LookupPerson("Joe Smith", "joes@example.com")
Public Function LookupPerson(ByVal name As string, ByVal emailAddress As string) As Boolean
  If Len(emailAddress) > 0 Then
    Using archiveHelper As Object = GetMailArchiveHelper()
      Return archiveHelper.LookUpAddress(emailAddress, name, True)
    End Using
  Else
    MsgBox(GetResource(Resource.cNoAddressFound), vbOKOnly + vbMsgBoxSetForeground + vbInformation, GetResource(Resource.cDialogTitle))
    Return False
  End If
End Function
```

## Windows

On the Windows client, this will cause SOCRM to be launched if it's not already running, and the COM API is used to look up the email address and name.

* If a match is found, then the current person/contact are set to match it.
* If no match is found and the addUnknown parameter is True, then a new person is created and the person dialog shown with the email and name already filled in.

## Web

On the web client, this triggers a login to SuperOffice web using the most recently stored URL. The mail archive helper calls a web service API to do the email address lookup, and the result is returned - same as the Windows client.

<!-- See the LookUpAddress reference. -->
