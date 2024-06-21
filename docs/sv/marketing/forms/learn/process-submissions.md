---
uid: help-sv-form-submissions-process
title: Behandla formulärinlämningar
description: I den här guiden lär du dig hur du bearbetar formulärinlämningar manuellt.
keywords: formulär, formulärinlämning, avsändar, inlämnad, data från formulär, formulärdat
author: Bergfrid Dias
date: 03.18.2024
version: 10
topic: howto
language: sv
audience: person
audience_tooltip: SuperOffice Marketing
---

# Behandla formulärinlämningar

Så snart formulärinlämningarna börjar strömma in är det dags att behandla dem. Formulär kan behandlas automatiskt, manuellt eller en kombination av båda. Detta anges som [formuläråtgärder][2].

Formulärintagningar med status **Inlämnad** måste behandlas manuellt. Detta innebär att granska formulärinnehållet och länka avsändaren till en befintlig eller ny kontakt och/eller företag i SuperOffice.

Den främsta anledningen till att välja manuell behandling är att ha mer kontroll över de kontakter som läggs till i din databas genom formulärintagningar. Specifikt kan du förhindra dubblettkontakter genom att kontrollera om en person redan är registrerad. SuperOffice kommer att kontrollera och validera e-postadressen som har angetts i formuläret för att kontrollera att det är ett befintligt domännamn. Grundläggande syntax i e-postadressen kontrolleras också.

När ett formulär skickas in försöker SuperOffice att koppla formuläret till en befintlig kontakt med hjälp av den angivna e-postadressen.

* Om en matchning hittas kan du visa kontakternas information, ärenden, försäljning, händelser och tidigare chattsessioner.
* Om ingen matchning hittas, sök efter rätt kontakt eller skapa en ny.

Titta på den här videon (eller följ steg-för-steg-guiden nedan) för att lära dig hur du manuellt kan behandla ett inskickat webbformulär (videons längd – 4:30) eller följ stegen nedan.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/XtdkUwIXkww]

## Steg

### 1- Hitta och öppna formulärinlämningen

Gör något av följande:

* Om du blev meddelad av ett Service ärende, öppna ärendet och klicka på länken.

* Om avsändaren är känd, gå till fönstret Kontakt, sök efter den aktuella personen och välj detaljkortet **Aktiviteter**. Dubbelklicka på raden med den ohanterade formulärinlämningen.

* I SuperOffice Marketing:

    1. Öppna ett formulär och gå till fliken **Formulärinlämningar**, eller gå till fliken **Formulärinlämningar** på huvudfönstret för marknadsföring.

    2. Längst ner på listan över formulärinlämningar avmarkera alla filter förutom **Inlämnad**. Listan visar nu bara formulärinlämningar som måste behandlas.

    3. Dubbelklicka på raden med den inlämning du vill behandla.

### 2 - Granska och behandla data

I **Formulärinlämning**-fönstret:

1. Välj fliken **Data från formulär** och granska de inlämnade data.

2. Välj fliken **Åtgärder** för att se de åtgärder som utförs på formulärdata när du behandlar dem.

3. I sidopanelen för **Avsändare**, länka avsändaren till en befintlig eller ny SuperOffice-kontakt:

    * **Använd föreslagen kontakt:** Om SuperOffice hittar matchande kontakter, visas de under **Den här kontakten kan vara...**. Klicka på en kontakt för att länka den till denna formulärinlämning.

    * **Sök efter en kontakt:** Om den korrekta kontakten inte hittas, använd sökfältet för att hitta den. Du kan också välja från historik och favoriter.

    * **Ändra kontakt:** Om du har valt fel kontakt, klicka på **Byt kontakt** för att söka igen.

    * **Skapa nytt företag och ny kontakt:** Om avsändaren inte finns i SuperOffice, skapa en ny kontakt och ett nytt företag:

      1. Klicka på **Skapa nytt företag och ny kontakt**. Vissa fält fylls i med formulärdata.
      2. Fyll i relevanta fält.
      3. Klicka på **Lägg till** för att lägga till den nya kontakten och företaget i SuperOffice.

4. Klicka på **Behandla**.

![Formulärinlämningar, Data från-formulär -screenshot][img1]

## Vad vill du göra nu?

* [Spåra formulärinlämningar och visa statistik][1]
* [Analysera dina utskicksresultat][4]

<!-- Referenced links -->
[1]: view-statistics.md
[2]: define-form-actions.md
[4]: ../../mailing/learn/view-statistics.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/marketing/form-submission-add-contact.png
