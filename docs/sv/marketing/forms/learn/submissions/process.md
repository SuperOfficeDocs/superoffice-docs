---
uid: help-sv-form-submissions-process
title: Behandla formulärinlämningar
description: I den här guiden lär du dig hur du bearbetar formulärinlämningar manuellt.
author: SuperOffice RnD
so.date: 02.21.2023
keywords: Formulär
so.topic: howto
language: sv
---

# Behandla formulärinlämningar

Så snart formulärinlämningarna börjar strömma in är det dags att behandla dem. Formulär kan behandlas automatiskt, manuellt eller en kombination av båda.

> [!NOTE]
> SuperOffice kommer att kontrollera och validera e-postadressen som har angetts i formuläret för att kontrollera att det är ett befintligt domännamn. Grundläggande syntax i e-postadressen kontrolleras också.

När du har konfigurerat ditt webbformulär för att automatiskt behandla alla inkommande inlämningar behöver du inte göra någonting. SuperOffice CRM behandlar dem åt dig och skapar en ny kontakt när ingen matchning hittas i din databas.

* När du behandlar formulärinlämningar manuellt kan du förhindra dubblettkontakter genom att kontrollera om en person redan är registrerad i din databas eller inte.

* Du kan också välja det här alternativet: "Manuellt om avsändaren är okänd. Automatiskt om avsändaren är känd." På så sätt har du mer kontroll över de kontakter som läggs till i databasen via formulärinlämningar.

Formulärinlämningar med statusen **Inlämnad** måste behandlas manuellt. Det innebär att formulärinnehållet granskas och länkas till avsändaren i en befintlig eller en ny kontakt och/eller företag i SuperOffice. Bearbetade formulär kommer att finnas tillgängliga på detaljkortet **Aktiviteter** i fönstren Företag och Kontakt i SuperOffice CRM. Om du valt att få en avisering vid varje nytt ärende blir de behandlade formulären tillgängliga på fliken **Ärende**.

Titta på den här videon (eller följ steg-för-steg-guiden nedan) för att lära dig hur du manuellt kan behandla ett inskickat webbformulär (videons längd – 4:30) eller följ stegen nedan.

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/XtdkUwIXkww]

## Steg

1. I SuperOffice Marknadsföring:
    1. Öppna ett formulär och gå till fliken **Formulärinlämningar** eller gå till fliken **Formulärinlämningar** (i huvudfönstret **Marknadsföring**).
    2. Avmarkera alla filter förutom **Inlämnad** längst ned i listan över formulärinlämningar. I listan visas bara formulärinlämningar som måste behandlas.

    I SuperOffice CRM: Gå till fönstret Kontakt, sök efter den aktuella personen och välj detaljkortet **Aktiviteter**.

2. Dubbelklicka på en rad.

3. I fönstret **Formulärinlämning**granskar du inlämnade data på fliken **Data från-formulär**.

4. Gå till fliken **Åtgärder** om du vill visa de åtgärder som utförs på formulärdata när du behandlar dem.

5. På sidopanelen **Avsändare** måste du länka avsändaren till en befintlig eller ny kontakt i SuperOffice.

6. Klicka på **Behandla**.

## Länka avsändaren till en SuperOffice-kontakt och företag

När ett formulär lämnas in försöker SuperOffice matcha e-postadressen i formuläret med befintliga e-postadresser i SuperOffice och länka formulärinlämningen till en befintlig kontakt. Om avsändaren finns i SuperOffice kan du visa kontaktinformation, ärenden, försäljning, händelser och tidigare registrerade chattsessioner.

Om ingen matchning hittades kan du försöka hitta rätt kontakt eller skapa en ny kontakt (och företag).

### Använd föreslagen kontakt

Om SuperOffice hittar matchande kontakter i databasen listas de under **Den här kontakten kan vara...**. Klicka på en kontakt om du vill visa relevant information och länka kontakten till denna formulärinlämning.

### Söka efter en kontakt

Om det inte går att hitta rätt kontakt i databasen i SuperOffice kan du söka efter kontakten i sökfältet. Här kan du också välja från historiklistan och favoriter.

### Ändra kontakt

Om du har valt fel kontakt klickar du på **Byt kontakt** längst ned på sidopanelen för att söka efter en annan kontakt.

### Skapa nytt företag och ny kontakt

Om du inte hittar avsändaren i SuperOffice kan du skapa en ny kontakt och nytt företag i sidopanelen.

1. Klicka på **Skapa nytt företag och ny kontakt**. Vissa fält fylls i med information som kunden lämnade i formuläret.
2. Fyll i relevanta fält.
3. Klicka på **Lägg till**. Den nya kontakten och det nya företaget läggs till i SuperOffice.
