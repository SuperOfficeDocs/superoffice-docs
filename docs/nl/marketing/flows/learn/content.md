---
uid: help-nl-flow-content
title: Flowinhoud
description: Flowinhoud
keywords: Marketing, flow, flowinhoud, inhoud
author: Bergfrid Dias, Trude Lien Smedbråten
date: 09.26.2025
version: 10.5
content_type: howto
category: marketing
topic: flows
license: marketingpremium
audience: person
audience_tooltip: SuperOffice Marketing
language: nl
---

# Flowinhoud

Flowinhoud zijn e-mails (en formulieren) die in een flow worden gebruikt.

Het maakt niet uit of u de inhoud eerst voorbereidt of na het ontwerpen van de flow. Ook, of verschillende gebruikers met inhoud en flowconfiguratie werken - of als dezelfde gebruiker alles voorbereidt - is aan u.

## Stappen

Om de voorbereide inhoud voor een specifieke flow te bekijken:

1. Ga naar **Marketing** > **Flows**.
1. Dubbelklik om een flow te selecteren.
1. Selecteer het tabblad **Inhoud flow**.

![Inhoud van Welkom e-mail flow -screenshot][img1]

## Nieuwe inhoud maken

### E-mail maken - als inhoud-editor

1. Op het tabblad **Inhoud flow**, in de linkerbenedenhoek, voer een naam in voor de nieuwe e-mail en klik op **maken**. Dit opent de Mailing wizard bij de stap **Sjabloon**.

    ![Flowinhoud - nieuwe e-mail maken -screenshot][img3]

1. Kies een sjabloon en klik op **Volgende**.

    ![Flowinhoud - sjabloon kiezen -screenshot][img4]

1. Stel de e-mail samen (zoals u een klassieke mailing zou doen).

    ![Flowinhoud - samenstellen -screenshot][img5]

    * [Inhoud toevoegen][3], [Een alinea bewerken][4]
    * [Klantspecifieke informatie invoegen][5]
    * [Gevolgde link invoegen][6]
    * [Abonnementslinks toevoegen][8] om GDPR-compliant te zijn
    * [Afbeeldingen aan het bericht toevoegen][2]

    > [!NOTE]
    > Als u wilt handelen op basis van linkklikken (bijv. als trigger, splitsing of wachtconditie), moet de link worden gevolgd.

1. Sluit de e-mailstap en klik op **Opslaan**.

### E-mail maken - als flow-administrator

1. Open de Flow-editor en ga naar de e-mailstap.

    ![Flowstap - nieuwe e-mail maken -screenshot][img6]

1. Kies een sjabloon en stel de e-mail samen zoals hierboven beschreven (beginnend bij stap 2).

> [!NOTE]
> U kunt niet op **Bewerken** klikken als de flow wordt uitgevoerd. Als u de flow niet wilt pauzeren terwijl u meer inhoud voorbereidt, kunt u een nieuw stuk inhoud maken en voorbereiden vanuit het tabblad **Inhoud flow**.

### Formulier maken

Ga naar **Marketing** > **Formulieren**. Voor details, zie [Formulier maken][1].

## Flowinhoud toevoegen aan e-mailstap

1. Open de Flow-editor.
1. Klik om de e-mailstap te selecteren waar u inhoud wilt toevoegen.
1. Kies **Selecteer bestaande e-mail voor deze stap**. Klik om een voorbereide e-mail te selecteren.
1. Selecteer desgewenst **Taak** > **Bewerken** in de e-mailvoorbeeld om de inhoud bij te werken.
1. Sluit de e-mailstap en klik op **Opslaan**.

![E-mailstap verzenden met inhoud, onderwerp en bijlage -screenshot][img2]

## Voorbereide inhoud bewerken

> [!NOTE]
> U kunt de flowinhoud die in een stap is opgenomen niet bewerken zonder de flow te pauzeren.

**Als een inhoud-editor:**

1. Klik op het tabblad **Inhoud flow** op de menuknop bij de e-mail die u wilt bijwerken en selecteer **Bewerken**.

**Als een flow-administrator:**

1. Open de Flow-editor en ga naar de e-mailstap.
1. In de e-mailvoorbeeld:
    * Selecteer **Taak** > **Bewerken** om de inhoud bij te werken.
    * Selecteer **Taak** > **Nieuwe naam geven** om de naam van de e-mail te wijzigen.
    * Klik op de rode X om de e-mail te verwijderen (zodat je deze kunt vervangen door een andere).

<!-- Referenced links -->
[1]: ../../forms/learn/create.md
[2]: ../../editor/learn/insert-images-in-message.md
[3]: ../../editor/learn/add-content.md
[4]: ../../editor/learn/edit-paragraph.md
[5]: ../../editor/learn/add-merge-tag.md
[6]: ../../editor/learn/add-tracked-link-to-msg.md
[8]: ../../editor/learn/add-unsubscribe-link.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/view-flow-contents.png
[img2]: ../../../../media/loc/en/marketing/send-email-welcome-with-attachment.png
[img3]: ../../../../media/loc/en/marketing/create-new-email-in-flow.png
[img4]: ../../../../media/loc/en/marketing/choose-flow-email-template.png
[img5]: ../../../../media/loc/en/marketing/flow-email-content-compose.png
[img6]: ../../../../media/loc/en/marketing/flow-send-email-new.png
