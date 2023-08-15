# How do I configure what information the users of our company can access in SuperOffice CRM?

How and where in SuperOffice CRM can I configure access rights for our users?

SuperOffice CRM uses a role- and group- based access right system. It means that every SuperOffice user has a role and belongs to a primary group- , these are mandatory settings. 

A role has a set of data and functional rights, and a group setting grants access to data objects, various SuperOffice lists and helps to set system preferences more efficiently. A user can also belong to other group. This is relevant when you are configuring access to data objects in SuperOffice CRM. 

Image 1 shows a model of how the access right system works in SuperOffice CRM. This model has references (1, 2, 3 ...) to various access right settings which are illustrated with screenshots and explained later in the article. 

![Access right system example][img1]

*Image 1*

A user must have one role, which controls access rights to data objects and functions in SuperOffice CRM. The system allows you to configure access to companies, contacts, projects, project members, selections, sales, stakeholders (of sales), [follow-ups (appointments, tasks, phone calls)](https://help.superoffice.com/Documentation/Help/EN/CRM/10.0/UserHelp/index.htm#t=StandardCRM%2Fchap06%2Factivities_list.htm&rhsearch=add%20activity), documents (documents, e-mails, and mailings fall under this category), relations (contact and company) and dashboards. All these different types of records are called data objects. 

Each data object belongs to a user who might be you yourself (a), users in your primary group (b), users that belong to your other groups (c), other associates to whom you are not connected by any of your groups (d), [external users](https://help.superoffice.com/Documentation/Help/EN/CRM/10.0/UserHelp/index.htm#t=StandardCRM%2Fchap03%2Fmanaging_external_users.htm&rhsearch=external%20users&rhhlterm=external%20users&rhsyns=%20) (e), and [anonymous users](https://help.superoffice.com/Documentation/Help/EN/CRM/10.0/WebHelpAdmin/index.htm#t=Rolle%2FEdit_rights_for_anonymous_users.htm&rhsearch=anonymous%20users&rhhlterm=anonymous%20users&rhsyns=%20) (f).

![User access rights][img2]

*Screenshot1*

The ownership of different data objects is set in different fields. For example, in the Company card the field called “Our Contact” specifies the owner of the record. In the Follow-up card it is the field “Owner”, in the project “Responsible”, etc.

You can set different access rights for each data object. 


Name   | Rights
-------|-----
None   | No Rights
Read   | Read Rights
Create | Read, and Create Rights
Update | Read, Create, and Update  Rights
Delete | Read, create, update and delete rights

For example, in the Settings & Maintenance module, you selected a Role **User level 1** (a) and set **Delete**   (b) right to a company data object under the primary group column. This configuration means that any user who has User level 1 role will be able to read, create, update and delete all the companies that belong to other users who are members of his/her primary group. 

![User level 0][img3]

*Screenshot 2*

**A role** also has a set of functional rights (3). By moving the functional right from one column to another, you can control , what a user can and cannot do in the system. [This FAQ](https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113494) explains what each of the functional rights stands for.

![Functional Rights][img4]

*Screenshot 3*

**A group**, which is assigned to the user, grants access to data objects (4 - screenshot 1).  A user must have one primary group and can have multiple other groups. Let's take a look at example of the image 2. User A has Marketing as the other group and User B has Marketing as the primary group. In this case, if User A wants to see data created by User B, User's A Role has to have the right "Read" next to all data objects in the column Other group. It is because Marketing group is other group for user A and it is connecting him with records that user B creates. 

![Groups][img5]

*Image 2*

A group also can grant access to list items (among which document templates (5)) in SuperOffice CRM. This is only relevant if you use the **Grouping and filtering** setting (a) on your lists. If this setting is not set up, all users will have access to all lists in SuperOffice CRM. Grouping and filtering are especially useful when many users with various responsibilities can access the system. This way you can avoid certain users accessing the information that they are not supposed to see.

![Lists][img6]

*Screenshot 4*

For example, if you want to make a particular list item visible only to some users, you need to go to the list, which stores these items (a), select the item (b) and in the box called "Visible for user groups", add a check next to the user groups which should see the list item (c).

![Follow-up type][img7]

*Screenshot 5*

Having your users organized in groups is also convenient when you want to personalize SuperOffice settings, we call them preferences (6). Every preference, which can be found in the [Settings & Maintenance](https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=10106) module can be set for one user, user group or the entire system.

![Sales][img8]

*Screenshot 6*

The settings which are explained in this FAQ will help you customize your user's experience and control access to the information you store in SuperOffice CRM.

### More information:

TechDoc: [User accounts and role-based access control](https://docs.superoffice.com/online/identity/user/index.html)

FAQ: [How do I create a new User Group in SuperOffice CRM?](https://cs.superoffice.com/scripts/customer.fcgi?_sf=0&custSessionKey=&customerLang=en&noCookies=true&action=viewKbEntry&id=113402)




[img1]:media/access-right-system.png
[img2]:media/user-access-level.png
[img3]:media/user-access-level-2.png
[img4]:media/functional-rights.png
[img5]:media/groups.png
[img6]:media/lists-grouping.png
[img7]:media/follow-up-type.png
[img8]:media/sales-group.png