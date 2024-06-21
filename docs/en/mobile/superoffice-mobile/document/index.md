---
uid: mobile-crm-document
title: Documents
description: Learn about working with documents in SuperOffice Mobile CRM.
author: Bergfrid Dias
date: 08.07.2023
keywords: mobile, document, email, activity
topic: reference
version: 10
language: en
client: mobile
---

# Documents ![icon][img12]

You have access to all documents and emails stored in the database from Mobile CRM.

## Where can I find documents?

Documents are linked to a specific contact, company, sale, or project. In SuperOffice CRM, you therefor find each document in the **Activities** section tab of the entity it belongs to, rather than all documents in a central location.

Mobile CRM treats documents in the same way. In the app, the Company, Contact, Sale, and Project screens all have a **Documents** tab.

In lists, you will typically see date, type, and title for each document. The sort order is *sent - descending*.

> [!TIP]
> You can perform some actions on your documents and emails without opening them. Swipe left on the document or email to see the options.

## Document information ![icon][img12]

**Header:**

* Document title
* Contact/company (click to navigate)
* Date
* Document type

Icons in the action bar: Share, Email, Preview (contents), Details (properties)

## Email information ![icon][img13]

Saved emails also appear in the **Documents** tab.

**Header:**

* Date and time the email was sent
* Sender (click to navigate)
* Recipients

Icons in the action bar: Reply, Reply all, Forward,  Preview (contents), Details (properties)

## View document (or email) properties

1. Go to a company, contact, sale, project.

2. Select the **Documents** tab.

3. Tap to select the document or email you want to view.

    ![Mobile CRM Document -app-screen][img1]

4. Tap ![icon][img11] to switch to details if the preview opens.

    [!include[Configure visible fields](../includes/tip-visible-fields.md)]

## Preview email

1. Select a document as described above.
2. Tap ![icon][img10] to switch to preview if the details show.
3. A preview of the email opens automatically in Mobile CRM on both iOS and Android devices.

## Preview document

1. Select a document as described above.
2. Tap ![icon][img10] to switch to preview if the details show.
3. The next step is device-specific:

    * On **iOS** devices, documents are automatically opened for preview.

    * On **Android** devices, you will see "Unable to show the content of this document." Click on the download button (1) and select which app (2) on your device to open documents in.

    ![Mobile CRM, view document on Android -app-screen][img2]

## Download

If you are looking at a list of documents, you can swipe left and select **Download** to skip opening a preview on Android.

![Mobile CRM, Document actions -app-screen][img5]

## Related content

* [Create document][1]
* [Update document][2]
* [How to set up an email account][3]
* [How to send email or SMS][4]

<!-- Referenced links -->
[1]: create.md
[2]: update.md
[3]: ../getting-started/set-up-email.md
[4]: ../send-email-sms.md

<!-- Referenced images -->
[img1]: media/document-tab.png
[img2]: media/android-download-document.png
[img5]: media/task-menu-document.png
[img10]: ../../../../../common/icons/mobile/document-preview.png
[img11]: ../../../../../common/icons/mobile/details.png
[img12]: ../../../../../common/icons/mobile/documents.png
[img13]: ../../../../../common/icons/mobile/email-ikon.png
