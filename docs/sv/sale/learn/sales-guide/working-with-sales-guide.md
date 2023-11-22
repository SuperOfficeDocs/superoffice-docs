---
uid: help-sv-working-with-sales-guide
title: Arbeta med säljguide
description: Arbeta med säljguide
author: SuperOffice RnD
so.date: 02.16.2023
keywords: försäljning
so.topic: howto
language: sv
---

# Arbeta med säljguider

Säljguiden guidar dig genom de olika faserna i en fördefinierad försäljningsprocess, tillhandahåller automatiskt förslag och mallar för dokument som behöver skapas under tiden och informerar om händelseaktiviteter som måste utföras.

Om du inte redan har gjort det, kan du lära dig hur du konfigurerar en säljguide här. Du kan använda SuperOffice Sales Guide eller skapa en egen.

Titta på den här videon för att lära dig hur enkelt det är att använda säljguiden (videolängd - 1:24):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IyETjAtn3po]

## Beteende när en försäljning har en guide

* Den första fasen i säljguiden är markerad i fältet **Fas** på huvudkortet **Försäljning**.

* Händelser och/eller dokument för fasen finns angivna på detaljkortet **Säljguide**.

## Försäljningsprocessen

1. Klicka på knappen **Skapa** framför namnet på händelsen/dokumentet.

2. I dialogrutan som öppnas [skapar du händelsen][2] eller [dokumentet][3] som vanligt. Många av fälten är redan ifyllda, men du kan ändra informationen eller lägga till mer information.

3. När du är färdig med händelsen markerar du **Slutfört** i den aktuella dialogrutan eller i kryssrutan framför händelsenamnet på detaljkortet **Säljguide**. Dokument är som standard markerade som slutförda.

    > [!TIP]
    > För att skapa flera händelser av samma typ kan du högerklicka på händelsen och välja **Skapa en till**.

4. När alla händelser och dokument för en fas är slutförda, går du till nästa fas på huvudkortet **Försäljning**.

    > [!NOTE]
    > Om du vill kan du gå till nästa fas utan att skapa eller slutföra alla händelser/dokument i en fas.

5. Upprepa detta för alla händelser/dokument i alla faser i säljguiden.

## Så här avancerar du statusen

Du kan flytta projektet till nästa status på två olika sätt:

**Från säljguiden:**

1. Högerklicka på knappen för nästa status på detaljkortet **Säljguide** och välj **Gå till den här statusen**.

**Från fliken Försäljning:**

1. Klicka på **Ändra** på fliken **Försäljning**.
2. Klicka på pilen bredvid fältet **Fas**.
3. Välj önskad fas i listan som visas. Med undantag för statusen **Såld** och **Förlorad** definieras alternativen i listan i Inställningar och underhåll.
4. Klicka på **Spara**.

## Varför öppnas dialogrutan Säljguide när jag markerar en händelse som slutförd?

I Inställningar och underhåll kan du ange att en händelse i en säljguide ska föreslås automatiskt när föregående händelse markeras som slutförd. Då öppnas dialogrutan **Säljguide** när du markera föregående händelse som slutförd.

I dialogrutan **Säljguide** har du tre möjligheter:

* Klicka på **Skapa** för att skapa nästa händelse i säljguiden. Du kommer då direkt till dialogrutan för händelsen.

* Klicka på **Avbryt** om du inte vill skapa händelsen nu. Dialogrutan **Säljguide** stängs och du måste komma ihåg att skapa händelsen senare.

* Markera **Skapa alltid händelse? Visa inte den här dialogrutan igen** om du i framtiden alltid vill skapa den föreslagna händelsen. Då öppnas dialogrutan för händelser automatiskt nästa gång.

> [!TIP]
> För att återställa det här alternativet, så att dialogrutan **Säljguide** öppnas, gå till ![ikon][img1] **Personliga inställningar** > **Inställningar** > **Försäljning** och välj **Ja** för alternativet **Bekräfta skapande av föreslagen händelse**.

## Exempel

Tänk på att dina säljguider kan konfigureras på andra sätt i Inställningar och underhåll.

### Registrera en ny försäljning och välj försäljningstyp

Du registrerar en ny försäljning och väljer försäljningstypen **Försäljning till ny kund**, som är kopplad till en säljguide. Säljguiden kan till exempel ha följande faser, händelser och dokument:

| Fas | Uppföljningar | Dokument |
|---|---|---|
| Första mötet | Kundmöte (Möte ute) | Mötesbekräftelse (e-post) |
| Offert | Offertarbete (Uppgift) | Offert (Brev) |
| Kontraktsunderskrift | Boka kontraktsmöte (Telefon ut)<br /> Kontraktsmöte (Möte ute) | Undertecknat kontrakt |

### Fasen Första möte

1. Du har bokat in en mötestidpunkt och vill skapa händelsen **Kundmöte** i kalendern och bjuda in deltagare.

    1. I projektguiden klickar du på knappen **Skapa** bredvid händelsen **Kundmöte**.
        Dialogrutan **Händels** öppnas, med **Möte ute** angivet som typ och namnet på försäljningen och företaget redan ifyllt.
    2. Fyll i information och [bjud in deltagare][1].
    3. Klicka på **Spara**.

2. För ordningens skull vill du skicka ett e-postmeddelande där du bekräftar tidpunkt och plats för mötet.

    1. Klicka på knappen **Skapa** bredvid **Mötesbekräftelse**.
        Dialogrutan **Dokument** öppnas där **E-post** redan är valt som dokumenttyp och namnet på företaget och försäljningen redan är ifyllt.
    2. Fyll i övrig information i fälten i dialogrutan **Dokument**.
    3. Klicka på knappen **Skapa** för att skapa och skicka e-postmeddelandet.

3. Efter att mötet är genomfört, anger du detta i säljguiden.

    I säljguiden markerar du kryssrutan bredvid händelsen **Kundmöte**.

    > [!TIP]
    > Du kan också göra det från aktivitetslistan i till exempel Kalender och Företag.

### Fasen Offert

1. Alla händelser och dokument i fasen **Första möte** är slutförda och du vill gå till nästa fas i säljguiden.

    1. Klicka på **Redigera**-knappen på huvudkortet **Försäljning**.
    2. Klicka på pilen bredvid fältet **Fas** och välj **Offert** i listan.
    3. Klicka på **Spara**.
        Händelserna och dokumenten för den senaste statusen visas nu på detaljkortet **Säljguide**.

    > [!TIP]
    > Du kan också högerklicka på **Offert**-knappen på detaljkortet **Säljguide** och välja **Gå till denna fas**.

2. Du vill skapa en uppgift i din kalender som påminner dig om att du måste skapa en offert.

    1. Klicka på **Skapa** bredvid händelsen **Offertarbete**.
        Dialogrutan **Uppgift** visas med **Händelse** angivet som uppgiftstyp.
    2. Fyll i information.
    3. Klicka på **Spara**.
    4. Efter du har skapat innehållet i offerten ställer du in händelsen på **Slutförd**.

3. Nu vill du skapa offerten till företaget.

    Klicka på **Skapa** bredvid dokumentet **Offert** och [skapa dokumentet][3].

### Fasen Kontraktsunderskrift

1. När alla händelser och dokument som du vill använda i fasen **Offert** är slutförda går du till den sista fasen i säljguiden, som är **Kontraktsunderskrift**.

    1. Klicka på **Redigera**-knappen på huvudkortet **Försäljning**.
    2. Klicka på pilen till höger om fältet **Fas** och välj **Kontraktsunderskrift** i listan.
    3. Klicka på **Spara**.
        Händelserna och dokumenten för denna fas visas nu på detaljkortet **Säljguide**.

2. Du vill skapa och slutföra den första händelsen i fasen.

    1. Klicka på **Skapa** bredvid samtalet **Boka kontraktsmöte** och skapa samtalet på vanligt sätt.

    2. När du har slutfört telefonsamtalet, markerar du rutan.

    3. I dialogrutan **Säljguide** har du tre möjligheter:

        * Klicka på **Skapa** för att skapa händelsen **Kontraktsmöte**, som är nästa händelse i säljguiden. Du kommer då direkt till dialogrutan för händelsen.

        * Klicka på **Avbryt** om du inte vill skapa händelsen nu. Dialogrutan **Säljguide** stängs och du måste komma ihåg att skapa händelsen senare.

        * Markera **Skapa alltid händelse? Visa inte den här dialogrutan igen** om du i framtiden alltid vill skapa den föreslagna händelsen. Då öppnas dialogrutan för händelser automatiskt nästa gång.

    > [!NOTE]
    > Dialogrutan **Säljguide** öppnas eftersom funktionen **Föreslå denna händelse automatiskt** är angiven för händelsen **Kontraktsmöte** i Inställningar och underhåll. Du kan välja att den här dialogrutan inte ska visas så att nästa händelse föreslås automatiskt.

3. Du vill skapa händelsen **Kontraktsmöte** från dialogrutan **Säljguide**.

    Klicka på **Skapa** i dialogrutan **Säljguide**.
    Dialogrutan **Händels** öppnas, där du kan skapa mötet på vanligt sätt.

4. Sedan vill du skapa det kontrakt du ska ha med dig på mötet.

    1. Klicka på **Skapa** bredvid dokumentet **Undertecknat kontrakt** för att skapa kontraktet.
    2. Efter kontraktsmötet och kontraktet är undertecknat, markerar du händelsen **Kontraktsmöte** som slutförd.

Nu kan du ändra fasen till **Såld**. När alla önskade händelser och dokument för försäljningen är slutförda kan du ange att försäljningen är slutförd.

> [!TIP]
> Om du vill att försäljningen fortfarande ska vara synlig på till exempel detaljkortet **Aktiviteter** i fönstret Försäljning och detaljkortet **Försäljning** i fönstret Kalender ska du inte ange att försäljningen är slutförd.

## Relaterat

* [Konfigurera en säljguide i Inställningar och underhåll][4]

<!-- Referenced links -->
[1]: ../../../diary/learn/invitation/add-participant.md
[2]: ../../../diary/learn/create-follow-up.md
[3]: ../../../document/learn/edit.md
[4]: create.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/personal-settings-small.png
