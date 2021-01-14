---
title: NSSalesActivity RequestForInfo(Integer associateIdForNewContact, String channel, String regarding, String contactName, String personFirstname, String personLastname, String emailAddress, String phoneNumber)
path: /EJScript/Classes/NSAppointmentAgent/Member functions/NSSalesActivity RequestForInfo(Integer p_0, String p_1, String p_2, String p_3, String p_4, String p_5, String p_6, String p_7)
intellisense: 1
classref: 1
sortOrder: 896
keywords: RequestForInfo(Integer,String,String,String,String,String,String,String)
---


Submits a request for information. The request is added to the task list of the user that is responsible for this contact. Based on wether the person the request is made for is found or not, the following happens: If the person is found, the person, person's contact and sales representative is returned. If neither the person nor the contact is found a new person and contact is created (if sufficient data is supplied), and the person, person's contact and sales representative is returned. If the contact and not the person is found a new person is created on this contact, and the contact, salesrep, and person is returned (if there was enough data to return the person). If more than one contact is found a list of contacts is returned.



* **associateIdForNewContact:** Associate id of the person set as "Our Contact" if a new Contact is created. Ensures that the request is assigned to the correct salesman.
* **channel:** The requested channel, e.g. "Phone"
* **regarding:** The text submitted by the user.
* **contactName:** The name of the contact that the RFI will be added to. May be empty.
* **personFirstname:** The firstname of the person that the RFI will be added to. May be empty.
* **personLastname:** The lastname of the person that the RFI will be added to. May be empty.
* **emailAddress:** The email address of the person that the RFI will be added to.
* **phoneNumber:** Phone number of the contact or contact's person.
* **Returns:** True if the submission was successful.


