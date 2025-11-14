---
uid: help-no-form-publish
title: Publisere skjemaer
description: Publisere skjemaer
keywords: skjema, publiser, publisere skjema, aktivere skjema, forhåndsutfylling av felt, forhåndsutfylt felt, ferdigutfylt, feltidentifikator, skriptkode, UTM-bygger, legg til UTM-sporing
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: no
redirect_from: /no/marketing/forms/learn/form-prefilled
---

# Publisere skjemaer

Når du har opprettet et skjema og (eventuelt) svaret på skjemaet, kan du publisere skjemaet.

> [!NOTE]
> Fanen **Publiser** er et her-og-nå-arbeidsområde. Alle verdier du legger inn på denne siden – for eksempel forhåndsutfylte felt eller UTM-parametere – brukes bare til å generere lenken eller skriptet du kopierer nå.
> SuperOffice lagrer **ikke** disse verdiene permanent. Hvis en annen bruker redigerer siden senere, blir dine tidligere verdier erstattet.

## Trinn

1. Gå til fanen **Skjemaer**.

1. Klikk på skjemaet for å åpne det i visningsmodus.

1. Sett skjemaet til **Aktiv** <i class="ph ph-toggle-right" aria-label="Toggle on"></i> i overskriften.

1. Gå til fanen **Publiser**.

1. Til venstre i bildet velger du et publiseringsalternativ for skjemaet:
    * **Direktekobling**: En direktekobling til skjemaet.
    * **Vis som innebygd skjema**: En skriptkode som brukes til å legge til skjemaet på en webside.
    * **Vis som popup**: En knapp for å åpne skjemaet i et popup-vindu på websiden.
    * **Vis som sidepanel**: Et sidepanel med en knapp for å skjule/vise skjemaet.

1. (valgfritt) I seksjonen **Forhåndsutfyll med kontaktpersondata** velger du ett eller flere felt som skal forhåndsutfylles med eksisterende kundedata fra SuperOffice.

1. Kopier koblingene/emneknaggene til et nyhetsbrev, webside eller kundesenter for å publisere dem til kundene eller potensielle kunder.

![Fanen Publiser i SuperOffice Marketing som viser hvordan du velger en publiseringsmetode og forhåndsutfyller skjemafelt med kontaktdata. -screenshot][img3]

## <a id="prefill"></a>Forhåndsutfylling av felt i skjemaer

Du kan forhåndsutfylle utvalgte skjemafelt med eksisterende kundedata fra SuperOffice for å spare besøkende tid når de sender inn et skjema.

Når du velger ett eller flere felt i seksjonen **Forhåndsutfyll med kontaktpersondata**, legger SuperOffice til de tilsvarende feltidentifikatorene og [malvariablene][7] i lenken eller skriptkoden.

Når skjemaet åpnes, fylles disse feltene automatisk ut med kundens lagrede informasjon.

En **feltidentifikator** er en unik ID for et spesifikt felt. Den endres ikke selv om feltnavnet, etiketten eller språket endres.

For eksempel:

```text
...form&id=F-Rg2nDAQI
```

blir til:

```text
...form&id=F-Rg2nDAQI&field_Email%3A=[[urlEncode(customer.email)]]
```

Dette sikrer at skjemaet dynamisk setter inn hver kontaktpersons e-postadresse når det åpnes via en personlig lenke.

> [!TIP]
> Feltidentifikatorer er stabile på tvers av språk og oppdateringer, så lenkene dine vil fortsette å fungere selv om skjemaet redigeres senere.

## <a id="utm"></a>Legg til UTM-sporing (Marketing Premium)

Den innebygde **UTM-byggeren** oppretter en skjemakoblingen med [UTM-parametere][4], slik at SuperOffice kan registrere hvor leadene dine kommer fra når en besøkende sender inn skjemaet.

### Forutsetninger og begrensninger

* Du har en **Marketing Premium**-brukerplan.
* En administrator har [aktivert overføring av UTM-data for skjemainnleveringer][6].
* UTM-sporing er bare tilgjengelig for alternativet **Direktekobling**. Den gjelder ikke for innebygde skjemaer.

### Trinn

1. I fanen **Publiser**, velg **Direktekobling** som publiseringsalternativ.

1. I seksjonen **Legg til UTM-sporing**, angi én eller flere UTM-verdier, for eksempel **kilde**, **medium** og **kampanje**.

    For eksempel:

    ```text
    ...form&id=F-Rg2nDAQI
    ```

    blir til:

    ```text
    ...formId=F-Rg2nDAQI&utm_source=linkedin&utm_campaign=rebranding
    ```

    ![Feltene for Legg til UTM-sporing i skjemaets publiseringsvisning -screenshot][img4]

    For detaljer om hver parameter og navngivningskonvensjoner, se [UTM-parametere][4].

1. Kopier den genererte koblingen fra feltet nedenfor.

1. Lim inn koblingen i annonsen, e-posten eller innlegget på sosiale medier.

> [!TIP]
> Kopier og lagre alltid koblingen med en gang etter at du har opprettet den. Eventuelle endringer i feltene senere vil generere en ny koblingen.

## Hva skjer nå?

Et varsel på fanen **Skjemainnsendinger** indikerer at du har [mottatt skjemainnsendinger][2], som kanskje må [behandles manuelt][3].

Skjemaer kan deaktiveres manuelt, eller deaktiveres automatisk på en bestemt dato eller når et bestemt antall innsendelser er mottatt.

## Relatert innhold

* [Oversikt over konverteringssporing][5]
* [Konfigurer UTM-sporing][6] - i Innstillinger og vedlikehold

<!-- Referenced links -->
[2]: view-statistics.md
[3]: process-submissions.md
[4]: ../../utm/learn/parameters.md
[5]: ../../utm/learn/index.md
[6]: ../../utm/admin/set-up.md
[7]: ../../../knowledge-base/learn/reply-templates/template-variables.md

<!-- Referenced images -->
[img3]: ../../../../media/loc/en/marketing/form-publish.png
[img4]: ../../../../media/loc/en/marketing/utm-builder.png
