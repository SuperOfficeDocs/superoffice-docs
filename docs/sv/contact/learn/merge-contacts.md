---
uid: help-sv-contact-merge
title: Slå ihop kontakter
description: Lär dig hur du slår ihop dubbletter av kontakter i SuperOffice CRM för att samla aktiviteter, försäljningar och projektmedlemskap.
keywords: slå ihop kontakter, underhåll kontakter, kontakt, person
author: Bergfrid Dias
date: 02.25.2025
version: 10.5.2
content_type: howto
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Slå ihop kontakter

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Om samma person är registrerad under olika namn eller företag i SuperOffice CRM (t.ex. "Jonathan Clark" och "Jonathon Clarke") kan du slå ihop deras kontaktposter för att samla aktiviteter, försäljningar och projektmedlemskap.

> [!NOTE]
> Du kan inte slå ihop kontakter (SuperOffice-användare) på ditt eget företag. Däremot kan du slå ihop en kontakt från ett annat företag med en kontakt i ditt eget företag.

## Steg

1. Öppna dialogrutan **Slå ihop kontakter**:

    * I fönstret **Kontakt**: Gå till den kontakt du vill slå ihop, klicka på knappen **Uppgift** (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>), och välj **Underhåll kontakter** > **Slå ihop kontakter**.

    * I fönstret **Företag**: Gå till detaljkortet **Kontakter**, markera en eller två kontakter, högerklicka och välj **Underhåll kontakter** > **Slå ihop kontakter**.

1. Om du bara har valt en kontakt, välj en andra kontakt under **Till**. Börja skriva för att söka efter kontakten.
    Om du vill byta plats på **Från**- och **Till**-kontakter, klicka på pilknappen <i class="ph ph-arrows-left-right" aria-hidden="true"></i>.

1. Under **Utför på \[kontakt\] efter sammanslagning**, välj ett av följande alternativ:

    * **Ta bort \[källkontakt\]**: Tar bort källkontakten efter sammanslagningen (användbart för dubbletter).
    * **Markera som tidigare anställd**: Markerar källkontakten som tidigare anställd (användbart när kontakten har bytt jobb).

1. Under **Åtgärd för alla befintliga aktiviteter och försäljningar**, välj ett alternativ:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

1. Klicka på **Slå ihop**. Följande sker:

    * Alla uppgifter slås ihop.
    * Aktiviteter och försäljningar förblir kopplade till målpersonen, eller flyttas beroende på ditt val.
    * Projektmedlemskap och medlemskap i statiska urval följer målpersonen.
    * Den valda åtgärden (ta bort eller markera som tidigare anställd) tillämpas på källkontakten.

![Dialogrutan Slå ihop kontakter visar alternativ för att hantera dubbletter av kontakter och välja åtgärder efter sammanslagning. -screenshot][img4]

## Relaterat innehåll

* [Slå ihop företag][1]
* [Återskapa borttagna företag och kontakter][2]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md
[2]: ../../learn/basics/deleting-elements.md#restore

<!-- Referenced images -->
[img4]: ../../../media/loc/en/contact/merge-contacts.png
