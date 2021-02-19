---
title: get_entity_java
description: Call service to get entity (Java)
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so-topic: howto
---

# Call service to get entity (Java)

Once we are [connected to the web service client][1] we can now retrieve a `Contact` entity and its properties as shown below.

```java
  //Create an instance of the Contact_Service Class
  Contact_Service newConSer = new Contact_Service();

  //Create an instance of the ContactSoap using the Contact_Service Class
  ContactSoap newConSoap = newConSer.getContactSoap();

  //Retrieves a Contact instance based on the Contact ID
  ContactEntity newConEnt = newConSoap.getContactEntity(4);

  //Retrieve properties of the Contact Entity
  String conName = newConEnt.getName();
  int conID = newConEnt.getContactId();
  String conDept = newConEnt.getDepartment();
```

The `ContactSoap` class is responsible for loading default values into the retrieved `ContactEntity`. Once this is done we can retrieve the properties of the entity.

## See also

* [Authentication and SOAP calls][2]

<!-- Referenced links -->
[1]: auth-java.md
[2]: ../../authentication/auth-and-soap-calls.md
