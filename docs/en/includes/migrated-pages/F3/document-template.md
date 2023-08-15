# How do I upload and use document templates in SuperOffice CRM?

What is the way to upload a document template in SuperOffice CRM and use it when preparing documents for your customers? 

In SuperOffice CRM you can easily upload your personalized document templates and use them to prepare documents with automatically populated information easily. Please follow the steps below to do it:

[Step 1. Upload a document template in SuperOffice CRM](https://community.superoffice.com/en/support-faqs/faq/how-do-i-upload-and-use-document-templates-in-superoffice-crm/#1)

[Step 2. Use your document template](https://community.superoffice.com/en/support-faqs/faq/how-do-i-upload-and-use-document-templates-in-superoffice-crm/#2)

### Step 1. Upload a document template in SuperOffice CRM

Please follow the steps below:

1. Log in to [Settings and Maintenance](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=10106) in SuperOffice CRM.

1. Click on the **Lists** (1) button in the Navigator panel, then select **Document templates** (2) from the drop-down list and click on **+Add** (3).

    ![Document Templates][img1]

1. Give a **Name** (1) to your document, select where the document should be stored (2), and upload your document template file (3). Click **Save** (4) to finish.

    > [!NOTE]
    > If you work with SuperOffice Online, please store templates in Online storage. Please check this wish report for more information.

    ![Edit List Item][img2]

    > [!NOTE]
    > As a default all document templates are stored in the SO Arc folder, however if you use G Suite of Office 365 integration document can be stored in the cloud storage provided by the integration. Please check the following links for [Office 365](https://online.superoffice.com/appstore/superoffice-as/office-365-integration) or [G Suite](https://online.superoffice.com/appstore/superoffice-as/g-suite-integration) integrations and [this link](https://docs.superoffice.com/document/cloud/overview.html) for a technical overview.


1. Then select **Direction** (1), **Document type** (2), and **Intention** (3) of the document. If you are uploading a quote document template, select a tick next to **Quote document type** (4) and select the type of the document from the drop-down list. Please check [this FAQ](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113056) about the different Quote document template types.

    If you want that your documents to automatically get a reference you need to include the reference pattern in Our reference (5) field. One option is to use a template variable {oref}.

    ![Reference List Item][img3]

1. If you want to include other language versions of the same document template, click on the **Language** (1) tab, then click on **+Add** (2).

    ![Add languages][img4]

1. In the **Add language** field, choose the language of the document template and upload or copy an existing document template, click **Add** to finish.

    ![Deutch document Upload][img5]

1. Click **Save** and the document template is ready to use.

### Step 2. Use your document template

Please follow the steps below:

1. Click on the **+New** button in the top left corner of the screen and then click on **Document**. 

    ![New Document][img6]

1. Then choose the document template (1) you have created from the drop-down list, fill in the relevant fields with metadata of the document, and click on the **Create** (2) button.

    ![Create Document][img7]

1. If you use [SuperOffice Web Tools](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=112992), the new document will be opened in the program on your computer. If [Web Tools are not in use](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113661), the new document will be downloaded on your computer and you'll be able to open it by double-clincing on the document file. Be aware that changes made on the document won't be saved in SuperOffice. If you want that all changes would be saved in the document automatically we recommend installing [SuperOffice Web Tools](https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113747). 

---
Please follow [this FAQ](https://online2.superoffice.com/Cust1990/CS/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113183), if you use SuperOffice Onsite 8 or any previous version.

---

### More Information

Forum: [PDF form as a template, is it possible.](https://community.superoffice.com/en/technical/forums/product-forums/crm-windows-application/pdf-form-as-a-template-is-it-possible/)


[img1]:media/lists-add.png
[img2]:media/edit-list-item.png
[img3]:media/reference-item.png
[img4]:media/language-add.png
[img5]:media/deutch-document-upload.png
[img6]:media/new-document.png
[img7]:media/create-document.png