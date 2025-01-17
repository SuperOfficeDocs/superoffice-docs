---
uid: help-da-form-field-options
title: Feltindstillinger
description: Feltindstillinger
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Formularer
so.topic: reference
language: da
---

# Feltindstillinger

Dette er en oversigt over særlige indstillinger i nogle af de tilgængelige felter.

## SuperOffice-elementer

* **Erstat**: Vælg denne indstilling for at erstatte en eksisterende værdi i SuperOffice med værdien i formularen. Dette er relevant for land, titel og Hr./Fr.

* **Person - samtykke**

  * **Formål**: Vælg, hvorfor personen skal give sit samtykke. Godkendelseteksten og beskrivelsen defineres i Indstillinger og vedligeholdelse.

  * **Vis link til erklæring om beskyttelse af personlige oplysninger**: Vælg denne indstilling for at medtage linket til erklæringen om beskyttelse af personlige oplysninger,[!include[SM](../../../learn/includes/as-defined-sm.md)]

* **Person - abonnement**: Vælg de abonnementer, der skal være synlige i formularen.

* **Firmanavn: Brug eksisterende firma hvis fundet**.

  * Hvis denne indstilling er slået TIL: Hvis en person indsender en formular, hvor firmanavnet matcher et firma i SuperOffice, føjes personen automatisk til firmaet som en ny person.

  * Hvis indstillingen er slået FRA: Både personen og firmaet føjes til SuperOffice.

  > [!NOTE]
  > Denne indstilling er normalt slået FRA for at undgå, at "tilfældige" personer føjes til firmaer, de ikke hører til.

## Formularelementer

* **Tekstfelt**: Et simpelt tekstfelt med 1 række.

* **Tekstområde**: Et stort tekstfelt med flere rækker.

* **Valgmulighedsknapper**: Et valgfelt, hvor man kan vælge én blandt flere værdier.

  * **Lodret**: Vis værdierne vandret eller lodret.

  * **Data**: Her kan du angive værdierne for hver alternativknap. Indtast en værdi i dette felt, og klik på knappen Tilføj ![ikon][img1]. Gentag for at tilføje flere værdier.

* **Afkrydsningsfelt**: Et valgfelt, hvor man kan vælge flere værdier.

  * **Lodret**: Vis værdierne vandret eller lodret.

  * **Data**: Her kan du angive værdierne for hvert afkrydsningsfelt. Indtast en værdi i dette felt, og klik på knappen Tilføj ![ikon][img1]. Gentag for at tilføje flere værdier.

* **Rulleliste**: Et valgfelt, hvor man kan vælge værdier fra en liste.

  * **Data**: Her angiver du listeværdierne. Indtast en værdi i dette felt, og klik på knappen Tilføj ![ikon][img1]. Gentag for at tilføje flere værdier.

* **Skjult**: Et felt, der ikke er synligt i den udgivne formular. I feltet **Standardværdi** kan du indtaste en kode, et projektnavn/-nummer eller andre oplysninger, som skal knyttes til denne formular.

* **Dato**: Et datofelt.

* **Upload fil**: Et felt til at uploade filer.

  * **Tillad flere filer**: Vælg denne indstilling for at tillade upload af flere filer.

  * **Maksimal filstørrelse (kb)**: Angiv en filtørrelse i kilobyte for at forhindre en stor fil i at blive uploadet. Lad dette felt stå tomt for at tillade alle filstørrelser.

  * **Godkendte filtyper**: Angiv de filtyper, der kan uploades. Brug formatet *jpg,gif,png,bmp* (kommasepareret, ingen mellemrum). Lad dette felt stå tomt for at tillade alle filtyper.

* **Bedømmelse**: Et felt, hvor kunderne kan bedømme for eksempel den service, de har fået, ved hjælp af forskellige bedømmelsestyper (stjerner, terninger, skala fra 1-10 osv.).

* **Google reCAPTCHA**: [reCAPTCHA-funktionen][1] (afkrydsningsfeltet "Jeg er ikke en robot") er en gratis Google-tjeneste, der vil sikre, at kun rigtige brugere kan indsende webformularer.. Dette forhindrer spam og automatiserede bots i at sabotere din dataindsamling.

## Visningselementer

* **Tekstblok**: Indtast en tekst, der skal vises i formularen, for eksempel en kort introduktion eller en detaljeret beskrivelse. Klik på **Vis/skjul værktøjslinje** ![ikon][img2] for at få vist formateringsindstillingerne for teksten. Klik på **Åbn teksteditor i dialogboks** ![ikon][img3] for at redigere teksten i et større redigeringsprogram.

* **Billede**: Tilføj et billede til formularen. Klik på linket for at vælge et billede, eller træk og slip et billede til feltet **Billede**. Brug valgmulighedsknappen **Position** til at placere billedet på formularen.

* **Afsnit**: Tilføj en sektion mellem felterne for at [oprette en formular med flere sider][2]. Nyttigt, hvis formularen indeholder mange felter, og du vil undgå at rulle.

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/marketing/forms/recaptcha.html
[2]: create.md#multi-page

<!-- Referenced images -->
[img1]: ../../../../../common/icons/add-icon.png
[img2]: ../../../../media/icons/marketing-and-forms/toolbar-show-hide.png
[img3]: ../../../../../common/icons/pop-out-icon.png
