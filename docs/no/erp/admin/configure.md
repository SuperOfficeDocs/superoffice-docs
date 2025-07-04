---
uid: help-no-erp-configure
title: Konfigurere ERP-kobling
description: Konfigurer synkronisering mellom SuperOffice CRM og ERP-systemet ved å tilordne felter, angi standardverdier og prioritere ERP-koblinger.
keywords: ERP-kobling, konfigurere synk, felttilordning, listetilordning, standardverdier, ranger ERP-felter, angi synkprioritet, redigere ERP-kobling, SuperOffice ERP-integrasjon, ERP-fane, sync connector
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Innstillinger og vedlikehold
language: no
redirect_from:
  - /no/quote/learn/admin/sync/sync-configure-default-values
  - /no/quote/learn/admin/sync/sync-configure-field-allocation
  - /no/quote/learn/admin/sync/sync-configure-list-mapping
  - /no/quote/learn/admin/sync/sync-rank-fields-shown-in-erp-tab
  - /no/quote/learn/admin/sync/sync-set-sync-priority
index: true
---

# Konfigurere ERP-kobling

Når du har lagt til en ERP-kobling, må du konfigurere hvordan data skal synkroniseres mellom SuperOffice og ERP-systemet. Dette gjør du ved å bruke knappene nederst på fanen **Sync** i bildet Tilbud/Sync.

![ERP-koblinger vist i Sync-fanen med alternativer nederst -screenshot][img1]

## Felttilordning

Felttilordning definerer hvordan ERP-felter tilsvarer SuperOffice-felter, og hvordan data flyter mellom systemene. De tilgjengelige ERP-aktørene og feltene leveres av sync connectoren og kan variere avhengig av ERP-systemet. I tillegg til å angi synkroniseringsretning, kan du velge hvilke felt som skal vises i søkevinduet og i **ERP**-fanen i SuperOffice CRM.

1. Velg ERP-koblingen og klikk på **Tilordninger** nederst i venstre hjørne.

    Dialogboksen **Tilordninger** åpnes og viser faner for tilgjengelige ERP-aktører (som Kunde, Leverandør, Person eller Prosjekt).

1. Velg fanen for aktøren du vil konfigurere.

1. Merk av for **Synkroniser ERP "[aktør]" med SuperOffice "[enhet]"** for å aktivere synkronisering.

1. For hvert ERP-felt i listen angir du:

    * **SuperOffice-felt:** Velg hvilket felt i SuperOffice ERP-feltet skal knyttes til.
    * **Retning:** Angi synkretningen. Bruk **&gt;** for ERP til SuperOffice, **&lt;** for SuperOffice til ERP, eller **&lt; &gt;** for toveis synkronisering.

        Retningsknappene har tre tilstander:
        * **Grå:** Deaktivert. Du må først velge et SuperOffice-felt.
        * **Hvit:** Aktiv, men ikke valgt.
        * **Blå:** Valgt.

    * **Vis i søk:** Marker for å vise dette feltet i søkeresultater.
    * **Vis i ERP-fane:** Marker for å vise dette feltet i **ERP**-fanen i SuperOffice CRM (Firma, Person og Prosjekt).

        Hvis et felt er satt opp for synkronisering, er det som regel ikke nødvendig å vise det i ERP-fanen.

    ![Konfigurer ERP-felttilordning -screenshot][img2]

1. Gjenta for andre aktører etter behov.

1. Klikk på **Fullført** når du er ferdig.

Du kan nå fortsette med listetilordning, standardverdier eller rangering av felter – *eller* aktivere koblingen hvis ingen videre konfigurasjon er nødvendig.

## <a id="list-mapping"></a>Listetilordning

Hvis du har tilordnet listefelt, som kategori eller status, må du også knytte de enkelte elementene i listene mellom ERP-systemet og SuperOffice.

1. Velg ERP-koblingen og klikk på **Listetilordning** nederst i venstre hjørne.

1. I dialogboksen velger du en liste. Tilsvarende ERP- og CRM-elementer vises.

    Hvis det ikke vises noen lister, må du kontrollere at de relevante feltene ble tilordnet i **Felttilordning**-dialogen.

1. For hvert ERP-element velger du det tilsvarende CRM-elementet.

    Hvert ERP-element kan bare knyttes til ett CRM-element. Duplikater vises i rødt. For å la et ERP-element stå uten tilordning, velger du **(Ingen utvalg)**.

1. Gjenta for alle relevante lister.

1. Klikk på **Lagre**, og aktiver ERP-koblingen hvis ingen ytterligere konfigurasjon er nødvendig.

## <a id="defaults"></a>Standardverdier for synkronisering

Standardverdier bidrar til å redusere manuell registrering av data for felt som vanligvis har en fast eller forutsigbar verdi. Dette er spesielt nyttig ved import av store datamengder eller hvis brukerne ikke skal måtte angi samme verdi gjentatte ganger eller merke av et felt som alltid skal være valgt.

1. Velg ERP-koblingen og klikk på **Standardverdier** nederst i venstre hjørne.

1. I dialogboksen velger du fanen for aktøren du vil konfigurere.

    ![Konfigurer standardverdier for synkronisering -screenshot][img3]

1. Klikk på **Legg til** for å definere en ny standard. Dialogboksen **Legg til standardverdi for synkronisering** åpnes.

1. I dialogboksen:

    * **ERP-felt:** Velg hvilket felt du vil definere en standardverdi for.

    Deretter velger du hvordan feltet skal håndteres:

    * **Angi standardverdi:** Bruk alltid en spesifikk verdi under synkronisering. Dette krever at du angir en verdi.
    * **Spør bruker om verdi:** Tillat brukeren å fylle inn en verdi manuelt.
    * **Påkrevd – bruker må fylle inn verdi:** Feltet må ha en verdi. Hvis du velger dette, må du også angi en av de to alternativene ovenfor.

    ![Legg til standardverdi for synkronisering -screenshot][img4]

1. Klikk på **OK** for å lagre.

1. Gjenta ved behov for å legge til flere standardverdier.

## <a id="rank"></a>Rangere felter som vises i ERP-fanen

Angi rekkefølgen på feltene som vises i **ERP**-fanen i bildene Firma, Person og Prosjekt. Alle tilgjengelige felt listes opp her, men kun de som er markert for visning vil vises i fanen.

1. Velg ERP-koblingen og klikk på **Ranger felt** nederst i venstre hjørne.

1. I dialogboksen velger du fanen for den aktøren du vil konfigurere.

    Alle tilgjengelige felt vises, inkludert de som ikke er merket for visning i **ERP**-fanen.

    ![Ranger felter vist i ERP-fanen -screenshot][img5]

1. Velg et felt og bruk <i class="ph ph-arrow-circle-up" aria-label="Pil opp"></i> og <i class="ph ph-arrow-circle-down" aria-label="Pil ned"></i> for å endre plasseringen i listen.

1. Gjenta for andre aktører etter behov.

1. Klikk på **Fullført** for å lagre endringene.

## <a id="priority"></a>Angi synkroniseringsprioritet

Hvis flere ERP-koblinger er aktive samtidig, kan du definere hvilken kobling som skal ha prioritet ved høy datatrafikk.

1. Klikk på **Angi synkroniseringsprioritet** under listen **ERP-koblinger**.

1. I dialogboksen velger du en kobling.

1. Bruk <i class="ph ph-arrow-circle-up" aria-label="Pil opp"></i> og <i class="ph ph-arrow-circle-down" aria-label="Pil ned"></i> for å flytte koblingen opp eller ned i listen.

1. Klikk på **Fullført** for å lagre endringene.

## Feilsøking

### Kan ikke aktivere ERP-kobling

Hvis ERP-koblingen ikke kan aktiveres, kontroller felttilordningen:

* Obligatoriske felt må ha en synkroniseringsretning.
* Eventuelle konfigurasjonsfeil vil gi en forklarende feilmelding.
* Du må rette feilene før koblingen kan aktiveres.

### Synkroniseringspiler er ikke tilgjengelige

Hvis retningspilene forblir nedtonet etter at du har valgt et SuperOffice-felt, kan det skyldes:

* Feltet kan ikke synkroniseres (for eksempel et ID-felt eller skrivebeskyttet data).
* Feltet er ikke gyldig for den valgte ERP-aktøren.

Hold musepekeren over pilen for å vise en forklaring.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../media/loc/en/erp/erp-connection-settings.png
[img2]: ../../../media/loc/en/erp/configure-field-mapping.png
[img3]: ../../../media/loc/en/erp/list-of-default-values.png
[img4]: ../../../media/loc/en/erp/add-sync-default-value.png
[img5]: ../../../media/loc/en/erp/rank-fields.png
