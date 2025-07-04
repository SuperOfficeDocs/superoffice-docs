---
title: Complete user account transition
uid: complete_user_transition
description: Complete user account transition from password to federated login
author: SuperOffice Product and Engineering
keywords:
content_type: tutorial
index: true
---

# Complete user account transition from password to federated login

After registering the IdP, each existing password user has to sign in once to complete the transition for their account.

The 1st time an existing password user tries to sign in after an [identity provider][1] has been registered for that domain, they have to complete a set of **transitional steps** from signing in with a password to signing in with the customer's IdP.

## Pre-requisites

* The user has signed in to SuperOffice account with a password

* [Username has been mapped][2]

* [Identity provider has been registered][3] for the domain

## First sign-in with Microsoft or Google

1. The user must **sign in with the old SuperOffice password** to prove their identity.

    ![Sign in -screenshot][img1]

    ![Use the old password -screenshot][img2]

2. The user is prompted to **sign in using the identity provider**.

    ![Sign in using identity provider -screenshot][img3]

3. The **user gives consent** to sign in with the identity provider and authenticates. Does the user's browser have an active session from the identity provider?

    * If no – the user must sign in to the selected IdP account
    * If yes – the user continues with the selected IdP account

    ![Sign in with Google -screenshot][img4]

4. The user is signed in and **redirected** to the SuperOffice CRM Online tenant.

**This completes the transition of the user account.**

<!-- Referenced links -->
[1]: ../../federated-id-and-identity-providers.md
[2]: map-idp-usernames.md
[3]: register-idp.md

[img1]: media/sign-in-old.png
[img2]: media/sign-in-old-password.png
[img3]: media/authenticate-identityprovider.png
[img4]: media/sign-in-idp.png
