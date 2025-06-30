---
uid: help-sv-working-with-sales-guide
title: Exempel – säljguide
description: Arbeta med säljguider
keywords: säljguide, exempel
author: SuperOffice RnD
date: 02.25.2025
version: 10.5.2
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Exempel – säljguide

Tänk på att dina säljguider kan konfigureras på andra sätt i Inställningar och underhåll.

## Registrera en ny försäljning och välj försäljningstyp

Du registrerar en ny försäljning och väljer försäljningstypen **Försäljning till ny kund**, som är kopplad till en säljguide. Säljguiden kan till exempel innehålla följande faser, händelser och dokument:

| Fas | Uppföljningar | Dokument |
|---|---|---|
| Första mötet | Kundmöte (Möte ute) | Mötesbekräftelse (e-post) |
| Offert | Offertarbete (Uppgift) | Offert (Brev) |
| Kontraktsunderskrift | Boka kontraktsmöte (Telefon ut)<br /> Kontraktsmöte (Möte ute) | Undertecknat kontrakt |

## Fasen Första möte

1. Du har bokat in en mötestid och vill skapa händelsen **Kundmöte** i kalendern och bjuda in deltagare.

    1. I säljguiden klickar du på **Skapa** bredvid händelsen **Kundmöte**.
        Dialogrutan **Händelse** öppnas, med **Möte ute** angivet som typ och försäljningens och företagets namn redan ifyllda.
    2. Fyll i information och [bjud in deltagare][1].
    3. Klicka på **Spara**.

2. För ordningens skull vill du skicka ett e-postmeddelande där du bekräftar tid och plats för mötet.

    1. Klicka på **Skapa** bredvid **Mötesbekräftelse**.
        Dialogrutan **Dokument** öppnas där **E-post** redan är valt som dokumenttyp och företagets och försäljningens namn redan är ifyllda.
    2. Fyll i övrig information i fälten i dialogrutan **Dokument**.
    3. Klicka på **Skapa** för att skapa och skicka e-postmeddelandet.

3. Efter att mötet är genomfört, anger du detta i säljguiden.

    I säljguiden markerar du kryssrutan bredvid händelsen **Kundmöte**.

    > [!TIP]
    > Du kan också göra detta från aktivitetslistan i till exempel **Kalender** och **Företag**.

## Fasen Offert

1. Alla händelser och dokument i fasen **Första mötet** är slutförda och du vill gå till nästa fas i säljguiden.

    1. Klicka på **Redigera** på huvudkortet **Försäljning**.
    2. Klicka på pilen bredvid fältet **Fas** och välj **Offert** i listan.
    3. Klicka på **Spara**.
        Händelserna och dokumenten för den nya fasen visas nu på detaljkortet **Säljguide**.

    > [!TIP]
    > Du kan också högerklicka på **Offert**-knappen på detaljkortet **Säljguide** och välja **Gå till denna fas**.

2. Du vill skapa en uppgift i kalendern för att påminna dig om att förbereda offerten.

    1. Klicka på **Skapa** bredvid händelsen **Offertarbete**.
        Dialogrutan **Uppgift** visas, med **Händelse** angivet som uppgiftstyp.
    2. Fyll i information.
    3. Klicka på **Spara**.
    4. När du har förberett offerten markerar du händelsen som **Slutförd**.

3. Du vill nu skapa offerten till företaget.

    Klicka på **Skapa** bredvid dokumentet **Offert** och [skapa dokumentet][3].

## Fasen Kontraktsunderskrift

1. När alla händelser och dokument i fasen **Offert** är slutförda, går du till den sista fasen i säljguiden, **Kontraktsunderskrift**.

    1. Klicka på **Redigera** på huvudkortet **Försäljning**.
    2. Klicka på pilen bredvid fältet **Fas** och välj **Kontraktsunderskrift** i listan.
    3. Klicka på **Spara**.
        Händelserna och dokumenten för denna fas visas nu på detaljkortet **Säljguide**.

2. Du vill skapa och slutföra den första händelsen i fasen.

    1. Klicka på **Skapa** bredvid telefonsamtalet **Boka kontraktsmöte** och skapa samtalet på vanligt sätt.

    2. När du har slutfört telefonsamtalet markerar du rutan.

    3. I dialogrutan **Säljguide** har du tre val:

        * Klicka på **Skapa** för att skapa händelsen **Kontraktsmöte**, som är nästa händelse i säljguiden. Du kommer då direkt till dialogrutan för händelsen.

        * Klicka på **Avbryt** om du inte vill skapa händelsen nu. Dialogrutan **Säljguide** stängs och du måste komma ihåg att skapa händelsen senare.

        * Markera **Skapa alltid händelse? Visa inte den här dialogrutan igen** om du alltid vill skapa den föreslagna händelsen. Då öppnas dialogrutan för händelser automatiskt nästa gång.

    > [!NOTE]
    > Dialogrutan **Säljguide** öppnas eftersom funktionen **Föreslå denna händelse automatiskt** är aktiverad för händelsen **Kontraktsmöte** i **Inställningar och underhåll**. Du kan välja att inaktivera denna dialogruta, så att nästa händelse föreslås automatiskt.

3. Du vill skapa händelsen **Kontraktsmöte** från dialogrutan **Säljguide**.

    Klicka på **Skapa** i dialogrutan **Säljguide**.
    Dialogrutan **Händelse** öppnas, där du kan skapa mötet på vanligt sätt.

4. Sedan vill du skapa kontraktet att ta med till mötet.

    1. Klicka på **Skapa** bredvid dokumentet **Undertecknat kontrakt** för att skapa kontraktet.
    2. Efter kontraktsmötet och att kontraktet är undertecknat, markerar du händelsen **Kontraktsmöte** som slutförd.

Nu kan du ändra fasen till **Såld**. När alla nödvändiga händelser och dokument för försäljningen är slutförda kan du ange att försäljningen är slutförd.

> [!TIP]
> Om du vill att försäljningen fortfarande ska vara synlig på detaljkortet **Aktiviteter** i fönstret **Försäljning** och detaljkortet **Försäljning** i fönstret **Kalender**, ska du inte ange att försäljningen är slutförd.

## Relaterat innehåll

* [Konfigurera en säljguide i Inställningar och underhåll][4]

<!-- Refererade länkar -->
[1]: ../../diary/learn/invitation/add-attendee.md
[3]: ../../document/learn/edit.md
[4]: ../admin/create-sales-guide.md
