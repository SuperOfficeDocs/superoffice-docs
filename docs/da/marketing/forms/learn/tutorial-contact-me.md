---
uid: help-da-forms-contact-me
title: Sådan oprettes en kontakt-mig formular
description: Denne vejledning vil forklare, hvordan du opretter en formular til kunder, der vil i kontakt med en supportmedarbejder.
keywords: formular, kontakt mig
author: Bergfrid Dias
date: 03.11.2024
version: 10
topic: tutorial
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Sådan oprettes en kontakt-mig formular

Læg en "Kontakt-mig"-formular på firmaets websider for at give en nem kommunikationskanal til nuværende eller potentielle kunder. Brug denne formular til generering af supportsag eller til generering af kundeemner til dit salgsteam.

## Hvad vi skal gøre

I dette eksempel viser vi, hvordan du opretter en formular til kunder, der vil i kontakt med en supportmedarbejder. Indsendelsen af formularen udløser en ny sag til din supportafdeling.

Eksemplerne dækker ikke alle felter og muligheder, men du kan finde detaljerede instruktion i [Opret ny formular][1].

## Start her

1. Åbn SuperOffice Markedsføring og gå til fanen **Formularer**.

1. Klik på **Formular**-knappen under **Opret ny** på højre side af skærmen.

1. I dialogboksen **Rediger formular**, skriv "Kontakt mig (support)" i feltet **Formularnavn**.

1. Vælg **Egenskaber** og udfyld indstillingerne/felterne hvis relevant. Du må IKKE aktivere indstillingerne under **Deaktiver formular automatisk.**

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

![Udfyld egenskaber for ny kontakt-mig formular -screenshot][img5]

## Felter

1. Vælg **Felter** fra venstremenuen.

1. Vælg feltet **Kontakt - Navn**, og klik på den røde X for at fjerne dette felt.

1. Klik på <i class="ph ph-plus" aria-label="Add"></i>, og tilføj følgende felter:

    * For-og efternavn.

    * **Få vist elementer** > **Tekstblok**: Indtast teksten "Sådan kan vi kontakte dig?" med fed skrift.

    * **Person - Mobil**: Indtast et eksempel på et korrekt formateret telefonnummer for dit land (medtage landekoden) i feltet **Pladsholder** (eksempel +45 20131188).

    * **Person - E-mail**

    * **Formularelementer** > **Tekstområde**: Ændr navnet på feltet til "Kommenter (valgfrit)", og skriv "Hvad kan vi hjælpe med i dag?" i feltet **Pladsholder**.

    [!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

1. Vælg feltet **OK**, ændr navnet til "Send" og rediger skrift/baggrundsfarven og placeringen.

1. Rediger navnene på de andre felter ved behov. **Tip**: Fjern "Person -".

1. Klik på ![ikon][img2] øverst i feltet, og træk det til den ønskede placering i formularen. Felterne skal have en logisk rækkefølge.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

![Tilføj felt i ny kontakt-mig formular -screenshot][img6]

## Typografi

1. Vælg **Typografi** fra venstremenuen for at definere formens udseende. Rediger layoutet, farverne, størrelsen og typografien på formularen. Overvej at involvere dine webdesignkolleger.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

## Landingssider

1. Vælg **Tak-side**.

1. Vælg **Vis denne meddelelse** og indtast "Tak, fordi du abonnerer". "Vi kontakter dig så hurtigt som muligt." Det vises, når kunden har sendt formularen.

1. Vælg **Side til inaktiv formular**.

1. Vælg **Omdiriger til eksternt websted** og indtast en URL-adresse. Det er relevant, hvis en kunde får adgang til formularen, når den er indstillet til inaktiv.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

## Formularhandlinger

1. Vælg **Handlinger** fra venstremenuen for at indstilles de handlinger, der skal udføres, når formularen behandles.

1. Vælg **Opret sag**, og gør følgende:
    1. Indtast en beskrivende titel på sagen, der skal genereres fra denne formular.
    2. Vælg den relevante sagskategori, f.eks. "Support", eller en underkategori med navnet "Formularindsendelser".
    3. Indstil sagsprioriteten til **Mellem**.

1. Vælg **Manuelt, hvis indsenderen er ukendt. Automatisk, hvis indsenderen er kendt**: Hvis e-mailadressen, der indsendes i formularen matcher en e-mailadresse i SuperOffice, behandles den indsendte formular automatisk. Ellers skal den behandles manuelt.

1. **E-mail-svar**: Vælg eller [opret et formularsvar][2], der skal sendes til personer, når deres formular behandles. Denne e-mail kan for eksempel informere kunden om din virksomhedspolitik om beskyttelse af personoplysninger og kan også indeholde et link til [administration af abonnementer][6].

![Definer formularhandlinger -screenshot][img7]

## Gem og udgiv

1. Klik på **Gem**. Formularen gemmes, og skærmbilledet **Rediger formular** lukkes.

1. Indstil formularen til **Aktiv** ![ikon][img3] i sidehovedet.

1. Gå til fanen **Udgiv**.

1. Kopier det direkte link og/eller JavaScript ind i et nyhedsbrev, et websted eller et customer centre for at udgive det til dine kunder eller potentielle kunder.

1. Åbn linket til formularen, udfyld formularen, og kontroller, at alt fungerer som forventet.

> [!TIP]
> Du er måske også interesseret i vores [nyhedsbrev tilmelding][7] vejledning. Lad dine kunder tilmelde sig et eller flere af dine nyhedsbreve.

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.yml
[6]: ../../recipients/learn/manage-email-subscriptions.md
[7]: tutorial-sign-up.md

<!-- Referenced images -->
[img2]: ../../../../media/icons/marketing-and-forms/move-field.png
[img3]: ../../../../media/icons/marketing-and-forms/form-active.png
[img5]: ../../../../media/loc/en/marketing/contact-me-form-properties.png
[img6]: ../../../../media/loc/en/marketing/contact-me-form-fields.png
[img7]: ../../../../media/loc/en/marketing/contact-me-form-actions.png
