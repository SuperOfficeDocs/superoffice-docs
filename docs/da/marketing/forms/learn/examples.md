---
uid: help-da-forms-examples
title: Sådan oprettes formularer (eksempler)
description: Sådan oprettes formularer (eksempler)
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Formularer
so.topic: concept
language: da
---

# Sådan oprettes formularer (eksempler)

Lad os se på to brugerdefinerede formularer, der kan være relevante for din virksomhed:

* [Tilmelding til nyhedsbrev](#newsletter-sign-up): Lad kunderne tilmelde sig et eller flere af dine nyhedsbreve.
* [Kontakt mig](#contact-me): Brug en "Kontakt mig"-formular til åbning af en anden kommunikationskanal med dine kunder eller kundeemner. Brug denne formular til generering af supportanmodninger eller til generering af kundeemner til dit salgsteam.

Eksemplerne dækker ikke alle felter og muligheder, men du kan finde detaljerede instruktion i [Opret ny formular.][1]

## Hvad er dobbelt tilsagn?

Med dobbelt tilsagn skal kunderne bekræfte deres e-mailadresse ved at klikke på linket i en bekræftelses-e-mail ud over at indsende formularen.

Denne indstilling føjer et ekstra lag af sikkerhed til formularen. Hvis du aktiverer denne indstilling, skal personen, der indsender formularen, også bekræfte sin e-mailadresse. Det gøres ved at sende vedkommende en e-mail, når formularen indsendes. E-mailen indeholder et link, som man skal klikke på for at bekræfte, at e-mailadressen er korrekt.
Linket er som standard gyldigt i 30 minutter.

## <a id="newsletter-sign-up" />Tilmelding til nyhedsbrev

Med denne formular kan dine kunder tilmelde sig et eller flere nyhedsbreve. Tilmeldingsprocessen inkluderer også dobbelt opt-in for at eliminere fejlagtige eller falske abonnementer.

1. Åbn SuperOffice CRM, og Opret en statisk udvælgelse af firmaer/personer, der kaldes "Abonnenter på nyhedsbreve (formular)". Vi bruger dette valg senere i denne vejledning.

1. Åbn SuperOffice Markedsføring og gå til fanen **Formularer**.

1. Vælg **Form** under **Opret ny** i højre side af skærmen. Skærmbilledet **Rediger formular** vises.

1. Skriv "Tilmelding til nyhedsbrev i feltet **formularnavne.**

1. Udfyld indstillingerne/felterne i kategorien **Egenskaber**, hvis relevant. Du må IKKE aktivere indstillingerne under **Deaktiver formular automatisk.**

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

1. Klik på **Felter** i kategorien, klik på ![ikon][img1], og tilføj følgende felter:

    * Fornavn og efternavn (fjern feltet **Person - navn**)
    * **Person - E-mail** (gør dette felt obligatorisk)
    * Person - Abonnement
        * Vælg et eller flere nyhedsbreve, der skal være tilgængelige
        * Angiv feltet som **Obligatorisk**.
        * Ændr navnet på feltet til "Vælg dine abonnementer".

1. Vælg feltet**OK**, og ændr navnet til "Send" og rediger skrifttypen/baggrundsfarven og placeringen.

1. Rediger navnene på de andre felter ved behov. **Tip**: Fjern "Person -".

1. Klik på ![ikon][img2] øverst i feltet, og træk det til den ønskede placering i formularen. Felterne skal have en logisk rækkefølge.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

1. Rediger layoutet, farverne, størrelsen og typografien på formularen i kategorien **Typografi**. Overvej at involvere dine webdesignkolleger.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

1. I kategorien **Dobbelt tilmelding** vælges **Aktiver dobbelt tilmelding**.

1. I fanen **Meddelelse** kan du angive den tekst, der skal vises, efter at formularen er blevet indsendt. Denne meddelelse skal informere kunden om, at de vil modtage en bekræftelse via e-mail. Klik på **Vis/skjul værktøjslinje** ![ikon][img3] for at få vist formateringsindstillingerne for teksten.

    <details><summary>Eksempel</summary>

    Vi sender nu en e-mail til den adresse, du har registreret i vores formular.

    Klik på linket i e-mailen for at bekræfte din e-mailadresse og aktivere dit/dine abonnement/abonnementer.

    Med venlig hilsen

    SuperShop
    </details>

1. I fanen **E-mail** skal du oprette den bekræftelses-e-mail, der sendes til personer, der indsender formularen.

    <details><summary>Eksempel</summary>

    Hej og tak for din interesse for vores nyhedsbreve

    Klik på linket nedenfor for at bekræfte din e-mailadresse og aktivere dit abonnement.

    Klik her for at bekræfte din e-mailadresse

    Med venlig hilsen

    SuperShop Teamet
    </details>

1. Klik på **Vis/skjul værktøjslinje** ![ikon][img3], og klik derefter på **Indsæt bekræftelseslink** ![ikon][img4].. Bekræftelseslinket indsættes i brødteksten.

1. Klik på bekræftelseslinket, vælg **Rediger link** ![ikon][img5], og ændre linkteksten til "Klik her for at bekræfte din e-mailadresse". Linket er som standard gyldigt i 30 minutter.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

1. I kategorien **Tak-side** kan du enten omdirigere kunden til en webside eller vise en meddelelse (som f.eks. "Tak, fordi du abonnerer".) Dette vises, når kunden har bekræftet sin e-mailadresse.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

1. I kategorien **Side til inaktiv formular** indtastes en URL-adresse eller en meddelelse. Det er relevant, hvis en kunde får adgang til formularen, når den er indstillet til inaktiv.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

1. i kategorien **Handlinger** indstilles de handlinger, der skal udføres, når formularen behandles:

    * Vælg ikke **Opret anmodning**. Abonnementerne aktiveres automatisk, så supportteamet kræver ingen handling.

    * Vælg **Manuelt, hvis indsenderen er ukendt. Automatisk, hvis indsenderen er kendt**: Hvis e-mailadressen, der indsendes i formularen matcher en e-mailadresse i SuperOffice, behandles den indsendte formular automatisk. Ellers skal den behandles manuelt.

    * **Tilføj person til udvalg**: Vælg blandt de valg, du oprettede i trin 1. Brug dette valg til at holde styr på de personer, der er tilføjet via denne formular.

    * **Tilføj interesser til person**: Vælg interessen, **Nyhedsbrev**. Denne interesse vil blive føjet til personer, der indsender denne formular.

    * **E-mail-svar**: Vælg eller [opret et formularsvar][2], der skal sendes til personer, når deres formular behandles. Denne e-mail kan for eksempel informere kunden om din virksomhedspolitik om beskyttelse af personoplysninger og kan også indeholde et link til [administration af abonnementer][6].

1. Klik på **Gem**. Formularen gemmes, og skærmbilledet **Rediger formular** lukkes.

1. Indstil formularen til **Aktiv** ![ikon][img6] i sidehovedet.

1. Gå til fanen **Udgiv**.

1. Kopier det direkte link og/eller JavaScript ind i et nyhedsbrev, et websted eller et customer centre for at udgive det til dine kunder eller potentielle kunder.

1. Åbn linket til formularen, udfyld formularen, og kontroller, at alt fungerer som forventet.

## <a id="contact-me" />Kontakt mig

Læg en "Kontaktmig"-formular på firmaets websider for at give en nem kommunikationskanal til nuværende eller potentielle kunder.

I dette eksempel viser vi, hvordan du opretter en kort formular til kunder, der vil i kontakt med en supportmedarbejder. Indsendelsen af formularen udløser en ny anmodning til din supportafdeling.

1. Åbn SuperOffice Markedsføring og gå til fanen **Formularer**.

1. Vælg **Form** under **Opret ny** i højre side af skærmen. Skærmbilledet **Rediger formular** vises.

1. Skriv "Kontakt mig (support)" i feltet **Formularnavn.**

1. Udfyld indstillingerne/felterne i kategorien **Egenskaber**, hvis relevant. Du må IKKE aktivere indstillingerne under **Deaktiver formular automatisk.**

1. Klik på **Felter** i kategorien, klik på ![ikon][img1], og tilføj følgende felter:

    * For-og efternavn. Fjern feltet **Person - navn**.
    * **Få vist elementer** > **Tekstblok**: Indtast teksten i "Sådan kan vi kontakte dig?" med fed skrift.
    * **Person - Mobil**: Indtast et eksempel på et korrekt formateret telefonnummer for dit land (medtage landekoden) i feltet **Pladsholder** (eksempel +45 20131188).
    * **Person - E-mail**
    * **Formularelementer** > **Tekstområde**: Ændr navnet på feltet til "Kommenter (valgfrit)", og skriv "Hvad kan vi hjælpe med i dag?" i feltet **Pladsholder**.

1. Vælg feltet**OK**, og ændr navnet til "Send" og rediger skrifttypen/baggrundsfarven og placeringen.

1. Rediger navnene på de andre felter ved behov. **Tip**: Fjern "Person -".

1. Klik på ![ikon][img2] øverst i feltet, og træk det til den ønskede placering i formularen. Felterne skal have en logisk rækkefølge.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

1. Rediger layoutet, farverne, størrelsen og typografien på formularen i kategorien **Typografi**. Overvej at involvere dine webdesignkolleger.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

1. Valgfrit: Hvis du vil aktivere dobbelt tilmelding, skal du også **indstille feltet E-mail** til **Obligatorisk**.

1. I kategorien **Tak-side** kan du enten omdirigere kunden til en webside eller vise en meddelelse (som f.eks. "Tak, fordi du abonnerer". "Vi kontakter dig så hurtigt som muligt.") Det vises, når kunden har sendt formularen.

1. I kategorien **Side til inaktiv formular** indtastes en URL-adresse eller en meddelelse. Det er relevant, hvis en kunde får adgang til formularen, når den er indstillet til inaktiv.

1. i kategorien **Handlinger** indstilles de handlinger, der skal udføres, når formularen behandles:

    * Vælg **Opret sag**, og gør følgende:
        1. Indtast en beskrivende titel på sagen, der skal genereres fra denne formular.
        2. Vælg den relevante sagskategori, f.eks. "Support", eller en underkategori med navnet "Formularindsendelser".
        3. Indstil sagsprioriteten **til**Mellem.

    * Vælg **Manuelt, hvis indsenderen er ukendt. Automatisk, hvis indsenderen er kendt**: Hvis e-mailadressen, der indsendes i formularen matcher en e-mailadresse i SuperOffice, behandles den indsendte formular automatisk. Ellers skal den behandles manuelt.

    * **E-mail-svar**: Vælg et formularsvar, der skal sendes til personer, når deres formular behandles. Denne e-mail kan for eksempel informere kunden om din virksomhedspolitik om beskyttelse af personoplysninger og kan også indeholde et link til administration af abonnementer. [Sådan oprettes et formularsvar][2].

1. Klik på **Gem**. Formularen gemmes, og skærmbilledet **Rediger formular** lukkes.

1. Indstil formularen til **Aktiv** ![ikon][img6] i sidehovedet.

1. Gå til fanen **Udgiv**.

1. Kopier det direkte link og/eller JavaScript ind i et nyhedsbrev, et websted eller et customer centre for at udgive det til dine kunder eller potentielle kunder.

1. Åbn linket til formularen, udfyld formularen, og kontroller, at alt fungerer som forventet.

## Hvad sker der så nu?

* [Formularindsendelser][3]
* [Sporing af formularindsendelser og visning af statistik][4]
* [Behandling af formularindsendelser][5]

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.yml
[3]: submissions/index.md
[4]: submissions/track.md
[5]: submissions/process.md
[6]: ../../recipients/learn/manage-email-subscriptions.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/marketing-and-forms/add-field.png
[img2]: ../../../../media/icons/marketing-and-forms/move-field.png
[img3]: ../../../../media/icons/marketing-and-forms/toolbar-show-hide.png
[img4]: ../../../../../common/icons/new-window-icon.png
[img5]: ../../../../../common/icons/edit-black.png
[img6]: ../../../../media/icons/marketing-and-forms/form-active.png
