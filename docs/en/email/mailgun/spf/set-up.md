---
title: How to set up SPF Record
uid: set_up_spf
description: "How to set up an SPF Record."
author: {github-id}
date: 02.02.2022
keywords: SPF, email, DNS record, domain
topic: howto
envir: cloud
client: online
---

# How to set up SPF Record

Before creating the SPF record for your domain, it is important to find out what the server address for the mail service to be authorized (which is going to be permitted to send emails on your behalf).

[!include[ALT](../includes/envir-google.md)]

[!include[ALT](../includes/hosted-by-enom.md)]

**How to create DNS records for Microsoft 365 when you manage your DNS records:**

You can follow the [general instructions from Microsoft for creating DNS records for Microsoft 365][2].

## Open the domain settings for the Google domain

[!include[ALT](../includes/open-google-domain-settings.md)]

## Add the SPF record

1. Go to **Host Records** in the DNS console. The existing SPF record for your Google account is there by default.

    ![x -screenshot][img1]

2. We want to add `_spf.online.superoffice.com` which contains correct records for both Mailgun clusters (EU and US). Since there only should be one SPF record - we need to combine the existing one with the new one. The actual TXT record to add is `"v=spf1 include:_spf.online.superoffice.com ~all"`.

    1. Click **Edit.** Update the existing record (text field) with the new combined record.

         ![x -screenshot][img2]

    2. Click **Save** to update the information.

        ![x -screenshot][img3]

[!include[ALT](../includes/note-dns-propagation-time.md)]

## Test a new SPF record

There are several tools available online to test your SPF record. Here we use [MX Toolbox][1].

1. Open the [SPF tool][3].

2. Add your domain (the one that you are going to send our mailings as) and click **SPF Record Lookup**.

    ![x -screenshot][img5]

3. The result should show that `_spf.online.superoffice.com` is included and pass the test for *allow*.

### What’s the difference between ~all and -all?

Given many receivers are not actively bouncing mail based on SPF pass/fail, there isn’t a strong argument for either -all or ~all in SPF records. For a while, Hotmail was advising that senders who published a -all record would have better delivery. This led to -all became a de-facto standard for a lot of ESPs and bulk senders. More recently, there does not seem to be any benefit to publishing -all even at Hotmail (Outlook.com, live.com, and similar).

What should I publish?

We recommend "~all" (soft fail if no matches) vs "-all" (hard fail if no matches) as a conservative measure. A soft mail means that the message will be tagged with a header documenting the failure, but will still be accepted. If you prefer a hard failure, ie "-all", then feel free to use that instead. There’s not a huge benefit to publishing -all and sometimes mail gets forwarded around. The one time we recommend an -all record is when a domain is getting forged into spam. Domain forgery can cause a lot of bounces. The number of bounces can be bad enough to take down a mail server, particularly those with a small user base. Many ISPs will check SPF before sending back a bounce and so an `-all` record can decrease the amount of blowback the domain owner has to deal with.

<!-- Referenced links -->
[1]: https://mxtoolbox.com/
[2]: https://support.office.com/en-us/article/general-instructions-for-creating-dns-records-for-office-365-e21a9a4a-7b14-42cb-b39b-03aee92da95f
[3]: https://mxtoolbox.com/spf.aspx

<!-- Referenced images -->
[img1]: media/image.png
[img2]: media/2a906f41-12d9-450b-b38f-9c6b62ed18ec.png
[img3]: media/8e28749e-be90-498f-ad22-584bff9d37b5.png
[img5]: media/image7mle8.png
