---
title: Creating the secret using Java
uid: create_secret_java
description: Creating the secret using Java
author: {github-id}
so.date:
keywords:
so-topic: howto
---

# Creating the secret using Java

Once the [web service client has been added][1], the next step is to create the secret for SuperOffice using Java.

[!code-java[Get secret](includes/get-secret.java)]

In the above code segment, the `getDate` method is used to get the date difference between the current date and a given date. The ? getSecret` method is used to retrieve the Base64Code.

> [!NOTE]
> The **GregorianCalender** used in `getDate()` is a concrete subclass of the `Calendar` class, which is provided in the `java.util` package, which provides the standard calendar used in most parts of the world.

The `base64Code` method uses the `BASE64Encoder` class which implements the BASE64 character encoder as specified in RFC1521. The `BASE64Encoder` class extends from the `java.lang.Object package`.

**Next:** [Connect to the web service using the Java secret][2]

<!-- Referenced links -->
[1]: create-ws-client-netbeans.md
[2]: auth-java.md
