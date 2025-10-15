---
uid: help-da-ui-web-panels
title: Webpaneler
description: Webpaneler
keywords: webpanel, www fane
author: digitaldiina
date: 10.13.2025
version: 11.5
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: customization
topic: web panel
language: da
index: true
redirect_from: 
  - /da/ui/web-panels/learn/index
  - /da/admin/lists/learn/web-panel
---

# Webpaneler

Et **webpanel** er et konfigurerbart område inden for SuperOffice CRM, der viser indhold fra en webside eller intern ressource baseret på en URL. Dette giver dig mulighed for at integrere eksterne datakilder eller interne værktøjer direkte i SuperOffice.

Webpaneler kan vises på forskellige placeringer og er tilpasset den kontekst, brugeren arbejder i, såsom et firmakort, en sag eller en opfølgning.

## Indholdstyper understøttet af webpaneler

Webpaneler understøtter en række indholdstyper:

* **URL-adresser:** eksterne websider eller interne systemer
* **Skærmbilleder:** genveje til SuperOffice CRM-skærmbilleder
* **Udvalg:** genveje til udvalg
* **Scripts/makroer:** handlinger udløst via en knap eller menu

## Visningsplaceringer for webpaneler

**Visningsplaceringen** defineres, når du konfigurerer panelet. Dette styrer, hvor i SuperOffice panelet vises.

* **Sidepanel** – Vises i det sammenfoldelige panel på siden af mange CRM-skærmbilleder.
* **Værktøjslinje** – Tilføjer en knap til værktøjslinjen.
* **Navigatorknap** – Tilføjer en knap til hovedmenuen.
* **Paneler:**
  * **Firma-, Person-, Projekt-, Salgs- og Udvalgskort** – Tilføjer en genvej i **www**-fanen for hvert skærmbillede.
  * **Webpanel på SuperOffice-knap** – Åbnes fra SuperOffice-logoet (øverste venstre hjørne). Flere URL'er vises som faner til højre.
  * **Detaljekort (i Firma-, Person-, Projekt- og Salgsskærmbilleder)** – Tilføjer en separat fane, der åbner panelindholdet.
* **Dialogbokse:**
  * **Opfølgningsdialogboks** – Tilføjer en genvej i **www**-fanen af opfølgningsdialogboksen.
  * **Dokument-, Produkt- og Tilbudsdialogbokse** – Tilføjer en genvej i **www**-fanen af hver dialogboks.
* **Menuer:**
  * **Værktøjsmenu** – Vises under **Andre programmer** ved klik på **Værktøj**-knappen i Navigatoren.
  * **Vis-menu** – Vises i menuindstillingen **Andre programmer**.
* **Dashboard-ruder** – Tilgængelige i rudeindholdsudvælgeren for dashboard-widgets.

### I Service (forældet)

* Hovedskærmbillede
* Sagsskærmbillede
* Firmaskærmbillede
* Personskærmbillede
* Ekstra tabelpostskærmbillede

## <a id="www"></a>www-fanen

På steder som Firma, Person, Projekt og Salg vises webpaneler ofte under **www**-fanen.

Du kan omdøbe fanen i **Indstillinger og vedligeholdelse** > **Indstillinger** > **Etiketter**. For at flytte fanen inden for CRM-grænsefladen skal du bruge listen **GUI – Webpanel**.

### Åbn i nyt vindue

Alle indlejrede URL-adresser kan åbnes i et separat browservindue ved hjælp af **Åbn i nyt vindue**.

## Sådan fungerer webpaneler

Webpaneler indlæser dynamisk indhold baseret på CRM-kontekst og den URL, der er defineret for panelet:

1. En bruger åbner en post (for eksempel et firma).
1. Systemet beregner URL'en ved hjælp af tilgængelige skabelonvariabler.
    * For eksempel bliver `http://server/side.asp?id=<cuid>` til `http://server/side.asp?id=123`
1. Hvis den nye URL er anderledes end den forrige, sender systemet en ny anmodning.
1. Serveren svarer med den passende webside: den modtager URL'en, beregner siden ved hjælp af URL-parametre og returnerer resultatet.
1. Panelet gengiver websiden inden for SuperOffice CRM.

## Relateret indhold

* [Tilføj webpanel][1]
* [Opbygning af webpaneler][2]

<!-- Referenced links -->
[1]: add-web-panel.md
[2]: ../../../../en/customization/web-panels/dev/index.md

<!-- Referenced images -->