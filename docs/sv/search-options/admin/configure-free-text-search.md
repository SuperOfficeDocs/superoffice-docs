---
uid: help-sv-settings-free-text-search
title: Konfigurera fritextsökning
description: Konfigurera fritextsökning
keywords: fritextsökning
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: sv
redirect_from:
  - /sv/admin/options/learn/freetext-search/enable
  - /sv/admin/options/learn/freetext-search/configure
  - /sv/admin/options/learn/freetext-search/index
  - /sv/search-options/admin/index
---

# Konfigurera fritextsökning

Med funktionen fritextsökning i SuperOffice CRM kan användarna söka efter text i hela programmet. Detta är text som de själva har lagt in i databasen, till exempel företagsnamn, avdelningar och text från fönstren Kontakt och Dokument.

Du kan definiera exakt hur detta ska fungera i SuperOffice CRM på fliken **Fritextsökning** under Inställningar och underhåll.

## Inaktivera fritextsökning (lokalt)

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Avmarkera **Aktivera fritextsökning**.

Som standard är fritextsökning aktiverad, men om organisationen vill spara systemresurser som används för att uppdatera fritextindexet vid nya poster kan du avmarkera **Aktivera fritextsökning**. Då inaktiveras fältet fritextsökning i SuperOffice CRM onsite. Obs: fritextsökning kan inte inaktiveras för online-/cloud-versioner.

## Ange sökkriterier för en fritextsökning

Du kan ange sökkriterier i form av både enskilda ord (till exempel *Peter*) och fraser som består av flera ord (till exempel *Oliver Peter Nielsen*).

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Kontrollera att fritextsökning är aktiverad.

1. Välj något av följande för **Sökkriterium för ett ord**:

    * **Börjar med**: en sökning på *pet* ger sökträffarna *Peter* och *Peterson*.
    * **Innehåller**: en sökning på *eter* ger sökträffarna *Peter* och *Peterson*.
    * **Exakt matchning**: en sökning på *Peter* ger bara sökträffen *Peter*.

    > [!NOTE]
    > Alternativet **Exakt matchning** är det minst resurskrävande vid sökning, medan alternativet **Innehåller** är det mest resurskrävande.

1. Välj något av följande för **Sökkriterium för flera ord**:
    * **Börjar med**: en sökning på *pet* ger sökträffen *Peter Nielsen*.
    * **Innehåller**: en sökning på *pet* ger sökträffarna *Oliver Peter Nielsen* och *Alan Peterson*.
    * **Exakt matchning**: endast en sökning på *Oliver Peter Nielsen* ger sökträffen *Oliver Peter Nielsen*.

    > [!NOTE]
    > När du söker efter fraser som består av flera ord görs en sökning efter alla ord tillsammans.

## Relaterat innehåll

* [Lägga till stoppord][3]
* [Återskapa fritextindex][4]

<!-- Referenced links -->
[3]: stopwords.md
[4]: regenerate-index.md

<!-- Referenced images -->
