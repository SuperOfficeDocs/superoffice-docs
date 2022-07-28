By default, all the columns with companies/contacts from the email application concerned (Outlook or Gmail) are linked to a SuperOffice field, but if you wish you can:

* click a column heading and edit the SuperOffice field into which the data in the column is to be imported
* click a column heading and select **(None selected)** if you do not wish to import the data in the column

1. Click **Configure import settings** and adjust the import settings as described in [Configure import settings][1].

2. In the **Consent comment** field, enter a comment about why you are registering these contacts in SuperOffice (purpose) and how/where you obtained their consent.

    The legal basis and consent source can be defined in **Import settings** (see [Configure import settings][1]). See also [Privacy][3].

3. Click **Next** when you have finished. The **Preview** window opens.

    What do the different icons in the table mean?

4. In **Preview** you can browse through the import data before the import begins.

    Many contacts are shown without an icon. Does this mean they will not be imported?

Rows without an icon will not be imported. If you can see that many contacts will not be imported, this may be because they have  not been linked to a company. Here, you can do one of the following:

* If the contact is actually linked to a company, you need to return to the import source (Gmail, Outlook or Excel) and specify a company for the person. Then start the import afresh.

* If the contact is not linked to a company, but is to be registered under his own name in SuperOffice, you must create the contact as a company. You do this as follows:

    1. Click **Previous** and **Configure import settings**.
    2. Click the **If company name is empty** list below **Contact**.
    3. Select **Create company using contact**.
    4. Click **Save**.
    5. Click **Next**, and check that the [New company icon][img1] icon is displayed next to the contact. The person will be registered as a company in SuperOffice CRM with himself or herself as the only contact.
    6. Remove the check marks for the rows you do NOT want to import.
    7. When you have verified that this actually is the data you want to import, click **Import**.

<!-- Referenced links -->
[1]: ../import-web/import-settings-web.md
[3]: ../privacy/index.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/import-preview-icon-company-new.bmp
