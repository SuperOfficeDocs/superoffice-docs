---
uid: help-sv-recurrence-set
title: Schemalägg återkommande händelse
description: Schemalägg återkommande händelse
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: kalender, händelse, upprepa, återkomma
so.topic: howto
language: sv
---

# Schemalägg återkommande händelse

Att ställa in återkommande möten innebär att schemalägga startdatumet för uppföljningsmöten i en serie.

[!include[Caution](../includes/caution-do-not-change-recurring-date.md)]

## Steg

<!-- markdownlint-disable MD051 -->
### [Classic](#tab/fields-old)

1. [Öppna eller skapa en händelse][2].

2. Välj fliken **Detaljer** och klicka på ordet **Aldrig** brevid fältet **Upprepning**.

    Om du uppdaterar en återkommande uppföljning, klicka på det tidigare inställda mönstret, till exempel, **Månadsvis (23.09.2023 - 23.09.2024)**.

3. Under **Förekomst** anger du om händelsen ska upprepas varje dag, vecka, månad eller år eller med ett användardefinierat intervall.

4. Välj sedan ytterligare [information för förekomst][4]. Vilka alternativ som är tillgängliga här beror på vad du väljer under steg 3.

    Om inget av mönstren passar dig, kan du manuellt ange de datum du behöver. Välj **Egendefinierad**. Välj sedan ett datum i kalendern och klicka på pilen ![ikon][img2] för att lägga till det i listan över valda datum. Upprepa för att lägga till fler datum. För att ta bort ett datum, välj datumet i listan och klicka på **Ta bort**.

5. I fältet **Återkommande händelser upphör** väljer du om händelsen ska upphöra efter ett visst antal gånger eller efter ett visst datum.

6. Du kan också ändra ett eller flera datum manuellt i listan över valda datum, till exempel om det finns en konflikt.

    * **För att flytta ett datum,** välj det datum du vill flytta och klicka på **Senare**  om du vill skjuta upp händelsen en dag eller på **Tidigare** om du vill flytta händelsen en dag framåt.

    * **För att lägga till ett datum,** klicka på knappen **Lägg till** under listan. Välj önskat datum och klicka på pilknappen ![ikon][img2] till höger om kalendern för att lägga till datumet i listan. Använd pilknapparna på vardera sida om månadsnamnet i kalendern för att visa andra månader.

    * **För att ta bort ett datum,** markera det datum du vill ta bort och klicka på knappen **Ta bort** under listan. Datumet tas bort från datumlistan.

7. När du har lagt in datum för händelsen klickar du på **OK** om du vill spara datumen och stänga dialogrutan, eller på **Avbryt** om du vill stänga dialogrutan utan att spara datumen.

    I dialogrutan **Bokning**, **Uppgift** eller **Samtal** visar texten bredvid fältet **Upprepning** vilken typ av upprepning du har valt för händelsen, till exempel **Månatlig (2016-09-23–2017-09-23)**.

8. Klicka på **Spara** i dialogrutan **Bokning** för att spara dina ändringar.

![Skärmbild av dialogruta för återkommande uppföljningar -screenshot][img6]

### [Ny (från version 10.2.11 pilot)](#tab/fields-new)

1. [Öppna eller skapa en uppföljning][2].

1. Klicka på upprepningssymbolen ![ikon][img1] och välj en av de föreslagna frekvenserna. Om inget av mönstren passar dig, välj **Anpassad**.

    ![Uppföljningsdialog, föreslagen återkomst -screenshot][img8]

    Om du inte ser ikonen, klicka på **Visa mer**.

1. Uppdatera startdatumet om det behövs.

1. Välj en frekvens, till exempel, upprepa var 2:a vecka. Ytterligare alternativ visas om du väljer *Vecka(r)*, *Månad(er)*, eller *År*.

    ![Uppföljningsdialog, återkomst -screenshot][img7]

1. Välj om uppföljningen ska sluta efter ett specifikt antal gånger eller efter ett specifikt datum.

1. Valfritt, finjustera listan över valda datum, till exempel, om det finns en konflikt. Klicka på ett datum, använd sedan knapparna under listan för att antingen ta bort eller flytta det datumet.

1. Klicka på **OK** för att spara datumen och återgå till uppföljningsdetaljerna.

1. Klicka på **Spara** i **Uppföljnings**-dialogen för att spara alla ändringar.

***
<!-- markdownlint-restore -->

## Vad vill du veta mer om?

* [Redigera återkommande händelser][1]
* [Stoppa återkommande händelser][3]

<!-- Referenced links -->
[1]: ../edit-follow-up.md#repeat
[2]: ../create-follow-up.md
[3]: stop.md
[4]: index.md#frequency

<!-- Referenced images -->
[img1]: ../../../../../common/icons/refresh-icon.png
[img2]: ../../../../media/icons/arrow-right.png
[img6]: ../../../../media/loc/en/diary/recurrence-dialog.png
[img7]: ../../../../media/loc/en/diary/recurrence-selected-dates.png
[img8]: ../../../../media/loc/en/diary/suggested-pattern.png
