---
uid: help-de-settings-free-text-search
title: Volltextsuche konfigurieren
description: Volltextsuche konfigurieren
keywords: Volltextsuche
author: digitaldiina
date: 10.17.2025
version: 11.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
index: true
language: de
redirect_from:
  - /de/admin/options/learn/freetext-search/enable
  - /de/admin/options/learn/freetext-search/configure
  - /de/admin/options/learn/freetext-search/index
  - /de/search-options/admin/index
---

# Volltextsuche konfigurieren

Mit der Funktion Volltextsuche in SuperOffice CRM können Benutzer die gesamte Anwendung nach Text durchsuchen. Dies gilt für Text, den die Benutzer selbst in die Datenbank eingefügt haben, wie zum Beispiel Firmennamen, Abteilungen und Text aus den Ansichten Person und Dokument.

Über die Registerkarte **Volltextsuche** in Einstellungen und Verwaltung können Sie die Volltextsuche in SuperOffice CRM genau steuern.

## Deaktivieren Sie die Volltextsuche (Vor Ort)

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Deaktivieren Sie das Kontrollkästchen **Volltextsuche ermöglichen**.

Standardmäßig ist die Volltextsuche aktiviert. Wenn Ihr Unternehmen Systemressourcen sparen möchte, die für die Aktualisierung des Volltextindex bei neuen Einträgen verwendet werden, können Sie das Kontrollkästchen **Volltextsuche aktiviert** deaktivieren. Dadurch wird das Feld für die Volltextsuche in SuperOffice CRM onsite deaktiviert. Die Freitextsuche kann nicht für online-/cloud-Versionen deaktiviert werden.

## Legen Sie Suchkriterien für eine Volltextsuche fest

Sie können Suchkriterien für Einzelwörter (zum Beispiel *Peter*) und Phrasen aus mehreren Wörtern (zum Beispiel *Oliver Peter Gruber*) festlegen.

1. [!include[Go to freetext search tab](includes/goto-freetext.md)]

1. Überprüfen Sie, ob die Volltextsuche aktiviert ist.

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

## Verwandte Inhalte

* [Stoppwörter hinzufügen][3]
* [Volltextindex neu generieren][4]

<!-- Referenced links -->
[3]: stopwords.md
[4]: regenerate-index.md

<!-- Referenced images -->
