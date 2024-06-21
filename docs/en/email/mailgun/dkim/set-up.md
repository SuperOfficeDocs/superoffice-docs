---
uid: set-up-dkim
title: How to set up a DKIM Record
description: How to set up a DKIM Record, authorizing an email service to send emails on your behalf.
keywords: DKIM, email, Mailgun, public domain key, domain name, DNS console, host record
author: Martin Pavlas
date: 03.04.2024
version: 10.3
topic: howto
envir: cloud
client: online
---

# How to set up a DKIM Record

Before creating the DKIM record for your domain, identify the **server address** of the mail service that will be authorized to send emails on your behalf.

## Overview

1. Order the public domain key for your domain.
2. Add the key to your domain's DNS record so recipients can retrieve it for reading the DKIM header.
3. Tell SuperOffice that DKIM is set up - to turn on email signing to begin adding the DKIM header to outgoing mail messages.

[!include[ALT](../includes/envir-google.md)]

[!include[ALT](../includes/hosted-by-enom.md)]

Learn more about [DKIM on DNS][2].

## Order a DKIM for your domain name

To be able to create a DKIM for your domain name, we need to know your domain name.
To make sure no one else, besides your company orders a DKIM key for your domain name, we need to make sure you are the owner of this domain name.

1. Fill in the [DKIM ORDER FORM][1] and submit it.
2. We will reply with the DKIM to the submitted email address.
3. You will now need to add this DKIM to your DNS, see the next step.

[!include[Limitation](../includes/multiple-dkims.md )]

## Open the domain settings for the Google domain

[!include[ALT](../includes/open-google-domain-settings.md)]

## Add the DKIM record

1. Go to **Host Records** in the DNS console. The existing records for your Google account are there by default.

    ![DNS default -screenshot][img3]

2. Next, add the DKIM record from Mailgun:

    1. Click **Add New** to add the new DKIM record.

    1. Enter the **Host name** value you received from SuperOffice (`xxx._domainkey.[yourdomainName]`).

    1. Enter the **Address** value you received from SuperOffice (`k=rsa; p=XXX...`).

        > [!NOTE]
        > Some DNS servers may require **version of DKIM**. If you are sure your DNS needs it, add `v=DKIM1;` in front of the key. Example: `k=rsa; p=XXX...` becomes `v=DKIM1; k=rsa; p=XXX...`

    1. Choose *TXT* as the record type.

    ![Add TXT record -screenshot][img4]

3. You also need to establish an SPF record. This identifies the mail servers authorized to send (and/or can't send) emails on your domain's behalf. For DKIM usage, include `_spf.online.superoffice.com ~all` (or `include:mailgun.org ~all`) to enable email sending and receiving. Read [this article on how to update the spf record][8].

4. Click **Save** to update the information.

[!include[ALT](../includes/note-dns-propagation-time.md)]

## Test a new DKIM record

Use a tool to make sure the DKIM is propagated. Via CMD:

1. Open Windows Command Prompt: Press Win+R, type `CMD`, and click **OK**.

2. Type `nslookup` and press Enter.

3. Type `set type=txt` and press Enter.

4. Type: `xxx._domainkey.yourdomainName` and press Enter.

If your key is deployed successfully, it should return your key.

There are several tools available online for testing your DKIM record.

* [https://mxtoolbox.com/dkim.aspx#][5]
* [https://www.mail-tester.com/spf-dkim-check][6]

Here, we have used [MX Toolbox][7]. "DKIM Record Lookup"

1. Open the DKIM tool:

    ![MXtoolbox tool -screenshot][img1]

2. Add your domain name and the "DKIM Selector" you received from SuperOffice, and click **DKIM Lookup**.

3. The result should show the values of your public DKIM key data:

    ![Test DKIM record -screenshot][img2]

## Verify back to SuperOffice

Once the DKIM DNS record has been propagated and it tests OK, SuperOffice needs to be informed, so the new DKIM can be activated and used (signing your outgoing emails). Send your confirmation as a reply to the mail you received for the DKIM order. This activation may take a couple of days.

<!-- Referenced links -->
[1]: order-key.md
[2]: http://www.enom.com/kb/kb/kb_1042-dkim-on-dns.htm
[5]: https://mxtoolbox.com/dkim.aspx
[6]: https://www.mail-tester.com/spf-dkim-check
[7]: https://www.mxtoolbox.com/dkim.aspx
[8]: ../spf/set-up.md

<!-- Referenced images -->
[img1]: media/mxtoolsboxdkim.png
[img2]: media/mxtoolsboxdkimresult.png
[img3]: media/enomdkimedit.png
[img4]: media/enomdkimadd.png
