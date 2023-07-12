---
uid: help-sv-contact-merge
title: Slå ihop kontakter
description: Slå ihop kontakter
author: SuperOffice RnD
so.date: 06.29.2022
keywords: företag
so.topic: howto
language: sv
---

# Slå ihop kontakter

[!include[Requirement](../../learn/includes/note-req-manage-entities.md)]

Om en fysisk person har registrerats som två olika kontakter i SuperOffice CRM kan du slå ihop dessa kontakter. Personen kan till exempel ha registrerats under två olika namn på samma företag ("Jonathan Clark" och "Jonathon Clarke") eller registrerats hos både sin gamla och sin nuvarande arbetsgivare.

Projektmedlemskap och aktiviteter flyttas till målpersonen och källpersonen kan tas bort eller anges som slutat.

1. Öppna dialogrutan **Slå ihop kontakter** på något av följande sätt:
    * I fönstret Företag: Gå till detaljkortet **Kontakter** markera och högerklicka på en eller två kontakter du vill slå ihop, välj **Underhåll kontakter** och **Slå ihop kontakter**.
    * I fönstret Kontakt: Gå till önskad kontakt, klicka på ![ikon][img1] knappen **Uppgift** på kontaktkortet och välj **Underhåll kontakter** och **Slå ihop kontakter**.

2. Om du bara har valt en kontakt väljer du ytterligare en kontakt under **Till** (börja skriva för att söka efter kontakten). De två kontakterna du vill slå ihop visas nu under **Från** och **Till**.

    > [!TIP]
    > Om du vill byta plats på **Från**\- och **Till**-kontakter klickar du på ![ikon][img2]-knappen.

3. Välj något av följande under **Utför på \[contact/company\] efter sammanslagning**:
    * **Ta bort...**: Om du väljer det här alternativet tas källkontakten bort efter sammanslagningen.
        Till exempel om du har registrerat samma kontakt två gånger på samma företag.
    * **Markera som tidigare anställd**: Om du väljer det här alternativet markeras kontakten som tidigare anställd efter sammanslagningen.
        Till exempel om en kontakt har bytt jobb, men fortfarande ska vara registrerad på det gamla företaget.

4. Välj något av följande under **Åtgärd för alla befintliga aktiviteter och försäljningar**:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

    [!include[Preview results](../../learn/includes/note-preview-results.md)]

5. Klicka på **Slå ihop**. Kontakterna slås ihop och projektmedlemskap och medlemskap i statiska urval flyttas.

> [!NOTE]
> Du kan inte slå ihop kontakter (SuperOffice-användare) på ditt eget företag, men du kan slå ihop en kontakt från ett annat företag med en kontakt från ditt eget företag.

## Relaterade ämnen

* [Slå ihop företag][1]

<!-- Referenced links -->
[1]: ../../company/learn/merge-companies.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-menu.png
[img2]: ../../../../common/icons/info-ball.png
