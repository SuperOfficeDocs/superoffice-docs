---
uid: help-da-erp-configure
title: Konfigurere ERP-link
description: Konfigurer synkronisering mellem SuperOffice CRM og dit ERP-system ved at tilknytte felter, angive standardværdier og prioritere ERP-links.
keywords: ERP-link, konfigurere synk, felttilknytning, listetilknytning, standardværdier, ranger ERP-felter, angiv synkprioritet, rediger ERP-link, SuperOffice ERP-integration, ERP-fanen, sync connector
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
redirect_from:
  - /da/quote/learn/admin/sync/sync-configure-default-values
  - /da/quote/learn/admin/sync/sync-configure-field-allocation
  - /da/quote/learn/admin/sync/sync-configure-list-mapping
  - /da/quote/learn/admin/sync/sync-rank-fields-shown-in-erp-tab
  - /da/quote/learn/admin/sync/sync-set-sync-priority
index: true
---

# Konfigurere ERP-link

Når du har tilføjet et ERP-link, skal du konfigurere, hvordan data synkroniseres mellem SuperOffice og ERP-systemet. Dette gør du ved hjælp af knapperne nederst på fanen **Sync** i skærmbilledet Tilbud/Sync.

![ERP-links vist i Sync-fanen med tilvalg nedenfor -screenshot][img1]

## Felttilknytning

Felttilknytninger definerer, hvordan ERP-felter svarer til SuperOffice-felter, og hvordan data flyder mellem systemerne. De tilgængelige ERP-aktører og -felter leveres af sync connectoren og kan variere afhængigt af ERP-systemet. Ud over at angive synkroniseringsretning kan du vælge, hvilke felter der skal vises i søgevinduet og på fanen **ERP** i SuperOffice CRM.

1. Markér ERP-linket, og klik på **Tilknytninger** nederst i venstre hjørne.

    Dialogboksen **Tilknytninger** åbnes og viser faner for de tilgængelige ERP-aktører (som Kunde, Leverandør, Person eller Projekt).

1. Vælg fanen for den aktør, du vil konfigurere.

1. Marker **Synkroniser ERP "\[aktør\]" med SuperOffice "\[enhed\]"** for at aktivere synkronisering.

1. For hvert ERP-felt på listen skal du angive:

    * **SuperOffice-felt:** Vælg det felt i SuperOffice, som ERP-feltet skal knyttes til.
    * **Retning:** Angiv synkroniseringsretning. Brug **&gt;** for ERP til SuperOffice, **&lt;** for SuperOffice til ERP, eller **&lt; &gt;** for tovejssynkronisering.

        Retningsknapper har tre tilstande:
        * **Grå:** Deaktiveret. Du skal først vælge et SuperOffice-felt.
        * **Hvid:** Aktiveret, men ikke valgt.
        * **Blå:** Valgt.

    * **Vis i søgning:** Marker for at vise dette felt i søgeresultater.
    * **Vis på ERP-fanen:** Marker for at vise dette felt på fanen **ERP** i SuperOffice CRM (Firma, Person og Projekt).

        Hvis et felt synkroniseres, er det som regel ikke nødvendigt at vise det på ERP-fanen.

    ![Konfigurer felttilknytning til ERP -screenshot][img2]

1. Gentag for andre aktører efter behov.

1. Klik på **Udfør**, når du er færdig.

Du kan nu fortsætte med listetilknytning, standardværdier eller felt-rangering – *eller* aktivere linket, hvis der ikke er behov for yderligere konfiguration.

## <a id="list-mapping"></a>Listetilknytning

Hvis du har tilknyttet lister, såsom kategori eller status, skal du også knytte de enkelte elementer i listerne mellem ERP-systemet og SuperOffice.

1. Markér ERP-linket, og klik på **Listetilknytning** nederst i venstre hjørne.

1. Vælg en liste i dialogboksen. De tilsvarende ERP- og CRM-elementer vises.

    Hvis der ikke vises nogen lister, skal du kontrollere, at de relaterede felter blev tilknyttet i **Felttilknytning**.

1. Vælg det tilsvarende CRM-element for hvert ERP-element.

    Hvert ERP-element kan kun knyttes til ét CRM-element. Dobbelt tildeling vises med rød markering. Hvis du ikke ønsker at knytte et ERP-element, skal du vælge **(Ingen markering)**.

1. Gentag for alle relevante lister.

1. Klik på **Gem**, og aktiver ERP-linket, hvis du er færdig med konfigurationen.

## <a id="defaults"></a>Standardværdier for synkronisering

Standardværdier hjælper med at reducere manuel dataindtastning for felter, som typisk har en fast eller forudsigelig værdi. Dette er især nyttigt ved masseimport eller hvis brugerne ikke skal angive den samme værdi gentagne gange – eller markere et felt, der altid skal være valgt.

1. Markér ERP-linket, og klik på **Standardværdier** nederst i venstre hjørne.

1. I dialogboksen skal du vælge fanen for den aktør, du vil konfigurere.

    ![Konfigurer standardværdier for synkronisering -screenshot][img3]

1. Klik på **Tilføj** for at oprette en ny standard. Dialogboksen **Tilføj synkroniseringsstandardværdi** åbnes.

1. I dialogboksen:

    * **ERP-felt:** Vælg det felt, du vil angive en standard for.

    Vælg derefter, hvordan feltet skal fungere:

    * **Angiv standardværdi:** Anvend automatisk en specifik værdi under synkronisering. Denne mulighed kræver, at du indtaster en værdi.
    * **Bed brugeren om værdi:** Brugeren kan manuelt indtaste en værdi.
    * **Obligatorisk – Brugeren skal udfylde værdi:** En værdi skal angives. Hvis dette er valgt, skal du også vælge en af de to muligheder ovenfor.

    ![Tilføj synkroniseringsstandardværdi -screenshot][img4]

1. Klik på **OK** for at gemme.

1. Gentag efter behov for at tilføje flere standardværdier.

## <a id="rank"></a>Rangér felter, der vises på ERP-fanen

Angiv rækkefølgen for de felter, der vises på fanen **ERP** i skærmbillederne Firma, Person og Projekt. Alle tilgængelige felter vises her, men kun de markerede vil blive vist på fanen.

1. Markér ERP-linket, og klik på **Ranger felter** nederst i venstre hjørne.

1. I dialogboksen, vælg fanen for den aktør, du vil konfigurere.

    Alle tilgængelige felter vises – både de, der er markeret til visning på ERP-fanen, og de, der ikke er.

    ![Rangér felter vist på ERP-fanen -screenshot][img5]

1. Vælg et felt, og brug <i class="ph ph-arrow-circle-up" aria-label="Pil op"></i> og <i class="ph ph-arrow-circle-down" aria-label="Pil ned"></i> for at ændre placeringen i listen.

1. Gentag for andre aktører efter behov.

1. Klik på **Udført** for at gemme ændringerne.

## <a id="priority"></a>Angiv synkroniseringsprioritet

Hvis der er flere ERP-links aktive samtidigt, kan du definere, hvilket link der skal have prioritet ved høj databelastning.

1. Klik på **Angiv synkroniseringsprioritet** under listen **ERP-links**.

1. I dialogboksen, vælg det ERP-link, du vil prioritere.

1. Brug <i class="ph ph-arrow-circle-up" aria-label="Pil op"></i> og <i class="ph ph-arrow-circle-down" aria-label="Pil ned"></i> til at flytte det valgte link op eller ned i prioriteringslisten.

1. Klik på **Udført** for at gemme.

## Fejlfinding

### Kan ikke aktivere ERP-link

Hvis ERP-linket ikke kan aktiveres, skal du kontrollere felttilknytningen:

* Obligatoriske felter skal have en angivet synkroniseringsretning.
* Eventuelle konfigurationsfejl udløser en forklarende fejlmeddelelse.
* Du skal rette fejlen, før du kan aktivere linket.

### Synkroniseringspile er ikke tilgængelige

Hvis retningspile forbliver nedtonede, selv efter at du har valgt et SuperOffice-felt, kan det skyldes:

* Feltet kan ikke synkroniseres (for eksempel et ID-felt eller skrivebeskyttede data).
* Feltet er ikke gyldigt for den valgte ERP-aktør.

Hold musen over pilen for at se en forklarende besked.

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: ../../../media/loc/en/erp/erp-connection-settings.png
[img2]: ../../../media/loc/en/erp/configure-field-mapping.png
[img3]: ../../../media/loc/en/erp/list-of-default-values.png
[img4]: ../../../media/loc/en/erp/add-sync-default-value.png
[img5]: ../../../media/loc/en/erp/rank-fields.png
