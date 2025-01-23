---
uid: help-no-faq-create
title: Opprett FAQ-oppføringer
description: Opprett FAQ-oppføringer
author: Bergfrid Dias
date: 03.14.2023
keywords: FAQ
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: no
---

# Opprett FAQ-oppføringer

Ved å opprette FAQ-oppføringer kan organisasjonen bygge opp en omfattende samling av spørsmål og svar som både kunder og ansatte kan bruke til å finne nyttig informasjon. FAQ-oppføringer kan opprettes på to måter:

* En bruker kan opprette en oppføring i FAQ, basert på kommunikasjon med en kunde i skjermbildet Saker.
* En administrator kan opprette en FAQ-oppføring direkte i **kunnskapsbasen** > **FAQ**.

Se denne videoen og finn ut hvordan du oppretter og publiserer FAQ-oppføringer i kundesenteret eller følg trinn-for-trinn-veiledningen nedenfor (videolengde - 3:01):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/TLOukelJp54]
*Slik oppretter og publiserer du en FAQ - Denne videoen er laget for versjon 8, så veiledningen kan avvike litt fra hvordan den ser ut i dag, men du vil forstå hvordan du gjør de samme trinnene i dagens versjon.*

## Krav

* Du trenger en lisens for Service premium eller Customer Engagement-plattformen for å bruke kunnskapsbasen.
* Hvis du ikke ser denne funksjonen, må du legge til *kunnskapsbasen* som funksjonell rettighet for å opprette FAQ.

## Opprett FAQ-oppføringer fra en sak

Hvis du svarer på en henvendelse og tenker at samme spørsmål kan komme opp igjen, kan det være lurt å lage et svar som kan gjenbrukes og gjøres tilgjengelig for alle kunder.

1. [Åpne en sak][1].

1. Klikk på <i class="ph ph-dots-three-circle-vertical" aria-label="Task menu"></i> og velg **Publiser til FAQ**. Du kommer til skjermbildet **Egenskaper for FAQ-oppføring**.

   ![Skjermbildet for FAQ-egenskaper -screenshot][img5]

1. Rediger saksnavnet i feltet **Navn** om nødvendig.

1. I feltet **Posisjon** velger du et nummer for oppføringens plassering i sorteringsrekkefølgen til mappen den tilhører. 1 betyr øverst på listen.

1. I **Mappe**-feltet velger du hvilken mappe du vil plassere oppføringen i (hvis du har en [mappestruktur for FAQ-oppføringer][2]).

1. I feltet **Tilgang** velger du hvem som skal ha tilgang til den aktuelle FAQ-oppføringen:

    * **Privat**: Bare deg. Dette kan være relevant hvis du oppretter nye FAQ-oppføringer eller oppdaterer utdaterte FAQ-oppføringer.
    * **Tilgjengelig for interne brukere**: Kun interne brukere (og ikke kunder som bruker SuperOffice Kundesenter).
    * **Tilgjengelig for registrerte kunder**: Registrerte kunder som har påloggingstilgang til SuperOffice Kundesenter.
    * **Tilgjengelig for alle**: Alle (krever ikke pålogging for å lese FAQ).

1. I feltet **Nøkkelord** kan du skrive inn nøkkelord (bruk mellomrom eller komma som skilletegn) for oppføringen. Pass på at du bare skriver inn nøkkelord som er relevante for oppføringen. Nøkkelord gjør det lettere å finne den ønskede oppføringen. I tillegg brukes nøkkelord til automatisk å foreslå FAQ-oppføringer som samsvarer med en henvendelse fra en kunde.

1. Som FAQ-administrator kan du velge mellom følgende alternativer i feltet **Arbeidsflyt**:

    * **Upublisert**: Velg dette alternativet dersom du ikke vil publisere FAQ-oppføringen akkurat nå.
    * **Publisert**: Velg dette alternativet for å [publisere FAQ-oppføringen umiddelbart][3].
    * **Utløpt**: Velg dette alternativet hvis FAQ-oppføringen ikke lenger er aktuell. Relevant når du redigerer eksisterende FAQ-oppføringer.

    > [!NOTE]
    > Listen inneholder også eventuelle egendefinerte trinn i arbeidsflyten som er lagt inn i systemet.

1. Hvis du velger en dato i feltet **Gyldig til**, endres oppføringens status til **Utløpt** på denne datoen. Etter det vil den ikke være tilgjengelig for andre enn FAQ-administratorene. De vil bli advart om at oppføringen er utløpt. Dette kan være aktuelt i forbindelse med markedsføringskampanjer. Hvis du ikke angir noen dato her, betyr det at FAQ-oppføringen alltid vil være tilgjengelig.

1. **I Vedlegg**-feltet kan du legge til ett eller flere dokumenter som vedlegg til saken:

    1. Klikk på **Velg fil** ved siden av **Vedlegg**.
    2. I dialogboksen blar du til dokumentet du trenger.
    3. Klikk på **+** for å legge til vedlegget.
    4. Gjenta denne fremgangsmåten hvis du vil legge til flere vedlegg.

1. I **Kobling**-feltet kan du legge til en eller flere adresser til relevante nettsteder:

    1. I feltet til venstre skriver du inn navnet som skal vises for koblingen.
    2. I feltet til høyre skriver du inn den aktuelle webadressen etter `http://`
    3. Klikk på **+** for å legge til koblingen.
    4. Gjenta denne fremgangsmåten hvis du vil legge til flere koblinger.

1. Gå til fanen **Spørsmål**.

1. Skriv inn spørsmålet du vil at FAQ-oppføringen skal inneholde. Som standard limes den første meldingen i saken inn i fanen **Spørsmål**.

    > [!TIP]
    > Klikk på **Formater skrifttype**-knappen (<i class="ph ph-text-a-underline" aria-hidden="true"></i>) for å endre oppsettet til teksten.

1. Gå til fanen **Svar**, og skriv inn svaret. Som standard limes de neste meldingene i saken inn i fanen **Svar**.

1. Hvis du har mer enn ett [språk][6], må du velge de forskjellige **språkene** i bunnteksten og gjenta trinnene for **Spørsmål** og **svar**.

1. Klikk på **OK** når du er ferdig. Skjermbildet**FAQ-oppføring** vises, og forslaget til FAQ-oppføring sendes til administratoren, som kan publisere den.

## Opprette ny FAQ

1. Gå til <i class="ph ph-list" aria-label="Main menu"></i> i toppraden og velg **Kunnskapsbase** > **FAQ**.

1. Gå til mappen du vil plassere FAQ-oppføringen i. Hvis den ikke finnes ennå, kan du [opprette en ny mappe][2].

1. Klikk på knappen **Ny oppføring**. Du kommer til skjermbildet **Egenskaper for FAQ-oppføring**.

    ![FAQ-skjermen -screenshot][img3]

1. Følg fremgangsmåten ovenfor fra og med **trinn 3**.

Fordi alternativet for å opprette FAQ-oppføringer på denne måten bare er tilgjengelig for **administratorer**, er det ikke behov for et eget publiseringstrinn, i denne prosessen. Administratoren kan opprette og publisere samtidig.

## Hva vil du gjøre nå?

* [Redigere FAQ-oppføringer][4]
* [Legge til FAQ i en melding][5]
* [Konfigurere flere språk][6]

<!-- Referenced links -->
[1]: ../../request/learn/index.md#open
[2]: manage-folders.md
[3]: publish.md
[4]: edit.md
[5]: add-to-request.md
[6]: ../../admin/options/learn/custlang/index.md

<!-- Referenced images -->
[img3]: ../../../media/loc/en/faq/create-publish-faq.png
[img5]: ../../../media/loc/en/faq/faq-create.png
