---
uid: help-da-form-publish
title: Udgiv formularer
description: Udgiv formularer
keywords: formular, udgiv, udgiv formular, forudfyldt, forudfyldte felt, felt-id, feltidentifikator, scripttag, UTM-builder, tilføj UTM-sporing
author: digitaldiina
date: 11.06.2025
version: 11.6
content_type: howto
category: marketing
topic: forms
license: marketingessentials
audience: person
audience_tooltip: SuperOffice Marketing
language: da
redirect_from: /da/marketing/forms/learn/form-prefilled
---

# Udgiv formularer

Når du har oprettet formularen og (hvis relevant) formularsvaret, kan du udgive formularen.

> [!NOTE]
> Fanen **Udgiv** er et her-og-nu-arbejdsområde. Alle værdier, du indtaster på denne side – for eksempel forudfyldte felter eller UTM-parametre – bruges kun til at generere det link eller script, du kopierer nu.
> SuperOffice gemmer **ikke** disse værdier permanent. Hvis en anden bruger redigerer siden senere, bliver dine tidligere værdier erstattet.

## Trin

1. Gå til fanen **Formularer**.

1. Klik på formularen for at åbne den i visningstilstand.

1. Indstil formularen til **Aktiv** <i class="ph ph-toggle-right" aria-label="Toggle on"></i> i sidehovedet.

1. Gå til fanen **Udgiv**.

1. Vælg en udgivelsesindstilling for formularen på venstre side af skærmen:

    * **Direkte link**: Et direkte link til formularen.
    * **Integrer inline**: Et scripttag, der bruges til at tilføje formularen på en webside.
    * **Integrer som popup**: En knap til at åbne formularen i et pop op-vindue på websiden.
    * **Integrer som sidefane**: En sidefane med en knap til at skjule/vise formularen.

1. (valgfrit) I sektionen **Forudfyld med personoplysninger** skal du vælge et eller flere felter, der skal udfyldes automatisk med eksisterende kundedata fra SuperOffice.

1. Kopier links/tags ind i et nyhedsbrev, website eller kundecenter for at udgive det til dine kunder eller kundeemner.

![Fanen Udgiv i SuperOffice Marketing, der viser, hvordan du vælger en udgivelsesmulighed og forududfylder formularfelter med kontaktdata. -screenshot][img3]

## <a id="prefill"></a>Forudfyldning af felter i formularer

Du kan forudfylde udvalgte formularfelter med eksisterende kundedata fra SuperOffice for at spare besøgende tid, når de indsender en formular.

Når du vælger et eller flere felter i sektionen **Forudfyld med personoplysninger**, tilføjer SuperOffice de tilsvarende felt-ID'er og [skabelonvariabler][7] til linket eller script-tagget.

Når formularen åbnes, udfyldes disse felter automatisk med kundens gemte oplysninger.

Et **felt-ID** er en unik identifikator for et bestemt felt. Det ændres ikke, selvom feltnavnet, etiketten eller sproget ændres.

For eksempel:

```text
...form&id=F-Rg2nDAQI
```

bliver til:

```text
...form&id=F-Rg2nDAQI&field_Email%3A=[[urlEncode(customer.email)]]
```

Dette sikrer, at formularen dynamisk indsætter hver kontaktpersons e-mailadresse, når den åbnes via et personligt link.

> [!TIP]
> Felt-ID'er er stabile på tværs af sprog og opdateringer, så dine links vil fortsætte med at fungere, selv hvis formularen redigeres senere.

## <a id="utm"></a>Tilføj UTM-sporing (Marketing Premium)

Den indbyggede **UTM-builder** opretter et formularlink med [UTM-parametre][4], så SuperOffice kan registrere, hvor dine leads kommer fra, når en besøgende sender formularen.

### Forudsætninger og begrænsninger

* Du har en **Marketing Premium**-brugerplan.
* En administrator har [aktiveret overførsel af UTM-data for formularindsendelser][6].
* UTM-sporing er kun tilgængelig for indstillingen **Direkte link**. Den gælder ikke for indlejrede formularer.

### Trin

1. Vælg **Direkte link** som udgivelsesmulighed under fanen **Publicer**.

1. I afsnittet **Tilføj UTM-sporing** skal du angive en eller flere UTM-værdier, for eksempel **kilde**, **medie** og **kampagne**.

    For eksempel:

    ```text
    ...form&id=F-Rg2nDAQI
    ```

    bliver til:

    ```text
   ...formId=F-Rg2nDAQI&utm_source=linkedin&utm_campaign=rebranding
    ```

    ![Felter til Tilføj UTM-sporing i visningen Udgiv formular -screenshot][img4]

    Du kan finde flere oplysninger om hver parameter og navngivningskonventioner under [UTM-parametre][4].

1. Kopiér det genererede link fra feltet nedenfor.

1. Indsæt linket i din annonce, e-mail eller dit opslag på sociale medier.

> [!TIP]
> Kopiér og gem altid linket med det samme, når du har oprettet det. Eventuelle senere ændringer i felterne vil generere et andet link.

## Hvad sker der så nu?

En meddelelse på fanen **Formularindsendelser** angiver, at du har [modtaget formularindsendelser][2], som muligvis skal [behandles manuelt][3].

Formularer kan deaktiveres manuelt eller deaktiveres automatisk på en bestemt dato eller når et bestemt antal indsendelser modtages.

## Relateret indhold

* [Oversigt over konverteringssporing][5]
* [Opsæt UTM-sporing][6] - i Indstillinger og vedligeholdelse

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
