---
uid: help-da-forms-sign-up
title: Sådan oprettes formularer (eksempler)
description: Denne vejledning vil forklare, hvordan du opretter en formular hvor dine kunder kan tilmelde sig et eller flere nyhedsbreve
keywords: formular, dobbelt tilmelding, tilmelding, nyhedsbrev
author: Bergfrid Dias
date: 03.11.2024
version: 10
topic: tutorial
audience: person
audience_tooltip: SuperOffice Marketing
language: da
---

# Vejledning - hvordan oprette formular for tilmelding til nyhedsbrev

Lad os se på en annen brugerdefinered formular, der kan være relevant for din virksomhed.

## Hvad vi skal gøre

I denne vejledning vil vi oprette en formular hvor dine kunder kan tilmelde sig et eller flere nyhedsbreve. Tilmeldingsprocessen inkluderer også dobbelt opt-in for at eliminere fejlagtige eller falske abonnementer.

Eksemplerne dækker ikke alle felter og muligheder, men du kan finde detaljerede instruktion i [Opret ny formular][1].

## Start her

1. I SuperOffice, [opret et statisk udvalg][7] af firmaer/personer, der kaldes "Abonnenter på nyhedsbreve (formular)". Vi bruger dette valg senere i denne vejledning.

1. Gå til **Markedsføring** og vælg fanen **Formularer**.

1. Klik på **Formular**-knappen under **Opret ny** på højre side af skærmen.

1. I dialogboksen **Rediger formular**, skriv "Tilmelding til nyhedsbrev i feltet **formularnavne**.

1. Vælg **Egenskaber** og udfyld indstillingerne/felterne hvis relevant. Du må IKKE aktivere indstillingerne under **Deaktiver formular automatisk.**

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

## Felter

1. Velg **Felt** fra venstremenyen.

1. Velg feltet **Kontakt - Navn**, og klikk på den røde X-en for å fjerne dette feltet.

1. Klikk på <i class="ph ph-plus" aria-label="Add"></i> og legg til følgende felt:

    * For- og etternavn

    * **Person - E-mail** (gør dette felt obligatorisk)

    * **Person - abonnement**
        * Vælg et eller flere nyhedsbreve, der skal være tilgængelige
        * Angiv feltet som **Obligatorisk**.
        * Ændr navnet på feltet til "Vælg dine abonnementer".

1. Vælg feltet **OK**, og ændr navnet til "Send" og rediger skrifttypen/baggrundsfarven og placeringen.

1. Rediger navnene på de andre felter ved behov. **Tip**: Fjern "Person -".

1. Klik på ![ikon][img2] øverst i feltet, og træk det til den ønskede placering i formularen. Felterne skal have en logisk rækkefølge.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

![Angi egenskaber for ny tilmeldingsformular -screenshot][img7]

## Typografi

1. Vælg **Typografi** fra venstremenuen for at definere formens udseende. Rediger layoutet, farverne, størrelsen og typografien på formularen i kategorien **Typografi**. Overvej at involvere dine webdesignkolleger.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

![Typografi for ny tilmeldingsformular -screenshot][img8]

## Dobbelt tilmelding

[!include[Show toolbar](includes/tip-show-toolbar-open-editor.md)]

1. Vælg **Dobbelt tilmelding** fra venstremenuen.

1. Klik på **Aktiver dobbelt tilmelding**.

1. I fanen **Meddelelse** angiv den tekst, der skal vises, efter at formularen er blevet indsendt. Denne meddelelse skal informere kunden om, at de vil modtage en bekræftelse via e-mail.

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

1. Klik på **Indsæt bekræftelseslink** (<i class="ph ph-arrow-square-out" aria-hidden="true"></i>). Bekræftelseslinket indsættes i brødteksten.

1. Klik på bekræftelseslinket, vælg **Rediger link** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>), og ændre linkteksten til "Klik her for at bekræfte din e-mailadresse". Linket er som standard gyldigt i 30 minutter.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

![Tilføj dobbel opt-in i ny tilmeldingsformular -screenshot][img9]

## Landingssider

1. Vælg **Tak-side**.

1. Vælg **Vis denne meddelelse** og indtast "Tak, fordi du abonnerer".Dette vises, når kunden har bekræftet sin e-mailadresse.

1. Vælg **Side til inaktiv formular**.

1. Vælg **Omdiriger til eksternt websted** og indtast en URL-adresse. Det er relevant, hvis en kunde får adgang til formularen, når den er indstillet til inaktiv.

1. Klik på **Anvend ny** for at gemme formularen og fortsætte med at redigere.

## Formularhandlinger

1. Vælg **Handlinger** fra venstremenuen for at indstilles de handlinger, der skal udføres, når formularen behandles.

1. Vælg ikke **Opret sag**. Abonnementerne aktiveres automatisk, så supportteamet kræver ingen handling.

1. Vælg **Manuelt, hvis indsenderen er ukendt. Automatisk, hvis indsenderen er kendt**: Hvis e-mailadressen, der indsendes i formularen matcher en e-mailadresse i SuperOffice, behandles den indsendte formular automatisk. Ellers skal den behandles manuelt.

1. **Tilføj person til udvalg**: Vælg blandt de valg, du oprettede i trin 1. Brug dette valg til at holde styr på de personer, der er tilføjet via denne formular.

1. **Tilføj interesser til person**: Vælg interessen, **Nyhedsbrev**. Denne interesse vil blive føjet til personer, der indsender denne formular.

1. **E-mail-svar**: Vælg eller [opret et formularsvar][2], der skal sendes til personer, når deres formular behandles. Denne e-mail kan for eksempel informere kunden om din virksomhedspolitik om beskyttelse af personoplysninger og kan også indeholde et link til [administration af abonnementer][6].

![Definer formularhandlinger -screenshot][img6]

## Gem og udgiv

1. Klik på **Gem**. Formularen gemmes, og skærmbilledet **Rediger formular** lukkes.

1. Indstil formularen til **Aktiv** ![ikon][img4] i sidehovedet.

1. Gå til fanen **Udgiv**.

1. Kopier det direkte link og/eller JavaScript ind i et nyhedsbrev, et websted eller et customer centre for at udgive det til dine kunder eller potentielle kunder.

1. Åbn linket til formularen, udfyld formularen, og kontroller, at alt fungerer som forventet.

> [!TIP]
> Du er måske også interesseret i vores [kontakt-mig formular][7] vejledning.

<!-- Referenced links -->
[1]: create.md
[2]: ../../mailing/learn/create/tutorial-form-mailing.yml
[6]: ../../recipients/learn/manage-email-subscriptions.md
[7]: ../../../search-options/selection/learn/create/tutorial.yml

<!-- Referenced images -->
[img2]: ../../../../media/icons/marketing-and-forms/move-field.png
[img4]: ../../../../media/icons/marketing-and-forms/form-active.png
[img6]: ../../../../media/loc/en/marketing/sign-up-form-actions.png
[img7]: ../../../../media/loc/en/marketing/sign-up-form-fields.png
[img8]: ../../../../media/loc/en/marketing/sign-up-form-style.png
[img9]: ../../../../media/loc/en/marketing/sign-up-form-double-opt-in.png
