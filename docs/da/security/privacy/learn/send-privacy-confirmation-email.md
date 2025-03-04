---
uid: help-da-send-privacy-confirmation-email
title: Send e-mail med bekræftelse om personbeskyttelse
description: Send e-mail med bekræftelse om personbeskyttelse
author: SuperOffice RnD
date: 02.21.2023
keywords: GDPR, samtykke, e-mail, personbeskyttelse
topic: howto
language: da
---

# Send e-mail med bekræftelse om personbeskyttelse

I den nye GDPR-verden har enkeltpersoner "ret til at blive informeret". Det betyder, at de har ret til at få at vide enten på forhånd eller inden for 30 dage efter, at deres personoplysninger er blevet indsamlet. GDPR fastsætter, at enkeltpersoner har ret til at blive informeret om (a), at en organisation har til hensigt at gemme deres personoplysninger og (b) hvad organisationen har til hensigt at bruge deres oplysninger til.

## Indsaml deres samtykke på forhånd via formularer

Ved at bruge integrerede formularer, der er tilgængelige i din CRM-løsning, kan du indhente en persons samtykke, samtidig med at vedkommende udfylder en webformular og giver dig sine personoplysninger. Dette samtykke dokumenteres automatisk i SuperOffice CRM ved hjælp af funktionerne til samtykkehåndtering.

Denne video viser dig, hvordan du opretter en grundlæggende webformular og tilføjer den til din webside:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/18m6Dx1t9wI]

(videolængde – 7:49)

## Send automatiske e-mailbekræftelser

SuperOffice CRM gør det muligt for dig automatisk at sende en e-mail med bekræftelse om personbeskyttelse til personer, der er registreret i din database. E-mailen sendes automatisk til en person, når vedkommende først er registreret i SuperOffice, uden at du behøver at gøre noget.

Dette er ikke kun en høflig måde at følge op på din første kontakt med en kunde på, men det gør det også nemt for personen at fortælle dig, hvis personen har spørgsmål eller indvendinger mod, at du gemmer vedkommendes oplysninger.

Du kan konfigurere systemet til også at medtage et link, hvilket vil føre til en personlig abonnementsside. I dette link kan dine personer vælge, hvilken type kommunikation de vil modtage.

## Sådan sender du en e-mail med bekræftelse om personbeskyttelse igen

Fra skærmbilledet Person kan du sende eller gensende e-mailen med bekræftelse om personbeskyttelse til en person.

[!include[Go to Contact screen](../../../learn/includes/goto-contact.md)]

1. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> > **Send e-mail med bekræftelse om personbeskyttelse**.

    ![Send en bekræftelses-e-mail for at informere personerne om, at deres oplysninger gemmes i din CRM-database -screenshot][img2]

1. I dialogboksen, der åbnes, udfylder du følgende felter:
    * **Send til**: Brug standard-e-mailadresse, eller vælg en anden adresse.
    * **Brug skabelon**: Vælg en e-mailskabelon.
    * **Sprog**: Brug standardsproget, eller vælg et af de tilgængelige sprog.
    * **Emne**: Rediger eventuelt e-mailens standardoverskrift.

1. Klik på **Send**.

E-mail-bekræftelsen sendes til personen. E-mailmeddelelsen arkiveres i detaljekortet **Aktiviteter**.

## Hvad indeholder denne e-mail?

E-mailen med bekræftelsen om personbeskyttelse vil normalt informere personen om følgende:

* Oplysninger om personen er gemt i SuperOffice
* Hvilke oplysninger, der er gemt
* Hvad oplysningerne bruges til (formål)
* At personen til enhver tid kan tilbagekalde samtykket
* At oplysningerne er sikre og ikke bliver delt

E-mailen kan også indeholde et link til et kundecenter, hvor personen kan vedligeholde abonnementer og samtykke. Linket er som standard gyldigt i 21 dage.

## Relateret indhold

* [Rediger e-mailen med bekræftelse om personbeskyttelse i Indstillinger og vedligeholdelse][1]

<!-- Referenced links -->
[1]: edit-privacy-confirmation-email.md

<!-- Referenced images -->
[img2]: ../../../../media/loc/en/security/confirmation-email.png
