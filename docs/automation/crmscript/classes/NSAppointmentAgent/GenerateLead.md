---
title: NSSalesActivity GenerateLead(Integer associateIdForNewContact, String leadDescription, String relation, Integer relationId, String leadContact, String leadPersonFirstname, String leadPersonLastname, String leadPersonEmail, String leadPhoneNumber, String creatorsContact, String creatorsFirstname, String creatorsLastname)
path: /EJScript/Classes/NSAppointmentAgent/Member functions/NSSalesActivity GenerateLead(Integer p_0, String p_1, String p_2, Integer p_3, String p_4, String p_5, String p_6, String p_7, String p_8, String p_9, String p_10, String p_11)
intellisense: 1
classref: 1
sortOrder: 895
keywords: GenerateLead(Integer,String,String,Integer,String,String,String,String,String,String,String,String)
---


Adds a sales lead (task) to a contact in SuperOffice. If the contact or person is known, the sales lead is added to the current contact. If not, a new contact is created, with the associate with ownerIdForNewContact as responsible (Our Contact). A relation is created between the contact and the person submitting the lead. Based on wether the person the request is made for is found or not, the following happens: If the person is found, the person, person's contact and sales representative is returned. If neither the person nor the contact is found a new person and contact is created (if sufficient data is supplied), and the person, person's contact and sales representative is returned. If the contact and not the person is found a new person is created on this contact, and the contact, salesrep, and person is returned (if there was enough data to return the person). If more than one contact is found a list of contacts is returned.



* **associateIdForNewContact:** Associate id of the person set as "Our Contact" if a new Contact is created. Ensures that the sales lead is assigned to the correct salesman.
* **leadDescription:** Description of the lead. The lead text as shown in SuperOffice
* **relation:** The relation the person submitting the lead has to the contact.
* **relationId:** Id of the relation type. Database specific.
* **leadContact:** Name of the new or existing contact (company) the lead is created for.
* **leadPersonFirstname:** Firstname of the contact's person.
* **leadPersonLastname:** Lastname of the contact's person.
* **leadPersonEmail:** Email to the contact's person.
* **leadPhoneNumber:** Phone number of the contact or contact's person.
* **creatorsContact:** The contact (company) of the person creating the lead
* **creatorsFirstname:** The firstname of the person creating the lead
* **creatorsLastname:** The lastname of the person creating the lead
* **Returns:** True if successfull.


