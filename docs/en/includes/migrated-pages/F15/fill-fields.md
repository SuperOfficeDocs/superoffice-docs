# How do I fill in the “Legal base”, “Consent source” and "Purpose" fields to many contacts in SuperOffice CRM all at once?

All the contact information that we store in our SuperOffice database is relevant and collected in accordance with the GDPR rules and our own business regulations. Thus I want to update the Legal basis, Consent source, and Purpose fields for our contacts in SuperOffice CRM all at once. How do I do it?

If you import or store a lot of data in your SuperOffice CRM, you can use the bulk update feature to help you get this data GDPR-ready. Please follow the steps below to fill in the privacy data for many contacts at once:

1. Click on the **Find** (1) button and in the Find screen click on **Find Contact** (2) to start your search.

    ![Find fields][img1]

1. In the Criteria tab chose the field that you want to use for identifying the contacts that need to get updated. In this example let's find all contacts that were registered today. To do this, select the field **Registered date** (1) and choose **Today** (2). When you are happy with your search setup click on **Find** (3) to get a list of these contacts.

    ![Find contacts][img2]

1. Click on the **Save as selection** (1) button at the bottom of the list, then click on the option **Dynamic (or Static) selection** (2) and click **Save** (3).

    ![Dynamic selection][img3]

1. Fill in the name (1) of the selection, choose a **Category** (2) from the drop-down list and click **Save** (3).

    ![Category][img4]

1. At the bottom of the screen, click on the **Task** (1) button and then choose **Bulk update** (2) in the Manage section. 

    ![Bulk Update][img5]

1. Click on the **Contact tab** (1) and click **+Add** (2) to include a new field. Then from the drop-down select the **Legal Basis** (3) choose an action **Add/Update** (4). Click there where it says **Click here to add legal base for purpose** and set up preferred values in the fields (5) then click on the **Update** (6) button to initiate the change. 

    ![Bulk Update][img6]


1. Click Yes to make the update.

    ![Legal basis][img7]

> [!NOTE]
> Bulk Update cannot be undone. That's why we recommend creating a database backup before making any large data updates. If your SuperOffice CRM is installed onsite, please refer to [this FAQ](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=111362) that explains how to do it. If you use SuperOffice Online, you do not have to do anything extra, as backups are created automatically.  

---
Please follow [this FAQ](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113497) if you use SuperOffice Onsite 8.5 R10 or any earlier version.
---

[img1]:media/find-fields.png
[img2]:media/find-contact.png
[img3]:media/dynamic-selection.png
[img4]:media/category-save.png
[img5]:media/bulk-update.png
[img6]:media/legal-basis.png
[img7]:media/yes.png