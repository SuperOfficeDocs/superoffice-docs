---
uid: help-sv-contact-move
title: Flytta en kontakt
description: Flytta en kontakt till ett annat företag.
keywords: flytta kontakt, underhåll kontakter, utför på kontakt, koppla från, kontakt
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Flytta en kontakt till ett annat företag

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Använd den här funktionen när en kontakt byter avdelning eller företag, eller om de har registrerats under fel företag. Alternativt kan du koppla bort en kontakt för att ta bort länken till ett företag utan att flytta dem.

> [!NOTE]
> Du kan inte flytta kontakter (SuperOffice-användare) på ditt eget företag.

## Steg

1. Öppna dialogrutan **Flytta kontakt**:

    * I fönstret **Kontakt**: Klicka på knappen **Uppgift** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) och välj **Underhåll kontakter** > **Flytta kontakt**.
    * I fönstret **Företag**: Gå till detaljkortet **Kontakter**, högerklicka på en kontakt och välj **Underhåll kontakter** > **Flytta kontakt**.

2. Under **Utför på kontakt**, välj ett av följande alternativ:

    * **Flytta till**: Ange eller välj det företag kontakten ska flyttas till.
    * **Koppla från**: Ta bort kontaktens länk till det aktuella företaget.

3. Under **Åtgärd för alla befintliga aktiviteter och försäljningar**, välj ett alternativ:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

4. Klicka på **Flytta**. Kontakten flyttas till det valda företaget eller kopplas bort, och aktiviteter uppdateras enligt ditt val.

![Dialogrutan Flytta kontakt med alternativ för att flytta eller koppla bort en kontakt och hantera befintliga aktiviteter och försäljningar. -screenshot][img1]

## Relaterat innehåll

* [Slå ihop kontakter][1]
* [Ta bort en kontakt][2]
* [Återskapa borttagna företag och kontakter][3]

<!-- Referenced links -->
[1]: merge-contacts.md
[2]: delete.md
[3]: ../../learn/basics/deleting-elements.md#restore

<!-- Referenced images -->
[img1]: ../../../media/loc/en/contact/move-contact.png
