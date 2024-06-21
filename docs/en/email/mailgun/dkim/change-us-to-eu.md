---
title: Change DKIM from the US to the EU
uid: change_dkim_us_to_eu
description: How to change DKIM from US to EU
author: {github-id}
keywords: email
topic: howto
---

# How to change DKIM from the US to the EU

In 2020 the European Court of Justice made a ruling that says the EU-US Privacy Shield (the agreement between the EU and the US that should ensure the safe transfer of personal data from the EU to the US), is now illegal. This is now known as the Schrems II ruling.

The SuperOffice CRM mailing feature is using an American cloud service provider; Mailgun Inc. for distributing mass emails and for email correspondence related to customer service tickets. This service has been protected by the Privacy Shield agreement, which no longer is valid.

Mailgun Inc. however also provides a data center located in the EU and we have moved all our customers to this location. This has been done as automatically as possible and without any cost on your part. By doing this, the SuperOffice CRM Online solution is fully GDPR compliant and satisfies all requirements for privacy data protection set out by this regulation.

If you need more information about the Schrems II ruling, we suggest you search your national Data Protection Authority website for additional information.

For those customers who have set up a DKIM towards Mailgun's data center located in the US, to be GDPR compliant you need to set up a new DKIM towards the data center located in the EU as soon as possible.

## What do have to do now?

Please plan and schedule for this change as soon as possible, and no later than the end of this year.

1. Remove current DKIM for Mailgun from your DNS

2. Notify SuperOffice you have removed the current DKIM (use this [form][1])
    * SuperOffice will:

        1. Delete the US DKIM key for your domain.
        1. Create a new EU DKIM key for your domain.
        1. Send you this new EU DKIM key.

3. Add new EU DKIM for Mailgun in your DNS

4. Notify SuperOffice new EU DKIM for Mailgun in your DNS is added (use this [form][1])
    * SuperOffice will:

        1. Configure the SMTP settings for your SuperOffice CRM Online solution to start to use the new EU DKIM for sending emails.
        1. Send you a confirmation email when new settings are in place.

More information on setting up DKIM in this [article][2].

<!-- Referenced links -->
[1]: https://community.superoffice.com/change-dkim/
[2]: order-key.md
