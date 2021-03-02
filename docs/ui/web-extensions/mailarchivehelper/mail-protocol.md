---
title: mailprotocol_helper
description: MailProtocol helper
author: Tony Yates
so.date: 06.24.2016
keywords: somail
so.topic: concept
so.client: web
so.envir: onsite
---

# MailProtocol helper

The MailProtocol is installed to handle the somail:xxx links that the SIX.web server generates.

Normally SIX.web will handle a click on an email link by opening a web-based mail editor. When the tray-app and local mail client extensions are installed, then SIX.web will generate a link using the custom SOMAIL protocol.

![diagram][img1]

1. SuperOffice writes the mail address and info to a temp file.
2. SuperOffice generates a redirect to an somail: link with the name of the temp file.
3. The browser launches the locally installed somail protocol handler, which is usually `SuperOffice.Mail.ProtocolHandler.exe`.
4. The protocol handler calls either *SOCRM.exe* or the SuperOffice web service depending on the local settings.
5. The protocol handler requests the temp file from the SuperOffice server.
6. The protocol parses the temp file contents returned from the server and performs the appropriate actions. For example, opening a new mail window with the recipient's email address already filled in.

## Example

Your mail protocol handler needs to do the following to turn the mysterious ID *mailtask* into useful XML:

```csharp
XmlDocument task = new XmlDocument();
task.LoadXml(mailArchiveHelper.GetMailTaskInfo(id));
```

`mailArchiveHelper` will call the SuperOffice web service with the *mailtask* ID. If connected, the `GetMailTaskInfo()` call will do nothing. The web service will return an XML document that looks like this:

```XML
<superoffice>
 <mails>
  <mail action="new">
    <to>
      <address>myaddress@somewhere.no
      <name>My Name
    </to>
 </mails>
</superoffice>
```

Your custom mail protocol handler needs to extract the mail address from this XML document and do the right thing. In this case, create a new email message and set the recipient's address and name.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/mail-protocol-sequence-diagram.png
