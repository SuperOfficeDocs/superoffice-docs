---
uid: help-sv-follow-up-edit
title: Redigera händelse
description: Hur du öppnar, redigerar eller tar bort en händelse. Ändra sluttid för en händelse i kalendern. Redigera eller ta bort en inbjudan. Redigera återkommande händelse.
keywords: redigera händelse, uppdatera händelse, förläng möte, förkorta möte, ändra endast denna förekomst, ta bort händelse, avboka möte, kalender, händelse, bokning, möte, uppgift, att göra, samtal, telefon, inbjudan
author: Bergfrid Dias
date: 02.21.2025
version: 10.5.2
content_type: howto
license: salesessentials, serviceessentials, marketingessentials
audience: person
audience_tooltip: SuperOffice CRM
language: sv
---

# Redigera händelse

[!include[Note](includes/note-edit-followup.md)]

Om du redigerar tid, datum eller plats för en händelse – eller tar bort en inbjudan som du har skapat och skickat – får de inbjudna ett meddelande om detta.

## Steg

1. Öppna en befintlig händelse genom att dubbelklicka på den:

    * I detaljkortet **Aktiviteter** i fönstret Företag, Kontakt, Kalender, Projekt eller Försäljning.
    * På de olika flikarna i fönstret Kalender.

2. [Gör de nödvändiga ändringarna i dialogrutan.][3]

    [!include[Recurrence](includes/note-repetition.md)]

3. Klicka på **Spara**.

> [!NOTE]
> Du kan inte redigera slutförda händelser förrän du har inaktiverat deras status **Slutförd**.

## <a id="change-end"></a>Ändra sluttid för en händelse i Kalendern

I fönstret Kalender kan du ändra sluttiden för en händelse utan att öppna den:

1. Klicka på händelsen i fliken **Dag**, **Vecka** eller **Översikt**.

1. Håll muspekaren över uppföljningens nedre kant. Markören ändras till en dubbelpil.

1. Klicka och håll nere musknappen, dra sedan den nedre kanten uppåt eller nedåt för att justera uppföljningens varaktighet. Den uppdaterade sluttiden visas medan du drar.

1. Släpp musknappen för att tillämpa ändringen.

> [!NOTE]
> Du kan också ändra tidsintervallet genom att öppna händelsen och redigera fälten **Start**, **Slut**, **Tidsgräns** eller **Varaktighet**.

## <a id="repeat"></a>Redigera återkommande händelse

Ändringar fungerar på samma sätt som när du redigerar händelser, men när du gör en ändring visas dialogrutan **Återkommande händelser**.

![Dialogrutan Återkommande händelser -screenshot][img1]

* Om du väljer **Ändra endast denna förekomst**, påverkas inte andra tider.

* Om du väljer **Ändra denna och alla kommande förekomster**, gäller ändringen även för denna händelse och alla framtida upprepningar.

Du kan endast ändra startdatumet för händelsen när du tittar på återkomstmönstret. För att ändra tiden, klicka på **OK** eller **Avbryt** för att återgå till uppföljningens detaljer.

Om du ändrar återkomstregeln mitt i en serie möten skapas en ny regel, och den gamla regeln stoppas där ändringen sker.

Om du ändrar starttiden för ett enskilt möte påverkas inte återkomstregeln. Mötet behandlas som ett undantag från regeln. Du kan återställa undantaget genom att flytta mötet tillbaka så att det linjerar med de andra.

[!include[Caution](includes/caution-do-not-change-recurring-date.md)]

## <a id="delete"></a>Ta bort händelse i Kalendern

* Om du tar bort en händelse som du är inbjuden till, tas den endast bort från din egen kalender.
* Om du tar bort en inbjudan som du äger från din kalender, försvinner den också från de inbjudna personernas kalendrar.

1. Välj den händelse du vill ta bort.
1. Högerklicka och välj **Ta bort**.
1. Bekräfta borttagningen genom att välja **Ja**, eller välj **Nej** för att behålla händelsen.

[!include[Deleting items](../../learn/includes/tip-deletion.md)]

## Relaterat innehåll

* [Ändra Slutförd-status för en aktivitet][2]
* [Stoppa återkommande händelser][5]
* [Lägg till länk till dokument, försäljning, projekt eller webbplats][6]

<!-- Referenced links -->
[2]: change-completed-status.md
[3]: create-follow-up.md#fields
[5]: recurrence/stop.md
[6]: ../../learn/basics/links.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/change-repeating-fo.png
