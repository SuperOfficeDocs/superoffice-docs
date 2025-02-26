---
uid: help-da-admin-primer
title: Oversigt
description: Introduktion til administration af SuperOffice.
keywords: admin, Indstillinger og vedligeholdelse
author: Bergfrid Dias
date: 02.21.2023
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---
# Oversigt

## Forberedelse af din CRM-implementering

Før du begynder at importere data og konfigurere systemet, foreslår vi, at du evaluerer, hvad du vil ændre i brugergrænsefladen. CRM-systemet skal understøtte dine forretningsprocesser og understøtte dine brugere samt forbedre rapporteringen i dit firma.

Forberedelse af implementeringen af CRM-systemet indebærer først og fremmest, at du overvejer dine planer og mål for dit CRM-initiativ og sikrer, at dit CRM-system understøtter disse mål.

Din rolle som administrator er afgørende her, fordi det er den vigtigste rolle i at gøre en CRM-implementering vellykket.

Når du planlægger din CRM-konfiguration, er det vigtigt at definere dine behov for datasegmentering. Du skal også skitsere, hvilke datafelter du skal spore i forskellige rapporter.

> [!NOTE]
> Du kan bruge alle de oplysninger, du registrerer i systemet, som søgekriterier, når du opretter målgrupper til opkaldslister eller udsendelser. Derfor bør du beslutte, hvilke kriterier du vil segmentere dine personer efter.

## Almindelige ting at redigere

* **Kategorier:** Det kan være en god idé at klassificere firmaer i hovedmålgrupper. Det kan f.eks. være kunde, kundeemne, leverandør, partner. (Hvis du vil redigere dem, skal du gå til Lister og redigere listen Kategori).

* **Branche:** Du kan redigere listen over brancher, du registrerer virksomheder i. Det kan være transport, IT, service, produktion og så videre. (Hvis du vil redigere brancherne, skal du gå til Lister og redigere listen Branche).

* **Interesser:** Under både firma og person kan du redigere listen for interesser. Det kan være forskellige kontotyper for firma og rolletyper for personerne.

* **Abonnementstype:** Alle personer i dit SuperOffice CRM kan have deres egen type abonnementer. Disse typer bruges meget, når du opretter udvalg og sender udsendelser.

Hvis du vil gennemgå vigtige overvejelser i forbindelse med konfigurationen, skal du [downloade dit konfigurationsforberedelsesdokument][2]. Når du har besvaret spørgsmålene i dokumentet, har du de oplysninger, du har brug for til at konfigurere dit system.

Når du har forberedt din CRM-implementering, er det tid til at oprette og [administrere dine CRM-brugere][1].

## Oprettelse af dine egne workflowguides

Workflowguides, f.eks [salgsguiden][4] og [projektguiden][5], hjælper brugerne med at bevare kontrollen og arbejde i overensstemmelse med bedste praksis.

Hjælp dine brugere med at bevare kontrollen over hvert trin i processen, sørg for, at alle projekter leveres til tiden, og at der følges op på alle salgsmuligheder. Uden en foruddefineret workflowguide er det let at miste kontrollen, især når man skal jonglere med flere projekter eller salg på samme tid. Du kan miste overblikket over de ting, der skal gøres i hver fase af dit projekt eller salg, og som følge heraf overskride din deadline.

Alle projekter og salgsmuligheder vil have en status, der angiver, hvor langt du er i din proces. En projektstatus kan f.eks. være "Planlagt", "Igangværende" og "Afsluttet". Og et salg kan være i fasen: "Prospekt", "Første møde", "Tilbud" eller "Mundtlig accept".

Hver status i din workflowguide indeholder de nødvendige opfølgningsaktiviteter og dokumenter, der guider brugeren gennem hele processen.

Du kan oprette en anden guide for hver type projekt eller salg, du bruger. Din guide vil være tilgængelig, når der oprettes et nyt salg eller projekt.

Når en af faserne i din guide er fuldført, spørger SuperOffice CRM automatisk om næste trin, så du kan planlægge din næste aktivitet med det samme. Det gør, at du bevarer kontrollen og ikke overser endnu en milepæl.

![Med projektguideskærmbilledet i Projekt får du nemt et overblik over projektets fremdrift. -screenshot][img1]

I sektionen Workflow kan du designe og implementere dine egne arbejdsgange til dine projekt- og salgsguider.

Når du opretter din egen guide, kan du bestemme statusserne samt de aktiviteter og dokumenter, du vil bruge pr. status.

Den bedste måde at definere dine egne projekt- eller salgsguider på er at diskutere og aftale din best practice-status med dine kolleger. Forskellige salg og projekter kan kræve en anden tilgang og måske en anden guide. Bare husk – du kan oprette flere guider til både salg og projekter.

## Mobile CRM

> [!NOTE]
> Hvis du vil ændre sproget i Mobile CRM, skal du klikke på knappen **Opgave** i nederste venstre hjørne. Vælg derefter **Indstillinger**, klik på **Sprog**, og vælg mellem indstillingerne.

## Relateret indhold

* [Administration af lister][6]
* [Administration af dokumentskabeloner][7]
* [GDPR-personbeskyttelsesindstillinger][8]
* [Systemindstillinger og videomøder][9]
* [Import af firmaer, personer, og produkter][3]

<!-- Referenced links -->
[1]: ../user-management/learn/index.md
[2]: ../../../assets/downloads/configuration-preparation-document.pdf
[3]: ../import/learn/index.md
[4]: ../../sale/learn/sales-guides.md
[5]: ../../project/learn/index.md
[6]: ../lists/learn/index.md
[7]: ../../document/templates/learn/index.md
[8]: ../../security/privacy/learn/implementation-guide.md
[9]: ../preferences/learn/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/project-guide.png
