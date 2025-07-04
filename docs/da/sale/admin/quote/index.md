---
uid: help-da-quote-admin
title: Administrer tilbuds- og ordreopsætning
description: Lær, hvordan tilbud, Quote Connectors og ERP-integration fungerer i SuperOffice CRM, og hvordan du konfigurerer det i skærmbilledet Tilbud/Sync.
keywords: quote connector, ERP-link, tilbudsindstillinger, prisliste, produkt, Tilbud/Sync, ERP-opsætning, quote connector-indstillinger, tilbudsintegration, salgsopsætning, tilbud, sync
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: concept
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: da
redirect_from:
  - /da/quote/learn/admin/index
  - /da/quote/learn/admin/quotesync-tab-erp-connections
  - /da/quote/learn/admin/quotesync-tab-settings
index: true
---

# Administrer tilbuds- og ordreopsætning

Skærmbilledet **Tilbud/Sync** i Indstillinger og vedligeholdelse er det sted, hvor du konfigurerer alt, hvad der er nødvendigt for at aktivere tilbud og ordrer i SuperOffice CRM.

> [!NOTE]
> Denne funktion kræver brugerplanen **Sales Premium**.

## Produkter og prislister

Hvert tilbud i SuperOffice indeholder ét eller flere produkter, og hvert produkt skal tilknyttes en **prisliste**.

Du kan håndtere produkter og priser på to måder i SuperOffice CRM:

* **Manuelt**, ved at bruge det indbyggede produktregister i SuperOffice, også kendt som **SuperOffice Standalone connector**.

* **Automatisk**, ved at hente produktdata fra et eksternt **ERP-system**.

## Quote Connectors og ERP-links

For at hente produktdata og beregne priser bruger SuperOffice **Quote Connectors** og **ERP-links**.

En **Quote Connector** er et plug-in (webtjeneste eller DLL), der håndterer integrationen. Den kommunikerer med et specifikt ERP- eller produktsystem og udfører opgaver som:

* Henter produkt- og prisdata
* Validerer rabatter
* Beregner totaler og moms
* Sender accepterede tilbud som ordrer

En **Quote Connector fungerer ikke alene** – den skal konfigureres. For at aktivere den skal du oprette et **ERP-link**, som kombinerer connectoren med:

* Adgangskontrol (hvem må bruge den)
* Autentificerings- eller endpoint-indstillinger
* Adfærdsregler såsom afrunding, advarsler og godkendelseslogik

Tænk på det sådan her: **ERP-link = Quote Connector + konfiguration**

Du kan oprette flere ERP-links for den samme connector. Det kan f.eks. være nødvendigt, hvis din organisation bruger forskellige indstillinger afhængigt af marked eller brugergruppe.

> [!TIP]
> Alle ERP-links administreres via fanen **ERP-links** i skærmbilledet **Tilbud/Sync**.

### SuperOffice Standalone connector

Dette er standardopsætningen, hvis der ikke er tilknyttet et ERP-system. Det er velegnet til enkle behov eller når produktdata ikke vedligeholdes andetsteds. Alle produktdata gemmes og administreres direkte i SuperOffice:

* [Definér prislister og tilføj produkter manuelt][2]
* Brug den indbyggede beregningsmotor
* Understøtter ikke automatisk ordreafsendelse

> [!NOTE]
> Et ERP-link er stadig påkrævet, men det er lokalt i SuperOffice og opretter ikke forbindelse til et eksternt system.

### ERP-baseret tilbudshåndtering

Når SuperOffice er integreret med et ERP-system, henter Quote Connector produkt- og prisinformation direkte fra ERP:

* Produkter hentes i realtid (gemmes ikke i SuperOffice)
* Priser og rabatter følger ERP-regler
* Accepterede tilbud kan automatisk oprette ordrer i ERP

## <a id="tabs"></a>Faner i Tilbud/Sync-skærmbilledet

Skærmbilledet Tilbud/Sync har fire faner, der bruges til at konfigurere tilbud, produkter og ERP-integration.

### ERP-links

Bruges til at administrere ERP-links for Quote Connectors.

* Viser alle tilgængelige Quote Connectors (indlæses automatisk efter installation). Hold musemarkøren over en række for at få vist detaljer.
* Viser aktive ERP-links.
* Dobbeltklik på et link for at redigere indstillinger som synlighed, adfærd og valideringsregler.
* Vælg et ERP-link i listen, og klik på **Test ERP-linket** for at kontrollere forbindelsen.

> [!TIP]
> Se [Sådan opsættes et ERP-link][1] for trinvise instruktioner.

### SuperOffice-produkter

Bruges til at administrere [prislister og produkter][2], der gemmes i SuperOffice (hvis Standalone connector bruges). Disse gemmes i SuperOffice-databasen, ikke i et ERP-system.

Du kan:

* Tilføje, redigere og slette prislister.
* Tilføje eller fjerne produkter i hver liste. Dobbeltklik på et produkt for at redigere det.
* Konfigurere produktoplysninger såsom kostpris, moms og fortjeneste.
* Vælge miniaturebilleder til visning i tilbudsdialogen.

### Indstillinger

Bruges til at konfigurere globale tilbudsindstillinger og [layoutet for produktdialogen][3].

* **Brug rabat på samlet værdi:** Aktiverer et valgfrit felt, hvor der kan angives rabat på den samlede tilbudsværdi (procent eller beløb). To rabatfelter vises derefter nederst i fanen **Produkter** i dialogboksen **Rediger tilbud**.

    > [!NOTE]
    > Rabatten anvendes ud over de rabatter, der allerede er tilføjet de enkelte produkter.

* **Standardtekst til opfølgning:** Angiv standardteksten for den opfølgning, der oprettes, når tilbuddet sendes.

* **Åbne salgstyper:** Åbner listen **Salg - Type, Faser, Tilbud**, hvor regler for tilbud fastlægges. Hvert salg i SuperOffice skal have en [salgstype][5], og mange standardegenskaber for et tilbud hentes fra salgstypen. Det gælder f.eks. brug af alternativer, tilbudsskabeloner, gyldighed og godkendelseskrav.

Under **Produktfelter** kan du vælge, hvilke felter der vises, når brugere tilføjer/redigerer produkter.

### Sync

Bruges til at [tilføje Sync Connectors og konfigurere ERP-links][4] til synkronisering af firmaer, personer og projekter. Denne fane er kun relevant, hvis du planlægger at synkronisere CRM-data med ERP-aktører.

## Relateret indhold

* [Sådan opsættes et ERP-link][1]
* [Tilføj prislister og produkter][2]
* [Tilpas tilbudsvisningen][3]
* [Administrer ERP-synkronisering][4]

<!-- Referenced links -->
[1]: set-up-quote-connector.md
[2]: price-list-and-products.md
[3]: configure-product-fields.md
[4]: ../../../erp/admin/index.md
[5]: ../sale-type.md
