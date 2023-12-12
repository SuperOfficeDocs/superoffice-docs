---
uid: help-sv-follow-up-edit
title: Redigera händelser
description: Öppna, redigera, eller ta bort händelse i kalendern; Ändra sluttid för en händelse i kalendern; Redigera eller ta bort förfrågan; Redigera återkommande händelse
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: kalender, händelse, förfrågan, bokning, uppgift, samtal, upprepa, återkomma
so.topic: howto
language: sv
---

# Redigera händelse

[!include[Note](includes/note-edit-followup.md)]

Om du redigerar tid, datum eller plats för en händelse - eller tar bort en förfrågan som du har skapat och skickat - får mottagarna ett meddelande om detta.

## Steg

1. Öppna en befintlig händelse genom att dubbelklicka på den:

    * I detaljkortet **Aktiviteter** i fönstret Företag, Kontakt, Försäljning, Projekt, Kalender
    * På flikarna i fönstret Kalender.

2. [Gör dina ändringar i dialogrutan.][3]

    [!include[Recurrence](includes/note-repetition.md)]

3. Klicka på **Spara**.

> [!NOTE]
> Du kan inte göra ändringar i slutförda händelser förrän du har inaktiverat statusen **Slutförd**.

## <a id="change-end" />Ändra sluttid för en händelse i kalendern

I fönstret Kalender kan du ändra sluttiden för en händelse utan att öppna den:

1. Klicka på händelsen på fliken **Dag**, **Vecka** eller **Visa**.

2. Håll muspekaren på händelsens nedre kant. Markören ändras till en dubbelpil.

3. Klicka på kanten och håll ned musknappen medan du drar den blå linjen uppåt eller nedåt för att minska eller öka händelsens tidsspann. Händelsens sluttid visas högst upp i det blå området.

4. Släpp musknappen. Händelsens tidsspann har ändrats.

> [!NOTE]
> Du kan också ändra tidsspannet genom att öppna händelsen och ändra fälten **Start**, **Slut**, **Tidsgräns** eller **Varaktighet**.

## <a id="repeat" />Redigera återkommande händelse

Ändringar fungerar på samma sätt som när du redigerar händelser, men när du gör en ändring visas dialogrutan **Återkommande händelser**.

![Repeating follow-up dialog -screenshot][img1]

* Om du väljer **Ändra endast denna förekomst** påverkar ändringen inte andra förekomster.

* Om du väljer **Ändra denna och alla kommande förekomster** tillämpas ändringen även på framtida förekomster av händelsen.

Du kan endast ändra startdatumet för händelsen när du tittar på återkomstmönstret. För att ändra tiden, klicka på **OK** eller **Avbryt** för att återgå till uppföljningsinformationen.

Om du bestämmer dig för att ändra regelmönstret mitt i en serie möten, då skapas en ny regel och den gamla regeln stoppas där brytningen inträffar.

Om du ändrar starttiden för ett enskilt möte påverkas inte regeln. Mötesundantaget betraktas som ett undantag från regeln. Undantaget kan göras om till ett vanligt möte genom att flytta det tillbaka i linje med de andra mötena.

[!include[Caution](includes/caution-do-not-change-recurring-date.md)]

## <a id="delete" />Ta bort händelse i kalendern

* Om du tar bort en förfrågan du blivit inbjuden till, tas den bort enbart från din egen dagbok.
* Om du tar bort en förfrågan som du äger från din dagbok, försvinner den även från de inbjudna personernas kalendrar.

1. Välj önskad händelse.
2. Högerklicka och välj **Ta bort**.
3. Bekräfta eller avbryt borttagningen i dialogrutan för bekräftelse.

[!include[Deleting items](../../learn/includes/tip-deletion.md)]

## Relaterade ämnen

* [Ändra Slutfört-status för en aktivitet][2]
* [Stoppa återkommande händelser][5]

<!-- Referenced links -->
[2]: change-completed-status.md
[3]: create-follow-up.md#fields
[5]: recurrence/stop.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/diary/change-repeating-fo.png
