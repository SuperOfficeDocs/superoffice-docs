---
uid: help-sv-freetext-search-configure
title: Ange sökkriterier
description: Ange sökkriterier
author: Bergfrid Dias
date: 03.24.2023
keywords: fritext, söka
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
---

# Ange sökkriterier för en fritextsökning

Du kan ange sökkriterier i form av både enskilda ord (till exempel *Peter*) och fraser som består av flera ord (till exempel *Oliver Peter Nielsen*).

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Kontrollera att [fritextsökning är aktiverad][1].

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

<!-- Referenced links -->
[1]: enable.md

<!-- Referenced images -->
