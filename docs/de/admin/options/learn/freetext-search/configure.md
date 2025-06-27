---
uid: help-de-freetext-search-configure
title: Suchkriterien festlegen
description: Suchkriterien festlegen
author: Bergfrid Dias
date: 03.24.2023
keywords: Volltext, Suchen
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Legen Sie Suchkriterien für eine Volltextsuche fest

Sie können Suchkriterien für Einzelwörter (zum Beispiel *Peter*) und Phrasen aus mehreren Wörtern (zum Beispiel *Oliver Peter Gruber*) festlegen.

1. [!include[Go to freetext search tab](../includes/goto-freetext.md)]

1. Überprüfen Sie, ob die [Volltextsuche aktiviert ist][1].

1. Wählen Sie für **Operator für Einzelwortsuche** eine der folgenden Optionen aus:

    * **Beginnt mit**: Hier kann eine Suche nach *pet* beispielsweise *Peter* und *Peterson* ergeben.
    * **Enthält**: Hier kann eine Suche nach *pet* beispielsweise *Peter* und *Peterson* ergeben.
    * **Exakte Übereinstimmung**: Hier kann eine Suche nach *Peter* nur das Ergebnis *Peter* ergeben.

    > [!NOTE]
    > Die Option **Exakte Übereinstimmung** benötigt beim Suchen die wenigsten Ressourcen, während die Option **Enthält** sehr ressourcenintensiv ist.

1. Wählen Sie für **Operator für Mehrwortsuche** eine der folgenden Optionen aus:
    * **Beginnt mit**: hier kann eine Suche nach *pet* beispielsweise *Peter Nielsen* ergeben.
    * **Enthält**: Hier kann eine Suche nach *pet* die Ergebnisse *Oliver Peter Gruber* und *Ludwig Peterson* ergeben.
    * **Exakte Übereinstimmung**: Nur eine Suche nach *Oliver Peter Nielsen* ergibt auch *Oliver Peter Nielsen* als Suchergebnis.

    > [!NOTE]
    > Bei der Suche nach Phrasen, die aus mehreren Wörtern bestehen, werden alle Wörter zusammen gesucht.

<!-- Referenced links -->
[1]: enable.md

<!-- Referenced images -->
